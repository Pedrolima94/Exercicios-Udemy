using System.Globalization;

namespace NFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados?   ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();


            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Funcionario: {i} ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, nome, salario));
                Console.WriteLine();
            }
            Console.Write("Entre com o id do funcionario que terá o salario aumentado:");
            int procurarid = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == procurarid);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem que sera acrescida: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionarios: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}