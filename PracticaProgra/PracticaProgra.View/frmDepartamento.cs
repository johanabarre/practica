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
    public partial class frmDepartamento : Form
    {
        private List<Departamento> _listado;

        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = DepartamentoBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.DepartamentoId,
                            Nombre = x.Nombre
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarDepartamento frm = new frmAgregarDepartamento();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _listado = DepartamentoBL.Instance.SellecALL();

            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.DepartamentoId,
                               Nombre = x.Nombre
                           };
            var query = busqueda.Where(x => x.Nombre.ToLower().StartsWith(textBox1.Text.ToLower())).ToList();
            dataGridView1.DataSource = query;
        }
    }
}
