namespace AchievementDependencyCreator
{
    partial class AchievementDependencyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.buttonLoadDepData = new System.Windows.Forms.Button();
            this.buttonCurrentData = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.listViewAchievement = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDesc = new System.Windows.Forms.ColumnHeader();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxAchSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.listViewCurrentDep = new System.Windows.Forms.ListView();
            this.columnHeaderLName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLDesc = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTargetDep = new System.Windows.Forms.ListView();
            this.columnHeaderTName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTDesc = new System.Windows.Forms.ColumnHeader();
            this.textBoxCurrentDepSearch = new System.Windows.Forms.TextBox();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.buttonLoadDepData);
            this.groupBoxData.Controls.Add(this.buttonCurrentData);
            this.groupBoxData.Controls.Add(this.buttonLoadData);
            this.groupBoxData.Controls.Add(this.buttonSaveData);
            this.groupBoxData.Location = new System.Drawing.Point(1196, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(181, 156);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // buttonLoadDepData
            // 
            this.buttonLoadDepData.Location = new System.Drawing.Point(7, 51);
            this.buttonLoadDepData.Name = "buttonLoadDepData";
            this.buttonLoadDepData.Size = new System.Drawing.Size(169, 23);
            this.buttonLoadDepData.TabIndex = 0;
            this.buttonLoadDepData.Text = "Load Dependency data";
            this.buttonLoadDepData.UseVisualStyleBackColor = true;
            this.buttonLoadDepData.Click += new System.EventHandler(this.buttonLoadDepData_Click);
            // 
            // buttonCurrentData
            // 
            this.buttonCurrentData.Location = new System.Drawing.Point(6, 127);
            this.buttonCurrentData.Name = "buttonCurrentData";
            this.buttonCurrentData.Size = new System.Drawing.Size(169, 23);
            this.buttonCurrentData.TabIndex = 1;
            this.buttonCurrentData.Text = "Save current dependency";
            this.buttonCurrentData.UseVisualStyleBackColor = true;
            this.buttonCurrentData.Click += new System.EventHandler(this.buttonCurrentData_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(6, 22);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(169, 23);
            this.buttonLoadData.TabIndex = 0;
            this.buttonLoadData.Text = "Load Achievement data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(6, 98);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(169, 23);
            this.buttonSaveData.TabIndex = 1;
            this.buttonSaveData.Text = "Save data";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // listViewAchievement
            // 
            this.listViewAchievement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDesc});
            this.listViewAchievement.FullRowSelect = true;
            this.listViewAchievement.HideSelection = false;
            this.listViewAchievement.Location = new System.Drawing.Point(12, 33);
            this.listViewAchievement.MultiSelect = false;
            this.listViewAchievement.Name = "listViewAchievement";
            this.listViewAchievement.Size = new System.Drawing.Size(550, 404);
            this.listViewAchievement.TabIndex = 2;
            this.listViewAchievement.UseCompatibleStateImageBehavior = false;
            this.listViewAchievement.View = System.Windows.Forms.View.Details;
            this.listViewAchievement.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAchievement_ItemSelectionChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Name = "columnHeaderName";
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 140;
            // 
            // columnHeaderDesc
            // 
            this.columnHeaderDesc.Name = "columnHeaderDesc";
            this.columnHeaderDesc.Text = "Description";
            this.columnHeaderDesc.Width = 400;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(996, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Search Value";
            this.textBoxSearch.Size = new System.Drawing.Size(194, 23);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxAchSearch
            // 
            this.textBoxAchSearch.Location = new System.Drawing.Point(368, 5);
            this.textBoxAchSearch.Name = "textBoxAchSearch";
            this.textBoxAchSearch.PlaceholderText = "Search Value";
            this.textBoxAchSearch.Size = new System.Drawing.Size(194, 23);
            this.textBoxAchSearch.TabIndex = 3;
            this.textBoxAchSearch.TextChanged += new System.EventHandler(this.textBoxAchSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Achievement and their dependencies";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(640, 12);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(129, 15);
            this.labelTarget.TabIndex = 4;
            this.labelTarget.Text = "Target Dependency List";
            // 
            // listViewCurrentDep
            // 
            this.listViewCurrentDep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLName,
            this.columnHeaderLDesc});
            this.listViewCurrentDep.FullRowSelect = true;
            this.listViewCurrentDep.HideSelection = false;
            this.listViewCurrentDep.Location = new System.Drawing.Point(640, 269);
            this.listViewCurrentDep.MultiSelect = false;
            this.listViewCurrentDep.Name = "listViewCurrentDep";
            this.listViewCurrentDep.Size = new System.Drawing.Size(550, 169);
            this.listViewCurrentDep.TabIndex = 2;
            this.listViewCurrentDep.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentDep.View = System.Windows.Forms.View.Details;
            this.listViewCurrentDep.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewCurrentDep_ItemSelectionChanged);
            this.listViewCurrentDep.DoubleClick += new System.EventHandler(this.listViewCurrentDep_DoubleClick);
            this.listViewCurrentDep.Leave += new System.EventHandler(this.listViewCurrentDep_Leave);
            // 
            // columnHeaderLName
            // 
            this.columnHeaderLName.Name = "columnHeaderLName";
            this.columnHeaderLName.Text = "Name";
            this.columnHeaderLName.Width = 150;
            // 
            // columnHeaderLDesc
            // 
            this.columnHeaderLDesc.Name = "columnHeaderLDesc";
            this.columnHeaderLDesc.Text = "Description";
            this.columnHeaderLDesc.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Dependency List";
            // 
            // listViewTargetDep
            // 
            this.listViewTargetDep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTName,
            this.columnHeaderTDesc});
            this.listViewTargetDep.FullRowSelect = true;
            this.listViewTargetDep.HideSelection = false;
            this.listViewTargetDep.Location = new System.Drawing.Point(640, 33);
            this.listViewTargetDep.MultiSelect = false;
            this.listViewTargetDep.Name = "listViewTargetDep";
            this.listViewTargetDep.Size = new System.Drawing.Size(550, 199);
            this.listViewTargetDep.TabIndex = 2;
            this.listViewTargetDep.UseCompatibleStateImageBehavior = false;
            this.listViewTargetDep.View = System.Windows.Forms.View.Details;
            this.listViewTargetDep.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewTargetDep_ItemSelectionChanged);
            this.listViewTargetDep.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            this.listViewTargetDep.Leave += new System.EventHandler(this.listViewTargetDep_Leave);
            // 
            // columnHeaderTName
            // 
            this.columnHeaderTName.Name = "columnHeaderTName";
            this.columnHeaderTName.Text = "Name";
            this.columnHeaderTName.Width = 150;
            // 
            // columnHeaderTDesc
            // 
            this.columnHeaderTDesc.Name = "columnHeaderTDesc";
            this.columnHeaderTDesc.Text = "Description";
            this.columnHeaderTDesc.Width = 400;
            // 
            // textBoxCurrentDepSearch
            // 
            this.textBoxCurrentDepSearch.Location = new System.Drawing.Point(996, 243);
            this.textBoxCurrentDepSearch.Name = "textBoxCurrentDepSearch";
            this.textBoxCurrentDepSearch.PlaceholderText = "Search Value";
            this.textBoxCurrentDepSearch.Size = new System.Drawing.Size(194, 23);
            this.textBoxCurrentDepSearch.TabIndex = 3;
            this.textBoxCurrentDepSearch.TextChanged += new System.EventHandler(this.textBoxCurrentDepSearch_TextChanged);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(1196, 189);
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Log.Size = new System.Drawing.Size(181, 249);
            this.Log.TabIndex = 5;
            this.Log.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1196, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log";
            // 
            // AchievementDependencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCurrentDepSearch);
            this.Controls.Add(this.listViewCurrentDep);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAchSearch);
            this.Controls.Add(this.listViewTargetDep);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewAchievement);
            this.Controls.Add(this.groupBoxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AchievementDependencyForm";
            this.Text = "Achievement Dependency Creator";
            this.groupBoxData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.ListView listViewAchievement;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDesc;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxAchSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ListView listViewCurrentDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTargetDep;
        private System.Windows.Forms.TextBox textBoxCurrentDepSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderLName;
        private System.Windows.Forms.ColumnHeader columnHeaderLDesc;
        private System.Windows.Forms.ColumnHeader columnHeaderTName;
        private System.Windows.Forms.ColumnHeader columnHeaderTDesc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonCurrentData;
        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadDepData;
    }
}

