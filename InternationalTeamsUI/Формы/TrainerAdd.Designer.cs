namespace InternationalTeamsUI.Формы
{
    partial class TrainerAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label5;
            Label label4;
            Label label3;
            Label label2;
            Label label1;
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 43;
            label5.Text = "Опыт:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 65);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 40;
            label4.Text = "Оклад:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 38;
            label3.Text = "Возраст:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 36;
            label2.Text = "Имя:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 34;
            label1.Text = "Фамилия:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(408, 62);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 26);
            textBox5.TabIndex = 45;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(408, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 26);
            textBox4.TabIndex = 41;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 26);
            textBox3.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 26);
            textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 26);
            textBox1.TabIndex = 35;
            // 
            // button1
            // 
            button1.Location = new Point(588, 20);
            button1.Name = "button1";
            button1.Size = new Size(90, 81);
            button1.TabIndex = 46;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(666, 225);
            dataGridView1.TabIndex = 47;
            // 
            // TrainerAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 364);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainerAdd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление тренера";
            TopMost = true;
            Load += TrainerAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}