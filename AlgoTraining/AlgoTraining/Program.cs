using AlgoTraining;

Console.WriteLine("----------Playground----------");

List<int> sortedNumbers = new() { 
    1, 2, 3, 3, 4, 5, 6, 12, 13, 13, 15, 23, 24, 25, 28, 32, 44, 44, 45, 50
};

int searchedValue = 13;
int searchedValueIndex = BinarySearch.Find(sortedNumbers, searchedValue);
Console.WriteLine($"Found number {searchedValue} on index: {searchedValueIndex} (using binary search)");
