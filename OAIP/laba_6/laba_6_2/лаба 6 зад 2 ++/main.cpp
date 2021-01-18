#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <algorithm>

int main () {
    int *arr,n,m,*el;
    printf ("Введите кол-во строк матрицы : ");
    scanf ("%d",&n);
    printf ("Введите кол-во столбцов матрицы : ");
    scanf ("%d",&m);
    el=(int*)malloc(sizeof(int)*n);
    arr=(int*)malloc(sizeof(int)*n);
    for (int i=0;i<n;i++) {
        for (int j=0;j<m;j++) {
            printf ("\nВведите элемент %d строки и %d стобца : ", i+1,j+1);
            scanf ("%d",arr + i*m + j);
        }
        }
    printf ("\nПервая матрица : ");
    for (int i=0;i<n;i++) {
        printf ("\n");
        *(el + i)=0;
        for (int j=0;j<m;j++)
            printf ("%d ", *(arr + i * m + j));
    }
    for (int i=0;i<n;i++) {
        for (int j=0;j<m;j++) {
            if (*(arr + i * m + j)> 0 && *(arr + i * m + j) % 2==0) {
                *(el+i) += *(arr+ i*m + j);
                printf ("\nСумма : %d\n", *(el + i));
            }
        }
        
    }
    for (int k=0;k<n;k++) {
        for (int i=0;i< m-k-1;i++) {
            if (*(el+i)>*(el+i+1)) {
                std::swap(*(el+i), *(el+i+1));
                for (int j=0;j<m;j++)
                    std::swap(*(arr+i*m+j), *(arr+(i+1)* m+j));
            }
        }
    }
    printf ("\nОтсортированная матрица : ");
    for (int i=0;i<n;i++) {
        printf ("\n");
        for (int j=0;j<m;j++)
            printf ("%d ", *(arr+ i*m+j));
        }
    getchar();
    return 0;
}


