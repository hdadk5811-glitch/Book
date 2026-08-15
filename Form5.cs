using System.Data.SQLite;
using System.IO;

namespace Book
{
    public class DatabaseHelper
    {
        private string databaseFile = "Book.db";
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = $"Data Source={databaseFile};Version=3;";
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            if (!File.Exists(databaseFile))
            {
                SQLiteConnection.CreateFile(databaseFile);
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"CREATE TABLE Books (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Author TEXT,
                        Publisher TEXT,
                        Year INTEGER,
                        Category TEXT,
                        Status TEXT,
                        Rating INTEGER,
                        Notes TEXT
                    )";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    // Sample books
                    string insertSample = @"INSERT INTO Books (Title, Author, Publisher, Year, Category, Status, Rating) VALUES
                    ('Война и мир', 'Лев Толстой', 'Эксмо', 1869, 'Художественная', 'В наличии', 5),
                    ('Преступление и наказание', 'Фёдор Достоевский', 'Азбука', 1866, 'Художественная', 'Выдана', 5),
                    ('Изучаем C#', 'Ахмед Мохаммед', 'Дар ан-Нашр', 2023, 'Наука', 'В наличии', 4)";
                    SQLiteCommand cmd2 = new SQLiteCommand(insertSample, conn);
                    cmd2.ExecuteNonQuery();
                }
            }
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
