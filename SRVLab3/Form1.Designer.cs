namespace SRVLab3
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
            this.lbFromImage = new System.Windows.Forms.ListBox();
            this.tbToConsole = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblTextToConsole = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFromImage
            // 
            this.lbFromImage.FormattingEnabled = true;
            this.lbFromImage.Location = new System.Drawing.Point(12, 111);
            this.lbFromImage.Name = "lbFromImage";
            this.lbFromImage.Size = new System.Drawing.Size(595, 212);
            this.lbFromImage.TabIndex = 0;
            // 
            // tbToConsole
            // 
            this.tbToConsole.Location = new System.Drawing.Point(54, 29);
            this.tbToConsole.Name = "tbToConsole";
            this.tbToConsole.Size = new System.Drawing.Size(198, 20);
            this.tbToConsole.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(345, 55);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(91, 24);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Запуск";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(345, 29);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(198, 20);
            this.tbCommand.TabIndex = 3;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(412, 9);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(71, 13);
            this.lblCommand.TabIndex = 4;
            this.lblCommand.Text = "Приложение";
            // 
            // lblTextToConsole
            // 
            this.lblTextToConsole.AutoSize = true;
            this.lblTextToConsole.Location = new System.Drawing.Point(51, 8);
            this.lblTextToConsole.Name = "lblTextToConsole";
            this.lblTextToConsole.Size = new System.Drawing.Size(115, 13);
            this.lblTextToConsole.TabIndex = 5;
            this.lblTextToConsole.Text = "Сообщение(команда)";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(54, 54);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(79, 25);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Отправка";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 335);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblTextToConsole);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbToConsole);
            this.Controls.Add(this.lbFromImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFromImage;
        private System.Windows.Forms.TextBox tbToConsole;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblTextToConsole;
        private System.Windows.Forms.Button btnSend;
    }
}

