#pragma once

#include <queue>
#include <mutex>
#include <condition_variable>

template <class T>	// classe generica
class BlockingQueue {
public:
	BlockingQueue(int size);
	bool preleva(T& res);
	void inserisci(T val);
	int	conteggio();
	void chiudi();
	virtual ~BlockingQueue();
private:
	unsigned int maxSize;
	std::queue<T> queue;
	std::mutex mutex;
	bool isOpen;
	std::condition_variable cv_full;
	std::condition_variable cv_empty;
};



template <class T> BlockingQueue<T>::BlockingQueue(int size) {
	if (size <= 0) {
		throw std::exception("Size <= 0");
	}
	std::lock_guard<std::mutex> l(mutex);
	this->maxSize = size;
	this->isOpen = true;
}

template <class T> bool BlockingQueue<T>::preleva(T & res) {
	std::unique_lock<std::mutex> l(mutex);
	while (queue.size() == 0) {
		if (!isOpen) {
			// in questo caso la coda è vuota e chiusa
			return false;
		}
		cv_empty.wait(l);
	}
	
	if (!isOpen) {
		// se la coda è chiusa ma ci sono ancora elementi, si preleva e si ritorna false
		res = queue.front();
		queue.pop();
		cv_full.notify_one();
		return false;
	}
	// qua la coda è aperta e con elementi
	res = queue.front();
	queue.pop();
	cv_full.notify_one();
	return true;
}

template <class T> void BlockingQueue<T>::inserisci(T val) {
	std::unique_lock<std::mutex> l(mutex);
	if (!isOpen) {
		throw std::exception("queue is closed"); // per evitare di entrare nel while
	}
	while (queue.size() >= maxSize) {
		if (!isOpen) {
			throw std::exception("queue is closed");	// lanciare subito, senza altre wait
		}
		cv_full.wait(l);
	}
	if (!isOpen) {
		throw std::exception("queue is closed");	// dopo il risveglio ci starebbe nella coda ma è stata chiusa
	}
	queue.push(val);
	cv_empty.notify_one();
}

template <class T> int BlockingQueue<T>::conteggio() {
	std::lock_guard<std::mutex> l(mutex);
	return queue.size();
}

template <class T> void BlockingQueue<T>::chiudi() {
	std::lock_guard<std::mutex> l(mutex);
	isOpen = false;
	// svegliare tutti
	cv_empty.notify_all();
	cv_full.notify_all();
}


template <class T> BlockingQueue<T>::~BlockingQueue() {
	std::unique_lock<std::mutex> l(mutex);
}

