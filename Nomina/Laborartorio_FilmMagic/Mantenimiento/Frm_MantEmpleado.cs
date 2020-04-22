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

namespace Laborartorio_FilmMagic.Mantenimiento
{
    public partial class Frm_MantEmpleado : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_MantEmpleado()
        {
            InitializeComponent();
            scampo = logic.siguiente("empleado", "codigo_empleado");
            bloqueartxt();
            Txt_Codigo.Text = scampo;
        }
        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_Codigo.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Cpuesto.Enabled = false;
            txt_estatus.Enabled = false;
            Txt_sueldo.Enabled = false;
            txt_CDepartamento.Enabled = false;
        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/
            Txt_Codigo.Enabled = false;
            txt_Nombre.Enabled = true;
            txt_Cpuesto.Enabled = true;
            txt_estatus.Enabled = true;
            Txt_sueldo.Enabled = true;
            txt_CDepartamento.Enabled = true;
        }

        public void limpiar()
        {
            Txt_Codigo.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Cpuesto.Enabled = false;
            txt_estatus.Enabled = false;
            Txt_sueldo.Enabled = false;
            txt_CDepartamento.Enabled = false;
            Txt_Codigo.Text = "";
            txt_Nombre.Text = "";
            txt_CDepartamento.Text = "";
            txt_estatus.Text = "";
            txt_Cpuesto.Text = "";
            Txt_sueldo.Text = "";
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarEmpleado(Txt_Codigo.Text, txt_Nombre.Text,txt_Cpuesto.Text,
                txt_CDepartamento.Text,Txt_sueldo.Text,txt_estatus.Text);

            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarEmpleado(Txt_Codigo.Text, txt_Nombre.Text,txt_Cpuesto.Text,
                txt_CDepartamento.Text,Txt_sueldo.Text,txt_estatus.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
            Txt_Codigo.Text = logic.siguiente("cliente", "pkidcliente");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_Codigo.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado cliente = new Frm_consultaEmpleado();
            cliente.ShowDialog();

            if (cliente.DialogResult == DialogResult.OK)
            {
                Txt_Codigo.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_Nombre.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_Cpuesto.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                txt_CDepartamento.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_sueldo.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[4].Value.ToString();
                txt_estatus.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[5].Value.ToString();
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

        private void btn_buscarP_Click(object sender, EventArgs e)
        {

            Frm_consultaPuesto memb = new Frm_consultaPuesto();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {

                txt_Cpuesto.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }

        private void btn_buscarD_Click(object sender, EventArgs e)
        {
            Frm_consultaDepartamento memb = new Frm_consultaDepartamento();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {

                txt_CDepartamento.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }
    }
}
