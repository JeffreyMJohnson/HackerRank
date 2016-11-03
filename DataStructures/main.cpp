#include "ArrayList.h"
unsigned int ColortoHex(unsigned short r, unsigned short g, unsigned short b, unsigned short a)
{
	return 0;
}

void Test()
{
	//const unsigned int mask = 0x000000FF;
	

}


void main()
{
	int foo[4]{ 1,2,3,4 };
	ArrayList list(4, foo);
	std::string result = list.ToString();
	std::cout << result;
}