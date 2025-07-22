using StardewModpackManager.common;
using StardewModpackManager.services;
using StardewModpackManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewModpackManager
{
    public partial class MainFormcs : Form
    {
        private bool isDragging = false;
        private List<Panel> wizardPanelPages = new List<Panel>();
        private int wizardPanelPageIndex = 0;
        private Point lastCursor;
        private Point lastFormLocation;
        public MainFormcs()
        {
            InitializeComponent();
        }

        private void MainFormcs_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MainFormcs loaded successfully.");
            Form form = FindForm();
            CommonUtils.DefaultForm(form);

            // Attach mouse events to the title bar panel  
            panelTitleBar.MouseUp += panelTitleBar_MouseUp!;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown!;
            panelTitleBar.MouseMove += panelTitleBar_MouseMove!;

            // Set initial colors for a dark theme  
            form.BackColor = Color.FromArgb(30, 30, 30); // Dark background for the main form  
            panelTitleBar.BackColor = Color.FromArgb(20, 20, 20); // Slightly darker for title bar  

            // Set main form button locations
            SetButtonLocation();

            /********************** Initial Logic **********************/
            // Checks XML file if it exists within data folder, otherwise it creates it
            XmlService xmlService = new XmlService();
            string xmlPathCreated = xmlService.CreateXmlFileIfNotExists();

            // Checks if Wizard is complete. If value doesnt exist, it will add to it and set it to false
            bool isWizardComplete = IsWizardComplete(xmlService, xmlPathCreated);

            if (!isWizardComplete)
            {
                xmlService.AddXMLKeyValue(xmlPathCreated, "userProfile", "isWizardComplete", "false");

                CommonUtils.DefaultPanel(wizardPanel_pg1);
                CenterPanel(wizardPanel_pg1);
                wizardPanel_pg1.Show();
                wizardPanelPageIndex = GetIndexOfPanel(wizardPanel_pg1);
                // Add the wizard panel to the list of pages
                wizardPanelPages.Add(wizardPanel_pg1);
            }
            else
            {
                wizardPanel_pg1.Hide();
            }

        }

        private void panelTitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastFormLocation = this.Location;
            }
        }

        private void panelTitleBar_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = Cursor.Position.X - lastCursor.X;
                int dy = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastFormLocation.X + dx, lastFormLocation.Y + dy);
            }
        }

        private void panelTitleBar_MouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        // Event handlers for control buttons  
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                panelTitleBar.Width = GetFormSize(FormSize.Width);
                panelTitleBar.Height = 61; // Set a fixed height for the title bar
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            SetButtonLocation();
            CenterPanel(wizardPanelPages[wizardPanelPageIndex]);
        }

        private int GetFormSize(FormSize formSize)
        {
            // Get the current size of the form  
            Size size = this.Size;
            return formSize == FormSize.Width ? size.Width : size.Height;
        }

        private void SetButtonLocation()
        {
            // Gets form
            Form form = FindForm();

            // Define spacing between buttons
            int buttonSpacing = 10;

            // Calculate the total width of all buttons and spacings
            int totalButtonsWidth = closeBtn.Width + maximizeRestoreBtn.Width + minimizeBtn.Width + (buttonSpacing * 2);

            // Start placing buttons from the right edge
            int startX = form.Size.Width - totalButtonsWidth;
            int y = 32; // Keep your desired Y position

            minimizeBtn.Location = new Point(startX, y);
            maximizeRestoreBtn.Location = new Point(startX + minimizeBtn.Width + buttonSpacing, y);
            closeBtn.Location = new Point(startX + minimizeBtn.Width + maximizeRestoreBtn.Width + (buttonSpacing * 2), y);
        }
        
        private static bool IsWizardComplete(XmlService xmlService, string xmlPathCreated)
        {
            try
            {
                string isWizardComplete = xmlService.GetXMLKeyValue(xmlPathCreated, "isWizardComplete");
                if (bool.TryParse(isWizardComplete, out bool result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Failed to parse isWizardComplete value from XML.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking if wizard is complete: {ex.Message}");
                xmlService.AddXMLKeyValue(xmlPathCreated, "userProfile", "isWizardComplete", "false");
                return true;
            }
        }

        private void CenterPanel(Panel panel)
        {
            // Center the panel within the form  
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
        }

        private int GetIndexOfPanel(Panel panel)
        {
            // tab index will start from 1, so we subtract 1 to get the index
            return panel.TabIndex - 1;
        }

        private void NextPageOfPanel(int currentIndex)
        {
            wizardPanelPages[wizardPanelPageIndex].Hide();
            wizardPanelPageIndex++;
            wizardPanelPages[wizardPanelPageIndex].Show();
        }

    }
}
