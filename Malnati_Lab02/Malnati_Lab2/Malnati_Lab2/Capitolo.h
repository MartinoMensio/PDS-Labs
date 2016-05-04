#pragma once
#include "Contenitore.h"
#include "Paragrafo.h"
class Capitolo :
	public Contenitore
{
protected:
	Capitolo();
public:
	// distruttore virtual perché classe ha metodi virtual
	virtual ~Capitolo();
	virtual Contenitore* aggiungi(Testo*);
	virtual string trova(string);
	// metodo factory
	static Capitolo* creaCapitolo();
private:
	// lista dei paragrafi. Per sottolineare che ho solo elementi di tipo Paragrafo,
	// uso questo tipo, ma dovrebbe andare bene anche list<Testo*>
	// non serve inizializzare la lista, automatico
	list<Paragrafo*> listaParagrafi;
};

