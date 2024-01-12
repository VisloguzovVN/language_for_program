int n = 10;
int[] arr = new int [n];
int i = 0;

while (i < n)
{
    arr[i]=i + 1;
   Console.Write(arr [i] % 2 == 0);
    Console.Write(" , ");
    i = i + 1;
}
