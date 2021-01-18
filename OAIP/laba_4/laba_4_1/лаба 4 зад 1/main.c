#include <stdio.h>
int main () {
    int n;
    printf ("Введите размер массива : ");
    scanf ("%d", &n);
    int arr[n];
    int i,max,min;
    for (i=0;i<n;i++){
         printf ("Введите число : ");
    scanf ("%d", &arr[i]);
    }
   
    min=arr[0];
    max=arr[0];
    for (i=0; i<n; i++)
    {
    if (min>arr [i])
    min= arr [i];
        if (max< arr [i])
            max=arr [i]; }
    printf ("Наш массив : ");
        for (i = 0; i < n; i++) {
            if (arr[i]==max)
                arr[i]=min;
            else  if (arr[i]==min)
                           arr[i]=max;
            printf (" %d", arr[i]);
            }
        
    int sum,com=1;
    for (i=0; i<n; i++) {
        sum+=arr[i];
        com*=arr[i];
    }
    printf ("\n");
    printf ("sum= %d\n",sum);
    printf ("com= %d\n",com);
    printf ("min= %d\n",min);
    printf ("max= %d\n",max);
    printf ("\n");
   
}



