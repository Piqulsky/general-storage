#include <iostream>
#include <ctime>

// W moim dzisiejszym eseju zatytułowanym "Dlaczego lepiej nie używać C++ na egzaminie zawodowym"
// chcialbym przedstawić moj argument numer 1...

using namespace std;

int searchArrayWithWatcher(int* arr, int n, int size) {
	int* search = new int[size];
	for (int i = 0; i < size; i++) {
		*(search + i) = *(arr + i);
	}
	*(search + size) = n;
	int foundIndex = 0;
	while (true)
	{
		if (*(search + foundIndex++) == n)
			break;
	}
	if (foundIndex == size + 1)
		return -1;
	else
		return --foundIndex;
}

int * generateArray(int size) {
	int* arr = new int[size];
	srand((unsigned)time(NULL));
	for (int i = 0; i < size; i++)
	{
		*(arr + i) = rand() % 100 + 1;
	}
	return arr;
}

int main()
{
	int* p;
	cout << "Podaj dlugosc tablicy (min. 50): ";
	int size;
	cin >> size;
	size = size < 50 ? 50 : size;
	p = generateArray(size);
	cout << "Podaj poszukiwana wartosc (od 1 do 100): ";
	int n;
	cin >> n;
	int index = searchArrayWithWatcher(p, n, size);
	cout << index << endl;
	for (int i = 0; i < size; i++) {
		cout << *(p + i) << ", ";
	}

	return 0;
}
