namespace InternationalTeamsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            ViewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            игрокToolStripMenuItem = new ToolStripMenuItem();
            командаToolStripMenuItem = new ToolStripMenuItem();
            функцииToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            командыToolStripMenuItem = new ToolStripMenuItem();
            игрокаToolStripMenuItem = new ToolStripMenuItem();
            сортировкаToolStripMenuItem = new ToolStripMenuItem();
            поФамильныйToolStripMenuItem = new ToolStripMenuItem();
            поПсевдонимуToolStripMenuItem = new ToolStripMenuItem();
            винрейтToolStripMenuItem = new ToolStripMenuItem();
            потерянноеВремяToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(972, 227);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, ViewToolStripMenuItem, EditToolStripMenuItem, добавитьToolStripMenuItem, функцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(996, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(62, 20);
            CreateToolStripMenuItem.Text = "Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // ViewToolStripMenuItem
            // 
            ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            ViewToolStripMenuItem.Size = new Size(93, 20);
            ViewToolStripMenuItem.Text = "Просмотреть";
            ViewToolStripMenuItem.Click += ViewToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(99, 20);
            EditToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { игрокToolStripMenuItem, командаToolStripMenuItem });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(71, 20);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // игрокToolStripMenuItem
            // 
            игрокToolStripMenuItem.Name = "игрокToolStripMenuItem";
            игрокToolStripMenuItem.Size = new Size(122, 22);
            игрокToolStripMenuItem.Text = "Игрок";
            игрокToolStripMenuItem.Click += игрокToolStripMenuItem_Click;
            // 
            // командаToolStripMenuItem
            // 
            командаToolStripMenuItem.Name = "командаToolStripMenuItem";
            командаToolStripMenuItem.Size = new Size(122, 22);
            командаToolStripMenuItem.Text = "Команда";
            командаToolStripMenuItem.Click += командаToolStripMenuItem_Click;
            // 
            // функцииToolStripMenuItem
            // 
            функцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поискToolStripMenuItem, сортировкаToolStripMenuItem, винрейтToolStripMenuItem, потерянноеВремяToolStripMenuItem });
            функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            функцииToolStripMenuItem.Size = new Size(68, 20);
            функцииToolStripMenuItem.Text = "Функции";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { командыToolStripMenuItem, игрокаToolStripMenuItem });
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(178, 22);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // командыToolStripMenuItem
            // 
            командыToolStripMenuItem.Name = "командыToolStripMenuItem";
            командыToolStripMenuItem.Size = new Size(125, 22);
            командыToolStripMenuItem.Text = "Команды";
            командыToolStripMenuItem.Click += командыToolStripMenuItem_Click;
            // 
            // игрокаToolStripMenuItem
            // 
            игрокаToolStripMenuItem.Name = "игрокаToolStripMenuItem";
            игрокаToolStripMenuItem.Size = new Size(125, 22);
            игрокаToolStripMenuItem.Text = "Игрока";
            игрокаToolStripMenuItem.Click += игрокаToolStripMenuItem_Click;
            // 
            // сортировкаToolStripMenuItem
            // 
            сортировкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поФамильныйToolStripMenuItem, поПсевдонимуToolStripMenuItem });
            сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            сортировкаToolStripMenuItem.Size = new Size(178, 22);
            сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поФамильныйToolStripMenuItem
            // 
            поФамильныйToolStripMenuItem.Name = "поФамильныйToolStripMenuItem";
            поФамильныйToolStripMenuItem.Size = new Size(160, 22);
            поФамильныйToolStripMenuItem.Text = "По фамилии";
            поФамильныйToolStripMenuItem.Click += поФамильныйToolStripMenuItem_Click;
            // 
            // поПсевдонимуToolStripMenuItem
            // 
            поПсевдонимуToolStripMenuItem.Name = "поПсевдонимуToolStripMenuItem";
            поПсевдонимуToolStripMenuItem.Size = new Size(160, 22);
            поПсевдонимуToolStripMenuItem.Text = "По псевдониму";
            поПсевдонимуToolStripMenuItem.Click += поПсевдонимуToolStripMenuItem_Click;
            // 
            // винрейтToolStripMenuItem
            // 
            винрейтToolStripMenuItem.Name = "винрейтToolStripMenuItem";
            винрейтToolStripMenuItem.Size = new Size(178, 22);
            винрейтToolStripMenuItem.Text = "Винрейт";
            винрейтToolStripMenuItem.Click += винрейтToolStripMenuItem_Click;
            // 
            // потерянноеВремяToolStripMenuItem
            // 
            потерянноеВремяToolStripMenuItem.Name = "потерянноеВремяToolStripMenuItem";
            потерянноеВремяToolStripMenuItem.Size = new Size(178, 22);
            потерянноеВремяToolStripMenuItem.Text = "Потерянное время";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 325);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игроки";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem игрокToolStripMenuItem;
        private ToolStripMenuItem командаToolStripMenuItem;
        private ToolStripMenuItem функцииToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem командыToolStripMenuItem;
        private ToolStripMenuItem игрокаToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem поФамильныйToolStripMenuItem;
        private ToolStripMenuItem поПсевдонимуToolStripMenuItem;
        private ToolStripMenuItem винрейтToolStripMenuItem;
        private ToolStripMenuItem потерянноеВремяToolStripMenuItem;
    }
}
