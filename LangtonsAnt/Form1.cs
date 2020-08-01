using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangtonsAnt
{
    public partial class FormAnt : Form
    {
        int[,] antArray;
        int antXPos;
        int antYPos;

        public FormAnt()
        {
            InitializeComponent();

            initaliseAnt();
        }

        private void btnStartStopAnt_Click(object sender, EventArgs e)
        {
            if (timerAnt.Enabled == true)
            {
                timerAnt.Enabled = false;
                btnStartStopAnt.Text = "Start Ant";
            }
            else
            {
                timerAnt.Enabled = true;
                btnStartStopAnt.Text = "Stop Ant";
            }
        }

        private void timerAnt_Tick(object sender, EventArgs e)
        {
            updateAnt();
        }

        private void panelAntCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGrahpics = e.Graphics;
        }

        private void updateAnt()
        {
            panelAntCanvas.Update();
        }

        private void initaliseAnt()
        {
            // We should never called when the ant is running but to be sure
            if (timerAnt.Enabled == true)
            {
                timerAnt.Enabled = false;
            }

            // Reset internal ant state
            antArray = new int[99,99];
            for (int x = 0; x < 100; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    antArray[x, y] = 0;
                }
            }

            antXPos = 50;
            antYPos = 50;

            // Reset ant display
        }
    }
}
