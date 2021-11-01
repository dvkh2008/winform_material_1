using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace SKCT.Entity
{
    public class DbContextDriver : IDisposable
    {
        private SQLiteConnection _con;

        public DbContextDriver(string cs)
        {
            _con = new SQLiteConnection(cs);
        }
        
        public SQLiteCommand GetCommand()
        {
            OpenCon();
            return new SQLiteCommand(_con);
        }

        private void OpenCon()
        {
            if (_con.State == System.Data.ConnectionState.Closed)
            {
                _con.Open();
            }
        }

        public void Dispose()
        {
            if (_con == null)
            {
                return;
            }
            if (_con.State == System.Data.ConnectionState.Open)
            {
                _con.Close();
            }
            _con.Dispose();
        }
    }
}
