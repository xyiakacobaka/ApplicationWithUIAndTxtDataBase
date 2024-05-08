using InternationalTeamsUI.��������;
using InternationalTeamsUI.����������;
using InternationalTeamsUI.�����;
using System;
using System.Numerics;

namespace InternationalTeamsUI
{
    public partial class Form1 : Form
    {
        /*********************************���������**********************************/
        static public List<Team> ListTeams = new List<Team>();
        static public List<string> ListNameTeams = new List<string>();
        static public List<Player> ListPlayers = new List<Player>();
        static public List<string> ListNickNames = new List<string>();
        static public List<Trainer> ListTrainers = new List<Trainer>();
        static public List<string> ListTrainersLastName = new List<string>();
        static public List<Person> ListPersons = new List<Person>();
        static public List<string> ListLastNamePersons = new List<string>();
        static public List<string> Ranks = ["������", "�����", "������", "�����", "�������", "���������", "��������"];
        /******************************����������� ����******************************/
        static public string SerchNickName;
        static public string SerchTeam;
        private List<Player> FindedPlayers = new List<Player>();
        /************************************�����***********************************/
        TeamAdd teamAdd = new TeamAdd();
        PlayerAdd playerAdd = new PlayerAdd();
        PlayerSearch playerSearch = new PlayerSearch();
        TeamSearch teamSearch = new TeamSearch();
        PersonsStatus personStatus = new PersonsStatus();
        TrainerAdd trainerAdd = new TrainerAdd();
        /*********************************����������*********************************/
        PlayerLastNameComparer playerLastNameComparer = new PlayerLastNameComparer();
        PlayerNickNameComparer playerNickNameComparer = new PlayerNickNameComparer();
        private bool FamilySwitcher = false;
        private bool NickNameSwitcher = false;
        public Form1()
        {
            InitializeComponent();
        }
        /***********************��������� DataGridView*******************************/
        private void DGVProperties()
        {
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
            dataGridView1.Columns["LastName"].DisplayIndex = 0;
            dataGridView1.Columns["Name"].DisplayIndex = 1;
            dataGridView1.Columns["Age"].DisplayIndex = 2;
            dataGridView1.Columns["NickName"].DisplayIndex = 3;
            dataGridView1.Columns["Rank"].DisplayIndex = 4;
            dataGridView1.Columns["WinGames"].DisplayIndex = 5;
            dataGridView1.Columns["LoseGames"].DisplayIndex = 6;
            dataGridView1.Columns["HoursInDota"].DisplayIndex = 7;
            dataGridView1.Columns["Team"].DisplayIndex = 8;
            /*********************��������� ����� �������********************/
            dataGridView1.Columns["LastName"].HeaderText = "�������";
            dataGridView1.Columns["Name"].HeaderText = "���";
            dataGridView1.Columns["Age"].HeaderText = "�������";
            dataGridView1.Columns["NickName"].HeaderText = "���������";
            dataGridView1.Columns["Rank"].HeaderText = "����";
            dataGridView1.Columns["WinGames"].HeaderText = "�����";
            dataGridView1.Columns["LoseGames"].HeaderText = "���������";
            dataGridView1.Columns["HoursInDota"].HeaderText = "����� � ����";
            dataGridView1.Columns["Team"].HeaderText = "�������";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProperties();

        }
        /*****************************�������� ���� ������***************************/
        private bool PlCheck(string str)
        {
            foreach (Player player in ListPlayers)
            {
                if (str == player.NickName)
                {
                    return false;
                }
            }
            return true;
        }
        private bool TmCheck(string str)
        {
            foreach (Team team in ListTeams)
            {
                if (str == team.Name)
                {
                    return false;
                }
            }
            return true;
        }
        /***********************�������� ���� ��������� ���������**********************/
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListPlayers.Count != 0)
            {
                /*************************������ � Teams.txt*********************/
                StreamWriter writer = new StreamWriter("Teams.txt", false);
                writer.WriteLine("��������;���;�����;������");
                foreach (Team item in ListTeams)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Close();
                /*************************������ � Players.txt*******************/
                writer = new StreamWriter("Players.txt", false);
                writer.WriteLine("�������;���;�������;���������;����;�����;���������;����� � ����;�������");
                foreach (Player item in ListPlayers)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Close();
                /*************************������ � Trainers.txt******************/
                writer = new StreamWriter("Trainers.txt", false);
                writer.WriteLine("�������;���;�������;����;�����");
                foreach (Trainer item in ListTrainers)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Close();
            }
            else throw new ArgumentException("���������� ������� ������ ����. ��������� ���� ������");
        }
        /*************************������ ���� ��������� ���������**********************/
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /************************������ Teams.txt************************/
            StreamReader reader = new StreamReader("Teams.txt");
            bool check = false;
            while (reader.Peek() > 1)
            {
                string[] strings = reader.ReadLine().Split(";");
                if (check)
                {
                    if (TmCheck(strings[0]) && strings.Length == 3)
                    {
                        new Team(strings[0], Int32.Parse(strings[1]), strings[2]);
                    }
                }
                check = true;
            }
            reader.Close();
            /*************************������ Players.txt*********************/
            reader = new StreamReader("Players.txt");
            dataGridView1.DataSource = null;
            check = false;
            while (reader.Peek() > 1)
            {
                string[] strings = reader.ReadLine().Split(";");
                if (check)
                {
                    if (PlCheck(strings[3]) && strings.Length == 9)
                    {
                        new Player(strings[0], strings[1], Int32.Parse(strings[2]),
                            strings[3], strings[4], Int32.Parse(strings[5]), Int32.Parse(strings[6]), Int32.Parse(strings[7]), strings[8]);
                    }
                }
                check = true;
            }
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
            DGVProperties();
            reader.Close();
            /*************************������ Trainers.txt*********************/
            reader = new StreamReader("Trainers.txt");
            check = false;
            while (reader.Peek() > 1)
            {
                string[] strings = reader.ReadLine().Split(";");
                if (check)
                {
                    if (PlCheck(strings[3]) && strings.Length == 5)
                    {
                        new Trainer(strings[0], strings[1], Int32.Parse(strings[2]),
                            Int32.Parse(strings[3]), Int32.Parse(strings[4]));
                    }
                }
                check = true;
            }
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
            reader.Close();
            reader.Close();
        }
        /***********************����� ����� ��� ���������� �������**********************/
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teamAdd.ShowDialog();
        }
        /***********************����� ����� ��� ���������� ������***********************/
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerAdd.ShowDialog();
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
        }
        /***********************����� ����� ��� ������ ������� �������******************/
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teamSearch.ShowDialog();
            foreach (Player player in ListPlayers)
            {
                if (player.Team == SerchTeam)
                    FindedPlayers.Add(player);
            }
            dataGridView1.DataSource = FindedPlayers.GetRange(0, FindedPlayers.Count);
            FindedPlayers.Clear();
        }
        /***********************����� ����� ��� ������ ������***************************/
        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerSearch.ShowDialog();
            foreach (Player player in ListPlayers)
            {
                if (player.NickName == SerchNickName)
                    FindedPlayers.Add(player);
            }
            dataGridView1.DataSource = FindedPlayers.GetRange(0, FindedPlayers.Count);
            FindedPlayers.Clear();
        }
        /***********************����� ����� ��� ���������� �� �������*******************/
        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FamilySwitcher)
            {
                ListPlayers.Sort(playerLastNameComparer);
                FamilySwitcher = true;
            }
            else
            {
                ListPlayers.Reverse();
                FamilySwitcher = false;
            }
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
        }
        /**********************����� ����� ��� ���������� �� ����������*****************/
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!NickNameSwitcher)
            {
                ListPlayers.Sort(playerNickNameComparer);
                NickNameSwitcher = true;
            }
            else
            {
                ListPlayers.Reverse();
                NickNameSwitcher = false;
            }
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
        }
        /*************����� ����� ��� ���������� ������ �������� �������� ������********/
        /***********************����� ���������� � ����������� �����********************/
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerSearch.ShowDialog();
            foreach (Player player in ListPlayers)
            {
                if (player.NickName == SerchNickName)
                {
                    MessageBox.Show($"� ������ � ����������� {player.NickName}, ������� ����������: {player.WinRate(player.WinGames, player.LoseGames)}", "���������", MessageBoxButtons.OK) ;
                    break;
                }
            }
        }
        /*************����� ����� ��� ��������  ������ �������� �������� ������*********/
        /***********************����� ���������� � ����������� �����********************/
        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerSearch.ShowDialog();
            foreach (Player player in ListPlayers)
            {
                if (player.NickName == SerchNickName)
                {
                    MessageBox.Show($"����� � ����������� {player.NickName}\n�������� �� ����: {player.DotaLife(player.HoursInDota, player.Age)} ����� ����� �����", "���������", MessageBoxButtons.OK);
                    break;
                }
            }
        }
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personStatus.ShowDialog();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trainerAdd.ShowDialog();
        }
    }
}
