/*
You are given an infinite 2-d grid with the bottom left cell referenced as (1,1). All the cells contain a value of zero initially. Let's play a game?

The game consists of N steps wherein each step you are given two integers a and b. The value of each of the cells in the co-ordinate (u, v) satisfying 1 ≤ u ≤ a and 1 ≤ v ≤ b, is increased by 1. After N such steps, if X is the largest number amongst all the cells in the rectangular board, can you print the number of X's in the board?

 = minX + miny - 1 (to account for 1,1 is same for both)

*/
#include <iostream>
#include <vector>
#include <math.h>
#include "TestCase.h"

#define TESTING
#define TEST_PATH "Data/test07.txt"
#define BIG_NUMBER unsigned long
using namespace std;

struct Vector
{
	BIG_NUMBER x = 0, y = 0;
	Vector(BIG_NUMBER a_x, BIG_NUMBER a_y)
	{
		x = a_x;
		y = a_y;
	}

};

void LoadData(int &steps, std::vector<Vector> &stepList)
{
#ifdef TESTING
	std::string path(TEST_PATH);
	HackerRank::TestCase tCase(path);
	std::cout << "File Loaded: " << tCase.FileLoaded << std::endl;
	steps = std::stoi(tCase.GetWord());
	std::cout << steps << " steps.\n";
#else
	cin >> steps;
#endif

	for (int i = 0; i < steps; i++)
	{
		BIG_NUMBER x, y;
#ifdef TESTING
		x = std::stod(tCase.GetWord());
		y = std::stod(tCase.GetWord());
#else
		cin >> x >> y;
#endif
		stepList.push_back(Vector(x,y));
	}
}

Vector GetMin(const vector<Vector> &stepList)
{
	BIG_NUMBER minX = UINT32_MAX, minY=UINT32_MAX;
	for (auto step : stepList)
	{
		if (step.x < minX)
		{
			minX = step.x;
		}
		if (step.y < minY)
		{
			minY = step.y;
		}
	}
	return Vector(minX, minY);
}

int main()
{
	int stepCount;
	vector<Vector> stepList;
	LoadData(stepCount, stepList);
	Vector minXY = GetMin(stepList);
	BIG_NUMBER result = minXY.x * minXY.y;


#ifdef TESTING
	cout << "The result is: ";
#endif
	cout << result << endl;
	system("pause");
	return 1;
}