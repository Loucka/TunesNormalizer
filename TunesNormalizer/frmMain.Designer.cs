
namespace TunesNormalizer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTunesDirectory = new System.Windows.Forms.Panel();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.textTunesDirectory = new System.Windows.Forms.TextBox();
            this.labelTunesDirectory = new System.Windows.Forms.Label();
            this.buttonBeginNormalization = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panelTunesDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.Controls.Add(this.panelTunesDirectory);
            this.panelMain.Controls.Add(this.buttonBeginNormalization);
            this.panelMain.Controls.Add(this.labelProgress);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(569, 88);
            this.panelMain.TabIndex = 0;
            // 
            // panelTunesDirectory
            // 
            this.panelTunesDirectory.AutoSize = true;
            this.panelTunesDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTunesDirectory.Controls.Add(this.buttonSelectDirectory);
            this.panelTunesDirectory.Controls.Add(this.textTunesDirectory);
            this.panelTunesDirectory.Controls.Add(this.labelTunesDirectory);
            this.panelTunesDirectory.Location = new System.Drawing.Point(3, 3);
            this.panelTunesDirectory.Name = "panelTunesDirectory";
            this.panelTunesDirectory.Size = new System.Drawing.Size(558, 29);
            this.panelTunesDirectory.TabIndex = 0;
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(434, 3);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(121, 23);
            this.buttonSelectDirectory.TabIndex = 2;
            this.buttonSelectDirectory.Text = "Select Directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // textTunesDirectory
            // 
            this.textTunesDirectory.Location = new System.Drawing.Point(97, 5);
            this.textTunesDirectory.Name = "textTunesDirectory";
            this.textTunesDirectory.Size = new System.Drawing.Size(331, 20);
            this.textTunesDirectory.TabIndex = 1;
            this.textTunesDirectory.TextChanged += new System.EventHandler(this.textTunesDirectory_TextChanged);
            // 
            // labelTunesDirectory
            // 
            this.labelTunesDirectory.AutoSize = true;
            this.labelTunesDirectory.Location = new System.Drawing.Point(6, 8);
            this.labelTunesDirectory.Name = "labelTunesDirectory";
            this.labelTunesDirectory.Size = new System.Drawing.Size(85, 13);
            this.labelTunesDirectory.TabIndex = 0;
            this.labelTunesDirectory.Text = "Tunes Directory:";
            // 
            // buttonBeginNormalization
            // 
            this.buttonBeginNormalization.Enabled = false;
            this.buttonBeginNormalization.Location = new System.Drawing.Point(3, 38);
            this.buttonBeginNormalization.Name = "buttonBeginNormalization";
            this.buttonBeginNormalization.Size = new System.Drawing.Size(121, 23);
            this.buttonBeginNormalization.TabIndex = 3;
            this.buttonBeginNormalization.Text = "Begin Normalization";
            this.buttonBeginNormalization.UseVisualStyleBackColor = true;
            this.buttonBeginNormalization.Click += new System.EventHandler(this.buttonBeginNormalization_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(3, 64);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(48, 13);
            this.labelProgress.TabIndex = 0;
            this.labelProgress.Text = "Progress";
            this.labelProgress.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(569, 88);
            this.Controls.Add(this.panelMain);
            this.Name = "frmMain";
            this.Text = "Tunes Normalizer";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTunesDirectory.ResumeLayout(false);
            this.panelTunesDirectory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private System.Windows.Forms.Panel panelTunesDirectory;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.TextBox textTunesDirectory;
        private System.Windows.Forms.Label labelTunesDirectory;
        private System.Windows.Forms.Button buttonBeginNormalization;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Timer timer;
    }
}

