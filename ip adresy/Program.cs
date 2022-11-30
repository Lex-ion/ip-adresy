int maska;
int cislo;
Random rd = new Random();
zacatek:
for (int i = 0; i <3; i++) 
{
    cislo = rd.Next(0,255);
    Console.Write(cislo+".");
}
cislo = rd.Next(0, 255);
Console.Write(cislo + "/");
maska = rd.Next(8,30);
Console.Write(maska);
Console.ReadKey();
Console.Clear();
goto zacatek;