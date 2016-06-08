#include "ArrayList.h"

void main()
{
	int foo[4]{ 1,2,3,4 };
	ArrayList list(4, foo);
	std::string result = list.ToString();
	std::cout << result;
}