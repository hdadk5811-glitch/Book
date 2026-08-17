using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Book
{
    public partial class Form2 : Form
    {
        private DatabaseHelper dbHelper;
        private int selectedBookId = -1;

        public Form2()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            InitializeComboBoxes();  // <- مع es
            LoadBooks();
        }

        private void InitializeComboBoxes()  // <- مع es
        {
            comboCategory.Items.AddRange(new string[] {
                "Художественная", "Наука", "Хобби", "Саморазвитие",
                "История", "Философия", "Религия", "Поэзия", "Дом"
            });
            comboCategory.SelectedIndex = 0;

            comboStatus.Items.AddRange(new string[] {
                "В наличии", "Выдана", "Потеряна"
            });
            comboStatus.SelectedIndex = 0;
        }

        private void LoadBooks()
        {
            try
            {
                using (SQLiteConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Title AS 'Название', Author AS 'Автор', Publisher AS 'Издательство', " +
                                 "Year AS 'Год', Category AS 'Категория', Status AS 'Статус', Rating AS 'Оценка' " +
                                 "FROM Books ORDER BY Id DESC";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewBooks.DataSource = dt;

                    if (dataGridViewBooks.Columns["Id"] != null)
                        dataGridViewBooks.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtYear.Text = "";
            txtRating.Text = "";
            comboCategory.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
            selectedBookId = -1;
            txtTitle.Focus();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название книги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (SQLiteConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Books (Title, Author, Publisher, Year, Category, Status, Rating) 
                                 VALUES (@title, @author, @publisher, @year, @category, @status, @rating)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text.Trim());
                    cmd.Parameters.AddWithValue("@year", string.IsNullOrWhiteSpace(txtYear.Text) ? 0 : int.Parse(txtYear.Text));
                    cmd.Parameters.AddWithValue("@category", comboCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", comboStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@rating", string.IsNullOrWhiteSpace(txtRating.Text) ? 0 : int.Parse(txtRating.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✓ Книга добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Выберите книгу из таблицы!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE Books SET Title=@title, Author=@author, Publisher=@publisher, 
                                 Year=@year, Category=@category, Status=@status, Rating=@rating WHERE Id=@id";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text.Trim());
                    cmd.Parameters.AddWithValue("@year", string.IsNullOrWhiteSpace(txtYear.Text) ? 0 : int.Parse(txtYear.Text));
                    cmd.Parameters.AddWithValue("@category", comboCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", comboStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@rating", string.IsNullOrWhiteSpace(txtRating.Text) ? 0 : int.Parse(txtRating.Text));
                    cmd.Parameters.AddWithValue("@id", selectedBookId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✓ Книга обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Выберите книгу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Удалить книгу?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection conn = dbHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM Books WHERE Id=@id";
                        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", selectedBookId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✓ Книга удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadBooks();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];
                selectedBookId = Convert.ToInt32(row.Cells["Id"].Value);
                txtTitle.Text = row.Cells["Название"].Value?.ToString() ?? "";
                txtAuthor.Text = row.Cells["Автор"].Value?.ToString() ?? "";
                txtPublisher.Text = row.Cells["Издательство"].Value?.ToString() ?? "";
                txtYear.Text = row.Cells["Год"].Value?.ToString() ?? "";
                comboCategory.SelectedItem = row.Cells["Категория"].Value?.ToString();
                comboStatus.SelectedItem = row.Cells["Статус"].Value?.ToString();
                txtRating.Text = row.Cells["Оценка"].Value?.ToString() ?? "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
