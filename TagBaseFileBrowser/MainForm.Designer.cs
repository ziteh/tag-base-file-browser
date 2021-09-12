﻿namespace TagBaseFileBrowser
{
    partial class MainForm
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.treeViewTags = new System.Windows.Forms.TreeView();
            this.listViewObjs = new System.Windows.Forms.ListView();
            this.textBoxObjInfo = new System.Windows.Forms.TextBox();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.buttonSelectObj = new System.Windows.Forms.Button();
            this.buttonClearTags = new System.Windows.Forms.Button();
            this.buttonWriteObj = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonWriteAndClear = new System.Windows.Forms.Button();
            this.buttonClearFile = new System.Windows.Forms.Button();
            this.textBoxSelectedTags = new System.Windows.Forms.TextBox();
            this.textBoxSelectedObjs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // textBoxPath
            //
            this.textBoxPath.Location = new System.Drawing.Point(13, 13);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(253, 25);
            this.textBoxPath.TabIndex = 0;
            //
            // buttonLoad
            //
            this.buttonLoad.Location = new System.Drawing.Point(273, 14);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            //
            // treeViewTags
            //
            this.treeViewTags.Location = new System.Drawing.Point(13, 45);
            this.treeViewTags.Name = "treeViewTags";
            this.treeViewTags.Size = new System.Drawing.Size(222, 436);
            this.treeViewTags.TabIndex = 2;
            this.treeViewTags.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTags_AfterSelect);
            //
            // listViewObjs
            //
            this.listViewObjs.HideSelection = false;
            this.listViewObjs.Location = new System.Drawing.Point(241, 45);
            this.listViewObjs.Name = "listViewObjs";
            this.listViewObjs.Size = new System.Drawing.Size(508, 346);
            this.listViewObjs.TabIndex = 3;
            this.listViewObjs.UseCompatibleStateImageBehavior = false;
            this.listViewObjs.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewObjs_ItemSelectionChanged);
            this.listViewObjs.DoubleClick += new System.EventHandler(this.listViewObjs_DoubleClick);
            //
            // textBoxObjInfo
            //
            this.textBoxObjInfo.Location = new System.Drawing.Point(241, 397);
            this.textBoxObjInfo.Multiline = true;
            this.textBoxObjInfo.Name = "textBoxObjInfo";
            this.textBoxObjInfo.ReadOnly = true;
            this.textBoxObjInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxObjInfo.Size = new System.Drawing.Size(508, 84);
            this.textBoxObjInfo.TabIndex = 4;
            //
            // buttonAddTag
            //
            this.buttonAddTag.Location = new System.Drawing.Point(765, 231);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTag.TabIndex = 5;
            this.buttonAddTag.Text = "Add Tag";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            //
            // buttonSelectObj
            //
            this.buttonSelectObj.Location = new System.Drawing.Point(765, 45);
            this.buttonSelectObj.Name = "buttonSelectObj";
            this.buttonSelectObj.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectObj.TabIndex = 6;
            this.buttonSelectObj.Text = "Select Obj";
            this.buttonSelectObj.UseVisualStyleBackColor = true;
            this.buttonSelectObj.Click += new System.EventHandler(this.buttonSelectFile_Click);
            //
            // buttonClearTags
            //
            this.buttonClearTags.Location = new System.Drawing.Point(867, 231);
            this.buttonClearTags.Name = "buttonClearTags";
            this.buttonClearTags.Size = new System.Drawing.Size(75, 23);
            this.buttonClearTags.TabIndex = 9;
            this.buttonClearTags.Text = "Clear Tag";
            this.buttonClearTags.UseVisualStyleBackColor = true;
            this.buttonClearTags.Click += new System.EventHandler(this.buttonClearTags_Click);
            //
            // buttonWriteObj
            //
            this.buttonWriteObj.Location = new System.Drawing.Point(765, 397);
            this.buttonWriteObj.Name = "buttonWriteObj";
            this.buttonWriteObj.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteObj.TabIndex = 10;
            this.buttonWriteObj.Text = "Write";
            this.buttonWriteObj.UseVisualStyleBackColor = true;
            this.buttonWriteObj.Click += new System.EventHandler(this.buttonWriteObj_Click);
            //
            // buttonOpenFile
            //
            this.buttonOpenFile.Location = new System.Drawing.Point(856, 45);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 11;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            //
            // buttonWriteAndClear
            //
            this.buttonWriteAndClear.Location = new System.Drawing.Point(867, 397);
            this.buttonWriteAndClear.Name = "buttonWriteAndClear";
            this.buttonWriteAndClear.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteAndClear.TabIndex = 12;
            this.buttonWriteAndClear.Text = "Weite&Clear";
            this.buttonWriteAndClear.UseVisualStyleBackColor = true;
            this.buttonWriteAndClear.Click += new System.EventHandler(this.buttonWriteAndClear_Click);
            //
            // buttonClearFile
            //
            this.buttonClearFile.Location = new System.Drawing.Point(856, 13);
            this.buttonClearFile.Name = "buttonClearFile";
            this.buttonClearFile.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFile.TabIndex = 13;
            this.buttonClearFile.Text = "Clear File";
            this.buttonClearFile.UseVisualStyleBackColor = true;
            this.buttonClearFile.Click += new System.EventHandler(this.buttonClearFile_Click);
            //
            // textBoxSelectedTags
            //
            this.textBoxSelectedTags.Location = new System.Drawing.Point(765, 269);
            this.textBoxSelectedTags.Multiline = true;
            this.textBoxSelectedTags.Name = "textBoxSelectedTags";
            this.textBoxSelectedTags.ReadOnly = true;
            this.textBoxSelectedTags.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSelectedTags.Size = new System.Drawing.Size(166, 122);
            this.textBoxSelectedTags.TabIndex = 14;
            //
            // textBoxSelectedObjs
            //
            this.textBoxSelectedObjs.Location = new System.Drawing.Point(768, 74);
            this.textBoxSelectedObjs.Multiline = true;
            this.textBoxSelectedObjs.Name = "textBoxSelectedObjs";
            this.textBoxSelectedObjs.ReadOnly = true;
            this.textBoxSelectedObjs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSelectedObjs.Size = new System.Drawing.Size(163, 126);
            this.textBoxSelectedObjs.TabIndex = 14;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 508);
            this.Controls.Add(this.textBoxSelectedObjs);
            this.Controls.Add(this.textBoxSelectedTags);
            this.Controls.Add(this.buttonClearFile);
            this.Controls.Add(this.buttonWriteAndClear);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonWriteObj);
            this.Controls.Add(this.buttonClearTags);
            this.Controls.Add(this.buttonSelectObj);
            this.Controls.Add(this.buttonAddTag);
            this.Controls.Add(this.textBoxObjInfo);
            this.Controls.Add(this.listViewObjs);
            this.Controls.Add(this.treeViewTags);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxPath);
            this.Name = "MainForm";
            this.Text = "Hierarchical Tag File Browser";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TreeView treeViewTags;
        private System.Windows.Forms.ListView listViewObjs;
        private System.Windows.Forms.TextBox textBoxObjInfo;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.Button buttonSelectObj;
        private System.Windows.Forms.Button buttonClearTags;
        private System.Windows.Forms.Button buttonWriteObj;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonWriteAndClear;
        private System.Windows.Forms.Button buttonClearFile;
        private System.Windows.Forms.TextBox textBoxSelectedTags;
        private System.Windows.Forms.TextBox textBoxSelectedObjs;
    }
}