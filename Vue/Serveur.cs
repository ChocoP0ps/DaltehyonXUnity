using DaltehyonXUnity.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DaltehyonXUnity
{
    public partial class Serveur : Form
    {
        private string search = "";
        private PartyDao partyDAO;
        private List<Party> serveurDispo;
        private bool focus = false;
        private MainController mainController;
        public Serveur()
        {
            InitializeComponent();
            partyDAO = PartyDao.getInstance();
            mainController = MainController.getInstance();
            serveurDispo = partyDAO.SelectAll();
            BindingList<Party> parties = new BindingList< Party >(serveurDispo);
            partiesGridView.DataSource = parties;
            partiesGridView.Columns["IdParty"].Visible = false;
        }

        private void hebergeButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[a-zA-Z0-9-_]{2,36}");
            if(regex.IsMatch(userNameTextBox.Text))
            {
                focus = false;
                this.Refresh();
                Party party = new Party();
                party.PseudoHost = userNameTextBox.Text;
                party.MdP = passwordTextBox.Text;
                party.PseudoPlayerTwo = "";
                int idInsert = partyDAO.Insert(party);
                refreshButton.PerformClick();
                waitingParty wait = new waitingParty(idInsert);
                wait.ShowDialog();
                if(mainController.partyFound)
                {
                    launchGame();
                }
                refreshButton.PerformClick();
            }
            else
            {
                focus = true;
                this.Refresh();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            serveurDispo = partyDAO.SelectAll();
            List<Party> listFiltered = new List<Party>(serveurDispo);

            if(withoutPassword.Checked)
            {
                foreach (Party p in listFiltered)
                {
                    if (p.MdP == "Oui")
                    {
                        serveurDispo.Remove(p);
                    }
                }
            }

            listFiltered = new List<Party>(serveurDispo);

            if (free.Checked)
            {
                foreach (Party p in listFiltered)
                {
                    if (p.PseudoPlayerTwo != null && p.PseudoPlayerTwo != "")
                    {
                        serveurDispo.Remove(p);
                    }
                }
            }

            listFiltered = new List<Party>(serveurDispo);

            if (search != "")
            {
                foreach (Party p in listFiltered)
                {
                    if (!p.PseudoHost.Contains(search))
                    {
                        if(p.PseudoPlayerTwo == null || !p.PseudoPlayerTwo.Contains(search))
                        {
                            serveurDispo.Remove(p);
                        }
                    }
                }
            }

            BindingList<Party> parties = new BindingList<Party>(serveurDispo);
            partiesGridView.DataSource = parties;
            partiesGridView.Columns["IdParty"].Visible = false;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            searchButton.PerformClick();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search = searchText.Text;
            refreshButton.PerformClick();
        }

        private void withoutPassword_CheckedChanged(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        private void free_CheckedChanged(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        private void Serveur_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                userNameTextBox.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(userNameTextBox.Location.X - variance, userNameTextBox.Location.Y - variance, userNameTextBox.Width + variance, userNameTextBox.Height + variance));
            }
            else
            {
                userNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            if(partiesGridView.SelectedRows[0] != null)
            {
                mainController.idParty = (int) partiesGridView.SelectedRows[0].Cells["IdParty"].Value;
                launchGame();
            }
        }

        private void launchGame()
        {
            mainController.partyFound = true;
            this.Close();
        }
    }
}
