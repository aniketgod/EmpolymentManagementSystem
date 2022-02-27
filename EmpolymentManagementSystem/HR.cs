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
    public partial class HR : Form
    {
        List<string> auth = new List<string>();
        Main hlogin_id = new Main();
        public HR()
        {
            InitializeComponent();
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
                
                Data.Text= ex.ToString();
            }
            auth = db.Auth(info, Password.Text);
            if (String.Equals(auth[0], "Message: your login is succesfully. welcome in Employment Management System"))
            {
                hlogin_id.id = info;
            }
            Data.Text = auth[0];
        }

        private void EmployeeMode_Click(object sender, EventArgs e)
        {

        }

        private void ManagerMode_Click(object sender, EventArgs e)
        {

        }
        // below method used to logout fromm application
        private void LogOut_Click(object sender, EventArgs e)
        {
            hlogin_id.id = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            auth = db.Number_of_employee(hlogin_id.id);
            Data.Text = auth[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Main person = new Main();
            person = db.Details(hlogin_id.id);
            string data = person.AllDetails;
            Data.Text = data;
            if (person.error_status == false)
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
            catch 
            {
                Data.Text = "your employee id is wrong";
                return;
            }
            person = db.employee_details(hlogin_id.id, info);
            string data = person.AllDetails;
            Data.Text = data;
            if (person.error_status == false)
            {
                Data.Text = person.error;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string res = db.employee_average_salary(hlogin_id.id);
            Data.Text = res;
        }

        private void IdForEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string res;
            res = db.employee_max_min_salary(hlogin_id.id);
            Data.Text = res;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string result = "";
            int info = 100;
            try
            {
                info = Int16.Parse(EmpID.Text);
            }
            catch
            {
                Data.Text = "your employee id is wrong";
                return;
            }
            

            if (!String.Equals(address.Text, "address"))
            {
                string addr = address.Text;
                result = db.insert_update(hlogin_id.id, info, "address", addr);
            }
            if (!String.Equals(employeePassword.Text, "password"))
            {
                string password = employeePassword.Text;
                result = db.insert_update(hlogin_id.id, info, "password", password);
            }
            if (!String.Equals(salary.Text, "salary"))
            {
                string Sal= salary.Text;
                result = db.insert_update(hlogin_id.id, info, "salary", Sal);
            }
            if (!String.Equals(Design.Text, "Desgination"))
            {
                string desgin= Design.Text;
                result = db.insert_update(hlogin_id.id, info, "Desgination", desgin);
            }
            if (!String.Equals(projectAssign.Text, "projectAssign"))
            {
                string project = projectAssign.Text;
                result = db.insert_update(hlogin_id.id, info, "projectAssign", project);
            }
            if (!String.Equals(workUnder.Text, "work_under"))
            {
                string work = workUnder.Text;
                result = db.insert_update(hlogin_id.id, info, "work", work);
            }



            Data.Text = result;
        }
        // below method used for attendance 
        private void button10_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            auth = db.insert_attendance(hlogin_id.id);
            Data.Text = auth[0];
        }

        private void workUnder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
