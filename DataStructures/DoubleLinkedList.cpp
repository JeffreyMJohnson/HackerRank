#include "DoubleLinkedList.h"

DataStructures::DoubleLinkedList::DoubleLinkedList()
{
	std::ostringstream convert;
	Node* current = _tail;
}

DataStructures::DoubleLinkedList::~DoubleLinkedList()
{
	while (_head != nullptr)
	{
		Node* previous = _head;
		_head = _head->next;
		delete previous;
	}
	delete _head;
}

std::string DataStructures::DoubleLinkedList::ToStringForward()
{
	std::ostringstream convert;
	Node* current = _head;
	while (current != nullptr)
	{
		convert << current->data << std::endl;
		current = current->next;
	}
	return convert.str();
}

std::string DataStructures::DoubleLinkedList::ToStringReverse()
{
	std::ostringstream convert;
	Node* current = _tail;
	while(current != nullptr)
	{
		convert << current->data << std::endl;
		current = current->previous;
	}
	return convert.str();
}

void DataStructures::DoubleLinkedList::InsertFirst(int value)
{
	Node* newNode = new Node();
	newNode->data = value;

	if(_head == nullptr)
	{
		_head = newNode;
		_tail = newNode;
		return;
	}

	_head->previous = newNode;
	newNode->next = _head;
	_head = newNode;
}

void DataStructures::DoubleLinkedList::InsertLast(int value)
{
	Node* newNode = new Node();
	newNode->data = value;
	if(_tail == nullptr)
	{
		_tail = newNode;
		_head = newNode;
		return;
	}
	_tail->next = newNode;
	newNode->previous = _tail;
	_tail = newNode;

}

void DataStructures::DoubleLinkedList::DeleteFirst()
{
	if (_head == nullptr)
	{
		return;
	}
	Node* prev = _head;
	_head = _head->next;
	_head->previous = nullptr;
	delete prev;
}

void DataStructures::DoubleLinkedList::DeleteLast()
{
	if(_tail == nullptr)
	{
		return;
	}
	Node* next = _tail;
	_tail = _tail->previous;
	_tail->next = nullptr;
	delete next;
}
