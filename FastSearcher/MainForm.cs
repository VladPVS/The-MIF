using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MIF
{
    public enum SearchMode
    {
        Conventional = 0,
        RegularExpression = 1
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public event EventHandler StartSearchClick;

        public event EventHandler StopSearchClick;

        public event EventHandler ResultSelected;

        public event EventHandler OpenClick;

        public event EventHandler ShowClick;

        public event EventHandler ClearClick;

        public event EventHandler AllDrivesClick;

        public event EventHandler CopyClick;

        public event EventHandler MoveClick;

        public event EventHandler DeleteClick;

        public event EventHandler AboutClick;

        public void AddItem(string item)
        {
            Action action = () => listBoxResult.Items.Add(item);

            if (this.InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        public void RemoveItem(int index)
        {
            Action action = () => listBoxResult.Items.RemoveAt(index);

            if (this.InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        public void AddProperty(string item)
        {
            Action action = () => richTextBoxProperties.AppendText(item);

            if (this.InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        public void ClearProperties()
        {
            Action action = () => richTextBoxProperties.Clear();

            if (this.InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        public string Pattern
        {
            get
            {
                string text = string.Empty;

                Action action = () => text = textBoxPattern.Text;

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);

                return text;
            }
        }

        public string DirectoryWays
        {
            get
            {
                string text = string.Empty;

                Action action = () => text = textBoxDirectories.Text;

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);

                return text;
            }

            set
            {
                Action action = () => textBoxDirectories.Text = value;

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }

        }

        public SearchMode SearchMode { get; set; }

        public int[] SelectedItems
        {
            get
            {
                int[] selectedItems = null;

                Action action = () =>
                {
                    if (listBoxResult.SelectedIndices.Count <= 1)
                    {
                        selectedItems = new int[] { listBoxResult.SelectedIndex };
                    }
                    else
                    {
                        selectedItems = listBoxResult.SelectedIndices.Cast<int>().ToArray();
                    }
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);

                return selectedItems;
            }
        }


        public int SelectedItemsCount
        {
            get
            {
                int count = 0;
                Action action = () => count = listBoxResult.SelectedIndices.Count;

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);

                return count;
            }
        }


        public int FilesCount
        {
            set
            {
                Action action = () => toolStripStatusLabelFilesCount.Text = value.ToString();

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }


        public bool IsSearchEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonSearch.Enabled = value;
                    contextMenuResultList.Items["startSearchToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }


        public bool IsStopEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonStop.Enabled = value;
                    contextMenuResultList.Items["stopSearchToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }


        public bool IsClearEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonClear.Enabled = value; 
                    contextMenuMain.Items["clearResultsToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }


        public bool IsShowEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonShow.Enabled = value;
                    contextMenuResultList.Items["showToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }


        public bool IsOpenEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonOpen.Enabled = value;
                    contextMenuResultList.Items["openToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }

        public bool IsCopyEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonCopy.Enabled = value;
                    contextMenuResultList.Items["copyToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }

        public bool IsMoveEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonMove.Enabled = value;
                    contextMenuResultList.Items["moveToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }

        public bool IsDeleteEnabled
        {
            set
            {
                Action action = () =>
                {
                    buttonDelete.Enabled = value;
                    contextMenuResultList.Items["deleteToolStripMenuItem"].Enabled = value;
                };

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);
            }
        }

        public string DirectoryWay { get; set; } // way for file operations

        public bool IsEnabled
        {
            set
            {
                Action action = () =>
                {
                    this.Enabled = value;
                };

                if (InvokeRequired)
                {
                    Invoke(action);
                }
                else
                {
                    action();
                }
            }
        }

        public string Caption
        {
            get
            {
                return this.Text;
            }

            set
            {
                this.Text = value;
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            StartSearchClick?.Invoke(this, EventArgs.Empty);
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopSearchClick?.Invoke(this, EventArgs.Empty);
        }


        public void SearchCompleted(bool isCanceled)
        {
            InitializeStartConfiguration();

            if (isCanceled)
            {
                ProcessNotification("Search stopped.");
            }
            else
            {
                ProcessNotification("Search completed");
            }   
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowItemInfo();
        }

        private void ShowItemInfo()
        {
            ResultSelected?.Invoke(this, EventArgs.Empty);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(textBoxDirectories.Text) || String.IsNullOrWhiteSpace(textBoxDirectories.Text))
                {
                    textBoxDirectories.Text = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    textBoxDirectories.Text += String.Concat(";", folderBrowserDialog.SelectedPath);
                }
            }
        }
        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearClick?.Invoke(this, EventArgs.Empty);
        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenClick?.Invoke(this, EventArgs.Empty);
        }


        private void buttonShow_Click(object sender, EventArgs e)
        {
            ShowClick?.Invoke(this, EventArgs.Empty);
        }


        private void buttonAllDrives_Click(object sender, EventArgs e)
        {
            AllDrivesClick?.Invoke(this, EventArgs.Empty);
        }


        private void radioButtonConventional_CheckedChanged(object sender, EventArgs e)
        {
            SearchMode = SearchMode.Conventional;
        }


        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            SearchMode = SearchMode.RegularExpression;
        }


        public void ProcessError(string message)
        {
            Action action = () => MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        public void ProcessWarning(string message)
        {
            Action action = () =>  MessageBox.Show(this, message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        public void ProcessNotification(string message)
        {
            Action action = () => MessageBox.Show(this, message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }

        }


        public void ClearResults()
        {
            Action action = () =>
            {  
                listBoxResult.Items.Clear();
                richTextBoxProperties.Clear();
                toolStripStatusLabelFilesCount.Text = "0";
                buttonClear.Enabled = false;

                contextMenuResultList.Items["showToolStripMenuItem"].Enabled = buttonShow.Enabled = false;
                contextMenuResultList.Items["openToolStripMenuItem"].Enabled = buttonOpen.Enabled = false;
                contextMenuResultList.Items["copyToolStripMenuItem"].Enabled = buttonCopy.Enabled = false;
                contextMenuResultList.Items["moveToolStripMenuItem"].Enabled = buttonMove.Enabled = false;
                contextMenuResultList.Items["deleteToolStripMenuItem"].Enabled = buttonDelete.Enabled = false;
            };
            
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        public void InitializeSearchConfiguration()
        {
            contextMenuMain.Items["startSearchToolStripMenuItem"].Enabled = buttonSearch.Enabled = false;
            contextMenuMain.Items["clearResultsToolStripMenuItem"].Enabled = buttonClear.Enabled = false;
            contextMenuMain.Items["stopSearchToolStripMenuItem"].Enabled = buttonStop.Enabled = true; 

            ClearResults();

            progressBar.Style = ProgressBarStyle.Marquee;
            labelCondition.Text = "Searching...";


            if (listBoxResult.Capture)
                listBoxResult.Capture = false;

            listBoxResult.SelectionMode = SelectionMode.One;
        }


        public void InitializeStartConfiguration()
        {
            Action action = () =>
            {
                contextMenuMain.Items["startSearchToolStripMenuItem"].Enabled = buttonSearch.Enabled = true;
                contextMenuMain.Items["stopSearchToolStripMenuItem"].Enabled  = buttonStop.Enabled = false;
                contextMenuMain.Items["clearResultsToolStripMenuItem"].Enabled = buttonClear.Enabled = listBoxResult.Items.Count > 0; 

                contextMenuResultList.Items["showToolStripMenuItem"].Enabled = buttonShow.Enabled = listBoxResult.SelectedIndex >= 0;
                contextMenuResultList.Items["openToolStripMenuItem"].Enabled = buttonOpen.Enabled = listBoxResult.SelectedIndex >= 0;

                progressBar.Style = ProgressBarStyle.Continuous;
                labelCondition.Text = "Ready to search";


                if (listBoxResult.Capture)
                {
                    int selectedIndex = listBoxResult.SelectedIndex;

                    listBoxResult.Capture = false;

                    listBoxResult.SelectionMode = SelectionMode.MultiExtended;

                    if (selectedIndex != -1)
                        listBoxResult.SetSelected(selectedIndex, true);
                }
                else
                {
                    listBoxResult.SelectionMode = SelectionMode.MultiExtended;
                }

            };

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        public void InitializeStoppingConfiguration()
        {
            Action action = () =>
            {
                buttonStop.Enabled = false;
                labelCondition.Text = "Stopping...";
            };

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryWay = folderBrowserDialog.SelectedPath;
                CopyClick?.Invoke(this, EventArgs.Empty);
            }              
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryWay = folderBrowserDialog.SelectedPath;
                MoveClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {           
                DeleteClick?.Invoke(this, EventArgs.Empty);
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutClick?.Invoke(this, EventArgs.Empty);
        }

        private void startSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartSearchClick?.Invoke(this, EventArgs.Empty);
        }

        private void stopSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopSearchClick?.Invoke(this, EventArgs.Empty);
        }

        private void clearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearClick?.Invoke(this, EventArgs.Empty);
        }

        private void useAllDrivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDrivesClick?.Invoke(this, EventArgs.Empty);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutClick?.Invoke(this, EventArgs.Empty);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            AcceptButton = buttonSearch;
        }

        private void textBoxDirectories_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void textBoxDirectories_Leave(object sender, EventArgs e)
        {
            AcceptButton = buttonSearch;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            textBoxDirectories.Focus();
        }

    }
}
