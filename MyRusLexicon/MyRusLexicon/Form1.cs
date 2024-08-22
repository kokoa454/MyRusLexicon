using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

//start from coding sample data(word only) like addWord("Россия");
//if success, code additional data(translation, partofspeech and etc)

namespace MyRusLexicon
{
    public partial class Form_main : Form
    {
        private DatabaseHelper dbHelper;
        public Form_main()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            dbHelper.initializeDatabase();
            loadWords();
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            listView.GridLines = true;

            /*
            label_translation.Visible = false;
            label_partOfSpeech.Visible = false;
            label_exampleSentence.Visible = false;
            */
        }

        private void loadWords()
        {
            var wordList = dbHelper.GetWords();

            foreach (var word in wordList)
            {
                ListViewItem item = new ListViewItem(word.Word);
                listView.Items.Add(item);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var selectedWord = listView.SelectedItems[0].Text;
                var wordInfo = dbHelper.GetWords().Find(w => w.Word == selectedWord);

                if (wordInfo != null)
                {
                    label_word.Text = wordInfo.Word;
                }
            }
        }
    }

    //start DB settings
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=data.db;Version=3;"; //directry bellow of bin

        public void initializeDatabase()
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.db");

            if (!File.Exists(dbFilePath)) //make new db file and examples of words if not exists
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Words (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Word TEXT NOT NULL
            )";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void addWord(string word)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO Words (Word)
                    VALUES (@Word);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Word", word);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<WordInfo> GetWords()
        {
            var words = new List<WordInfo>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Words;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var wordInfo = new WordInfo(
                            reader["Word"].ToString()
                        );

                        words.Add(wordInfo);
                    }
                }
            }

            return words;
        }
    }

    public class WordInfo
    {
        public string Word { get; set; }

        public WordInfo(string word)
        {
            Word = word;
        }

        public override string ToString()
        {
            return Word;
        }
    }
    //end DB settings

}
