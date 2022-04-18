namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.countAssignTxtBx = new System.Windows.Forms.TextBox();
            this.numStudTxtBx = new System.Windows.Forms.TextBox();
            this.submitCountsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastStudBtn = new System.Windows.Forms.Button();
            this.nextStudBtn = new System.Windows.Forms.Button();
            this.prevStudBtn = new System.Windows.Forms.Button();
            this.firstStudBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studNameTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveNameBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.scoreEntryLbl = new System.Windows.Forms.Label();
            this.assignScoreTxtBx = new System.Windows.Forms.TextBox();
            this.assignNumTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveScoreBtn = new System.Windows.Forms.Button();
            this.displayScoresBtn = new System.Windows.Forms.Button();
            this.scoreDisplayTxtBx = new System.Windows.Forms.RichTextBox();
            this.resetScoresBtn = new System.Windows.Forms.Button();
            this.navErrorLbl = new System.Windows.Forms.Label();
            this.saveNameSuccessLbl = new System.Windows.Forms.Label();
            this.saveScoreSuccessLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.countAssignTxtBx);
            this.groupBox1.Controls.Add(this.numStudTxtBx);
            this.groupBox1.Controls.Add(this.submitCountsBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(207, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // countAssignTxtBx
            // 
            this.countAssignTxtBx.Location = new System.Drawing.Point(143, 57);
            this.countAssignTxtBx.Name = "countAssignTxtBx";
            this.countAssignTxtBx.Size = new System.Drawing.Size(58, 20);
            this.countAssignTxtBx.TabIndex = 11;
            // 
            // numStudTxtBx
            // 
            this.numStudTxtBx.Location = new System.Drawing.Point(143, 25);
            this.numStudTxtBx.Name = "numStudTxtBx";
            this.numStudTxtBx.Size = new System.Drawing.Size(58, 20);
            this.numStudTxtBx.TabIndex = 10;
            // 
            // submitCountsBtn
            // 
            this.submitCountsBtn.Location = new System.Drawing.Point(248, 34);
            this.submitCountsBtn.Name = "submitCountsBtn";
            this.submitCountsBtn.Size = new System.Drawing.Size(100, 31);
            this.submitCountsBtn.TabIndex = 4;
            this.submitCountsBtn.Text = "Submit Counts";
            this.submitCountsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.submitCountsBtn.UseVisualStyleBackColor = true;
            this.submitCountsBtn.Click += new System.EventHandler(this.submitCountsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of assignments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of students:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastStudBtn);
            this.groupBox2.Controls.Add(this.nextStudBtn);
            this.groupBox2.Controls.Add(this.prevStudBtn);
            this.groupBox2.Controls.Add(this.firstStudBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // lastStudBtn
            // 
            this.lastStudBtn.Location = new System.Drawing.Point(366, 33);
            this.lastStudBtn.Name = "lastStudBtn";
            this.lastStudBtn.Size = new System.Drawing.Size(100, 31);
            this.lastStudBtn.TabIndex = 3;
            this.lastStudBtn.Text = "Last Student >>";
            this.lastStudBtn.UseVisualStyleBackColor = true;
            this.lastStudBtn.Click += new System.EventHandler(this.lastStudBtn_Click);
            // 
            // nextStudBtn
            // 
            this.nextStudBtn.Location = new System.Drawing.Point(249, 33);
            this.nextStudBtn.Name = "nextStudBtn";
            this.nextStudBtn.Size = new System.Drawing.Size(100, 31);
            this.nextStudBtn.TabIndex = 2;
            this.nextStudBtn.Text = "Next Student >";
            this.nextStudBtn.UseVisualStyleBackColor = true;
            this.nextStudBtn.Click += new System.EventHandler(this.nextStudBtn_Click);
            // 
            // prevStudBtn
            // 
            this.prevStudBtn.Location = new System.Drawing.Point(130, 33);
            this.prevStudBtn.Name = "prevStudBtn";
            this.prevStudBtn.Size = new System.Drawing.Size(100, 31);
            this.prevStudBtn.TabIndex = 1;
            this.prevStudBtn.Text = "< Prev Student";
            this.prevStudBtn.UseVisualStyleBackColor = true;
            this.prevStudBtn.Click += new System.EventHandler(this.prevStudBtn_Click);
            // 
            // firstStudBtn
            // 
            this.firstStudBtn.Location = new System.Drawing.Point(17, 33);
            this.firstStudBtn.Name = "firstStudBtn";
            this.firstStudBtn.Size = new System.Drawing.Size(100, 31);
            this.firstStudBtn.TabIndex = 0;
            this.firstStudBtn.Text = "<< First Student";
            this.firstStudBtn.UseVisualStyleBackColor = true;
            this.firstStudBtn.Click += new System.EventHandler(this.firstStudBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studNameTxtBx);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.saveNameBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // studNameTxtBx
            // 
            this.studNameTxtBx.Location = new System.Drawing.Point(91, 31);
            this.studNameTxtBx.Name = "studNameTxtBx";
            this.studNameTxtBx.Size = new System.Drawing.Size(203, 20);
            this.studNameTxtBx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student #1:";
            // 
            // saveNameBtn
            // 
            this.saveNameBtn.Location = new System.Drawing.Point(334, 29);
            this.saveNameBtn.Name = "saveNameBtn";
            this.saveNameBtn.Size = new System.Drawing.Size(75, 23);
            this.saveNameBtn.TabIndex = 1;
            this.saveNameBtn.Text = "Save Name";
            this.saveNameBtn.UseVisualStyleBackColor = true;
            this.saveNameBtn.Click += new System.EventHandler(this.saveNameBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.scoreEntryLbl);
            this.groupBox4.Controls.Add(this.assignScoreTxtBx);
            this.groupBox4.Controls.Add(this.assignNumTxtBx);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.saveScoreBtn);
            this.groupBox4.Location = new System.Drawing.Point(12, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Info";
            // 
            // scoreEntryLbl
            // 
            this.scoreEntryLbl.AutoSize = true;
            this.scoreEntryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scoreEntryLbl.Location = new System.Drawing.Point(365, 46);
            this.scoreEntryLbl.Name = "scoreEntryLbl";
            this.scoreEntryLbl.Size = new System.Drawing.Size(0, 13);
            this.scoreEntryLbl.TabIndex = 8;
            // 
            // assignScoreTxtBx
            // 
            this.assignScoreTxtBx.Location = new System.Drawing.Point(183, 59);
            this.assignScoreTxtBx.Name = "assignScoreTxtBx";
            this.assignScoreTxtBx.Size = new System.Drawing.Size(58, 20);
            this.assignScoreTxtBx.TabIndex = 9;
            // 
            // assignNumTxtBx
            // 
            this.assignNumTxtBx.Location = new System.Drawing.Point(183, 25);
            this.assignNumTxtBx.Name = "assignNumTxtBx";
            this.assignNumTxtBx.Size = new System.Drawing.Size(58, 20);
            this.assignNumTxtBx.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Assignment Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Assignment Number (1-5):";
            // 
            // saveScoreBtn
            // 
            this.saveScoreBtn.Location = new System.Drawing.Point(282, 41);
            this.saveScoreBtn.Name = "saveScoreBtn";
            this.saveScoreBtn.Size = new System.Drawing.Size(75, 23);
            this.saveScoreBtn.TabIndex = 0;
            this.saveScoreBtn.Text = "Save Score";
            this.saveScoreBtn.UseVisualStyleBackColor = true;
            this.saveScoreBtn.Click += new System.EventHandler(this.saveScoreBtn_Click);
            // 
            // displayScoresBtn
            // 
            this.displayScoresBtn.Location = new System.Drawing.Point(280, 391);
            this.displayScoresBtn.Name = "displayScoresBtn";
            this.displayScoresBtn.Size = new System.Drawing.Size(93, 33);
            this.displayScoresBtn.TabIndex = 4;
            this.displayScoresBtn.Text = "Display Scores";
            this.displayScoresBtn.UseVisualStyleBackColor = true;
            this.displayScoresBtn.Click += new System.EventHandler(this.displayScoresBtn_Click);
            // 
            // scoreDisplayTxtBx
            // 
            this.scoreDisplayTxtBx.Location = new System.Drawing.Point(12, 430);
            this.scoreDisplayTxtBx.Name = "scoreDisplayTxtBx";
            this.scoreDisplayTxtBx.Size = new System.Drawing.Size(749, 140);
            this.scoreDisplayTxtBx.TabIndex = 5;
            this.scoreDisplayTxtBx.Text = "";
            // 
            // resetScoresBtn
            // 
            this.resetScoresBtn.Location = new System.Drawing.Point(466, 30);
            this.resetScoresBtn.Name = "resetScoresBtn";
            this.resetScoresBtn.Size = new System.Drawing.Size(88, 47);
            this.resetScoresBtn.TabIndex = 6;
            this.resetScoresBtn.Text = "Reset Scores";
            this.resetScoresBtn.UseVisualStyleBackColor = true;
            this.resetScoresBtn.Click += new System.EventHandler(this.resetScoresBtn_Click);
            // 
            // navErrorLbl
            // 
            this.navErrorLbl.AutoSize = true;
            this.navErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navErrorLbl.Location = new System.Drawing.Point(509, 162);
            this.navErrorLbl.Name = "navErrorLbl";
            this.navErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.navErrorLbl.TabIndex = 7;
            // 
            // saveNameSuccessLbl
            // 
            this.saveNameSuccessLbl.AutoSize = true;
            this.saveNameSuccessLbl.ForeColor = System.Drawing.Color.Green;
            this.saveNameSuccessLbl.Location = new System.Drawing.Point(508, 243);
            this.saveNameSuccessLbl.Name = "saveNameSuccessLbl";
            this.saveNameSuccessLbl.Size = new System.Drawing.Size(0, 13);
            this.saveNameSuccessLbl.TabIndex = 8;
            // 
            // saveScoreSuccessLbl
            // 
            this.saveScoreSuccessLbl.AutoSize = true;
            this.saveScoreSuccessLbl.ForeColor = System.Drawing.Color.Green;
            this.saveScoreSuccessLbl.Location = new System.Drawing.Point(509, 339);
            this.saveScoreSuccessLbl.Name = "saveScoreSuccessLbl";
            this.saveScoreSuccessLbl.Size = new System.Drawing.Size(0, 13);
            this.saveScoreSuccessLbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 573);
            this.Controls.Add(this.saveScoreSuccessLbl);
            this.Controls.Add(this.saveNameSuccessLbl);
            this.Controls.Add(this.navErrorLbl);
            this.Controls.Add(this.resetScoresBtn);
            this.Controls.Add(this.scoreDisplayTxtBx);
            this.Controls.Add(this.displayScoresBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Scores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lastStudBtn;
        private System.Windows.Forms.Button nextStudBtn;
        private System.Windows.Forms.Button prevStudBtn;
        private System.Windows.Forms.Button firstStudBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button displayScoresBtn;
        private System.Windows.Forms.RichTextBox scoreDisplayTxtBx;
        private System.Windows.Forms.Button resetScoresBtn;
        private System.Windows.Forms.TextBox countAssignTxtBx;
        private System.Windows.Forms.TextBox numStudTxtBx;
        private System.Windows.Forms.Button submitCountsBtn;
        private System.Windows.Forms.TextBox studNameTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveNameBtn;
        private System.Windows.Forms.TextBox assignScoreTxtBx;
        private System.Windows.Forms.TextBox assignNumTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveScoreBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label navErrorLbl;
        private System.Windows.Forms.Label scoreEntryLbl;
        private System.Windows.Forms.Label saveNameSuccessLbl;
        private System.Windows.Forms.Label saveScoreSuccessLbl;
    }
}

