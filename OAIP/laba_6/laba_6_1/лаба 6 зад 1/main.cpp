#include <iostream>
#include <math.h>
#include <stdio.h>
#include <stdlib.h>
int main () {
    int n, *mas,max,sum=0,el,ar=0;
    printf ("Введите кол-во элементов массива : ");
    scanf ("%d",&n);
    mas= (int*)malloc(sizeof(int)* n);
    for (int i=0;i<n;i++) {
        printf("Введите %d элемент массива : ", i+1);
        scanf ("%d", mas+i);
        if (*(mas+i)<0)
            ar+=1;
    }
    if (ar==n)
        printf ("\nНет положительных элементов\n");
    else {
        max=*mas;
        for (int i=0;i<n;i++) {
            if (abs(*(mas+i))>max)
                max=abs(*(mas+i));
        }
        printf ("Модуль максимального элемента массива : %d",max);
        for (int i=0;i<n;i++) {
            if (*(mas+i)>0) {
                el=i;
                break;
            }
        }
        for (int i=el+1;i<n;i++)
            sum+= *(mas+i);
        printf ("\nНужная сумма : %d\n",sum);
    }
}

