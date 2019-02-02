/*
 * EXERCISE............: Exercise 10.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP.....: 2º Interface Development 
 * PROJECT.............: Forms III. Serial Port and DLL
 * DATE................: 30 Jan 2019
 */


using Microsoft.Win32;
using System.Windows.Forms;
using FormUtilities;

namespace Exercise10
{
    public partial class frmAbout : Form
    {
        #region constructor
        public frmAbout()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.CenterToParent();
            lblCounter.Text = Options.GetRegKey(@"SOFTWARE\P10", "Uses");
        }
        #endregion
    }
}
