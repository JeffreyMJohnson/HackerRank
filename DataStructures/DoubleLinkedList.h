#pragma once
#include <string>
#include <sstream>

namespace DataStructures
{
	struct Node
	{
		int data = -1;
		Node* previous = nullptr;
		Node* next = nullptr;
	};

	class DoubleLinkedList
	{
	public:
		DoubleLinkedList();
		~DoubleLinkedList();

		std::string ToStringForward();
		std::string ToStringReverse();
		void InsertFirst(int value);
		void InsertLast(int value);
		void DeleteFirst();
		void DeleteLast();

	private:
		Node* _head = nullptr;
		Node* _tail = nullptr;
	};

}
