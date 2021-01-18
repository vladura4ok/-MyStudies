#include <stdio.h>



int main()
{
    printf("Введите строку: ");
    const int bufsize = 100;
    char buffer[bufsize];
    fgets(buffer, bufsize, stdin);
    printf("Вывод строки: ");
    for(int i = 0; i<sizeof(buffer);i++)
    {
        
        int a  = (int)buffer[i];
        if(a == ' ')
        {
            printf("%c", buffer[i]);
        }
        if(a>96 && a<123)
        {
            int b = a - 32;
            printf("%c", b);
        }
        if (a > 64 && a < 91)
        {
        int b = a + 32;
        printf("%c",b);
        }
        
    }
    printf("\n");
    
}
