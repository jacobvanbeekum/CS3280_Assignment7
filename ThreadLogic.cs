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
    internal class ThreadLogic
    {
        private string outputData = "";

        public ThreadLogic(string scoreData)
        {
            outputData = scoreData;
          
        }
        
        public void OutputFile()
        {
            Thread.Sleep(3000);
            System.Windows.Forms.MessageBox.Show(outputData);

        }

    }
}
