#include <string>
#include <iostream>
#include <cstdio>
#include <list>
#include <future>
#include <vector>
#include <string>
#include <sstream>
#include <cpprest\http_client.h>
#include <cpprest\filestream.h>
#include <Windows.h>

using namespace utility;                    // Common utilities like string conversions
using namespace web;                        // Common features like URIs.
using namespace web::http;                  // Common HTTP functionality
using namespace web::http::client;          // HTTP client features
using namespace concurrency::streams;

void searchAll(std::vector<std::string> parts);
web::json::value search(std::string str);
std::wstring s2ws(const std::string& s);
std::string ws2s(const std::wstring& s);

int main(int argc, char *argv[]) {

	std::vector<std::string> parts;
	// main loop
	while (1) {
		std::cout << "Insert a sentence" << std::endl;
		std::string line;
		// read a line from console
		std::getline(std::cin, line);
		if (line.compare("#exit") == 0) {
			break;
		}
		std::stringstream ss(line);
		// clear the parts from previous loops
		parts.clear();
		// split the line read into parts divided by spaces
		while (ss.good()) {
			std::string tok;
			std::getline(ss, tok, ' ');
			parts.push_back(tok);
		}
		// this function does all the work
		searchAll(parts);
	}

	return 0;
}

void searchAll(std::vector<std::string> parts) {

	std::vector<std::future<web::json::value>> futures;
	std::vector<web::json::object> resultsObj;

	for each (std::string str in parts) {
		// add to the list of futures
		futures.push_back(async(search, str));
	}
	// then wait for all of them and store results
	for (unsigned int i = 0; i < futures.size(); i++) {
		// the future can have generated some exceptions, or also reading the values from json can cause exceptions
		try {
			// get on the future to wait this thread, and get the result as_object
			// to have web::json::object instead of web::json::value
			web::json::object res = futures[i].get().as_object();
			// web::json:object properties can be reas as an associative array: using as index a string (U macro is for using std::wstring instead of std::string)
			// the results array for each query is stored in res.query.search
			web::json::array array = res[U("query")][U("search")].as_array();
			// only take the search results (title, size) and save them
			for each (web::json::value el in array) {
				resultsObj.push_back(el.as_object());
			}
		}
		catch (const std::exception& e) {
			std::cout << e.what();
		}

	};
	//sort
	// sort on the size ascending of the result page
	std::sort(resultsObj.begin(), resultsObj.end(), [](web::json::object a, web::json::object b) {
		return a[U("size")].as_integer() < b[U("size")].as_integer();
	});

	// print out something (size and title of the result)
	for each (web::json::object o in resultsObj) {
		std::string title = ws2s(o[U("title")].as_string());
		int size = o[U("size")].as_integer();
		std::cout << "page length:" << size << "\ttitle: " << title << std::endl;
	}
}

// each query will have 10 results by default
web::json::value search(std::string str) {

	// Create http_client to send the request.
	http_client client(U("https://it.wikipedia.org/w/"));

	// Build request URI and start the request.
	uri_builder builder(U("/api.php"));
	builder.append_query(U("action"), U("query"));
	builder.append_query(U("format"), U("json"));
	builder.append_query(U("list"), U("search"));
	builder.append_query(U("utf8"), U("1"));

	// need to convert from std::string to std::wstring
	std::wstring r = s2ws(str);

	builder.append_query(U("srsearch"), r);
	builder.append_query(U("srwhat"), U("text")); // to match also on page content
	builder.append_query(U("srinfo"), U("totalhits")); // total number of hits
	builder.append_query(U("srprop"), U("size")); // size of each page

	pplx::task<web::json::value> requestTask = client.request(methods::GET, builder.to_string())

		// Handle response headers arriving.
		.then([=](http_response response) {
		//printf("Received response status code:%u\n", response.status_code());

		return response.extract_json();

	});

	// wait for the task completion
	web::json::value v = requestTask.get();
	// convert to a json object
	web::json::object o = v.as_object();
	// read property o.query.searchinfo.totalhits
	int totalhits = o[U("query")][U("searchinfo")][U("totalhits")].as_integer();
	// and print it out
	std::string res = "-Query for " + str + ": " + std::to_string(totalhits) + " pages found\n";
	std::cout << res;

	return v;

	// if some exception (e.g. timeout expired) is raised, it will be captured in searchAll loop
}

// those functions are copy/paste http://codereview.stackexchange.com/questions/419/converting-between-stdwstring-and-stdstring
std::wstring s2ws(const std::string& s) {
	int len;
	int slength = (int)s.length() + 1;
	len = MultiByteToWideChar(CP_ACP, 0, s.c_str(), slength, 0, 0);
	std::wstring r(len, L'\0');
	MultiByteToWideChar(CP_ACP, 0, s.c_str(), slength, &r[0], len);
	return r;
}

std::string ws2s(const std::wstring& s) {
	int len;
	int slength = (int)s.length() + 1;
	len = WideCharToMultiByte(CP_ACP, 0, s.c_str(), slength, 0, 0, 0, 0);
	std::string r(len, '\0');
	WideCharToMultiByte(CP_ACP, 0, s.c_str(), slength, &r[0], len, 0, 0);
	return r;
}

// results for query "prova": (https://it.wikipedia.org/w/api.php?action=query&format=json&list=search&utf8=1&srsearch=prova&srwhat=text&srinfo=totalhits&srprop=size)
/*
{
  "batchcomplete": "",
  "continue": {
	"sroffset": 10,
	"continue": "-||"
  },
  "query": {
	"searchinfo": {
	  "totalhits": 33078
	},
	"search": [
	  {
		"ns": 0,
		"title": "Prova",
		"size": 893
	  },
	  {
		"ns": 0,
		"title": "Prova (diritto)",
		"size": 2316
	  },
	  {
		"ns": 0,
		"title": "Prova speciale",
		"size": 1352
	  },
	  {
		"ns": 0,
		"title": "Mezzo di ricerca della prova",
		"size": 924
	  },
	  {
		"ns": 0,
		"title": "Sven Nys",
		"size": 28561
	  },
	  {
		"ns": 0,
		"title": "Prova a incastrarmi - Find Me Guilty",
		"size": 2552
	  },
	  {
		"ns": 0,
		"title": "La prova",
		"size": 875
	  },
	  {
		"ns": 0,
		"title": "Affidamento in prova al servizio sociale",
		"size": 4180
	  },
	  {
		"ns": 0,
		"title": "Nazionale di ciclismo su strada dell'Italia",
		"size": 76436
	  },
	  {
		"ns": 0,
		"title": "Prova (ordinamento penale italiano)",
		"size": 13079
	  }
	]
  }
}
*/