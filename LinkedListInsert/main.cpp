

/*
You are given the pointer to the head node of a linked list and an integer to add to the list.
Create a new node with the given integer. Insert this node at the tail of the linked list and
return the head node. The given head pointer may be null, meaning that the initial list is empty.
*/

#include <list>
#include <iostream>

struct Node
{
	int data;
	Node* next;
};

/*
You’re given the pointer to the head node of a linked list, an integer to add to the list and the
position at which the integer must be inserted. Create a new node with the given integer, insert
this node at the desired position and return the head node. A position of 0 indicates head, a position
of 1 indicates one node away from the head and so on. The head pointer given may be null meaning that the initial list is empty.
*/
Node* InsertatPosition(Node* head, int data, int position)
{
	Node* newNode = new Node{ data, nullptr };
	if (head == nullptr)
	{
		return newNode;
	}
	if(position == 0)
	{
		newNode->next = head;
		return newNode;
	}
	
	Node* headCopy = head;
	Node* previous = nullptr;
	for (int i = 0; i < position; i++)
	{
		if (head->next != nullptr)
		{
			previous = head;
			head = head->next;
		}
	}
	previous->next = newNode;
	newNode->next = head;
	return headCopy;
}
/*
You’re given the pointer to the head node of a linked list and an integer to add to the list.
Create a new node with the given integer, insert this node at the head of the linked list and
return the new head node. The head pointer given may be null meaning that the initial list is empty.
*/
Node* InsertAtHead(Node *head, int data)
{
	if (head == nullptr)
	{
		return new Node{ data, nullptr };
	}

	Node* newHead = new Node{ data, head };
	return newHead;
}

Node* InsertAtTail(Node* head, int data)
{
	if (head == nullptr)
	{
		return head = new Node{ data, nullptr };
	}
	Node* headCopy = head;
	while (head != nullptr)
	{
		if (head->next == nullptr)
		{
			Node* newNode = new Node{ data, nullptr };
			head->next = newNode;
			return headCopy;
		}
		head = head->next;
	}
}

void Cleanup(Node* head)
{
	if (head == nullptr)
	{
		return;
	}
	std::list<Node*> nodeList;
	nodeList.emplace_front(head);
	while (head->next != nullptr)
	{
		nodeList.emplace_back(head->next);
		head = head->next;
	}
	for each(Node* node in nodeList)
	{
		delete node;
	}

}

/*
You’re given the pointer to the head node of a linked list and the position of a node to delete. 
Delete the node at the given position and return the head node. A position of 0 indicates head, a 
position of 1 indicates one node away from the head and so on. The list may become empty after you delete the node.
*/
Node* Delete(Node* head, int position)
{
	if(position == 0)
	{
		if(head->next == nullptr)
		{
			return nullptr;
		}
		return head->next;
	}

	Node* headCopy = head;
	Node* previous = nullptr;
	for(int i = 0; i < position; i++)
	{
		previous = head;
		head = head->next;
	}

	previous->next = head->next;
	delete head;
	return headCopy;

}

/*
You’re given the pointer to the head node of a linked list. Change the next pointers of the
nodes so that their order is reversed. The head pointer given may be null meaning that the initial list is empty.
*/
Node* Reverse(Node* head)
{
	Node* reversed = nullptr;
	while (head != nullptr)
	{
		if (reversed == nullptr)
		{
			reversed = new Node{ head->data, nullptr };
		}
		else
		{
			reversed = new Node{ head->data, reversed };
		}
		head = head->next;
	}
	return reversed;
}

void Print(Node* head)
{
	if (head == nullptr)
	{
		return;
	}
	while(head != nullptr)
	{
		std::cout << head->data << std::endl;
		head = head->next;
	}
}

/*
You are given the pointer to the head node of a linked list and you need to print all its elements
in reverse order from tail to head, one element per line. The head pointer may be null meaning that 
the list is empty - in that case, do not print anything!
*/
void ReversePrint(Node* head)
{
	Node* reversed = Reverse(head);
	Print(reversed);
	Cleanup(reversed);
}

/*
You’re given the pointer to the head nodes of two linked lists. Compare the data in the nodes of the linked 
lists to check if they are equal. The lists are equal only if they have the same number of nodes and corresponding 
nodes contain the same data. Either head pointer given may be null meaning that the corresponding list is empty.
*/
int CompareLists(Node* headA, Node* headB)
{
	if(headA == nullptr && headB == nullptr)
	{
		return 1;
	}
	if(headA == nullptr || headB == nullptr)
	{
		return 0;
	}

	while(headA != nullptr && headB != nullptr)
	{
		if(headA->data != headB->data)
		{
			return 0;
		}
		
		headA = headA->next;
		headB = headB->next;
	}
	
	//if not same state, not equal
	if(headA != nullptr || headB != nullptr)
	{
		return 0;
	}

	return 1;
}

void main()
{
	Node* head = new Node{ 0, nullptr };
	head = InsertAtTail(head, 1);
	head = InsertAtTail(head, 2);
	head = InsertAtHead(head, -1);
	head = InsertatPosition(head, 10, 0);
	head = Delete(head, 2);

	Print(head);
	ReversePrint(head);
	Cleanup(head);
	
	system("pause");
}