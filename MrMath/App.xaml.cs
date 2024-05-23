﻿using MrMath.Helpers;

namespace MrMath
{
    public partial class App : Application
    {
        static SQLiteDataBaseHelper _db;

        public static SQLiteDataBaseHelper Db
        {
            get
            {
                if(_db == null)
                {
                    string path = Path.Combine
                        (Environment.GetFolderPath
                        (Environment.SpecialFolder.LocalApplicationData)
                        , "banco_sqlite_compras.db3");

                    _db = new SQLiteDataBaseHelper (path);
                }
                return _db;
            }
        }


        public App()
        {
            InitializeComponent();
        }
    }
}
