internal class Program
{
    private static async Task Main()
    {
        var myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Even Numbers:");
        await foreach (var number in GetEvenNumbers(myList))
        {
            Console.WriteLine(number);
        }
    }

    private static async IAsyncEnumerable<int> GetEvenNumbers(List<int> list)
    {
        foreach (var number in list.Where(number => number % 2 == 0))
        {
            yield return number;
            await Task.Delay(10000);
        }
    }
}