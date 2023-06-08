// Na podstawie Część IV. Dokumentacja aplikacji
Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.instancje);
Osoba o1 = new Osoba();
Console.Write("Id osoby: ");
int id = int.Parse(Console.ReadLine());
Console.Write("Imię osoby: ");
string name = Console.ReadLine();
Osoba o2 = new Osoba(id, name);
o1.WypisanieImienia("Jan");
o2.WypisanieImienia("Jan");
Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.instancje);

class Osoba
{
    private int id;
    private string imie;
    // Pole statyczne jest dostępne za pomocą Osoba.instancje, dostępne między instancjami
    public static int instancje;
    // Konstruktor bezparametrowy
    public Osoba()
    {
        id = 0;
        imie = "";
        instancje++;
    }
    // Konstruktor parametrowy
    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;
        instancje++;
    }
    // Konstruktor kopiujący
    public Osoba(Osoba o)
    {
        this.id = o.id;
        this.imie = o.imie;
        instancje++;
    }
    // Metoda wypisująca imię na podstawie parametru
    public void WypisanieImienia(string imie)
    {
        // Właściwość this rozróżnia pole klasy od argumentu funkcji
        if (this.imie != "")
            Console.WriteLine("Cześć " + imie + " mam na imię " + this.imie);
        else
            Console.WriteLine("Brak danych");
    }
}

