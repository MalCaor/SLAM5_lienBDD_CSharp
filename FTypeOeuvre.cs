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
    public partial class FTypeOeuvre : Form
    {
        public FTypeOeuvre()
        {
            InitializeComponent();
            //les Types d'Oeuvre
            bsto.DataSource = Modele.listetypoeuvre();
            dgvto.DataSource = bsto.DataSource;
            dgvto.Columns[2].Visible = false;
        }
    }
}
