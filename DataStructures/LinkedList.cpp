#include "LinkedList.h"

LinkedList::LinkedList()
{
	_head = new Node();
}

LinkedList::~LinkedList()
{ 
	
	while(_head != nullptr)
	{
		Node* previous = _head;
		_head = _head->next;
		delete previous;
	}
	delete _head;
}


void LinkedList::Insert(int value)
{
	Node* newNode = new Node();
	newNode->data = value;
	newNode->next = _head->next;
	_head->next = newNode;
}

void LinkedList::Delete()
{
	if(_head->next == nullptr)
	{
		return;
	}
	_head->next = _head->next->next;
}

void LinkedList::Reverse()
{
	Node* previous = nullptr;
	Node* current = _head->next;
	Node* next;

	while (current != nullptr)
	{
		next = current->next;
		current->next = previous;
		previous = current;
		current = next;
	}
	_head->next = previous;
}

std::string LinkedList::ToString()
{
	std::ostringstream convert;
	Node* current = _head->next;
	while (current != nullptr)
	{
		convert << current->data << std::endl;
		current = current->next;
	}
	return convert.str();
}
