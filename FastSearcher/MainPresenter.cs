using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Reflection;
using FastSearchLibrary;
using FileUtilityLibrary;
using MIF.BL;

namespace MIF
{

    class MainPresenter
    {

        private IMainForm mainFormView;

        private IModel model;

        private IWindowManager windowManager;

        private IFileUtilityForm fileUtilityFormView;

        public IFileUtilityForm FileUtilityFormView
        {
            set
            {
                fileUtilityFormView = value;
                fileUtilityFormView.FormShown += FileUtilityFormView_FormShown;
                fileUtilityFormView.ClosedClick += FileUtilityFormView_ClosedClick;
            }
        }

        private static object mainFormLocker = new object();

        private static object fileUtilityFormLocker = new object();

        private ObservableDistinctCollection files;

        private ProgramStatus programStatus;


        public MainPresenter(IMainForm mainForm, IModel model, IWindowManager windowManager)
        {

            files = new ObservableDistinctCollection();

            files.CollectionChanged += (o, arg) =>
            {
                switch (arg.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                    {
                         mainFormView.AddItem(((FileInfo) arg.NewItems[0]).Name);
                         break;
                    }

                    case NotifyCollectionChangedAction.Remove:
                    {
                         mainFormView.RemoveItem(arg.OldStartingIndex);
                         break;
                    }
                }
                mainFormView.FilesCount = files.Count;
            };

            this.mainFormView = mainForm;

            this.model = model;

            this.windowManager = windowManager;

            mainFormView.FilesCount = 0;

            mainFormView.InitializeStartConfiguration();

            mainFormView.StartSearchClick += ViewStartSearch;
            mainFormView.StopSearchClick  += ViewStopSearch;
            mainFormView.ResultSelected   += View_ResultSelected;
            mainFormView.OpenClick        += View_OpenClick;
            mainFormView.ShowClick        += View_ShowClick;
            mainFormView.ClearClick       += View_ClearClick;
            mainFormView.AllDrivesClick   += View_AllDrivesClick;
            mainFormView.CopyClick        += View_CopyClick;
            mainFormView.MoveClick        += View_MoveClick;
            mainFormView.DeleteClick      += View_DeleteClick;
            mainForm.AboutClick           += MainForm_AboutClick;

            SetProcessPriority(ProcessPriorityClass.High);

            SetThreadPriority(ThreadPriority.AboveNormal);

            ProcessCommandLineArgs();

            programStatus = ProgramStatus.ReadyToSearch;
        }


        private void FileUtilityFormView_ClosedClick(object sender, EventArgs e)
        {
            mainFormView.IsEnabled = true;
        }

        private void FileUtilityFormView_FormShown(object sender, EventArgs e)
        {
            fileUtilityFormView.InitializeStartConfiguration();

        }

        private void MainForm_AboutClick(object sender, EventArgs e)
        {
            windowManager.ShowAboutBoxForm();
        }

        private async void View_DeleteClick(object sender, EventArgs e)
        {
            programStatus = ProgramStatus.FileOperation;

            mainFormView.ClearProperties();

            int[] selectedItemNumbers = mainFormView.SelectedItems;
            int itemsCount = selectedItemNumbers.Length;

            if (itemsCount == 0) return;

            List<FileInfo> selectedFiles = new List<FileInfo>();

            for (int i = 0; i < itemsCount; i++)
            {
                selectedFiles.Add(files[selectedItemNumbers[i]]);
            }

            int processedFilesCount = 0;

            windowManager.ShowFileUtilityForm(this);

            fileUtilityFormView.ProcessStatus = String.Format($"{processedFilesCount}/{itemsCount}");

            fileUtilityFormView.Caption = "Deleted files: ";

            model.FileUtility = new FileUtility();

            model.FileUtility.FileDeleted += (o, arg) =>
            {
                lock (fileUtilityFormLocker)
                {
                    string fileName = arg.File.Name;
                    files.RemoveItem(arg.File);

                    fileUtilityFormView.AddProcessedFile(fileName);
                    fileUtilityFormView.ProcessStatus = String.Format($"{++processedFilesCount}/{itemsCount}");
                }
            };

            model.FileUtility.FileDeleteCompleted += (o, arg) =>
            {
                fileUtilityFormView.InitializeFinishConfiguration();
                fileUtilityFormView.OperationName = "Deleting completed";

                if (arg.ErrorList.Count > 0)
                {
                    string errorMessage = "Some files have not been deleted.";
                    fileUtilityFormView.ProcessError(errorMessage);
                }

                if (files.Count == 0)
                {
                    mainFormView.IsClearEnabled = false;
                    mainFormView.IsShowEnabled = false;
                    mainFormView.IsOpenEnabled = false;
                    mainFormView.IsCopyEnabled = false;
                    mainFormView.IsMoveEnabled = false;
                    mainFormView.IsDeleteEnabled = false;
                }

                programStatus = ProgramStatus.ReadyToSearch;
            };

            model.FileUtility.FileDeleteCompleted += View_ResultSelected;

            fileUtilityFormView.OperationName = "Deleting...";

            mainFormView.IsEnabled = false;

            await Task.Run(() => { model.FileUtility.DeleteFiles(selectedFiles); });
        }


