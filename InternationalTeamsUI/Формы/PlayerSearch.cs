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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InternationalTeamsUI
{
    public partial class PlayerSearch : Form
    {
        Form form1;
        public PlayerSearch()
        {
            InitializeComponent();
        }

        private void PlayerSearch_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Form1.ListNickNames.GetRange(0, Form1.ListNickNames.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = Application.OpenForms[0];
            form1.Show();
            Form1.SerchNickName = comboBox1.Text;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
