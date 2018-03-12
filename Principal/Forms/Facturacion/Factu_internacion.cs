using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.Facturacion
{
    public partial class Factu_internacion : MetroForm
    {
        SISTMEDEntities E = new SISTMEDEntities();

        public Factu_internacion()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Descripcion: Devuelve la edad del paciente teniendo en cuenta la fecha actual
        /// </summary>
        /// <param name="fechaNacimiento">Fecha de nacimiento del paciente</param>
        /// <returns> La edad del paciente </returns>
        private static Int32 CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime temp = fechaNacimiento;
            Int32 age = 0;
            while ((temp = temp.AddYears(1)) < DateTime.Now)
                age++;
            return age;
        }

        private string traeObraSocial(int paciente_id)
        {
            var q = (from p in E.Pacientes
                    join o in E.OBRA_SOCIAL on p.obraSocial_id equals o.codigo_os
                    where p.paciente_id == paciente_id
                    select new { descOS = o.descripcion_obraSocial }).Single();
            return (q.descOS != null)? q.descOS : "-";
        }



        private void Factu_internacion_Load(object sender, EventArgs e)
        {
            Pacientes p = E.Pacientes.Find(Clases.Paciente.PacienteIngresado);
            this.nombre_paciente.Text = p.nombre;
            this.apellido_paciente.Text = p.apellido;
            this.edad.Text = CalcularEdad(p.fechaNacimiento.Value).ToString();
            this.dni_paciente.Text = p.numeroDocumento.ToString();
            this.sede.Text = p.Habitaciones.Sedes.descripcion;
            this.habitacion_sede.Text = p.Habitaciones.descripcion.ToString();
            this.obra_social.Text = traeObraSocial(p.paciente_id);
            this.num_afiliado.Text = (this.obra_social.Text == "-")? "-" : p.numeroObraSocial;
            this.diagnostico.Text = p.MED_Diagnosticos.Diagnostico;
        }
    }
}
