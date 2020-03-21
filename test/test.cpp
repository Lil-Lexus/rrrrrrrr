// test.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "");
	string path = "myFile.txt";

	fstream fs;
	fs.open(path, fstream::in | fstream::out | fstream::app); // чтение и запись файла | - битовое или app - чтобы файлы не стирались а дописывались далее
	if (!fs.is_open())
	{
		cout << "Ошибка открытия файла!" << endl;
	}
	else
	{
		string s;
		int var;
		cout << "Файл открыт!" << endl;
        cout << "Введите 1 для записи";
		cout << "Введите 2 для считывания";
		cin >> var;
		if (var == 1)
		{
			cin >> s;
			fs << s << "\n";		
		}
		if (var == 2)
		{

		}
	}
	fs.close();
	return 0;
}
