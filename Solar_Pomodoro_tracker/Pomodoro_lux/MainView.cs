using System;
using System.Linq;
using System.Windows.Forms;
using LuxaforSharp;

namespace Pomodro_lux
{
    public partial class Form1 : Form
    {
        private IDevice device = null;

        public Form1()
        {
            IDeviceList listOfDevices = new DeviceList();
            listOfDevices.Scan();
            device = listOfDevices.First();
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            byte R = byte.Parse(colorR.Text);
            byte G = byte.Parse(colorG.Text);
            byte B = byte.Parse(colorB.Text);

            device?.SetColor(LedTarget.AllFrontSide, new Color(R, G, B)); // Immediatly switches all leds to picked color
            device?.SetColor(LedTarget.AllBackSide, new Color(G, R, B)); // Immediatly switches all leds to picked color
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            device?.SetColor(LedTarget.All, new Color(0, 0, 0)); // Immediatly switches all leds to picked color
            device?.Dispose();
        }

        private void pomodoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pomodoroPanel.Visible = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pomodoroPanel.Visible = false;
        }
    }
}
