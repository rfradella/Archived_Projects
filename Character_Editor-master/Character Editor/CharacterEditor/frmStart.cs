using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterEditor
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewCharacter_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart();
          
            frmNewCharacter newChar = new frmNewCharacter();
            start.Visible=false;
            newChar.Show();
           
        }

        private void btnLoadCharacter_Click(object sender, EventArgs e)
        {
            frmLoadCharacter loadCharacter = new frmLoadCharacter();
            loadCharacter.Show();
        }
    }
}
