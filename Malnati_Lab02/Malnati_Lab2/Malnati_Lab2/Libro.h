#pragma once
#include "Contenitore.h"
#include "Capitolo.h"
class Libro :
	public Contenitore
{
protected:
	Libro(string);
public:
	// distruttore virtual perché classe ha metodi virtual
	virtual ~Libro();
	string titolo;
	virtual Contenitore* aggiungi(Testo*);
	virtual string trova(string);
	static Libro* creaLibro(string titolo);
private:
	// lista dei capitoli (anche qui avrei potuto usare list<Testo*>)
	list<Capitolo*> listaCapitoli;
};

