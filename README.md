# Programming Problems from [HackerRank](http://www.hackerrank.com/jefjohms)
## C# Solutions
#### [Hash Tables: Ransom Note](https://www.hackerrank.com/challenges/ctci-ransom-note)
A kidnapper wrote a ransom note but is worried it will be traced back to him. He found a 
magazine and wants to know if he can cut out whole words from it and use them to create 
an untraceable replica of his ransom note. The words in his note are case-sensitive and 
he must use whole words available in the magazine, meaning he cannot use substrings or 
concatenation to create the words he needs.

Given the words in the magazine and the words in the ransom note, print Yes if he can 
replicate his ransom note exactly using whole words from the magazine; otherwise, 
print No.
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/HashTables_RansomNote/Program.cs)

***
#### [Stacks: Balanced Brackets](https://www.hackerrank.com/challenges/ctci-balanced-brackets)
A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs 
to the left of a closing bracket (i.e., ), ], or }) of the exact same type. There are three types of 
matched pairs of brackets: [], {}, and ().

A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. 
For example, {[(])} is not balanced because the contents in between { and } are not balanced. The 
pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses 
encloses a single, unbalanced closing square bracket, ].

By this logic, we say a sequence of brackets is considered to be balanced if the following 
conditions are met:
* It contains no unmatched brackets.
* The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.

Given `n` strings of brackets, determine whether each sequence of brackets is balanced. If a string is 
balanced, print YES on a new line; otherwise, print NO on a new line.

* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Stacks_BalancedBrackets/Program.cs)

***
#### [Strings: Making Anagrams](https://www.hackerrank.com/challenges/ctci-making-anagrams)
Alice is taking a cryptography class and finding anagrams to be very useful. We consider two 
strings to be anagrams of each other if the first string's letters can be rearranged to form 
the second string. In other words, both strings must contain the same exact letters in the 
same exact frequency For example, bacdc and dcbac are anagrams, but bacdc and dcbad are not.

Alice decides on an encryption scheme involving two large strings where encryption is 
dependent on the minimum number of character deletions required to make the two strings 
anagrams. Can you help her find this number?

Given two strings, `a` and `b`, that may or may not be of the same length, determine the minimum 
number of character deletions required to make  and  anagrams. Any characters can be deleted 
from either of the strings.
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Making_Anagrams/Program.cs)

***
#### [Arrays: Left Rotation](https://www.hackerrank.com/challenges/ctci-array-left-rotation)
A left rotation operation on an array of size `n` shifts each of the array's 
elements `1` unit to the left. For example, if `2` left rotations are
performed on array `[1, 2, 3, 4, 5]`, then the array would become 
`[3, 4, 5, 1, 2]`.

Given an array of `n` integers and a number, `d`, perform `d`
left rotations on the array. Then print the updated array as a single line of space-separated
integers.
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/LeftShift/Program.cs)

***
#### [Lonely Integer](https://www.hackerrank.com/challenges/lonely-integer)
Consider an array of `n` integers, `A = [a(0), a(1), ... a(n-1)]` , where all but one of 
the integers occur in pairs. In other words, every element in `A` occurs exactly twice except 
for one unique element.

Given `A`, find and print the unique element.
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/LonelyInteger/Program.cs)

***
#### [Palindrome Index](https://www.hackerrank.com/challenges/palindrome-index)
Given a string, `S`, of lowercase letters, determine the index of the character whose removal 
will make `S` a palindrome. If `S` is already a palindrome or no such character exists, then 
print `-1`. There will always be a valid solution, and any correct answer is acceptable. For 
example, if  "bcbc", we can either remove 'b' at index `0` or 'c' at index `3`.
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/PalindromeIndex/Program.cs)

***
#### [CamelCase](https://www.hackerrank.com/challenges/camelcase)
Alice wrote a sequence of words in CamelCase as a string of letters, `s`, having the following 
properties:
1. It is a concatenation of one or more words consisting of English letters.
2. All letters in the first word are lowercase.
3. For each of the subsequent words, the first letter is uppercase and rest of the letters are lowercase. 
 
Given `s`, print the number of words in `s` on a new line.
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/CamelCase/Program.cs)

***
#### [PanGrams](https://www.hackerrank.com/challenges/pangrams)
Roy wanted to increase his typing speed for programming contests. So, his friend advised him 
to type the sentence "The quick brown fox jumps over the lazy dog" repeatedly, because it 
is a pangram. (Pangrams are sentences constructed by using every letter of the alphabet at 
least once.)

After typing the sentence several times, Roy became bored with it. So he started to look 
for other pangrams.

Given a sentence `s`, tell Roy if it is a pangram or not.
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Pangrams/Program.cs)

***
#### [RectangularGames](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Pangrams/Program.cs)
You are given an infinite 2-d grid with the bottom left cell referenced as (1,1). All the cells contain 
a value of zero initially. Let's play a game?

The game consists of **N** steps wherein each step you are given two integers **a** and **b**. The value 
of each of the cells in the co-ordinate (u, v) satisfying 1 ≤ u ≤ a and 1 ≤ v ≤ b, is increased by 1. 
After **N** such steps, if **X** is the largest number amongst all the cells in the rectangular board, 
can you print the number of **X**'s in the board?
* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/RectangularGame2/Program.cs)

***
#### [Angry Professor](https://www.hackerrank.com/challenges/angry-professor)
A Discrete Mathematics professor has a class of `N` students. Frustrated with their lack of discipline, 
he decides to cancel class if fewer than `K` students are present when class starts.

Given the arrival time of each student, determine if the class is canceled.

* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/LazyProfessor/Program.cs)

***
***

