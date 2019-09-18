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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void SalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form flessalles = new FSalle();
            flessalles.Show();
        }

        private void VilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form flesvilles = new FVille();
            flesvilles.Show();
        }

        private void BatimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form flesbats = new FBatiment();
            flesbats.Show();
        }

        private void TypeOeuveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form flesTO = new FTypeOeuvre();
            flesTO.Show();
        }

        private void CompositeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ParNationalitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form flesComps = new FCompositeurNation();
            flesComps.Show();
        }

        private void ParStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form flesStyles = new FCompositeurStyle();
            flesStyles.Show();
        }

        private void ParOeuvreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form flesOeuvres = new FCompositeurOeuvre();
            flesOeuvres.Show();
        }

        private void CompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fcompte = new FCompte();
            fcompte.Show();
        }
    }
}
