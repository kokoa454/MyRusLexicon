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
            this.button_OK = new System.Windows.Forms.Button();
            this.label_titleForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_textExampleSentence = new System.Windows.Forms.Label();
            this.richTextBox_exampleSentence1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentence2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentenceTranslation1 = new System.Windows.Forms.RichTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.richTextBox_exampleSentenceTranslation2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_word = new System.Windows.Forms.RichTextBox();
            this.richTextBox_translation = new System.Windows.Forms.RichTextBox();
            this.richTextBox_partOfSpeech = new System.Windows.Forms.RichTextBox();
            this.label_asterisk1 = new System.Windows.Forms.Label();
            this.label_asterisk2 = new System.Windows.Forms.Label();
            this.label_asterisk3 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Yu Mincho Demibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(605, 856);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(95, 25);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "キャンセル";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Yu Mincho Demibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(130, 856);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(95, 25);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "確定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_titleForm
            // 
            this.label_titleForm.AutoSize = true;
            this.label_titleForm.Font = new System.Drawing.Font("Yu Mincho Demibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_titleForm.Location = new System.Drawing.Point(262, 9);
            this.label_titleForm.Name = "label_titleForm";
            this.label_titleForm.Size = new System.Drawing.Size(315, 62);
            this.label_titleForm.TabIndex = 10;
            this.label_titleForm.Text = "新規登録画面";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Mincho Demibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(24, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "訳：";
            // 
            // label_textExampleSentence
            // 
            this.label_textExampleSentence.AutoSize = true;
            this.label_textExampleSentence.Font = new System.Drawing.Font("Yu Mincho Demibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textExampleSentence.Location = new System.Drawing.Point(24, 276);
            this.label_textExampleSentence.Name = "label_textExampleSentence";
            this.label_textExampleSentence.Size = new System.Drawing.Size(69, 34);
            this.label_textExampleSentence.TabIndex = 6;
            this.label_textExampleSentence.Text = "例文";
            // 
            // richTextBox_exampleSentence1
            // 
            this.richTextBox_exampleSentence1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_exampleSentence1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_exampleSentence1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentence1.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_exampleSentence1.Location = new System.Drawing.Point(30, 327);
            this.richTextBox_exampleSentence1.Name = "richTextBox_exampleSentence1";
            this.richTextBox_exampleSentence1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentence1.Size = new System.Drawing.Size(782, 78);
            this.richTextBox_exampleSentence1.TabIndex = 4;
            this.richTextBox_exampleSentence1.Text = "Введите пример предложения①";
            // 
            // richTextBox_exampleSentence2
            // 
            this.richTextBox_exampleSentence2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_exampleSentence2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_exampleSentence2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentence2.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_exampleSentence2.Location = new System.Drawing.Point(30, 515);
            this.richTextBox_exampleSentence2.Name = "richTextBox_exampleSentence2";
            this.richTextBox_exampleSentence2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentence2.Size = new System.Drawing.Size(782, 78);
            this.richTextBox_exampleSentence2.TabIndex = 6;
            this.richTextBox_exampleSentence2.Text = "Введите пример предложения②";
            // 
            // richTextBox_exampleSentenceTranslation1
            // 
            this.richTextBox_exampleSentenceTranslation1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_exampleSentenceTranslation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_exampleSentenceTranslation1.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_exampleSentenceTranslation1.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_exampleSentenceTranslation1.Location = new System.Drawing.Point(30, 411);
            this.richTextBox_exampleSentenceTranslation1.Name = "richTextBox_exampleSentenceTranslation1";
            this.richTextBox_exampleSentenceTranslation1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentenceTranslation1.Size = new System.Drawing.Size(780, 48);
            this.richTextBox_exampleSentenceTranslation1.TabIndex = 5;
            this.richTextBox_exampleSentenceTranslation1.Text = "例文訳①を入力してください";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.label_asterisk3);
            this.panel.Controls.Add(this.label_asterisk2);
            this.panel.Controls.Add(this.label_asterisk1);
            this.panel.Controls.Add(this.richTextBox_exampleSentenceTranslation2);
            this.panel.Controls.Add(this.richTextBox_exampleSentenceTranslation1);
            this.panel.Controls.Add(this.richTextBox_exampleSentence2);
            this.panel.Controls.Add(this.richTextBox_exampleSentence1);
            this.panel.Controls.Add(this.label_textExampleSentence);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.richTextBox_word);
            this.panel.Controls.Add(this.richTextBox_translation);
            this.panel.Controls.Add(this.richTextBox_partOfSpeech);
            this.panel.Location = new System.Drawing.Point(1, 88);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(832, 737);
            this.panel.TabIndex = 17;
            // 
            // richTextBox_exampleSentenceTranslation2
            // 
            this.richTextBox_exampleSentenceTranslation2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_exampleSentenceTranslation2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_exampleSentenceTranslation2.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_exampleSentenceTranslation2.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_exampleSentenceTranslation2.Location = new System.Drawing.Point(30, 599);
            this.richTextBox_exampleSentenceTranslation2.Name = "richTextBox_exampleSentenceTranslation2";
            this.richTextBox_exampleSentenceTranslation2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentenceTranslation2.Size = new System.Drawing.Size(782, 45);
            this.richTextBox_exampleSentenceTranslation2.TabIndex = 7;
            this.richTextBox_exampleSentenceTranslation2.Text = "例文訳②を入力してください";
            // 
            // richTextBox_word
            // 
            this.richTextBox_word.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_word.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_word.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_word.Location = new System.Drawing.Point(20, 17);
            this.richTextBox_word.Name = "richTextBox_word";
            this.richTextBox_word.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_word.Size = new System.Drawing.Size(655, 112);
            this.richTextBox_word.TabIndex = 0;
            this.richTextBox_word.Text = "Введите слова...";
            // 
            // richTextBox_translation
            // 
            this.richTextBox_translation.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_translation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_translation.Font = new System.Drawing.Font("Yu Mincho", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_translation.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_translation.Location = new System.Drawing.Point(101, 147);
            this.richTextBox_translation.Name = "richTextBox_translation";
            this.richTextBox_translation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_translation.Size = new System.Drawing.Size(709, 102);
            this.richTextBox_translation.TabIndex = 3;
            this.richTextBox_translation.Text = "訳を入力してください...";
            // 
            // richTextBox_partOfSpeech
            // 
            this.richTextBox_partOfSpeech.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_partOfSpeech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_partOfSpeech.Font = new System.Drawing.Font("Yu Mincho Demibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox_partOfSpeech.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_partOfSpeech.Location = new System.Drawing.Point(681, 45);
            this.richTextBox_partOfSpeech.Name = "richTextBox_partOfSpeech";
            this.richTextBox_partOfSpeech.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox_partOfSpeech.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_partOfSpeech.Size = new System.Drawing.Size(131, 44);
            this.richTextBox_partOfSpeech.TabIndex = 1;
            this.richTextBox_partOfSpeech.Text = "品詞名";
            // 
            // label_asterisk1
            // 
            this.label_asterisk1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asterisk1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_asterisk1.Location = new System.Drawing.Point(16, 0);
            this.label_asterisk1.Name = "label_asterisk1";
            this.label_asterisk1.Size = new System.Drawing.Size(17, 15);
            this.label_asterisk1.TabIndex = 18;
            this.label_asterisk1.Text = "*";
            // 
            // label_asterisk2
            // 
            this.label_asterisk2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asterisk2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_asterisk2.Location = new System.Drawing.Point(677, 27);
            this.label_asterisk2.Name = "label_asterisk2";
            this.label_asterisk2.Size = new System.Drawing.Size(17, 15);
            this.label_asterisk2.TabIndex = 19;
            this.label_asterisk2.Text = "*";
            // 
            // label_asterisk3
            // 
            this.label_asterisk3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asterisk3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_asterisk3.Location = new System.Drawing.Point(97, 132);
            this.label_asterisk3.Name = "label_asterisk3";
            this.label_asterisk3.Size = new System.Drawing.Size(17, 15);
            this.label_asterisk3.TabIndex = 20;
            this.label_asterisk3.Text = "*";
            // 
            // Form_makeNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(833, 907);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label_titleForm);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_close);
            this.Name = "Form_makeNew";
            this.Text = "新規登録 - MyRusLexicon";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_titleForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_textExampleSentence;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentence1;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentence2;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentenceTranslation1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox richTextBox_translation;
        private System.Windows.Forms.RichTextBox richTextBox_partOfSpeech;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentenceTranslation2;
        private System.Windows.Forms.RichTextBox richTextBox_word;
        private System.Windows.Forms.Label label_asterisk1;
        private System.Windows.Forms.Label label_asterisk3;
        private System.Windows.Forms.Label label_asterisk2;
    }
}