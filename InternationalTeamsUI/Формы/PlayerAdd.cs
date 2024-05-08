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
    public partial class PlayerAdd : Form
    {
        public PlayerAdd()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            Label label7;
            Label label8;
            Label label9;
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 10;
            label1.Text = "Фамилия:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 18;
            label2.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 20;
            label3.Text = "Возраст:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 22;
            label4.Text = "Псевдоним:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 56);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 25;
            label5.Text = "Ранг:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(311, 87);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 26;
            label6.Text = "Побед:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(641, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 29;
            label7.Text = "Поражений:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(641, 56);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 17);
            label8.TabIndex = 31;
            label8.Text = "Кол-во часов:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(641, 87);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 17);
            label9.TabIndex = 33;
            label9.Text = "Команда:";
            // 
            // button1
            // 
            button1.Location = new Point(13, 115);
            button1.Name = "button1";
            button1.Size = new Size(917, 53);
            button1.TabIndex = 16;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 25);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 25);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 25);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(438, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 25);
            textBox4.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(438, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 25);
            comboBox1.TabIndex = 24;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(438, 84);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 25);
            textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(741, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(189, 25);
            textBox6.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(741, 53);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(189, 25);
            textBox7.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Рекрут", "Страж", "Рыцарь ", "Герой", "Легенда", "Властелин", "Божество", "рекрут", "страж", "рыцарь", "герой", "легенда", "властелин", "божество" });
            comboBox2.Location = new Point(741, 84);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(189, 25);
            comboBox2.TabIndex = 32;
            // 
            // PlayerAdd
            // 
            ClientSize = new Size(942, 189);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PlayerAdd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление игрока";
            TopMost = true;
            Load += PlayerAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox2;

        Form form1;
        private void PlayerAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Form1.Ranks.GetRange(0, Form1.Ranks.Count);
            comboBox2.DataSource = Form1.ListNameTeams.GetRange(0, Form1.ListNameTeams.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty
                    || textBox5.Text == string.Empty || textBox6.Text == string.Empty || textBox7.Text == string.Empty || comboBox1.Text == string.Empty
                    || comboBox2.Text == string.Empty)
                    throw new ApplicationException("Проверьте введенные поля");
                new Player(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, comboBox1.Text, int.Parse(textBox5.Text),
                    int.Parse(textBox6.Text), int.Parse(textBox7.Text), comboBox2.Text);
                form1 = Application.OpenForms[0];
                form1.Show();
                Close();
            }
            catch(FormatException) 
            {
                throw new FormatException("Не правильный формат данных. Проверьте поля.");
            }
        }
    }
}
