#include <iostream>
#include <vector>
using namespace std;
void StairCase(int n)
{
	
	int numSpace = n - 1;

	for (int i = 0; i < n; i++)
	{
		//whitespace
		for (int whiteCount = 0; whiteCount < numSpace; ++whiteCount)
		{
			cout << ' ';
		}
		//hash
		for (int hashCount = 0; hashCount < n - numSpace; ++hashCount)
		{
			cout << '#';
		}
		cout << endl;
		--numSpace;
	}
}

int sum(vector<int> numbers)
{
	int sum = 0;
	for (int i : numbers)
	{
		sum += i;
	}
	return sum;
}

/*

*/

int main()
{

	std::cout << "how many steps:";
	int n;
	std::cin >> n;
	StairCase(n);
	system("pause");
	return 0;
}