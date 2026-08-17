namespace Book
{
    partial class Form3
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
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.lblAvgRating = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInventory.Location = new System.Drawing.Point(71, 116);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersVisible = false;
            this.dataGridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInventory.Size = new System.Drawing.Size(860, 440);
            this.dataGridViewInventory.TabIndex = 4;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelStats.Controls.Add(this.lblTotalBooks);
            this.panelStats.Controls.Add(this.lblAvailable);
            this.panelStats.Controls.Add(this.lblBorrowed);
            this.panelStats.Controls.Add(this.lblAvgRating);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(20);
            this.panelStats.Size = new System.Drawing.Size(968, 80);
            this.panelStats.TabIndex = 5;
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooks.ForeColor = System.Drawing.Color.White;
            this.lblTotalBooks.Location = new System.Drawing.Point(20, 25);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(200, 30);
            this.lblTotalBooks.TabIndex = 0;
            this.lblTotalBooks.Text = "📚 Всего книг: 0";
            this.lblTotalBooks.Click += new System.EventHandler(this.lblTotalBooks_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblAvailable.Location = new System.Drawing.Point(240, 25);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(200, 30);
            this.lblAvailable.TabIndex = 1;
            this.lblAvailable.Text = "✅ В наличии: 0";
            this.lblAvailable.Click += new System.EventHandler(this.lblAvailable_Click);
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblBorrowed.Location = new System.Drawing.Point(460, 25);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(200, 30);
            this.lblBorrowed.TabIndex = 2;
            this.lblBorrowed.Text = "📤 Выдана: 0";
            this.lblBorrowed.Click += new System.EventHandler(this.lblBorrowed_Click);
            // 
            // lblAvgRating
            // 
            this.lblAvgRating.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvgRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblAvgRating.Location = new System.Drawing.Point(680, 25);
            this.lblAvgRating.Name = "lblAvgRating";
            this.lblAvgRating.Size = new System.Drawing.Size(200, 30);
            this.lblAvgRating.TabIndex = 3;
            this.lblAvgRating.Text = "⭐ Средняя оценка: 0.0";
            this.lblAvgRating.Click += new System.EventHandler(this.lblAvgRating_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(50, 606);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 40);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "🔄 Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 661);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.dataGridViewInventory);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Label lblAvgRating;
        private System.Windows.Forms.Button btnRefresh;
    }
}