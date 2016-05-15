namespace wordAnswer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFam = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonToWord = new System.Windows.Forms.Button();
            this.labelFam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOtch = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxAdmPract = new System.Windows.Forms.GroupBox();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBoxAutotrans = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxNomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMan = new System.Windows.Forms.Panel();
            this.panelCar = new System.Windows.Forms.Panel();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAdmPract.SuspendLayout();
            this.groupBoxPeriod.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelMan.SuspendLayout();
            this.panelCar.SuspendLayout();
            this.groupBoxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.Enabled = false;
            this.buttonFind.Location = new System.Drawing.Point(25, 262);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFam
            // 
            this.textBoxFam.Location = new System.Drawing.Point(114, 11);
            this.textBoxFam.Name = "textBoxFam";
            this.textBoxFam.Size = new System.Drawing.Size(119, 20);
            this.textBoxFam.TabIndex = 3;
            this.textBoxFam.Text = "КАЛЬДИН";
            this.textBoxFam.TextChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1015, 206);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonToWord
            // 
            this.buttonToWord.Enabled = false;
            this.buttonToWord.Location = new System.Drawing.Point(150, 262);
            this.buttonToWord.Name = "buttonToWord";
            this.buttonToWord.Size = new System.Drawing.Size(75, 23);
            this.buttonToWord.TabIndex = 6;
            this.buttonToWord.Text = "ToWord";
            this.buttonToWord.UseVisualStyleBackColor = true;
            this.buttonToWord.Click += new System.EventHandler(this.buttonToWord_Click);
            // 
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.Location = new System.Drawing.Point(13, 18);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(56, 13);
            this.labelFam.TabIndex = 7;
            this.labelFam.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(114, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(119, 20);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Text = "Владимир";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Отчество";
            // 
            // textBoxOtch
            // 
            this.textBoxOtch.Location = new System.Drawing.Point(114, 65);
            this.textBoxOtch.Name = "textBoxOtch";
            this.textBoxOtch.Size = new System.Drawing.Size(119, 20);
            this.textBoxOtch.TabIndex = 10;
            this.textBoxOtch.Text = "Вячеславович";
            this.textBoxOtch.TextChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата рождения";
            // 
            // groupBoxAdmPract
            // 
            this.groupBoxAdmPract.Controls.Add(this.groupBoxPeriod);
            this.groupBoxAdmPract.Controls.Add(this.checkedListBox1);
            this.groupBoxAdmPract.Controls.Add(this.buttonToWord);
            this.groupBoxAdmPract.Controls.Add(this.buttonFind);
            this.groupBoxAdmPract.Location = new System.Drawing.Point(307, 33);
            this.groupBoxAdmPract.Name = "groupBoxAdmPract";
            this.groupBoxAdmPract.Size = new System.Drawing.Size(249, 300);
            this.groupBoxAdmPract.TabIndex = 15;
            this.groupBoxAdmPract.TabStop = false;
            this.groupBoxAdmPract.Text = "Адм. практика";
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.label5);
            this.groupBoxPeriod.Controls.Add(this.label4);
            this.groupBoxPeriod.Controls.Add(this.dateTimePicker3);
            this.groupBoxPeriod.Controls.Add(this.dateTimePicker2);
            this.groupBoxPeriod.Location = new System.Drawing.Point(25, 161);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(200, 89);
            this.groupBoxPeriod.TabIndex = 16;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Период поиска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "По";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "С";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(40, 56);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker3.TabIndex = 2;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(40, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "ФИО",
            "Год рождения",
            "Автомобиль (марка)",
            "Автомобиль (номер)",
            "Дата нарушения",
            "Нарушение",
            "Место работы",
            "Адрес места жительства"});
            this.checkedListBox1.Location = new System.Drawing.Point(25, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 124);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            // 
            // groupBoxAutotrans
            // 
            this.groupBoxAutotrans.Location = new System.Drawing.Point(596, 33);
            this.groupBoxAutotrans.Name = "groupBoxAutotrans";
            this.groupBoxAutotrans.Size = new System.Drawing.Size(200, 300);
            this.groupBoxAutotrans.TabIndex = 16;
            this.groupBoxAutotrans.TabStop = false;
            this.groupBoxAutotrans.Text = "Автотранспорт";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(832, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 300);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Водительское уд.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Авто (марка)";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(114, 10);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(119, 20);
            this.textBoxMarka.TabIndex = 10;
            // 
            // textBoxNomer
            // 
            this.textBoxNomer.Location = new System.Drawing.Point(114, 39);
            this.textBoxNomer.Name = "textBoxNomer";
            this.textBoxNomer.Size = new System.Drawing.Size(119, 20);
            this.textBoxNomer.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Авто (номер)";
            // 
            // panelMan
            // 
            this.panelMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMan.Controls.Add(this.labelFam);
            this.panelMan.Controls.Add(this.textBoxOtch);
            this.panelMan.Controls.Add(this.label3);
            this.panelMan.Controls.Add(this.label1);
            this.panelMan.Controls.Add(this.label2);
            this.panelMan.Controls.Add(this.textBoxFam);
            this.panelMan.Controls.Add(this.textBoxName);
            this.panelMan.Controls.Add(this.dateTimePicker1);
            this.panelMan.Enabled = false;
            this.panelMan.Location = new System.Drawing.Point(12, 41);
            this.panelMan.Name = "panelMan";
            this.panelMan.Size = new System.Drawing.Size(246, 127);
            this.panelMan.TabIndex = 20;
            // 
            // panelCar
            // 
            this.panelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCar.Controls.Add(this.label6);
            this.panelCar.Controls.Add(this.label7);
            this.panelCar.Controls.Add(this.textBoxMarka);
            this.panelCar.Controls.Add(this.textBoxNomer);
            this.panelCar.Enabled = false;
            this.panelCar.Location = new System.Drawing.Point(12, 209);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(246, 76);
            this.panelCar.TabIndex = 21;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(12, 19);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(88, 17);
            this.radioButtonMan.TabIndex = 22;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "По человеку";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Location = new System.Drawing.Point(15, 188);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(65, 17);
            this.radioButtonCar.TabIndex = 23;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "По авто";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButtonCar_CheckedChanged);
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Controls.Add(this.radioButtonMan);
            this.groupBoxFind.Controls.Add(this.radioButtonCar);
            this.groupBoxFind.Controls.Add(this.panelMan);
            this.groupBoxFind.Controls.Add(this.panelCar);
            this.groupBoxFind.Location = new System.Drawing.Point(12, 33);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(271, 300);
            this.groupBoxFind.TabIndex = 24;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "По чему ищем";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 675);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxAutotrans);
            this.Controls.Add(this.groupBoxAdmPract);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAdmPract.ResumeLayout(false);
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMan.ResumeLayout(false);
            this.panelMan.PerformLayout();
            this.panelCar.ResumeLayout(false);
            this.panelCar.PerformLayout();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxFam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonToWord;
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOtch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxAdmPract;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBoxAutotrans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxNomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMan;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.GroupBox groupBoxFind;
    }
}

