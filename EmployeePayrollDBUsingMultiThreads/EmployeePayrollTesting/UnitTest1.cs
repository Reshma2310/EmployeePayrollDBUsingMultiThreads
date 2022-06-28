using System.Collections.Generic;
using EmployeePayrollDBUsingMultiThreads;
namespace EmployeePayrollTesting
{
    public class Tests
    {
        [Test]
        public void GivenListOfMultipleEmployee_AddIntoDataBase_TestTimeWithout_MutltiThreading()
        {
            List<EmployeePayrollModelClass> employee = new List<EmployeePayrollModelClass>();
            employee.Add(new EmployeePayrollModelClass(Id: 14, Name: "Reshma", Salary: 25000, Start: DateTime.Now, Gender: "Female", PhoneNo: 3333338274, Address: "India", Department: "WedDesigner", BasicPay: 25000, Deductions: 1200, TaxablePay: 1000, NetPay: 22800));
            employee.Add(new EmployeePayrollModelClass(Id: 15, Name: "Basith", Salary: 33000, Start: DateTime.Now, Gender: "Male", PhoneNo: 2222228748, Address: "India", Department: "Software", BasicPay: 33000, Deductions: 1500, TaxablePay: 1100, NetPay: 30400));
            employee.Add(new EmployeePayrollModelClass(Id: 16, Name: "Thanvir", Salary: 40000, Start: DateTime.Now, Gender: "Female", PhoneNo: 2323258768, Address: "India", Department: "Finance", BasicPay: 40000, Deductions: 1700, TaxablePay: 1200, NetPay: 37100));
            employee.Add(new EmployeePayrollModelClass(Id: 17, Name: "Vahidha", Salary: 45000, Start: DateTime.Now, Gender: "Female", PhoneNo: 666674325, Address: "US", Department: "Finance", BasicPay: 45000, Deductions: 1900, TaxablePay: 1300, NetPay: 41800));

            EmployeeRepoClass repo = new EmployeeRepoClass();
            DateTime startTime = DateTime.Now;
            repo.AddNewEmployee(employee);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Time required to add multiple employees without using Thread: " + (endTime - startTime));
        }
    }
}