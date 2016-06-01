using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.ModelLayer.LayerBlocks
{
    class File
    {
        private string fileName;
        private string filePath;
        private string fileText;

        public File(string path, string text)
        {

        }

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }
        public string FilePath
        {
            get
            {
                return filePath;
            }

            set
            {
                filePath = value;
            }
        }
        public string FileText
        {
            get
            {
                return fileText;
            }

            set
            {
                fileText = value;
            }
        }
    }
}
