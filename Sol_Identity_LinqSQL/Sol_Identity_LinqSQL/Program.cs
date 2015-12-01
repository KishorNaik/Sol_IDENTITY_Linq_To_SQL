using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Identity_LinqSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Read Identity Value from Stored Procedures

            //Object IdentityValue = new EmployeeDAL().AddEmployee(new Employee()
            //{
            //    FirstName="Yogesh",
            //    LastName="Naik"
            //});


            Employee EmpObj = new EmployeeDAL().AddEmployeeReturnValue(new Employee()
            {
                FirstName="Deepika",
                LastName="Naik"
            });

            #endregion
        }
    }
}
