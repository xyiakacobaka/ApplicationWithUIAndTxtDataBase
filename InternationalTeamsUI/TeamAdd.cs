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
using InternationalTeamsUI.Иерархия;

namespace InternationalTeamsUI
{
    public partial class TeamAdd : Form
    {
        Form form1;

        public TeamAdd()
        {
            InitializeComponent();

        }
        private void DGVProperties()
        {
            dataGridView1.DataSource = Form1.ListTeams.GetRange(0, Form1.ListTeams.Count);
            dataGridView1.Columns["Name"].DisplayIndex = 0;
            dataGridView1.Columns["Count"].DisplayIndex = 1;
            dataGridView1.Columns["Trainer"].DisplayIndex = 2;            
            /****************************************************************/
            /*********************Изменение имени столбца********************/
            /****************************************************************/
            dataGridView1.Columns["Name"].HeaderText = "Название";
            dataGridView1.Columns["Count"].HeaderText = "Количество выигранных турниров";
            dataGridView1.Columns["Trainer"].HeaderText = "Тренер";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                throw new ApplicationException("Проверьте введенные поля");
            form1 = Application.OpenForms[0];
            form1.Show();
            new Team(textBox1.Text, Int32.Parse(textBox2.Text),textBox3.Text);
            this.Close();
        }

        private void TeamAdd_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Form1.ListTeams.GetRange(0, Form1.ListTeams.Count);
            DGVProperties();
        }
    }
}
