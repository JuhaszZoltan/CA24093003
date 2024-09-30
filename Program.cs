using CA24093003;
using System.Text;

Random rnd = new();
List<Recept> szakacskonyv = [];

using StreamReader sr = new(@"..\..\..\src\szakacskonyvCLI_adatok.csv",Encoding.UTF8);
while (!sr.EndOfStream) szakacskonyv.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feladat: az allomanyban {szakacskonyv.Count} recept szerepel.");

var f4 = szakacskonyv.Count(r => r.Ido < 65);
Console.WriteLine($"4. feladat: {f4} recept keszitheto el 65 percnel rovidebb ido alatt");

var f5 = szakacskonyv.GroupBy(r => r.Fajta);
Console.WriteLine("5. feladat: etelfajtak - darab");
foreach (var fajat in f5)
{
    Console.WriteLine($"\t{fajat.Key}: {fajat.Count()} db");
}

var f6 = szakacskonyv.Where(r => r.Nehezseg == "könnyű").ToList();
Console.WriteLine($"6. feladat: pl. egy konnyu etel: {f6[rnd.Next(f6.Count)]}");