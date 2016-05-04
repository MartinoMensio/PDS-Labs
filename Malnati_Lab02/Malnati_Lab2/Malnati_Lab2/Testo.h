#pragma once
#include "stdafx.h"

// utile per non scrivere sempre std::
using namespace std;

class Testo
{
protected:
	Testo() {};
public:
	// se una classe ha un metodo virtual, meglio che il distruttore sia virtual
	virtual ~Testo() {};
	// metodo virtuale astratto
	virtual string trova(string) = 0;
};

