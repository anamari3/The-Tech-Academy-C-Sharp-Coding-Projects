using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_140Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            List<string> firstnames = new List<string>()
            { "Ana", "Zachary",
            "Joe","Joe",
            "Emmy","Devin",
            "Molly","Cody",
            "Hilary","Erik",};

            List<string> lastname = new List<string>()
            { "Meyer","Leo",
            "Orozco","Daniels",
            "Kitts","Sawa",
            "Good","Limbach",
            "Browning","Miller",};

            List<int> ids = new List<int>()
            { 1,2,3,4,5,6,7,8,9,10};

            int i = 0;
            foreach (string FName in firstnames)
            {
                employees.Add(new Employee (FName, lastname[i], ids[i]));
                i++;
            }

            List<Employee> joes = new List<Employee>();
            int j = 0;
            foreach (string Fname in firstnames)
            {
                if (firstnames =  "Joe")
                {
                    joes.Add(new Employee(Fname, lastname[j], ids[j]));
                }

            }

            string joseph = employees.Where(x => x.fname == firstnames="Joe");

            int bigId = ids.Where(y => y > 5);
            Console.WriteLine(bigId);
            Console.ReadLine();

            }
    }
}
