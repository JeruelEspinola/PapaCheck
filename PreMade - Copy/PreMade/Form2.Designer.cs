namespace PreMade
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStudentInfo = new Button();
            btnGradeChecker = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // btnStudentInfo
            // 
            btnStudentInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentInfo.Location = new Point(126, 67);
            btnStudentInfo.Name = "btnStudentInfo";
            btnStudentInfo.Size = new Size(384, 56);
            btnStudentInfo.TabIndex = 0;
            btnStudentInfo.Text = "Student Information";
            btnStudentInfo.UseVisualStyleBackColor = true;
            // 
            // btnGradeChecker
            // 
            btnGradeChecker.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGradeChecker.Location = new Point(126, 163);
            btnGradeChecker.Name = "btnGradeChecker";
            btnGradeChecker.Size = new Size(384, 56);
            btnGradeChecker.TabIndex = 1;
            btnGradeChecker.Text = "Check Grade";
            btnGradeChecker.UseVisualStyleBackColor = true;
            btnGradeChecker.Click += btnGradeChecker_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(47, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 302);
            Controls.Add(button1);
            Controls.Add(btnGradeChecker);
            Controls.Add(btnStudentInfo);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudentInfo;
        private Button btnGradeChecker;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}