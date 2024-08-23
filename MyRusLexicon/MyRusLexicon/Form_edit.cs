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
    public partial class Form_edit : Form
    {
        private DatabaseHelper dbHelper;
        private Form_main form_main;
        private WordInfo wordInfo;

        public Form_edit(Form_main form, WordInfo word)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            form_main = form;
            wordInfo = word;

            richTextBox_word.Text = wordInfo.Word;
            richTextBox_translation.Text = wordInfo.Translation;
            richTextBox_partOfSpeech.Text = wordInfo.PartOfSpeech;
            richTextBox_exampleSentence1.Text = wordInfo.ExampleSentence1;
            richTextBox_exampleSentenceTranslation1.Text = wordInfo.ExampleSentenceTranslation1;
            richTextBox_exampleSentence2.Text = wordInfo.ExampleSentence2;
            richTextBox_exampleSentenceTranslation2.Text = wordInfo.ExampleSentenceTranslation2;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
            form_main.Show();
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

            dbHelper.updateWord(wordInfo.Word, word, translation, partOfSpeech, exampleSentence1, exampleSentenceTranslation1, exampleSentence2, exampleSentenceTranslation2);

            var selectedItem = form_main.listView.SelectedItems[0];
            selectedItem.Text = word;
            selectedItem.SubItems[1].Text = partOfSpeech;

            richTextBox_word.Clear();
            richTextBox_translation.Clear();
            richTextBox_partOfSpeech.Clear();
            richTextBox_exampleSentence1.Clear();
            richTextBox_exampleSentenceTranslation1.Clear();
            richTextBox_exampleSentence2.Clear();
            richTextBox_exampleSentenceTranslation2.Clear();

            form_main.refreshWords();

            this.Hide();
            form_main.Show();
        }
    }
}
