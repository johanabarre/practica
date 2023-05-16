using PracticaProgra.BusinessLogic;
using PracticaProgra.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProgra.View
{
    public partial class frmAgregarDepartamento : Form
    {
        int id;
        public frmAgregarDepartamento()
        {
            InitializeComponent();
        }
        

        private void frmAgregarDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamento entity = new Departamento()
            {
                DepartamentoId=id,
                Nombre = textBox1.Text.Trim(),
                

            };

            
            
                if (DepartamentoBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            






            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
