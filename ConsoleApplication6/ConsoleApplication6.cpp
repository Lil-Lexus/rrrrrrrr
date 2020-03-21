// ConsoleApplication6.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
	const int n = 10;
	double m[n]{};
	double m1[n]{};
	double m2[n]{};
	for (int i = 0; i < n; i++)
	{
		m[i] = rand() % 10;
		m1[i] = rand() % 10;
	}
	for (int i = 0; i < n; i++)
	{
		cout << m[i] << " ";
	}
	cout << endl;
	for (int i = 0; i < n; i++)
	{
		cout << m1[i] << " ";
	}
	for (int i = 0; i < n; i++)
	{
		if (m[i] > m1[i])
		{
			m2[i] = m[i];
		}
		else
		{
			m2[i] = m1[i];
		}
	}
	cout << endl;
	for (int i = 0; i < n; i++)
	{
		cout << m2[i] << " ";
	}
}