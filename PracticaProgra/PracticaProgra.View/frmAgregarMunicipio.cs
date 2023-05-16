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
    public partial class frmAgregarMunicipio : Form
    {
        int id;
        public frmAgregarMunicipio()
        {
            InitializeComponent();
        }
        public frmAgregarMunicipio(Municipio entity)
        {
            InitializeComponent();
            id = entity.MunicipioId;
            textBox1.Text = entity.Nombre;
            textBox2.Text = entity.Poblacion;

        }

        private void frmAgregarMunicipio_Load(object sender, EventArgs e)
        {
            UpdateComboDepartamento();
        }
        private void UpdateComboDepartamento()
        {
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "DepartamentoId";
            comboBox1.DataSource = DepartamentoBL.Instance.SellecALL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Municipio entity = new Municipio()
            {
                Nombre = textBox1.Text.Trim(),
                Poblacion = textBox2.Text.Trim(),
                DepartamentoId = (int)comboBox1.SelectedValue,




            };

            
            
                if (MunicipioBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            textBox1.ResetText();
            textBox2.ResetText();
        }
    }
}
