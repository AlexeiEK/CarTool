﻿using System.IO;

namespace DataBaseLib
{
    public class ConnectionString
    {
        private static string _server;
        private static string _db;
        private static string _user;
        private static string _password;


        public static string Init(string str)
        {
            var config = str.Split('|');
            _server = config[0];
            _db = config[1];
            _user = config[2];
            _password = config[3];
            return $"Server={_server};Database={_db};Uid={_user};Pwd={_password}";
        }

        public static string InitFile(string path)
        {
            using var file = new StreamReader(path);
            var temp = file.ReadLine();

            var config = temp.Split('|');
            _server = config[0];
            _db = config[1];
            _user = config[2];
            _password = config[3];

            return $"Server={_server};Database={_db};Uid={_user};Pwd={_password}";
        }
    }
}