#include "Paragrafo.h"



Paragrafo::Paragrafo(string str)
{
	testo = str;
}


Paragrafo::~Paragrafo()
{
	// non fa niente
	// i paragrafi devono essere rilasciati con la delete nel main
}

Paragrafo * Paragrafo::creaParagrafo(string testo)
{
	// chiama il costruttore
	Paragrafo* p = new Paragrafo(testo);
	// e ritorna il puntatore
	return p;
}

string Paragrafo::trova(string term)
{
	// trovare l'indice in testo dove è presente term
	size_t startpos = testo.find(term);
	if (startpos == string::npos)
	{
		// stringa non trovata (la find restituisce valore string::npos)
		return string("");
	}
	size_t endpos = startpos + term.length();
	// i valori di startpos partono da 0, mentre l'utente si aspetta valori che partono da 1
	// invece per endpos va bene così perché endpos è l'indice del primo carattere dopo il match
	return string(to_string(startpos + 1) + ":" + to_string(endpos));
}
