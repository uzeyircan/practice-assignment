using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaÖdevi
{
    public partial class Konular : Form
    {
        public Konular()
        {
            InitializeComponent();
        }

        private void Konular_Load(object sender, EventArgs e)
        {
            TreeView TreeAna = new TreeView();
            TreeAna.Width = 300;
            TreeAna.Height = 300;
            TreeAna.Location = new Point(10, 10);
            TreeAna.NodeMouseClick += TreeAna_NodeMouseClick;

            TreeNode Konular = new TreeNode("Konular");
            Konular.Nodes.Add("ButtonKontrol", "Button Kontrol");
            Konular.Nodes.Add("TextBoxKontrol", "TextBox Kontrol");
            TreeAna.Nodes.Add(Konular);
            TreeAna.ExpandAll();
            Controls.Add(TreeAna);

        }

        private void TreeAna_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "ButtonKontrol":
                    FrmButtonKontrol frmButtonKontrolformu = new FrmButtonKontrol();
                    frmButtonKontrolformu.ShowDialog();
                    break;
                case "TextBoxKontrol":
                    FrmTextBoxKontrol frmTextBoxKontrolformu = new FrmTextBoxKontrol();
                    frmTextBoxKontrolformu.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
