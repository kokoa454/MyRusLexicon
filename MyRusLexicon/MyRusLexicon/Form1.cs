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
using System.Runtime.InteropServices;

//consider a way to search for words without case sensitivity(if eng, it works, but no russian)

//i wanna add func with chatgpt api to suggest example sentences for users in future

namespace MyRusLexicon
{
    public partial class Form_main : Form
    {
        private DatabaseHelper dbHelper;

        [DllImport("User32.dll")]
        static extern int HideCaret(IntPtr hWnd); //use to hide carot
        public Form_main()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            dbHelper.initializeDatabase();
            dbHelper.makeExample();
            loadWords();
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            listView.GridLines = true;
            
            richTextBox_word.Visible = false;
            label_textTranslation.Visible = false;
            richTextBox_translation.Visible = false;
            richTextBox_partOfSpeech.Visible = false;
            label_textExampleSentence.Visible = false;
            richTextBox_exampleSentence1.Visible = false;
            richTextBox_exampleSentenceTranslation1.Visible = false;
            richTextBox_exampleSentence2.Visible = false;
            richTextBox_exampleSentenceTranslation2.Visible = false;

            richTextBox_word.Click += new EventHandler(hideCaret);
            richTextBox_translation.Click += new EventHandler(hideCaret);
            richTextBox_partOfSpeech.Click += new EventHandler(hideCaret);
            richTextBox_exampleSentence1.Click += new EventHandler(hideCaret);
            richTextBox_exampleSentenceTranslation1.Click += new EventHandler(hideCaret);
            richTextBox_exampleSentence2.Click += new EventHandler(hideCaret);
            richTextBox_exampleSentenceTranslation2.Click += new EventHandler(hideCaret);
        }

        private void hideCaret(object sender, EventArgs e)
        {
            RichTextBox name = sender as RichTextBox;
            HideCaret(name.Handle);
        }

        private void loadWords() //show list-items from DB
        {
            var wordList = dbHelper.getWords();

            foreach (var word in wordList)
            {
                ListViewItem item = new ListViewItem(word.Word);
                item.SubItems.Add(word.PartOfSpeech);
                listView.Items.Add(item);
            }

            listView.ListViewItemSorter = new ListViewItemComparer(0);
            listView.Sort();
        }

        public void refreshWords() //use for Form_edit to reflect changes to listView
        {
            int selectedIndex = listView.SelectedIndices.Count > 0 ? listView.SelectedIndices[0] : -1;

            listView.Items.Clear();
            loadWords();

            if(selectedIndex >= 0 && selectedIndex < listView.Items.Count)
            {
                listView.Items[selectedIndex].Selected = true;
                listView.Items[selectedIndex].Focused = true;
                updateRichTextBox(listView.Items[selectedIndex]);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var selectedWord = listView.SelectedItems[0].Text;
                var wordInfo = dbHelper.getWords().Find(w => w.Word == selectedWord);

                if (wordInfo != null)
                {
                    richTextBox_word.Visible = true;
                    label_textTranslation.Visible = true;
                    richTextBox_translation.Visible = true;
                    richTextBox_partOfSpeech.Visible = true;
                    label_textExampleSentence.Visible = true;
                    richTextBox_exampleSentence1.Visible = true;
                    richTextBox_exampleSentenceTranslation1.Visible = true;
                    richTextBox_exampleSentence2.Visible = true;
                    richTextBox_exampleSentenceTranslation2.Visible = true;

                    richTextBox_word.Text = wordInfo.Word;
                    richTextBox_translation.Text = wordInfo.Translation;
                    richTextBox_partOfSpeech.Text = wordInfo.PartOfSpeech;
                    richTextBox_exampleSentence1.Text = wordInfo.ExampleSentence1;
                    richTextBox_exampleSentenceTranslation1.Text = wordInfo.ExampleSentenceTranslation1;
                    richTextBox_exampleSentence2.Text = wordInfo.ExampleSentence2;
                    richTextBox_exampleSentenceTranslation2.Text = wordInfo.ExampleSentenceTranslation2;
                }
            }
        }

