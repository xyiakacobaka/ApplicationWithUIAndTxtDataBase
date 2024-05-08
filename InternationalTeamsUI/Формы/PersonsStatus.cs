using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using InternationalTeamsUI;
using InternationalTeamsUI.Иерархия;

namespace InternationalTeamsUI.Формы
{
    public partial class PersonsStatus : Form
    {
        public PersonsStatus()
        {
            InitializeComponent();
        }
        Form form1;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Person person in Form1.ListPersons)
            {
                if(comboBox1.Text == person.LastName)
                {
                    person.Status();
                    break;
                }
            }
            form1 = Application.OpenForms[0];
            form1.Show();
            Form1.SerchNickName = comboBox1.Text;
            this.Close();
        }
        private void PersonsStatus_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Form1.ListLastNamePersons.GetRange(0, Form1.ListLastNamePersons.Count);
        }
    }
}
