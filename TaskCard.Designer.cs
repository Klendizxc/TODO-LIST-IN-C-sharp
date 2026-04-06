namespace WinFormsApp1
{
    partial class TaskCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            deleteBtn = new Button();
            taskLbl = new Label();
            checkTask = new CheckBox();
            statusLbl = new Label();
            userBox = new TextBox();
            userLbl = new Label();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteBtn.BackColor = Color.MistyRose;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(253, 12);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(78, 29);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Удалить";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            deleteBtn.MouseEnter += deleteBtn_MouseEnter;
            deleteBtn.MouseLeave += deleteBtn_MouseLeave;
            // 
            // taskLbl
            // 
            taskLbl.AutoSize = true;
            taskLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            taskLbl.ForeColor = Color.FromArgb(64, 64, 64);
            taskLbl.Location = new Point(13, 49);
            taskLbl.MaximumSize = new Size(300, 0);
            taskLbl.Name = "taskLbl";
            taskLbl.Size = new Size(55, 23);
            taskLbl.TabIndex = 1;
            taskLbl.Text = "label1";
            // 
            // checkTask
            // 
            checkTask.AutoSize = true;
            checkTask.Location = new Point(13, 19);
            checkTask.Name = "checkTask";
            checkTask.Size = new Size(18, 17);
            checkTask.TabIndex = 0;
            checkTask.UseVisualStyleBackColor = true;
            checkTask.CheckedChanged += checkTask_CheckedChanged;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(37, 16);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(13, 20);
            statusLbl.TabIndex = 3;
            statusLbl.Text = " ";
            // 
            // userBox
            // 
            userBox.BorderStyle = BorderStyle.None;
            userBox.Location = new Point(112, 12);
            userBox.Name = "userBox";
            userBox.PlaceholderText = "Кто принял зд?";
            userBox.Size = new Size(133, 20);
            userBox.TabIndex = 4;
            userBox.KeyDown += userBox_KeyDown;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Location = new Point(122, 16);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(50, 20);
            userLbl.TabIndex = 5;
            userLbl.Text = "label1";
            userLbl.Visible = false;
            // 
            // TaskCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(userLbl);
            Controls.Add(userBox);
            Controls.Add(statusLbl);
            Controls.Add(checkTask);
            Controls.Add(taskLbl);
            Controls.Add(deleteBtn);
            MaximumSize = new Size(400, 0);
            Name = "TaskCard";
            Padding = new Padding(10);
            Size = new Size(344, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkTask;
        private Button deleteBtn;
        private Label taskLbl;
        private Label statusLbl;
        private TextBox userBox;
        private Label userLbl;
    }
}
