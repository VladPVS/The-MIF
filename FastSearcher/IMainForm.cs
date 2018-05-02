using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIF
{
    interface IMainForm
    {
        string Pattern { get; }

        string DirectoryWays { get; set; }

        SearchMode SearchMode { get; }

        int[] SelectedItems { get; }

        int SelectedItemsCount { get; }

        int FilesCount { set; }

        bool IsSearchEnabled { set; }

        bool IsStopEnabled { set; }

        bool IsClearEnabled { set; }

        bool IsShowEnabled { set; }

        bool IsOpenEnabled { set; }

        bool IsCopyEnabled { set; }

        bool IsMoveEnabled { set; }

        bool IsDeleteEnabled { set; }

        string DirectoryWay { get; }

        bool IsEnabled { set; }

        string Caption { get; set; }

        void AddItem(string item);

        void RemoveItem(int index);

        void AddProperty(string item);

        void ClearProperties();

        void SearchCompleted(bool isCanceled);

        void InitializeStartConfiguration();

        void InitializeSearchConfiguration();

        void InitializeStoppingConfiguration();

        void ClearResults();

        void ProcessError(string message);

        void ProcessWarning(string message);


        event EventHandler StartSearchClick;

        event EventHandler StopSearchClick;

        event EventHandler ResultSelected;

        event EventHandler OpenClick;

        event EventHandler ShowClick;

        event EventHandler ClearClick;

        event EventHandler AllDrivesClick;

        event EventHandler CopyClick;

        event EventHandler MoveClick;

        event EventHandler DeleteClick;

        event EventHandler AboutClick;

    }
}
