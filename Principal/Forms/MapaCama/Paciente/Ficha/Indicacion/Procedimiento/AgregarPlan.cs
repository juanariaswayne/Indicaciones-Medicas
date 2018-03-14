using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public partial class AgregarPlan : MetroForm
    {
        public Dictionary<int, string> alimentosAAgregar;
        private Dictionary<int, string> alimentosAEliminar;
        public AgregarPlan formActual; // Referencia al form actual usada para recibir datos del siguiente form

        public AgregarPlan()
        {
            InitializeComponent();

            formActual = this;
            alimentosAAgregar = new Dictionary<int, string>();
            alimentosAEliminar = new Dictionary<int, string>();

            btnGuardar.Enabled = false;
            // Cargo el combo-box con los alimentos correspondientes al
            // horario de administracion por defecto
            SISTMEDEntities E = new SISTMEDEntities();

            var horarios_administracion = from h in E.PRO_Alimento_Horarios_Administracion select new { h.id, h.descripcion };

            // Obtengo el id del horario de administracion por defecto (es decir el primer elemento)
            int iteracion = 1;
            int primer_horario_administracion = -1;
            foreach (var ha in horarios_administracion)
            {
                if (iteracion == 1)
                    primer_horario_administracion = ha.id;
                cmbBoxHorarioAdministracion.Items.Add(ha.descripcion);
                iteracion++;
            }
            cmbBoxHorarioAdministracion.SelectedIndex = 0;

            // Obtener los alimentos que consume el paciente en ese horario de administracion
            var alimentos = from x in E.PRO_Alimento
                                            join y in E.PRO_Alimento_Paciente on x.alimento_id equals y.id_alimento
                                            join z in E.PRO_Alimento_Horarios_Administracion on y.id_horario_administracion equals z.id
                                            where z.id == primer_horario_administracion
                                            select new { x.alimento_id, x.descripcion };

            datagridAlimentosSeleccionados.Rows.Clear();
            // Cargo los datos en el combo-box
            int indice;
            foreach (var alimento in alimentos)
            {
                indice = datagridAlimentosSeleccionados.Rows.Add();
                datagridAlimentosSeleccionados.Rows[indice].Cells["Alimentos"].Value = alimento.descripcion;
                datagridAlimentosSeleccionados.Rows[indice].Cells["id"].Value = alimento.alimento_id;
            }
        }

        // Abre la pantalla para agregar alimentos al plan nutricional
        // y luego se queda esperando los datos que se seleccionen
        private void btnAgregarAlimentos_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadActualDeFilas = datagridAlimentosSeleccionados.Rows.Count;
                FrmAgregarAlimentos frmAgregarAlimentos = new FrmAgregarAlimentos(formActual);

                if (frmAgregarAlimentos.ShowDialog() == DialogResult.OK)
                {
                    int indice;
                    bool repetido = false;
                    for (int i = 0; i < alimentosAAgregar.Count; i++)
                    {
                        // Me fijo si el elemento ya está en el datagridview
                        foreach (DataGridViewRow row in datagridAlimentosSeleccionados.Rows)
                        {
                            if (row.Cells["Alimentos"].Value.ToString().Equals(alimentosAAgregar.Values.ElementAt(i)))
                                repetido = true;
                        }

                        // Si el elemento no está ya en el datagridview lo agrego
                        if (repetido == false)
                        {
                            indice = datagridAlimentosSeleccionados.Rows.Add();

                            datagridAlimentosSeleccionados.Rows[indice].Cells["Alimentos"].Value = alimentosAAgregar.Values.ElementAt(i);
                            datagridAlimentosSeleccionados.Rows[indice].Cells["id"].Value = alimentosAAgregar.Keys.ElementAt(i);
                        }
                        repetido = false;
                    }

                    if (cantidadActualDeFilas != datagridAlimentosSeleccionados.Rows.Count)
                    {
                        btnGuardar.Enabled = true;
                        cmbBoxHorarioAdministracion.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cmbBoxHorarioAdministracion.Enabled = true;

            // Obtengo los datos que voy a guardar en la bd
            SISTMEDEntities E = new SISTMEDEntities();
            
            string observaciones = (txtObservacion.Text != null) ? txtObservacion.Text : "";
            int idpaciente = Clases.Paciente.PacienteIngresado;
            int id_horarioadministracion_elegido = (from h in E.PRO_Alimento_Horarios_Administracion
                                           where h.descripcion.Equals(cmbBoxHorarioAdministracion.SelectedItem.ToString())
                                           select h.id).Single();



            // Guardo los que haya que guardar
            if(alimentosAAgregar.Count > 0)
            {
                var filas = E.PRO_Alimento_Paciente;
                for (int i = 0; i < alimentosAAgregar.Count; i++)
                {
                    filas.Add(new PRO_Alimento_Paciente()
                    {
                        id_alimento = alimentosAAgregar.Keys.ElementAt(i),
                        id_paciente = idpaciente,
                        id_horario_administracion = id_horarioadministracion_elegido,
                        observacion = observaciones
                    });
                }

                E.SaveChanges();
                alimentosAAgregar.Clear();
            }

            // Elimino los que haya que eliminar de los que ya estaban
            if(alimentosAEliminar.Count > 0)
            {
                var filas = E.PRO_Alimento_Paciente;
                for (int i = 0; i < alimentosAEliminar.Count; i++)
                {
                    int id_alimentoAEliminar = Convert.ToInt32(alimentosAEliminar.Keys.ElementAt(i));
                    //Console.WriteLine("id alimento a eliminar: " + id_alimentoAEliminar);
                    var filaAEliminar = filas.FirstOrDefault(x => x.id_paciente == idpaciente &&
                                                             x.id_horario_administracion == id_horarioadministracion_elegido &&
                                                             x.id_alimento == id_alimentoAEliminar);
                    //Console.WriteLine("obtuve la fila");
                    if (filaAEliminar != null)
                    {
                        filas.Remove(filaAEliminar);
                        //Console.WriteLine("Elimine la fila");
                    }
                }

                E.SaveChanges();
                alimentosAEliminar.Clear();
                //Console.WriteLine("Elimine los alimentos seleccionados");
            }
            btnGuardar.Enabled = false;
        }


        private void cmbBoxHorarioAdministracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            SISTMEDEntities E = new SISTMEDEntities();

            string horario = cmbBoxHorarioAdministracion.SelectedItem.ToString();

            int id_horarioadministracion = (from h in E.PRO_Alimento_Horarios_Administracion
                                            where h.descripcion.Equals(cmbBoxHorarioAdministracion.SelectedItem.ToString())
                                            select h.id).Single();

            // Obtener los alimentos que consume el paciente en ese horario de administracion
            IEnumerable<string> alimentos = from x in E.PRO_Alimento
                                            join y in E.PRO_Alimento_Paciente on x.alimento_id equals y.id_alimento
                                            join z in E.PRO_Alimento_Horarios_Administracion on y.id_horario_administracion equals z.id
                                            where z.id == id_horarioadministracion
                                            select x.descripcion;

            datagridAlimentosSeleccionados.Rows.Clear();
            // Cargo los datos en el combo-box
            int indice;
            foreach (string alimento in alimentos)
            {
                indice = datagridAlimentosSeleccionados.Rows.Add();
                datagridAlimentosSeleccionados.Rows[indice].Cells["Alimentos"].Value = alimento;
            }
        }

        private void datagridAlimentosSeleccionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                // PROBLEMA: los id estan vacios en el grid
                // El usuario quiere eliminar el alimento
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if(!alimentosAEliminar.ContainsKey(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["id"].Value)))
                        alimentosAEliminar.Add(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["id"].Value), senderGrid.Rows[e.RowIndex].Cells["Alimentos"].Value.ToString());
                    //Console.WriteLine("Agregue a alimentosAEliminar: " + Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["id"].Value) + " - " + senderGrid.Rows[e.RowIndex].Cells["Alimentos"].Value.ToString());
                    if (alimentosAAgregar.ContainsKey(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["id"].Value)) == true)
                        alimentosAAgregar.Remove(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["id"].Value));
                    datagridAlimentosSeleccionados.Rows.RemoveAt(e.RowIndex);
                    btnGuardar.Enabled = true;
                    cmbBoxHorarioAdministracion.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error22", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnGuardar.Enabled == true)
            {
                var respuesta = MessageBox.Show("¿Desea descartar los cambios realizados?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {

                }
            }


        }
    }
}