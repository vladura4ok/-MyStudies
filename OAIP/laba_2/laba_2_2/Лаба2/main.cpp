#include <iostream>


using namespace std;

int main ()
{
setlocale(LC_ALL, "rus");
int a, b, c, k;
printf("введите а\n");
scanf("%d", &a);
printf("введите b\n");
scanf("%d", &b);
printf("введите c\n");
scanf("%d", &c);
printf("введите k\n");
scanf("%d", &k);
if(a % k == 0){
printf("k является делителем a\n");}
if(b % k == 0){
printf("k является делителем b\n");}
if(c % k == 0){
printf("k является делителем c\n");}
return 0;
}
