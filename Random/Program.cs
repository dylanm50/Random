using System.Runtime.InteropServices;
// Generates 'n' unique numbers within a range of 'range' in O(n) time

int range = 10;
int n = 10;
int min = 0;
int[] a = new int[n];
int sect = range / n;
Random rand = new Random();

for (int i = 0; i < n; i ++)
{
    int max = sect * (i + 1);
    a[i] = rand.Next(min, max);
    min = max;

    Console.WriteLine(a[i]);
}

