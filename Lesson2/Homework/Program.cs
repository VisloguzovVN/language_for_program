int n = 9;
int [] array = {100, 345, 786, 21, 1, 876, 22, 344, 890};
int i = 0;
int max = array [0];

while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

max = array[0];
for(int r = 0; r < n; r++)
{
   if (array[r] > max)
    {
        max = array[r];
    } 
}

Console.WriteLine(max);

max = array[0];
foreach (int b in array)
{
if (b > max)
    {
        max = b;
    } 
}
Console.WriteLine(max);

