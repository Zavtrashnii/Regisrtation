namespace Registration
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBorn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeOfpayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusOfPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.OnlyOrgBtn = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Железнодорожный";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Кировский";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Октябрьский";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "Ленинский";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "Центральный";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 32);
            this.button7.TabIndex = 5;
            this.button7.Text = "Советский";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(12, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 32);
            this.button8.TabIndex = 4;
            this.button8.Text = "Свердловский";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "Все районы";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameGrid,
            this.INN,
            this.District,
            this.DateReg,
            this.Boss,
            this.User,
            this.DateBorn,
            this.Email,
            this.Number,
            this.Address,
            this.Passport,
            this.SizeOfpayments,
            this.StatusOfPayments});
            this.dataGridView1.Location = new System.Drawing.Point(151, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1040, 504);
            this.dataGridView1.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // NameGrid
            // 
            this.NameGrid.HeaderText = "Название";
            this.NameGrid.Name = "NameGrid";
            // 
            // INN
            // 
            this.INN.HeaderText = "ИНН";
            this.INN.Name = "INN";
            // 
            // District
            // 
            this.District.HeaderText = "Район";
            this.District.Name = "District";
            // 
            // DateReg
            // 
            this.DateReg.HeaderText = "Дата регистрации";
            this.DateReg.Name = "DateReg";
            // 
            // Boss
            // 
            this.Boss.HeaderText = "Уполномоченный";
            this.Boss.Name = "Boss";
            // 
            // User
            // 
            this.User.HeaderText = "Пользователь";
            this.User.Name = "User";
            // 
            // DateBorn
            // 
            this.DateBorn.HeaderText = "Дата рождения";
            this.DateBorn.Name = "DateBorn";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Number
            // 
            this.Number.HeaderText = "Телефонный номер";
            this.Number.Name = "Number";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // Passport
            // 
            this.Passport.HeaderText = "Паспорт";
            this.Passport.Name = "Passport";
            // 
            // SizeOfpayments
            // 
            this.SizeOfpayments.HeaderText = "Размер выплат";
            this.SizeOfpayments.Name = "SizeOfpayments";
            // 
            // StatusOfPayments
            // 
            this.StatusOfPayments.HeaderText = "Состояние выплат";
            this.StatusOfPayments.Name = "StatusOfPayments";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(13, 582);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 40);
            this.button9.TabIndex = 9;
            this.button9.Text = "Настройки";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // OnlyOrgBtn
            // 
            this.OnlyOrgBtn.BackColor = System.Drawing.Color.White;
            this.OnlyOrgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OnlyOrgBtn.Location = new System.Drawing.Point(13, 12);
            this.OnlyOrgBtn.Name = "OnlyOrgBtn";
            this.OnlyOrgBtn.Size = new System.Drawing.Size(120, 45);
            this.OnlyOrgBtn.TabIndex = 10;
            this.OnlyOrgBtn.Text = "Только организации";
            this.OnlyOrgBtn.UseVisualStyleBackColor = false;
            this.OnlyOrgBtn.Click += new System.EventHandler(this.OnlyOrgBtn_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(13, 63);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 45);
            this.button11.TabIndex = 11;
            this.button11.Text = "Только физ лица";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1203, 634);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.OnlyOrgBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boss;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBorn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeOfpayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusOfPayments;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button OnlyOrgBtn;

    }
}

