using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frmVendor : Form
    {

        manttoVendor obj = new manttoVendor();

        public frmVendor()
        {
            InitializeComponent();
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.prueba());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            obj.CodVendor = txtCodigoVen.Text;
            obj.NombreVendor = txtNombreVen.Text;
            obj.insertVendor();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            obj.CodVendor = txtCodigoVen.Text;
            obj.NombreVendor = txtNombreVen.Text;
            obj.updateVendor();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCodigoVen.Text =obj.CodVendor;
            txtNombreVen.Text =obj.NombreVendor;
            obj.selectVendor();
        }
    }
}
