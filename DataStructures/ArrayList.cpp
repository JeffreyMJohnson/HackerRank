#include "ArrayList.h"

ArrayList::ArrayList(int size)
{
	_length = size;
	_list = new int[_length];	
}
ArrayList::ArrayList(int size, int * values)
{
	_length = size;
	_list = new int[_length];
	for(int i = 0; i < _length; i++)
	{
		_list[i] = *values++;
	}

}
ArrayList::~ArrayList()
{
	delete _list;
}

int ArrayList::GetLength()
{
	return _length;
}
std::string ArrayList::ToString()
{
	std::ostringstream convert;
	for(int i = 0; i < _length; i++)
	{
		convert << _list[i] << std::endl;
	}
	return convert.str();
}

void ArrayList::Insert(int index, int value)
{
	int currentIndex = _length;
	Resize(_length + 1);
	while(currentIndex >= index)
	{
		_list[currentIndex + 1] = _list[currentIndex];
		currentIndex--;
	}
	_list[index] = value;
}

void ArrayList::Delete(int index)
{
	int currentIndex = index + 1;
	while(currentIndex < _length)
	{
		_list[currentIndex - 1] = _list[currentIndex];
		currentIndex += 1;
	}
	Resize(_length - 1);
}

int ArrayList::Search(int value)
{
	for(int i = 0; i < _length; i++)
	{
		if(_list[i] == value)
		{
			return i;
		}
	}
	return -1;
}

void ArrayList::Update(int index, int value)
{
	_list[index] = value;
}

void ArrayList::Resize(int size)
{
	int oldLength = _length;
	int* oldList = _list;
	_length = size;
	_list = new int[_length];
	int test = std::min(oldLength, _length);
	for(int i = 0; i < test; i++)
	{
		_list[i] = oldList[i];
	}
	delete oldList;
}
