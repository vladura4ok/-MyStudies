#include "iostream"
#include "stdio.h"
#include "math.h"
int main()

{

int y1,y2,y3,x1,x2,x3;
double a, b, c;

printf("Vvedite koordinaty radiysa\n");
scanf("%d%d", &x1, &y1);
printf("Vvedite koordinaty tochki #1\n");
scanf("%d%d", &x2, &y2);
printf("Vvedite koordinaty tochki #2\n");
scanf("%d%d", &x3, &y3);
a = sqrt(pow(x1 - x2, 2) + pow(y1 - y2, 2));
b = sqrt(pow(x2 - x3, 2) + pow(y2 - y3, 2));
c = sqrt(pow(x3 - x1, 2) + pow(y3 - y1, 2));
if(a+c==a+b) {
printf("Prinadlejit\n");
} else{
printf("ne prinadlejit\n");
}


return 0;

}

