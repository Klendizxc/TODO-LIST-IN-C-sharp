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

        private TaskStatus _status;

        public TaskStatus Status
        {
            get => _status;
            set
            {
                _status = value;

                if (_status == TaskStatus.ToDo)
                    statusLbl.Text = "To Do";
                else if (_status == TaskStatus.InProgress)
                    statusLbl.Text = "In Progress";
                else if (_status == TaskStatus.Done)
                    statusLbl.Text = "Done";
            }
        }

        public TaskCard(string text)
        {
            InitializeComponent();
            TaskText = text;
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
                _status = TaskStatus.InProgress;
            }
        }

        private void checkTask_CheckedChanged(object sender, EventArgs e)
        {
            if (isCompleted && isAccepted)
            {
                Status = TaskStatus.Done;
            }
            else if (!isCompleted && isAccepted)
            {
                Status = TaskStatus.InProgress;
            }
            else
            {
                Status = TaskStatus.ToDo;
            }
        }
    }
}
