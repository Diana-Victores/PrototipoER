using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista_uni
{
    public partial class MenuUniversidad : Form
    {

        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();

        public MenuUniversidad()
        {
            InitializeComponent();
            customizeDesing();

            Button[] apps = { buttonAlum, btnProf,
                btnRegitroNotaP,btnSeguridad,
                btnConsulta,btnSalir};
            cnseg.deshabilitarApps(apps);
            cnseg.getAccesoApp(2001, apps[0]);
            cnseg.getAccesoApp(2002, apps[1]);
            cnseg.getAccesoApp(2003, apps[2]);
            cnseg.getAccesoApp(2004, apps[3]);
            cnseg.getAccesoApp(2100, apps[4]);
        }

        private void customizeDesing()
        {
            panelCatalogo.Visible = false;
            panelProceso.Visible = false;
            panelSeguridad.Visible = false;
            panelHerra.Visible = false;
            panelSalir.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCatalogo.Visible == true)
                panelCatalogo.Visible = false;
            if (panelProceso.Visible == true)
                panelProceso.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false;
            if (panelHerra.Visible == true)
                panelHerra.Visible = false;
            if (panelSalir.Visible == true)
                panelSalir.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonAlum_Click(object sender, EventArgs e)
        {
            Alumnos b = new Alumnos();
        
        b.MdiParent = this;
            b.StartPosition = FormStartPosition.CenterScreen;
            b.Show();
            hideSubMenu();
    }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatalogo);
        }

        private void buttonProceso_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProceso);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void btnHerra_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHerra);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }
    }
}
