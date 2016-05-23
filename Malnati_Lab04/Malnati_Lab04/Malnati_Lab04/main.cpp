#include "BlockingQueue.h"
#include <future>
#include <iostream>
#include <list>
#include <thread>
#include <assert.h>
#include <string>

BlockingQueue<int> intQ(3);

void producer();
void consumer();

int main(int argc, char** argv) {

	int i;
	bool res;

	std::list<std::future<void>> futures;

	std::cout << "conteggio iniziale: " << intQ.conteggio() << std::endl;

	intQ.inserisci(1);
	intQ.inserisci(2);
	intQ.inserisci(3);
	//intQ.inserisci(4);

	std::cout << "conteggio (1, 2, 3): " << intQ.conteggio() << std::endl;

	res = intQ.preleva(i);
	std::cout << "primo prelievo: " << res << ": " << i << std::endl;

	res = intQ.preleva(i);
	std::cout << "secondo prelievo: " << res << ": " << i << std::endl;

	res = intQ.preleva(i);
	std::cout << "terzo prelievo: " << res << ": " << i << std::endl;

	//res = intQ.preleva(i);

	// creo 4 producer
	for (i = 0; i < 4; i++) {
		futures.push_back(std::async(producer));
	}
	// aspetto un po'
	std::this_thread::sleep_for(std::chrono::milliseconds(5000));
	// creo 4 consumer
	for (i = 0; i < 4; i++) {
		futures.push_back(std::async(consumer));
	}
	// aspetto un po'
	std::this_thread::sleep_for(std::chrono::milliseconds(20000));
	// chiudo la coda
	intQ.chiudi();
	return 0;
	// i futures bloccano l'uscita finchè non terminano
}

void producer() {
	int time;
	int i = 0;
	std::string output;
	try {
		while (true) {
			time = std::rand() % 10;
			std::this_thread::sleep_for(std::chrono::milliseconds(time * 100));
			intQ.inserisci(i);
			// creo prima la stringa da stampare
			output = "inserito " + std::to_string(i) + "\n";
			// output atomico
			std::cout << output;
			i++;
		}
	}
	catch (const std::exception&) {
		std::cout << "eccezione, producer terminato\n";
	}
}

void consumer() {
	int time;
	int i = 0;
	bool res;
	std::string output;

	while (true) {
		time = std::rand() % 10;
		std::this_thread::sleep_for(std::chrono::milliseconds(time * 300));
		res = intQ.preleva(i);
		output = "res: " + std::to_string(res) + " prelevato " + std::to_string(i) + "\n";
		// output atomico
		std::cout << output;
		if (res == false) {
			break;
		}
	}
	std::cout << "consumer terminato perchè niente da consumare e coda chiusa\n";
}