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
    public partial class frmMunicipio : Form
    {
        private List<Municipio> _listado;

        public frmMunicipio()
        {
            InitializeComponent();
        }


        private void UpdateGrid()
        {
            _listado = MunicipioBL.Instance.SellecALL();
            var query = from x in _listado
                         select new
                         {
                             Id = x.MunicipioId,
                             Nombre = x.Nombre,
                             Poblacion = x.Poblacion,
                             Departamento = x.DepartamentoId


                         };
            dataGridView1.DataSource = query.ToList();
        }
        private void frmMunicipio_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _listado = MunicipioBL.Instance.SellecALL();

            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.MunicipioId,
                               Nombre = x.Nombre,
                               poblacion = x.Poblacion,
                               departamento = x.Departamentos.Nombre
                           };
            var query = busqueda.Where(x => x.Nombre.ToLower().StartsWith(textBox1.Text.ToLower())).ToList();
            dataGridView1.DataSource = query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarMunicipio frm = new frmAgregarMunicipio();
            frm.ShowDialog();
            UpdateGrid();
        }
    }
}
