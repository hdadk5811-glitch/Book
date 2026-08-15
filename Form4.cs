using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Book
{
    public partial class Form4 : Form
    {
        private DatabaseHelper dbHelper;

        public Form4()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Введите слово для поиска!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Title AS 'Название', Author AS 'Автор', " +
                                 "Publisher AS 'Издательство', Year AS 'Год', Category AS 'Категория', " +
                                 "Status AS 'Статус', Rating AS 'Оценка' FROM Books " +
                                 "WHERE Title LIKE @search OR Author LIKE @search OR Category LIKE @search";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@search", $"%{keyword}%");
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewResults.DataSource = dt;
                    lblResultCount.Text = $"🔍 Найдено: {dt.Rows.Count} книг";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dataGridViewResults.DataSource = null;
            lblResultCount.Text = "🔍 Введите слово для поиска";
            txtSearch.Focus();
        }
    }
}


