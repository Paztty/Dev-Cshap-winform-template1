using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_project1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            this.btnRuntest_Click(btnRuntest, EventArgs.Empty);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void labelActiveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
            {
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width + 20  , Screen.PrimaryScreen.WorkingArea.Height + 17);
                this.WindowState = FormWindowState.Maximized;
            }
                
            
        }


        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(62, 62, 62);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelActiveWindow.Text = currentButton.Text;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private Form currentForm = new Form();
        private void OpenChildForm(Form childForm)
        {
            if (currentForm.Name != childForm.Name)
            {
                
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;
                childForm.FormBorderStyle = FormBorderStyle.None;
                this.panelMainWindow.Controls.Add(childForm);
                currentForm.Hide();
                childForm.Show();
                currentForm = childForm;
                
            }

        }


        private void btnFile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FormFile activateForm = new FormFile();
            OpenChildForm(activateForm);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FormUser activateForm = new FormUser();
            OpenChildForm(activateForm);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FormSetting activateForm = new FormSetting();
            OpenChildForm(activateForm);
        }

        private void btnRuntest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FormRunTest activateForm = new FormRunTest();
            OpenChildForm(activateForm);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FormReport activateForm = new FormReport();
            OpenChildForm(activateForm);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            FormHelp activateForm = new FormHelp();
            OpenChildForm(activateForm);
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            labelActiveWindow.Text = "About Daeyoung Electronic VN";
            DaeyoungInfor activateForm = new DaeyoungInfor();
            OpenChildForm(activateForm);
        }
    }
}
