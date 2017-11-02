using DaltehyonXUnity.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DaltehyonXUnity
{
    public partial class waitingParty : Form
    {
        private int idParty;
        private PartyDao partyDao;
        private bool playerTwo = false;
        private MainController mainController;
        private System.Threading.Thread monthread;

        public waitingParty(int idParty)
        {
            partyDao = PartyDao.getInstance();
            mainController = MainController.getInstance();
            this.idParty = idParty;
            InitializeComponent();
            monthread = new System.Threading.Thread(new System.Threading.ThreadStart(checkPlayerTwo));
            monthread.Start();
        }

        public void checkPlayerTwo()
        {
            Party party = new Party();
            while (!playerTwo)
            {
                party = partyDao.SelectById(idParty)[0];
                if(party == null)
                {
                    this.Close();
                }
                else
                {
                    if(party.PseudoPlayerTwo != null && party.PseudoPlayerTwo != "")
                    {
                        playerTwo = true;
                    }
                    else
                    {
                        playerTwo = false;
                    }
                }
                System.Threading.Thread.Sleep(500);
            }
            mainController.partyFound = true;
            mainController.idParty = idParty;
            Invoke(new Action(Close));
        }

        private void waitingParty_FormClosed(object sender, FormClosedEventArgs e)
        {
            monthread.Abort();
            if(!mainController.partyFound)
            {
                partyDao.Delete(idParty);
            }
        }
    }
}
