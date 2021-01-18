# pragma warning (disable: 4996)
#include <stdio.h>
#include <stdbool.h>

void conclusion()
{
    printf("1) Ввести новый массив(динамический)\n2) Задание 1\n3) Вывод массива\n4) Задание 2\n5) Выход\n");
    printf("\n");
}
int a[100];
int u, s;
void one()
{
    printf("Введите размер массива n: ");
    scanf("%d", &u);
      for(int i =0; i< u; i++)
      {
          printf("Введите элемент: ");
          scanf("%d", &a[i]);
      }
    printf("\n");

}
void two( int x,int y)
{
    int s;
    int MyArray[x][y];
    for(int j =0; j< x; j++)
    {
        printf("%d строка", j+1);
        printf("\n");
        for(int i =0; i< y; i++)
        {
            printf("Введите элемент: ");
            scanf("%d", &MyArray[j][i]);
           
        }
        
    }
    printf("Вывод массива: ");
    printf("\n");
    for(int j =0; j< x; j++)
    {
        for(int i =0; i< y; i++)
        {
            printf("%d ", MyArray[j][i]);
        }
        printf("\n");
    }
    for(int j =0; j< x; j++)
    {
        for(int i =0; i< y; i++)
        {
         if(MyArray[j][i]< 0)
         {
             printf("Строка с отрицательным элементом: ");
             printf("%d", j+1);
             printf("\n");
             s++;
         }
        }
        for(int i = 0; i < y; i++)
        {
            MyArray[i][j] /= 2;
        }
    }
    printf("\n");
    if(s != 0)
    {
    printf("Вывод массива:/2 ");
    printf("\n");
    for(int j =0; j< x; j++)
    {
        for(int i =0; i< y; i++)
        {
            printf("%d ", MyArray[j][i]);
        }
        printf("\n");
}
    }
    else
    {
        printf("Отрицательных нет :(\n");
    }
    
}
void three()
{
    
    printf("Вывод массива: ");
    for(int i =0; i<u;i++)
    {
        printf("%d",a[i]);
        printf(" ");
    }
    printf("\n");
    printf("\n");
}
void four()
{
/*Методом не смогла*/
    
        printf("Введите строку: ");
        const int bufsize = 100; //выделяем хранилище для переменной
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


void five(int choice)
{
    printf("Спасибо, что пользовались моей программой!♡♡♡\n");
    printf("\n");
}
void other()
{
    printf("Такого варианта нет :-( попробуйте ещё разок: \n");
    printf("\n");
}
int main()
{
    conclusion();
    int n, choice, x,y,u;
    printf("Выберите действие: ");
    scanf("%d", &n);
    printf("\n");
    bool i = true;
    while (i) {
    bool j = true;
    switch (n)
    {
    case 1:
            
            one();
            conclusion();
            u+=1;
            printf("Выберите действие: ");
            scanf("%d", &n);
            printf("\n");
    break;
    case 2:
            printf("Введите высоту: ");
            scanf("%d", &x);
            printf("Введите ширину: ");
            scanf("%d", &y);
            two(x,y);
            conclusion();
            printf("Выберите действие: ");
            scanf("%d", &n);
            printf("\n");
    break;
    case 3:
            if(u>0)
            {
            three();
            }
            else
            {
                printf("Сперва введите его!\n");
            }
            conclusion();
            printf("Выберите действие: ");
            scanf("%d", &n);
            printf("\n");
    break;
    case 4:
            printf("отдельно");
            conclusion();
            printf("Выберите действие: ");
            scanf("%d", &n);
            printf("\n");
    break;
    case 5:
            printf("Вы хотите покинуть программу?\n1)Да 2)Нет\n");
            printf("\n");
            printf("Выберите действие: ");
            scanf("%d", &choice);
            printf("\n");
            while (j)
            {
            if(choice==1)
            {
            five(choice);
            j = false;
            i = false;
            }
            else if(choice==2)
            {
                printf("Тогда ещё разок :\n");
                printf("\n");
                conclusion();
                printf("Выберите действие: ");
                scanf("%d", &n);
                printf("\n");
                j = false;
            }
            else
            {
                printf("Такой цыфры нет (；⌣̀_⌣́)\n");
            }
                
            }
            
    }
        
    }
    
}
