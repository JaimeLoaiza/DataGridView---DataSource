using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public List<Persona> Gente { get; set; }
        public Form1()
        {
            Gente = GetGente();
            InitializeComponent();
        }
        private List<Persona> GetGente()
        {
            var list = new List<Persona>();
            list.Add(new Persona()
            {
                PersonaId = 1,
                Nombre = "Persona 1",
                Apellido = "Apellido 1",
                Profesion = "Profesion 1"
            });
            list.Add(new Persona()
            {
                PersonaId = 2,
                Nombre = "Persona 2",
                Apellido = "Apellido 2",
                Profesion = "Profesion 2"
            });
            list.Add(new Persona()
            {
                PersonaId = 3,
                Nombre = "Persona 3",
                Apellido = "Apellido 3",
                Profesion = "Profesion 3"
            });
            return list;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var gente = this.Gente;
            DgvTabla.DataSource = gente;
            DgvTabla.Columns["PersonaId"].Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void DgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedPersona = DgvTabla.SelectedRows[0].DataBoundItem as Persona;
                txtPersonaId.Text = selectedPersona.PersonaId.ToString();
                txtNombre.Text = selectedPersona.Nombre;
                txtApellido.Text = selectedPersona.Apellido;
                txtProfesion.Text = selectedPersona.Profesion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error: " + ex.Message + " - " + ex.Source);
            }
        }
    }
}
