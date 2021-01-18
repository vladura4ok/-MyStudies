#include <string.h>
#include <stdio.h>
#include <math.h>
//  Структура «Школьник»: фамилия, имя, отчество; класс; номер телефона; оценки по предметам (математика, физика, русский язык, литература).
struct student {
char surname[30];
char name[30];
char otchestvo[30];
char klass[30];
char nomer[30];
char ocenka[30];
};
struct student mas[30];
struct student tmp[30];
