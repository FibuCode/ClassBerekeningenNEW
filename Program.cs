using BerekeningRechtNamespace;
using BerekeningRondNamespace;
using BerekeningDrukNamespace;

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
        BerekeningDruk druk = new BerekeningDruk();

        switch(keuze){

            //debietsberekening voor een rond kanaal
            case 1:
            Console.WriteLine("Ingave diameter van het kanaal in meters(m)");
            rond.Diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"diameter = {rond.Diameter} m");

            Console.WriteLine("Ingave gemeten snelheid(m/s)");
            rond.Snelheid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"snelheid = {rond.Snelheid} m/s");
            Console.WriteLine($"oppervlakte = {rond.OppervlakteRond()} m²");

            Console.WriteLine($"Het gemeten debiet is {rond.DebietsBerekeningRond()} m³/h");
            break;

            
            //debietsberekening voor een recht kanaal
            case 2:
            Console.WriteLine("Ingave lengte van het kanaal in meters(m)");
            recht.lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"lengte kanaal = {recht.lengte} m");

            Console.WriteLine("Ingave breedte van het kanaal in meters(m)");
            recht.breedte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"breedte kanaal = {recht.breedte} m");

            Console.WriteLine("Ingave gemeten snelheid (m/s)");
            recht.snelheid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"gemeten snelheid = {recht.snelheid} m/s");

            Console.WriteLine($"Het gemeten debiet is {recht.DebietsBerekening()} m³/h");
            break;

            //debietsberekening adhv toename of afname druk voor een gekend debiet
            case 3:
            Console.WriteLine("Ingave oud gemeten debiet m³/h");
            druk.oudDebiet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"oud debiet = {druk.oudDebiet} m³/h");

            Console.WriteLine("Ingave oude druk in Pa");
            druk.oudDruk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"oude druk = {druk.oudDruk}Pa");

            Console.WriteLine("Ingave nieuwe druk in Pa");
            druk.nieuwDruk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"nieuwe druk = {druk.nieuwDruk}Pa");

            Console.WriteLine($"Het nieuwe berekend debiet is {druk.DebietsBerekening()}m³/h");
            break;

            
        }        
    }
}
