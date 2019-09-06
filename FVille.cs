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
    public partial class FVille : Form
    {
        private Entities maConnexion;
        public FVille()
        {
            InitializeComponent();
            /*Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new Entities();
            /* le  bindingSource  bsVille est connecté à la table Ville de la BDD  via la chaîne de connexion */
            bsVille.DataSource = maConnexion.VILLE.ToList();
        }

        private void VILLEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
