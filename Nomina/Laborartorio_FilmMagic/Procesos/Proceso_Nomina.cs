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
            scampo = logic.siguiente("nominaE", "codigo_nomina");
            dtp_fechaI.Format = DateTimePickerFormat.Custom;
            dtp_fechaI.CustomFormat = "yyyy/MM/dd";

            dtp_FechaF.Format = DateTimePickerFormat.Custom;
            dtp_FechaF.CustomFormat = "yyyy/MM/dd";
            txt_Codigo1.Text = scampo;
            txt_Codigo2.Text = scampo;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
        private void Btn_buscarS_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado memb = new Frm_consultaEmpleado();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_empleado.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            //------ ENCABEZADO
            OdbcDataReader encabezado = logic.insertarEncabezadoNomina(txt_Codigo1.Text, dtp_fechaI.Text, dtp_FechaF.Text);
            MessageBox.Show("Datos registrados.");
            //------ DETALLE
            OdbcDataReader detalle = logic.insertarDetalleNomina(txt_Codigo1.Text, txt_empleado.Text, txt_concepto.Text, txt_valor.Text);
            MessageBox.Show("Datos registrados.");

            txt_Codigo1.Text = logic.siguiente("nominaE", "codigo_nomina");
            txt_Codigo2.Text = logic.siguiente("nominaD", "codigo_nomina");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_BuscarC_Click(object sender, EventArgs e)
        {
            Frm_consultaConcepto memb = new Frm_consultaConcepto();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_concepto.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }
    }
}
