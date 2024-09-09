using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRusLexicon
{
    public partial class Form_makeNew : Form
    {
        private DatabaseHelper dbHelper;
        private Form_main form_main;

        public Form_makeNew(Form_main form)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            form_main = form;

            richTextBox_word.Enter += new EventHandler(clearRichTextBox);
            richTextBox_translation.Enter += new EventHandler(clearRichTextBox);
            richTextBox_partOfSpeech.Enter += new EventHandler(clearRichTextBox);
            richTextBox_exampleSentence1.Enter += new EventHandler(clearRichTextBox);  
            richTextBox_exampleSentenceTranslation1.Enter += new EventHandler(clearRichTextBox);
            richTextBox_exampleSentence2.Enter += new EventHandler(clearRichTextBox);
            richTextBox_exampleSentenceTranslation2.Enter += new EventHandler(clearRichTextBox);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string word = richTextBox_word.Text;
            string translation = richTextBox_translation.Text;
            string partOfSpeech = richTextBox_partOfSpeech.Text;
            string exampleSentence1 = richTextBox_exampleSentence1.Text;
            string exampleSentenceTranslation1 = richTextBox_exampleSentenceTranslation1.Text;
            string exampleSentence2 = richTextBox_exampleSentence2.Text;
            string exampleSentenceTranslation2 = richTextBox_exampleSentenceTranslation2.Text;

            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(translation) || string.IsNullOrEmpty(partOfSpeech))
            {
                MessageBox.Show("単語名・訳・品詞名は必須項目です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dbHelper.addWord(word, translation, partOfSpeech, exampleSentence1, exampleSentenceTranslation1, exampleSentence2, exampleSentenceTranslation2);

            
            ListViewItem item = new ListViewItem(word);
            item.SubItems.Add(partOfSpeech);
            form_main.listView.Items.Add(item);

            richTextBox_word.Clear();
            richTextBox_translation.Clear();
            richTextBox_partOfSpeech.Clear();
            richTextBox_exampleSentence1.Clear();
            richTextBox_exampleSentenceTranslation1.Clear();
            richTextBox_exampleSentence2.Clear();
            richTextBox_exampleSentenceTranslation2.Clear();
        }

        private void clearRichTextBox(object sender, EventArgs e)
        {
            RichTextBox name = sender as RichTextBox;
            if(name.ForeColor == Color.Gray && 
              (name.Text == "Введите слово..." ||
               name.Text == "品詞名" ||
               name.Text == "訳を入力してください..." ||
               name.Text == "Введите пример предложения①" ||
               name.Text == "例文訳①を入力してください" ||
               name.Text == "Введите пример предложения②" ||
               name.Text == "例文訳②を入力してください"))
            {
                name.Clear();
                name.ForeColor = Color.Black;
            }
        }
    }
}
