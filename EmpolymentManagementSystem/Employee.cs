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
    public partial class Employee : Form
    {
        //  List<Main> Person = new List<Main>();
        List<string> auth=new List<string>();
        Main login_id = new Main();

        public Employee()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
// below method used for attendance 
        private void button4_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            auth = db.insert_attendance(login_id.id);
            Data.Text = auth[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string result = "";
            if (!String.Equals(address.Text, "address"))
            {
                string addr = address.Text;
                result = db.insert_update(login_id.id, login_id.id, "address", addr);
            }
            if (!String.Equals(employeePassword.Text, "password"))
            {
                string password = employeePassword.Text;
                result = db.insert_update(login_id.id, login_id.id, "password", password);
            }



            Data.Text = result;
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
        /*
         Below button used for login employee
         */
        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int info = 100;
            try
            {
               info = Int16.Parse(EmployeeID.Text);
            }
            catch(Exception ex)
            {
                Data.Text = ex.ToString();
                return;
            }
            
            auth = db.Auth(info, Password.Text);
            if(String.Equals(auth[0], "Message: your login is succesfully. welcome in Employment Management System"))
            {
                login_id.id = info;
            }   
            Data.Text = auth[0];

        }

        private void EmployeeDetails_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Main person = new Main();
            person = db.Details(login_id.id);

            if(person.error_status==false)
            {
                Data.Text = person.error;
                return;
            }
            string data = person.AllDetails;
            Data.Text = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HrMode_Click(object sender, EventArgs e)
        {
            HR form = new  HR();
            form.Show();

        }

        private void ManagerMode_Click(object sender, EventArgs e)
        {
            Manager form = new Manager();
            form.Show();
        }
        // below method used to logout fromm application
        private void LogOut_Click(object sender, EventArgs e)
        {
            login_id.id = -1;
            Data.Text = "your logout is successful";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
