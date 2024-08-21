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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();

            this.Load += Form_main_Load;
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            listView.GridLines = true;

            ListViewItem example1 = new ListViewItem("Россия");
            example1.SubItems.Add("名詞");
            listView.Items.Add(example1);

            ListViewItem example2 = new ListViewItem("Япония");
            example2.SubItems.Add("名詞");
            listView.Items.Add(example2);
        }
    }
}
