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
        private string mCaption;
        private TabControl mTabControl;

        public CreateTabCommand(TabControl tab, string text, string caption)
        {
            mCaption = caption;
            mTabControl = tab;
            mInnerText = text;
        }
        public void Execute()
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Text = mInnerText;

            TabPage page = new TabPage(mCaption);
            page.Controls.Add(richTextBox);

            mTabControl.TabPages.Add(page);
            mTabControl.SelectedTab = page;
        }
    }
}
