namespace Creator.Views
{
    partial class AddQuestionForm
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
            QuestionTextBox = new TextBox();
            QuestionAnswer1TextBox = new TextBox();
            QuestionAnswer2TextBox = new TextBox();
            QuestionAnswer3TextBox = new TextBox();
            QuestionAnswer4TextBox = new TextBox();
            IsCorrectAnswer1CheckBox = new CheckBox();
            IsCorrectAnswer3CheckBox = new CheckBox();
            IsCorrectAnswer2CheckBox = new CheckBox();
            IsCorrectAnswer4CheckBox = new CheckBox();
            AddBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Location = new Point(195, 23);
            QuestionTextBox.Multiline = true;
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Size = new Size(421, 161);
            QuestionTextBox.TabIndex = 1;
            // 
            // QuestionAnswer1TextBox
            // 
            QuestionAnswer1TextBox.Location = new Point(71, 223);
            QuestionAnswer1TextBox.Name = "QuestionAnswer1TextBox";
            QuestionAnswer1TextBox.Size = new Size(239, 27);
            QuestionAnswer1TextBox.TabIndex = 2;
            // 
            // QuestionAnswer2TextBox
            // 
            QuestionAnswer2TextBox.Location = new Point(449, 223);
            QuestionAnswer2TextBox.Name = "QuestionAnswer2TextBox";
            QuestionAnswer2TextBox.Size = new Size(239, 27);
            QuestionAnswer2TextBox.TabIndex = 3;
            // 
            // QuestionAnswer3TextBox
            // 
            QuestionAnswer3TextBox.Location = new Point(71, 294);
            QuestionAnswer3TextBox.Name = "QuestionAnswer3TextBox";
            QuestionAnswer3TextBox.Size = new Size(239, 27);
            QuestionAnswer3TextBox.TabIndex = 4;
            // 
            // QuestionAnswer4TextBox
            // 
            QuestionAnswer4TextBox.Location = new Point(449, 294);
            QuestionAnswer4TextBox.Name = "QuestionAnswer4TextBox";
            QuestionAnswer4TextBox.Size = new Size(239, 27);
            QuestionAnswer4TextBox.TabIndex = 5;
            // 
            // IsCorrectAnswer1CheckBox
            // 
            IsCorrectAnswer1CheckBox.AutoSize = true;
            IsCorrectAnswer1CheckBox.Location = new Point(316, 229);
            IsCorrectAnswer1CheckBox.Name = "IsCorrectAnswer1CheckBox";
            IsCorrectAnswer1CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer1CheckBox.TabIndex = 6;
            IsCorrectAnswer1CheckBox.UseVisualStyleBackColor = true;
            // 
            // IsCorrectAnswer3CheckBox
            // 
            IsCorrectAnswer3CheckBox.AutoSize = true;
            IsCorrectAnswer3CheckBox.Location = new Point(316, 300);
            IsCorrectAnswer3CheckBox.Name = "IsCorrectAnswer3CheckBox";
            IsCorrectAnswer3CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer3CheckBox.TabIndex = 7;
            IsCorrectAnswer3CheckBox.UseVisualStyleBackColor = true;
            // 
            // IsCorrectAnswer2CheckBox
            // 
            IsCorrectAnswer2CheckBox.AutoSize = true;
            IsCorrectAnswer2CheckBox.Location = new Point(694, 229);
            IsCorrectAnswer2CheckBox.Name = "IsCorrectAnswer2CheckBox";
            IsCorrectAnswer2CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer2CheckBox.TabIndex = 8;
            IsCorrectAnswer2CheckBox.UseVisualStyleBackColor = true;
            // 
            // IsCorrectAnswer4CheckBox
            // 
            IsCorrectAnswer4CheckBox.AutoSize = true;
            IsCorrectAnswer4CheckBox.Location = new Point(694, 300);
            IsCorrectAnswer4CheckBox.Name = "IsCorrectAnswer4CheckBox";
            IsCorrectAnswer4CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer4CheckBox.TabIndex = 9;
            IsCorrectAnswer4CheckBox.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(195, 376);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(170, 29);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Dodaj";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(446, 376);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(170, 29);
            CancelBtn.TabIndex = 11;
            CancelBtn.Text = "Anuluj";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(IsCorrectAnswer4CheckBox);
            Controls.Add(IsCorrectAnswer2CheckBox);
            Controls.Add(IsCorrectAnswer3CheckBox);
            Controls.Add(IsCorrectAnswer1CheckBox);
            Controls.Add(QuestionAnswer4TextBox);
            Controls.Add(QuestionAnswer3TextBox);
            Controls.Add(QuestionAnswer2TextBox);
            Controls.Add(QuestionAnswer1TextBox);
            Controls.Add(QuestionTextBox);
            Name = "AddQuestionForm";
            Text = "Dodaj pytanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QuestionTextBox;
        private TextBox QuestionAnswer1TextBox;
        private TextBox QuestionAnswer2TextBox;
        private TextBox QuestionAnswer3TextBox;
        private TextBox QuestionAnswer4TextBox;
        private CheckBox IsCorrectAnswer1CheckBox;
        private CheckBox IsCorrectAnswer3CheckBox;
        private CheckBox IsCorrectAnswer2CheckBox;
        private CheckBox IsCorrectAnswer4CheckBox;
        private Button AddBtn;
        private Button CancelBtn;
    }
}