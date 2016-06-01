using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad.ViewLayer.Commands;

namespace Notepad.ViewLayer.Forms
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void toolStripNewFile_Click(object sender, EventArgs e)
        {
            ICommand command = new CreateTabCommand(this.tabControl, "blablablab");
            command.Execute();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
