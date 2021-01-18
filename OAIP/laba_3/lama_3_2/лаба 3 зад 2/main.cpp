#include <stdio.h>

int main()
{
float l = 20, t = 0;
int v1= 2, v2 = 3, sh = 5, flag = 1;
for (; l >= 0.00001; flag *= -1, l -= (v1 + v2) * t) {
t = l / (sh + (flag > 0 ? v2 : v1));
printf("%f\n", sh * t);
}
}
