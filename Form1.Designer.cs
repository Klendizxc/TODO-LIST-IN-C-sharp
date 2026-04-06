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
            components = new System.ComponentModel.Container();
            addBtn = new Button();
            InputTask = new TextBox();
            exceptionLbl = new Label();
            taskBoard = new FlowLayoutPanel();
            filterBox = new ComboBox();
            imageList1 = new ImageList(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(312, 549);
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
            // taskBoard
            // 
            taskBoard.Location = new Point(12, 44);
            taskBoard.Name = "taskBoard";
            taskBoard.Size = new Size(1476, 499);
            taskBoard.TabIndex = 8;
            // 
            // filterBox
            // 
            filterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterBox.FormattingEnabled = true;
            filterBox.Items.AddRange(new object[] { "To Do", "In Progress", "Done", "All" });
            filterBox.Location = new Point(81, 10);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(151, 28);
            filterBox.TabIndex = 9;
            filterBox.SelectedIndexChanged += filterBox_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(63, 32);
            label1.TabIndex = 10;
            label1.Text = "filter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1500, 587);
            Controls.Add(label1);
            Controls.Add(filterBox);
            Controls.Add(taskBoard);
            Controls.Add(exceptionLbl);
            Controls.Add(InputTask);
            Controls.Add(addBtn);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addBtn;
        private TextBox InputTask;
        private Label exceptionLbl;
        private FlowLayoutPanel taskBoard;
        private ComboBox filterBox;
        private ImageList imageList1;
        private Label label1;
    }
}
