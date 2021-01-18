#define _CRT_SECURE_NO_WARNINGS
#include "stdio.h"

#include "locale.h"

#include "stdlib.h"
#include <math.h>
int main()

{
setlocale(LC_ALL, "RUS");
int i, j, n, m, max, min, jmin = 0, jmax = 0, t;
float a[100][100];
printf("Введите количество строк: ");
scanf("%d", &n);
printf("Введите количество столбцов: ");
scanf("%d", &m);

for (i = 0; i < n; i++)
{
for (j = 0; j < m; j++)
{
printf("введите элементы [%d; %d]\n", i, j);
scanf("%f", &a[i][j]);
}
}
printf("\nВведенная матрица : \n");
for (i = 0; i < n; i++)
{
for (j = 0; j < m; j++)
printf("%0.f ", a[i][j]);
printf("\n");
}

// Найти сумму элементов на главной диагонали//

printf("\n");
int sum = 0;
for (i = 0; i < n; i++)

{
sum += a[i][i];
}

printf("сумма элементов главной диагонали = %.d\n", sum);
printf("\n");

//Найти максимальный и минимальный элемент в каждой строке и поменять их местами//
for (i = 0; i < n; i++)

{
min = a[i][0];
max = a[i][0];
for (j = 0; j < m; j++) {

if (min > a[i][j]) {
min = a[i][j];
jmin = j;
}

if (max < a[i][j]) {
max = a[i][j];
jmax = j;
}
}

printf("В %d-ой строке макс = %d, мин = %d\n", i + 1, max, min);

t = a[i][jmax];
a[i][jmax] = a[i][jmin];
a[i][jmin] = t;

}
for (i = 0; i < n; i++)
{
for (j = 0; j < m; j++)
printf("%.0f ", a[i][j]);
printf("\n");
}
printf("\n");

return 0;

}
