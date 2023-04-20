using PessoaSalarioEmail.Entities;
using System.Globalization;

namespace PessoaSalarioEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path");
            string path = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            List<Product> list = new List<Product>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Product(name, email, salary));
                    }
                }


                var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine("Sum of salary of people whose name starts with 'M' :" + sum.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