        private async void View_MoveClick(object sender, EventArgs e)
        {
            programStatus = ProgramStatus.FileOperation;

            mainFormView.ClearProperties();

            int[] selectedItemNumbers = mainFormView.SelectedItems;
            int itemsCount = selectedItemNumbers.Length;

            if (itemsCount == 0) return;

            List<FileInfo> selectedFiles = new List<FileInfo>();

            for (int i = 0; i < itemsCount; i++)
            {
                selectedFiles.Add(files[selectedItemNumbers[i]]);
            }

            int processedFilesCount = 0;

            windowManager.ShowFileUtilityForm(this);

            fileUtilityFormView.ProcessStatus = String.Format($"{processedFilesCount}/{itemsCount}");

            fileUtilityFormView.Caption = "Moved files: ";

            model.FileUtility = new FileUtility();

            model.FileUtility.FileMoved += (o, arg) =>
            {
                lock (fileUtilityFormLocker)
                {
                    files.RemoveItem(arg.PreviousFile);
                    files.AddItem(arg.CurrentFile);

                        string fileName = arg.CurrentFile.Name; // without Task

                        fileUtilityFormView.AddProcessedFile(fileName);
                        fileUtilityFormView.ProcessStatus = String.Format($"{++processedFilesCount}/{itemsCount}");            
                }
            };

            model.FileUtility.FileMoveCompleted += (o, arg) =>
            {
                fileUtilityFormView.InitializeFinishConfiguration();
                fileUtilityFormView.OperationName = "Moving completed";

                if (arg.ErrorList.Count > 0)
                {
                    string errorMessage = "Some files have not been moved.";
                    fileUtilityFormView.ProcessError(errorMessage);
                }

                programStatus = ProgramStatus.ReadyToSearch;
            };

            model.FileUtility.FileMoveCompleted += View_ResultSelected;

            fileUtilityFormView.OperationName = "Moving...";

            mainFormView.IsEnabled = false;

            await Task.Run(() => { model.FileUtility.MoveFiles(selectedFiles, mainFormView.DirectoryWay); });
        }


        private async void View_CopyClick(object sender, EventArgs e)
        {
            programStatus = ProgramStatus.FileOperation;

            int[] selectedItemNumbers = mainFormView.SelectedItems;
            int itemsCount = selectedItemNumbers.Length;

            if (itemsCount == 0) return;

            List<FileInfo> selectedFiles = new List<FileInfo>();

            for (int i = 0; i < itemsCount; i++)
            {
                selectedFiles.Add(files[selectedItemNumbers[i]]);
            }

            int processedFilesCount = 0;

            windowManager.ShowFileUtilityForm(this);
            fileUtilityFormView.ProcessStatus = String.Format($"{processedFilesCount}/{itemsCount}");
            fileUtilityFormView.Caption = "Copied files: ";

            model.FileUtility = new FileUtility();
            model.FileUtility.FileCopied += (o, arg) =>
            {
                lock (fileUtilityFormLocker)
                {
                    string fileName = arg.File.Name;
                    
                    fileUtilityFormView.AddProcessedFile(fileName);
                    fileUtilityFormView.ProcessStatus = String.Format($"{++processedFilesCount}/{itemsCount}");
                }
            };

            model.FileUtility.FileCopyCompleted += (o, arg) =>
            {
                fileUtilityFormView.InitializeFinishConfiguration();
                fileUtilityFormView.OperationName = "Copying completed";

                if (arg.ErrorList.Count > 0)
                {
                    string errorMessage = "Some files have not been copied.";
                    fileUtilityFormView.ProcessError(errorMessage);
                }

                programStatus = ProgramStatus.ReadyToSearch;
            };

            fileUtilityFormView.OperationName = "Copying...";

            mainFormView.IsEnabled = false;

            await Task.Run(() => { model.FileUtility.CopyFiles(selectedFiles, mainFormView.DirectoryWay); });
        }


