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
            if (mTabConrtol.TabCount > 1)
            {
                int newIndex = mTabConrtol.SelectedIndex - 1;
                if (newIndex < 0)
                    newIndex = 0;
                mTabConrtol.TabPages.Remove(mTabConrtol.SelectedTab);
                mTabConrtol.SelectedIndex = newIndex;
            }
        }
    }
}
