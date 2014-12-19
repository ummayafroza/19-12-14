using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentUIForm : Form
    {
        public StudentUIForm()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
   
        

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (students.Count == 3)
            {
                MessageBox.Show("Out Of Range");

            }
            else
            {
                Student student1 = new Student();
                student1.firstName = firstNameTextBox.Text;
                student1.lastName = lastNameTextBox.Text;
                student1.regNo = regNoInputTextBox.Text;
                students.Add(student1);
                MessageBox.Show("Saved");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string value = " ";
            foreach (Student aStudent in students)
            {
                value += aStudent.regNo + "  \t   "  + aStudent.GetFullName()+ "\n";

            }
            MessageBox.Show("Registration Number  FullName \n"+value);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            MessageBox.Show("Clear All Data");
        }
    }
}
