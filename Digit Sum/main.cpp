/*
Implement a program, which given an integer n, computes the sum of its digits.

If a negative number is given, the function should work as if it was positive.

For example, if n is 1325132435356, the digit's sum is 43. If n is -10, the sum is 1 + 0 = 1.

In the test cases for this task we will have that -2^63 < n < 2^63.
*/

int digit_sum(long long number)
{
	int sum = 0;
	long long num = number < 0 ? number * -1 : number;
	while (num >= 10)
	{
		int digit = num % 10;
		num = num / 10;
		sum += digit;
	}
	sum += num;
	return sum;
}

int main()
{
	int sum = digit_sum(-1325132435356);


	return 0;
}