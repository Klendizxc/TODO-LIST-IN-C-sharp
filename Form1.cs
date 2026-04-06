using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskText = InputTask.Text.Trim();

            if (string.IsNullOrEmpty(taskText))
            {
                MessageBox.Show("Название задачи и статус не может быть пустым!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTask.Focus();
                return;
            }
            else
            {
                TaskCard taskCard = new TaskCard(InputTask.Text);
                taskCard.Width = taskBoard.Width - 25;
                taskBoard.Controls.Add(taskCard);
                InputTask.Clear();
            }
        }
        private void ApplyFilter()
        {
            string selectedFilter = filterBox.Text;
            foreach (Control control in taskBoard.Controls)
            {
                if (control is TaskCard taskCard)
                {
                    if (selectedFilter == "All" || string.IsNullOrEmpty(selectedFilter))
                    {
                        taskCard.Visible = true;
                    }
                    else if (selectedFilter == "To Do")
                    {
                        taskCard.Visible = (taskCard.Status == TaskStatus.ToDo);
                    }
                    else if (selectedFilter == "In Progress")
                    {
                        taskCard.Visible = (taskCard.Status == TaskStatus.InProgress);
                    }
                    else if (selectedFilter == "Done")
                    {
                        taskCard.Visible = (taskCard.Status == TaskStatus.Done);
                    }
                }
            }
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
