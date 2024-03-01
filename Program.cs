

class Program {
    static void Main(string[] args){

        //ingave keuze voor het type meting uit te voeren
        Console.WriteLine("Geef het type debietsberekening in:");
        Console.WriteLine("Optie 1 - KANAAL ROND");
        Console.WriteLine("Optie 2 - KANAAL RECHT");
        Console.WriteLine("Optie 3 - DEBIET ADHV DRUK");

        int keuze = Convert.ToInt32(Console.ReadLine());

        //instantieren van de benodigde klasses in main
        BerekeningRond rond = new BerekeningRond();
        BerekeningRecht recht = new BerekeningRecht();

        switch(keuze){

            //debietsberekening voor een rond kanaal
            case 1:
            Console.WriteLine("Ingave diameter van het kanaal in meters(m)");
            rond.Diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{rond.Diameter} m³/h");

            Console.WriteLine("Ingave gemeten snelheid(m/s)");
            rond.Snelheid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{rond.Snelheid} m/s");
            Console.WriteLine($"{rond.OppervlakteRond()} m²");

            Console.WriteLine($"Het gemeten debiet is {rond.DebietsBerekeningRond()} m³/h");
            break;

            
            //debietsberekening voor een recht kanaal
            case 2:
            Console.WriteLine("Ingave lengte van het kanaal in meters(m)");
            recht.lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{recht.lengte} m");

            Console.WriteLine("Ingave breedte van het kanaal in meters(m)");
            recht.breedte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{recht.breedte} m");

            Console.WriteLine("Ingave gemeten snelheid (m/s)");
            recht.snelheid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{recht.snelheid} m/s");

            Console.WriteLine($"Het gemeten debiet is {recht.Debietsberekening()} m³/h");
            break;
        }        
    }
}
