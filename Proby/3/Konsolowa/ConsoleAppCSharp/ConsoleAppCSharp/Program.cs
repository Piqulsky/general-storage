
Osoba o1 = new Osoba(0, "Stefan");
Osoba o2 = new Osoba(1, "Feliks");
Osoba o3 = new Osoba(o1);
o1.WypisanieImienia("Feliks");
Console.WriteLine("Liczba instancji: " + Osoba.instancje);

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
        if (imie != "")
            Console.WriteLine("Cześć " + imie + " mam na imię " + this.imie);
        else
            Console.WriteLine("Brak danych");
    }
}

