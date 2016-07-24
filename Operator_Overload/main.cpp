#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


/*
You are given a main() function which takes a set of inputs to create two matrices and prints the result of their addition. You need to write the class Matrix which has a member a of type vector<vector<int> >. You also need to write a member function to overload the operator +. The function's job will be to add two objects of Matrix type and return the resultant Matrix.
*/
#include "TestCase.h"
#define TESTING
#define TEST_PATH "data/test1.txt"

class Matrix
{
public:
	vector<vector<int>> a;


};
Matrix operator +(const Matrix &a, const Matrix &b)
{
	Matrix result;
	for (int i = 0; i < a.a.size(); ++i)
	{
		vector<int> rowA = a.a[i];
		vector<int> rowB = b.a[i];
		vector<int> resultRow;

		for (int j = 0; j < rowA.size(); ++j)
		{
			resultRow.push_back(rowA[j] + rowB[j]);
		}
		result.a.push_back(resultRow);
	}

	return result;
}

int main() {
	int cases, k;
#ifdef TESTING
	std::string path(TEST_PATH);
	HackerRank::TestCase tCase(path);
	std::cout << "File Loaded: " << tCase.FileLoaded << std::endl;
	cases = std::stoi(tCase.GetWord());
	std::cout << cases << " cases.\n";
#else
	cin >> cases;
#endif
	for (k = 0; k < cases; k++) {
		Matrix x;
		Matrix y;
		Matrix result;
		int n, m, i, j;
#ifdef TESTING
		n = std::stoi(tCase.GetWord());
		m = std::stoi(tCase.GetWord());
#else
		cin >> n >> m;
#endif
		for (i = 0; i < n; i++) {
			vector<int> b;
			int num;
			for (j = 0; j < m; j++) {
#ifdef TESTING
				num = std::stoi(tCase.GetWord());
#else
				cin >> num;
#endif
				b.push_back(num);
			}
			x.a.push_back(b);
		}
		for (i = 0; i < n; i++) {
			vector<int> b;
			int num;
			for (j = 0; j < m; j++) {
#ifdef TESTING
				num = std::stoi(tCase.GetWord());
#else
				cin >> num;
#endif
				b.push_back(num);
			}
			y.a.push_back(b);
		}
		result = x + y;
		for (i = 0; i < n; i++) {
			for (j = 0; j < m; j++) {
				cout << result.a[i][j] << " ";
			}
			cout << endl;
		}
	}
	system("pause");
	return 0;
}