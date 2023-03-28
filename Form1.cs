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
            string Name = this.tbName.Text;
            string Age = this.tbBirthYear.Text;
            int iAge = int.Parse(Age);
            double iGrade = Double.Parse(this.tbGPA.Text);
            Person persons = new Person(Name, iAge, iGrade);
            this.classroom.addPerson2Class(persons);
            this.classroom.addGpa2Class();
            
            this.tbName.Text = "";
            this.tbGPA.Text = "";
            this.tbBirthYear.Text = "";

            this.tbListofPerson.Text = classroom.showAllPersoninclass();
            this.tbTotal.Text = classroom.showAgeAll().ToString();
            this.tbGpaMax.Text = classroom.getMaxGrade().ToString();
            this.tbGpaMin.Text = classroom.getMinGrade().ToString();
            this.tbGpaAvg.Text = classroom.getAvgGrade().ToString();
            this.tbNameMax.Text = classroom.getNameMaxGrade().ToString();
            this.tbMinName.Text = classroom.getNameMinGrade().ToString();  
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