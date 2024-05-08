using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace InternationalTeamsUI
{
    public partial class TeamSearch : Form
    {
        Form form1;
        public TeamSearch()
        {
            InitializeComponent();
        }

        private void TeamSearch_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Form1.ListNameTeams;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)
                throw new ApplicationException("Проверьте введенные поля");
            form1 = Application.OpenForms[0];
            form1.Show();
            Form1.SerchTeam = comboBox1.Text;
            this.Close();
        }
    }
}
