namespace OKO
{
    partial class Info
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
            this.FIOe = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.Label();
            this.Arte = new System.Windows.Forms.PictureBox();
            this.Del = new System.Windows.Forms.Button();
            this.Workse = new System.Windows.Forms.ComboBox();
            this.Art = new System.Windows.Forms.Label();
            this.Ide = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Works = new System.Windows.Forms.Label();
            this.Upd = new System.Windows.Forms.Button();
            this.Agee = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.InfoA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Arte)).BeginInit();
            this.SuspendLayout();
            // 
            // FIOe
            // 
            this.FIOe.BackColor = System.Drawing.Color.White;
            this.FIOe.Location = new System.Drawing.Point(167, 166);
            this.FIOe.Margin = new System.Windows.Forms.Padding(4);
            this.FIOe.Name = "FIOe";
            this.FIOe.Size = new System.Drawing.Size(326, 22);
            this.FIOe.TabIndex = 34;
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FIO.Location = new System.Drawing.Point(75, 158);
            this.FIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(76, 33);
            this.FIO.TabIndex = 33;
            this.FIO.Text = "ФИО";
            // 
            // Arte
            // 
            this.Arte.BackColor = System.Drawing.SystemColors.Window;
            this.Arte.Location = new System.Drawing.Point(534, 129);
            this.Arte.Name = "Arte";
            this.Arte.Size = new System.Drawing.Size(282, 299);
            this.Arte.TabIndex = 32;
            this.Arte.TabStop = false;
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.White;
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Del.Location = new System.Drawing.Point(302, 390);
            this.Del.Margin = new System.Windows.Forms.Padding(4);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(175, 38);
            this.Del.TabIndex = 31;
            this.Del.Text = "Уволить";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Workse
            // 
            this.Workse.FormattingEnabled = true;
            this.Workse.Items.AddRange(new object[] {
            "Тестировщик",
            "Кодер",
            "Дизайнер"});
            this.Workse.Location = new System.Drawing.Point(167, 248);
            this.Workse.Name = "Workse";
            this.Workse.Size = new System.Drawing.Size(179, 24);
            this.Workse.TabIndex = 30;
            // 
            // Art
            // 
            this.Art.AutoSize = true;
            this.Art.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Art.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Art.Location = new System.Drawing.Point(639, 99);
            this.Art.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Art.Name = "Art";
            this.Art.Size = new System.Drawing.Size(64, 27);
            this.Art.TabIndex = 29;
            this.Art.Text = "Фото";
            // 
            // Ide
            // 
            this.Ide.BackColor = System.Drawing.Color.White;
            this.Ide.Location = new System.Drawing.Point(167, 124);
            this.Ide.Margin = new System.Windows.Forms.Padding(4);
            this.Ide.Name = "Ide";
            this.Ide.Size = new System.Drawing.Size(63, 22);
            this.Ide.TabIndex = 28;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Id.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Id.Location = new System.Drawing.Point(60, 116);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(91, 33);
            this.Id.TabIndex = 27;
            this.Id.Text = "Номер";
            // 
            // Works
            // 
            this.Works.AutoSize = true;
            this.Works.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Works.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Works.Location = new System.Drawing.Point(12, 240);
            this.Works.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Works.Name = "Works";
            this.Works.Size = new System.Drawing.Size(148, 33);
            this.Works.TabIndex = 26;
            this.Works.Text = "Должность";
            // 
            // Upd
            // 
            this.Upd.BackColor = System.Drawing.Color.White;
            this.Upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upd.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Upd.Location = new System.Drawing.Point(51, 390);
            this.Upd.Margin = new System.Windows.Forms.Padding(4);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(175, 38);
            this.Upd.TabIndex = 25;
            this.Upd.Text = "Подтвердить";
            this.Upd.UseVisualStyleBackColor = false;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Agee
            // 
            this.Agee.BackColor = System.Drawing.Color.White;
            this.Agee.Location = new System.Drawing.Point(167, 204);
            this.Agee.Margin = new System.Windows.Forms.Padding(4);
            this.Agee.Name = "Agee";
            this.Agee.Size = new System.Drawing.Size(67, 22);
            this.Agee.TabIndex = 24;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Age.Location = new System.Drawing.Point(46, 196);
            this.Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(109, 33);
            this.Age.TabIndex = 23;
            this.Age.Text = "Возраст";
            // 
            // InfoA
            // 
            this.InfoA.AutoSize = true;
            this.InfoA.BackColor = System.Drawing.Color.Transparent;
            this.InfoA.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoA.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.InfoA.Location = new System.Drawing.Point(215, 24);
            this.InfoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoA.Name = "InfoA";
            this.InfoA.Size = new System.Drawing.Size(427, 38);
            this.InfoA.TabIndex = 22;
            this.InfoA.Text = "Информация о сотруднике";
            this.InfoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 451);
            this.Controls.Add(this.FIOe);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Arte);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Workse);
            this.Controls.Add(this.Art);
            this.Controls.Add(this.Ide);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Works);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Agee);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.InfoA);
            this.Name = "Info";
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.Arte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIOe;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.PictureBox Arte;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.ComboBox Workse;
        private System.Windows.Forms.Label Art;
        private System.Windows.Forms.TextBox Ide;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Works;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.TextBox Agee;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label InfoA;
    }
}