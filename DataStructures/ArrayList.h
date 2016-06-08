#pragma once
#include <iostream>
#include <sstream>
#include <algorithm>

class ArrayList
{
public:
	ArrayList(int size);
	ArrayList(int size, int* values);
	~ArrayList();

	int GetLength();
	std::string ToString();

	//Inserts the given value at the given index.
	void Insert(int index, int value);
	//Deletes the value at the given index and shifts values to the right of index to the left by one.
	void Delete(int index);
	//Returns the index of the value matching the given one, otherwise returns -1;
	int Search(int value);
	//update value at given index with given value.
	void Update(int index, int value);
private:
	int _length = 0;
	int* _list = nullptr;

	void Resize(int size);
};
