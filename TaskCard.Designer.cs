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
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(119, 68);
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
            TaskLbl.Location = new Point(27, 3);
            TaskLbl.Name = "TaskLbl";
            TaskLbl.Size = new Size(50, 20);
            TaskLbl.TabIndex = 1;
            TaskLbl.Text = "label1";
            // 
            // checkTask
            // 
            checkTask.AutoSize = true;
            checkTask.Location = new Point(3, 3);
            checkTask.Name = "checkTask";
            checkTask.Size = new Size(18, 17);
            checkTask.TabIndex = 0;
            checkTask.UseVisualStyleBackColor = true;
            // 
            // TaskCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkTask);
            Controls.Add(TaskLbl);
            Controls.Add(deleteBtn);
            Name = "TaskCard";
            Size = new Size(200, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkTask;
        private Button deleteBtn;
        private Label TaskLbl;
    }
}
