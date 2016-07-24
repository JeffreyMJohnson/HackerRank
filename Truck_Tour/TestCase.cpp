#include "TestCase.h"

HackerRank::TestCase::TestCase(std::string& path)
{
	_fileStream = new std::fstream();
	_fileStream->open(path, std::ios::in);
	if(!_fileStream->is_open())
	{
		std::cout << "There was a problem opening the file: " << path;
	}
	else
	{
		FileLoaded = true;
	}
}

HackerRank::TestCase::~TestCase()
{
	if (_fileStream && _fileStream->is_open())
	{
		_fileStream->close();
	}
	delete _fileStream;
}

std::string HackerRank::TestCase::GetWord()
{
	if(!_fileStream->is_open())
	{
		return std::string();
	}
	std::string result;
	*_fileStream >> result;
	return result;
}
