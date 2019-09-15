using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }






        public static void Pattern1()
        {
            var customers = new[] {
                    new { Name = "Annie", Email = "annie@test.com" },
                    new { Name = "Ben", Email = "" },
                    new { Name = "Lily", Email = "lily@test.com" },
                    new { Name = "Joel", Email = "joel@test.com" },
                    new { Name = "Sam", Email = "" },
            };

            foreach (var customer in customers.Where(x => !string.IsNullOrEmpty(x.Email)).ToList())
            {
                Console.WriteLine("Sending email to " + customer.Name);

            }
        }
        public static void MotorSportScore() {
            string score = "10,5,0,8,10,1,4,0,10,1";

            var total = score.Split(',')
                .OrderBy(x => int.Parse(x))
                .Select(x =>
                {
                    Console.WriteLine(x);
                    return int.Parse(x);
                })
                .Skip(3)
                .Sum();

            Console.WriteLine(total);
        }
    }
}
