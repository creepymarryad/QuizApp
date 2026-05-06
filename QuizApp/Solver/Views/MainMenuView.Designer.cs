namespace Solver.Views
{
    partial class MainMenuView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Title = new Label();
            label_FileSelect = new Label();
            label_Password = new Label();
            textBox_Password = new TextBox();
            button_SelectFile = new Button();
            panel_QuizInfo = new Panel();
            button_Start = new Button();
            label_QuizMaxScore = new Label();
            label_QuizQuestions = new Label();
            label_QuizTime = new Label();
            label_QuizTitle = new Label();
            panel_QuizInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(462, 50);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(467, 96);
            label_Title.TabIndex = 0;
            label_Title.Text = "Quiz Solver!";
            // 
            // label_FileSelect
            // 
            label_FileSelect.AutoSize = true;
            label_FileSelect.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_FileSelect.Location = new Point(296, 203);
            label_FileSelect.Name = "label_FileSelect";
            label_FileSelect.Size = new Size(273, 48);
            label_FileSelect.TabIndex = 1;
            label_FileSelect.Text = "Select quiz file:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Password.Location = new Point(339, 280);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(288, 48);
            label_Password.TabIndex = 2;
            label_Password.Text = "Enter password:";
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password.Location = new Point(724, 280);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(281, 45);
            textBox_Password.TabIndex = 8;
            // 
            // button_SelectFile
            // 
            button_SelectFile.Location = new Point(724, 203);
            button_SelectFile.Name = "button_SelectFile";
            button_SelectFile.Size = new Size(281, 48);
            button_SelectFile.TabIndex = 9;
            button_SelectFile.Text = "Select...";
            button_SelectFile.UseVisualStyleBackColor = true;
            button_SelectFile.Click += btnLoad_Click;
            // 
            // panel_QuizInfo
            // 
            panel_QuizInfo.Controls.Add(button_Start);
            panel_QuizInfo.Controls.Add(label_QuizMaxScore);
            panel_QuizInfo.Controls.Add(label_QuizQuestions);
            panel_QuizInfo.Controls.Add(label_QuizTime);
            panel_QuizInfo.Controls.Add(label_QuizTitle);
            panel_QuizInfo.Location = new Point(0, 377);
            panel_QuizInfo.Name = "panel_QuizInfo";
            panel_QuizInfo.Size = new Size(1420, 574);
            panel_QuizInfo.TabIndex = 10;
            panel_QuizInfo.Visible = false;
            // 
            // button_Start
            // 
            button_Start.Enabled = false;
            button_Start.Location = new Point(568, 380);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(279, 63);
            button_Start.TabIndex = 12;
            button_Start.Text = "START QUIZ!";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += btnStart_Click;
            // 
            // label_QuizMaxScore
            // 
            label_QuizMaxScore.AutoSize = true;
            label_QuizMaxScore.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuizMaxScore.Location = new Point(991, 245);
            label_QuizMaxScore.Name = "label_QuizMaxScore";
            label_QuizMaxScore.Size = new Size(187, 45);
            label_QuizMaxScore.TabIndex = 11;
            label_QuizMaxScore.Text = "Max Score:";
            // 
            // label_QuizQuestions
            // 
            label_QuizQuestions.AutoSize = true;
            label_QuizQuestions.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuizQuestions.Location = new Point(605, 245);
            label_QuizQuestions.Name = "label_QuizQuestions";
            label_QuizQuestions.Size = new Size(186, 45);
            label_QuizQuestions.TabIndex = 10;
            label_QuizQuestions.Text = "Questions: ";
            // 
            // label_QuizTime
            // 
            label_QuizTime.AutoSize = true;
            label_QuizTime.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuizTime.Location = new Point(218, 245);
            label_QuizTime.Name = "label_QuizTime";
            label_QuizTime.Size = new Size(103, 45);
            label_QuizTime.TabIndex = 9;
            label_QuizTime.Text = "Time:";
            // 
            // label_QuizTitle
            // 
            label_QuizTitle.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuizTitle.Location = new Point(0, 131);
            label_QuizTitle.Name = "label_QuizTitle";
            label_QuizTitle.Size = new Size(1420, 74);
            label_QuizTitle.TabIndex = 8;
            label_QuizTitle.Text = "QuizTitle";
            label_QuizTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_SelectFile);
            Controls.Add(textBox_Password);
            Controls.Add(label_Password);
            Controls.Add(label_FileSelect);
            Controls.Add(label_Title);
            Controls.Add(panel_QuizInfo);
            Name = "MainMenuView";
            Size = new Size(1420, 951);
            panel_QuizInfo.ResumeLayout(false);
            panel_QuizInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Title;
        private Label label_FileSelect;
        private Label label_Password;
        private TextBox textBox_Password;
        private Button button_SelectFile;
        private Panel panel_QuizInfo;
        private Button button_Start;
        private Label label_QuizMaxScore;
        private Label label_QuizQuestions;
        private Label label_QuizTime;
        private Label label_QuizTitle;
    }
}
