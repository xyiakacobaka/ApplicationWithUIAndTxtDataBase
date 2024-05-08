namespace InternationalTeamsUI.Формы
{
    partial class PersonsStatus
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 40);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 27);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(132, 74);
            button1.Name = "button1";
            button1.Size = new Size(154, 33);
            button1.TabIndex = 1;
            button1.Text = "Узнать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(400, 27);
            label1.TabIndex = 2;
            label1.Text = "Статус, какой персоны нужно узнать?";
            // 
            // PersonsStatus
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 124);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonsStatus";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Persons";
            TopMost = true;
            Load += PersonsStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
    }
}