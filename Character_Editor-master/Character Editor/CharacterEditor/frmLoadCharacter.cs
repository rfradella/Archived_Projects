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
    public partial class frmLoadCharacter : Form
    {
        public frmLoadCharacter()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int counter = 0; //used for changing the description

            string[] description = { "Character Name: ", "HP: ", "MP: ", "Shield: ", "Armor: " };

            OpenFileDialog openFileDialog = new OpenFileDialog() ;              
            if (openFileDialog.ShowDialog() == DialogResult.OK)             //Select character file
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);

                for (int i = 0; i < description.Count(); i++) {         //Iterate through and match descriptions to values                    
                        lblCharacterInfo.Text += description[counter];      //Description
                        lblCharacterInfo.Text+=(sr.ReadLine())+"\r\n";      //Read next line
                        counter++;                                          //used for changing the description
                }           
                sr.Close();
            }
        }
    }
}
