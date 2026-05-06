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
            panel2 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)QuizTimeLimitNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // QuizNameTextBox
            // 
            QuizNameTextBox.BackColor = Color.DimGray;
            QuizNameTextBox.BorderStyle = BorderStyle.None;
            QuizNameTextBox.Dock = DockStyle.Fill;
            QuizNameTextBox.ForeColor = Color.White;
            QuizNameTextBox.Location = new Point(0, 0);
            QuizNameTextBox.Name = "QuizNameTextBox";
            QuizNameTextBox.Size = new Size(309, 20);
            QuizNameTextBox.TabIndex = 0;
            // 
            // QuizTimeLimitNumericUpDown
            // 
            QuizTimeLimitNumericUpDown.BackColor = Color.DimGray;
            QuizTimeLimitNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            QuizTimeLimitNumericUpDown.ForeColor = Color.White;
            QuizTimeLimitNumericUpDown.Location = new Point(871, 70);
            QuizTimeLimitNumericUpDown.Name = "QuizTimeLimitNumericUpDown";
            QuizTimeLimitNumericUpDown.Size = new Size(98, 27);
            QuizTimeLimitNumericUpDown.TabIndex = 1;
            // 
            // QuestionsListBox
            // 
            QuestionsListBox.BackColor = Color.DimGray;
            QuestionsListBox.ForeColor = Color.White;
            QuestionsListBox.FormattingEnabled = true;
            QuestionsListBox.Location = new Point(30, 226);
            QuestionsListBox.Name = "QuestionsListBox";
            QuestionsListBox.ScrollAlwaysVisible = true;
            QuestionsListBox.Size = new Size(951, 184);
            QuestionsListBox.TabIndex = 2;
            // 
            // AddQuestionBtn
            // 
            AddQuestionBtn.Cursor = Cursors.Hand;
            AddQuestionBtn.FlatAppearance.BorderSize = 0;
            AddQuestionBtn.FlatStyle = FlatStyle.Flat;
            AddQuestionBtn.ForeColor = Color.White;
            AddQuestionBtn.Location = new Point(18, 357);
            AddQuestionBtn.Name = "AddQuestionBtn";
            AddQuestionBtn.Padding = new Padding(0, 0, 0, 5);
            AddQuestionBtn.Size = new Size(300, 55);
            AddQuestionBtn.TabIndex = 3;
            AddQuestionBtn.Text = "Add question";
            AddQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveQuestionBtn
            // 
            RemoveQuestionBtn.Cursor = Cursors.Hand;
            RemoveQuestionBtn.FlatAppearance.BorderSize = 0;
            RemoveQuestionBtn.FlatStyle = FlatStyle.Flat;
            RemoveQuestionBtn.ForeColor = Color.White;
            RemoveQuestionBtn.Location = new Point(681, 460);
            RemoveQuestionBtn.Name = "RemoveQuestionBtn";
            RemoveQuestionBtn.Padding = new Padding(0, 0, 0, 5);
            RemoveQuestionBtn.Size = new Size(300, 55);
            RemoveQuestionBtn.TabIndex = 4;
            RemoveQuestionBtn.Text = "Delete question";
            RemoveQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // SaveQuizBtn
            // 
            SaveQuizBtn.Cursor = Cursors.Hand;
            SaveQuizBtn.FlatAppearance.BorderSize = 0;
            SaveQuizBtn.FlatStyle = FlatStyle.Flat;
            SaveQuizBtn.ForeColor = Color.White;
            SaveQuizBtn.Location = new Point(30, 26);
            SaveQuizBtn.Name = "SaveQuizBtn";
            SaveQuizBtn.Padding = new Padding(0, 0, 0, 5);
            SaveQuizBtn.Size = new Size(335, 60);
            SaveQuizBtn.TabIndex = 5;
            SaveQuizBtn.Text = "Save quiz";
            SaveQuizBtn.UseVisualStyleBackColor = true;
            // 
            // ChangeQuestionBtn
            // 
            ChangeQuestionBtn.Cursor = Cursors.Hand;
            ChangeQuestionBtn.FlatAppearance.BorderSize = 0;
            ChangeQuestionBtn.FlatStyle = FlatStyle.Flat;
            ChangeQuestionBtn.ForeColor = Color.White;
            ChangeQuestionBtn.Location = new Point(344, 357);
            ChangeQuestionBtn.Name = "ChangeQuestionBtn";
            ChangeQuestionBtn.Padding = new Padding(0, 0, 0, 5);
            ChangeQuestionBtn.Size = new Size(300, 55);
            ChangeQuestionBtn.TabIndex = 6;
            ChangeQuestionBtn.Text = "Modify question";
            ChangeQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // LoadQuizBtn
            // 
            LoadQuizBtn.Cursor = Cursors.Hand;
            LoadQuizBtn.FlatAppearance.BorderSize = 0;
            LoadQuizBtn.FlatStyle = FlatStyle.Flat;
            LoadQuizBtn.ForeColor = Color.White;
            LoadQuizBtn.Location = new Point(646, 26);
            LoadQuizBtn.Name = "LoadQuizBtn";
            LoadQuizBtn.Padding = new Padding(0, 0, 0, 5);
            LoadQuizBtn.Size = new Size(335, 60);
            LoadQuizBtn.TabIndex = 7;
            LoadQuizBtn.Text = "Load quiz";
            LoadQuizBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 85);
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Quiz title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 85);
            label2.Location = new Point(511, 36);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 9;
            label2.Text = "Quiz time duration (seconds)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ChangeQuestionBtn);
            panel1.Controls.Add(AddQuestionBtn);
            panel1.Controls.Add(QuizTimeLimitNumericUpDown);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 438);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(QuizNameTextBox);
            panel2.Location = new Point(18, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 38);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(387, 22);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "Creator";
            // 
            // CreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 553);
            Controls.Add(label3);
            Controls.Add(LoadQuizBtn);
            Controls.Add(SaveQuizBtn);
            Controls.Add(RemoveQuestionBtn);
            Controls.Add(QuestionsListBox);
            Controls.Add(panel1);
            Name = "CreatorForm";
            Text = "Quiz Creator";
            ((System.ComponentModel.ISupportInitialize)QuizTimeLimitNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
    }
}
