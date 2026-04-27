public enum Typ
{
    Stern,
    Planet,
    Mond
}


public class Himmelskoerper
{
    public string Name { get; set;}
    public uint KatalogNummer { get; set;}
    // typ
    public Typ Himmelskoerpertyp { get; set;}
    // spectral
    public char? Spectral { get; set;}
    // helligkeit
    public float? helligkeit { get; set;}
    // Umlauf
    public float? umlauf { get; set;}
    // KatNr von Elternobjekt
    public uint KatalogNummerReferenz { get; set;}    

}

public class Program
{
    public static void Main(string[] args)
    {
        Himmelskoerper koerper = new Himmelskoerper();
        Console.WriteLine(args[1]);
        LeseEin(koerper, args);
        Ausgabe(koerper);
    }

    public static void Ausgabe(Himmelskoerper koerper)
    {

    }

    public static void LeseEin(Himmelskoerper koerper, string[] args)
    {
        if (args.Length > 1)
        {
            koerper.Name = args[1];
            koerper.KatalogNummer = uint.Parse(args[2]);
            koerper.Himmelskoerpertyp = (Typ) Enum.Parse(typeof(Typ), args[3]);
            if (koerper.Himmelskoerpertyp == Typ.Stern)
            {
                koerper.Spectral = args[4][0];
                koerper.helligkeit = float.Parse(args[5]);
            }else{
                koerper.umlauf = float.Parse(args[4]);
                koerper.KatalogNummerReferenz = uint.Parse(args[5]);
            }
        }else{
            Console.WriteLine("Name des Himmelskörpers:");
            koerper.Name = Console.ReadLine();

            Console.WriteLine("KatalogNummer (5-stellig):");
            koerper.KatalogNummer = uint.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie den Typ ein (Stern, Planet, Mond):");
            koerper.Himmelskoerpertyp = (Typ) Enum.Parse(typeof(Typ), Console.ReadLine());

            if (koerper.Typ == Typ.Stern)
            {
                Console.WriteLine("Spektralklasse (O, B, A, F, G, K, M): ");
                koerper.Spektralklasse = Console.ReadLine()[0];

                Console.WriteLine("scheinbare Helligkeit: ");
                koerper.helligkeit = float.Parse(Console.ReadLine());
            }else{
                Console.WriteLine("Umlaufzeit in Erdjahren: ");
                koerper.umlauf = float.Parse(Console.ReadLine());
                Console.WriteLine("KatalogNummer des Zentralkörpers: ");
                koerper.KatalogNummerReferenz = uint.Parse(Console.ReadLine());
            }
        }


    }
}