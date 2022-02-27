using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
namespace EmpolymentManagementSystem
{
    class DataAccess
    {

        /*
         Below mehthod used for authhenication of user
        */
        public List<string> Auth(int login_id, string Password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                Main Output = new Main();
                List<string> message = new List<string>();
                var sq= "select * from employDetails where id ="+login_id;
                try
                    {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch 
                {
                    message.Add("Message: your login is unsucessfully! your employee id does not exist");
                    return message;
                }

                message.Clear();
                if (Output.password!=Password)
                {
                    message.Add("Message: your login is unsucessfully! kindlly give your right password");
                    return message;
                }
                message.Clear();
                message.Add("Message: your login is succesfully. welcome in Employment Management System");

                return message;
            }
        }
        public List<string> insert_attendance(int login_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                Main Output = new Main();
                var sq = "select * from employDetails where id =" + login_id;
                List<string> message = new List<string>();
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch 
                {
                    message.Add("Message: you are not login");
                    return message;
                }
                
                int attend = Output.attendance;
                int result;
                result=attend+1;

                if (result > 22)
                {
                    result = 1;
                    sq = "UPDATE employDetais SET attendance =" + result + "where id=" + login_id;
                    try
                    {
                        connection.Execute(sq);
                    }
                    catch (Exception ex)
                    {
                        message.Clear();
                        message.Add(ex.ToString());
                        return message;
                    }
                    message.Clear();
                    message.Add("Message: you succesfully mark your attendance.");
                    return message;

                }
                
                sq = "update employDetails SET attendance =" + result + "where id=" + login_id;
                try
                {
                    connection.Execute(sq);
                }
                catch (Exception ex)
                {
                    message.Clear();
                    message.Add(ex.ToString());
                    return message;
                }
                
                message.Clear();
                message.Add("Message: you succesfully mark your attendance.");
                return message;                                  

                
            }

        }
        public List<string> Number_of_employee(int login_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                Main Output = new Main();
                var sq = "select * from employDetails where id =" + login_id;
                List<string> message = new List<string>();
          
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch
                {
                    message.Add("Message: you are not login");
                    return message;
                }
                message.Clear();
                sq = "select count(*) from employdetails";
                int result = connection.QuerySingle<int>(sq);
                message.Add("Message: Number of employee in XYZ company is "+result);
                return message;
            }


        }
        public   Main Details(int login_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                 Main Output = new Main();
                var sq = "select * from employDetails where id =" + login_id;
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch 
                {
                    Output.error="Message: you are not login";
                    Output.error_status = false;
                    return Output;
                }
                return Output;
            }

        }
        
        public string insert_update(int login_id, int id, string colname, string data)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                Main Output = new Main();


                var sq = "select * from employDetails where id =" + login_id;
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch 
                {
                  return  "Message: you are not login";
                   
                }
                List<string> message = new List<string>();
                if (String.Equals(colname, "address"))
                {
                    try
                    {
                        connection.Execute("UPDATE employDetails SET address= @uk  where id =@_id ", new { uk = data, _id = id });

                    }
                    catch(Exception ex)
                    {
                        return ex.ToString();
                    }
                    
                }
                else if (String.Equals(colname, "password"))
                {
                    try
                    {
                        connection.Execute("UPDATE employDetails SET password= @uk  where id =@_id ", new { uk = data, _id = id });

                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                else if (String.Equals(colname, "salary"))
                {
                    try
                    {
                        connection.Execute("UPDATE employDetails SET salary= @uk  where id =@_id ", new { uk = data, _id = id });

                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                else if (String.Equals(colname, "projectAssign"))
                {
                    try
                    {
                        connection.Execute("UPDATE employDetails SET projectAssign= @uk  where id =@_id ", new { uk = data, _id = id });

                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                else if (String.Equals(colname, "Desgination"))
                {
                    try
                    {
                        connection.Execute("UPDATE employDetails SET Desgination= @uk  where id =@_id ", new { uk = data, _id = id });

                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                else if (String.Equals(colname, "work_under"))
                {
                    try
                    {
                        connection.Execute("UPDATE employDetails SET workUnder= @uk  where id =@_id ", new { uk = data, _id = id });

                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                return "Update is successfull";
            }
        }
        
        public Main employee_details(int login_id, int info)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                Main Output = new Main();
                var sq = "select * from employDetails where id =" + login_id;
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch 
                {
                    Output.error = "Message: you are not login";
                    Output.error_status = false;
                    return Output;
                }
                sq = "select * from employDetails where id =" + info;
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch (Exception ex)
                {
                    Output.error = ex.ToString();
                    Output.error_status = false;
                    return Output;
                }
                return Output;
            }
        }
    // max_min salary    
        public string employee_max_min_salary(int login_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                Main Output = new Main();
                var sq = "select * from employDetails where id =" + login_id;
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch 
                {
                    return "Message: you are not login";

                }
                sq = "SELECT * FROM employDetails where id  = (SELECT Min(id) FROM employDetails where salary=(SELECT MAX(salary) FROM employDetails))";
                Output= connection.QuerySingle<Main>(sq);
                string result = "";
                string nline = Environment.NewLine;
                result = result + "Maximum salary = "+Output.salary + nline + "id = " + Output.id + nline + "First Name = " + Output.firstName + nline + "Last Name = " + Output.lastName + nline;
                sq = "SELECT * FROM employDetails where id  = (SELECT Min(id) FROM employDetails where salary = (SELECT Min(salary) FROM employDetails))";
                Output = connection.QuerySingle<Main>(sq);
                result = result + "Minimum salary = " + Output.salary + nline + "id = " + Output.id + nline + "First Name = " + Output.firstName + nline + "Last Name = " + Output.lastName + nline;
                return result;
            }
        }
 // average salary
        public string employee_average_salary(int login_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.connectdb("employDetails")))
            {
                Main Output = new Main();
                var sq = "select * from employDetails where id =" + login_id;
                try
                {
                    Output = connection.QuerySingle<Main>(sq);
                }
                catch 
                {
                    return "Message: you are not login";

                }
                sq = "SELECT AVG(salary) FROM employDetails";
                int avgsalary = connection.QuerySingle<int>(sq);
                string result = "";
                string nline = Environment.NewLine;
                result = result + "Average salary = " + avgsalary + nline;
                return result;
            }
        }
    }
}
