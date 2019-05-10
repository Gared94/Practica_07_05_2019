using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

namespace capaNegocios
{
    public class manttoVendor
    {
        bdConex test = new bdConex();
        private string codVendor, nombreVendor;
        public DataTable dt = new DataTable();
        public string CodVendor
        {
            get { return codVendor; }
            set { codVendor = value; }
        }

        public string NombreVendor
        {
            get { return nombreVendor; }
            set { nombreVendor = value; }
        }


        public void insertVendor()
        {
            try
            {
                String insert = "INSERT INTO VENDEDOR (VENDEDOR, NOMBRE)VALUES('"+codVendor+"','"+nombreVendor+"')";
                test.Conectar();
                test.consultarSQL(insert);
                test.Desconectar();
            }
            catch (Exception e)
            {

            }
        }

        public void updateVendor()
        {
            try
            {
                String update = "UPDATE VENDEDOR set NOMBRE ='" + nombreVendor + "' WHERE VENDEDOR ='" + codVendor + "'";
                test.Conectar();
                test.consultarSQL(update);
                test.Desconectar();
            }
            catch (Exception e)
            {

            }
        }

        public void deleteVendor()
        {
            try
            {
                String delete = "DELETE FROM VENDEDOR WHERE VENDEDOR ='" + codVendor + "'";
                test.Conectar();
                test.consultarSQL(delete);
                test.Desconectar();
            }
            catch (Exception e)
            {

            }
        }

        public void selectVendor()
        {
            try
            {
                String select = "SELECT * FROM VENDEDOR";
                test.Conectar();
                test.mostrarSQL(select);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch (Exception e)
            {

            }
        }



        public String prueba() 
        {
            String mensaje;

            if(test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }else
            {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;
        }
    }
}
