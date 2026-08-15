namespace Book
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TextBox txtTitle, txtAuthor, txtPublisher, txtYear, txtRating;
        private System.Windows.Forms.ComboBox comboCategory, comboStatus;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.Label lblTitle, lblAuthor, lblPublisher, lblYear, lblCategory, lblStatus, lblRating;
        private System.Windows.Forms.GroupBox grpBookData, grpButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBookData = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.grpBookData.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBooks.Location = new System.Drawing.Point(490, 20);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(490, 550);
            this.dataGridViewBooks.TabIndex = 2;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(290, 24);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(130, 72);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(290, 24);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(130, 112);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(290, 24);
            this.txtPublisher.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(130, 152);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 24);
            this.txtYear.TabIndex = 7;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(130, 272);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(100, 24);
            this.txtRating.TabIndex = 13;
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.Location = new System.Drawing.Point(130, 192);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(200, 24);
            this.comboCategory.TabIndex = 9;
          //  this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.Location = new System.Drawing.Point(130, 232);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(200, 24);
            this.comboStatus.TabIndex = 11;
          //  this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(160, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "✏️ Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(300, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "🗑️ Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(20, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "🧹 Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpBookData
            // 
            this.grpBookData.BackColor = System.Drawing.Color.White;
            this.grpBookData.Controls.Add(this.lblTitle);
            this.grpBookData.Controls.Add(this.txtTitle);
            this.grpBookData.Controls.Add(this.lblAuthor);
            this.grpBookData.Controls.Add(this.txtAuthor);
            this.grpBookData.Controls.Add(this.lblPublisher);
            this.grpBookData.Controls.Add(this.txtPublisher);
            this.grpBookData.Controls.Add(this.lblYear);
            this.grpBookData.Controls.Add(this.txtYear);
            this.grpBookData.Controls.Add(this.lblCategory);
            this.grpBookData.Controls.Add(this.comboCategory);
            this.grpBookData.Controls.Add(this.lblStatus);
            this.grpBookData.Controls.Add(this.comboStatus);
            this.grpBookData.Controls.Add(this.lblRating);
            this.grpBookData.Controls.Add(this.txtRating);
            this.grpBookData.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpBookData.Location = new System.Drawing.Point(20, 20);
            this.grpBookData.Name = "grpBookData";
            this.grpBookData.Size = new System.Drawing.Size(450, 390);
            this.grpBookData.TabIndex = 0;
            this.grpBookData.TabStop = false;
            this.grpBookData.Text = "📘 Данные книги";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(20, 75);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(100, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Автор:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.Location = new System.Drawing.Point(20, 115);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(100, 25);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Издательство:";
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(20, 155);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(100, 25);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Год издания:";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(20, 195);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 25);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Категория:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 235);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 25);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Статус:";
            // 
            // lblRating
            // 
            this.lblRating.Location = new System.Drawing.Point(20, 275);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(100, 25);
            this.lblRating.TabIndex = 12;
            this.lblRating.Text = "Оценка (1-5):";
            // 
            // grpButtons
            // 
            this.grpButtons.BackColor = System.Drawing.Color.White;
            this.grpButtons.Controls.Add(this.btnAdd);
            this.grpButtons.Controls.Add(this.btnUpdate);
            this.grpButtons.Controls.Add(this.btnDelete);
            this.grpButtons.Controls.Add(this.btnClear);
            this.grpButtons.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpButtons.Location = new System.Drawing.Point(20, 430);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(450, 130);
            this.grpButtons.TabIndex = 1;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "⚙️ Действия";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.grpBookData);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📖 Управление книгами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.grpBookData.ResumeLayout(false);
            this.grpBookData.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}