using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Part 2
            #region Q1

            //person[] persons = new person[3];
            //persons[0] = new person(25, "Marwan");
            //persons[1] = new person(9, "Adam");
            //persons[2] = new person(10, "Youssef");


            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            //}

            #endregion

            #region Q2
            //person[] persons = new person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}");
            //    Console.WriteLine("Name: ");

            //    string name = Console.ReadLine();
            //    Console.WriteLine("Age: ");

            //    int age = int.Parse(Console.ReadLine());
            //    persons[i] = new person(age, name);
            //}
            //person oldestPerson = persons[0];
            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if
            //        (persons[i].age > oldestPerson.age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}
            //Console.WriteLine($"The oldest person is {oldestPerson.name} with {oldestPerson.age} years."); 
            #endregion

            //Part 3

            #region Q2
            //Develop a Class to represent the Hiring Date Data:
            //Consisting of fields to hold the day, month and Years.




            //HiringDate hireDate = new HiringDate(09, 25, 2024);
            //Console.WriteLine(hireDate);
            #endregion

            #region Q3
            //Console.WriteLine(Gender.F);
            //Console.WriteLine(Gender.M);
            #endregion

            #region Q4
            //Console.WriteLine(SecurityLevel.Guest);
            //Console.WriteLine(SecurityLevel.Developer);
            //Console.WriteLine(SecurityLevel.Secretary);



            #endregion

            #region Q5

            // 1.We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            // display employee salary in a currency format. [use String.Format Function]



            //Employee[] emp = new Employee[3];

            //Employee emp1 = new Employee(1, "marwan", 'm', SecurityLevel.Guest, 5000, new DateTime(2000, 10, 4));
            //Employee emp2 = new Employee(2, "ahmed", 'm', SecurityLevel.DBA, 5000, new DateTime(2024, 09, 25));
            //Employee emp3 = new Employee(3, "samy", 'm', SecurityLevel.Developer, 5000, new DateTime(2024, 5, 5));



            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);
            //Console.WriteLine(emp3);

            #endregion

        
        }



        #region Demo
        internal class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public void Func1()
            {
                Console.WriteLine("I'm Employee");
            }
            public virtual void Func2()
            {
                Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}");
            }
        }

        internal class FullTimeEmployee : Employee
        {
            public int Salary { get; set; }

            public new void Func1()
            {
                Console.WriteLine("A'M FullTime Employee");
            }
            public override void Func2()
            {
                Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}, Salary {Salary}");
            }
        }

        internal class PartTimeEmployee : Employee
        {
            public int HourRate { get; set; }
            public int CountoFHours { get; set; }
            public new void Func1()
            {
                Console.WriteLine("A'M PartTime Employee");
            }
            public override void Func2()
            {
                Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}, Salary {CountoFHours * HourRate}");
            }
        }
        internal class Program
        {
            #region Poly
            public static void sum(int x, int y)
            {
                Console.WriteLine(x + y);
            }
            public static void sum(int x, int y, int z)
            {
                Console.WriteLine(x + y + z);
            }
            public static void sum(int x, double y)
            {
                Console.WriteLine(x + y);
            }
            public static void sum(double x, double y)
            {
                Console.WriteLine(x + y);
            }
            #endregion

            public static void ProccessEmpolyee(Employee employee)
            {
                if (employee is not null)
                {
                    employee.Func1();//Im Employee => Ref
                    employee.Func2();//Full Part => Object
                }
            }


            static void Main(string[] args)
            {
                #region Polymorphism 
                //// sum(1, 1.5);   

                ////TypeA typeA = new TypeA();
                ////typeA.A = 5;
                ////typeA.Func1();
                ////typeA.Func2();

                //TypeB typeB = new TypeB(5, 10);
                //typeB.Func1();//IM Parent
                //typeB.Func2();// 5
                #endregion

                #region Binding 
                //Ref Parent => Obj Child 
                //TypeA typeA = new TypeB(5, 10);
                //typeA.A = 20;
                //Static  Binding [Early Binding]
                //Compiler => Will Bind Method Call Based on Ref
                // typeA.Func1();
                //Dynamic Binding [Late Binding]
                //Complier => Will Bind Method Call Based on Object 
                //typeA.Func2();//A B
                #endregion

                #region No Binding
                //Type B = new Type A();
                // Dog = animal 
                //TypeA tA = new TypeA(5);
                //TypeB TB =(TypeB) tA;
                #endregion

                //TypeC typeC = new TypeC(5, 6, 7);
                //typeC.Func1();
                //typeC.Func2();

                //TypeA typeA = new TypeC(1, 2, 3);
                //TypeB typeB = new TypeC(4, 5, 6);
                ////typeA.Func1();//Base
                ////typeA.Func2();//A B C
                //TypeA typeA1 = new TypeB(9, 10);
                //typeB.Func1();////Child 
                //typeB.Func2();// A B C

                //typeA1.Func1();//BASE
                //typeA1.Func2();////A B C
                //TypeA typeA = new TypeD(1, 2, 3,4);//InDirect Parent
                //TypeB typeB = new TypeD(4, 5, 6,7);//InDirect Parent
                //TypeC typeC = new TypeD(10,11, 12,13);//Direct Parent

                //typeA.Func2();//A B C D
                //typeB.Func2();//A B C D
                //typeC.Func2();//A B C D
                //typeA.Func1();//A B C D
                //typeB.Func1();//A B C D
                //typeC.Func1();//A B C D

                //TypeA typeA = new TypeE(1, 2, 3, 4,5);//InDirect Parent
                //TypeB typeB = new TypeE(4, 5, 6, 7,8);//InDirect Parent
                //TypeC typeC = new TypeE(10, 11, 12, 13,14);//InDirect Parent
                //TypeD typeD = new TypeE(15, 16, 17, 18, 19);//Direct Parent
                //TypeE typeE = new TypeE(15, 16, 17, 18, 19);//Direct Parent

                ////typeA.Func2();//bASE
                ////typeB.Func2();//cHILD
                ////typeC.Func2();//C
                ////typeD.Func2();
                //typeD.Func2();

                //FullTimeEmployee employee = new FullTimeEmployee();
                //employee.Id = 1;
                //employee.Name = "Ahmed";
                //employee.Age = 25;
                //employee.Salary = 4000;
                //PartTimeEmployee Pemployee = new PartTimeEmployee();
                //Pemployee.Id = 2;
                //Pemployee.Name = "Mohamed";
                //Pemployee.Age = 25;
                //Pemployee.CountoFHours = 60;
                //Pemployee.HourRate = 300;
                //ProccessEmpolyee(Pemployee);
                //ProccessEmpolyee(employee);

            }
        }
        #endregion
    }
}
