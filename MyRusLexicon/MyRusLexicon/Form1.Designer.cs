namespace MyRusLexicon
{
    partial class Form_main
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
            this.components = new System.ComponentModel.Container();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_makeNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.label_lineTop = new System.Windows.Forms.Label();
            this.label_lineCenter = new System.Windows.Forms.Label();
            this.label_lineMiddle = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel = new System.Windows.Forms.Panel();
            this.label_exampleSentenceTranslation2 = new System.Windows.Forms.Label();
            this.label_exampleSentenceTranslation1 = new System.Windows.Forms.Label();
            this.label_exampleSentence2 = new System.Windows.Forms.Label();
            this.label_textExampleSentence = new System.Windows.Forms.Label();
            this.label_textTranslation = new System.Windows.Forms.Label();
            this.label_exampleSentence1 = new System.Windows.Forms.Label();
            this.label_partOfSpeech = new System.Windows.Forms.Label();
            this.label_translation = new System.Windows.Forms.Label();
            this.label_word = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_search.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.textBox_search.Location = new System.Drawing.Point(21, 48);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(211, 22);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_search.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.button_search.Location = new System.Drawing.Point(250, 45);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(60, 25);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "検索";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_makeNew,
            this.toolStripMenuItem_edit,
            this.toolStripMenuItem_delete,
            this.toolStripMenuItem_about});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem_makeNew
            // 
            this.toolStripMenuItem_makeNew.Name = "toolStripMenuItem_makeNew";
            this.toolStripMenuItem_makeNew.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem_makeNew.Text = "新規登録";
            // 
            // toolStripMenuItem_edit
            // 
            this.toolStripMenuItem_edit.Name = "toolStripMenuItem_edit";
            this.toolStripMenuItem_edit.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem_edit.Text = "編集";
            // 
            // toolStripMenuItem_delete
            // 
            this.toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            this.toolStripMenuItem_delete.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem_delete.Text = "削除";
            // 
            // toolStripMenuItem_about
            // 
            this.toolStripMenuItem_about.Name = "toolStripMenuItem_about";
            this.toolStripMenuItem_about.Size = new System.Drawing.Size(88, 20);
            this.toolStripMenuItem_about.Text = "アプリについて";
            // 
            // label_lineTop
            // 
            this.label_lineTop.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_lineTop.Location = new System.Drawing.Point(0, 24);
            this.label_lineTop.Name = "label_lineTop";
            this.label_lineTop.Size = new System.Drawing.Size(984, 1);
            this.label_lineTop.TabIndex = 11;
            // 
            // label_lineCenter
            // 
            this.label_lineCenter.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_lineCenter.Location = new System.Drawing.Point(350, 24);
            this.label_lineCenter.Name = "label_lineCenter";
            this.label_lineCenter.Size = new System.Drawing.Size(1, 538);
            this.label_lineCenter.TabIndex = 12;
            // 
            // label_lineMiddle
            // 
            this.label_lineMiddle.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_lineMiddle.Location = new System.Drawing.Point(0, 92);
            this.label_lineMiddle.Name = "label_lineMiddle";
            this.label_lineMiddle.Size = new System.Drawing.Size(350, 1);
            this.label_lineMiddle.TabIndex = 14;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.type});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 94);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(350, 468);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "単語名";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 250;
            // 
            // type
            // 
            this.type.Text = "品詞名";
            this.type.Width = 100;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.label_exampleSentenceTranslation2);
            this.panel.Controls.Add(this.label_exampleSentenceTranslation1);
            this.panel.Controls.Add(this.label_exampleSentence2);
            this.panel.Controls.Add(this.label_textExampleSentence);
            this.panel.Controls.Add(this.label_textTranslation);
            this.panel.Controls.Add(this.label_exampleSentence1);
            this.panel.Controls.Add(this.label_partOfSpeech);
            this.panel.Controls.Add(this.label_translation);
            this.panel.Controls.Add(this.label_word);
            this.panel.Location = new System.Drawing.Point(352, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(632, 535);
            this.panel.TabIndex = 16;
            // 
            // label_exampleSentenceTranslation2
            // 
            this.label_exampleSentenceTranslation2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exampleSentenceTranslation2.Location = new System.Drawing.Point(30, 456);
            this.label_exampleSentenceTranslation2.Name = "label_exampleSentenceTranslation2";
            this.label_exampleSentenceTranslation2.Size = new System.Drawing.Size(578, 27);
            this.label_exampleSentenceTranslation2.TabIndex = 9;
            this.label_exampleSentenceTranslation2.Text = "例文訳";
            // 
            // label_exampleSentenceTranslation1
            // 
            this.label_exampleSentenceTranslation1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exampleSentenceTranslation1.Location = new System.Drawing.Point(32, 340);
            this.label_exampleSentenceTranslation1.Name = "label_exampleSentenceTranslation1";
            this.label_exampleSentenceTranslation1.Size = new System.Drawing.Size(578, 27);
            this.label_exampleSentenceTranslation1.TabIndex = 8;
            this.label_exampleSentenceTranslation1.Text = "例文訳";
            // 
            // label_exampleSentence2
            // 
            this.label_exampleSentence2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exampleSentence2.Location = new System.Drawing.Point(28, 376);
            this.label_exampleSentence2.Name = "label_exampleSentence2";
            this.label_exampleSentence2.Size = new System.Drawing.Size(578, 70);
            this.label_exampleSentence2.TabIndex = 7;
            this.label_exampleSentence2.Text = "例文";
            this.label_exampleSentence2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_textExampleSentence
            // 
            this.label_textExampleSentence.AutoSize = true;
            this.label_textExampleSentence.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textExampleSentence.Location = new System.Drawing.Point(28, 230);
            this.label_textExampleSentence.Name = "label_textExampleSentence";
            this.label_textExampleSentence.Size = new System.Drawing.Size(68, 31);
            this.label_textExampleSentence.TabIndex = 6;
            this.label_textExampleSentence.Text = "例文";
            // 
            // label_textTranslation
            // 
            this.label_textTranslation.AutoSize = true;
            this.label_textTranslation.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textTranslation.Location = new System.Drawing.Point(28, 98);
            this.label_textTranslation.Name = "label_textTranslation";
            this.label_textTranslation.Size = new System.Drawing.Size(55, 31);
            this.label_textTranslation.TabIndex = 4;
            this.label_textTranslation.Text = "訳：";
            // 
            // label_exampleSentence1
            // 
            this.label_exampleSentence1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exampleSentence1.Location = new System.Drawing.Point(28, 261);
            this.label_exampleSentence1.Name = "label_exampleSentence1";
            this.label_exampleSentence1.Size = new System.Drawing.Size(578, 70);
            this.label_exampleSentence1.TabIndex = 3;
            this.label_exampleSentence1.Text = "例文";
            this.label_exampleSentence1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_partOfSpeech
            // 
            this.label_partOfSpeech.AutoSize = true;
            this.label_partOfSpeech.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_partOfSpeech.Location = new System.Drawing.Point(511, 35);
            this.label_partOfSpeech.Name = "label_partOfSpeech";
            this.label_partOfSpeech.Size = new System.Drawing.Size(95, 31);
            this.label_partOfSpeech.TabIndex = 2;
            this.label_partOfSpeech.Text = "品詞名";
            // 
            // label_translation
            // 
            this.label_translation.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_translation.Location = new System.Drawing.Point(89, 98);
            this.label_translation.Name = "label_translation";
            this.label_translation.Size = new System.Drawing.Size(531, 97);
            this.label_translation.TabIndex = 1;
            this.label_translation.Text = "訳";
            // 
            // label_word
            // 
            this.label_word.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_word.Location = new System.Drawing.Point(24, 21);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(508, 55);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "単語名";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label_lineMiddle);
            this.Controls.Add(this.label_lineCenter);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_lineTop);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form_main";
            this.Text = "MyRusLexicon";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_makeNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_delete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_about;
        private System.Windows.Forms.Label label_lineTop;
        private System.Windows.Forms.Label label_lineCenter;
        private System.Windows.Forms.Label label_lineMiddle;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.Label label_partOfSpeech;
        private System.Windows.Forms.Label label_translation;
        private System.Windows.Forms.Label label_exampleSentence1;
        private System.Windows.Forms.Label label_textExampleSentence;
        private System.Windows.Forms.Label label_textTranslation;
        private System.Windows.Forms.Label label_exampleSentence2;
        private System.Windows.Forms.Label label_exampleSentenceTranslation1;
        private System.Windows.Forms.Label label_exampleSentenceTranslation2;
    }
}

