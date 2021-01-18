#include <math.h>
#include <iostream>
#include <stdio.h>
#include <ncurses.h>

int main() {
    int n,m,s=0,e[10];
    float arr[10][10];
    printf ("Введите кол-во строк и столбцов : ");
    scanf ("%d%d", &n, &m);
    for (int i=0;i<n;i++){
        for (int j=0;j<m;j++) {
            printf ("Введите элементы %d строки и %d столбца : ",i,j);
            scanf ("%f",&arr[i][j]);
            if (arr[i][j]<0)
                e[i]=1;
        }
        }
    for (int i=0;i<n;i++) {
        for (int j=0;j<m;j++){
            if (arr[i][j]>0)
                s+=1;
        }
    }
    if (s==n*m)
        printf ("Матрица не имеет отрицательные элементы\n");
    else {
        printf ("Отрицательные элементы в строке(строках) матрицы : ");
        for (int i=0;i<n;i++){
            if (e[i]==1){
                printf ("%d",i);
                for (int j=0;j<m;j++) {
                    arr[j][i]/=2;
                }
            }
        }
        printf ("\nИзмененная матрица :\n");
        for (int i=0;i<n;i++){
            printf ("\n");
            for (int j=0;j<m;j++){
                printf ("%.1f ",arr[i][j]);
            }
            
        }
            
    }
    
    
}
