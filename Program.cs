// part 1

// int[] numbers = [5, 2, 8, 1, 4];

// Console.WriteLine("before:");
// Console.WriteLine(string.Join(", ", numbers));

// BubbleSort(numbers);

// Console.WriteLine("after:");
// Console.WriteLine(string.Join(", ", numbers));

// массив является ссылочным типом


// part 2

// int[] selectionNumbers = [5, 2, 8, 1, 4];

// Console.WriteLine("before:");
// Console.WriteLine(string.Join(", ", selectionNumbers));

// SelectionSort(selectionNumbers);

// Console.WriteLine("after:");
// Console.WriteLine(string.Join(", ", selectionNumbers));


// part 3

// int[] insertionNumbers = [5, 2, 4, 1];

// Console.WriteLine("before:");
// Console.WriteLine(string.Join(", ", insertionNumbers));

// InsertionSort(insertionNumbers);

// Console.WriteLine("after:");
// Console.WriteLine(string.Join(", ", insertionNumbers));

// ручная трассировка:
// [5] | [2, 4, 1]
// [2, 5] | [4, 1]
// [2, 4, 5] | [1]
// [1, 2, 4, 5] | []


// part 4

int[] bubbleNumbers = [5, 2, 8, 1, 4];
int[] otherNumbers = [5, 2, 8, 1, 4];
int[] standardNumbers = [5, 2, 8, 1, 4];

BubbleSort(bubbleNumbers);
SelectionSort(otherNumbers);
Array.Sort(standardNumbers);

Console.WriteLine("BubbleSort: " + string.Join(", ", bubbleNumbers));
Console.WriteLine("SelectionSort: " + string.Join(", ", otherNumbers));
Console.WriteLine("Array.Sort: " + string.Join(", ", standardNumbers));

List<int> values = [5, 2, 8, 1, 4];

values.Sort();

Console.WriteLine("List.Sort: " + string.Join(", ", values));

values.Reverse();

Console.WriteLine("reverse " + string.Join(", ", values));

// чтобы понять принцип работы сортировочных алгоритмов


// sort

void BubbleSort(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = 0; j < numbers.Length - 1 - i; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
}


void SelectionSort(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[j] < numbers[minIndex])
            {
                minIndex = j;
            }
        }

        int temp = numbers[i];
        numbers[i] = numbers[minIndex];
        numbers[minIndex] = temp;
    }
}

void InsertionSort(int[] numbers)
{
    for (int i = 1; i < numbers.Length; i++)
    {
        int current = numbers[i];
        int j = i - 1;

        while (j >= 0 && numbers[j] > current)
        {
            numbers[j + 1] = numbers[j];
            j--;
        }

        numbers[j + 1] = current;
    }
}