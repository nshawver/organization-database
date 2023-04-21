using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationDatabase
{
    public partial class FormMainMenu : Form
    {

        // Fields
        private Button currentButton;
        private Form activeForm;

        // Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false; // Disables the default control box around the form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Imports the drag and drop feature
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // ActivateButton function styles the button that was last activated
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(251, 137, 55);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = Color.FromArgb(186, 103, 43);
                    btnCloseChildForm.Visible = true;   // Sets the button to close the child form as visible, it is off by default
                }
            }
        }

        // DisableButton function resets the style of the previously active button to default
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(58, 87, 126);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        // OpenChildForm function is what displays the child form for each of the tabs when clicked
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelHomePanel.Controls.Add(childForm);
            this.panelHomePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // When the Organizations button is clicked, it opens the Organization child form
        private void btnOrgs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrganizations(), sender);
        }

        // When the Volunteers button is clicked, it opens the Volunteer child form
        private void btnVols_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVolunteers(), sender);

        }

        // When the Staff button is clicked, it opens the Staff child form
        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStaff(), sender);

        }

        // When the Donors button is clicked, it opens the Donor child form
        private void btnDonors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDonors(), sender);

        }

        // When the Exit button is clicked, it closes the app
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // When the X button at the top is clicked, it closes the current child form and returns to the home page
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        // Reset function is what styles the home page back to default when no child form is open
        private void Reset()
        {
            DisableButton();
            panelTitle.BackColor = Color.FromArgb(58, 87, 126);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        // Allows for drag and drop in the event of a mouse down on the title bar
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Closes the app when the red X button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Maximizes the window when the blue circle button is clicked, if the it is not already
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // Minimizes the window when the yellow - button is clicked
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
