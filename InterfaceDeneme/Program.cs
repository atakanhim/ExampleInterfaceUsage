using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            };

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salarys = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salarys)
            {
                salary.GetSalary();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();   
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
        Console.WriteLine("Manager Eating");
    }

        public void GetSalary()
        {
        Console.WriteLine("Manager Salary");
    }

        public void Work()
        {
        Console.WriteLine("Manager Working");
        }

       
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
             Console.WriteLine("Worker Eating");
        }

        public void GetSalary()
        {
             Console.WriteLine("Worker Salary");
        }

        public void Work()
        {
             Console.WriteLine("Worker working");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
              Console.WriteLine("Robot working");
        }
    }
}
