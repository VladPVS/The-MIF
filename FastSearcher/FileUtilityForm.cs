using System;
using System.Windows.Forms;

namespace MIF
{
    public partial class FileUtilityForm : Form, IFileUtilityForm
    {
        private bool canClose;

        public string ProcessStatus
        {
            set
            {
                Action action = () => labelProcessedAmount.Text = value;

                if (!InvokeRequired)
                    action();
                else
                    Invoke(action);          
            }
        }


        public string OperationName
        {
            set
            {
                Action action = () => labelOperation.Text = value;

                if (!InvokeRequired)
                {
                    action();
                }
                else
                {
                    Invoke(action);
                }
            }
        }


        public string Caption
        {
            set
            {
                Action action = () => labelCaption.Text = value;

                if (!InvokeRequired)
                {
                    action();
                }
                else
                {
                    Invoke(action);
                }
            }
        }


        public FileUtilityForm()
        {
            InitializeComponent();

            canClose = false;
        }

        public event EventHandler FormShown;

        public event EventHandler ClosedClick;


        private void FileUtilityForm_Shown(object sender, EventArgs e)
        {
            FormShown?.Invoke(this, EventArgs.Empty);
        }

        public void InitializeStartConfiguration()
        {
            Action action = () =>
            {
                buttonClose.Enabled = false;
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

        public void InitializeFinishConfiguration()
        {
            Action action = () =>
            {
                buttonClose.Enabled = true;
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


        private void buttonClose_Click(object sender, EventArgs e)
        {
            canClose = true;
            ClosedClick?.Invoke(this, EventArgs.Empty);
            this.Close();
        }


        public void AddProcessedFile(string fileName)
        {
            Action action = () =>
            {
                listBoxResult.Items.Add(fileName);
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


        private void FileUtilityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose)
                e.Cancel = true;
        }
    }
}
