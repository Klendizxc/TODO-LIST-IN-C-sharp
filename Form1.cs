using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskText = InputTask.Text.Trim();
            string statusText = statusBox.Text.Trim();

            if (string.IsNullOrEmpty(taskText) || string.IsNullOrEmpty(statusText))
            {
                MessageBox.Show("Название задачи и статус не может быть пустым!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTask.Focus();
                return;
            }
            else
            {
                TaskCard taskCard = new TaskCard(InputTask.Text, statusBox.Text);
                taskCard.Width = taskBoard.Width - 25;
                taskBoard.Controls.Add(taskCard);
                InputTask.Clear();
            }
        }
    }
}
