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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class TaskCard : UserControl
    {
        public string TaskText
        {
            get => TaskLbl.Text;
            set => TaskLbl.Text = value;
        }
        private bool isCompleted => checkTask.Checked;
        private bool isAccepted => userLbl.Text != "";

        public string Status { get => statusLbl.Text; set => statusLbl.Text = value; }

        public TaskCard(string text, string status)
        {
            InitializeComponent();
            TaskText = text;
            Status = status;
            userLbl.Text = "";
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
        private void userBox_KeyDown(object sender, KeyEventArgs e)
        {
            string user = userBox.Text.Trim();
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(user))
            {
                userLbl.Text = userBox.Text;
                userBox.Enabled = false;
                userBox.Visible = false;
                userLbl.Visible = true;
                e.SuppressKeyPress = true;
                Status = "In Progress";
            }
        }

        private void checkTask_CheckedChanged(object sender, EventArgs e)
        {
            if (isCompleted && isAccepted)
            {
                Status = "Done";
            }
            else if (!isCompleted && isAccepted)
            {
                Status = "In Progress";
            }
            else
            {
                Status = "To Do";
            }
        }
    }
}
