/*
You are given a pointer to the root of a binary search tree and a value to be inserted into the tree. 
Insert this value into its appropriate position in the binary search tree and return the root of the 
updated binary tree. You just have to complete the function.

Return the root of the binary search tree after inserting the value into the tree.

    4
   / \
  2   7
 / \
1   3
*/

#include <iostream>
#include <memory>
#include <list>

using namespace std;



struct node
{
	int data;
	node * left;
	node * right;
};
list<node*> _livePointers;


node* insert(node* root, int value)
{
	if(root->data == value)
	{
		return root;
	}
	if(value < root->data)
	{
		if(root->left != nullptr)
		{
			insert(root->left, value);
		}
		else
		{
			root->left = new node{ value, nullptr, nullptr };
			_livePointers.push_back(root->left);
			return root;
		}
	}
	else
	{
		if(root->right != nullptr)
		{
			insert(root->right, value);
		}
		else
		{
			root->right = new node{ value, nullptr, nullptr };
			_livePointers.push_back(root->right);
			return root;
		}
	}
	return root;
}

void main()
{
	node* one = new node{1, nullptr, nullptr};
	_livePointers.push_back(one);
	node* three = new node{ 3, nullptr, nullptr };
	_livePointers.push_back(three);
	node* two = new node{ 2, one, three };
	_livePointers.push_back(two);
	node* seven = new node{  7, nullptr, nullptr };
	_livePointers.push_back(seven);
	node* root = new node{4, two, seven};
	_livePointers.push_back(root);
	
	root = insert(root, 6);

	for (list<node*>::iterator it = _livePointers.begin(); it != _livePointers.end(); it++)
	{
		delete *it;
	}
	_livePointers.clear();

	system("pause");
}

