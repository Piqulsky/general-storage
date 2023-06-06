// Proba1: Kosnolowa

// Funkcja implementująca algorytm opisany w Proba1
// Argumenty: tablica, którą przeszukujemy, oraz tzw. wartownik
int searchArrayWithWatcher(int[] arr, int i)
{
    int[] search= new int[arr.Length];
    arr.CopyTo(search, 0);
    search[search.Length-1] = i;
    int foundIndex  = 0;
    while (true)
    {
        if (search[foundIndex++] == i)
            break;
    }
    if (foundIndex == arr.Length)
        return -1;
    else
        return --foundIndex;
}

int[] generateArray(int size){
    int[] ints= new int[size < 50 ? 50 : size];
    Random random= new Random();
    for(int i = 0; i < ints.Length; i++)
    {
        ints[i]= random.Next(100);
    }
    return ints;
}

Console.Write("Podaj długość tablicy (min.50): ");
int[] array = generateArray(int.Parse(Console.ReadLine()));
Console.Write("Podaj poszukiwaną wartość (od 1 do 100): ");
int result = searchArrayWithWatcher(array, int.Parse(Console.ReadLine()));
if (result == -1)
    Console.WriteLine("Nie znaleziono liczby");
else Console.WriteLine("Liczba znaleziona pod indeksem: " + result.ToString());
foreach (int i in array) Console.Write(i.ToString() + ", ");
