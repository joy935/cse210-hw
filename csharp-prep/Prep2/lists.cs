using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        

        float number = 1;
        List<float> numbers = new List<float>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        float sum = 0;
        float largest = 0;
        float smallest = 99999;
        foreach (int oneNumber in numbers)
        {
            sum += oneNumber;
            if (oneNumber > largest) 
            {
                largest = oneNumber;
            }
            else if (oneNumber < smallest && oneNumber > 0)
            {
                smallest = oneNumber;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        float lenNumbers = (numbers.Count - 1);
        float average = sum / lenNumbers;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");

        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.RemoveAt(numbers.Count - 1);
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }


        


    }
}