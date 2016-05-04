/*
** client.c
** 
*/

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#include "myHeap.h"

#define MAXLINELEN 100

typedef struct {
  char **array;
  int num;
  int allocSize;
} strArray_t;

int leggiPagina(heap_t *h, char **page, FILE *fp, int maxR);
void ordinaPagina(char **page, int nr);
void scriviPagina(char **page, FILE *fp, int nr);
void filtraeLiberaPagina(heap_t *h, char **page, int nr, 
                         strArray_t *save, int M);
strArray_t *strArrayInit(heap_t *h, int  initSize);
void strArrayFree(heap_t *h, strArray_t *sarray);
void strArrayPush(heap_t *h, strArray_t *sarray, char *s);
void strArraySort(strArray_t *sarray);
void strArrayPrint(strArray_t *sarray, FILE *fp);

int main (int argc, char *argv[])
{
  char *nameFileIn = argv[1];
  char *nameFileOut = argv[2];
  char *nameFileOut2 = argv[3];
  char **page;
  FILE *fpI, *fpO;
  int i, nr;
  heap_t *heap;
  strArray_t *save;

  int D=atoi(argv[4]), N=atoi(argv[5]), M=atoi(argv[6]);

  printf("input file: %s - output file: %s\n", nameFileIn, nameFileOut);
  printf("input file: %s - output file: %s output file 2\n", 
         nameFileIn, nameFileOut, nameFileOut2);
  printf("D: %d - N: %d - M: %d\n", D, N, M);

  heap = heapCreate(D);

  save = strArrayInit(heap,0); /* inizializza a vuoto */

  page = (char **) heapAlloc (heap, N * sizeof(char *));
  fpI = fopen (nameFileIn, "r");
  fpO = fopen (nameFileOut, "w");
  if (page==NULL || fpI==NULL || fpO==NULL) {
    printf("errore in allocazione memoria o apertura file\n");
    exit (1);
  }

  while ((nr = leggiPagina(heap,page,fpI,N)) > 0) {
    ordinaPagina(page,nr);
    scriviPagina(page,fpO,nr);
    filtraeLiberaPagina(heap,page,nr,save,M);
  } 
  
  fclose(fpI);
  fclose(fpO);
  heapFree(heap,page);

  fpO = fopen (nameFileOut2, "w");
  if (fpO==NULL) {
    printf("errore in apertura file\n");
    exit (1);
  }

  strArraySort(save);
  strArrayPrint(save,fpO);
  fclose(fpO);

  strArrayFree(heap,save);

  heapDestroy (heap);

}

int leggiPagina(heap_t *h, char **page, FILE *fp, int maxR) {
  int nr = 0, len;
  char buf[MAXLINELEN+1];

  for (nr=0; nr<maxR; nr++) {
    if (fgets(buf,MAXLINELEN,fp)==NULL) break;
    /* rimuovi eventuale a-capo */
    len = strlen(buf);
    if (buf[len-1]=='\n') {
      buf[len-1] = '\0';
      len--;
    }
    page[nr] = heapAlloc(h,(len+1)*sizeof(char));
    strcpy(page[nr],buf);
  }
  return nr;
}

void scriviPagina(char **page, FILE *fp, int nr) {
  int i;

  for (i=0; i<nr; i++) {
    fprintf(fp,"%s\n",page[i]);
  }
}

void ordinaPagina(char **page, int nr) {
  /* insertion sort */
  int i, j;
  for (i=1; i<nr; i++) {
    char *xp = page[i];
    for (j=i-1; j>=0 && strcmp(xp,page[j])<0; j--) {
      page[j+1] = page[j];
    }
    page[j+1] = xp;
  }

  printf("PAGINA ORDINATA\n................\n");
  for (i=0; i<nr; i++) {
    printf("%s\n",page[i]);
  }
  printf("................\n");

}

void filtraeLiberaPagina(heap_t *h, char **page, int nr, 
                         strArray_t *save, int M) {
  int i;

  for (i=0; i<nr; i++) {
    if (strlen(page[i])<=M) {
      heapFree(h,page[i]);
    }
    else {
      strArrayPush(h,save,page[i]);
    }
  }
}

strArray_t *strArrayInit(heap_t *h, int initSize) {
  strArray_t *p = heapAlloc(h, sizeof(strArray_t));
  p->array=NULL;
  p->num=0;
  p->allocSize = initSize;
  if (initSize > 0) {
    p->array=heapAlloc(h,initSize*(sizeof(char *)));
  }
  return p;  
}

void strArrayFree(heap_t *h, strArray_t *sarray) {
  if (sarray->allocSize>0) {
    heapFree(h,sarray->array);
  }
  heapFree(h,sarray);
}

void strArrayPush(heap_t *h, strArray_t *sarray, char *s) {
  if (sarray->num+1>=sarray->allocSize) {
    /* rialloca usando malloc */
    int i;
    char **old = sarray->array;
    sarray->allocSize *= 2;
    if (sarray->allocSize==0) sarray->allocSize=2;
    sarray->array = heapAlloc(h,(sarray->allocSize)*(sizeof(char *)));
    if (old!=NULL) {
      for (i=0; i<sarray->num; i++) {
        sarray->array[i] = old[i];
      }
      heapFree(h,old);
    }
  }
  sarray->array[sarray->num++] = s;
}

void strArraySort(strArray_t *sarray) {
  if (sarray->num==0) return;
  ordinaPagina(sarray->array,sarray->num);
}

void strArrayPrint(strArray_t *sarray, FILE *fp) {
  if (sarray->num==0) return;
  scriviPagina(sarray->array,fp,sarray->num);
}





