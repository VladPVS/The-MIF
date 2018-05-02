using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using FastSearchLibrary;
using FileUtilityLibrary;

namespace MIF.BL
{
    public interface IModel
    {
        bool IsFileExists(string filePath);

        FileSearcherMultiple FileSearcher { get; set; }

        FileUtility FileUtility { get; set; }

        string GetFileSize(long size);

        void Open(string file);

        void Show(string file);

        string[] GetDrives();

    }
}