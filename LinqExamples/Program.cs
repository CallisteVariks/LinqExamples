using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqExamplesTest();
        }

        public static void LinqExamplesTest()
        {
            int[] numbers = new int[] { 1, 2, 3, 5, 5, 1, 2, 3, 3, 5, 3, 2, 6, 3, 2, 1, 4, 5, 3, 5, 1, 3 };
            int[] otherNumbers = new int[] { 1, 2, 3 };

            // Does the list contain any elements
            bool anyElements = numbers.Length > 0;
            anyElements = numbers.Any();


            // Sum of the numbers in the list
            int sum = 0;
            foreach (var item in numbers)
                sum += item;
            sum = numbers.Sum();


            // How many even numbers are there in the list (using the method below)
            int evenNumbers = 0;
            foreach (var item in numbers)
                if (IsEvenNumber(item))
                    evenNumbers++;
            evenNumbers = numbers.Count(IsEvenNumber);


            // What is the average of the numbers in the list
            sum = 0;
            foreach (var item in numbers)
                sum += item;

            double avg = sum / numbers.Length;

            avg = numbers.Average();

            numbers.DefaultIfEmpty(0).Average();


            // What are the distinct values in the list
            var distinct = numbers.Distinct();


            // How many are there of each number?
            var grouped = numbers.GroupBy(number => number);
            foreach (var group in grouped)
                Console.WriteLine($"{group.Key} - {group.Count()}");


            // One list except another
            var excepr = numbers.Except(otherNumbers);


            // One list plus another
            var plusAnother = numbers.Concat(otherNumbers);




            List<Person> persons = new List<Person>
            {

                new Person { Age = 10, Gender = Gender.Female, Name = "2" },
                new Person { Age = 40, Gender = Gender.Male, Name = "5" },
                new Person { Age = 20, Gender = Gender.Male, Name = "3" },
                new Person { Age = 10, Gender = Gender.Female, Name = "1"},
                new Person { Age = 30, Gender = Gender.Male, Name = "4"},
            };

            // Get the first value
            // Get the last value
            var first = persons.FirstOrDefault(person => person.Gender == Gender.Other);
            var last = persons.LastOrDefault(person => person.Gender == Gender.Other);


            // Sort a list
            var sorted = persons.OrderBy(person => person.Age).ThenBy(person => person.Gender);

            // Get the lowest number
            var minAge = persons.Min(person => person.Age);

            // Get the highest value
            var maxAge = persons.Max(person => person.Age);


            // Where
            var where = persons.Where(person => person.Gender == Gender.Female)
                               .Where(person => person.Name == "1");


            // Single
            var single = persons.FirstOrDefault(person => person.Gender == Gender.Female && person.Name == "2123123");


            var groupPersons = persons.GroupBy(person => person.Gender);
            foreach (var group in groupPersons)
                group.First();


            // Select
            var select = persons.Where(person => person.Gender == Gender.Female)
                                .Select(person => person.Name);


            // ToList
            List<string> newListOfPersons = select.ToList();

        }

        private static bool IsEvenNumber(int number) => number % 2 == 0; 
    }
}
