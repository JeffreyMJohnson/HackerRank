#pragma once

#ifndef TEST_CASE_H
#define TEST_CASE_H
#include <fstream>
#include <iostream>
#include <string>
namespace HackerRank
{
	class TestCase
	{
	public:
		TestCase(std::string &path);
		~TestCase();
		std::string GetWord();
		bool FileLoaded = false;
	private:
		std::fstream *_fileStream = nullptr;

	};

}
#endif
