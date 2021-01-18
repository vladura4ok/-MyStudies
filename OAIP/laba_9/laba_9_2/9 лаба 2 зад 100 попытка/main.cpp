/*
 Формирование, печать, добавление, поиск элементов
*/
#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <stdio.h>
#include <string.h>


using namespace std;

struct student  //Объявляем шаблон структуры
{
  char surname[30];
  char name[30];
  char otch[30];
  char klass[20];
  char bykva[20];
  char ocenka[20];
};

struct student mas[30]; //Объвляем глобальный массив структур (максимально кол-во школьников: 30)
int counter = 0, u = 0;
FILE* F1;

int menu();
void formir();
void pechat();
void dobav();
void poisk();


int main()
{
   while (1) //Бесконечный цикл
  {
    switch (menu())
    {
    case 1:
      formir();
      break;
    case 2:
      pechat();
      break;
    case 3:
      dobav();
      break;
    case 4:
      poisk();
      break;
    case 5:
      return 0;
    default:
      cout << "\nВведите число от 1 до 7\n";
    }
  }
  return 0;
}

int menu() //Ф-ция, выводящая на экран меню
{
  int p;
  cout << "\n Выберите один из пунктов меню:\n\n";
  cout << "\t1) Сформировать файл\n";
  cout << "\t2) Печать информации о школьниках в файл\n";
  cout << "\t3) Ввести новую информацию о школьнике\n";
  cout << "\t4) Поиск информации о школьниках по заданному параметру\n";
  cout << "\t5) Выход из программы\n\n";
  cout << " Ваш выбор: ";
  cin >> p;
  system("cls"); //Ф-ция очищения экрана
  return p;
}

void formir()
{
  u++;
  if (!(F1 = fopen("Школьники.txt", "wb"))) //wb"    Создает двоичный файл для записи.
  {
    printf("Ошибка создания файла\n");
  }
  else
    printf("Файл успешно создан\n");
}

void pechat()
{
  if (u == 0)
    cout << "Создайте файл в пункте 1\n";
  else
  {
    if (counter == 0) //если счетчик количества структур равен 0, то выводим, что нет записей
      cout << "\nЗаписей нет. Введите информацию о школьниках в пункте 3 \n";
    else //Вводим новую запись только, если счетчик полных записей меньше максимального количества записей
    {
      F1 = fopen("Школьники.txt", "ab"); //"ab"    Дописывает информацию к концу двоичного файла.
      for (int i = 0; i < counter; i++) //выводим в цикле все записи
      {
          fprintf(F1, "%d-й школьник %s %s %s учится в классе номер %s, буква %s, оценка: %s\n", i + 1, mas[i].surname, mas[i].name, mas[i].otch, mas[i].klass, mas[i].bykva, mas[i].ocenka);
      }
      cout << "Данные успешно напечатаны в файл!\n";
      fclose(F1);
    }
  }
}
void dobav() //Ф-ция ввода информации о школьнике
{
  if (u == 0)
    cout << "Создайте файл в пункте 1\n";
  else
  {
    if (counter < 30) //Вводим новую запись только, если счетчик полных записей меньше максимального количества записей
    {
      F1 = fopen("Школьники.txt", "wb");
      cout << "\n\tЗапись номера " << counter + 1; //Выводим номер записи
      cout << "\n Введите фамилию школьника: ";
      cin >> mas[counter].surname;
      cout << " Введите имя школьника: ";
      cin >> mas[counter].name;
      cout << " Введите отчество школьника: ";
      cin >> mas[counter].otch;
      cout << " Введите класс школьника:\n";
      cin >> mas[counter].klass;
      cout << " Введите букву класса школьника: ";
      cin >> mas[counter].bykva;
      cout << " Введите оценку школьника: ";
      cin >> mas[counter].ocenka;
      cout << "\n";
      counter++; //Увеличиваем счетчик полных записей на единицу
      fclose(F1);
    }
    else
      cout << "Введено максимальное кол-во записей"; //Выведем на экран, если пользователь введет больше 30 записей
  }
}

void poisk() //Ф-ция поиска записей
{
  int sw, i, x=0;     // переключатель
  char fam[30];
  char nam[30];

  if (u == 0)
    cout << "Создайте файл в пункте 1\n";
  else
  {
    if (counter == 0)
      cout << "\nЗаписей нет. Введите информацию о школьниках в пункте 3 \n";
    else
    {
      cout << "\n\tВыберите один из пунктов: \n";
      cout << "1) Найти школьника по фамилии\n";
      cout << "2) Найти школьника по имени\n";
      cout << " Ваш выбор: ";
      cin >> sw;
      if (sw == 1)
      {
        F1 = fopen("Школьники.txt", "ab");
        cout << "\n\tВведите фамилию школьника:\n";
        cin >> fam;
        for (i = 0; i < counter; i++) //2 цикла необходимо для того, чтобы упорядочивать структуру до тех пор, пока она полностью не упорядочится
        {
          if (strcmp(mas[i].surname, fam) == 0) //Ф-ция strcmp сравнивает 2 строки (возвращает 0, если строки равны
            
          {
            fprintf(F1, "Результаты поиска:\n");
            fprintf(F1, "%d-й школьник %s %s %s учится в классе номер %s, буква %s, оценка: %s\n", i + 1, mas[i].surname, mas[i].name, mas[i].otch, mas[i].klass, mas[i].bykva, mas[i].ocenka);
                x++;
          }
        }
        printf("\nРезультаты поиска занесены в файл\n");

        if (x == 0)
        {
          fprintf(F1, "Результаты поиска:\n");
          fprintf(F1, "Совпадений не найдено\n\n");
        }
        fclose(F1);
      }

      if (sw == 2)
      {
        F1 = fopen("Школьники.txt", "ab");
        cout << "\n\tВведите имя школьника:\n";
        cin >> nam;
          for (i = 0; i < counter; i++) //2 цикла необходимо для того, чтобы упорядочивать структуру до тех пор, пока она полностью не упорядочится
          {
            if (strcmp(mas[i].name, nam) == 0) //Ф-ция strcmp сравнивает 2 строки (возвращает 0, если строки равны
                                                    //полож. число, если код элемента 1 строки больше кода соотв. эл. 2 строки
            {
              fprintf(F1, "Результаты поиска:\n");
              fprintf(F1, "%d-й школьник %s %s %s учится в классе номер %s, буква %s, оценка: %s\n", i + 1, mas[i].surname, mas[i].name, mas[i].otch, mas[i].klass, mas[i].bykva, mas[i].ocenka);
                  x++;
            }
          }
          
          printf("\nРезультаты поиска занесены в файл\n");
          if (x == 0)
                  {
                    fprintf(F1, "Результаты поиска:\n");
                    fprintf(F1, "Совпадений не найдено\n\n");
                  }
                  fclose(F1);
                }
    }
  }
}

