using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaltehyonXUnity
{
    public partial class Form1 : Form
    {
        private string faction = "";
        private List<Personnage> armee;
        private int pdr = 100;

        public Form1()
        {
            armee = new List<Personnage>();
            InitializeComponent();
        }

        private void faction1_Click(object sender, EventArgs e)
        {
            if(this.faction != "Dakrenien")
            {
                this.pdr = 100;
                this.pdrLabel.Text = this.pdr.ToString();
                this.armee = new List<Personnage>();
                this.armee.Add(new Personnage("Maître Invocateur", 6, 10, 0));
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("Maître Invocateur (PM) ( 6 / 10 / 0 )");
                this.faction = "Dakrenien";
                imagePerso1.Image = DaltehyonXUnity.Properties.Resources.Maître_Invocateur;
                imagePerso2.Image = DaltehyonXUnity.Properties.Resources.Shaman;
                imagePerso3.Image = DaltehyonXUnity.Properties.Resources.Persécuteur;
                imagePerso4.Image = DaltehyonXUnity.Properties.Resources.Gobelin_Noir;
                imagePerso5.Image = DaltehyonXUnity.Properties.Resources.Ombre_de_Dakréos;
            }
        }

        private void faction2_Click(object sender, EventArgs e)
        {
            if (this.faction != "Humain")
            {
                this.pdr = 100;
                this.pdrLabel.Text = this.pdr.ToString();
                this.armee = new List<Personnage>();
                this.armee.Add(new Personnage("Seigneur Dan Flint", 6, 10, 0));
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("Seigneur Dan Flint (PM) ( 6 / 10 / 0 )");
                this.faction = "Humain";
                imagePerso1.Image = DaltehyonXUnity.Properties.Resources.Seigneur_Dan_Flint;
                imagePerso2.Image = DaltehyonXUnity.Properties.Resources.Ecuyer;
                imagePerso3.Image = DaltehyonXUnity.Properties.Resources.Chevalier;
                imagePerso4.Image = DaltehyonXUnity.Properties.Resources.Archer;
                imagePerso5.Image = DaltehyonXUnity.Properties.Resources.Catapulte;
            }
        }

        private void faction3_Click(object sender, EventArgs e)
        {
            if (this.faction != "Jal-kenien")
            {
                this.pdr = 100;
                this.pdrLabel.Text = this.pdr.ToString();
                this.armee = new List<Personnage>();
                this.armee.Add(new Personnage("Jäl", 6, 10, 0));
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("Jäl (PM)  (6/10) ( 6 / 10 / 0 )");
                this.faction = "Jal-kenien";
                imagePerso1.Image = DaltehyonXUnity.Properties.Resources.Jäl;
                imagePerso2.Image = DaltehyonXUnity.Properties.Resources.Minotaure;
                imagePerso3.Image = DaltehyonXUnity.Properties.Resources.Centaure;
                imagePerso4.Image = DaltehyonXUnity.Properties.Resources.Satyre;
                imagePerso5.Image = DaltehyonXUnity.Properties.Resources.Loup;
            }
        }

        private void faction4_Click(object sender, EventArgs e)
        {
            if (this.faction != "Nain")
            {
                this.pdr = 100;
                this.pdrLabel.Text = this.pdr.ToString();
                this.armee = new List<Personnage>();
                this.armee.Add(new Personnage("Roi Gamaten", 6, 10, 0));
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("Roi Gamaten (PM) ( 6 / 10 / 0 )");
                this.faction = "Nain";
                imagePerso1.Image = DaltehyonXUnity.Properties.Resources.Roi_Gamaten;
                imagePerso2.Image = DaltehyonXUnity.Properties.Resources.Exosquelette;
                imagePerso3.Image = DaltehyonXUnity.Properties.Resources.Canonnier;
                imagePerso4.Image = DaltehyonXUnity.Properties.Resources.Fusilleur;
                imagePerso5.Image = DaltehyonXUnity.Properties.Resources.Guerrier;
            }
        }

        private void faction5_Click(object sender, EventArgs e)
        {
            if (this.faction != "Shujaa")
            {
                this.pdr = 100;
                this.pdrLabel.Text = this.pdr.ToString();
                this.armee = new List<Personnage>();
                this.armee.Add(new Personnage("Chef de Clan", 6, 10, 0));
                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("Chef de Clan (PM) ( 6 / 10 / 0 )");
                this.faction = "Shujaa";
                imagePerso1.Image = DaltehyonXUnity.Properties.Resources.Chef_de_Clan;
                imagePerso2.Image = DaltehyonXUnity.Properties.Resources.Assaillant;
                imagePerso3.Image = DaltehyonXUnity.Properties.Resources.Eclaireur;
                imagePerso4.Image = DaltehyonXUnity.Properties.Resources.Archer_Shujaa;
                imagePerso5.Image = DaltehyonXUnity.Properties.Resources.Assassin;
            }
        }

        private void imagePerso2_Click(object sender, EventArgs e)
        {
            switch (this.faction)
            {
                case "Dakrenien":
                    if (this.pdr >= 7)
                    {
                        this.armee.Add(new Personnage("Shaman", 3, 10, 7));
                        this.pdr -= 7;
                        this.listBox1.Items.Add("Shaman ( 3 / 10 / 7 )");
                    }
                    break;
                case "Humain":
                    if (this.pdr >= 4)
                    {
                        this.armee.Add(new Personnage("Ecuyer", 5, 10, 4));
                        this.pdr -= 4;
                        this.listBox1.Items.Add("Ecuyer ( 5 / 10 / 4 )");
                    }
                    break;
                case "Jal-kenien":
                    if (this.pdr >= 13)
                    {
                        this.armee.Add(new Personnage("Minotaure", 9, 11, 13));
                        this.pdr -= 13;
                        this.listBox1.Items.Add("Minotaure ( 9 / 11 / 13 )");
                    }
                    break;
                case "Nain":
                    if (this.pdr >= 12)
                    {
                        this.armee.Add(new Personnage("Exosquelette", 4, 13, 12));
                        this.pdr -= 12;
                        this.listBox1.Items.Add("Exosquelette ( 4 / 13 / 12 )");
                    }
                    break;
                case "Shujaa":
                    if (this.pdr >= 5)
                    {
                        this.armee.Add(new Personnage("Assaillant", 6, 10, 5));
                        this.pdr -= 5;
                        this.listBox1.Items.Add("Assaillant ( 6 / 10 / 5 )");
                    }
                    break;
            }
            this.pdrLabel.Text = this.pdr.ToString();
        }

        private void imagePerso3_Click(object sender, EventArgs e)
        {
            switch (this.faction)
            {
                case "Dakrenien":
                    if (this.pdr >= 12)
                    {
                        this.armee.Add(new Personnage("Persécuteur", 8, 12, 12));
                        this.pdr -= 12;
                        this.listBox1.Items.Add("Persécuteur ( 8 / 12 / 12 )");
                    }
                    break;
                case "Humain":
                    if (this.pdr >= 5)
                    {
                        this.armee.Add(new Personnage("Chevalier", 7, 11, 5));
                        this.pdr -= 5;
                        this.listBox1.Items.Add("Chevalier ( 7 / 11 / 5 )");
                    }
                    break;
                case "Jal-kenien":
                    if (this.pdr >= 7)
                    {
                        this.armee.Add(new Personnage("Centaure", 7, 10, 7));
                        this.pdr -= 7;
                        this.listBox1.Items.Add("Centaure ( 7 / 10 / 7 )");
                    }
                    break;
                case "Nain":
                    if (this.pdr >= 10)
                    {
                        this.armee.Add(new Personnage("Canonnier", 6, 10, 10));
                        this.pdr -= 10;
                        this.listBox1.Items.Add("Canonnier ( 6 / 10 / 10 )");
                    }
                    break;
                case "Shujaa":
                    if (this.pdr >= 6)
                    {
                        this.armee.Add(new Personnage("Eclaireur", 6, 10, 6));
                        this.pdr -= 6;
                        this.listBox1.Items.Add("Eclaireur ( 6 / 10 / 6 )");
                    }
                    break;
            }
            this.pdrLabel.Text = this.pdr.ToString();
        }

        private void imagePerso4_Click(object sender, EventArgs e)
        {
            switch (this.faction)
            {
                case "Dakrenien":
                    if (this.pdr >= 3)
                    {
                        this.armee.Add(new Personnage("Gobelin Noir", 6, 9, 3));
                        this.pdr -= 3;
                        this.listBox1.Items.Add("Gobelin Noir ( 6 / 9 / 3 )");
                    }
                    break;
                case "Humain":
                    if (this.pdr >= 6)
                    {
                        this.armee.Add(new Personnage("Archer", 6, 11, 6));
                        this.pdr -= 6;
                        this.listBox1.Items.Add("Archer ( 6 / 11 / 6 )");
                    }
                    break;
                case "Jal-kenien":
                    if (this.pdr >= 5)
                    {
                        this.armee.Add(new Personnage("Satyre", 6, 9, 5));
                        this.pdr -= 5;
                        this.listBox1.Items.Add("Satyre ( 6 / 9 / 5 )");
                    }
                    break;
                case "Nain":
                    if (this.pdr >= 9)
                    {
                        this.armee.Add(new Personnage("Fusilleur", 7, 9, 9));
                        this.pdr -= 9;
                        this.listBox1.Items.Add("Fusilleur ( 7 / 9 / 9 )");
                    }
                    break;
                case "Shujaa":
                    if (this.pdr >= 4)
                    {
                        this.armee.Add(new Personnage("Archer Shujaa", 5, 9, 4));
                        this.pdr -= 4;
                        this.listBox1.Items.Add("Archer Shujaa ( 5 / 9 / 4 )");
                    }
                    break;
            }
            this.pdrLabel.Text = this.pdr.ToString();
        }

        private void imagePerso5_Click(object sender, EventArgs e)
        {
            switch (this.faction)
            {
                case "Dakrenien":
                    if (this.pdr >= 3)
                    {
                        this.armee.Add(new Personnage("Ombre de Dakréos", 6, 9, 3));
                        this.pdr -= 3;
                        this.listBox1.Items.Add("Ombre de Dakréos ( 6 / 9 / 3 )");
                    }
                    break;
                case "Humain":
                    if (this.pdr >= 10)
                    {
                        this.armee.Add(new Personnage("Catapulte", 8, 10, 10));
                        this.pdr -= 10;
                        this.listBox1.Items.Add("Catapulte ( 8 / 10 / 10 )");
                    }
                    break;
                case "Jal-kenien":
                    if (this.pdr >= 3)
                    {
                        this.armee.Add(new Personnage("Loup", 6, 9, 3));
                        this.pdr -= 3;
                        this.listBox1.Items.Add("Loup ( 6 / 9 / 3 )");
                    }
                    break;
                case "Nain":
                    if (this.pdr >= 5)
                    {
                        this.armee.Add(new Personnage("Guerrier", 3, 12, 5));
                        this.pdr -= 5;
                        this.listBox1.Items.Add("Guerrier ( 3 / 12 / 5 )");
                    }
                    break;
                case "Shujaa":
                    if (this.pdr >= 10)
                    {
                        this.armee.Add(new Personnage("Assassin", 8, 12, 10));
                        this.pdr -= 10;
                        this.listBox1.Items.Add("Assassin ( 8 / 12 / 10 )");
                    }
                    break;
            }
            this.pdrLabel.Text = this.pdr.ToString();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (!listBox1.SelectedItem.ToString().Contains("(PM)"))
                {
                    string persoName = listBox1.SelectedItem.ToString().Split('(')[0];
                    persoName = persoName.Substring(0, persoName.Length - 1);
                    Console.WriteLine(persoName);
                    this.pdr += this.armee.Find(x => x.Name == persoName).Pdr;
                    this.pdrLabel.Text = this.pdr.ToString();
                    this.armee.Remove(this.armee.Find(x => x.Name == persoName));
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
