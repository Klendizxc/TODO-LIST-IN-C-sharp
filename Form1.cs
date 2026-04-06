using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.IO;
using System.Runtime.InteropServices;

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
        private void SaveTasksToFile()
        {
            List<TaskData> tasksToSave = new List<TaskData>();

            foreach (Control control in taskBoard.Controls)
            {
                if (control is TaskCard card)
                {
                    tasksToSave.Add(new TaskData
                    {
                        Task = card.TaskText,
                        Status = card.Status,
                        AssignedUser = card.AssignedUser // Забираем имя из карточки
                    });
                }
            }
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(tasksToSave, options);
            File.WriteAllText("myTasks.json", jsonString);
        }
        private void LoadTasksFromFile()
        {
            if (File.Exists("myTasks.json"))
            {
                string jsonString = File.ReadAllText("myTasks.json");
                var savedTasks = JsonSerializer.Deserialize<List<TaskData>>(jsonString);

                if (savedTasks != null)
                {
                    foreach (var task in savedTasks)
                    {
                        TaskCard taskCard = new TaskCard(task.Task);
                        taskCard.AssignedUser = task.AssignedUser;
                        taskCard.Status = task.Status;
                        taskCard.Width = taskBoard.Width - 25;
                        taskBoard.Controls.Add(taskCard);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasksToFile();
        }
    }
}
