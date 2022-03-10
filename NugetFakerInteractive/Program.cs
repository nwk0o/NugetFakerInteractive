using System;

namespace NugetFakerInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            int interactive = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < interactive; i++)
            {
                Console.WriteLine(Faker.Name.FullName());
                Console.WriteLine(Faker.Address.StreetAddress());
                Console.WriteLine(Faker.Identification.DateOfBirth());
                Console.WriteLine(Faker.Identification.UkNationalInsuranceNumber());
                Console.WriteLine(Faker.Identification.UkPassportNumber());
            }
        }
    }
}
