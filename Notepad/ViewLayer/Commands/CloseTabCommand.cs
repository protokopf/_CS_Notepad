using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.ViewLayer.Commands
{
    class CloseTabCommand : ICommand
    {
        private TabControl mTabConrtol;

        public CloseTabCommand(TabControl tabControl)
        {
            mTabConrtol = tabControl;
        }

        public void Execute()
        {
            mTabConrtol.TabPages.Remove(mTabConrtol.SelectedTab);
        }
    }
}
