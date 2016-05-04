#pragma once
#include "Testo.h"
class Paragrafo :
	public Testo
{
protected:
	Paragrafo(string);
public:
	// distruttore virtual perché classe ha metodi virtual
	virtual ~Paragrafo();
	// memorizza il contenuto del paragrafo
	string testo;
	// factory method
	static Paragrafo* creaParagrafo(string testo);
	// funzione di ricerca
	virtual string trova(string);
};

