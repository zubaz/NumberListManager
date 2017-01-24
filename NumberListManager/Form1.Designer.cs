namespace NumberListManager
{
    partial class NumberListManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberListManager));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listNumbers = new System.Windows.Forms.ListBox();
            this.radSorted = new System.Windows.Forms.RadioButton();
            this.radUnsorted = new System.Windows.Forms.RadioButton();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radBinary = new System.Windows.Forms.RadioButton();
            this.radLinear = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMaxLabel = new System.Windows.Forms.Label();
            this.lblEntriesLabel = new System.Windows.Forms.Label();
            this.lblFirstEntryLabel = new System.Windows.Forms.Label();
            this.lblFirstEntry = new System.Windows.Forms.Label();
            this.lblLastEntryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastEntry = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSelectedLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.picBin = new System.Windows.Forms.PictureBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.grpSort.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(356, 425);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(135, 26);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(195, 601);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listNumbers
            // 
            this.listNumbers.FormattingEnabled = true;
            this.listNumbers.Location = new System.Drawing.Point(340, 12);
            this.listNumbers.Name = "listNumbers";
            this.listNumbers.Size = new System.Drawing.Size(172, 407);
            this.listNumbers.TabIndex = 3;
            this.listNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listNumbers_MouseDown);
            // 
            // radSorted
            // 
            this.radSorted.AutoSize = true;
            this.radSorted.Location = new System.Drawing.Point(14, 38);
            this.radSorted.Name = "radSorted";
            this.radSorted.Size = new System.Drawing.Size(56, 17);
            this.radSorted.TabIndex = 4;
            this.radSorted.Text = "Sorted";
            this.radSorted.UseVisualStyleBackColor = true;
            this.radSorted.CheckedChanged += new System.EventHandler(this.radSort_CheckedChanged);
            // 
            // radUnsorted
            // 
            this.radUnsorted.AutoSize = true;
            this.radUnsorted.Checked = true;
            this.radUnsorted.Location = new System.Drawing.Point(14, 88);
            this.radUnsorted.Name = "radUnsorted";
            this.radUnsorted.Size = new System.Drawing.Size(68, 17);
            this.radUnsorted.TabIndex = 5;
            this.radUnsorted.TabStop = true;
            this.radUnsorted.Text = "Unsorted";
            this.radUnsorted.UseVisualStyleBackColor = true;
            this.radUnsorted.CheckedChanged += new System.EventHandler(this.radUnsorted_CheckedChanged);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.radUnsorted);
            this.grpSort.Controls.Add(this.radSorted);
            this.grpSort.Location = new System.Drawing.Point(195, 12);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(132, 127);
            this.grpSort.TabIndex = 6;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sorting";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Enabled = false;
            this.btnShuffle.Location = new System.Drawing.Point(356, 457);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(135, 26);
            this.btnShuffle.TabIndex = 7;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(356, 489);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 26);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(356, 521);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 26);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radBinary);
            this.grpSearch.Controls.Add(this.radLinear);
            this.grpSearch.Location = new System.Drawing.Point(195, 145);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(132, 123);
            this.grpSearch.TabIndex = 10;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // radBinary
            // 
            this.radBinary.AutoSize = true;
            this.radBinary.Location = new System.Drawing.Point(14, 77);
            this.radBinary.Name = "radBinary";
            this.radBinary.Size = new System.Drawing.Size(91, 17);
            this.radBinary.TabIndex = 1;
            this.radBinary.TabStop = true;
            this.radBinary.Text = "Binary Search";
            this.radBinary.UseVisualStyleBackColor = true;
            // 
            // radLinear
            // 
            this.radLinear.AutoSize = true;
            this.radLinear.Checked = true;
            this.radLinear.Location = new System.Drawing.Point(14, 29);
            this.radLinear.Name = "radLinear";
            this.radLinear.Size = new System.Drawing.Size(91, 17);
            this.radLinear.TabIndex = 0;
            this.radLinear.TabStop = true;
            this.radLinear.Text = "Linear Search";
            this.radLinear.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(88, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Empty";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaxLabel
            // 
            this.lblMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxLabel.Location = new System.Drawing.Point(3, 0);
            this.lblMaxLabel.Name = "lblMaxLabel";
            this.lblMaxLabel.Size = new System.Drawing.Size(79, 20);
            this.lblMaxLabel.TabIndex = 13;
            this.lblMaxLabel.Text = "Max Entries";
            this.lblMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntriesLabel
            // 
            this.lblEntriesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntriesLabel.Location = new System.Drawing.Point(3, 20);
            this.lblEntriesLabel.Name = "lblEntriesLabel";
            this.lblEntriesLabel.Size = new System.Drawing.Size(79, 20);
            this.lblEntriesLabel.TabIndex = 14;
            this.lblEntriesLabel.Text = "Entries";
            this.lblEntriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstEntryLabel
            // 
            this.lblFirstEntryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstEntryLabel.Location = new System.Drawing.Point(3, 40);
            this.lblFirstEntryLabel.Name = "lblFirstEntryLabel";
            this.lblFirstEntryLabel.Size = new System.Drawing.Size(79, 20);
            this.lblFirstEntryLabel.TabIndex = 15;
            this.lblFirstEntryLabel.Text = "First Entry";
            this.lblFirstEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstEntry
            // 
            this.lblFirstEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstEntry.Location = new System.Drawing.Point(88, 40);
            this.lblFirstEntry.Name = "lblFirstEntry";
            this.lblFirstEntry.Size = new System.Drawing.Size(80, 20);
            this.lblFirstEntry.TabIndex = 16;
            this.lblFirstEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastEntryLabel
            // 
            this.lblLastEntryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastEntryLabel.Location = new System.Drawing.Point(3, 60);
            this.lblLastEntryLabel.Name = "lblLastEntryLabel";
            this.lblLastEntryLabel.Size = new System.Drawing.Size(79, 20);
            this.lblLastEntryLabel.TabIndex = 17;
            this.lblLastEntryLabel.Text = "Last Entry";
            this.lblLastEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(88, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "30";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastEntry
            // 
            this.lblLastEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastEntry.Location = new System.Drawing.Point(88, 60);
            this.lblLastEntry.Name = "lblLastEntry";
            this.lblLastEntry.Size = new System.Drawing.Size(80, 20);
            this.lblLastEntry.TabIndex = 19;
            this.lblLastEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.tableLayout);
            this.grpStatus.Location = new System.Drawing.Point(3, 12);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(186, 127);
            this.grpStatus.TabIndex = 20;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "List Status";
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.lblStatus, 1, 1);
            this.tableLayout.Controls.Add(this.lblSelected, 1, 4);
            this.tableLayout.Controls.Add(this.lblMaxLabel, 0, 0);
            this.tableLayout.Controls.Add(this.lblLastEntry, 1, 3);
            this.tableLayout.Controls.Add(this.lblSelectedLabel, 0, 4);
            this.tableLayout.Controls.Add(this.label1, 1, 0);
            this.tableLayout.Controls.Add(this.lblFirstEntry, 1, 2);
            this.tableLayout.Controls.Add(this.lblEntriesLabel, 0, 1);
            this.tableLayout.Controls.Add(this.lblFirstEntryLabel, 0, 2);
            this.tableLayout.Controls.Add(this.lblLastEntryLabel, 0, 3);
            this.tableLayout.Location = new System.Drawing.Point(9, 19);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 5;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout.Size = new System.Drawing.Size(171, 102);
            this.tableLayout.TabIndex = 25;
            // 
            // lblSelected
            // 
            this.lblSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelected.Location = new System.Drawing.Point(88, 80);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(80, 22);
            this.lblSelected.TabIndex = 21;
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectedLabel
            // 
            this.lblSelectedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedLabel.Location = new System.Drawing.Point(3, 80);
            this.lblSelectedLabel.Name = "lblSelectedLabel";
            this.lblSelectedLabel.Size = new System.Drawing.Size(79, 22);
            this.lblSelectedLabel.TabIndex = 20;
            this.lblSelectedLabel.Text = "Selected";
            this.lblSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 38);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 230);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 38);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(129, 145);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(60, 41);
            this.txtSearch.TabIndex = 23;
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(129, 230);
            this.txtInsert.Multiline = true;
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(60, 38);
            this.txtInsert.TabIndex = 24;
            // 
            // picBin
            // 
            this.picBin.Image = ((System.Drawing.Image)(resources.GetObject("picBin.Image")));
            this.picBin.Location = new System.Drawing.Point(227, 274);
            this.picBin.Name = "picBin";
            this.picBin.Size = new System.Drawing.Size(100, 134);
            this.picBin.TabIndex = 25;
            this.picBin.TabStop = false;
            this.picBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.picBin_DragDrop);
            this.picBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.picBin_DragEnter);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(373, 637);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(173, 18);
            this.lblCopyRight.TabIndex = 26;
            this.lblCopyRight.Text = "© Liam Jones 2016-2017";
            // 
            // NumberListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 653);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.picBin);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.listNumbers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumberListManager";
            this.Text = "Number List Manager";
            this.Load += new System.EventHandler(this.NumberListManager_Load);
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listNumbers;
        private System.Windows.Forms.RadioButton radSorted;
        private System.Windows.Forms.RadioButton radUnsorted;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton radBinary;
        private System.Windows.Forms.RadioButton radLinear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMaxLabel;
        private System.Windows.Forms.Label lblEntriesLabel;
        private System.Windows.Forms.Label lblFirstEntryLabel;
        private System.Windows.Forms.Label lblFirstEntry;
        private System.Windows.Forms.Label lblLastEntryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastEntry;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblSelectedLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.PictureBox picBin;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

