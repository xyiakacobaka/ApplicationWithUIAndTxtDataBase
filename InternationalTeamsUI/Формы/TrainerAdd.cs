using InternationalTeamsUI.Иерархия;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalTeamsUI.Формы
{
    public partial class TrainerAdd : Form
    {
        public TrainerAdd()
        {
            InitializeComponent();
        }
        Form form1;

        private void TrainerAdd_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.ListTrainers.GetRange(0, Form1.ListTrainers.Count);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Trainer trainer = new Trainer(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
                form1 = Application.OpenForms[0];
                form1.Show();
                this.Close();
            }
            catch (FormatException)
            {
                throw new FormatException("Убедитесь в праильности введенного формата");
            }
        }
    }
}
