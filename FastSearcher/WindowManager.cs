using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MIF
{
    class WindowManager: IWindowManager
    {
        private FileUtilityForm fileUtilityForm;

        private AboutForm aboutForm;

        public void ShowAboutBoxForm()
        {
            aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        public void ShowFileUtilityForm(MainPresenter presenter)
        {
            fileUtilityForm = new FileUtilityForm();
            
            presenter.FileUtilityFormView = fileUtilityForm;
            fileUtilityForm.TopLevel = true;
            fileUtilityForm.Show();
        }
    }
}
