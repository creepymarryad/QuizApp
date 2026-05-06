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
            AddBtn = new Button();
            CancelBtn = new Button();
            panel2 = new Panel();
            QuestionAnswer4TextBox = new TextBox();
            QuestionAnswer2TextBox = new TextBox();
            QuestionAnswer1TextBox = new TextBox();
            QuestionAnswer3TextBox = new TextBox();
            IsCorrectAnswer1CheckBox = new CheckBox();
            IsCorrectAnswer3CheckBox = new CheckBox();
            QuestionTextBox = new TextBox();
            IsCorrectAnswer2CheckBox = new CheckBox();
            IsCorrectAnswer4CheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(58, 491);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(335, 55);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Save";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(451, 491);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(355, 55);
            CancelBtn.TabIndex = 11;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(QuestionAnswer1TextBox);
            panel2.Controls.Add(IsCorrectAnswer1CheckBox);
            panel2.Location = new Point(65, 274);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 30, 0);
            panel2.Size = new Size(320, 50);
            panel2.TabIndex = 14;
            // 
            // QuestionAnswer4TextBox
            // 
            QuestionAnswer4TextBox.Location = new Point(443, 370);
            QuestionAnswer4TextBox.Multiline = true;
            QuestionAnswer4TextBox.Name = "QuestionAnswer4TextBox";
            QuestionAnswer4TextBox.Size = new Size(320, 50);
            QuestionAnswer4TextBox.TabIndex = 5;
            // 
            // QuestionAnswer2TextBox
            // 
            QuestionAnswer2TextBox.Location = new Point(443, 274);
            QuestionAnswer2TextBox.Multiline = true;
            QuestionAnswer2TextBox.Name = "QuestionAnswer2TextBox";
            QuestionAnswer2TextBox.Size = new Size(320, 50);
            QuestionAnswer2TextBox.TabIndex = 3;
            // 
            // QuestionAnswer1TextBox
            // 
            QuestionAnswer1TextBox.BorderStyle = BorderStyle.None;
            QuestionAnswer1TextBox.Dock = DockStyle.Fill;
            QuestionAnswer1TextBox.Location = new Point(0, 0);
            QuestionAnswer1TextBox.Multiline = true;
            QuestionAnswer1TextBox.Name = "QuestionAnswer1TextBox";
            QuestionAnswer1TextBox.Size = new Size(286, 46);
            QuestionAnswer1TextBox.TabIndex = 2;
            // 
            // QuestionAnswer3TextBox
            // 
            QuestionAnswer3TextBox.Location = new Point(65, 370);
            QuestionAnswer3TextBox.Multiline = true;
            QuestionAnswer3TextBox.Name = "QuestionAnswer3TextBox";
            QuestionAnswer3TextBox.Size = new Size(320, 50);
            QuestionAnswer3TextBox.TabIndex = 4;
            // 
            // IsCorrectAnswer1CheckBox
            // 
            IsCorrectAnswer1CheckBox.AutoSize = true;
            IsCorrectAnswer1CheckBox.Location = new Point(290, 15);
            IsCorrectAnswer1CheckBox.Name = "IsCorrectAnswer1CheckBox";
            IsCorrectAnswer1CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer1CheckBox.TabIndex = 6;
            IsCorrectAnswer1CheckBox.UseVisualStyleBackColor = true;
            // 
            // IsCorrectAnswer3CheckBox
            // 
            IsCorrectAnswer3CheckBox.AutoSize = true;
            IsCorrectAnswer3CheckBox.Location = new Point(357, 388);
            IsCorrectAnswer3CheckBox.Name = "IsCorrectAnswer3CheckBox";
            IsCorrectAnswer3CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer3CheckBox.TabIndex = 7;
            IsCorrectAnswer3CheckBox.UseVisualStyleBackColor = true;
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Location = new Point(65, 56);
            QuestionTextBox.Multiline = true;
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.ScrollBars = ScrollBars.Vertical;
            QuestionTextBox.Size = new Size(698, 161);
            QuestionTextBox.TabIndex = 1;
            // 
            // IsCorrectAnswer2CheckBox
            // 
            IsCorrectAnswer2CheckBox.AutoSize = true;
            IsCorrectAnswer2CheckBox.Location = new Point(734, 291);
            IsCorrectAnswer2CheckBox.Name = "IsCorrectAnswer2CheckBox";
            IsCorrectAnswer2CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer2CheckBox.TabIndex = 8;
            IsCorrectAnswer2CheckBox.UseVisualStyleBackColor = true;
            // 
            // IsCorrectAnswer4CheckBox
            // 
            IsCorrectAnswer4CheckBox.AutoSize = true;
            IsCorrectAnswer4CheckBox.Location = new Point(734, 388);
            IsCorrectAnswer4CheckBox.Name = "IsCorrectAnswer4CheckBox";
            IsCorrectAnswer4CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer4CheckBox.TabIndex = 9;
            IsCorrectAnswer4CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 251);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 10;
            label1.Text = "Answer 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 251);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 11;
            label2.Text = "Answer 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 347);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 12;
            label3.Text = "Answer 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 347);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 13;
            label4.Text = "Answer 4";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(IsCorrectAnswer4CheckBox);
            panel1.Controls.Add(IsCorrectAnswer2CheckBox);
            panel1.Controls.Add(QuestionTextBox);
            panel1.Controls.Add(IsCorrectAnswer3CheckBox);
            panel1.Controls.Add(QuestionAnswer3TextBox);
            panel1.Controls.Add(QuestionAnswer2TextBox);
            panel1.Controls.Add(QuestionAnswer4TextBox);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 449);
            panel1.TabIndex = 12;
            // 
            // AddQuestionForm
            // 
            AcceptButton = AddBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(846, 574);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(panel1);
            Name = "AddQuestionForm";
            Text = "Add Question";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button AddBtn;
        private Button CancelBtn;
        private Panel panel2;
        private TextBox QuestionAnswer1TextBox;
        private CheckBox IsCorrectAnswer1CheckBox;
        private TextBox QuestionAnswer4TextBox;
        private TextBox QuestionAnswer2TextBox;
        private TextBox QuestionAnswer3TextBox;
        private CheckBox IsCorrectAnswer3CheckBox;
        private TextBox QuestionTextBox;
        private CheckBox IsCorrectAnswer2CheckBox;
        private CheckBox IsCorrectAnswer4CheckBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}