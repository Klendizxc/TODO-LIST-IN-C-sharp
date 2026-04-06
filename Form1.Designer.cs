namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            addBtn = new Button();
            InputTask = new TextBox();
            exceptionLbl = new Label();
            statusBox = new ComboBox();
            taskBoard = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 1;
            label1.Text = "Tasks:";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(477, 549);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(63, 29);
            addBtn.TabIndex = 2;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += button1_Click;
            // 
            // InputTask
            // 
            InputTask.Location = new Point(12, 549);
            InputTask.Name = "InputTask";
            InputTask.PlaceholderText = "Создать задачу";
            InputTask.Size = new Size(294, 27);
            InputTask.TabIndex = 3;
            // 
            // exceptionLbl
            // 
            exceptionLbl.AutoSize = true;
            exceptionLbl.Location = new Point(615, 552);
            exceptionLbl.Name = "exceptionLbl";
            exceptionLbl.Size = new Size(13, 20);
            exceptionLbl.TabIndex = 6;
            exceptionLbl.Text = " ";
            // 
            // statusBox
            // 
            statusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "To Do", "In Progress", "Done" });
            statusBox.Location = new Point(320, 550);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(151, 28);
            statusBox.TabIndex = 7;
            // 
            // taskBoard
            // 
            taskBoard.Location = new Point(12, 44);
            taskBoard.Name = "taskBoard";
            taskBoard.Size = new Size(1476, 499);
            taskBoard.TabIndex = 8;
            taskBoard.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 587);
            Controls.Add(taskBoard);
            Controls.Add(statusBox);
            Controls.Add(exceptionLbl);
            Controls.Add(InputTask);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addBtn;
        private TextBox InputTask;
        private Label exceptionLbl;
        private ComboBox statusBox;
        private FlowLayoutPanel taskBoard;
    }
}
