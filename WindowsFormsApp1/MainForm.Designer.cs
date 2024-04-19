
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
            this.newUserButton = new Project2MovieMate.RoundedButton();
            this.enterButton = new Project2MovieMate.RoundedButton();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // newUserButton
            // 
            this.newUserButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newUserButton.Location = new System.Drawing.Point(508, 383);
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
            this.enterButton.Location = new System.Drawing.Point(508, 310);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(271, 188);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.enterButton);
            this.Name = "MainForm";
            this.Text = "MovieMate";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Project2MovieMate.RoundedButton enterButton;
        private Project2MovieMate.RoundedButton newUserButton;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

