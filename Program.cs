using session.Encapsulation;
using session.Inhertance;
using System.Xml.Linq;

namespace session
{
    internal class Program
    {
        static void main(string[] args)

        {
            #region encapsulation
            //Employee employee = new Employee(10, "bassim", 2000,20);
            //Console.WriteLine(employee);
            //   Id = 10
            // Name = bassim
            //Salary =2,000.00
            //Console.WriteLine(employee);
            //employee.Id = 1;//set ID directly through attributes
            ////Console.WriteLine(employee);//get id through attributes
            //employee.SetName("bassim ahmed");

            //Console.WriteLine(employee.GetName());
            //employee.Salary = 6000;
            //Console.WriteLine(employee.Salary);
            //employee.age = 10;
            //Console.WriteLine(employee);
            //Console.WriteLine(employee.Deduction);
            #endregion
            #region indexer

            Phonebook phonebook = new Phonebook(3);
            phonebook.AddPerson(0,"bassim", 123123);
            phonebook.AddPerson(1,"ahmed", 1223);
            phonebook.AddPerson(2,"ali", 1234556);

            //int phoneNUmber = phonebook.GetPersonNumber("ali");
            //Console.WriteLine(phoneNUmber == -1?"not found":phoneNUmber);
            //phonebook.SetPersonNumber("ali", 9999);
            //Console.WriteLine(phonebook.GetPersonNumber("ali"));
            //phonebook["ali"] = 1999;
            //Console.WriteLine(phonebook["ali"]);
            //string name = "bassim";
            //Console.WriteLine(name[0]);
            //indexer of string only get
            //for (int i = 0; i < phonebook.Size; i++){
            //    Console.WriteLine(phonebook[i]);

            //}
            #endregion
            #region class
            //Car c1;
            ////declare refrence type from type car
            ////can refrence to an object from type car 
            ////or an object from class [Inhertance from car]
            ////clr woll allocating 4 bytes for refrence "c1" at stack
            ////zero bytes allocate to heap
            //c1 = new Car();
            //// 1-allocate required Bytes [16 bytes ] at heap
            //// 2-ontialize the allocated bytes with default value of data type
            ////3- call user dfined constructor[if exists]
            ////4-assign the refrence "c1 " to allocated oblect at heap
            //Console.WriteLine(c1);

            //Car c1=new Car(1);
            //Console.WriteLine(c1);
            #endregion
            #region inhertance
            //Parent p=new Parent(1,2);
            //Console.WriteLine($"p={p}");//(1,2)
            //Console.WriteLine($"procuct={p.product()}");//2
            Child C = new Child(3, 4, 5);
            Console.WriteLine($"c={C}");
            Console.WriteLine($"procuct={C.product()}");
            #endregion
        }
    }
}
