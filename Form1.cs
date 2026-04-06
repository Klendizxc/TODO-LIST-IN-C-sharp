using System.Windows.Forms;

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

            try
            {
                if (InputTask.Text == "")
                {
                    throw new ArgumentException("Task cannot be empty.");
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(InputTask.Text))
                    {
                        TaskCard taskCard = new TaskCard(InputTask.Text);
                        taskCard.Width = taskBoard.Width - 25;
                        taskBoard.Controls.Add(taskCard);
                        InputTask.Clear();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
