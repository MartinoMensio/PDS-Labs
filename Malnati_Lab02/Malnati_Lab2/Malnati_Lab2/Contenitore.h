#pragma once
#include "Testo.h"
class Contenitore :
	public Testo
{
protected:
	Contenitore() {};
public:
	// distruttore virtual perché classe ha metodi virtual
	virtual ~Contenitore() {};
	virtual std::string trova(std::string) = 0;
	virtual Contenitore* aggiungi(Testo*) = 0;
};

