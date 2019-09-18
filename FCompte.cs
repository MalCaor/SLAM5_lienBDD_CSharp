using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SLAM5_lienBDD_CSharp
{
    public partial class FCompte : Form
    {
        public FCompte()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                string currentmdp = "0x" + GetMd5Hash(tbAnciMDP.Text);
                string nouvmdp = "0x" + GetMd5Hash(tbNouvMDP.Text);
                string confmdp = "0x" + GetMd5Hash(tbConfMDP.Text);

            }
            else
            {
                MessageBox.Show("remplit");
            }
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private bool verif()
        {
            if (tbAnciMDP.Text.Length < 1)
            {
                return false;
            }
            if (tbConfMDP.Text.Length < 1)
            {
                return false;
            }
            if (tbNouvMDP.Text.Length < 1)
            {
                return false;
            }
            return true;
        }
    }

}
