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
            limpiar();
            cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            obj.CodVendor = txtCodigoVen.Text;
            obj.NombreVendor = txtNombreVen.Text;
            obj.updateVendor();
            limpiar();
            cargar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            obj.CodVendor = txtCodigoVen.Text;
            obj.deleteVendor();
            limpiar();
            cargar();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void limpiar() {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = obj.dt;
        }
        public void cargar() {
            obj.selectVendor();
            
            dataGridView1.DataSource = obj.dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }

       
       
    }
}
