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
using System.IO;
using System.Reflection;

namespace Assignment3
{
    internal class OutputFileLogic
    {
        /// <summary>
        /// Variables
        /// </summary>
        private string outputData = "";
        StreamWriter myWriter;

        /// <summary>
        /// This is the main constructor for the outputfilelogic class
        /// </summary>
        /// <param name="scoreData"></param>
        public OutputFileLogic(string scoreData)
        {
            try
            {
                outputData = scoreData;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method is called by the main window to output the file.
        /// </summary>
        public void OutputFile()
        {
            try
            {
                string sFile = @"C:\Users\Public\OutputFile.txt";

                if (File.Exists(sFile))
                {
                    var result = MessageBox.Show("You are about to overwrite the existing file.", "", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        File.Delete(sFile);
                        using (myWriter = new StreamWriter(sFile))
                        {
                            myWriter.Write(outputData);
                            //Simulate writing to a large file
                            Thread.Sleep(2000);
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else
                {
                    using (myWriter = new StreamWriter(sFile))
                    {
                        myWriter.Write(outputData);
                        //Simulate writing to a large file
                        Thread.Sleep(2000);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }




        }

        /// <summary>
        /// Error handling function
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }
    }
}
