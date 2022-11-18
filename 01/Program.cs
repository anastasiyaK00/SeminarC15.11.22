// Обмен значениями двух переменных.
/* 1)Классичский способ
int a = 5;
int b = 7;
int temp;
temp=a;
a=b;
b=temp;
*/

// 2)Без использования третей переменной
/*
int a =5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
*/

// 3) Используя ксор ^
int a = 5;
int b = 7;
a=a^b;
b=a^b;
a=a^b;
System.Console.WriteLine($"a={a}, b={b}");
