namespace WinFormsApp1
{
    public partial class TaskCard : UserControl
    {
        public event EventHandler? DeleteRequested;
        public string TaskText
        {
            get => taskLbl.Text;
            set => taskLbl.Text = value;
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
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        private void AcceptUser()
        {
            string user = userBox.Text.Trim();
            if (string.IsNullOrEmpty(user))
                return;

            userLbl.Text = user;
            userBox.Visible = false;
            userLbl.Visible = true;

            if (!isCompleted)
                Status = TaskStatus.InProgress;
        }

        private void userBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AcceptUser();
                e.SuppressKeyPress = true;
            }
        }

        private void userBox_Leave(object sender, EventArgs e)
        {
            AcceptUser();
        }

        private void userLbl_Click(object sender, EventArgs e)
        {
            userBox.Text = userLbl.Text;
            userLbl.Visible = false;
            userBox.Visible = true;
            userBox.Focus();
        }

        private void SetTaskFont(FontStyle style, Color color)
        {
            var oldFont = taskLbl.Font;
            taskLbl.Font = new Font(oldFont.FontFamily, oldFont.Size, style);
            taskLbl.ForeColor = color;

            if (oldFont != Font)
                oldFont.Dispose();
        }

        private void checkTask_CheckedChanged(object sender, EventArgs e)
        {
            if (isCompleted && isAccepted)
            {
                SetTaskFont(FontStyle.Strikeout, Color.Gray);
                Status = TaskStatus.Done;
            }
            else if (!isCompleted && isAccepted)
            {
                SetTaskFont(FontStyle.Regular, Color.FromArgb(64, 64, 64));
                Status = TaskStatus.InProgress;
            }
            else
            {
                SetTaskFont(FontStyle.Regular, Color.FromArgb(64, 64, 64));
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
