namespace Book
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch, btnClear;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.Panel panelSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();

            // ====== Form Settings ======
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Text = "🔍 Поиск книг";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);

            // ====== panelSearch ======
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Height = 80;
            this.panelSearch.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);

            // ====== txtSearch ======
            this.txtSearch.Location = new System.Drawing.Point(20, 25);
            this.txtSearch.Size = new System.Drawing.Size(500, 27);
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12);
            this.txtSearch.Text = "🔍 Введите слово для поиска...";

            // ====== btnSearch ======
            this.btnSearch.Text = "🔍 Найти";
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(540, 23);
            this.btnSearch.Size = new System.Drawing.Size(100, 35);

            // ====== btnClear ======
            this.btnClear.Text = "🧹 Очистить";
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(650, 23);
            this.btnClear.Size = new System.Drawing.Size(100, 35);

            // ====== lblResultCount ======
            this.lblResultCount.Text = "🔍 Введите слово для поиска";
            this.lblResultCount.ForeColor = System.Drawing.Color.White;
            this.lblResultCount.Font = new System.Drawing.Font("Tahoma", 12, System.Drawing.FontStyle.Bold);
            this.lblResultCount.Location = new System.Drawing.Point(20, 70);
            this.lblResultCount.Size = new System.Drawing.Size(400, 30);

            this.panelSearch.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtSearch, this.btnSearch, this.btnClear, this.lblResultCount
            });

            // ====== dataGridViewResults ======
            this.dataGridViewResults.Location = new System.Drawing.Point(20, 110);
            this.dataGridViewResults.Size = new System.Drawing.Size(860, 470);
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.RowHeadersVisible = false;

            // ====== Events ======
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ====== Add Controls to Form ======
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dataGridViewResults);

            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
        }
    }
}