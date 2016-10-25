using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Entidades;

namespace EjemploTestDetail2
{
    public partial class Ejemplo : Form
    {
        public Ejemplo()
        {
            InitializeComponent();
        }

        private Grupos grupos = new Grupos();

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            grupos.Estudiantes.Add(new Estudiantes((int)EstudianteIdcomboBox.SelectedValue, EstudianteIdcomboBox.Text));
            EstudiantesdataGridView.DataSource = null;
            EstudiantesdataGridView.DataSource = grupos.Estudiantes;

           
        }


        private void EstudianteIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void Ejemplo_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void LlenarCombo()
        {
            EstudianteIdcomboBox.DataSource = EstudiantesBLL.GetLista();
            EstudianteIdcomboBox.DisplayMember = "nombreEstudiantes";
            EstudianteIdcomboBox.ValueMember = "estudiantesId";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var estudiante = new Estudiantes();
            estudiante.nombreEstudiantes = "Yinet";
            EstudiantesBLL.Insertar(estudiante);
            LlenarCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grupos.grupoNombres = NombreGrupotextBox.Text;
            grupos.Estudiantes = grupos.Estudiantes;

            GruposBLL.Insertar(grupos);
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
