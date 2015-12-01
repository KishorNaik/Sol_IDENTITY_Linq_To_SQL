using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Identity_LinqSQL
{
    public class EmployeeDAL
    {
        public int AddEmployee(Employee EmpObj)
        {
            try
            {
                ORD.EmployeeDBDataContext DC = new ORD.EmployeeDBDataContext();

                var Query = DC.SpInsertEmployee(EmpObj.FirstName, EmpObj.LastName);

                var IdentityValue = Query.SingleOrDefault().ID;

                return (int)IdentityValue;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Employee AddEmployeeReturnValue(Employee EmpObj)
        {
            try
            {
                ORD.EmployeeDBDataContext DC = new ORD.EmployeeDBDataContext();

                var Query = DC.SpInsertEmployee(EmpObj.FirstName, EmpObj.LastName);

                var QueryReturn = DC.Employees.Where(LE => LE.EmployeeID == Query.SingleOrDefault().ID)
                    .Select(LE=> new Employee() {FirstName=LE.FirstName,LastName=LE.LastName,EmployeeID=(int)LE.EmployeeID}).SingleOrDefault();

                return QueryReturn;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
