#include <algorithm>
#include <stdio.h>
#include <math.h>
int main () {
int arr[10][10],n,m,sum[10];
printf ("Введите кол-во строк и столбцов : ");
scanf ("%d%d", &n, &m);
for (int i=0;i<n;i++){
    for (int j=0;j<m;j++) {
        printf ("Введите элементы %d строки и %d столбца : ",i,j);
        scanf ("%d",&arr[i][j]);
    }
    }
    for (int i=0;i<n;i++) {
        for (int j=0;j<m;j++){
            if (arr[i][j]>0 && arr[i][j]%2 == 0)
                sum[i] += arr[i][j];
        }
    }
    for (int i=0;i<n;i++) {
        int sI=i;
        for (int j=0;j<m;j++) {
            if (sum[j]<sum[sI]){
                sI=j;
            }
        }
        std::swap(arr[i],arr[sI]);
    }
    printf("Исходная матрица : ");
    for (int i=0;i<n;i++) {
        printf ("\n");
        for (int j=0;j<m;j++) {
            printf ("%d",arr[i][j]);
        }
        
    }
    return 0;
    }


