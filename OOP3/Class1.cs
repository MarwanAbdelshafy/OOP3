using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{

    internal struct person
    {
        public int age;
        public string name;



        public person(int Age, string Name)
        {
            age = Age; name = Name;
        }

    }

    public enum Gender {M,F}
        public enum SecurityLevel { Guest, Developer, Secretary, DBA }

    public class Employee
    {
        public int ID;
        public string Name;
        public char Gender;
        public SecurityLevel SecurityLevel;
        public decimal Salary;
        public DateTime HireDate;

        public Employee(int id, string name, char gender, SecurityLevel securityLevel, decimal salary, DateTime hiredate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hiredate;
        }
        public override string ToString()
        {
            return string.Format($"id : {ID},name : {Name} ,gender :{Gender}, salary: {Salary},hiredate :{HireDate}");
        }
    }


    public class HiringDate
    {
        public int Day;
        public int Month;
        public int Year;

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }


}
