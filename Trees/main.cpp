#include <iostream>
#include <algorithm>

/* you only have to complete the function given below.
Node is defined as

struct node
{
int data;
node* left;
node* right;
};

*/

struct node
{
	int data;
	node* left;
	node* right;
};

/*
Complete the preOrder function in your editor below, which has  parameter: a pointer 
to the root of a binary tree. It must print the values in the tree's preorder traversal 
as a single line of space-separated values.

Algorithm Preorder(tree)
1. Visit the root.
2. Traverse the left subtree, i.e., call Preorder(left-subtree)
3. Traverse the right subtree, i.e., call Preorder(right-subtree)
*/
void preOrder(node *root)
{
	if(root == nullptr)
	{
		return;
	}

	std::cout << root->data << ' ';

	preOrder(root->left);

	preOrder(root->right);
}

/*
Complete the postOrder function in your editor below, which has  parameter: a pointer to 
the root of a binary tree. It must print the values in the tree's preorder traversal as 
a single line of space-separated values.

Algorithm Postorder(tree)
1. Traverse the left subtree, i.e., call Postorder(left-subtree)
2. Traverse the right subtree, i.e., call Postorder(right-subtree)
3. Visit the root.
*/
void postOrder(node *root)
{
	if(root == nullptr)
	{
		return;
	}

	postOrder(root->left);

	postOrder(root->right);

	std::cout << root->data << ' ';
}

/*
Algorithm Inorder(tree)
1. Traverse the left subtree, i.e., call Inorder(left-subtree)
2. Visit the root.
3. Traverse the right subtree, i.e., call Inorder(right-subtree)
*/
void inOrder(node *root)
{
	if(root == nullptr)
	{
		return;
	}

	inOrder(root->left);

	std::cout << root->data << ' ';

	inOrder(root->right);
}

/*
Get the height of left sub tree, say leftHeight
Get the height of right sub tree, say rightHeight
Take the Max(leftHeight, rightHeight) and add 1 for the root and return
Call recur­sively.
*/

int height(node * root)
{
	if(root == nullptr)
	{
		return 0;
	}
	int lefHeight = height(root->left);
	int rightHeight = height(root->right);

	return 1 + std::max(lefHeight, rightHeight);
	
}


void main()
{
	node* seven = new node{ 7, nullptr, nullptr };
	node* six = new node{ 6, nullptr, seven };
	node* one = new node{ 1, nullptr, nullptr };
	node* four = new node{ 4, nullptr, nullptr };
	node* five = new node{ 5, four, six };
	node* two = new node{ 2, one, nullptr };
	node* root = new node{ 3, two, five };

	preOrder(root);
	std::cout << std::endl;
	postOrder(root);
	std::cout << std::endl;
	inOrder(root);
	std::cout << "\nheight: " << height(root);
	system("pause");

	delete one;
	delete two;
	delete four;
	delete five;
	delete six;
	delete root;

}