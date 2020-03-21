// ConsoleApplication5.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
	const int n = 10;
	double m[n]{ 1, 2, 5, 6, -1, 4, 5, 5, -8, -10 };
	int indlast;
	double sum = 0;


	for (int i = n - 1; i > 0; i--)
	{
		if (m[i] > 0)
		{
			indlast = i;
			i = 0;
		}
	}
	for (int i = 0; i < indlast; i++)
	{
		sum += m[i];
	}
	for (int i = 0; i < n; i++)
	{
		cout << m[i] << " ";
	}
	cout << endl;
	cout << sum;
}
