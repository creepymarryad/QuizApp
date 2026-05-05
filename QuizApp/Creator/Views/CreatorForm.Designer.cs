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
            ((System.ComponentModel.ISupportInitialize)QuizTimeLimitNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // QuizNameTextBox
            // 
            QuizNameTextBox.Location = new Point(65, 39);
            QuizNameTextBox.Name = "QuizNameTextBox";
            QuizNameTextBox.Size = new Size(239, 27);
            QuizNameTextBox.TabIndex = 0;
            // 
            // QuizTimeLimitNumericUpDown
            // 
            QuizTimeLimitNumericUpDown.Location = new Point(400, 40);
            QuizTimeLimitNumericUpDown.Name = "QuizTimeLimitNumericUpDown";
            QuizTimeLimitNumericUpDown.Size = new Size(78, 27);
            QuizTimeLimitNumericUpDown.TabIndex = 1;
            // 
            // QuestionsListBox
            // 
            QuestionsListBox.FormattingEnabled = true;
            QuestionsListBox.Location = new Point(65, 120);
            QuestionsListBox.Name = "QuestionsListBox";
            QuestionsListBox.ScrollAlwaysVisible = true;
            QuestionsListBox.Size = new Size(674, 204);
            QuestionsListBox.TabIndex = 2;
            // 
            // AddQuestionBtn
            // 
            AddQuestionBtn.Location = new Point(65, 382);
            AddQuestionBtn.Name = "AddQuestionBtn";
            AddQuestionBtn.Size = new Size(170, 29);
            AddQuestionBtn.TabIndex = 3;
            AddQuestionBtn.Text = "Add question";
            AddQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveQuestionBtn
            // 
            RemoveQuestionBtn.Location = new Point(590, 382);
            RemoveQuestionBtn.Name = "RemoveQuestionBtn";
            RemoveQuestionBtn.Size = new Size(149, 29);
            RemoveQuestionBtn.TabIndex = 4;
            RemoveQuestionBtn.Text = "Delete question";
            RemoveQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // SaveQuizBtn
            // 
            SaveQuizBtn.Location = new Point(573, 38);
            SaveQuizBtn.Name = "SaveQuizBtn";
            SaveQuizBtn.Size = new Size(166, 29);
            SaveQuizBtn.TabIndex = 5;
            SaveQuizBtn.Text = "Save quiz";
            SaveQuizBtn.UseVisualStyleBackColor = true;
            // 
            // ChangeQuestionBtn
            // 
            ChangeQuestionBtn.Location = new Point(340, 382);
            ChangeQuestionBtn.Name = "ChangeQuestionBtn";
            ChangeQuestionBtn.Size = new Size(149, 29);
            ChangeQuestionBtn.TabIndex = 6;
            ChangeQuestionBtn.Text = "Change question";
            ChangeQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // CreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangeQuestionBtn);
            Controls.Add(SaveQuizBtn);
            Controls.Add(RemoveQuestionBtn);
            Controls.Add(AddQuestionBtn);
            Controls.Add(QuestionsListBox);
            Controls.Add(QuizTimeLimitNumericUpDown);
            Controls.Add(QuizNameTextBox);
            Name = "CreatorForm";
            Text = "Quiz Creator";
            ((System.ComponentModel.ISupportInitialize)QuizTimeLimitNumericUpDown).EndInit();
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
    }
}
