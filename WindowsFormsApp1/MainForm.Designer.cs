
namespace WindowsFormsApp1
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.newUserButton = new Project2MovieMate.RoundedButton();
            this.enterButton = new Project2MovieMate.RoundedButton();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(508, 179);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(206, 24);
            this.usersComboBox.TabIndex = 2;
            // 
            // newUserButton
            // 
            this.newUserButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newUserButton.Location = new System.Drawing.Point(508, 344);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(206, 67);
            this.newUserButton.TabIndex = 4;
            this.newUserButton.Text = "Новый Пользователь";
            this.newUserButton.UseVisualStyleBackColor = false;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterButton.Location = new System.Drawing.Point(508, 254);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(206, 67);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NicknameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NicknameLabel.Location = new System.Drawing.Point(393, 44);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(296, 69);
            this.NicknameLabel.TabIndex = 5;
            this.NicknameLabel.Text = "Nickname";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.usersComboBox);
            this.Name = "MainForm";
            this.Text = "MovieMate";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox usersComboBox;
        private Project2MovieMate.RoundedButton enterButton;
        private Project2MovieMate.RoundedButton newUserButton;
        private System.Windows.Forms.Label NicknameLabel;
    }
}

