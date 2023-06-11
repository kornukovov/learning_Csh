int a = 3;
int b = 4;
int c = 1;
int d = 2;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.WriteLine($"max = {max}");
