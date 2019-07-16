using System;

namespace ClassesAndStructs
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
        }

        struct Employee
        {
            public int EmpId;
            public string FirstName;
            public string LastName;

            public Employee(int empid, string fname, string lname)
            { 
                EmpId = empid;
                FirstName = fname;
                LastName = lname;
            }






        }

    }

}