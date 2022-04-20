using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment3
{
    internal class OutputFileLogic
    {
        private string outputData = "";

        public OutputFileLogic(string scoreData)
        {
            outputData = scoreData;
        }
        
        public void OutputFile()
        {
            //Simulate writing to a large file
            Thread.Sleep(10000);
        }


    }
}
