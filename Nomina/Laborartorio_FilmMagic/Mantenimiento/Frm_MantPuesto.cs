using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laborartorio_FilmMagic.Consultas;

namespace Laborartorio_FilmMagic.Mantenimiento
{
    public partial class Frm_MantPuesto : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_MantPuesto()
        {
            InitializeComponent();
            scampo = logic.siguiente("membresia", "pkidmembresia");
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "yyyy/MM/dd";

            dtp_FechaC.Format = DateTimePickerFormat.Custom;
            dtp_FechaC.CustomFormat = "yyyy/MM/dd";
            Txt_Cod.Text = scampo;
            bloqueartxt();

        }

        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_Cod.Enabled = false;
            txt_Nombre.Enabled = false;
            dtp_fecha.Enabled = false;
            dtp_FechaC.Enabled = false;
            
        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/

            Txt_Cod.Enabled = false;
            txt_Nombre.Enabled = true;
            dtp_fecha.Enabled = true;
            dtp_FechaC.Enabled = true;
            
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            txt_Nombre.Enabled = false;
            dtp_fecha.Enabled = false;
            dtp_FechaC.Enabled = false;
            
            Txt_Cod.Text = "";
            txt_Nombre.Text = "";
            

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarMembresia(Txt_Cod.Text, txt_Nombre.Text, dtp_fecha.Text,dtp_FechaC.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
            Txt_Cod.Text = logic.siguiente("sucursal", "pkidmembresia");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarMembresia(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarMembresia(Txt_Cod.Text, txt_Nombre.Text,dtp_fecha.Text,dtp_FechaC.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaPuesto memb = new Frm_consultaPuesto();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_Nombre.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                dtp_fecha.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                dtp_FechaC.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
