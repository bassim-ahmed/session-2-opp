namespace assignment
{
    //public struct Person
    //{
    #region attributes
    //private string[] Name;
    //private int[] Age;
    #endregion
    #region property
    //public int Size { get; }
    #endregion
    #region constructor
    //public Person(int size)
    //{
    //    Size = size;
    //    Name = new string[size];
    //    Age = new int[size];
    //}
    #endregion
    #region methods
    //public void AddPerson(int position, string PersonName, int PersonAge)
    //{
    //    if (Name is not null && Age is not null && position < Size)
    //    {
    //        Name[position] = PersonName;
    //        Age[position] = PersonAge;
    //    }


    //}
    //public int this[string name]
    //{
    //    get
    //    {
    //        if (Name is not null && Age is not null)
    //        {
    //            for (int i = 0; i < name.Length; i++)
    //            {
    //                if (Name[i] == name)
    //                {
    //                    return Age[i];
    //                }
    //            }
    //        }
    //        return -1;

    //    }
    //}
    //public string this[int index]
    //{
    //    get
    //    {
    //        return $"{index}::{Name[index]}::{Age[index]}";
    //    }

    //}

    #endregion
    //}
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    #region part 3
    public class Employee
    {
        // Properties
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public GenderType Gender { get; set; }
        public SecurityPrivilege Privilege { get; set; }


        // Constructor
        public Employee(int employeeId, string name, int securityLevel, decimal salary, DateTime hireDate, GenderType gender, SecurityPrivilege privilege)
        {
            EmployeeId = employeeId;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
            Privilege = privilege;
        }
        #region part3 (3)
        // Enum for Gender
        public enum GenderType
        {
            M,
            F
           
        }

        #endregion
        #region part 3 (4)
       
        public enum SecurityPrivilege
        {
            Guest ,
            Developer ,
            Secretary ,
            DBA 
        }
        #endregion
        #region part 3 (5)
        public override string ToString()
        {
          
            string formattedSalary = string.Format("{0:C}", Salary);

            return $"Employee ID: {EmployeeId}\nName: {Name}\nSecurity Level: {SecurityLevel}\nSalary: {formattedSalary}\nHire Date: {HireDate.ToShortDateString()}\nGender: {Gender}\nPrivilege: {Privilege}";
        }
        #endregion
    }
    #endregion
    #region part 2 (2)
    public class HiringDate
    {
        // Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // Method 
        public string GetFormattedDate()
        {
            return $"{Month:D2}/{Day:D2}/{Year}";
        }
    }
    #endregion

    internal class assignment
    {
        static void Main(string[] args)
        {
            #region part 2 (1)
            //Person persons = new Person(3);

            //persons.AddPerson(0,"bassim", 24);
            //persons.AddPerson(1, "ahmed", 24);
            //persons.AddPerson(2, "kamal", 24);
            //for (int i = 0; i < persons.Size; i++)
            //{
            //    Console.WriteLine(persons[i]);

            //}
            #endregion
            #region part 2 (2)

            //    Person[] people = new Person[3];

            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine($"Enter details for person {i + 1}:");
            //        Console.Write("Name: ");
            //        string name = Console.ReadLine();
            //        Console.Write("Age: ");
            //        int age = int.Parse(Console.ReadLine());

            //        people[i] = new Person { Name = name, Age = age };
            //    }


            //    Person oldestPerson = GetOldestPerson(people);


            //    Console.WriteLine($"The oldest person is {oldestPerson.Name}, aged {oldestPerson.Age}.");
            //}

            //static Person GetOldestPerson(Person[] people)
            //{
            //    Person oldest = people[0];
            //    foreach (var person in people)
            //    {
            //        if (person.Age > oldest.Age)
            //            oldest = person;
            //    }
            //    return oldest;
            //}
            #endregion
            #region part 3 (6)

            Employee[] EmpArr = new Employee[3];

         
            EmpArr[0] = new Employee(101, "bassim ahmed", 3, 75000, DateTime.Parse("2022-01-15"), Employee.GenderType.M, Employee.SecurityPrivilege.DBA);
            EmpArr[1] = new Employee(102, "ismael mohamed", 1, 50000, DateTime.Parse("2023-03-10"), Employee.GenderType.F, Employee.SecurityPrivilege.Guest);
            EmpArr[2] = new Employee(103, "mohamed anour", 5, 90000, DateTime.Parse("2021-11-20"), Employee.GenderType.M, Employee.SecurityPrivilege.Secretary);

         
            foreach (var emp in EmpArr)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeId}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Security Level: {emp.SecurityLevel}");
                Console.WriteLine($"Salary: {emp.Salary:C}");
                Console.WriteLine($"Hire Date: {emp.HireDate.ToShortDateString()}");
                Console.WriteLine($"Gender: {emp.Gender}");
                Console.WriteLine($"Privilege: {emp.Privilege}");
                Console.WriteLine();
            }
            #endregion
        }
    }
}


