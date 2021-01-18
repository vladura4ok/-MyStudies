#include <stdio.h>
int main () {
    int a1,b3,c5,m;
    /*do
    { printf ("введите m : ");
        scanf ("%d", &m);
        
    }
    while(10>m || m>50);
    }*/
    while (10>m || m>50) {
        printf ("введите m : ");
        scanf ("%d", &m);
        
    }
    for ( c5=0; c5<=m/5; c5++)
    for ( b3=0; b3<=10-c5; b3++)
    {
        a1=10-5-3;
        if (c5*5+b3*3+a1==m) {
            printf ("%d*5+%d*3+%d=%d\n", c5,b3,a1,m);
        }
    }

    }

