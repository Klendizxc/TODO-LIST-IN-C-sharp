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
            TaskLbl = new Label();
            checkTask = new CheckBox();
            statusLbl = new Label();
            userBox = new TextBox();
            userLbl = new Label();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(166, 68);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(78, 29);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Удалить";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // TaskLbl
            // 
            TaskLbl.AutoSize = true;
            TaskLbl.Location = new Point(29, 25);
            TaskLbl.Name = "TaskLbl";
            TaskLbl.Size = new Size(50, 20);
            TaskLbl.TabIndex = 1;
            TaskLbl.Text = "label1";
            // 
            // checkTask
            // 
            checkTask.AutoSize = true;
            checkTask.Location = new Point(3, 25);
            checkTask.Name = "checkTask";
            checkTask.Size = new Size(18, 17);
            checkTask.TabIndex = 0;
            checkTask.UseVisualStyleBackColor = true;
            checkTask.CheckedChanged += checkTask_CheckedChanged;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(19, 72);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(13, 20);
            statusLbl.TabIndex = 3;
            statusLbl.Text = " ";
            // 
            // userBox
            // 
            userBox.Location = new Point(83, 2);
            userBox.Name = "userBox";
            userBox.PlaceholderText = "Кто принял зд?";
            userBox.Size = new Size(161, 27);
            userBox.TabIndex = 4;
            userBox.KeyDown += userBox_KeyDown;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Location = new Point(194, 5);
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
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(userLbl);
            Controls.Add(userBox);
            Controls.Add(statusLbl);
            Controls.Add(checkTask);
            Controls.Add(TaskLbl);
            Controls.Add(deleteBtn);
            Name = "TaskCard";
            Size = new Size(247, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkTask;
        private Button deleteBtn;
        private Label TaskLbl;
        private Label statusLbl;
        private TextBox userBox;
        private Label userLbl;
    }
}