## C++ Solutions
#### [Linked Lists: Detect a Cycle](https://www.hackerrank.com/challenges/ctci-linked-list-cycle)
A linked list is said to contain a *cycle* if any node is visited more than once while
traversing the list.

Complete the function provided in the editor below. It has one parameter: a pointer 
to a *Node* object named `head` that points to the head of a linked list. Your 
function must return a boolean denoting whether or not there is a cycle in the list. 
If there *is* a cycle, return *true*; otherwise, return *false*.

* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/LinkedList_DetectACycle_CPP/main.cpp)

***
#### [Operator Overloading](https://www.hackerrank.com/challenges/operator-overloading)
Classes define new types in C++. Types in C++ not only interact by means of constructions 
and assignments but also via operators. For example:
```
int a=2, b=1, c;
c = b + a;
```
The result of variable c will be 3. Similarly, classes can also perform operations using 
[operator overloading](https://www.hackerrank.com/external_redirect?to=https://msdn.microsoft.com/en-us/library/5tk49fh2.aspx)
. Operators are overloaded by means of operator functions, which are regular functions with 
special names. Their name begins with the operator keyword followed by the operator sign 
that is overloaded. The syntax is:

 ```type operator sign (parameters) { /*... body ...*/ }```

 You are given a main() function which takes a set of inputs to create two matrices and prints the 
 result of their addition. You need to write the class *Matrix* which has a member *a* of type 
 *vector\<vector\<int\>\>*. You also need to write a member function to overload the operator **+**. 
 The function's job will be to add two objects of *Matrix* type and return the resultant *Matrix*.

 * [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Operator_Overload/main.cpp)

***
#### [Preprocessor Solution](https://www.hackerrank.com/challenges/preprocessor-solution)
Preprocessor directives are lines included in the code preceded by a hash sign (#). These lines are 
directives for the preprocessor. The preprocessor examines the code before actual compilation of code 
begins and resolves all these directives before any code is actually generated by regular statements.

```
#define INF 10000000
if( val == INF) {
//Do something
}
After the preprocessor has replaced the directives, the code will be
if( val == 10000000) { //Here INF is replaced by the value with which it's defined.
//Do something
}
```

You can also define function macros which have parameters.

```
#define add(a, b) a + b
int x = add(a, b);

The second statement after the preprocessor has replaced the directives will be:
int x = a + b;
```

To know more about preprocessor directives, you can go to this 
[link](https://www.hackerrank.com/external_redirect?to=http://www.cplusplus.com/doc/tutorial/preprocessor/)

You're spending your afternoon at a local school, teaching kids how to code. You give them a simple task: 
find the difference between the maximum and minimum values in an array of integers.

After a few hours, they came up with some promising source code. Unfortunately, it doesn't compile! Since 
you don't want to discourage them, you decide to make their code work without modifying it by adding 
preprocessor macros.

Review the locked stub code in your editor and add the preprocessor macros necessary to make the code work.

* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Preprocessor_solution/main.cpp)

***
#### [Truck Tour](https://www.hackerrank.com/challenges/truck-tour)
Suppose there is a circle. There are `N` petrol pumps on that circle. Petrol pumps are numbered `0` to
`(N - 1)`  (both inclusive). You have two pieces of information corresponding to each of the petrol pump: 
(1) the amount of petrol that particular petrol pump will give, and (2) the distance from that petrol pump 
to the next petrol pump.

Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at any of the 
petrol pumps. Calculate the first point from where the truck will be able to complete the circle. Consider 
that the truck will stop at each of the petrol pumps. The truck will move one kilometer for each litre of 
the petrol.

* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Truck_Tour/main.cpp)

***
#### Tree Problems
##### [PreOrder Traversal](https://www.hackerrank.com/challenges/tree-preorder-traversal)
Complete the *preOrder* function in your editor below, which has `1` parameter: a pointer to the root of 
a binary tree. It must print the values in the tree's preorder traversal as a single line of 
space-separated values.

##### [PostOrder Traversal](https://www.hackerrank.com/challenges/tree-postorder-traversal)
Complete the *postOrder* function in your editor below, which has `1` parameter: a pointer to the root of 
a binary tree. It must print the values in the tree's postorder traversal as a single line of 
space-separated values.

##### [InOrder Traversal](https://www.hackerrank.com/challenges/tree-inorder-traversal)
Complete the *inOrder* function in your editor below, which has `1` parameter: a pointer to the root of 
a binary tree. It must print the values in the tree's inorder traversal as a single line of 
space-separated values.

##### [Height of a Binary Tree](https://www.hackerrank.com/challenges/tree-inorder-traversal)
The height of a binary tree is the number of edges between the tree's root and its furthest leaf. This 
means that a tree containing a single node has a height of `0`.

Complete the *getHeight* function provided in your editor so that it returns the height of a binary tree. 
This function has a parameter, `root`, which is a pointer to the root node of a binary tree.

* [Solution](https://github.com/JeffreyMJohnson/HackerRank/blob/master/Trees/main.cpp)

***
#### Linked List Problems
##### [Print the Elements of a Linked List](https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list)
##### [Insert a Node at the Tail of a Linked List](https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list)
##### [Insert a node at the head of a linked list](https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list)
##### [Insert a node at a specific position in a linked list](https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list)
##### [Delete a Node](https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list)
##### [Print in Reverse](https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list-in-reverse)
##### [Reverse a linked list](https://www.hackerrank.com/challenges/reverse-a-linked-list)
##### [Compare two linked lists](https://www.hackerrank.com/challenges/compare-two-linked-lists)

* [Solutions](https://github.com/JeffreyMJohnson/HackerRank/blob/master/LinkedListInsert/main.cpp)
