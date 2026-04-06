using Microsoft.VisualBasic.ApplicationServices;
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

        public string AssignedUser
        {
            get => userLbl.Text;
            set
            {
                userLbl.Text = value;

                if (!string.IsNullOrEmpty(value))
                {
                    userBox.Enabled = false;
                    userBox.Visible = false;
                    userLbl.Visible = true;
                }
            }
        }

        private TaskStatus _status;

        public TaskStatus Status
        {
            get => _status;
            set
            {
                _status = value;

                if (_status == TaskStatus.ToDo)
                {
                    statusLbl.Text = "To Do";
                    statusLbl.ForeColor = Color.DarkGray;
                }
                else if (_status == TaskStatus.InProgress)
                {
                    statusLbl.Text = "In Progress";
                    statusLbl.ForeColor = Color.DodgerBlue;
                }
                else if (_status == TaskStatus.Done)
                {
                    statusLbl.Text = "Done";
                    statusLbl.ForeColor = Color.MediumSeaGreen;
                }
            }
        }

        public TaskCard(string text)
        {
            InitializeComponent();
            TaskText = text;
            userLbl.Text = "";
            Status = TaskStatus.ToDo;
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
                Status = TaskStatus.InProgress;
            }
        }

        private void checkTask_CheckedChanged(object sender, EventArgs e)
        {
            if (isCompleted && isAccepted)
            {
                TaskLbl.Font = new System.Drawing.Font(TaskLbl.Font, FontStyle.Strikeout);
                TaskLbl.ForeColor = Color.Gray;
                Status = TaskStatus.Done;
                Status = TaskStatus.Done;
            }
            else if (!isCompleted && isAccepted)
            {

                Status = TaskStatus.InProgress;
            }
            else
            {
                TaskLbl.Font = new System.Drawing.Font(TaskLbl.Font, FontStyle.Regular);
                TaskLbl.ForeColor = Color.Black;
                Status = TaskStatus.ToDo;
            }
        }
        private void deleteBtn_MouseEnter(object sender, EventArgs e)
        {
            deleteBtn.BackColor = Color.Red;
            deleteBtn.ForeColor = Color.White;
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteBtn.BackColor = Color.MistyRose;
            deleteBtn.ForeColor = Color.DarkRed;
        }
    }
}
