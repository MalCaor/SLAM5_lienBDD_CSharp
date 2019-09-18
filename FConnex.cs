using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLAM5_lienBDD_CSharp
{
    public partial class FConnex : Form
    {
        public FConnex()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            if (Verif())
            {
                string ID = tbID.Text;
                string mdp = tbMDP.Text;
                if(Modele.verifLogin(ID, mdp))
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login ou mdp invalide");
                }
            }
            else
            {
                MessageBox.Show("ID ou MDP non remplit");
            }
        }

        private bool Verif()
        {
            if (tbID.Text.Length < 1)
            {
                return false;
            }
            if (tbMDP.Text.Length < 1)
            {
                return false;
            }
            return true;
        }
        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }
    }
}
