using System.Security.Cryptography.X509Certificates;

namespace Lab04
{
    public partial class Form1 : Form
    {
        private Classroom classroom;

        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_year = this.tbBirthYear.Text;
            int iYear = int.Parse(input_year);
            string input_grade = this.tbGPA.Text;
            double iGrade = double.Parse(input_grade);

            Person person = new Person(input_name, iYear ,iGrade);
            this.classroom.AddPersontoClass(person);


            this.tbListofPerson.Text =
                this.classroom.showAllPersoninClass();

            this.tbTotal.Text = "";
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}