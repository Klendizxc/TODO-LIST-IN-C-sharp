using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class TaskCard : UserControl
    {
        public string TaskText
        {
            get => TaskLbl.Text;
            set => TaskLbl.Text = value;
        }

        public TaskCard(string text)
        {
            InitializeComponent();
            TaskText = text;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

    }
}
