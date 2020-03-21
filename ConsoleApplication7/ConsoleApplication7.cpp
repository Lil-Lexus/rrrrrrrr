// ConsoleApplication7.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
	const int s = 5;
	const int c = 10;
	double m[s][c]
	{
		{2, 4, 5, 1, 7, 8, 9, 4, 1, 1},
		{3, 1, 5, 2, 1, 4, 6, 2, 1, 0},
		{2, 6, 1, 7, 3, 5, 2, 6, 4, 3},
		{2, 5, 2, 4, 6, 4, 2, 1, 9, 1},
		{1, 7, 4, 3, 8, 5, 3, 3, 9, 1}
	};
	int k = 3;
	double sum = 0;
	double prz = 1;
	for (int i = 0; i < s; i++)
	{
		cout << endl;
		for (int j = 0; j < c; j++)
		{
			cout << m[i][j] << " ";
		}
	}
	cout << endl << k << endl;
	for (int j = 0; j < c; j++)
	{
		for (int i = 0; i < s; i++)
		{
			if (j == k)
			{
				prz = prz * m[i][j];
				sum += m[i][j];
			}
		}
	}
	cout << sum << endl;
	cout << prz;
	return 0;
}

