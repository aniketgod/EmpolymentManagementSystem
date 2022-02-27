using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpolymentManagementSystem
{
    public partial class Manager : Form
    {
        List<string> auth = new List<string>();
        Main mlogin_id = new Main();
        public Manager()
        {
            InitializeComponent();

          
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
        // below method used for login button
        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int info = 100;
            try
            {
                info = Int16.Parse(EmployeeID.Text);
            }
            catch (Exception ex)
            {
                Data.Text = ex.ToString();
                return;

            }
            auth = db.Auth(info, Password.Text);
            if (String.Equals(auth[0], "Message: your login is succesfully. welcome in Employment Management System"))
            {
                mlogin_id.id = info;
            }
            Data.Text = auth[0];
        }

        private void EmployeeMode_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.Show();
        }

        private void HrMode_Click(object sender, EventArgs e)
        {
             HR form = new HR();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        // below method used to logout fromm application
        private void LogOut_Click(object sender, EventArgs e)
        {
            mlogin_id.id = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            auth = db.Number_of_employee(mlogin_id.id);
            Data.Text = auth[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Main person = new Main();
            person = db.Details(mlogin_id.id);
            string data = person.AllDetails;
            Data.Text = data;
            if (person.error_status==false)
            {
                Data.Text = person.error;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Main person = new Main();
            int info = 100;
            try
            {
                info = Int16.Parse(IdForEmployee.Text);
            }
            catch (Exception)
            {
                Data.Text = "Employee Id is wrong";
                return;

            }
            person = db.employee_details(mlogin_id.id,info);
            string data = person.AllDetails;
            Data.Text = data;
            if (person.error_status==false)
            {
                Data.Text = person.error;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string res;
            res = db.employee_max_min_salary(mlogin_id.id);
            Data.Text = res;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string res;
            res = db.employee_average_salary(mlogin_id.id);
            Data.Text = res;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string result = "";
            if (!String.Equals(address.Text, "address"))
            {
                string addr = address.Text;
                result = db.insert_update(mlogin_id.id, mlogin_id.id, "address", addr);
            }
            if (!String.Equals(employeePassword.Text, "password"))
            {
                string password = employeePassword.Text;
                result = db.insert_update(mlogin_id.id, mlogin_id.id, "password", password);
            }



            Data.Text = result;
        }
        // below method used for attendance 
        private void EmployeeAttendance_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            auth = db.insert_attendance(mlogin_id.id);
            Data.Text = auth[0];
        }
    }
}