        private void View_ClearClick(object sender, EventArgs e)
        {
            files?.Clear();
            mainFormView.ClearResults();
        }


        private void View_AllDrivesClick(object sender, EventArgs e)
        {
            mainFormView.DirectoryWays = String.Join(";", model.GetDrives());
        }


        private void View_ShowClick(object sender, EventArgs e)
        {
            int[] items = mainFormView.SelectedItems;

            if (items.Length == 0 || items[0] == -1) return;
               model.Show(files[items[0]].FullName);
        }


        private void View_OpenClick(object sender, EventArgs e)
        {
            int[] items = mainFormView.SelectedItems;

            if (items.Length == 0 || items[0] == -1) return;
            try
            {
                model.Open(files[items[0]].FullName);
            }
            catch(Exception ex)
            {
                mainFormView.ProcessError($"Unable to open selected file.");
            }
        }


        private void View_ResultSelected(object sender, EventArgs e)
        {
            if (programStatus == ProgramStatus.FileOperation) return;

            mainFormView.ClearProperties();

            int[] selectedItems = null;

            int itemsCount = mainFormView.SelectedItemsCount;

            const ushort maxViewedItems = 1024;
            const ushort maxSizeCountableItems = 4096;

            FileInfo file = null;

            if (itemsCount == 0)
            {
                mainFormView.IsShowEnabled = false;
                mainFormView.IsOpenEnabled = false;
                mainFormView.IsCopyEnabled = false;
                mainFormView.IsMoveEnabled = false;
                mainFormView.IsDeleteEnabled = false;
                return;
            }

            mainFormView.IsShowEnabled = itemsCount == 1;
            mainFormView.IsOpenEnabled = itemsCount == 1;

            if (programStatus == ProgramStatus.ReadyToSearch)
            {
                mainFormView.IsCopyEnabled = true;
                mainFormView.IsMoveEnabled = true;
                mainFormView.IsDeleteEnabled = true;
            }

            if (itemsCount > 1)
            {
                mainFormView.AddProperty($"Selected files: {itemsCount}{Environment.NewLine}");

                if (itemsCount > maxSizeCountableItems) return;

                selectedItems = mainFormView.SelectedItems;

                long fileSizesSum = selectedItems.AsParallel().Sum((i => files[i].Length));

                mainFormView.AddProperty($"Total size: {model.GetFileSize(fileSizesSum)}{Environment.NewLine}{Environment.NewLine}");

                if (itemsCount > maxViewedItems) return;

                for (int i = 0; i < itemsCount; i++)
                {
                    file = files[selectedItems[i]];

                    mainFormView.AddProperty($"Full name: {file.FullName}{Environment.NewLine}{Environment.NewLine}");
                }

                return;
            }

            selectedItems = mainFormView.SelectedItems;

            int number = selectedItems[0];

            if (number < 0) return;

            file = files[number];

            mainFormView.AddProperty($"Full Name: {file.FullName}\n");
            mainFormView.AddProperty($"Creation Time: {file.CreationTime}\n");
            mainFormView.AddProperty($"Last Access Time: {file.LastAccessTime}\n");
            mainFormView.AddProperty($"Size: {model.GetFileSize(file.Length)}\n");
            mainFormView.AddProperty($"Readonly: {file.IsReadOnly}");
        }


        private void Searcher_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            mainFormView.SearchCompleted(e.IsCanceled);
            programStatus = ProgramStatus.ReadyToSearch;
        }


        private void Searcher_FilesFound(object sender, FileEventArgs e)
        {
            lock (mainFormLocker)
            {
                e.Files.ForEach((f) =>
                {
                    files.AddItem(f);
                });              
            }
        }


        private void ViewStopSearch(object sender, EventArgs e)
        {
            mainFormView.InitializeStoppingConfiguration();
            model.FileSearcher.StopSearch();
        }


