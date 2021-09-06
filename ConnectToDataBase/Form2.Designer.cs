
namespace ConnectToDataBase
{
    partial class Form2
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
            this.lbDB = new System.Windows.Forms.ListBox();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.lbDataBase = new System.Windows.Forms.Label();
            this.btTables = new System.Windows.Forms.Button();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDB
            // 
            this.lbDB.FormattingEnabled = true;
            this.lbDB.Location = new System.Drawing.Point(2, 3);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(800, 199);
            this.lbDB.TabIndex = 0;
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(273, 208);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(196, 20);
            this.tbDB.TabIndex = 1;
            // 
            // lbDataBase
            // 
            this.lbDataBase.AutoSize = true;
            this.lbDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDataBase.Location = new System.Drawing.Point(72, 210);
            this.lbDataBase.Name = "lbDataBase";
            this.lbDataBase.Size = new System.Drawing.Size(172, 18);
            this.lbDataBase.TabIndex = 2;
            this.lbDataBase.Text = "Enter DataBase name";
            // 
            // btTables
            // 
            this.btTables.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTables.Location = new System.Drawing.Point(494, 205);
            this.btTables.Name = "btTables";
            this.btTables.Size = new System.Drawing.Size(108, 30);
            this.btTables.TabIndex = 3;
            this.btTables.Text = "Show Tables";
            this.btTables.UseVisualStyleBackColor = false;
            this.btTables.Click += new System.EventHandler(this.btTables_Click);
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(2, 243);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(800, 199);
            this.lbTables.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.btTables);
            this.Controls.Add(this.lbDataBase);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.lbDB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDB;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label lbDataBase;
        private System.Windows.Forms.Button btTables;
        private System.Windows.Forms.ListBox lbTables;
    }
}