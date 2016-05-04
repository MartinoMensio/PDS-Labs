#include "Libro.h"



Libro::Libro(std::string str)
{
	titolo = str;
}


Libro::~Libro()
{
}

Contenitore * Libro::aggiungi(Testo *t)
{
	// uso il dynamic_cast così sono sicuro che non fa casino (funziona sia per upcast che downcast)
	Capitolo* p = dynamic_cast<Capitolo*>(t);
	if (p == NULL)
	{
		// in caso di errore il dynamic cast restituisce NULL
		throw exception("aggiungi chiamata con tipo non valido!");
	}
	// inserimento in fondo alla lista del puntatore (no duplicazione oggetto, solo copia del puntatore)
	listaCapitoli.push_back(p);
	// ritorno this per permettere il chaining di operazioni
	return this;
}

string Libro::trova(string key)
{
	string result = string("");
	int i = 0;
	for each (Capitolo* p in listaCapitoli)
	{
		// indice del capitolo "user-friendly", cioè con valore iniziale 1
		i++;
		// cerca nel capitolo
		string temp = p->trova(key);
		if (temp.compare("") != 0)
		{
			// stringa trovata: aggiungere numero capitolo e risultato del capitolo
			result += "/" + to_string(i) + "/" + temp;
			// solo la prima occorrenza
			break;
		}
	}
	return result;
}

Libro * Libro::creaLibro(string titolo)
{
	Libro* p = new Libro(titolo);
	return p;
}
