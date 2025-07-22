namespace StardewModpackManager
{
    partial class MainFormcs
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// Required method for Designer support - do not modify
        private void InitializeComponent()
        {
            panelTitleBar = new Panel();
            mainFormLabel = new Label();
            maximizeRestoreBtn = new Button();
            minimizeBtn = new Button();
            closeBtn = new Button();
            wizardPanel_pg1 = new Panel();
            wizardPanel_label_pg1 = new Label();
            setupWizardImg = new PictureBox();
            panelTitleBar.SuspendLayout();
            wizardPanel_pg1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setupWizardImg).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(mainFormLabel);
            panelTitleBar.Controls.Add(maximizeRestoreBtn);
            panelTitleBar.Controls.Add(minimizeBtn);
            panelTitleBar.Controls.Add(closeBtn);
            panelTitleBar.Location = new Point(-7, -30);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1325, 61);
            panelTitleBar.TabIndex = 0;
            // 
            // mainFormLabel
            // 
            mainFormLabel.AutoSize = true;
            mainFormLabel.ForeColor = Color.White;
            mainFormLabel.Location = new Point(596, 36);
            mainFormLabel.Name = "mainFormLabel";
            mainFormLabel.Size = new Size(177, 15);
            mainFormLabel.TabIndex = 4;
            mainFormLabel.Text = "StardewModpackManager";
            // 
            // maximizeRestoreBtn
            // 
            maximizeRestoreBtn.BackgroundImage = Properties.Resources.icons8_expand_collapse;
            maximizeRestoreBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maximizeRestoreBtn.FlatAppearance.BorderSize = 0;
            maximizeRestoreBtn.FlatStyle = FlatStyle.Flat;
            maximizeRestoreBtn.Location = new Point(1174, 37);
            maximizeRestoreBtn.Name = "maximizeRestoreBtn";
            maximizeRestoreBtn.Size = new Size(24, 24);
            maximizeRestoreBtn.TabIndex = 3;
            maximizeRestoreBtn.UseVisualStyleBackColor = true;
            maximizeRestoreBtn.Click += btnMaximizeRestore_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackgroundImage = Properties.Resources.icons8_minimize;
            minimizeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Location = new Point(1090, 37);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(24, 24);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = Properties.Resources.icons8_close;
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(1257, 37);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(24, 24);
            closeBtn.TabIndex = 1;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // wizardPanel_pg1
            // 
            wizardPanel_pg1.Controls.Add(wizardPanel_label_pg1);
            wizardPanel_pg1.Controls.Add(setupWizardImg);
            wizardPanel_pg1.Location = new Point(25, 60);
            wizardPanel_pg1.Name = "wizardPanel_pg1";
            wizardPanel_pg1.Size = new Size(1249, 529);
            wizardPanel_pg1.TabIndex = 1;
            // 
            // wizardPanel_label_pg1
            // 
            wizardPanel_label_pg1.ForeColor = Color.White;
            wizardPanel_label_pg1.Location = new Point(425, 290);
            wizardPanel_label_pg1.MaximumSize = new Size(400, 200);
            wizardPanel_label_pg1.Name = "wizardPanel_label_pg1";
            wizardPanel_label_pg1.Size = new Size(400, 200);
            wizardPanel_label_pg1.TabIndex = 1;
            wizardPanel_label_pg1.Text = "It looks like the wizard has not set up yet! Set up with the wizard in order to use Stardew Modpack Manager.";
            // 
            // setupWizardImg
            // 
            setupWizardImg.Image = Properties.Resources.programWizard;
            setupWizardImg.InitialImage = Properties.Resources.programWizard;
            setupWizardImg.Location = new Point(485, 13);
            setupWizardImg.Name = "setupWizardImg";
            setupWizardImg.Size = new Size(256, 256);
            setupWizardImg.SizeMode = PictureBoxSizeMode.StretchImage;
            setupWizardImg.TabIndex = 0;
            setupWizardImg.TabStop = false;
            setupWizardImg.WaitOnLoad = true;
            // 
            // MainFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1310, 656);
            Controls.Add(wizardPanel_pg1);
            Controls.Add(panelTitleBar);
            Font = new Font("Arial Rounded MT Bold", 8.830189F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainFormcs";
            Text = "MainFormcs";
            Load += MainFormcs_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            wizardPanel_pg1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)setupWizardImg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitleBar;
        private Button maximizeRestoreBtn;
        private Button minimizeBtn;
        private Button closeBtn;
        private Label mainFormLabel;
        private Panel wizardPanel_pg1;
        private PictureBox setupWizardImg;
        private Label wizardPanel_label_pg1;
    }
}