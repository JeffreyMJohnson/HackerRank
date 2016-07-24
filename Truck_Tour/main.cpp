

/*Suppose there is a circle. There are  petrol pumps on that circle. Petrol pumps are numbered 0 to N-1 (both inclusive).
You have two pieces of information corresponding to each of the petrol pump: (1) the amount of petrol that particular
petrol pump will give, and (2) the distance from that petrol pump to the next petrol pump.

Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at any of the petrol pumps.
Calculate the first point from where the truck will be able to complete the circle. Consider that the truck will stop
at each of the petrol pumps. The truck will move one kilometer for each litre of the petrol.

Pump
	double qty
	double distance

Truck
	qty
	stops at each pump
	moves 1km/litre

Calculate the first point from where the truck will be able to complete the circle
complete the circle = pump.distance * n
total fuel needed = total distance
fuel needed per stop = current stop distance

loop with counter 0 - number of pumps
	startPump <- loop counter
	pumpsVisited <- 0
	truckFuel <-0
	currentPump <- startPump
	loop while pumpsVisited < total pump count
		if truckFuel + current pump qty < current pump distance
			truckFuel <- add current pump qty
			truckFuel <- sub current pump distance
			increment pumpsVisisted
			increment currentPump
			if currentPump equals total pumps
				currentPump <- 0
		else
			break;
	if pumpsVisited equal to total pumps
		answer <- startPump
		break;



*/
#include <iostream>
#include <vector>

#include "TestCase.h"

#define TESTING
#define TEST_PATH "Data/test01.txt"

struct Pump
{
	double qty = 0;
	double distance = 0;
	Pump(double a_qty, double a_distance)
	{
		qty = a_qty;
		distance = a_distance;
	}
};

void Destroy(std::vector<Pump*> *pumps)
{
	for (int i = 0; i < pumps->size(); i++)
	{
		Pump *ptr = pumps->at(i);
		delete ptr;
		ptr = nullptr;
	}
	delete pumps;
	pumps = nullptr;
}



void LoadData(int& qtyPumps, std::vector<Pump*> *pumps)
{
#ifdef TESTING
	std::string path(TEST_PATH);
	HackerRank::TestCase tCase(path);
	std::cout << "File Loaded: " << tCase.FileLoaded << std::endl;
	qtyPumps = std::stoi(tCase.GetWord());
	std::cout << qtyPumps << " pumps.\n";
#else
	cin >> qtyPumps;
#endif

	for (int i = 0; i < qtyPumps; i++)
	{
		double qty, distance;
#ifdef TESTING
		qty = std::stod(tCase.GetWord());
		distance = std::stod(tCase.GetWord());
#else
		cin >> qty >> distance;
#endif
		Pump *p = new Pump{ qty, distance };
		pumps->push_back(p);
	}
}


int main()
{
	using namespace std;
	double truckQty = 0;

	int qtyPumps;
	vector<Pump*> *pumps = new vector<Pump*>();

	LoadData(qtyPumps, pumps);

	int result = -1;

	for (int i = 0; i < pumps->size(); i++)
	{
		int startPump = i;
		int pumpsVisited = 0;
		int currentIndex = i;
		truckQty = 0;
		while (pumpsVisited < pumps->size())
		{
			Pump currentPump = *pumps->at(currentIndex);
			if(truckQty + currentPump.qty > currentPump.distance)
			{
				truckQty += currentPump.qty;
				truckQty -= currentPump.distance;
				pumpsVisited++;
				currentIndex++;
				if(currentIndex == pumps->size())
				{
					currentIndex = 0;
				}
			}
			else
			{
				break;
			}

		}
		if(pumpsVisited == pumps->size())
		{
			result = startPump;
			break;
		}
	}
#ifdef TESTING
	cout << "The result is: ";
#endif
	cout << result << endl;

	Destroy(pumps);
	system("pause");
}
