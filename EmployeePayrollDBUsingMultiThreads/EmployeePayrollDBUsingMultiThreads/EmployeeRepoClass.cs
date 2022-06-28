using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeePayrollDBUsingMultiThreads
{
    public class EmployeeRepoClass
    {
        public static string dbpath = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_Service;Integrated Security=True";
        public List<EmployeePayrollModelClass> employeeList = new List<EmployeePayrollModelClass>();
        public void CreateNewContact(EmployeePayrollModelClass model)
        {
            SqlConnection connect = new SqlConnection(dbpath);
            using (connect)
            {
                connect.Open();                
                SqlCommand sql = new SqlCommand("SP_EmployeeDetails", connect);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Name", model.Name);
                sql.Parameters.AddWithValue("@salary", model.Salary);
                sql.Parameters.AddWithValue("@start", model.Start);
                sql.Parameters.AddWithValue("@Gender", model.Gender);
                sql.Parameters.AddWithValue("@Phone", model.PhoneNo);
                sql.Parameters.AddWithValue("@Address", model.Address);
                sql.Parameters.AddWithValue("@Department", model.Department);
                sql.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                sql.ExecuteNonQuery();
                Console.WriteLine("Record created successfully.");
                connect.Close();
            }
        }
        public void AddNewEmployee(List<EmployeePayrollModelClass> employeeList)
        {
            foreach (EmployeePayrollModelClass employee in employeeList)
            {
                this.CreateNewContact(employee);
                Console.WriteLine("Employee Added: " + employee.Name);
            }
        }
        public void AddNewEmployeeUsingThread(List<EmployeePayrollModelClass> employeeList)
        {
            foreach (EmployeePayrollModelClass employee in employeeList)
            {
                Task Thread = new Task(() =>
                {
                    this.CreateNewContact(employee);
                    Console.WriteLine("Employee Added: " + employee.Name);
                });
                Thread.Start();
            }
        }
    }
}
