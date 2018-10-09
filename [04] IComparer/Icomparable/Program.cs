using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person() { Name = "Sheldon", Family = "Cooper", NationalCode = "12345852147" },
                new Person() { Name = "John", Family = "Doe", NationalCode = "85252215147" },
                new Person() { Name = "Monica", Family = "Geller", NationalCode = "7453215982" },
                new Person() { Name = "Ross", Family = "Geller", NationalCode = "1593574125" }
            };

            Array.Sort(people);
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
