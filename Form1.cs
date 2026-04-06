using System.Windows.Forms;
using System.Xml.Serialization;
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

            if (string.IsNullOrEmpty(taskText))
            {
                MessageBox.Show("Название задачи и статус не может быть пустым!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTask.Focus();
                return;
            }
            else
            {
                TaskCard taskCard = new TaskCard(InputTask.Text, "To Do");
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
                    if (selectedFilter == taskCard.Status)
                    {
                        taskCard.Visible = true;
                    }
                    else if (selectedFilter == "All")
                    {
                        taskCard.Visible = true;
                    }
                    else
                    {
                        taskCard.Visible = false;
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
