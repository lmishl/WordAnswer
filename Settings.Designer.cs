namespace wordAnswer
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNachDolz = new System.Windows.Forms.TextBox();
            this.textBoxNachFIO = new System.Windows.Forms.TextBox();
            this.textBoxIspolFIO = new System.Windows.Forms.TextBox();
            this.textBoxIspolPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCans = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должность начальника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО начальника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО исполнителя";
            // 
            // textBoxNachDolz
            // 
            this.textBoxNachDolz.Location = new System.Drawing.Point(185, 30);
            this.textBoxNachDolz.Name = "textBoxNachDolz";
            this.textBoxNachDolz.Size = new System.Drawing.Size(186, 20);
            this.textBoxNachDolz.TabIndex = 3;
            // 
            // textBoxNachFIO
            // 
            this.textBoxNachFIO.Location = new System.Drawing.Point(185, 62);
            this.textBoxNachFIO.Name = "textBoxNachFIO";
            this.textBoxNachFIO.Size = new System.Drawing.Size(186, 20);
            this.textBoxNachFIO.TabIndex = 4;
            // 
            // textBoxIspolFIO
            // 
            this.textBoxIspolFIO.Location = new System.Drawing.Point(185, 94);
            this.textBoxIspolFIO.Name = "textBoxIspolFIO";
            this.textBoxIspolFIO.Size = new System.Drawing.Size(186, 20);
            this.textBoxIspolFIO.TabIndex = 5;
            // 
            // textBoxIspolPhone
            // 
            this.textBoxIspolPhone.Location = new System.Drawing.Point(185, 126);
            this.textBoxIspolPhone.Name = "textBoxIspolPhone";
            this.textBoxIspolPhone.Size = new System.Drawing.Size(186, 20);
            this.textBoxIspolPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон исполнителя";
            // 
            // buttonCans
            // 
            this.buttonCans.Location = new System.Drawing.Point(296, 176);
            this.buttonCans.Name = "buttonCans";
            this.buttonCans.Size = new System.Drawing.Size(75, 23);
            this.buttonCans.TabIndex = 8;
            this.buttonCans.Text = "Отмена";
            this.buttonCans.UseVisualStyleBackColor = true;
            this.buttonCans.Click += new System.EventHandler(this.buttonCans_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(210, 176);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 220);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCans);
            this.Controls.Add(this.textBoxIspolPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIspolFIO);
            this.Controls.Add(this.textBoxNachFIO);
            this.Controls.Add(this.textBoxNachDolz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNachDolz;
        private System.Windows.Forms.TextBox textBoxNachFIO;
        private System.Windows.Forms.TextBox textBoxIspolFIO;
        private System.Windows.Forms.TextBox textBoxIspolPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCans;
        private System.Windows.Forms.Button buttonSave;
    }
}