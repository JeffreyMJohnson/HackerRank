#pragma once
#include <string>
#include <sstream>

struct Node
{
	int data = 0;;
	Node* next = nullptr;
};

class LinkedList
{
public:
	LinkedList();
	~LinkedList();

	//Insert new node with given value in beginning of list.
	void Insert(int value);
	//Delete the first node in list.
	void Delete();

	void Reverse();
	std::string ToString();


private:
	Node* _head = nullptr;
};
