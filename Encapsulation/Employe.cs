using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session.Encapsulation
{
   
    
        public struct Employee
        {
            #region attribute
            public int Id;
            private string? EmpName;
            private decimal Empsalary;
        #endregion
        //encapsulation seprate data definition [Attributes]
        //from its uses [getter - setter] -[property]
        #region apply encapsulation [getter - setter] 
        //a privite attributes
        //b two function getter setter
        //getter 
        public string? GetName()
        {
            return EmpName;
        }
        //setter 
        public void SetName(string? Value)
        {
            EmpName = Value?.Length > 6 ? Value.Substring(0, 6) : Value;
        }
        //لو عايز تغير في attributes 
        // ده هيبقي عادي ومش هفيأثر علي المشروع
        #endregion
        #region apply encapsulation through [property]
        public decimal Salary
        {
            get { return Empsalary; }
            set { Empsalary = value <5000?5000:value; }
        }
        //full property
        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}
        //automatic property
        public int age {  get; set; }
        //compiler will generate hidden privite attribute [Backing field]

        //full property =>propfull
        //atumatic prop=>prop
        #endregion
        public decimal Deduction
        {
            get { return Salary * 0.2m; }
        }
        #region Constructor
        public Employee(int id, string name, decimal salary,int age)
            {
                Id = id;
                EmpName = name;
               // this.Empsalary = salary;
               Salary=salary;
            this.age = age;
            }
            #endregion
            #region Methods
            public override string ToString()
            {
                return $"Id={Id}\n Name={EmpName}\n Salary={Empsalary:c}\n age={age}";
            }
            #endregion

        }
    
}
