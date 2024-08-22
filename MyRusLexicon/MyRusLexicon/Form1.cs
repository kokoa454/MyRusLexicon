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
using System.Collections;

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
            richTextBox_exampleSentence1.Visible = false;
            richTextBox_exampleSentenceTranslation1.Visible = false;
            richTextBox_exampleSentence2.Visible = false;
            richTextBox_exampleSentenceTranslation2.Visible = false;
        }

        private void loadWords() //show list-items from DB
        {
            var wordList = dbHelper.GetWords();

            foreach (var word in wordList)
            {
                ListViewItem item = new ListViewItem(word.Word);
                item.SubItems.Add(word.PartOfSpeech);
                listView.Items.Add(item);
            }

            listView.ListViewItemSorter = new ListViewItemComparer(0);
            listView.Sort();
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
                    richTextBox_exampleSentence1.Visible = true;
                    richTextBox_exampleSentenceTranslation1.Visible = true;
                    richTextBox_exampleSentence2.Visible = true;
                    richTextBox_exampleSentenceTranslation2.Visible = true;

                    label_word.Text = wordInfo.Word;
                    label_translation.Text = wordInfo.Translation;
                    label_partOfSpeech.Text = wordInfo.PartOfSpeech;
                    richTextBox_exampleSentence1.Text = wordInfo.ExampleSentence1;
                    richTextBox_exampleSentenceTranslation1.Text = wordInfo.ExampleSentenceTranslation1;
                    richTextBox_exampleSentence2.Text = wordInfo.ExampleSentence2;
                    richTextBox_exampleSentenceTranslation2.Text = wordInfo.ExampleSentenceTranslation2;
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
                addWord("Россия", "ロシア", "名詞", "Москва, столица России, славится своими историческими памятниками, такими как Красная площадь и Кремль.", "ロシアの首都であるモスクワは、赤の広場やクレムリンに代表されるように、歴史的建造物で有名だ。", "Когда я думаю о России, мне сразу приходят на ум бескрайние просторы Сибири и величественные горы Урала.", "ロシアについて考えていると、広大なシベリアと偉大なウラル山脈が頭に浮かぶ。");
                addWord("Япония", "日本", "名詞", "В Японии находится филиал ДВФУ, и японские студенты изучают регионоведение Россиии.", "日本にはロシア極東連邦総合大学の分校があり、日本人学生達はロシア地域学を勉強している。", "Япония, страна восходящего солнца, известна своей уникальной культурой, где традиции гармонично сочетаются с передовыми технологиями и инновациями.", "日出る国、日本は伝統と先進技術が調和している独自の文化で知られている。");
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

    //start listview sort settings
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int result;

            return String.Compare(((ListViewItem)x).SubItems[col].Text,
                                  ((ListViewItem)y).SubItems[col].Text);

            if(order == SortOrder.Descending)
            {
                result *= -1;
            }

            return result;
        }
    }
    //end listview sort settings 
}
