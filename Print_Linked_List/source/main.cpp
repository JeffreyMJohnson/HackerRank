#include <iostream>


struct Node
{
	int data = 0;
	Node* nextNode = nullptr;

	Node(int a_data, Node* a_nextNode)
	{
		data = a_data;
		nextNode = a_nextNode;
	}
};

void Print(Node* rootNode)
{
	if(rootNode == nullptr)
	{
		return;
	}
	Node* currentNode = rootNode;
	do
	{
		std::cout << currentNode->data <<std::endl;
		currentNode = currentNode->nextNode;
	} while (currentNode->nextNode != nullptr);
}

int main()
{
	Node node3 = Node(3, nullptr);
	Node node2 = Node(2, &node3);
	Node node1 = Node(1, &node2);
	Node root = Node(0, &node1);
	
	Print(&root);
	system("pause");
	return 0;
}