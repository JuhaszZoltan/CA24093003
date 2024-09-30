namespace CA24093003
{
    internal class Recept
    {
        public string Etel { get; set; }
        public int Ido { get; set; }
        public string Fajta { get; set; }
        public string Nehezseg { get; set; }

        public override string ToString()
        {
            return $"{Etel} ({Nehezseg}, {Ido} perc, {Fajta})";
        }

        public Recept(string sor)
        {
            var v = sor.Split(';');
            Etel = v[0];
            Ido = int.Parse(v[1]);
            Fajta = v[2];
            Nehezseg = v[3];
        }
    }
}
