using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laborartorio_FilmMagic;
using Laborartorio_FilmMagic.Mantenimiento;
using Laborartorio_FilmMagic.Mantenimientos;
using Laborartorio_FilmMagic.Procesos;

namespace Laborartorio_FilmMagic
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        bool ventanaConcepto = false;
        Mnt_Concepto concepto = new Mnt_Concepto();     
        private void ConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Mnt_Concepto);
            if (ventanaConcepto == false || frmC == null)
            {
                if (frmC == null)
                {
                    concepto = new Mnt_Concepto();
                }

                concepto.MdiParent = this;
                concepto.Show();
                Application.DoEvents();
                ventanaConcepto = true;
            }
            else
            {
                concepto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaEmpleado = false;
        Frm_MantEmpleado empleado = new Frm_MantEmpleado();
        private void MembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantEmpleado);
            if (ventanaEmpleado == false || frmC == null)
            {
                if (frmC == null)
                {
                    empleado = new Frm_MantEmpleado();
                }

                empleado.MdiParent = this;
                empleado.Show();
                Application.DoEvents();
                ventanaEmpleado = true;
            }
            else
            {
                empleado.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaPuesto = false;
        Frm_MantPuesto puesto = new Frm_MantPuesto();
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPuesto);
            if (ventanaPuesto == false || frmC == null)
            {
                if (frmC == null)
                {
                    puesto = new Frm_MantPuesto();
                }

                puesto.MdiParent = this;
                puesto.Show();
                Application.DoEvents();
                ventanaPuesto = true;
            }
            else
            {
                puesto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaDepa = false;
        Frm_MantDepartemento depa = new Frm_MantDepartemento();        
        private void TipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantDepartemento);
            if (ventanaDepa == false || frmC == null)
            {
                if (frmC == null)
                {
                    depa = new Frm_MantDepartemento();
                }

                depa.MdiParent = this;
                depa.Show();
                Application.DoEvents();
                ventanaDepa = true;
            }
            else
            {
                depa.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        
        bool ventanaNomina = false;
        Proceso_Nomina nomina = new Proceso_Nomina();
        private void RentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Proceso_Nomina);
            if (ventanaNomina == false || frmC == null)
            {
                if (frmC == null)
                {
                    nomina = new Proceso_Nomina();
                }

                nomina.MdiParent = this;
                nomina.Show();
                Application.DoEvents();
                ventanaNomina = true;
            }
            else
            {
                nomina.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
