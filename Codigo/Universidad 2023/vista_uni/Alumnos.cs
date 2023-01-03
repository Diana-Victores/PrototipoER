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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2003";
            TextBox[] Grupotextbox = { textID, textNombre,
                textDireccion, textTelefono, textEmail, textEstatus,  };
            TextBox[] Idtextbox = { textID, textNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dgvAlumnos;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dgvAlumnos, Grupotextbox, "siu");
        }
    }
}
