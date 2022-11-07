using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftOS_TheRevival_CS
{
    public partial class ShiftOSMenu : Form
    {
        public ShiftOSMenu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_StoryMode_Click(object sender, EventArgs e)
        {
            switch (btn_StoryMode.Text) {
                case "Story Mode":
                    btn_StoryMode.Text = "New Game";
                    btn_FreeRoam.Text = "Continue";
                    btn_Aboot.Text = "Back";
                    btn_Exit.Visible = false;
                    break;
                case "New Game":
                    break;
            }
        }

        private void btn_FreeRoam_Click(object sender, EventArgs e)
        {
            switch (btn_FreeRoam.Text)
            {
                case "Free Roam Mode":
                    break;
                case "Continue":
                    break;
            }
        }

        private void btn_Aboot_Click(object sender, EventArgs e)
        {
            switch (btn_Aboot.Text) {
                case "Back":
                    btn_StoryMode.Text = "Story Mode";
                    btn_FreeRoam.Text = "Free Roam Mode";
                    btn_Aboot.Text = "About";
                    btn_Exit.Visible = true;
                    break;
            }
        }
    }
}
