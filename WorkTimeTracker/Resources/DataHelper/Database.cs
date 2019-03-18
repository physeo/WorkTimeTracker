using Android.Util;
using SQLite;
using System.Collections.Generic;
using System.IO;
using WorkTimeTracker.Resources.Models;

namespace WorkTimeTracker.Resources.DataHelper
{
    public class Database
    {
        readonly string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        private const string dbName = "time_tracking.db";

        public bool CreateDatabase()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Path.Combine(folder, dbName)))
                {
                    connection.CreateTable<Shift>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool InsertIntoTableShift(Shift shift)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Path.Combine(folder, dbName)))
                {
                    connection.Insert(shift);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public List<Shift> SelectTableShift()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Path.Combine(folder, dbName)))
                {
                    return connection.Table<Shift>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }

        public bool UpdateTableShift(Shift shift)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Path.Combine(folder, dbName)))
                {
                    connection.Query<Shift>("UPDATE Shift set BeginShift=?,Break=?,EndShift=? WHERE Id = ?;",shift.BeginShift, shift.Break,shift.EndShift);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool DeleteTableShift(Shift shift)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Path.Combine(folder, dbName)))
                {
                    connection.Delete(shift);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool SelectQueryTableShift(int Id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Path.Combine(folder, dbName)))
                {
                    connection.Query<Shift>("SELECT * FROM Shift WHERE Id = ?;", Id);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
    }
}