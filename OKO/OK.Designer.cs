﻿namespace OKO
{
    partial class OKO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OKO));
            this.NameForm = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // NameForm
            // 
            this.NameForm.AutoSize = true;
            this.NameForm.BackColor = System.Drawing.Color.Transparent;
            this.NameForm.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameForm.Location = new System.Drawing.Point(226, 19);
            this.NameForm.Name = "NameForm";
            this.NameForm.Size = new System.Drawing.Size(509, 49);
            this.NameForm.TabIndex = 0;
            this.NameForm.Text = "Отдел кадров организации";
            // 
            // OFD
            // 
            this.OFD.FileName = "OFD";
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(129, 83);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(708, 388);
            this.Table.TabIndex = 3;
            this.Table.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDoubleClick);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(257, 488);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(208, 49);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(471, 488);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(208, 49);
            this.Update.TabIndex = 5;
            this.Update.Text = "Удалить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // OKO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 549);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.NameForm);
            this.Name = "OKO";
            this.Text = "Отдел кадров";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameForm;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
    }
}

