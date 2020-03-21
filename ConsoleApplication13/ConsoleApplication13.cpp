// ConsoleApplication13.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <fstream>
#include <windows.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
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
		cout << "Введите 1 для записи" << endl;
		cout << "Введите 2 для считывания" << endl;
		cin >> var;
		if (var == 1)
		{
			SetConsoleCP(1251); // чёто с кодировкой для символов кириллицы
			cin >> s;
			fs << s << "\n";
			SetConsoleCP(866); // возврат обратно
		}
		if (var == 2)
		{
			while (! fs.eof()) // end of file пока файл не закончится
			{
				s = ""; // затирка данных
				fs >> s;
				cout << s << endl;
			}
		}
	}
	fs.close();
	return 0;
}
