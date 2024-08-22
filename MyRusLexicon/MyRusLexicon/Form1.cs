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
            dbHelper.makeExample();
            loadWords();
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            listView.GridLines = true;
            
            label_word.Visible = false;
            label_textTranslation.Visible = false;
            label_translation.Visible = false;
            label_partOfSpeech.Visible = false;
            label_textExampleSentence.Visible = false;
            label_exampleSentence1.Visible = false;
            label_exampleSentenceTranslation1.Visible = false;
            label_exampleSentence2.Visible = false;
            label_exampleSentenceTranslation2.Visible = false;
        }

        private void loadWords() //show listitems from DB
        {
            var wordList = dbHelper.GetWords();

            foreach (var word in wordList)
            {
                ListViewItem item = new ListViewItem(word.Word);
                item.SubItems.Add(word.PartOfSpeech);
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
                    label_word.Visible = true;
                    label_textTranslation.Visible = true;
                    label_translation.Visible = true;
                    label_partOfSpeech.Visible = true;
                    label_textExampleSentence.Visible = true;
                    label_exampleSentence1.Visible = true;
                    label_exampleSentenceTranslation1.Visible = true;
                    label_exampleSentence2.Visible = true;
                    label_exampleSentenceTranslation2.Visible = true;

                    label_word.Text = wordInfo.Word;
                    label_translation.Text = wordInfo.Translation;
                    label_partOfSpeech.Text = wordInfo.PartOfSpeech;
                    label_exampleSentence1.Text = wordInfo.ExampleSentence1;
                    label_exampleSentenceTranslation1.Text = wordInfo.ExampleSentenceTranslation1;
                    label_exampleSentence2.Text = wordInfo.ExampleSentence2;
                    label_exampleSentenceTranslation2.Text = wordInfo.ExampleSentenceTranslation2;
                }
            }
        }
    }

    //start DB settings
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=data.db;Version=3;";
        private int flg = 0;

        public void initializeDatabase()
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.db"); //directry bellow of bin

            if (!File.Exists(dbFilePath)) //make new db file if not exists
            {
                SQLiteConnection.CreateFile(dbFilePath);
                flg = 1;
            }

            using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Words (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Word TEXT NOT NULL,
                Translation TEXT,
                PartOfSpeech TEXT,
                ExampleSentence1 TEXT,
                ExampleSentenceTranslation1 TEXT,
                ExampleSentence2 TEXT,
                ExampleSentenceTranslation2 TEXT
            )";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void makeExample()
        {
            if (flg == 1)
            {
                addWord("Россия", "ロシア", "名詞", "Я хочу побывать в России.", "私はロシアへ行きたい。", "Он уже уехал в Россию.", "彼はすでにロシアへ去ってしまったよ。");
                addWord("Япония", "日本", "名詞", "В Японии находится филиал ДВФУ.", "日本にはロシア極東連邦総合大学の分校がある。", "", "");
            }
        }

        public void addWord(string word, string translation, string partOfSpeech, string exampleSentence1, string exampleSentenceTranslation1, string exampleSentence2, string exampleSentenceTranslation2)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO Words (Word, Translation, PartOfSpeech, ExampleSentence1, ExampleSentenceTranslation1, ExampleSentence2, ExampleSentenceTranslation2)
                    VALUES (@Word, @Translation, @PartOfSpeech, @ExampleSentence1, @ExampleSentenceTranslation1, @ExampleSentence2, @ExampleSentenceTranslation2);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Word", word);
                    command.Parameters.AddWithValue("@Translation", translation);
                    command.Parameters.AddWithValue("@PartOfSpeech", partOfSpeech);
                    command.Parameters.AddWithValue("@ExampleSentence1", exampleSentence1);
                    command.Parameters.AddWithValue("@ExampleSentenceTranslation1", exampleSentenceTranslation1);
                    command.Parameters.AddWithValue("@ExampleSentence2", exampleSentence2);
                    command.Parameters.AddWithValue("@ExampleSentenceTranslation2", exampleSentenceTranslation2);
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
                            reader["Word"].ToString(),
                            reader["Translation"].ToString(),
                            reader["PartOfSpeech"].ToString(),
                            reader["ExampleSentence1"].ToString(),
                            reader["ExampleSentenceTranslation1"].ToString(),
                            reader["ExampleSentence2"].ToString(),
                            reader["ExampleSentenceTranslation2"].ToString()
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
        public string Translation { get; set; }
        public string PartOfSpeech { get; set; }
        public string ExampleSentence1 { get; set; }
        public string ExampleSentenceTranslation1 { get; set; }
        public string ExampleSentence2 { get; set; }
        public string ExampleSentenceTranslation2 { get; set; }

        public WordInfo(string word, string translation, string partOfSpeech, string exampleSentence1, string exampleSentenceTranslation1, string exampleSentence2, string exampleSentenceTranslation2)
        {
            Word = word;
            Translation = translation;
            PartOfSpeech = partOfSpeech;
            ExampleSentence1 = exampleSentence1;
            ExampleSentenceTranslation1 = exampleSentenceTranslation1;
            ExampleSentence2 = exampleSentence2;
            ExampleSentenceTranslation2 = exampleSentenceTranslation2;
        }

        public override string ToString()
        {
            return Word;
        }
    }
    //end DB settings

}
