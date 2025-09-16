using DVLD.BLL.Entities;

namespace DVLD.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Person person = Person.Find("1234");
            


            InitializeComponent();

            if (person == null)
                MessageBox.Show("NUllito!!!!!!!!!!!!!!!");
            else
                MessageBox.Show(person.FirstName + person.LastName);
        }
    }
}
