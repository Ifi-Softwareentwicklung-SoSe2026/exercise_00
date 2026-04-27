public enum HimmelskoerperTyp
{
    Stern,
    Planet,
    Mond,
    Todestern
}

public class Himmelskoerper
{
    public string Name { get; set;}
    // katalognummer
    public uint KatalogNummer { get; set;}
    // HimmelskoerperTyp
    public HimmelskoerperTyp Typ { get; set;}
    // Spektralklasse
    public char? SpektralKlasse { get; set;}
    // ScheinbareHelligkeit
    public double? ScheinbareHelligkeit { get; set;}
    // Umlaufzeit
    public double? Umlaufzeit { get; set;}
    // ZentralkoerperKatalogNummer
    public uint? ZentralkoerperKatalogNummer { get; set;}
}


public class Program
{
    public static void Main(string[] args)
    {
        Himmelskoerper stern = new Himmelskoerper();
        LeseDatenEin(stern, args);
        var istOkay = Validierung(stern);
        if (istOkay)
        {
            GibDatenAus(stern);
        }
        else
        {
            Console.WriteLine("Fehlerhafte Eingabe.");
        }
    }

    public static bool Validierung(Himmelskoerper koerper)
    {
        // Zentralkoerper KatalogNummer muss 5 Stellig sein
        if (koerper.ZentralkoerperKatalogNummer < 10000 ||
         koerper.ZentralkoerperKatalogNummer > 99999)
        {
            return false;
        }
        if (koerper.KatalogNummer < 10000 ||
         koerper.KatalogNummer > 99999)
        {
            return false;
        }
        return true;
    }

    public static void GibDatenAus(Himmelskoerper koerper)
    {
        Console.WriteLine("Himmelskörper:");
        Console.WriteLine($"Name: {koerper.Name}, Katalog-Nummer: {koerper.KatalogNummer}, Typ: {koerper.Typ}");
        if (koerper.Typ == Himmelskoerper.Stern)
        {
            Console.WriteLine($"Spektralklasse: {koerper.Spektralklasse}, Scheinbare Helligkeit: {koerper.ScheinbareHelligkeit}");
        }else{
            Console.WriteLine($"Umlaufzeit: {koerper.Umlaufzeit} Erdjahre, Zentralkörper-Katalognummer: {koerper.ZentralkoerperKatalogNummer}");
        }
    }

    public static void LeseDatenEin(Himmelskoerper koerper, string[] args)
    {
        if (args.Length > 2){
            koerper.Name = args[1];
            koerper.KatalogNummer = uint.Parse(args[2]);
            koerper.Typ = (HimmelskoerperTyp)Enum.Parse(typeof(HimmelskoerperTyp), args[3]);

            if (koerper.Typ == HimmelskoerperTyp.Stern)
            {
                // SpektralKlasse
                koerper.SpektralKlasse = args[4][0]; //char.Parse(args[4])
                // ScheinbareHelligkeit
                koerper.ScheinbareHelligkeit = double.Parse(args[5]);
            }else{
                // Umlaufzeit
                koerper.Umlaufzeit = double.Parse(args[4]);
                // ZentralkoerperKatalogNummer
                koerper.ZentralkoerperKatalogNummer = uint.Parse(args[5]);
            }
        }else{
            Console.WriteLine("Namen des Himmelskörpers: ");
            koerper.Name = Console.ReadLine();

            Console.WriteLine("Katalognummer (5-Stellig): ");
            koerper.KatalogNummer = uint.Parse(Console.ReadLine());

            Console.WriteLine("Himmelskörpertyp (Stern, Planet, Mond): ");
            koerper.Typ = (HimmelskoerperTyp)Enum.Parse(
                typeof(HimmelskoerperTyp),
                Console.ReadLine()
                );

            if (koerper.Typ == HimmelskoerperTyp.Stern)
            {
                // SpektralKlasse
                Console.WriteLine("Spektralklasse: ");
                koerper.SpektralKlasse = char.Parse(Console.ReadLine());
                // ScheinbareHelligkeit
                Console.WriteLine("Scheinbare Helligkeit: ");
                koerper.ScheinbareHelligkeit = double.Parse(Console.ReadLine());
            }else{
                // Umlaufzeit
                Console.WriteLine("Umlaufzeit: ");
                koerper.Umlaufzeit = double.Parse(Console.ReadLine());
                // ZentralkoerperKatalogNummer
                Console.WriteLine("Katalognummer des Zentralgestirns: ");
                koerper.ZentralkoerperKatalogNummer = uint.Parse(Console.ReadLine());
            }
        }
    }
    
    //public static Himmelskoerper LeseDatenEin(string[] args){}
}