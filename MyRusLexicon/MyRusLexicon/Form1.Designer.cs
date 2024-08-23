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
            this.richTextBox_exampleSentenceTranslation2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentenceTranslation1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentence2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_exampleSentence1 = new System.Windows.Forms.RichTextBox();
            this.label_textExampleSentence = new System.Windows.Forms.Label();
            this.label_textTranslation = new System.Windows.Forms.Label();
            this.richTextBox_word = new System.Windows.Forms.RichTextBox();
            this.richTextBox_partOfSpeech = new System.Windows.Forms.RichTextBox();
            this.richTextBox_translation = new System.Windows.Forms.RichTextBox();
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
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem_makeNew
            // 
            this.toolStripMenuItem_makeNew.Name = "toolStripMenuItem_makeNew";
            this.toolStripMenuItem_makeNew.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem_makeNew.Text = "新規登録";
            this.toolStripMenuItem_makeNew.Click += new System.EventHandler(this.toolStripMenuItem_makeNew_Click);
            // 
            // toolStripMenuItem_edit
            // 
            this.toolStripMenuItem_edit.Name = "toolStripMenuItem_edit";
            this.toolStripMenuItem_edit.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem_edit.Text = "編集";
            this.toolStripMenuItem_edit.Click += new System.EventHandler(this.toolStripMenuItem_edit_Click);
            // 
            // toolStripMenuItem_delete
            // 
            this.toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            this.toolStripMenuItem_delete.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem_delete.Text = "削除";
            this.toolStripMenuItem_delete.Click += new System.EventHandler(this.toolStripMenuItem_delete_Click);
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
            this.label_lineTop.Size = new System.Drawing.Size(1184, 1);
            this.label_lineTop.TabIndex = 11;
            // 
            // label_lineCenter
            // 
            this.label_lineCenter.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_lineCenter.Location = new System.Drawing.Point(350, 24);
            this.label_lineCenter.Name = "label_lineCenter";
            this.label_lineCenter.Size = new System.Drawing.Size(1, 738);
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
            this.listView.Size = new System.Drawing.Size(350, 667);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "単語名";
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
            this.panel.Controls.Add(this.richTextBox_exampleSentenceTranslation2);
            this.panel.Controls.Add(this.richTextBox_exampleSentenceTranslation1);
            this.panel.Controls.Add(this.richTextBox_exampleSentence2);
            this.panel.Controls.Add(this.richTextBox_exampleSentence1);
            this.panel.Controls.Add(this.label_textExampleSentence);
            this.panel.Controls.Add(this.label_textTranslation);
            this.panel.Controls.Add(this.richTextBox_word);
            this.panel.Controls.Add(this.richTextBox_partOfSpeech);
            this.panel.Controls.Add(this.richTextBox_translation);
            this.panel.Location = new System.Drawing.Point(352, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(832, 737);
            this.panel.TabIndex = 16;
            // 
            // richTextBox_exampleSentenceTranslation2
            // 
            this.richTextBox_exampleSentenceTranslation2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_exampleSentenceTranslation2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_exampleSentenceTranslation2.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_exampleSentenceTranslation2.Location = new System.Drawing.Point(30, 599);
            this.richTextBox_exampleSentenceTranslation2.Name = "richTextBox_exampleSentenceTranslation2";
            this.richTextBox_exampleSentenceTranslation2.ReadOnly = true;
            this.richTextBox_exampleSentenceTranslation2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentenceTranslation2.Size = new System.Drawing.Size(782, 45);
            this.richTextBox_exampleSentenceTranslation2.TabIndex = 20;
            this.richTextBox_exampleSentenceTranslation2.TabStop = false;
            this.richTextBox_exampleSentenceTranslation2.Text = "例文";
            // 
            // richTextBox_exampleSentenceTranslation1
            // 
            this.richTextBox_exampleSentenceTranslation1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_exampleSentenceTranslation1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_exampleSentenceTranslation1.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_exampleSentenceTranslation1.Location = new System.Drawing.Point(30, 411);
            this.richTextBox_exampleSentenceTranslation1.Name = "richTextBox_exampleSentenceTranslation1";
            this.richTextBox_exampleSentenceTranslation1.ReadOnly = true;
            this.richTextBox_exampleSentenceTranslation1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentenceTranslation1.Size = new System.Drawing.Size(780, 48);
            this.richTextBox_exampleSentenceTranslation1.TabIndex = 19;
            this.richTextBox_exampleSentenceTranslation1.TabStop = false;
            this.richTextBox_exampleSentenceTranslation1.Text = "例文";
            // 
            // richTextBox_exampleSentence2
            // 
            this.richTextBox_exampleSentence2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_exampleSentence2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_exampleSentence2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentence2.Location = new System.Drawing.Point(30, 515);
            this.richTextBox_exampleSentence2.Name = "richTextBox_exampleSentence2";
            this.richTextBox_exampleSentence2.ReadOnly = true;
            this.richTextBox_exampleSentence2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentence2.Size = new System.Drawing.Size(782, 78);
            this.richTextBox_exampleSentence2.TabIndex = 18;
            this.richTextBox_exampleSentence2.TabStop = false;
            this.richTextBox_exampleSentence2.Text = "例文";
            // 
            // richTextBox_exampleSentence1
            // 
            this.richTextBox_exampleSentence1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_exampleSentence1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_exampleSentence1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exampleSentence1.Location = new System.Drawing.Point(30, 327);
            this.richTextBox_exampleSentence1.Name = "richTextBox_exampleSentence1";
            this.richTextBox_exampleSentence1.ReadOnly = true;
            this.richTextBox_exampleSentence1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_exampleSentence1.Size = new System.Drawing.Size(782, 78);
            this.richTextBox_exampleSentence1.TabIndex = 17;
            this.richTextBox_exampleSentence1.TabStop = false;
            this.richTextBox_exampleSentence1.Text = "例文";
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
            // label_textTranslation
            // 
            this.label_textTranslation.AutoSize = true;
            this.label_textTranslation.Font = new System.Drawing.Font("Yu Mincho Demibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_textTranslation.Location = new System.Drawing.Point(24, 150);
            this.label_textTranslation.Name = "label_textTranslation";
            this.label_textTranslation.Size = new System.Drawing.Size(69, 34);
            this.label_textTranslation.TabIndex = 4;
            this.label_textTranslation.Text = "訳：";
            // 
            // richTextBox_word
            // 
            this.richTextBox_word.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_word.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_word.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_word.Location = new System.Drawing.Point(20, 15);
            this.richTextBox_word.Name = "richTextBox_word";
            this.richTextBox_word.ReadOnly = true;
            this.richTextBox_word.Size = new System.Drawing.Size(655, 112);
            this.richTextBox_word.TabIndex = 21;
            this.richTextBox_word.TabStop = false;
            this.richTextBox_word.Text = "Слово";
            // 
            // richTextBox_partOfSpeech
            // 
            this.richTextBox_partOfSpeech.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_partOfSpeech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_partOfSpeech.Font = new System.Drawing.Font("Yu Mincho Demibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox_partOfSpeech.Location = new System.Drawing.Point(679, 46);
            this.richTextBox_partOfSpeech.Name = "richTextBox_partOfSpeech";
            this.richTextBox_partOfSpeech.ReadOnly = true;
            this.richTextBox_partOfSpeech.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox_partOfSpeech.Size = new System.Drawing.Size(131, 44);
            this.richTextBox_partOfSpeech.TabIndex = 22;
            this.richTextBox_partOfSpeech.TabStop = false;
            this.richTextBox_partOfSpeech.Text = "品詞名";
            // 
            // richTextBox_translation
            // 
            this.richTextBox_translation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_translation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_translation.Font = new System.Drawing.Font("Yu Mincho", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox_translation.Location = new System.Drawing.Point(101, 144);
            this.richTextBox_translation.Name = "richTextBox_translation";
            this.richTextBox_translation.ReadOnly = true;
            this.richTextBox_translation.Size = new System.Drawing.Size(709, 102);
            this.richTextBox_translation.TabIndex = 23;
            this.richTextBox_translation.TabStop = false;
            this.richTextBox_translation.Text = "訳";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label_lineMiddle);
            this.Controls.Add(this.label_lineCenter);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_lineTop);
            this.MainMenuStrip = this.menuStrip;
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
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label_textExampleSentence;
        private System.Windows.Forms.Label label_textTranslation;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentence1;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentenceTranslation1;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentence2;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.RichTextBox richTextBox_exampleSentenceTranslation2;
        private System.Windows.Forms.RichTextBox richTextBox_word;
        private System.Windows.Forms.RichTextBox richTextBox_translation;
        private System.Windows.Forms.RichTextBox richTextBox_partOfSpeech;
    }
}

