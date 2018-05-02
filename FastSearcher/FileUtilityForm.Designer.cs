namespace MIF
{
    partial class FileUtilityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileUtilityForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.panelCount = new System.Windows.Forms.Panel();
            this.labelProcessedAmount = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.labelCaption = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxOperation.SuspendLayout();
            this.panelCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(321, 245);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.groupBoxOperation);
            this.groupBoxMain.Controls.Add(this.labelCaption);
            this.groupBoxMain.Controls.Add(this.listBoxResult);
            this.groupBoxMain.Location = new System.Drawing.Point(16, 11);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(380, 218);
            this.groupBoxMain.TabIndex = 15;
            this.groupBoxMain.TabStop = false;
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.panelCount);
            this.groupBoxOperation.Controls.Add(this.labelOperation);
            this.groupBoxOperation.Location = new System.Drawing.Point(18, 19);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(345, 37);
            this.groupBoxOperation.TabIndex = 20;
            this.groupBoxOperation.TabStop = false;
            // 
            // panelCount
            // 
            this.panelCount.Controls.Add(this.labelProcessedAmount);
            this.panelCount.Location = new System.Drawing.Point(210, 10);
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(129, 22);
            this.panelCount.TabIndex = 21;
            // 
            // labelProcessedAmount
            // 
            this.labelProcessedAmount.AutoSize = true;
            this.labelProcessedAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelProcessedAmount.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessedAmount.Location = new System.Drawing.Point(84, 0);
            this.labelProcessedAmount.Name = "labelProcessedAmount";
            this.labelProcessedAmount.Size = new System.Drawing.Size(45, 22);
            this.labelProcessedAmount.TabIndex = 13;
            this.labelProcessedAmount.Text = "X / Y";
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperation.Location = new System.Drawing.Point(3, 13);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(68, 18);
            this.labelOperation.TabIndex = 20;
            this.labelOperation.Text = "Copied";
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaption.Location = new System.Drawing.Point(16, 66);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(64, 16);
            this.labelCaption.TabIndex = 16;
            this.labelCaption.Text = "Caption";
            // 
            // listBoxResult
            // 
            this.listBoxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(18, 88);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxResult.Size = new System.Drawing.Size(345, 108);
            this.listBoxResult.TabIndex = 15;
            // 
            // FileUtilityForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(412, 286);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileUtilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The MIF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileUtilityForm_FormClosing);
            this.Shown += new System.EventHandler(this.FileUtilityForm_Shown);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            this.panelCount.ResumeLayout(false);
            this.panelCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.Panel panelCount;
        private System.Windows.Forms.Label labelProcessedAmount;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}