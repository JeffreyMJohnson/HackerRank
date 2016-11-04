#include <iostream>
#include <vector>
#include <algorithm>
/*
Detect a cycle in a linked list. Note that the head pointer may be 'NULL' if 
the list is empty.

A Node is defined as:
struct Node {
int data;
struct Node* next;
}
*/

struct Node {
	int data;
	struct Node* next;
	Node(int a_data, Node* a_next)
	{
		data = a_data;
		next = nullptr;
	}
};


using NodeList = std::vector<Node*>;
using it = NodeList::iterator;

bool has_cycle(Node* head) 
{
	if (head == nullptr)
	{
		return false;
	}
	//add nodes to a list to be searched as you walk list
	NodeList visited;
	visited.push_back(head);
	//if you hit null, can't be circular
	while(head->next != nullptr)
	{
		head = head->next;
		//if circular would be infinite loop so verify haven't
		//visited node
		it searchResult = std::find(visited.begin(), visited.end(), head);
		if (searchResult != visited.end())
		{
			return true;
		}
		else
		{
			visited.push_back(head);
		}
	}
	return false;
}

int main()
{
	Node one(1, nullptr);
	Node two(2, nullptr);
	Node three(3, nullptr);

	std::cout << has_cycle(&one) << std::endl;

	one.next = &two;
	two.next = &three;
	three.next = &two;
	
	std::cout << has_cycle(&one) << std::endl;

	system("pause");
	return 1;
}