        private async void ViewStartSearch(object sender, EventArgs e)
        {
            programStatus = ProgramStatus.Search;

            List<string> searchDirectories = new List<string>();

            if (String.IsNullOrEmpty(mainFormView.DirectoryWays.Trim()))
                mainFormView.DirectoryWays = String.Join(";", model.GetDrives());

            string[] directories = mainFormView.DirectoryWays.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string[] distinctDirectories = directories.Distinct().ToArray();

            if (directories.Length != distinctDirectories.Length)
            {
                mainFormView.DirectoryWays = String.Join(";", distinctDirectories);
            }

            searchDirectories.AddRange(distinctDirectories);

            string pattern = mainFormView.Pattern;

            switch (mainFormView.SearchMode)
            {
                case SearchMode.Conventional:
                {
                        if (String.IsNullOrWhiteSpace(pattern) || pattern == String.Empty)
                        {
                            mainFormView.ProcessWarning("Pattern has not been entered.");
                            return;
                        }

                        if (!IsPatternValid(pattern))
                        {
                            mainFormView.ProcessWarning("Incorrect pattern has been entered.");
                            return;
                        }                  

                        try
                        {
                            model.FileSearcher = new FileSearcherMultiple(searchDirectories, PreparePattern(pattern), new CancellationTokenSource());
                        }
                        catch(ArgumentException ex) when (ex.ParamName == "folder")
                        {
                            mainFormView.ProcessWarning("Incorrect folder has been entered.");
                            return;
                        }
                        catch (NotSupportedException ex)
                        {
                            mainFormView.ProcessWarning("Incorrect folder has been entered.");
                            return;
                        }
                        catch (Exception ex)
                        {
                            mainFormView.ProcessError(ex.Message);
                            return;
                        }
                        break;
                }

                case SearchMode.RegularExpression:
                {
                        if (String.IsNullOrWhiteSpace(pattern) || pattern == String.Empty)
                        {
                            mainFormView.ProcessWarning("Pattern has not been entered.");
                            return;
                        }

                        if (!IsRegexValid(pattern))
                        {
                            mainFormView.ProcessError("Incorrect pattern has been entered.");
                            return;
                        }

                        try
                        {
                            model.FileSearcher = new FileSearcherMultiple(searchDirectories, (f) =>
                            {
                                return Regex.IsMatch(f.Name, pattern);
                            }, new CancellationTokenSource());
                        }
                        catch(ArgumentException ex) when(ex.ParamName == "folder")
                        {
                            mainFormView.ProcessWarning("Incorrect folder has been entered.");
                            return;
                        }
                        catch(NotSupportedException ex)
                        {
                            mainFormView.ProcessWarning("Incorrect folder has been entered.");
                            return;
                        }
                        catch(Exception ex)
                        {
                            mainFormView.ProcessError(ex.Message);
                            return;
                        }
                        break;
                }
            }

            files.Clear();

            mainFormView.InitializeSearchConfiguration();

            model.FileSearcher.FilesFound += Searcher_FilesFound;
            model.FileSearcher.SearchCompleted += Searcher_SearchCompleted;

            try
            {
                await model.FileSearcher.StartSearchAsync();
            }
            catch (AggregateException ex)
            {
                mainFormView.SearchCompleted(true);
                mainFormView.ProcessError($"{ex.InnerException.Message}");
            }
            catch (Exception ex)
            {
                mainFormView.SearchCompleted(true);
                mainFormView.ProcessError($"{ex.Message}");
            }
        }


        private bool IsRegexValid(string pattern)
        {
            try
            { 
                Regex reg = new Regex(pattern);
            }
            catch(ArgumentException ex)
            {
                return false;
            }
            return true;
        }

        private bool IsPatternValid(string pattern)
        {
            try
            {     
                new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.GetDirectories(pattern, SearchOption.TopDirectoryOnly);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        private string PreparePattern(string pattern)
        {
            if (pattern.Count((ch) => ch == '*' || ch == '?') > 0) return pattern;

            return String.Concat("*", pattern.Trim(), "*");
        }

        private void SetProcessPriority(ProcessPriorityClass priority)
        {
            Process.GetCurrentProcess().PriorityClass = priority;
        }

        private void SetThreadPriority(ThreadPriority priority)
        {
            Thread.CurrentThread.Priority = priority;
        }

        private void ProcessCommandLineArgs()
        {
            string [] args = Environment.GetCommandLineArgs();

            if (args.Length <= 1) return;

            if (args[1] == "-fl")
                mainFormView.Caption += " (Forced Launch)";
        }

    }
}
