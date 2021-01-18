#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <iostream>
#include <string>

int main()
{

char a[50];
char s[50];
int k = 0;
int i;
FILE* f1, *f2;
f1 = fopen("f1.txt", "r"); //r-Создает файл для записи (по умолчанию файл открывается как текстовый)
if (!f1)
{
printf("Error!");
return 0;
}
f2 = fopen("f2.txt", "wt"); //wt-Открывает текстовый файл для записи.
if (!f2)
{
printf("Error!");
return 0;
}
for (i = 1; i <= 10; i++) {
fscanf(f1, "%s", &a);
if (a[0] = 'a')
fprintf(f2, "%s\n", a);
}
fclose(f1);
fclose(f2);//закрываем файл
printf("DONE!");
return 0;
}
