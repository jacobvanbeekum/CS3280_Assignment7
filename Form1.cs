using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows.Forms;
using System.Threading;

namespace Assignment3
{

    public partial class Form1 : Form
    {
        int numStudents = 0;
        int numAssignments = 0;
        int currStudentIndex = 0;
        int currAssignIndex = 0;
        string textOutput = "";
        string[] studentNames;
        int[,] studentScores;

        public Form1()
        {
            InitializeComponent();
            lockForm();
        }
        

        #region FormLocking
        private void lockForm() 
        {
            firstStudBtn.Enabled = false;
            prevStudBtn.Enabled = false;
            nextStudBtn.Enabled = false;
            lastStudBtn.Enabled = false;
            saveNameBtn.Enabled = false;
            saveScoreBtn.Enabled = false;
            displayScoresBtn.Enabled = false;
            resetScoresBtn.Enabled = false;
            outputFileBtn.Enabled = false;

            studNameTxtBx.Enabled = false;
            assignScoreTxtBx.Enabled = false;
            assignNumTxtBx.Enabled = false;
            scoreDisplayTxtBx.Enabled = false;

            numStudTxtBx.Enabled = true;
            countAssignTxtBx.Enabled = true;
            submitCountsBtn.Enabled = true;

        }

        private void unlockForm()
        {
            firstStudBtn.Enabled = true;
            prevStudBtn.Enabled = true;
            nextStudBtn.Enabled = true;
            lastStudBtn.Enabled = true;
            saveNameBtn.Enabled = true;
            saveScoreBtn.Enabled = true;
            displayScoresBtn.Enabled = true;
            resetScoresBtn.Enabled = true;
            outputFileBtn.Enabled = true;

            studNameTxtBx.Enabled = true;
            assignScoreTxtBx.Enabled = true;
            assignNumTxtBx.Enabled = true;
            scoreDisplayTxtBx.Enabled = true;

            numStudTxtBx.Enabled = false;
            countAssignTxtBx.Enabled = false;
            submitCountsBtn.Enabled = false;
        }
        #endregion


        private void saveScoreBtn_Click(object sender, EventArgs e)
        {
            resetLabels();

            try
            {
                currAssignIndex = Int32.Parse(assignNumTxtBx.Text) - 1;
                studentScores[currStudentIndex, currAssignIndex] = Int32.Parse(assignScoreTxtBx.Text);
                saveScoreSuccessLbl.Text = "Save Successful";
            }
            catch (System.FormatException) 
            {
                scoreEntryLbl.Text = "Must be a valid number";
            }
            catch(System.IndexOutOfRangeException)
            {
                scoreEntryLbl.Text = "Number out of Range";
            }

            assignScoreTxtBx.Text = "";
            assignNumTxtBx.Text = "";
        }

        public void resetLabels()
        {
            scoreEntryLbl.Text = "";
            navErrorLbl.Text = "";
            label6.Text = "";
            saveNameSuccessLbl.Text = "";
            saveScoreSuccessLbl.Text = "";
        }

        private void submitCountsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                numStudents = Int32.Parse(numStudTxtBx.Text);
                numAssignments = Int32.Parse(countAssignTxtBx.Text);

