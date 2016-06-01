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
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Text = mInnerText;

            TabPage page = new TabPage(String.Format("new {0}", mTabControl.Controls.Count.ToString()));
            page.Controls.Add(richTextBox);

            mTabControl.TabPages.Add(page);
            mTabControl.SelectedTab = page;
        }
    }
}
