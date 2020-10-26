using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesibilityApplication
{
    public partial class OrdenDePedido : Form
    {
        public OrdenDePedido()
        {
            InitializeComponent();
            SetColorScheme();
            Microsoft.Win32.SystemEvents.UserPreferenceChanged
       += new Microsoft.Win32.UserPreferenceChangedEventHandler(
       this.UserPreferenceChanged);

        }
        public void UserPreferenceChanged(object sender,
Microsoft.Win32.UserPreferenceChangedEventArgs e)
        {
            SetColorScheme();
        }
        private void SetColorScheme()
        {
            if (SystemInformation.HighContrast)
            {
                companyLabel.BackColor = SystemColors.Window;
                companyLabel.ForeColor = SystemColors.WindowText;
            }
            else
            {
                companyLabel.BackColor = Color.Blue;
                companyLabel.ForeColor = Color.Yellow;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
