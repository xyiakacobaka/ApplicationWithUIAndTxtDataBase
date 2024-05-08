namespace InternationalTeamsUI
{
    partial class TeamAdd
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 26);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 2;
            label2.Text = "выигранных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 3;
            label3.Text = "чемпионатов";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 4;
            label4.Text = "Количество";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 26);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(329, 67);
            button1.Name = "button1";
            button1.Size = new Size(89, 71);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 133);
            dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 142);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 8;
            label5.Text = "Тренер:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 26);
            textBox3.TabIndex = 9;
            // 
            // TeamAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 328);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeamAdd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление команды";
            TopMost = true;
            Load += TeamAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox3;
    }
}