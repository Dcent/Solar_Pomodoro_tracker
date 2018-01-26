using System;
using System.Linq;
using System.Windows.Forms;
using LuxaforSharp;
using Solar_Pomodoro.Core.Models;

namespace Pomodro_lux
{
    public partial class MainView : Form
    {
        private IDevice device = null;
        PreloadedColors colors = new PreloadedColors();

        public MainView()
        {
            IDeviceList listOfDevices = new DeviceList();
            listOfDevices.Scan();
            device = listOfDevices.First();
            InitializeComponent();
            
            colorsBox.DataSource = new BindingSource(colors.ColorsMap, null);
            colorsBox.DisplayMember = "Key";
            colorsBox.ValueMember = "Value";

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
           // string s = colorsBox.SelectedValue;


            device?.SetColor(LedTarget.AllFrontSide, (Color) colorsBox.SelectedValue); // Immediatly switches all leds to picked color
            //device?.SetColor(LedTarget.AllBackSide, new Color(G, R, B)); // Immediatly switches all leds to picked color
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
