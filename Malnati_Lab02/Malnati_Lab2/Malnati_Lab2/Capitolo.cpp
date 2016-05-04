#include "Capitolo.h"


Capitolo::Capitolo()
{
	// non serve fare niente
}

Capitolo::~Capitolo()
{
}

Contenitore * Capitolo::aggiungi(Testo *t)
{
	// uso il dynamic_cast così sono sicuro che non fa casino (funziona sia per upcast che downcast)
	Paragrafo* p = dynamic_cast<Paragrafo*>(t);
	if (p == NULL)
	{
		// in caso di errore il dynamic cast restituisce NULL
		throw exception("aggiungi chiamata con tipo non valido!");
	}
	// inserimento in fondo alla lista del puntatore (no duplicazione oggetto, solo copia del puntatore)
	listaParagrafi.push_back(p);
	// dato che il tipo di ritorno è Contenitore*, se ritorno this posso permettere il chaining di operazioni
	// ad esempio c2->aggiungi(p3)->aggiungi(p4);
	return this;
}

string Capitolo::trova(string key)
{
	string result = string("");
	int i = 0;
	for each (Paragrafo* p in listaParagrafi)
	{
		// indice del paragrafo "user-friendly", cioè con valore iniziale 1
		i++;
		// cerca nel paragrafo
		string temp = p->trova(key);
		if (temp.compare("") != 0)
		{
			// stringa trovata: aggiungere numero paragrafo e risultato del paragrafo
			result += to_string(i) + "/" + temp;
			// solo la prima occorrenza
			break;
		}
	}
	return result;
}

Capitolo * Capitolo::creaCapitolo()
{
	Capitolo* p = new Capitolo();
	return p;
}
