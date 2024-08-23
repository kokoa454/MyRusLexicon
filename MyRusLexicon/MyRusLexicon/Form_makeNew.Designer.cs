namespace MyRusLexicon
{
    partial class Form_makeNew
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
            this.button_close = new System.Windows.Forms.Button();
            this.label_textWord = new System.Windows.Forms.Label();
            this.label_textTranslation = new System.Windows.Forms.Label();
            this.label_textPArtOfSpeech = new System.Windows.Forms.Label();
            this.label_textExampleSentence1 = new System.Windows.Forms.Label();
            this.label_textExampleSentenceTranslation1 = new System.Windows.Forms.Label();
            this.label_textExampleSentence2 = new System.Windows.Forms.Label();
            this.label_textExampleSentenceTranslation2 = new System.Windows.Forms.Label();
            this.richTextBox_exampleSentence1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentenceTranslation1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentence2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentenceTranslation2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_partOfSpeech = new System.Windows.Forms.RichTextBox();
            this.richTextBox_translation = new System.Windows.Forms.RichTextBox();
            this.richTextBox_word = new System.Windows.Forms.RichTextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_titleForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(605, 593);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 25);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "キャンセル";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_textWord
            // 
            this.label_textWord.AutoSize = true;
            this.label_textWord.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textWord.Location = new System.Drawing.Point(53, 122);
            this.label_textWord.Name = "label_textWord";
            this.label_textWord.Size = new System.Drawing.Size(82, 24);
            this.label_textWord.TabIndex = 1;
            this.label_textWord.Text = "単語名";
            // 
            // label_textTranslation
            // 
            this.label_textTranslation.AutoSize = true;
            this.label_textTranslation.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textTranslation.Location = new System.Drawing.Point(72, 168);
            this.label_textTranslation.Name = "label_textTranslation";
            this.label_textTranslation.Size = new System.Drawing.Size(34, 24);
            this.label_textTranslation.TabIndex = 2;
            this.label_textTranslation.Text = "訳";
            // 
            // label_textPArtOfSpeech
            // 
            this.label_textPArtOfSpeech.AutoSize = true;
            this.label_textPArtOfSpeech.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textPArtOfSpeech.Location = new System.Drawing.Point(53, 215);
            this.label_textPArtOfSpeech.Name = "label_textPArtOfSpeech";
            this.label_textPArtOfSpeech.Size = new System.Drawing.Size(82, 24);
            this.label_textPArtOfSpeech.TabIndex = 3;
            this.label_textPArtOfSpeech.Text = "品詞名";
            // 
            // label_textExampleSentence1
            // 
            this.label_textExampleSentence1.AutoSize = true;
            this.label_textExampleSentence1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textExampleSentence1.Location = new System.Drawing.Point(53, 297);
            this.label_textExampleSentence1.Name = "label_textExampleSentence1";
            this.label_textExampleSentence1.Size = new System.Drawing.Size(82, 24);
            this.label_textExampleSentence1.TabIndex = 4;
            this.label_textExampleSentence1.Text = "例文①";
            // 
            // label_textExampleSentenceTranslation1
            // 
            this.label_textExampleSentenceTranslation1.AutoSize = true;
            this.label_textExampleSentenceTranslation1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textExampleSentenceTranslation1.Location = new System.Drawing.Point(43, 370);
            this.label_textExampleSentenceTranslation1.Name = "label_textExampleSentenceTranslation1";
            this.label_textExampleSentenceTranslation1.Size = new System.Drawing.Size(106, 24);
            this.label_textExampleSentenceTranslation1.TabIndex = 5;
            this.label_textExampleSentenceTranslation1.Text = "例文訳①";
            // 
            // label_textExampleSentence2
            // 
            this.label_textExampleSentence2.AutoSize = true;
            this.label_textExampleSentence2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textExampleSentence2.Location = new System.Drawing.Point(53, 453);
            this.label_textExampleSentence2.Name = "label_textExampleSentence2";
            this.label_textExampleSentence2.Size = new System.Drawing.Size(82, 24);
            this.label_textExampleSentence2.TabIndex = 6;
            this.label_textExampleSentence2.Text = "例文②";
            // 
            // label_textExampleSentenceTranslation2
            // 
            this.label_textExampleSentenceTranslation2.AutoSize = true;
            this.label_textExampleSentenceTranslation2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textExampleSentenceTranslation2.Location = new System.Drawing.Point(43, 522);
            this.label_textExampleSentenceTranslation2.Name = "label_textExampleSentenceTranslation2";
            this.label_textExampleSentenceTranslation2.Size = new System.Drawing.Size(106, 24);
            this.label_textExampleSentenceTranslation2.TabIndex = 7;
            this.label_textExampleSentenceTranslation2.Text = "例文訳②";
            // 
            // richTextBox_exampleSentence1
            // 
            this.richTextBox_exampleSentence1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentence1.Location = new System.Drawing.Point(165, 279);
            this.richTextBox_exampleSentence1.Name = "richTextBox_exampleSentence1";
            this.richTextBox_exampleSentence1.Size = new System.Drawing.Size(575, 70);
            this.richTextBox_exampleSentence1.TabIndex = 4;
            this.richTextBox_exampleSentence1.Text = "";
            // 
            // richTextBox_exampleSentenceTranslation1
            // 
            this.richTextBox_exampleSentenceTranslation1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentenceTranslation1.Location = new System.Drawing.Point(165, 370);
            this.richTextBox_exampleSentenceTranslation1.Name = "richTextBox_exampleSentenceTranslation1";
            this.richTextBox_exampleSentenceTranslation1.Size = new System.Drawing.Size(575, 37);
            this.richTextBox_exampleSentenceTranslation1.TabIndex = 5;
            this.richTextBox_exampleSentenceTranslation1.Text = "";
            // 
            // richTextBox_exampleSentence2
            // 
            this.richTextBox_exampleSentence2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentence2.Location = new System.Drawing.Point(165, 434);
            this.richTextBox_exampleSentence2.Name = "richTextBox_exampleSentence2";
            this.richTextBox_exampleSentence2.Size = new System.Drawing.Size(575, 70);
            this.richTextBox_exampleSentence2.TabIndex = 6;
            this.richTextBox_exampleSentence2.Text = "";
            // 
            // richTextBox_exampleSentenceTranslation2
            // 
            this.richTextBox_exampleSentenceTranslation2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentenceTranslation2.Location = new System.Drawing.Point(165, 522);
            this.richTextBox_exampleSentenceTranslation2.Name = "richTextBox_exampleSentenceTranslation2";
            this.richTextBox_exampleSentenceTranslation2.Size = new System.Drawing.Size(575, 36);
            this.richTextBox_exampleSentenceTranslation2.TabIndex = 7;
            this.richTextBox_exampleSentenceTranslation2.Text = "";
            // 
            // richTextBox_partOfSpeech
            // 
            this.richTextBox_partOfSpeech.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_partOfSpeech.Location = new System.Drawing.Point(165, 215);
            this.richTextBox_partOfSpeech.Name = "richTextBox_partOfSpeech";
            this.richTextBox_partOfSpeech.Size = new System.Drawing.Size(575, 36);
            this.richTextBox_partOfSpeech.TabIndex = 3;
            this.richTextBox_partOfSpeech.Text = "";
            // 
            // richTextBox_translation
            // 
            this.richTextBox_translation.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_translation.Location = new System.Drawing.Point(165, 164);
            this.richTextBox_translation.Name = "richTextBox_translation";
            this.richTextBox_translation.Size = new System.Drawing.Size(575, 36);
            this.richTextBox_translation.TabIndex = 1;
            this.richTextBox_translation.Text = "";
            // 
            // richTextBox_word
            // 
            this.richTextBox_word.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_word.Location = new System.Drawing.Point(165, 122);
            this.richTextBox_word.Name = "richTextBox_word";
            this.richTextBox_word.Size = new System.Drawing.Size(575, 36);
            this.richTextBox_word.TabIndex = 0;
            this.richTextBox_word.Text = "";
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(110, 593);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 25);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "確定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_titleForm
            // 
            this.label_titleForm.AutoSize = true;
            this.label_titleForm.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_titleForm.Location = new System.Drawing.Point(279, 42);
            this.label_titleForm.Name = "label_titleForm";
            this.label_titleForm.Size = new System.Drawing.Size(239, 37);
            this.label_titleForm.TabIndex = 10;
            this.label_titleForm.Text = "新規登録画面";
            // 
            // Form_makeNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.label_titleForm);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.richTextBox_word);
            this.Controls.Add(this.richTextBox_translation);
            this.Controls.Add(this.richTextBox_partOfSpeech);
            this.Controls.Add(this.richTextBox_exampleSentenceTranslation2);
            this.Controls.Add(this.richTextBox_exampleSentence2);
            this.Controls.Add(this.richTextBox_exampleSentenceTranslation1);
            this.Controls.Add(this.richTextBox_exampleSentence1);
            this.Controls.Add(this.label_textExampleSentenceTranslation2);
            this.Controls.Add(this.label_textExampleSentence2);
            this.Controls.Add(this.label_textExampleSentenceTranslation1);
            this.Controls.Add(this.label_textExampleSentence1);
            this.Controls.Add(this.label_textPArtOfSpeech);
            this.Controls.Add(this.label_textTranslation);
            this.Controls.Add(this.label_textWord);
            this.Controls.Add(this.button_close);
            this.Name = "Form_makeNew";
            this.Text = "新規登録 - MyRusLexicon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_textWord;
        private System.Windows.Forms.Label label_textTranslation;
        private System.Windows.Forms.Label label_textPArtOfSpeech;
        private System.Windows.Forms.Label label_textExampleSentence1;
        private System.Windows.Forms.Label label_textExampleSentenceTranslation1;
        private System.Windows.Forms.Label label_textExampleSentence2;
        private System.Windows.Forms.Label label_textExampleSentenceTranslation2;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentence1;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentenceTranslation1;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentence2;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentenceTranslation2;
        private System.Windows.Forms.RichTextBox richTextBox_partOfSpeech;
        private System.Windows.Forms.RichTextBox richTextBox_translation;
        private System.Windows.Forms.RichTextBox richTextBox_word;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_titleForm;
    }
}