using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        private object ConfigurationManager;

        public IEnumerable<Employee> Employees
        {
            get
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                List<Employee> employees = new List<Employee>();
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Employee employee = new Employee();
                        employee.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        employee.EmployeeName = dr["EmployeeName"].ToString();
                        employee.EmployeeGender = dr["EmployeeGender"].ToString();
                        employee.EmployeeDesignation = dr["EmployeeDesignation"].ToString();
                        employees.Add(employee);
                    }
                }
                return employees;
            }
        }

       

        public void AddEmployee(Employee employee)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertEmployeeDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@EmployeeGender", employee.EmployeeGender);
                cmd.Parameters.AddWithValue("@EmployeeDesignation", employee.EmployeeDesignation);

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateEmployee(Employee employee)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@EmployeeGender", employee.EmployeeGender);
                cmd.Parameters.AddWithValue("@EmployeeDesignation", employee.EmployeeDesignation);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteEmployee(int id)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@EmployeeID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}