using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(BugfixingLeaderSorted(new int[] { 1, 2, 4, 4, 4 }));
            Console.ReadKey();
            /*
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Anuj", 34));
            employees.Add(new Employee("Bhavna", 30));
            employees.Add(new Employee("Rahul", 36));
            employees.Add(new Employee("Preeti", 34));


            List<Employee> result = employees.FindAll(x => x.Age == 34);
            employees.Find(new Predicate<Employee>(function(Employee emp){ return employees.}));
            employees.Find(delegate (Employee emp) { return emp.Age == 34; });
            */
        }


        public static int Permuation(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A == null || A.Length == 0)
                return 0;
            else
            {
                Array.Sort(A);
                if (A[A.Length - 1] == A.Length)
                    return 1;
                else
                    return 0;
            }
        }


        public static int BugfixingLeaderSorted(int[] A)
        {
            int n = A.Length;
            int[] L = new int[n + 1];
            L[0] = -1;
            for (int i = 0; i < n; i++)
            {
                L[i + 1] = A[i];
            }
            int count = 0;
            int pos = (n + 1) / 2;
            int candidate = L[pos];
            for (int i = 1; i <= n; i++)
            {
                if (L[i] == candidate)
                count = count + 1;
            }
            if (count >= pos)
                return candidate;
            return (-1);
        }


        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Employee(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }
    }
}
