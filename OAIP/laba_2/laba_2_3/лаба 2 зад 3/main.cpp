#include <stdio.h>
#include <math.h>
#include <locale.h>
int main()
{
 setlocale(LC_ALL, "Rus");
 int disc;
 printf("Выберите дисциплину: \n1-Информатика \n2-Культурология \n3-Математика \n4-Ин. яз. \n5-Экономика\n");
 scanf("%d", &disc);
 switch (disc) {
 case 1: printf("Экзамен, зачет\n"); break;
 case 2: printf("Зачет\n"); break;
 case 3: printf("Экзамен, зачет\n"); break;
 case 4: printf("Экзамен, зачет\n"); break;
 case 5: printf("Экзамен\n");
 default: printf("Ошибка\n");
 }
}
