using Capa_Logica;
using Laborartorio_FilmMagic.Consultas;
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

namespace Laborartorio_FilmMagic.Procesos
{
    public partial class Proceso_Nomina : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Proceso_Nomina()
        {
            InitializeComponent();
            scampo = logic.siguiente("renta_encabezado", "pkidrentaencabezado");
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "yyyy/MM/dd";

            dtp_FechaE.Format = DateTimePickerFormat.Custom;
            dtp_FechaE.CustomFormat = "yyyy/MM/dd";
            Txt_Codigo.Text = scampo;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_buscarM_Click(object sender, EventArgs e)
        {
            Frm_consultaPuesto memb = new Frm_consultaPuesto();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {

                Txt_membresia.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }

        private void Btn_buscarS_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.insertarEncabezadoRenta(Txt_Codigo.Text,Txt_membresia.Text,dtp_fecha.Text,dtp_FechaE.Text,Txt_sucursal.Text);
            MessageBox.Show("Datos registrados.");
            
            Txt_Codigo.Text = logic.siguiente("renta_encabezado", "pkidrentaencabezado");
        }
    }
}
