using System.Security.Cryptography.X509Certificates;

namespace Lab04
{
    public partial class Form1 : Form
    {   
        Classroom classroom;
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
            string iName = this.tbName.Text;
            string Age = this.tbBirthYear.Text;
            int iAge = int.Parse(Age);
            double iGrade = Double.Parse(this.tbGPA.Text);
            Person persons = new Person(iName, iAge, iGrade);
            this.tbName.Text = "";
            this.tbGPA.Text = "";
            this.tbBirthYear.Text = "";
            
            tbGpaAvg.Text = classroom.getGpaAvg().ToString();
            this.classroom.addPersonToClass(persons);
            tbListofPerson.Text = classroom.showAllPersoninclass();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGPA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}