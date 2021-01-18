#include <stdlib.h>
#include <stdio.h>
int main () {
    int n;
    printf ("Введите размер массива : ");
    scanf ("%d", &n);
    int arr[n];
    int i,max,sum,index;
    for (i=0;i<n;i++){
         printf ("Введите число : ");
    scanf ("%d", &arr[i]);
    }
    max= abs(arr[0]);
    for (i=0; i<n; i++)
    {  if (max< abs(arr [i]))
            max=abs(arr [i]); }
    printf ("Наш массив : ");
    for (i = 0; i < n; i++) {
           printf (" %d", arr[i]);
             }
        for (i = 0; i < n; i++) {
            if (arr[i]>0) {
                break;
            }
        
            }
    
    index=i;
    for (i = index; i < n; i++)
        sum+=arr[i];
    printf ("\n");
    printf ("sum= %d\n",sum);
    printf ("max= %d\n",max);
    printf ("\n");
   
}



