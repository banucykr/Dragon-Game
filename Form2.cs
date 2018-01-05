using oyun.Enums;
using oyun.Models;
using oyun.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form2 : Form
    {
        CharacterType playerType;
        string playerName;
        Form1 form;
        public Form2(Form1 f1)
        {
            form = f1;
            this.playerType = form.playerType;
            this.playerName = form.player;
            InitializeComponent();
        }
        Player player;
        Dragon dragon = new Dragon("Dragon Walter");
       

        private void Form2_Load(object sender, EventArgs e)
        {

            if (playerType == CharacterType.Warrior)
                player = new Warrior();
            else if (playerType == CharacterType.Mage)
                player = new Mage();
            player.Name = playerName;
            
               lblplayername.Text = player.Name;
                lblplayerhealth.Text = player.Health.ToString();
                lblplayerattack.Text = player.Power.ToString();
           
               
          
                lbldname.Text = dragon.Name;
                lbldhealth.Text = dragon.Health.ToString();
                lbldattack.Text = dragon.Power.ToString();
            lblyaz.Text = "Your Turn!";
            dragon.OnDeath += E_OnDeath;
            player.OnDeath += E_OnDeath;
               
            }

        private void btnroll_Click(object sender, EventArgs e)
        {
            btnroll.Visible = false;
            int hit = player.Attack(Dice.Roll());
            dragon.HealthDecrease(hit);
            UpdateLabels(player.Name, hit); // labelları güncelle
            Refresh();
            Thread.Sleep(900);

           lblyaz.Text = $"{dragon.Name} attacking...";
            Refresh();
            Thread.Sleep(900);

            hit = dragon.Attack(Dice.Roll());
            player.HealthDecrease(hit);
            UpdateLabels(dragon.Name, hit);
            Refresh();
            Thread.Sleep(900);

            lblyaz.Text = "Your Turn!";
            btnroll.Visible = true;


        }
        private void UpdateLabels(string name, int hit)
        {
            lblplayerhealth.Text = player.Health.ToString();
            lbldhealth.Text = dragon.Health.ToString();
            if (hit == 0)
                lblyaz.Text = $"{name} MISSED!";
            else
                lblyaz.Text = $"{name} hit {hit}!";
        }

        private void E_OnDeath()
        {
            if (player.Health <= 0)
                MessageBox.Show("You Lost!");
            else
                MessageBox.Show("You Won!");

            this.Hide();
            form.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
  
        }
    

