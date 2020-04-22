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
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ToolStripStatusLabel_Click(object sender, EventArgs e)
        {

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

        bool ventanaMembresia = false;
        Frm_MantMembresia memb= new Frm_MantMembresia();
        private void MembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantMembresia);
            if (ventanaMembresia == false || frmC == null)
            {
                if (frmC == null)
                {
                    memb = new Frm_MantMembresia();
                }

                memb.MdiParent = this;
                memb.Show();
                Application.DoEvents();
                ventanaMembresia = true;
            }
            else
            {
                memb.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCliente = false;
        Frm_MantCliente cliente = new Frm_MantCliente();
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantCliente);
            if (ventanaCliente == false || frmC == null)
            {
                if (frmC == null)
                {
                    cliente = new Frm_MantCliente();
                }

                cliente.MdiParent = this;
                cliente.Show();
                Application.DoEvents();
                ventanaCliente = true;
            }
            else
            {
                cliente.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaTipo = false;
        Frm_MantTipoProducto tipo = new Frm_MantTipoProducto();
        private void TipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTipoProducto);
            if (ventanaTipo == false || frmC == null)
            {
                if (frmC == null)
                {
                    tipo = new Frm_MantTipoProducto();
                }

                tipo.MdiParent = this;
                tipo.Show();
                Application.DoEvents();
                ventanaTipo = true;
            }
            else
            {
                tipo.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaAutor = false;
        Frm_MantAutor autor = new Frm_MantAutor();
        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantAutor);
            if (ventanaAutor == false || frmC == null)
            {
                if (frmC == null)
                {
                    autor = new Frm_MantAutor();
                }

                autor.MdiParent = this;
                autor.Show();
                Application.DoEvents();
                ventanaAutor = true;
            }
            else
            {
                autor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCategoria = false;
        Frm_MantCategoria categoria = new Frm_MantCategoria();
        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantCategoria);
            if (ventanaCategoria == false || frmC == null)
            {
                if (frmC == null)
                {
                    categoria = new Frm_MantCategoria();
                }

                categoria.MdiParent = this;
                categoria.Show();
                Application.DoEvents();
                ventanaCategoria = true;
            }
            else
            {
                categoria.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaprodcuto = false;
        Frm_productos producto = new Frm_productos();
        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_productos);
            if (ventanaprodcuto == false || frmC == null)
            {
                if (frmC == null)
                {
                    producto = new Frm_productos();
                }

                producto.MdiParent = this;
                producto.Show();
                Application.DoEvents();
                ventanaprodcuto = true;
            }
            else
            {
                producto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaproveedores = false;
        Frm_Proveedores proveedores = new Frm_Proveedores();
        private void ProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Proveedores);
            if (ventanaproveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    proveedores = new Frm_Proveedores();
                }

                proveedores.MdiParent = this;
                proveedores.Show();
                Application.DoEvents();
                ventanaproveedores = true;
            }
            else
            {
                proveedores.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanasucursal = false;
        Frm_sucursal sucursal = new Frm_sucursal();
        private void SucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_sucursal);
            if (ventanasucursal == false || frmC == null)
            {
                if (frmC == null)
                {
                    sucursal = new Frm_sucursal();
                }

                sucursal.MdiParent = this;
                sucursal.Show();
                Application.DoEvents();
                ventanasucursal = true;
            }
            else
            {
                sucursal.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanarenta = false;
        Proceso_Rentar renta = new Proceso_Rentar();
        private void rentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Proceso_Rentar);
            if (ventanarenta == false || frmC == null)
            {
                if (frmC == null)
                {
                    renta = new Proceso_Rentar();
                }

                renta.MdiParent = this;
                renta.Show();
                Application.DoEvents();
                ventanarenta = true;
            }
            else
            {
                renta.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
