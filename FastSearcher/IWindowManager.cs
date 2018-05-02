using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIF
{
    interface IWindowManager
    {
        void ShowFileUtilityForm(MainPresenter presenter);
        void ShowAboutBoxForm();
    }
}
