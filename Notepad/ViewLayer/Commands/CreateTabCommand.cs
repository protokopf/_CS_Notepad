using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.ViewLayer.Commands
{
    class CreateTabCommand : ICommand
    {
        private string mInnerText;
        private TabControl mTabControl;

        public CreateTabCommand(TabControl tab, string text)
        {
            mTabControl = tab;
            mInnerText = text;
        }
        public void Execute()
        {
            TabPage page = new TabPage(String.Format("new {0}",mTabControl.Controls.Count.ToString()));
            page.Controls.Add(new RichTextBox());
            page.Controls[0].Dock = DockStyle.Fill;
            page.Controls[0].Text = mInnerText;
            mTabControl.TabPages.Add(page);
        }
    }
}
