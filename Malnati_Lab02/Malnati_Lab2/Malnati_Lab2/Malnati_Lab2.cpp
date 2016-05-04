// Malnati_Lab2.cpp : definisce il punto di ingresso dell'applicazione console.
//

#include "stdafx.h"
#include "Libro.h"
/*
Inclusione degli header:
Libro.h include: Contenitore.h (perché classe base) e Capitolo.h (perché ha la lista di capitoli)
Capitolo.h include: Contenitore.h (classe base) e Paragrafo.h (perché ha la lista dei paragrafi)
Contenitore.h include: Testo.h (classe base)
Paragrafo.h include: Testo.h (classe base)
Testo.h include: stdafx.h (dove le librerie usate sono inserite)(dovrebbe servire per generare headers precompilati)
stdafx.h include le librerie

*/


int main()
{
	Paragrafo* p1 = Paragrafo::creaParagrafo("alfa");
	Paragrafo* p2 = Paragrafo::creaParagrafo("beta");
	Paragrafo* p3 = Paragrafo::creaParagrafo("gamma");
	Paragrafo* p4 = Paragrafo::creaParagrafo("delta");
	Capitolo* c1 = Capitolo::creaCapitolo();
	Capitolo* c2 = Capitolo::creaCapitolo();
	Libro* l = Libro::creaLibro("Libro I");

	l->aggiungi(c1)->aggiungi(c2);
	c1->aggiungi(p1)->aggiungi(p2);
	c2->aggiungi(p3)->aggiungi(p4);

	cout << l->trova("eta") << endl;
	cout << l->trova("ma") << endl;
	cout << l->trova("prova") << endl;

	// test su aggiunta non valida
	try
	{
		c2->aggiungi(c1);
	}
	catch (const std::exception& ex)
	{
		cout << ex.what() << endl;
	}

	// delete devono essere fatte dal main
	delete(p1);
	delete(p2);
	delete(p3);
	delete(p4);
	delete(c1);
	delete(c2);
	delete(l);
    return 0;
}
