﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace REvernus.Utilities
{
    public static class Paths
    {
        // Directories
        public static string CurrentDirectory => Environment.CurrentDirectory;
        public static string DataFolderPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "REvernus", "Data");
        public static string DataBaseFolderPath => Path.Combine(DataFolderPath, "db");
        public static string EveDocumentsFolderPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EVE");
        public static string EveFleetLogsFolderPath => Path.Combine(EveDocumentsFolderPath, "logs", "Fleetlogs");
        public static string EveMarketLogsFolderPath => Path.Combine(EveDocumentsFolderPath, "logs", "Marketlogs");
        public static string EveGameLogsFolderPath => Path.Combine(EveDocumentsFolderPath, "logs", "Gamelogs");
        public static string EveChatlogsLogsFolderPath => Path.Combine(EveDocumentsFolderPath, "logs", "Chatlogs");

        // DB Paths
        public static string SdeDataBasePath => Path.Combine(DataBaseFolderPath, "eve.db");
        public static string CompressedSdeDataBasePath => Path.Combine(DataBaseFolderPath, "eve.db.bz2");
        public static string UserDataBasePath => Path.Combine(DataBaseFolderPath, "user.db");

        // Specific Files
        public static string CharacterDataFilePath => Path.Combine(DataFolderPath, "Characters.bin");
        public static string SettingsDataFilePath => Path.Combine(DataFolderPath, "Settings.bin");

    }
}
