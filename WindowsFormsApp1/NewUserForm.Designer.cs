
namespace Project2MovieMate
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.secondEnterButton = new Project2MovieMate.RoundedButton();
            this.pandaCheckBox = new System.Windows.Forms.CheckBox();
            this.ForsazhCheckBox = new System.Windows.Forms.CheckBox();
            this.treescheckBox = new System.Windows.Forms.CheckBox();
            this.avengersCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // secondEnterButton
            // 
            this.secondEnterButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondEnterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondEnterButton.Location = new System.Drawing.Point(119, 404);
            this.secondEnterButton.Name = "secondEnterButton";
            this.secondEnterButton.Size = new System.Drawing.Size(151, 58);
            this.secondEnterButton.TabIndex = 0;
            this.secondEnterButton.Text = "Войти";
            this.secondEnterButton.UseVisualStyleBackColor = false;
            // 
            // pandaCheckBox
            // 
            this.pandaCheckBox.AutoSize = true;
            this.pandaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pandaCheckBox.Location = new System.Drawing.Point(44, 257);
            this.pandaCheckBox.Name = "pandaCheckBox";
            this.pandaCheckBox.Size = new System.Drawing.Size(168, 24);
            this.pandaCheckBox.TabIndex = 1;
            this.pandaCheckBox.Text = "Кунг-фу панда";
            this.pandaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ForsazhCheckBox
            // 
            this.ForsazhCheckBox.AutoSize = true;
            this.ForsazhCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForsazhCheckBox.Location = new System.Drawing.Point(44, 284);
            this.ForsazhCheckBox.Name = "ForsazhCheckBox";
            this.ForsazhCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ForsazhCheckBox.TabIndex = 2;
            this.ForsazhCheckBox.Text = "Форсаж";
            this.ForsazhCheckBox.UseVisualStyleBackColor = true;
            // 
            // treescheckBox
            // 
            this.treescheckBox.AutoSize = true;
            this.treescheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treescheckBox.Location = new System.Drawing.Point(44, 311);
            this.treescheckBox.Name = "treescheckBox";
            this.treescheckBox.Size = new System.Drawing.Size(76, 24);
            this.treescheckBox.TabIndex = 3;
            this.treescheckBox.Text = "Ёлки";
            this.treescheckBox.UseVisualStyleBackColor = true;
            // 
            // avengersCheckBox
            // 
            this.avengersCheckBox.AutoSize = true;
            this.avengersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avengersCheckBox.Location = new System.Drawing.Point(44, 338);
            this.avengersCheckBox.Name = "avengersCheckBox";
            this.avengersCheckBox.Size = new System.Drawing.Size(122, 24);
            this.avengersCheckBox.TabIndex = 4;
            this.avengersCheckBox.Text = "Мстители";
            this.avengersCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.avengersCheckBox);
            this.Controls.Add(this.treescheckBox);
            this.Controls.Add(this.ForsazhCheckBox);
            this.Controls.Add(this.pandaCheckBox);
            this.Controls.Add(this.secondEnterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUserForm";
            this.Text = "MovieMate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton secondEnterButton;
        private System.Windows.Forms.CheckBox pandaCheckBox;
        private System.Windows.Forms.CheckBox ForsazhCheckBox;
        private System.Windows.Forms.CheckBox treescheckBox;
        private System.Windows.Forms.CheckBox avengersCheckBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}