                if (numStudents > 10 || numAssignments > 99)
                {
                    label6.Text = "Max Students: 10; Max Assignments: 99";
                }
                else
                {
                    unlockForm();
                    resetLabels();
                    studentNames = new string[numStudents];
                    studentScores = new int[numStudents, numAssignments]; //[rows, columns]

                    for (int row = 0; row < studentNames.GetLength(0); row++)
                    {
                        studentNames.SetValue("Student #" + (row + 1), row);
                    }

                    for (int row = 0; row < studentScores.GetLength(0); row++)
                    {
                        for (int column = 0; column < studentScores.GetLength(1); column++)
                        {
                            studentScores.SetValue(0, row, column);
                        }
                    }
                    currStudentIndex = 0;
                    studNameTxtBx.Text = studentNames[currStudentIndex];
                }
            }
            catch (System.FormatException) 
            {
                label6.Text = "You must enter a number!";
            }
        }

        private void firstStudBtn_Click(object sender, EventArgs e)
        {
            resetLabels();
            currStudentIndex = 0;
            studNameTxtBx.Text = studentNames[currStudentIndex];
        }

        private void lastStudBtn_Click(object sender, EventArgs e)
        {
            resetLabels();
            currStudentIndex = studentNames.GetLength(0) - 1;
            studNameTxtBx.Text = studentNames[currStudentIndex];
        }

        private void nextStudBtn_Click(object sender, EventArgs e)
        {
            resetLabels();
            currStudentIndex++;

            if (currStudentIndex >= studentNames.GetLength(0))
            {
                currStudentIndex--;
                navErrorLbl.Text = "There are no additional records";
            }
            else
            {
                studNameTxtBx.Text = studentNames[currStudentIndex];
            }
        }

        private void prevStudBtn_Click(object sender, EventArgs e)
        {
            resetLabels();
            currStudentIndex--;

            if (currStudentIndex <= -1)
            {
                currStudentIndex++;
                navErrorLbl.Text = "There are no previous records";
            }
            else
            {
                studNameTxtBx.Text = studentNames[currStudentIndex];
            }
        }

        private void saveNameBtn_Click(object sender, EventArgs e)
        {
            resetLabels();
            if (studNameTxtBx.TextLength < 8 || studNameTxtBx.TextLength > 15)
            {
                saveNameSuccessLbl.Text = "Formatting: 8 < length < 15";
                saveNameSuccessLbl.ForeColor = System.Drawing.Color.Red;
                studNameTxtBx.Text = "";
                studentNames[currStudentIndex] = "";
                return;
            }
            else 
            {
                scoreEntryLbl.Text = "";
                studentNames[currStudentIndex] = studNameTxtBx.Text;
                saveNameSuccessLbl.Text = "Save Successful";
                saveNameSuccessLbl.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void resetScoresBtn_Click(object sender, EventArgs e)
        {
            submitCountsBtn_Click(sender, e);
            scoreDisplayTxtBx.Text = "";
            textOutput = "";
            lockForm();
        }

        private void displayScoresBtn_Click(object sender, EventArgs e)
        {
            scoreDisplayTxtBx.Text = getScoresData(); 
        }

        private string getScoresData()
        {
            scoreDisplayTxtBx.Text = "";
            textOutput = "";
            textOutput = "STUDENT" + "\t" + "\t" + "\t";

            for (int row = 0; row < studentScores.GetLength(1); row++)
            {
                textOutput += "#" + (row + 1) + "\t";
            }
            textOutput += "\n";

            for (int row = 0; row < studentScores.GetLength(0); row++)
            {
                textOutput += studentNames[row] + "\t" + "\t" + "\t";

                for (int column = 0; column < studentScores.GetLength(1); column++)
                {
                    textOutput += studentScores[row, column] + "\t";
                }
                textOutput += "\n";
            }

            return textOutput;

        }

        private void outputFileBtn_Click(object sender, EventArgs e)
        {
            ToggleBtnLbl();
            textOutput = getScoresData();

            Thread thread1 = new Thread(new ThreadStart(OutputFile));
            thread1.Start();
            thread1.Name = "Thread1";
        }

        private void OutputFile()
        {
            OutputFileLogic clsTl = new OutputFileLogic(textOutput);
            clsTl.OutputFile();
            outputFileBtn.Invoke(new DisplayMessageDelegate(ToggleBtnLbl));
        }

        private void ToggleBtnLbl()
        {
            if (outputFileBtn.Enabled == true)
            {
                outputFileBtn.Enabled = false;
                OutputLbl.Text = "Writing to file...";
                OutputLbl.ForeColor = Color.Red;
            }
            else if (outputFileBtn.Enabled == false)
            {
                outputFileBtn.Enabled = true;
                OutputLbl.Text = "Finished writing to file.";
                OutputLbl.ForeColor = Color.Green;
            }

        }

        private delegate void DisplayMessageDelegate();


    }
}