        private void updateRichTextBox(ListViewItem item)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var selectedWord = item.Text;
                var wordInfo = dbHelper.getWords().Find(w => w.Word == selectedWord);

                if (wordInfo != null)
                {
                    richTextBox_word.Visible = true;
                    label_textTranslation.Visible = true;
                    richTextBox_translation.Visible = true;
                    richTextBox_partOfSpeech.Visible = true;
                    label_textExampleSentence.Visible = true;
                    richTextBox_exampleSentence1.Visible = true;
                    richTextBox_exampleSentenceTranslation1.Visible = true;
                    richTextBox_exampleSentence2.Visible = true;
                    richTextBox_exampleSentenceTranslation2.Visible = true;

                    richTextBox_word.Text = wordInfo.Word;
                    richTextBox_translation.Text = wordInfo.Translation;
                    richTextBox_partOfSpeech.Text = wordInfo.PartOfSpeech;
                    richTextBox_exampleSentence1.Text = wordInfo.ExampleSentence1;
                    richTextBox_exampleSentenceTranslation1.Text = wordInfo.ExampleSentenceTranslation1;
                    richTextBox_exampleSentence2.Text = wordInfo.ExampleSentence2;
                    richTextBox_exampleSentenceTranslation2.Text = wordInfo.ExampleSentenceTranslation2;
                }
            }
        }

        private void toolStripMenuItem_makeNew_Click(object sender, EventArgs e)
        {
            Form_makeNew form_makeNew = new Form_makeNew(this);
            form_makeNew.Show();
        }

        private void toolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("削除する単語を選んでください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("本当にこの単語を削除しますか？", "削除 - MyRusLexicon", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        dbHelper.deleteWord(item.Text);
                        listView.Items.Remove(item);

                        richTextBox_word.Text = "";
                        richTextBox_translation.Text = "";
                        richTextBox_partOfSpeech.Text = "";
                        richTextBox_exampleSentence1.Text = "";
                        richTextBox_exampleSentenceTranslation1.Text = "";
                        richTextBox_exampleSentence2.Text = "";
                        richTextBox_exampleSentenceTranslation2.Text = "";

                        richTextBox_word.Visible = false;
                        label_textTranslation.Visible = false;
                        richTextBox_translation.Visible = false;
                        richTextBox_partOfSpeech.Visible = false;
                        label_textExampleSentence.Visible = false;
                        richTextBox_exampleSentence1.Visible = false;
                        richTextBox_exampleSentenceTranslation1.Visible = false;
                        richTextBox_exampleSentence2.Visible = false;
                        richTextBox_exampleSentenceTranslation2.Visible = false;
                    }
                }
            }

            return;
        }

        private void toolStripMenuItem_edit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("編集する単語を選んでください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var selectedWord =listView.SelectedItems[0].Text;
                var  wordInfo = dbHelper.getWords().Find(w => w.Word == selectedWord);

                Form_edit form_edit = new Form_edit(this, wordInfo);
                form_edit.ShowDialog();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var word = textBox_search.Text;
            var searchResults = dbHelper.searchWord(word);

            listView.Items.Clear();

            foreach (var wordInfo in searchResults)
            {
                ListViewItem item = new ListViewItem(wordInfo.Word);
                item.SubItems.Add(wordInfo.PartOfSpeech);
                listView.Items.Add(item);
            }

            listView.ListViewItemSorter = new ListViewItemComparer(0);
            listView.Sort();
        }

        private void toolStripMenuItem_about_Click(object sender, EventArgs e)
        {
            Form_about form_about = new Form_about();
            form_about.Show();
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
                addWord(
                    "Россия", 
                    "ロシア", 
                    "名詞", 
                    "Москва, столица России, славится своими историческими памятниками, такими как Красная площадь и Кремль.", 
                    "ロシアの首都であるモスクワは、赤の広場やクレムリンに代表されるように、歴史的建造物で有名だ。", 
                    "Когда я думаю о России, мне сразу приходят на ум бескрайние просторы Сибири и величественные горы Урала.", 
                    "ロシアについて考えていると、広大なシベリアと偉大なウラル山脈が頭に浮かぶ。"
                    );

                addWord(
                    "Япония", 
                    "日本", 
                    "名詞", 
                    "В Японии находится филиал ДВФУ, и японские студенты изучают регионоведение Россиии.",
                    "日本にはロシア極東連邦総合大学の分校があり、日本人学生達はロシア地域学を勉強している。",
                    "Япония, страна восходящего солнца, известна своей уникальной культурой, где традиции гармонично сочетаются с передовыми технологиями и инновациями.", 
                    "日出る国、日本は伝統と先進技術が調和している独自の文化で知られている。"
                    );

                addWord(
                    "программировать\nзапрограммировать",
                    "プログラミングする",
                    "動詞",
                    "Нельзя мешать мне, когда я программирую.",
                    "プログラミングしているときは邪魔をしないでくれ。",
                    "Программировать - одна из работ программистов.",
                    "プログラミングはプログラマーの仕事の一つである。"
                    );

                addWord(
                    "рентгеноэлектрокардиографический",
                    "心電図X線の",
                    "形容詞",
                    "В нашей клинике внедрен новый рентгеноэлектрокардиографический метод диагностики.",
                    "私達のクリニックでは、新しい心電図X線診断法が導入された。",
                    "Рентгеноэлектрокардиографический аппарат, который мы недавно приобрели, значительно улучшил точность диагностики сердечно-сосудистых заболеваний.",
                    "最近購入した心電図X線装置は、心血管疾患の診断精度を大幅に向上させた。"
                    );

                addWord(
                   "соответственно + чему",
                   "に従って\nに応じて",
                   "副詞",
                   "Я всегда стараюсь поступать соответственно своим убеждениям.",
                   "私はいつも自身の信念に従って行動するようにしている。",
                   "Сотрудники должны пройти дополнительное обучение соответственно новым правилам.",
                   "新規則に則り、職員は追加教育を受けなければならない。"
                   );
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

        public List<WordInfo> getWords()
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

        public void deleteWord(string word)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Words WHERE Word = @Word";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Word", word);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void updateWord(string originalWord, string newWord, string translation, string partOfSpeech, string exampleSentence1, string exampleSentenceTranslation1, string exampleSentence2, string exampleSentenceTranslation2)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    UPDATE Words 
                    SET Word = @newWord, 
                        Translation =  @translation, 
                        PartOfSpeech = @partOfSpeech, 
                        ExampleSentence1 = @exampleSentence1, 
                        ExampleSentenceTranslation1 = @exampleSentenceTranslation1,
                        ExampleSentence2 = @exampleSentence2,
                        ExampleSentenceTranslation2 = @exampleSentenceTranslation2 
                WHERE Word = @originalWord";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newWord", newWord);
                    command.Parameters.AddWithValue("@translation", translation);
                    command.Parameters.AddWithValue("@partOfSpeech", partOfSpeech);
                    command.Parameters.AddWithValue("@exampleSentence1", exampleSentence1);
                    command.Parameters.AddWithValue("@exampleSentenceTranslation1", exampleSentenceTranslation1);
                    command.Parameters.AddWithValue("@exampleSentence2", exampleSentence2);
                    command.Parameters.AddWithValue("@exampleSentenceTranslation2", exampleSentenceTranslation2);
                    command.Parameters.AddWithValue("@originalWord", originalWord);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<WordInfo> searchWord(string word)
        {
            var words = new List<WordInfo>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Words WHERE Word LIKE @Word || '%' COLLATE NOCASE";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Word", word);

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
            return $"{Word} - {ExampleSentenceTranslation2}";
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
