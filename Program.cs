class Program
{
	public static long Product(long input)
    {
		long result = 1;

		//get each digit by mod instead of string conversion
		while (input > 0)
        {
			result *= input % 10;
			input /= 10;
        }

		return result;
    }

	public static long MultiplicativePersistence(long userInput)
    {
		long steps = 0;

		//10 is smallest double digit number
		while (userInput >= 10)
        {
			userInput = Product(userInput);
			steps++;
        }

		return steps;
    }
    public static void Main(string[] args)
    {
		//largest step count discovered for number 277777788888899

		long highestStepsCount = 0;
		long highestStepsNumber = 0;

		long start = 77551000000;
		long finish = 1000000000000000;

        for (long number = start; number < finish; number++)
        {
			//Console.WriteLine($"{number}: {MultiplicativePersistence(number)}");
			if (MultiplicativePersistence(number) > highestStepsCount)
            {
				highestStepsCount = MultiplicativePersistence(number);
				highestStepsNumber = number;
            }
			if (number % 1000000 == 0)
            {
				Console.WriteLine($"Upto {number} so far: {highestStepsNumber}");
            }
        }

		Console.WriteLine($"Highest step count: {highestStepsNumber} at {highestStepsCount}");
	}
}