namespace Rename_Series
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCurrent = new System.Windows.Forms.ListBox();
            this.lstPreview = new System.Windows.Forms.ListBox();
            this.lstTypes = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatch1 = new System.Windows.Forms.TextBox();
            this.txtReplace1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdPreview = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdUndo = new System.Windows.Forms.Button();
            this.txtReplace2 = new System.Windows.Forms.TextBox();
            this.txtMatch2 = new System.Windows.Forms.TextBox();
            this.txtReplace3 = new System.Windows.Forms.TextBox();
            this.txtMatch3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Directory";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(18, 33);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(683, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowse.Location = new System.Drawing.Point(707, 31);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstCurrent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstPreview, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 227);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current File Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preview Renamed File Names";
            // 
            // lstCurrent
            // 
            this.lstCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCurrent.FormattingEnabled = true;
            this.lstCurrent.IntegralHeight = false;
            this.lstCurrent.Location = new System.Drawing.Point(3, 16);
            this.lstCurrent.Name = "lstCurrent";
            this.lstCurrent.Size = new System.Drawing.Size(376, 208);
            this.lstCurrent.TabIndex = 2;
            // 
            // lstPreview
            // 
            this.lstPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPreview.FormattingEnabled = true;
            this.lstPreview.IntegralHeight = false;
            this.lstPreview.Location = new System.Drawing.Point(385, 16);
            this.lstPreview.Name = "lstPreview";
            this.lstPreview.Size = new System.Drawing.Size(376, 208);
            this.lstPreview.TabIndex = 3;
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.IntegralHeight = false;
            this.lstTypes.Location = new System.Drawing.Point(15, 311);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(132, 79);
            this.lstTypes.TabIndex = 4;
            this.lstTypes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstTypes_ItemCheck);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "File Types To Process";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Match This Pattern";
            // 
            // txtMatch1
            // 
            this.txtMatch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatch1.Location = new System.Drawing.Point(153, 312);
            this.txtMatch1.Name = "txtMatch1";
            this.txtMatch1.Size = new System.Drawing.Size(222, 20);
            this.txtMatch1.TabIndex = 7;
            // 
            // txtReplace1
            // 
            this.txtReplace1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReplace1.Location = new System.Drawing.Point(381, 312);
            this.txtReplace1.Name = "txtReplace1";
            this.txtReplace1.Size = new System.Drawing.Size(244, 20);
            this.txtReplace1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Replace With This";
            // 
            // cmdPreview
            // 
            this.cmdPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdPreview.Location = new System.Drawing.Point(631, 310);
            this.cmdPreview.Name = "cmdPreview";
            this.cmdPreview.Size = new System.Drawing.Size(75, 23);
            this.cmdPreview.TabIndex = 10;
            this.cmdPreview.Text = "Compute";
            this.cmdPreview.UseVisualStyleBackColor = true;
            this.cmdPreview.Click += new System.EventHandler(this.cmdPreview_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(153, 406);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(467, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(626, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdUndo
            // 
            this.cmdUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdUndo.Enabled = false;
            this.cmdUndo.Location = new System.Drawing.Point(707, 406);
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(75, 23);
            this.cmdUndo.TabIndex = 13;
            this.cmdUndo.Text = "Undo";
            this.cmdUndo.UseVisualStyleBackColor = true;
            this.cmdUndo.Click += new System.EventHandler(this.cmdUndo_Click);
            // 
            // txtReplace2
            // 
            this.txtReplace2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReplace2.Location = new System.Drawing.Point(381, 338);
            this.txtReplace2.Name = "txtReplace2";
            this.txtReplace2.Size = new System.Drawing.Size(244, 20);
            this.txtReplace2.TabIndex = 15;
            // 
            // txtMatch2
            // 
            this.txtMatch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatch2.Location = new System.Drawing.Point(153, 338);
            this.txtMatch2.Name = "txtMatch2";
            this.txtMatch2.Size = new System.Drawing.Size(222, 20);
            this.txtMatch2.TabIndex = 14;
            // 
            // txtReplace3
            // 
            this.txtReplace3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReplace3.Location = new System.Drawing.Point(381, 364);
            this.txtReplace3.Name = "txtReplace3";
            this.txtReplace3.Size = new System.Drawing.Size(244, 20);
            this.txtReplace3.TabIndex = 17;
            // 
            // txtMatch3
            // 
            this.txtMatch3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatch3.Location = new System.Drawing.Point(153, 364);
            this.txtMatch3.Name = "txtMatch3";
            this.txtMatch3.Size = new System.Drawing.Size(222, 20);
            this.txtMatch3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.txtReplace3);
            this.Controls.Add(this.txtMatch3);
            this.Controls.Add(this.txtReplace2);
            this.Controls.Add(this.txtMatch2);
            this.Controls.Add(this.cmdUndo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmdPreview);
            this.Controls.Add(this.txtReplace1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMatch1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstTypes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(816, 490);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCurrent;
        private System.Windows.Forms.ListBox lstPreview;
        private System.Windows.Forms.CheckedListBox lstTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatch1;
        private System.Windows.Forms.TextBox txtReplace1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdPreview;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdUndo;
        private System.Windows.Forms.TextBox txtReplace2;
        private System.Windows.Forms.TextBox txtMatch2;
        private System.Windows.Forms.TextBox txtReplace3;
        private System.Windows.Forms.TextBox txtMatch3;
    }
}

