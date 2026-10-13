namespace DataLogging
{
    partial class DataLogging
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
            DrawButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            ButtonGroupBox = new GroupBox();
            DisplayPictureBox = new PictureBox();
            TopMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ButtonStatusStrip = new StatusStrip();
            ButtonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            TopMenu.SuspendLayout();
            SuspendLayout();
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(26, 26);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(140, 58);
            DrawButton.TabIndex = 0;
            DrawButton.Text = "Draw";
            DrawButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(172, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(140, 58);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(318, 26);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(140, 58);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(DrawButton);
            ButtonGroupBox.Location = new Point(550, 361);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(489, 97);
            ButtonGroupBox.TabIndex = 3;
            ButtonGroupBox.TabStop = false;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaptionText;
            DisplayPictureBox.Location = new Point(0, 35);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(1051, 250);
            DisplayPictureBox.TabIndex = 4;
            DisplayPictureBox.TabStop = false;
            // 
            // TopMenu
            // 
            TopMenu.ImageScalingSize = new Size(20, 20);
            TopMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new Size(1051, 28);
            TopMenu.TabIndex = 5;
            TopMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // ButtonStatusStrip
            // 
            ButtonStatusStrip.ImageScalingSize = new Size(20, 20);
            ButtonStatusStrip.Location = new Point(0, 461);
            ButtonStatusStrip.Name = "ButtonStatusStrip";
            ButtonStatusStrip.Size = new Size(1051, 22);
            ButtonStatusStrip.TabIndex = 6;
            ButtonStatusStrip.Text = "ButtonStatusStrip";
            // 
            // DataLogging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 483);
            Controls.Add(ButtonStatusStrip);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(TopMenu);
            MainMenuStrip = TopMenu;
            Name = "DataLogging";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataLogging";
            ButtonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DrawButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox ButtonGroupBox;
        private PictureBox DisplayPictureBox;
        private MenuStrip TopMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip ButtonStatusStrip;
    }
}
