
namespace ConnectToDataBase
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(285, 201);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(186, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(220, 205);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(46, 16);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(285, 241);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(186, 20);
            this.tbPass.TabIndex = 2;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(190, 245);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(76, 16);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLogin.Location = new System.Drawing.Point(331, 296);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(88, 27);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Enter";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbLogin);
            this.Name = "Form1";
            this.Text = "ConnectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btLogin;
    }
}

