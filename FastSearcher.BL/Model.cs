using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using FastSearchLibrary;
using FileUtilityLibrary;


namespace MIF.BL
{
    public class Model : IModel
    {
        private FileSearcherMultiple searcher;

        private FileUtility fileUtility;

        public FileSearcherMultiple FileSearcher
        {
            get
            {
                return searcher;
            }

            set
            {
                searcher = value;
            }
        }

        public FileUtility FileUtility
        {
            get
            {
                return fileUtility;
            }

            set
            {
                fileUtility = value;
            }
        }


        public string GetFileSize(long size)
        {
            const int bInKB = 1024;
            const int bInMB = 1048576;
            const int bInGB = 1073741824;
            const long bInTB = 1099511627776;

            if (size <= 1024)
                return String.Format($"{size} B");

            if (size <= 1048576) 
                return String.Format($"{Math.Round((double) size / bInKB, 2)} KB");

            if (size <= 1073741824)
                 return String.Format($"{Math.Round((double)size / bInMB, 2)} MB");

            if (size <= 1099511627776)
                return String.Format($"{Math.Round((double)size / bInGB, 2)} GB");

            return String.Format($"{Math.Round((double)size / bInTB, 2)} TB");
        }

        public bool IsFileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public void Open(string file)
        {
            Process.Start(file); 
        }

        public void Show(string file)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + file));
        }

        public string[] GetDrives()
        {
            List<string> drives = new List<string>();

            foreach(var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    drives.Add(drive.Name);            
            }

            return drives.ToArray();
        }

    }
}
