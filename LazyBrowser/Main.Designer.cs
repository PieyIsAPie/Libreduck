namespace LazyBrowser
{
    partial class Main
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
            this.CefPanel = new System.Windows.Forms.Panel();
            this.forwardButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.addressBarPanel = new System.Windows.Forms.Panel();
            this.baseWinPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addressBarPanel.SuspendLayout();
            this.baseWinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CefPanel
            // 
            this.CefPanel.Location = new System.Drawing.Point(3, 42);
            this.CefPanel.Name = "CefPanel";
            this.CefPanel.Size = new System.Drawing.Size(794, 405);
            this.CefPanel.TabIndex = 0;
            // 
            // forwardButton
            // 
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Location = new System.Drawing.Point(25, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(22, 23);
            this.forwardButton.TabIndex = 0;
            this.forwardButton.Text = ">";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Location = new System.Drawing.Point(46, 3);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(22, 23);
            this.reloadButton.TabIndex = 1;
            this.reloadButton.Text = "r";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(22, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addressBar
            // 
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Location = new System.Drawing.Point(74, 3);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(603, 20);
            this.addressBar.TabIndex = 3;
            // 
            // addressBarPanel
            // 
            this.addressBarPanel.Controls.Add(this.addressBar);
            this.addressBarPanel.Controls.Add(this.backButton);
            this.addressBarPanel.Controls.Add(this.forwardButton);
            this.addressBarPanel.Controls.Add(this.reloadButton);
            this.addressBarPanel.Location = new System.Drawing.Point(2, 2);
            this.addressBarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBarPanel.Name = "addressBarPanel";
            this.addressBarPanel.Size = new System.Drawing.Size(679, 32);
            this.addressBarPanel.TabIndex = 0;
            // 
            // baseWinPanel
            // 
            this.baseWinPanel.ColumnCount = 1;
            this.baseWinPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseWinPanel.Controls.Add(this.addressBarPanel, 0, 0);
            this.baseWinPanel.Controls.Add(this.CefPanel, 0, 1);
            this.baseWinPanel.Location = new System.Drawing.Point(1, 0);
            this.baseWinPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseWinPanel.Name = "baseWinPanel";
            this.baseWinPanel.RowCount = 2;
            this.baseWinPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.67052F));
            this.baseWinPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.32948F));
            this.baseWinPanel.Size = new System.Drawing.Size(800, 450);
            this.baseWinPanel.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baseWinPanel);
            this.Name = "Main";
            this.Text = "Form1";
            this.addressBarPanel.ResumeLayout(false);
            this.addressBarPanel.PerformLayout();
            this.baseWinPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CefPanel;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Panel addressBarPanel;
        private System.Windows.Forms.TableLayoutPanel baseWinPanel;
    }
}

