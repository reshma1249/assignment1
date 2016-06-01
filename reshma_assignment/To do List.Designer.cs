namespace reshma_assignment
{
    partial class list
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
            this.lblList = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkBoxList = new System.Windows.Forms.CheckedListBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxList = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("SketchFlow Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(193, 34);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(159, 29);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "To Do List";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem,
            this.menuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClose});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(37, 20);
            this.menuItem.Text = "File";
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(97, 22);
            this.menuItemClose.Text = "Quit";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAuthor});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(52, 20);
            this.menuAbout.Text = "About";
            // 
            // menuItemAuthor
            // 
            this.menuItemAuthor.Name = "menuItemAuthor";
            this.menuItemAuthor.Size = new System.Drawing.Size(111, 22);
            this.menuItemAuthor.Text = "Author";
            this.menuItemAuthor.Click += new System.EventHandler(this.menuItemAuthor_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("SketchFlow Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(144, 23);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // chkBoxList
            // 
            this.chkBoxList.FormattingEnabled = true;
            this.chkBoxList.Location = new System.Drawing.Point(16, 88);
            this.chkBoxList.Name = "chkBoxList";
            this.chkBoxList.Size = new System.Drawing.Size(516, 154);
            this.chkBoxList.TabIndex = 3;
            this.chkBoxList.SelectedIndexChanged += new System.EventHandler(this.chkBoxList_SelectedIndexChanged);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(12, 284);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(477, 24);
            this.lblNew.TabIndex = 4;
            this.lblNew.Text = "New Item description(Click add to add a new item)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(457, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save items";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxList
            // 
            this.txtBoxList.Location = new System.Drawing.Point(16, 321);
            this.txtBoxList.Name = "txtBoxList";
            this.txtBoxList.Size = new System.Drawing.Size(516, 20);
            this.txtBoxList.TabIndex = 8;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusVersion,
            this.statusCheck,
            this.statusCount});
            this.statusBar.Location = new System.Drawing.Point(0, 362);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(570, 22);
            this.statusBar.TabIndex = 9;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusVersion
            // 
            this.statusVersion.Name = "statusVersion";
            this.statusVersion.Size = new System.Drawing.Size(64, 17);
            this.statusVersion.Text = "Version 3.0";
            // 
            // statusCheck
            // 
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(373, 17);
            this.statusCheck.Spring = true;
            this.statusCheck.Text = "toolStripStatusLabel2";
            // 
            // statusCount
            // 
            this.statusCount.Name = "statusCount";
            this.statusCount.Size = new System.Drawing.Size(118, 17);
            this.statusCount.Text = "toolStripStatusLabel3";
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 384);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.txtBoxList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.chkBoxList);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To do List";
            this.Load += new System.EventHandler(this.list_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemAuthor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckedListBox chkBoxList;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxList;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusVersion;
        private System.Windows.Forms.ToolStripStatusLabel statusCheck;
        private System.Windows.Forms.ToolStripStatusLabel statusCount;
    }
}

