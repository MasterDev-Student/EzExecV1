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
using System.Net;
using WeAreDevs_API;
using System.Diagnostics;
using System.Threading;

// By MasterDev
// Si tu vend cette source tu es vraiment un sans race
// Tutoriel ajouté !

namespace MasterDevExec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pour lancer l'API de Roblox : by WeAreDev
            ExploitAPI api = new ExploitAPI();
            api.LaunchExploit();
        }

        private void flatButton1Execute_Click(object sender, EventArgs e)
        {

        }

        private void flatButton2OpenFile_Click(object sender, EventArgs e)
        {
            
        }

        private void flatButton3Clear_Click(object sender, EventArgs e)
        {

        }


        private void flatButton1AddFire_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour ajouter des flammes
            ExploitAPI api = new ExploitAPI();
            api.AddFire();
        }

        private void flatButton3AddSmoke_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour ajouter de la smoke
            ExploitAPI api = new ExploitAPI();
            api.AddSmoke();
        }

        private void flatButton5KillMe_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour kill son perso principal
            ExploitAPI api = new ExploitAPI();
            api.Suicide();
        }

        private void flatButton2RemoveFire_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour enlever les flammes
            ExploitAPI api = new ExploitAPI();
            api.RemoveFire();
        }

        private void flatButton4RemoveSmoke_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour enlever les smokes
            ExploitAPI api = new ExploitAPI();
            api.RemoveSmoke();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flatButton1AddSparkles_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour add les sparkles
            ExploitAPI api = new ExploitAPI();
            api.AddSparkles();
        }

        private void flatButton4RemoveSparkles_Click(object sender, EventArgs e)
        {            
            //Commande de l'exploit pour supp les sparkles
            ExploitAPI api = new ExploitAPI();
            api.RemoveSparkles();
        }

        private void flatButton1RemoveLegs_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour supp les legs
            ExploitAPI api = new ExploitAPI();
            api.RemoveLegs();
        }

        private void flatButton2RemoveLimbs_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/InkaWeb666/featured");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/AXeZFAbPaK");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour add les flammes
            ExploitAPI api = new ExploitAPI();
            api.AddFire();
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour add les smokes
            ExploitAPI api = new ExploitAPI();
            api.AddSmoke();
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour add les sparkles
            ExploitAPI api = new ExploitAPI();
            api.AddSparkles();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour supp les legs
            ExploitAPI api = new ExploitAPI();
            api.RemoveLegs();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour supp les limbs
            ExploitAPI api = new ExploitAPI();
            api.RemoveLimbs();
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            //Commande de l'exploit pour kill son perso
            ExploitAPI api = new ExploitAPI();
            api.Suicide();
        }

        private void ButtonYT_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/InkaWeb666/featured");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/AXeZFAbPaK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Commande pour reset la console
            fastColoredTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Pour ajouter dans la console du text via un fichier lua ou txt
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("Erreur MasterDev", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Execute le Lua dans la console + message de confirmation
            ExploitAPI api = new ExploitAPI();
            api.SendLimitedLuaScript(fastColoredTextBox1.Text);
            MessageBox.Show("Injected by MasterDev", "Nice !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

// By MasterDev
// Si tu vend cette source tu es vraiment un sans race
