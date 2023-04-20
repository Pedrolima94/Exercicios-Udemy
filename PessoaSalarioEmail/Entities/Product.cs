
namespace PessoaSalarioEmail.Entities
{
    internal class Product
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Product(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
