#include <iostream>
#include <vector>

using namespace std;

/*
subarray of array a to be contiguos block of a's elements having length less than or equal to the length olf array a.

get subArrays
the length of the sub = master.size() -> 1
loop through master -> startIndex
	if startIndex + length -1 < master.size()
		loop from 0 to length - 1 -> currentIndex
			add master[startIndex + currentIndex] to sub list
	add sub list to result list

*/

vector<vector<int>> GetSubArrays(vector<int> &masterList)
{
	vector<vector<int>> result;
	int subLength = masterList.size();
	while (subLength >= 1)
	{
		for (int startIndex = 0; startIndex < masterList.size(); ++startIndex)
		{
			if (startIndex + subLength > masterList.size())
			{
				break;
			}
			vector<int> subList; 
			for (int currentIndex = 0; currentIndex < subLength; ++currentIndex)
			{
				
				subList.push_back(masterList[startIndex + currentIndex]);
			}
			result.push_back(subList);
		}
		--subLength;
	}

	return result;
}

int ListSum(vector<int> &list)
{
	int sum = 0;
	for (auto num : list)
	{
		sum += num;
	}
	return sum;
}

vector<vector<int>> SubSumLessOrEqual(vector<vector<int>> &subList, int k)
{
	vector<vector<int>> resultList;

	for (auto list : subList)
	{
		if (ListSum(list) <= k)
		{
			resultList.push_back(list);
		}
	}
	return resultList;
}

int maxLength(vector<int> a, int k)
{
	vector<vector<int>> subLists = GetSubArrays(a);
	vector<vector<int>> lessThanLists = SubSumLessOrEqual(subLists, k);
	int max = 0;
	for (auto list : lessThanLists)
	{
		if (list.size() > max)
		{
			max = list.size();
		}
	}
	return max;
}



int main()
{
	vector<int> masterList{ 1,2,3 };
	cout << maxLength(masterList, 4);
	system("pause");
	return 1;
}