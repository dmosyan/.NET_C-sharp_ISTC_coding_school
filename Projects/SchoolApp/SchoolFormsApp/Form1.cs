using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPushToTest_Click(object sender, EventArgs e)
        {
            School testSchool = new School();
            testSchool.Name = txtName.Text;
            testSchool.Address = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.PhoneNumber = txtPhone.Text;
            testSchool.Zip = txtZip.Text;

            try
            {
                testSchool.TwitterAddress = txtTwitter.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());
        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            float gp = teacher.ComputeGradeAverage();
            MessageBox.Show($"Grade average is: {gp}");
        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            float gp = student.ComputeGradeAverage();
            MessageBox.Show($"Grade average is: {gp}");
        }
    }
}
