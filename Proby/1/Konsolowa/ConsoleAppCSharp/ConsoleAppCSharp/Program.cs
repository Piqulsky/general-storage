// Proba1: Kosnolowa

// Funkcja implementująca algorytm opisany w Proba1
// Argumenty: tablica, którą przeszukujemy, oraz tzw. wartownik
int searchArrayWithWatcher(int[] arr, int i)
{
    // Utworzenie nowej tablicy, ponieważ arr ma już określoną długość i nie możemy jej zmienić
    int[] search = new int[arr.Length];
    // Skopiowanie zawartości arr do nowej, dłuższej tablicy
    arr.CopyTo(search, 0);
    // Przypisanie wartownika
    search[search.Length-1] = i;
    // foundeIndex to zmienna, która będzie naszym wynikiem
    int foundIndex  = 0;
    // Pętla nieskończona, która przerwie się gdy znajdziemy wynik
    // Jako, że wartownik jest naszym wynikiem, to pętla zawsze się przerwie
    while (true)
    {
        // Porównujemy wartość i inkrementujemy indeks, żeby w następnej iteracji sprawdzić kolejną cyfrę
        if (search[foundIndex++] == i)
            break;
    }
    // -1 oznacza brak wyniku
    if (foundIndex == arr.Length)
        return -1;
    // --foundIndex jest konieczny, ponieważ pętla wykonuje inkrementację foundIndex o jeden raz więcej
    else
        return --foundIndex;
}
// Funkcja generująca tablicę o min. 50 pseudolosowych liczbach
// Argumenty: wielkość
int[] generateArray(int size){
    // Nowa tablica ma co najmniej 50 elementów, więc jeżeli size jest za mały, domyślną wartością jest 50
    int[] ints = new int[size < 50 ? 50 : size];
    // Instancja losowa - konieczna do losowania liczb
    Random random = new Random();
    // Pętla do wypełnienia tablicy
    for(int i = 0; i < ints.Length; i++)
    {
        // Losowanie liczby od 0 do 100 i przypisanie jej
        ints[i]= random.Next(100);
    }
    return ints;
}

Console.Write("Podaj długość tablicy (min.50): ");
// Odczytanie wielkości od użytkownika i wygenerowanie tablicy o odpowiedniej długości
int[] array = generateArray(int.Parse(Console.ReadLine()));
Console.Write("Podaj poszukiwaną wartość (od 1 do 100): ");
// Odczytanie liczby szukanej od użytkownika i wywołanie algorytmu szukania
int result = searchArrayWithWatcher(array, int.Parse(Console.ReadLine()));
if (result == -1)
    Console.WriteLine("Nie znaleziono liczby");
else Console.WriteLine("Liczba znaleziona pod indeksem: " + result.ToString());
// Wypisanie tablicy
foreach (int i in array) Console.Write(i.ToString() + ", ");
