using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.ViewLayer.Commands
{
    public interface ICommand
    {
        void Execute(); 
    }
}
