//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace Solution
//{
//    public class Solution
//    {

//        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
//        {
//            try
//            {
//                var averageAgeForEachCompany = employees.GroupBy(e => e.Company).ToDictionary(g => g.Key,g => (int)g.Average(e => e.Age));
//                var c = employees.Max(g => g.Age);
//                Console.WriteLine();
//                return averageAgeForEachCompany;

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//                return null;    
//            }

//        }

//        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
//        {
//            var employeeCountByCompany = employees.GroupBy(e => e.Company).ToDictionary(g => g.Key, g => g.Count());


//            return employeeCountByCompany;
//        }

//        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
//        {
//            var oldestAgeForEachCompany = employees.GroupBy(e => e.Company).ToDictionary(g => g.Key, g => g.OrderByDescending(e => e.Age).FirstOrDefault());

//            return oldestAgeForEachCompany;

//        }

//        public static void Main()
//        {
//            int countOfEmployees = int.Parse(Console.ReadLine());

//            var employees = new List<Employee>();

//            for (int i = 0; i < countOfEmployees; i++)
//            {
//                string str = Console.ReadLine();
//                string[] strArr = str.Split(' ');
//                employees.Add(new Employee
//                {
//                    FirstName = strArr[0],
//                    LastName = strArr[1],
//                    Company = strArr[2],
//                    Age = int.Parse(strArr[3])
//                });
//            }

//            foreach (var emp in AverageAgeForEachCompany(employees))
//            {
//                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
//            }

//            foreach (var emp in CountOfEmployeesForEachCompany(employees))
//            {
//                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
//            }

//            foreach (var emp in OldestAgeForEachCompany(employees))
//            {
//                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
//            }
//        }
//    }

//    public class Employee
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int Age { get; set; }
//        public string Company { get; set; }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using ClassLibrary1;

class Program
{
    static void Main(string[] args)
    {

#if !DEBUG

        #region Question 1

        Console.WriteLine("Please Enter number");
        int i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.WriteLine("EVEN");
        }
        else 
        {
            Console.WriteLine("odd");
        }

        Console.ReadLine();

        #endregion


#endif

        #region Question 2

        IEnumerable<int> oddNums = Enumerable.Range(20, 20).Where(x => x % 2 != 0);
        Class1 cs = new Class1();
        cs.function();

        foreach (int n in oddNums)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();


        #endregion

    }

}

