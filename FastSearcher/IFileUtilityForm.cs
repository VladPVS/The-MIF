using System;

namespace MIF
{
    interface IFileUtilityForm
    {
        string Caption { set; }

        string ProcessStatus { set; }

        string OperationName { set; }

        void ProcessError(string message);

        void InitializeStartConfiguration();

        void InitializeFinishConfiguration();

        void AddProcessedFile(string fileName);

        event EventHandler FormShown;

        event EventHandler ClosedClick;
    }
}
