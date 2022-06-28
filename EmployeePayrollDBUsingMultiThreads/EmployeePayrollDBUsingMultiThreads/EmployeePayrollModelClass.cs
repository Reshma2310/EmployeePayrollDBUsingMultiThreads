using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollDBUsingMultiThreads
{
    public class EmployeePayrollModelClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime Start { get; set; }
        public string Gender { get; set; }
        public decimal PhoneNo { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double NetPay { get; set; }
        public EmployeePayrollModelClass(int Id, string Name, double Salary, DateTime Start, string Gender, decimal PhoneNo, string Address,
            string Department, double BasicPay, double Deductions, double TaxablePay, double NetPay)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.Start = Start;
            this.Gender = Gender;
            this.PhoneNo = PhoneNo;
            this.Address = Address;
            this.Department = Department;
            this.BasicPay = BasicPay;
            this.Deductions = Deductions;
            this.TaxablePay = TaxablePay;
            this.NetPay = NetPay;
        }
    }
}
