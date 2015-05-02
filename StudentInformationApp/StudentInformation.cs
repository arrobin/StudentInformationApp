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
    public partial class StudentInformation : Form
    {

        List<Student> studentList = new List<Student>();
        
        public StudentInformation()
        {
            InitializeComponent();
        }

           
        private void addButton_Click(object sender, EventArgs e)
        {

            if (studentList.Count<3)
            {
                Student aStudent = new Student();
                aStudent.regNo = regNoTextBox.Text;
                aStudent.firstName = firstNameTextBox.Text;
                aStudent.lastName = lastNameTextBox.Text;

                studentList.Add(aStudent);
                MessageBox.Show("Student Added");
                
            }
            else
            {
                MessageBox.Show("You Can Add Maximum 3 Student");
            }
            
            Clear();

        }

        private void Clear()
        {
            regNoTextBox.Clear();
            firstNameTextBox.Clear(); 
            lastNameTextBox.Clear();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            
            string studentInfo = "RegNo\tName\n";

            foreach (Student student in studentList)
            {
                studentInfo = studentInfo + student.regNo + "\t" + student.firstName + " " + student.lastName + "\n";
            }

            MessageBox.Show(studentInfo);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           studentList=new List<Student>();
        }
    }
}
