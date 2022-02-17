int[] arrayValues = { 1, 329, 21, 24, 67, 231, 20, 45 };

IEnumerable<int> sortedValues = from i in arrayValues orderby i select i; //orderby high to low sort

IEnumerable<int> reverseValues = sortedValues.Reverse();

foreach (var item in reverseValues)
{

    Console.WriteLine(item);
}
Console.WriteLine(" ");
IEnumerable<int> reversedSortedInts = from i in sortedValues orderby i descending select i; //descending functions like Reverse
IEnumerable<int> ascendingSortedInts = from i in sortedValues orderby i ascending select i; //ascending
foreach (var item in reversedSortedInts)
{
    Console.WriteLine(item);
}

Console.WriteLine(" ");

foreach (var item in ascendingSortedInts)
{
    Console.WriteLine(item);
}
Console.Read();
