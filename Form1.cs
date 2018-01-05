using oyun.Enums;
using oyun.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string player;
        public CharacterType playerType;
 
        
        private void button1_Click(object sender, EventArgs e)
        {
            player = txtname.Text;
            playerType = rbmage.Checked ? CharacterType.Mage : CharacterType.Warrior;

            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
           if(!string.IsNullOrWhiteSpace(txtname.Text))
           
                    btnbattle.Enabled = true;
                else
                    btnbattle.Enabled = false;
                  
            }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

     
    }

