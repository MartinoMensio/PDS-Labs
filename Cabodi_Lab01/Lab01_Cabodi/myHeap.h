#ifndef MYHEAP_H_INCLUDED
#define MYHEAP_H_INCLUDED

/*------------------------------------------------------------------------*/
/* myheap.h */
typedef enum {
  first_fit,
  best_fit,
  worst_fit
} heap_policy_t;

typedef struct heap_s heap_t;

heap_t *heapCreate (size_t heapSize);
void heapDestroy (heap_t *h);
void *heapAlloc (heap_t *h, size_t size);
void heapFree (heap_t *h, void *p);
void heapSetPolicy (heap_t *h, heap_policy_t policy);
void heapDefrag (heap_t *h);
void *heapNewPointer (heap_t *h, void *p);
void heapDefragClose (heap_t *h);
/*------------------------------------------------------------------------*/

#endif // MYHEAP_H_INCLUDED
