namespace samostRab_Option_25_ShamilovaHayala
{
    partial class Form1
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
            this.LevelNumberAndTaskLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.BinaryNumberLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.OctalNumberTextBox = new System.Windows.Forms.TextBox();
            this.HexNumberTextBox = new System.Windows.Forms.TextBox();
            this.OctalNumberLabel = new System.Windows.Forms.Label();
            this.HexNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.NextLevelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelNumberAndTaskLabel
            // 
            this.LevelNumberAndTaskLabel.AutoSize = true;
            this.LevelNumberAndTaskLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelNumberAndTaskLabel.Location = new System.Drawing.Point(33, 9);
            this.LevelNumberAndTaskLabel.Name = "LevelNumberAndTaskLabel";
            this.LevelNumberAndTaskLabel.Size = new System.Drawing.Size(429, 34);
            this.LevelNumberAndTaskLabel.TabIndex = 0;
            this.LevelNumberAndTaskLabel.Text = "ЗАДАНИЕ: ПЕРЕВЕДИТЕ ЧИСЛО ИЗ 2-ОЙ СИСТЕМЫ \r\nСЧИСЛЕНИЯ В 8-УЮ И 16-УЮ\r\n";
            this.LevelNumberAndTaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CheckButton.Location = new System.Drawing.Point(111, 285);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(260, 34);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Перейти к результатам";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Visible = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // BinaryNumberLabel
            // 
            this.BinaryNumberLabel.AutoSize = true;
            this.BinaryNumberLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryNumberLabel.Location = new System.Drawing.Point(84, 78);
            this.BinaryNumberLabel.Name = "BinaryNumberLabel";
            this.BinaryNumberLabel.Size = new System.Drawing.Size(54, 22);
            this.BinaryNumberLabel.TabIndex = 3;
            this.BinaryNumberLabel.Text = "label2";
            this.BinaryNumberLabel.Visible = false;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.Location = new System.Drawing.Point(12, 78);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(61, 22);
            this.NumberLabel.TabIndex = 4;
            this.NumberLabel.Text = "Число";
            this.NumberLabel.Visible = false;
            // 
            // OctalNumberTextBox
            // 
            this.OctalNumberTextBox.Location = new System.Drawing.Point(154, 115);
            this.OctalNumberTextBox.Multiline = true;
            this.OctalNumberTextBox.Name = "OctalNumberTextBox";
            this.OctalNumberTextBox.Size = new System.Drawing.Size(290, 22);
            this.OctalNumberTextBox.TabIndex = 5;
            this.OctalNumberTextBox.Visible = false;
            this.OctalNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OctalNumberTextBox_KeyPress);
            // 
            // HexNumberTextBox
            // 
            this.HexNumberTextBox.Location = new System.Drawing.Point(154, 170);
            this.HexNumberTextBox.Multiline = true;
            this.HexNumberTextBox.Name = "HexNumberTextBox";
            this.HexNumberTextBox.Size = new System.Drawing.Size(290, 22);
            this.HexNumberTextBox.TabIndex = 6;
            this.HexNumberTextBox.Visible = false;
            this.HexNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexNumberTextBox_KeyPress);
            // 
            // OctalNumberLabel
            // 
            this.OctalNumberLabel.AutoSize = true;
            this.OctalNumberLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OctalNumberLabel.Location = new System.Drawing.Point(12, 115);
            this.OctalNumberLabel.Name = "OctalNumberLabel";
            this.OctalNumberLabel.Size = new System.Drawing.Size(119, 22);
            this.OctalNumberLabel.TabIndex = 3;
            this.OctalNumberLabel.Text = "в 8-ой сс = ";
            this.OctalNumberLabel.Visible = false;
            // 
            // HexNumberLabel
            // 
            this.HexNumberLabel.AutoSize = true;
            this.HexNumberLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexNumberLabel.Location = new System.Drawing.Point(12, 168);
            this.HexNumberLabel.Name = "HexNumberLabel";
            this.HexNumberLabel.Size = new System.Drawing.Size(126, 22);
            this.HexNumberLabel.TabIndex = 3;
            this.HexNumberLabel.Text = "в 16-ой сс = ";
            this.HexNumberLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.LevelNumberAndTaskLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 75);
            this.panel1.TabIndex = 7;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ExitButton.Location = new System.Drawing.Point(111, 245);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(260, 34);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.StartButton.Location = new System.Drawing.Point(111, 205);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(260, 34);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NextLevelButton
            // 
            this.NextLevelButton.BackColor = System.Drawing.Color.Transparent;
            this.NextLevelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextLevelButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLevelButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NextLevelButton.Location = new System.Drawing.Point(111, 205);
            this.NextLevelButton.Name = "NextLevelButton";
            this.NextLevelButton.Size = new System.Drawing.Size(260, 34);
            this.NextLevelButton.TabIndex = 1;
            this.NextLevelButton.Text = "Следующий уровень";
            this.NextLevelButton.UseVisualStyleBackColor = false;
            this.NextLevelButton.Visible = false;
            this.NextLevelButton.Click += new System.EventHandler(this.NextLevelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(496, 334);
            this.Controls.Add(this.HexNumberTextBox);
            this.Controls.Add(this.OctalNumberTextBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.HexNumberLabel);
            this.Controls.Add(this.OctalNumberLabel);
            this.Controls.Add(this.BinaryNumberLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NextLevelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучение системам счисления";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LevelNumberAndTaskLabel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label BinaryNumberLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox OctalNumberTextBox;
        private System.Windows.Forms.TextBox HexNumberTextBox;
        private System.Windows.Forms.Label OctalNumberLabel;
        private System.Windows.Forms.Label HexNumberLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button NextLevelButton;
    }
}

