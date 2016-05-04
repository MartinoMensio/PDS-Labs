#include "myHeap.h"

#include <stdlib.h>
#include <stdio.h>

#define UNITY_DIM 128   //bytes

struct heap_s {
    size_t size;
    void *storage;
    free_block *freelist;
    // table of allocated
    allocated_block_t *table;
    int allocated_block_n;
    heap_policy_t policy;
};

typedef struct {
    free_block_node *next;
    size_t dim;
    // maybe add some padding to reach block_dim?
} free_block_node;

typedef struct {
    void *block;
    size_t unity_n; // the number of units used
    size_t size;    // the size in bytes
} allocated_block_t;


// functions to handle free_block_node
free_block_node *free_block_init(void *p, free_block_node *next, size_t dim) {
    free_block_node *b = (free_block_node *)p;
    b->dim = dim;
    b->next = next;
    return b;
}
/*
// free list management (heap conscious)
free_block_node *freelist_init(heap_t h) {
    free_block_node *b = (free_block_node *) h.storage;
    b->dim = h.size;
    b->next = NULL;
    h.freelist = b;
    return b;
}*/
/*
// TODO delete != insert
// insertion is in order in freelist
void *freelist_delete(heap_t h, free_block_node *b) {
    free_block_node *p, *q;
    if(h.freelist > b) {
        // if lower than beginning of the list, insert at the beginning
        b.next = h.freelist;
        h.freelist = b;
    } else {
        for(p = h.freelist; p != NULL; p = p->next) {
            if(p->next > b || p->next == NULL) {
                q = p->next;
                p->next = b;
                b->next = q;
                break;
            }
        }
    }
}*/

// find the freeblock preceding an address
free_block_node *freelist_find_prev(heap_t h, void *b) {
    free_block_node *p;
    if(h.freelist >= b) {
        return NULL;
    }
    for(p = h.freelist; p != NULL; p = p->next) {
        if(p->next >= b || p->next == NULL) {
            return p;
        }
    }
}

// find the first freeblock following an address
free_block_node *freelist_find_next(heap_t h, void *b) {
    free_block_node *p;
    for(p = h.freelist; p != NULL; p = p->next) {
        if(p->next > b || p->next == NULL) {
            return p->next;
        }
    }
}
/*
// TODO crap
void freelist_insert(heap_t h, free_block_node *b) {


    // find previous block
    free_block_node *previous = freelist_find_prev(b);
    // find following block
    free_block_node *following = freelist_find_next(b);
    int p_free = 0, f_free = 0;
    if(previous != NULL && previous + previous->dim == b) {
        p_free = 1;
    }
    if(b + b->dim == following) {
        f_free = 1;
    }
    if(!p_free && !f_free) {
        // both the preceding and following blocks are occupied or NULL
        // simply add a new free node in the list
        freelist_insert(h, b); // MAYBE better to
    } else if(!p_free && f_free) {
        // preceding block is occupied (or NULL), following is free
        if(previous == NULL) {
            // need to update the pointer to list, because following(modified) is the first node
            h.freelist = b;
        } else {
            // update the pointer
            previous.next = b;
        }
        b.dim = following.size
    }
}*/

heap_t *heapCreate (size_t heapSize) {
    heap_t *h;
    h = malloc(sizeof(heap_s));
    if(h == NULL) {
        return NULL;
    }
    storage = malloc(heapSize);
    if(storage == NULL) {
        free(h);
        return NULL;
    }
    // init the freelist
    //freelist_init(h);
    h.freelist = (free_block_node *) h.storage;
    h.freelist->dim = h.size;
    h.freelist->next = NULL;
    //
    h.table = malloc(heapSize / UNITY_DIM * sizeof(allocated_block_t));
    h.allocated_block_n = 0;
    h.policy = first_fit;
}

void heapDestroy (heap_t *h) {
    free(h.storage);
    free(h.table);
}

void *heapAlloc (heap_t *h, size_t size) {
    // = find space following the policy (and possible that there is not enough)
    void *foundAddr = NULL;
    foundAddr = findSpace(size); // returns a void *pointer
    if (foundAddr == NULL) {
        // no space found
        return NULL;
    }

    free_block_node *prev, *next;
    prev = freelist_find_prev(foundAddr);
    next = freelist_find_next(foundAddr);
    if((void *)prev == foundAddr) {
        // the foundAddr is at the beginning of prev block
    }
    // and remove from freelist (only a block) or split in two regions (plus the occupied central region)
    // insert in table of used
    // return
}

void heapFree (heap_t *h, void *p) {
    // remove from table
    // update freelist inserting (or updating in case of contiguity) a node:
    // four cases
    // 1: p is surrounded by allocated regions --> simply insert in freelist
    // 2: p starts after an allocated region but is followed by free region --> remove the following from freelist and insert new of the cumulated size
    // 3: p starts after free region and is followed by an allocated region --> update in freelist the preceding space adding the dimension freed
    // 4: p surrounded by free regions --> remove following region and update preceding adding freed dimension and following region size
}

void heapSetPolicy (heap_t *h, heap_policy_t policy) {

}

void heapDefrag (heap_t *h) {

}

void *heapNewPointer (heap_t *h, void *p) {

}

void heapDefragClose (heap_t *h) {

}
