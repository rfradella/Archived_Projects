using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CharacterEditor
{
    public partial class frmNewCharacter : Form
    {
        public frmNewCharacter()
        {
            
            InitializeComponent();
        }

        private void frmNewCharacter_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] line = { txtCharacterName.Text, txtHP.Text, txtMP.Text, txtShield.Text, txtArmor.Text }; //Get text values and shove them in an array
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Ray F\Desktop\"+txtCharacterName.Text+".txt");  //write unique files to the desktop and attach .txt to the end

            for (int i = 0; i < line.Count(); i++)
            {
                file.WriteLine(line[i]);            //write the lines
            }            

            file.Close();
        }

        private void btnChangeSave_Click(object sender, EventArgs e)
        {
           
        }
    }
}
