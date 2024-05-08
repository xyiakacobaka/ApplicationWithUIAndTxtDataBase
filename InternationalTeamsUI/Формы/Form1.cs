using InternationalTeamsUI.Иерархия;
using InternationalTeamsUI.Сортировка;
using InternationalTeamsUI.Формы;
using System;
using System.Numerics;

namespace InternationalTeamsUI
{
    public partial class Form1 : Form
    {
        /****************************************************************************/
        /*********************************Коллекции**********************************/
        /****************************************************************************/
        static public List<Team> ListTeams = new List<Team>();
        static public List<string> ListNameTeams = new List<string>();
        static public List<Player> ListPlayers = new List<Player>();
        static public List<string> ListPlayersLastName = new List<string>();
        private List<Player> FindedPlayers = new List<Player>();
        static public List<string> ListNickNames = new List<string>();
        static public List<Trainer> ListTrainers = new List<Trainer>();
        static public List<string> ListTrainersName = new List<string>();
        static public List<string> Ranks = ["Рекрут", "Страж", "Рыцарь", "Герой", "Легенда", "Властелин", "Божество"];
        /****************************************************************************/
        /******************************Статические поля******************************/
        /****************************************************************************/
        static public string SerchNickName;
        static public string SerchTeam;
        /****************************************************************************/
        /************************************Формы***********************************/
        /****************************************************************************/
        TeamAdd teamAdd = new TeamAdd();
        PlayerAdd playerAdd = new PlayerAdd();
        PlayerSearch playerSearch = new PlayerSearch();
        TeamSearch teamSearch = new TeamSearch();
        /****************************************************************************/
        /*********************************Сортировки*********************************/
        /****************************************************************************/
        PlayerLastNameComparer playerLastNameComparer = new PlayerLastNameComparer();
        PlayerNickNameComparer playerNickNameComparer = new PlayerNickNameComparer();
        private bool FamilySwitcher = false;
        private bool NickNameSwitcher = false;
        public Form1()
        {
            InitializeComponent();
        }
        /****************************************************************************/
        /***********************Настройка DataGridView*******************************/
        /****************************************************************************/
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
            /****************************************************************/
            /*********************Изменение имени столбца********************/
            /****************************************************************/
            dataGridView1.Columns["LastName"].HeaderText = "Фамилия";
            dataGridView1.Columns["Name"].HeaderText = "Имя";
            dataGridView1.Columns["Age"].HeaderText = "Возраст";
            dataGridView1.Columns["NickName"].HeaderText = "Псевдоним";
            dataGridView1.Columns["Rank"].HeaderText = "Ранг";
            dataGridView1.Columns["WinGames"].HeaderText = "Побед";
            dataGridView1.Columns["LoseGames"].HeaderText = "Поражений";
            dataGridView1.Columns["HoursInDota"].HeaderText = "Часов в доте";
            dataGridView1.Columns["Team"].HeaderText = "Команда";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProperties();

        }
        /****************************************************************************/
        /*****************************Проверки базы данных***************************/
        /****************************************************************************/
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
        /******************************************************************************/
        /***********************Создание двух текстовых документа**********************/
        /******************************************************************************/
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListPlayers.Count != 0)
            {
                /****************************************************************/
                /*************************Запись в Teams.txt*********************/
                /****************************************************************/
                StreamWriter writer = new StreamWriter("Teams.txt", false);
                writer.WriteLine("Название;Имя;Доход;Тренер");
                foreach (Team item in ListTeams)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Close();
                /****************************************************************/
                /*************************Запись в Players.txt*******************/
                /****************************************************************/
                writer = new StreamWriter("Players.txt", false);
                writer.WriteLine("Фамилия;Имя;Возраст;Псевдоним;Ранг;Побед;Поражений;Часов в доте;Команда");
                foreach (Player item in ListPlayers)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Close();
            }
            else throw new ArgumentException("Невозможно создать пустой файл. Проверьте базу данных");
        }
        /******************************************************************************/
        /*************************Чтение двух текстовых документа**********************/
        /******************************************************************************/
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /****************************************************************/
            /************************Чтение Teams.txt************************/
            /****************************************************************/
            StreamReader reader = new StreamReader("Teams.txt");
            bool check = false;
            while (reader.Peek() > 1)
            {
                string[] strings = reader.ReadLine().Split(";");
                if (check)
                {
                    if (TmCheck(strings[0]) && strings.Length == 3)
                    {
                        Team team = new Team(strings[0], Int32.Parse(strings[1]), strings[2]);
                    }
                }
                check = true;
            }
            reader.Close();
            /****************************************************************/
            /*************************Чтение Players.txt*********************/
            /****************************************************************/
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
                        Player player = new Player(strings[0], strings[1], Int32.Parse(strings[2]),
                            strings[3], strings[4], Int32.Parse(strings[5]), Int32.Parse(strings[6]), Int32.Parse(strings[7]), strings[8]);
                    }
                }
                check = true;
            }
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
            DGVProperties();
            reader.Close();
        }
        /****************************************************************-**************/
        /***********************Вызов формы для добавления команды**********************/
        /*******************************************************************************/
        private void командаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teamAdd.ShowDialog();
        }
        /****************************************************************-**************/
        /***********************Вызов формы для добавления игрока***********************/
        /*******************************************************************************/
        private void игрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerAdd.ShowDialog();
            dataGridView1.DataSource = ListPlayers.GetRange(0, ListPlayers.Count);
        }
        /****************************************************************-**************/
        /***********************Вызов формы для поиска игроков команды******************/
        /*******************************************************************************/
        private void командыToolStripMenuItem_Click(object sender, EventArgs e)
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
        /****************************************************************-**************/
        /***********************Вызов формы для поиска игрока***************************/
        /*******************************************************************************/
        private void игрокаToolStripMenuItem_Click(object sender, EventArgs e)
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
        /****************************************************************-**************/
        /***********************Вызов формы для сортировки по фамилии*******************/
        /*******************************************************************************/
        private void поФамильныйToolStripMenuItem_Click(object sender, EventArgs e)
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
        /****************************************************************-**************/
        /**********************Вызов формы для сортировки по псевдониму*****************/
        /*******************************************************************************/
        private void поПсевдонимуToolStripMenuItem_Click(object sender, EventArgs e)
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
        /*******************************************************************************/
        /*************Вызов формы для выполнения метода подсчета винрейта игрока********/
        /***********************игрок выбирается в открывшейся форме********************/
        private void винрейтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerSearch.ShowDialog();
            foreach (Player player in ListPlayers)
            {
                if (player.NickName == SerchNickName)
                {
                    string[] WinRates = new string[2] { player.NickName, player.WinRate(player.WinGames, player.LoseGames).ToString() };
                    string Result = string.Format("У игрока с псевдонимом {0}, винрейт составляет: {1}", WinRates[0], WinRates[1]);
                    MessageBox.Show(Result, "Результат", MessageBoxButtons.OK);
                    break;
                }
            }
        }
        /*******************************************************************************/
        /*************Вызов формы для подсчета  метода подсчета винрейта игрока*********/
        /***********************игрок выбирается в открывшейся форме********************/
        private void потерянноеВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerSearch.ShowDialog();
            foreach (Player player in ListPlayers)
            {
                if (player.NickName == SerchNickName)
                {
                    string[] Hours = new string[2] { player.NickName, player.DotaLife(player.HoursInDota,player.Age).ToString() };
                    string Result = string.Format("Игрок с псевдонимом {0}\nпотратил на игру: {1} часов своей жизни", Hours[0], Hours[1]);
                    MessageBox.Show(Result, "Результат", MessageBoxButtons.OK);
                    break;
                }
            }
        }
    }
}
