Console.WriteLine("Vvedite dlinu massiva");
int n=Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
int[] cont= new int[n];
int g = 0;
Random rnd = new Random();
Console.WriteLine("Vvedite chisla massiva");
for (int i = 0; i < n; i++)
{
    mass[i]= rnd.Next(100);
    Console.WriteLine(mass[i]);
}
for (int i=0;i<n;i++)
{
    for(int j = 0; j < n;j++)
    {
        if (mass[i] > mass[j])
        {
            g++;
        }
        else if (mass[i] == mass[j])
        {
          
        }
    }
    cont[i] = mass[g];
    g = 0;
}
Console.WriteLine("otvet");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(cont[i]);
}