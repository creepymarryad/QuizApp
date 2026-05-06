namespace QuizApp
{
    partial class CreatorForm
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
            QuizNameTextBox = new TextBox();
            QuizTimeLimitNumericUpDown = new NumericUpDown();
            QuestionsListBox = new ListBox();
            AddQuestionBtn = new Button();
            RemoveQuestionBtn = new Button();
            SaveQuizBtn = new Button();
            ChangeQuestionBtn = new Button();
            LoadQuizBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)QuizTimeLimitNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // QuizNameTextBox
            // 
            QuizNameTextBox.Location = new Point(18, 70);
            QuizNameTextBox.Name = "QuizNameTextBox";
            QuizNameTextBox.Size = new Size(240, 27);
            QuizNameTextBox.TabIndex = 0;
            // 
            // QuizTimeLimitNumericUpDown
            // 
            QuizTimeLimitNumericUpDown.Location = new Point(891, 70);
            QuizTimeLimitNumericUpDown.Name = "QuizTimeLimitNumericUpDown";
            QuizTimeLimitNumericUpDown.Size = new Size(78, 27);
            QuizTimeLimitNumericUpDown.TabIndex = 1;
            // 
            // QuestionsListBox
            // 
            QuestionsListBox.FormattingEnabled = true;
            QuestionsListBox.Location = new Point(30, 226);
            QuestionsListBox.Name = "QuestionsListBox";
            QuestionsListBox.ScrollAlwaysVisible = true;
            QuestionsListBox.Size = new Size(951, 204);
            QuestionsListBox.TabIndex = 2;
            // 
            // AddQuestionBtn
            // 
            AddQuestionBtn.Location = new Point(354, 460);
            AddQuestionBtn.Name = "AddQuestionBtn";
            AddQuestionBtn.Size = new Size(300, 50);
            AddQuestionBtn.TabIndex = 3;
            AddQuestionBtn.Text = "Add question";
            AddQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveQuestionBtn
            // 
            RemoveQuestionBtn.Location = new Point(681, 460);
            RemoveQuestionBtn.Name = "RemoveQuestionBtn";
            RemoveQuestionBtn.Size = new Size(300, 50);
            RemoveQuestionBtn.TabIndex = 4;
            RemoveQuestionBtn.Text = "Delete question";
            RemoveQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // SaveQuizBtn
            // 
            SaveQuizBtn.Location = new Point(30, 29);
            SaveQuizBtn.Name = "SaveQuizBtn";
            SaveQuizBtn.Size = new Size(335, 55);
            SaveQuizBtn.TabIndex = 5;
            SaveQuizBtn.Text = "Save quiz";
            SaveQuizBtn.UseVisualStyleBackColor = true;
            // 
            // ChangeQuestionBtn
            // 
            ChangeQuestionBtn.Location = new Point(30, 460);
            ChangeQuestionBtn.Name = "ChangeQuestionBtn";
            ChangeQuestionBtn.Size = new Size(300, 50);
            ChangeQuestionBtn.TabIndex = 6;
            ChangeQuestionBtn.Text = "Change question";
            ChangeQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // LoadQuizBtn
            // 
            LoadQuizBtn.Location = new Point(646, 29);
            LoadQuizBtn.Name = "LoadQuizBtn";
            LoadQuizBtn.Size = new Size(335, 55);
            LoadQuizBtn.TabIndex = 7;
            LoadQuizBtn.Text = "Load quiz";
            LoadQuizBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 46);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Quiz title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(704, 46);
            label2.Name = "label2";
            label2.Size = new Size(265, 20);
            label2.TabIndex = 9;
            label2.Text = "Quiz time duration (provide in second)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(QuizNameTextBox);
            panel1.Controls.Add(QuizTimeLimitNumericUpDown);
            panel1.Location = new Point(12, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 438);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 46);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 11;
            label3.Text = "Quiz Creator";
            // 
            // CreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 553);
            Controls.Add(label3);
            Controls.Add(LoadQuizBtn);
            Controls.Add(ChangeQuestionBtn);
            Controls.Add(SaveQuizBtn);
            Controls.Add(RemoveQuestionBtn);
            Controls.Add(AddQuestionBtn);
            Controls.Add(QuestionsListBox);
            Controls.Add(panel1);
            Name = "CreatorForm";
            Text = "Quiz Creator";
            ((System.ComponentModel.ISupportInitialize)QuizTimeLimitNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QuizNameTextBox;
        private NumericUpDown QuizTimeLimitNumericUpDown;
        private ListBox QuestionsListBox;
        private Button AddQuestionBtn;
        private Button RemoveQuestionBtn;
        private Button SaveQuizBtn;
        private Button ChangeQuestionBtn;
        private Button LoadQuizBtn;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}
