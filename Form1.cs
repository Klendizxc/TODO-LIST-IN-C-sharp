using System.Text.Json;

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

        private void addBtn_Click(object sender, EventArgs e)
        {
            string taskText = inputTask.Text.Trim();

            if (string.IsNullOrEmpty(taskText))
            {
                MessageBox.Show("Название задачи и статус не может быть пустым!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputTask.Focus();
                return;
            }
            else
            {
                TaskCard taskCard = new TaskCard(inputTask.Text);
                taskCard.DeleteRequested += TaskCard_DeleteRequested;
                taskCard.Width = taskBoard.Width - 25;
                taskBoard.Controls.Add(taskCard);
                inputTask.Clear();
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

        private void TaskCard_DeleteRequested(object? sender, EventArgs e)
        {
            if (sender is TaskCard card)
            {
                card.DeleteRequested -= TaskCard_DeleteRequested;
                taskBoard.Controls.Remove(card);
                card.Dispose();
            }
        }
        private void SaveTasksToFile()
        {
            try
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
                            AssignedUser = card.AssignedUser
                        });
                    }
                }
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(tasksToSave, options);
                File.WriteAllText("myTasks.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении задач: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTasksFromFile()
        {
            try
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
                            taskCard.DeleteRequested += TaskCard_DeleteRequested;
                            taskCard.AssignedUser = task.AssignedUser;
                            taskCard.Status = task.Status;
                            taskCard.Width = taskBoard.Width - 25;
                            taskBoard.Controls.Add(taskCard);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке задач: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
