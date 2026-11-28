using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Data
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString = "Data Source=budget_tracker.db";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }

        public static void InitializeDatabase()
        {
            using var conn = GetConnection();
            conn.Open();

            string createUsersTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL
                );";

            using var cmd = new SqliteCommand(createUsersTable, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
