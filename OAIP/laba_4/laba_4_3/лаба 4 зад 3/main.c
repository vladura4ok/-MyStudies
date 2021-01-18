#include <stdio.h>
#include <math.h>
int main () {
    int n;
       printf ("Введите размер массивов : ");
       scanf ("%d", &n);
    int a[n];
   int b[n];
    int c[n];
    int i;
     printf ("\n");
     printf ("Массив a : \n");
    for (i=0;i<n;i++){
         printf ("Введите число : ");
    scanf ("%d", &a[i]);
    }
    for (i=0; i<n; i++) {
        printf (" %d",a[i]);
        }
     printf ("\n");
    printf ("Массив b : \n");
    for (i=0;i<n;i++){
         printf ("Введите число : ");
    scanf ("%d", &b[i]);
    }
    for (i=0; i<n; i++) {
           printf (" %d",b[i]);
       }
     printf ("\n");
     printf ("Массив c : \n");
    for (i=0; i<n; i++) {
        c[i]=a[i]+b[i];
        printf (" %d",c[i]);
    }
    printf ("\n");
    
    
    
    
    
}
