#include "stdafx.h"
#include "CppUnitTest.h"
#include "..\DataStructures\ArrayList.h"
#include "..\DataStructures\LinkedList.h"
#include "..\DataStructures\DoubleLinkedList.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace DataStructuresTesting
{
	TEST_CLASS(DoubleLinkedListTests)
	{
		
	public:
		TEST_METHOD(InsertFirst)
		{

			DataStructures::DoubleLinkedList list = DataStructures::DoubleLinkedList();
			list.InsertFirst(1);
			list.InsertFirst(2);
			list.InsertFirst(3);
			Assert::AreEqual(std::string("3\n2\n1\n"), list.ToStringForward());
			Assert::AreEqual(std::string("1\n2\n3\n"), list.ToStringReverse());
		}

		TEST_METHOD(InsertLast)
		{

			DataStructures::DoubleLinkedList list = DataStructures::DoubleLinkedList();
			list.InsertLast(3);
			list.InsertLast(2);
			list.InsertLast(1);
			Assert::AreEqual(std::string("3\n2\n1\n"), list.ToStringForward());
			Assert::AreEqual(std::string("1\n2\n3\n"), list.ToStringReverse());
		}

		TEST_METHOD(DeleteFirst)
		{

			DataStructures::DoubleLinkedList list = DataStructures::DoubleLinkedList();
			list.InsertLast(3);
			list.InsertLast(2);
			list.InsertLast(1);

			list.DeleteFirst();
			Assert::AreEqual(std::string("2\n1\n"), list.ToStringForward());
			Assert::AreEqual(std::string("1\n2\n"), list.ToStringReverse());
		}

		TEST_METHOD(DeleteLast)
		{

			DataStructures::DoubleLinkedList list = DataStructures::DoubleLinkedList();
			list.InsertLast(3);
			list.InsertLast(2);
			list.InsertLast(1);

			list.DeleteLast();
			Assert::AreEqual(std::string("3\n2\n"), list.ToStringForward());
			Assert::AreEqual(std::string("2\n3\n"), list.ToStringReverse());
		}
	};
	
	TEST_CLASS(LinkedListUnitTests)
	{
	public:
		TEST_METHOD(Insert)
		{
			LinkedList list = LinkedList();
			list.Insert(10);
			list.Insert(30);
			list.Insert(20);
			Assert::AreEqual(std::string("20\n30\n10\n"), list.ToString());
		}
		TEST_METHOD(Delete)
		{
			LinkedList list = LinkedList();
			list.Insert(10);
			list.Insert(30);
			list.Insert(20);

			list.Delete();
			Assert::AreEqual(std::string("30\n10\n"), list.ToString());
		}

		TEST_METHOD(Reverse)
		{
			LinkedList list = LinkedList();
			list.Insert(10);
			list.Insert(30);
			list.Insert(20);

			list.Reverse();
			Assert::AreEqual(std::string("10\n30\n20\n"), list.ToString());
		}
	};

	TEST_CLASS(ArrayListUnitTests)
	{
	public:

		TEST_METHOD(ToStringwithValues)
		{
			int foo[4]{ 1,2,3,4 };
			ArrayList list(4, foo);
			std::string result = list.ToString();
			Assert::AreEqual(std::string("1\n2\n3\n4\n"), result);
		}

		TEST_METHOD(GetLength)
		{
			int foo[4]{ 1,2,3,4 };
			ArrayList list(4, foo);
			Assert::AreEqual(4, list.GetLength());

			ArrayList list2(5);
			Assert::AreEqual(5, list2.GetLength());
		}

		TEST_METHOD(Insert)
		{
			int foo[4]{ 1,2,3,5 };
			ArrayList list(4, foo);
			list.Insert(3, 4);
			Assert::AreEqual(std::string("1\n2\n3\n4\n5\n"), list.ToString());
			Assert::AreEqual(5, list.GetLength());
		}

		TEST_METHOD(Delete)
		{
			int foo[4]{ 1,2,3,4 };
			ArrayList list(4, foo);
			list.Delete(2);
			Assert::AreEqual(std::string("1\n2\n4\n"), list.ToString());
			Assert::AreEqual(3, list.GetLength());
		}

		TEST_METHOD(Search)
		{
			int foo[5]{ 1,2,3,4,5 };
			ArrayList list(5, foo);
			int three = list.Search(3);
			int ten = list.Search(10);
			Assert::AreEqual(2, three);
			Assert::AreEqual(-1, ten);
		}

		TEST_METHOD(Update)
		{
			int foo[5]{ 1,2,3,4,5 };
			ArrayList list(5, foo);
			list.Update(0, 5);
			list.Update(1, 4);
			list.Update(2, 3);
			list.Update(3, 2);
			list.Update(4, 1);
			Assert::AreEqual(std::string("5\n4\n3\n2\n1\n"), list.ToString());
		}

	};
}