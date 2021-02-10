using System;
using Jobs.Entities;
using Jobs.Entities.Enum;

namespace Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: \n");
            string nameDepartment = Console.ReadLine();
            Console.WriteLine("Enter worker data: \n");
            Console.Write("Name: \n");
            string nameWorker = Console.ReadLine();
            Console.Write("Worker level: \n");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: \n");
            double salary = double.Parse(Console.ReadLine());

            Department department = new Department(nameDepartment);
            Worker worker = new Worker(nameWorker, level, salary, department);

            Console.Write("How many contracts to this worker? \n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)

            {
                Console.WriteLine("Contracts: \n");
                Console.Write("Contract date: \n");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: \n");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("How many hours? \n");
                int hoursWorking = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(dateTime, valueHour, hoursWorking);
                worker.AddContract(hourContract);

            }
            Console.Write("How many contracts do you want to remove? \n");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Incomes: \n");
            Console.Write("Enter month and year to calculate income (MM/YYYY) \n");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: \n" + worker.Name);
            Console.WriteLine("Department: \n" + worker.Department.Name);
            Console.WriteLine("Income for: \n" + monthAndYear + ": " + worker.Income(year, month).ToString());
        }
    }
}
