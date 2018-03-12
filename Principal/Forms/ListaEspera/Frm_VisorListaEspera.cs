using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Linq.Dynamic;

namespace Principal.Forms.ListaEspera
{
    public partial class Frm_VisorListaEspera : MetroForm
    {
        #region Variables
        enum Col_Visor
        {
            COL_ESPERA_ID = 0,
            COL_PUNTAJE,
            COL_FECHA,
            COL_OS,
            COL_APELLIDO,
            COL_NOMBRE,
            COL_EDAD,
            COL_SEXO,
            COL_DIAGNOSTICO,
            COL_CULTIVO,
            COL_FHISOPADO,
            COL_VTO_HISPODADO,
            COL_MODULOS,
            COL_DERIVA,
            COL_DESCRIP_DERIVA,
            COL_MOTIVO_EGRESO,
            COL_SEDE_ID,
            COL_SEDE,
            COL_CAMA_DADA,
            COL_OBS,
            COL_CAMA_CONFIRMADA,
            COL_FECHA_CONFIRMACION_CAMA
            


        }

        SISTMEDEntities _Mod = new SISTMEDEntities();
        List<TraeVisorListaEspera_Result> _listaEspera = new List<TraeVisorListaEspera_Result>();
        SISTMEDEntities _Stored = new SISTMEDEntities();
        int _listaEsperaUpdate = 0;
        #endregion

        #region Funciones
        public Frm_VisorListaEspera()
        {
            InitializeComponent();
        }

        private void TraeObraSocial()
        {
            try
            {
                var _listObj = (from Tipos in _Stored.TraeObrasSociales()
                                orderby Tipos.cli_RazSoc
                                select Tipos).ToList();

                TraeObrasSociales_Result _itemSeleccion = new TraeObrasSociales_Result();//  ENTITIES QUE GENERA EL E. FRAMEWORK CUANDO ES UN STORED

                //Limpia el combo
                comboBoxOS.SuspendLayout();
                comboBoxOS.DataSource = null;
                comboBoxOS.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.cli_RazSoc = "<Seleccione una Obra Social>";
                _itemSeleccion.cli_Cod = "0";
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                comboBoxOS.DisplayMember = "cli_RazSoc";
                comboBoxOS.ValueMember = "cli_Cod";
                comboBoxOS.DataSource = _listObj.ToArray();
                comboBoxOS.SelectedIndex = 0;

                comboBoxOS.ResumeLayout();

            }

            catch (Exception ex)
            {


            }

        }

        private void TraerModulos()
        {
            try
            {
                var _listObj = (from M in _Mod.MED_Modulo select M).ToList();


                MED_Modulo _itemSeleccion = new MED_Modulo();

                //Limpia el combo
                comboBoxModulo.SuspendLayout();
                comboBoxModulo.DataSource = null;
                comboBoxModulo.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.Descripcion = "<Seleccione un Módulo>";
                _itemSeleccion.modulo_id = "0";
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                comboBoxModulo.DisplayMember = "Descripcion";
                comboBoxModulo.ValueMember = "modulo_id";
                comboBoxModulo.DataSource = _listObj.ToArray();
                comboBoxModulo.SelectedIndex = 0;

                comboBoxModulo.ResumeLayout();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraerDiagnosticos()
        {
            try
            {
                var _listObj = (from M in _Mod.MED_Diagnosticos select M).OrderBy(x => x.Diagnostico).ToList();


                MED_Diagnosticos _itemSeleccion = new MED_Diagnosticos();

                //Limpia el combo
                comboBoxDiagnostico.SuspendLayout();
                comboBoxDiagnostico.DataSource = null;
                comboBoxDiagnostico.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.Diagnostico = "<Seleccione un Diagnóstico>";
                _itemSeleccion.diagnostico_id = 0;
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                comboBoxDiagnostico.DisplayMember = "Diagnostico";
                comboBoxDiagnostico.ValueMember = "diagnostico_id";
                comboBoxDiagnostico.DataSource = _listObj.ToArray();
                comboBoxDiagnostico.SelectedIndex = 0;

                comboBoxDiagnostico.ResumeLayout();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraeListaEspera(bool conScoring, bool soloOrdena)
        {
            try
            {


                ///
                if (soloOrdena) //SOLO ORDENO LA LISTA EXISTENTE, NO EJECUTO DE NUEVO EL STORED
                {
                    if (conScoring)
                    {
                        _listaEspera = _listaEspera.OrderByDescending(p => p.Puntaje).ToList();
                    }
                    else
                    {
                        _listaEspera = _listaEspera.OrderBy(p => p.espera_id).ToList();
                    }

                }
                else //EJECUTO EL STORED
                {
                    _listaEspera = _Mod.TraeVisorListaEspera().ToList();

                    if (conScoring)
                    {
                        _listaEspera = _listaEspera.OrderByDescending(p => p.Puntaje).ToList();
                    }
                    else
                    {
                        _listaEspera = _listaEspera.OrderBy(p => p.espera_id).ToList();
                    }
                }


                dataGridViewLista.Rows.Clear();
                dataGridViewLista.Columns[(int)Col_Visor.COL_MOTIVO_EGRESO].Visible = false;
                int indice = 0;
                foreach (var item in _listaEspera)
                {
                    indice = dataGridViewLista.Rows.Add();

                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_ESPERA_ID].Value = item.espera_id;
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_PUNTAJE].Value = (item.Puntaje == 999999999) ? "Recomendado" : item.Puntaje.ToString(); // PUNTAJE
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_FECHA].Value = Convert.ToDateTime(item.fechaIngreso).ToShortDateString(); //FECHA INGRESO A LA LISTA
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_OS].Value = item.ObraSocial; //OBRA SOCIAL
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_APELLIDO].Value = item.apellido; //APELLIDO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_NOMBRE].Value = item.nombre; //NOMBRE
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_EDAD].Value = item.edad; //EDAD
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEXO].Value = item.genero; //GENERO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_DIAGNOSTICO].Value = item.Diagnostico; // DIAGNOSTICO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CULTIVO].Value = item.UltimoCultivo; // ULTIMO CULTIVO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_FHISOPADO].Value = Convert.ToDateTime(item.UltimaFecha).ToShortDateString(); // ULTIMO FECHA CULTIVO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_VTO_HISPODADO].Value = Convert.ToDateTime(item.UltimoVto).ToShortDateString(); // ULTIMO  VTO CULTIVO


                    //PRIMERO VEO SI TIENE CAMA DADA
                    if (Convert.ToBoolean(item.camaDada))
                    {
                        //TIENE LA CAMA CONFIRMADA...LO PINTO DE OTRO COLOR
                        dataGridViewLista.Rows[indice].DefaultCellStyle.BackColor = Color.MistyRose;

                    }
                    // EN EL SIGUIENTE ORDEN, VEO SI TIENE CAMA CONFIRMADA
                    if (Convert.ToBoolean(item.confirmaCama))
                    {
                        //TIENE LA CAMA CONFIRMADA...LO PINTO DE OTRO COLOR
                        dataGridViewLista.Rows[indice].DefaultCellStyle.BackColor = Color.PaleGreen;

                    }

                    //SI ESTA VENCIDO LO PINTO DE ROJO
                    if (item.UltimoCultivo != "PEN")
                    {
                        int result = DateTime.Compare(Convert.ToDateTime(item.UltimoVto), Convert.ToDateTime(DateTime.Now));
                         if (result < 0 )
                        {
                            dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_VTO_HISPODADO].Style.BackColor = Color.Red;
                        }
                       
                    }
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_MODULOS].Value = item.Modulos; // MODULOS
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_DESCRIP_DERIVA].Value = item.DescripDeriva; // DERIVA
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_OBS].Value = item.obs; //OBS
                                      
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEDE_ID].Value = item.sedeSugerida; // SEDE SUGERIDA_ID
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEDE].Value = item.Sede; //SEDE
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CAMA_DADA].Value = (item.camaDada == true) ? "S" : "N"; //PIDE HABITACION INDIVIDAUL

                 

                    string _historiaHisopado=string.Empty;
                    int i = 0;
                    foreach (MED_CultivosListaEspera itemCultivo in _Mod.MED_CultivosListaEspera.ToList().Where(x => x.espera_id == item.espera_id).OrderByDescending(x=> x.Fecha))
                    {
                        if(i==0)
                        {
                            _historiaHisopado = "Cultivo: "+ itemCultivo.Cultivo.ToString() + " - Fecha: " + Convert.ToDateTime(itemCultivo.Fecha).ToShortDateString() + "  F.Vto: " + Convert.ToDateTime(itemCultivo.FechaVto).ToShortDateString() + "\n\r";
                        }
                        else
                        {
                            _historiaHisopado = _historiaHisopado + "Cultivo: " + itemCultivo.Cultivo.ToString() + " - Fecha: " + Convert.ToDateTime(itemCultivo.Fecha).ToShortDateString() + " F.Vto: " + Convert.ToDateTime(itemCultivo.FechaVto).ToShortDateString() + "\n\r";
                        }
                        i++;
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CULTIVO].ToolTipText = _historiaHisopado;
                    }
                    indice++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ///

        }

        private void ReingresoListaEspera(Object sender, EventArgs e)
        {
            //codigo para mostrar formulario
            
            if (_listaEsperaUpdate > 0)
            {
                //CAMBIO EL ESTADO EN LA LISTA DE ESpÈRA

                Clases.IndicacionesBLL.ListaEspera _saveObj = new Clases.IndicacionesBLL.ListaEspera();
                if (_saveObj.ReingresaListaEspera(_listaEsperaUpdate))
                {
                    TraerEliminados();
                    MessageBox.Show("Reingreso a Lista correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error reingreso lista de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                

            }
            else
            {
                MessageBox.Show("Debe seleccionar un Paciente para el ingreso a la lista de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TraerEliminados()
        {
            try
            {
                SISTMEDEntities _ModElimina = new SISTMEDEntities();
                DateTime _fechaDesde = Convert.ToDateTime(this.dateTimeDesde.Value.ToString("yyyy-MM-dd 00:00:00"));
                DateTime _fechaHasta = Convert.ToDateTime(this.dateTimeHasta.Value.ToString("yyyy-MM-dd 23:59:59"));

                var _listaEliminados = _ModElimina.TraeVisorListaEsperaEliminados(_fechaDesde, _fechaHasta).ToList().OrderBy(m=> m.fechaEgreso);


                dataGridViewLista.Rows.Clear();
                //MOTIVO... PRIMERO PONGO VISIBLE LA COLUMNA QUE POR DEFAUL VIENE EN FALSE
                dataGridViewLista.Columns[(int)Col_Visor.COL_MOTIVO_EGRESO].Visible = true;
                int indice = 0;
                foreach (var item in _listaEliminados)
                {
                    indice = dataGridViewLista.Rows.Add();

                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_ESPERA_ID].Value = item.espera_id;
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_PUNTAJE].Value = (item.Puntaje == 999999999) ? "Recomendado" : item.Puntaje.ToString(); // PUNTAJE
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_FECHA].Value = Convert.ToDateTime(item.fechaIngreso).ToShortDateString(); //FECHA INGRESO A LA LISTA
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_OS].Value = item.ObraSocial; //OBRA SOCIAL
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_APELLIDO].Value = item.apellido; //APELLIDO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_NOMBRE].Value = item.nombre; //NOMBRE
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_EDAD].Value = item.edad; //EDAD
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEXO].Value = item.genero; //GENERO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_DIAGNOSTICO].Value = item.Diagnostico; // DIAGNOSTICO
                                      dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CULTIVO].Value = item.UltimoCultivo; // ULTIMO CULTIVO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_FHISOPADO].Value = Convert.ToDateTime(item.UltimaFecha).ToShortDateString(); // ULTIMO FECHA CULTIVO
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_VTO_HISPODADO].Value = Convert.ToDateTime(item.UltimoVto).ToShortDateString(); // ULTIMO  VTO CULTIVO
                    if (item.UltimoCultivo != "PEN")
                    {
                        int result = DateTime.Compare(Convert.ToDateTime(item.UltimoVto), Convert.ToDateTime(DateTime.Now));
                        if (result < 0)
                        {
                            dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_VTO_HISPODADO].Style.BackColor = Color.Red;
                        }

                    }

                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_MODULOS].Value = item.Modulos; // MODULOS
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_DESCRIP_DERIVA].Value = item.DescripDeriva; // DERIVA
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_OBS].Value = item.obs; //OBS
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEDE_ID].Value = item.sedeSugerida; // SEDE SUGERIDA_ID
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEDE].Value = item.Sede; //SEDE
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CAMA_DADA].Value = (item.camaDada == true) ? "S" : "N"; //PIDE HABITACION INDIVIDAUL
                    dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_MOTIVO_EGRESO].Value = item.MotivoEgreso; //motivo egreso

                    string _historiaHisopado = string.Empty;
                    int i = 0;
                    foreach (MED_CultivosListaEspera itemCultivo in _Mod.MED_CultivosListaEspera.ToList().Where(x => x.espera_id == item.espera_id).OrderByDescending(x => x.Fecha))
                    {
                        if (i == 0)
                        {
                            _historiaHisopado = "Cultivo: " + itemCultivo.Cultivo.ToString() + " - Fecha: " + Convert.ToDateTime(itemCultivo.Fecha).ToShortDateString() + "  F.Vto: " + Convert.ToDateTime(itemCultivo.FechaVto).ToShortDateString() + "\n\r";
                        }
                        else
                        {
                            _historiaHisopado = _historiaHisopado + "Cultivo: " + itemCultivo.Cultivo.ToString() + " - Fecha: " + Convert.ToDateTime(itemCultivo.Fecha).ToShortDateString() + " F.Vto: " + Convert.ToDateTime(itemCultivo.FechaVto).ToShortDateString() + "\n\r";
                        }
                        i++;
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CULTIVO].ToolTipText = _historiaHisopado;
                    }

                    

                    indice++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ///

        }
        #endregion

        #region Eventos
        private void Frm_VisorListaEspera_Load(object sender, EventArgs e)
        {
            //CONFIGURO ORIGEN DE DATOS DEL 
            TraeListaEspera(false, false);

            TraeObraSocial();
            TraerModulos();
            TraerDiagnosticos();
            dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }


        #endregion

        private void radioSinScoring_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSinScoring.Checked)
            {
                TraeListaEspera(false, true);
            }
            else
            {
                TraeListaEspera(true, true);

            }
        }

        private void radioConScoring_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSinScoring.Checked)
            {
                TraeListaEspera(false, true);
            }
            else
            {
                TraeListaEspera(true, true);

            }
        }

        private void checkBoxOS_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOS.Visible = (checkBoxOS.Checked) ? true : false;
            comboBoxOS.SelectedIndex = 0;
        }

        private void checkBoxMes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMes.Checked)
            {
                groupBoxAnio.Visible = true;
                labelAnio.Visible = true;
                labelMes.Visible = true;
                textBoxAnio.Visible = true;
                textBoxMes.Visible = true;
                textBoxAnio.Text = DateTime.Now.Year.ToString();
                textBoxMes.Focus();
            }
            else
            {
                textBoxAnio.Text = string.Empty;
                textBoxMes.Text = string.Empty;
                labelAnio.Visible = false;
                labelMes.Visible = false;
                textBoxAnio.Visible = false;
                textBoxMes.Visible = false;
                groupBoxAnio.Visible = false;
            }
        }

        private void checkBoxSexo_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSexo.Visible = (checkBoxSexo.Checked) ? true : false;
        }

        private void checkBoxModulo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxModulo.Visible = (checkBoxModulo.Checked) ? true : false;
            comboBoxModulo.SelectedIndex = 0;
        }

        private void checkBoxDiagnostico_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDiagnostico.Visible = (checkBoxDiagnostico.Checked) ? true : false;
            comboBoxDiagnostico.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTileFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                //APLICA FILSTROS
                TraeVisorListaEspera_Result _listaFiltro = new TraeVisorListaEspera_Result();
                List<TraeVisorListaEspera_Result> _listaFinal = new List<TraeVisorListaEspera_Result>();
                bool _selecciono = false;
                bool _seleccionoModulo = false;

                //Creacion del objeto de filtro
                var ListaFiltro = new TraeVisorListaEspera_Result();


                //FILSTRO POR O.S.
                if (comboBoxOS.SelectedIndex > 0)
                {
                    ListaFiltro.obraSocial_id = comboBoxOS.SelectedValue.ToString();
                    _selecciono = true;
                }

                // MES

                if (checkBoxMes.Checked && textBoxMes.Text != string.Empty && textBoxAnio.Text != string.Empty)
                {
                    ListaFiltro.Anio = Convert.ToInt16(textBoxAnio.Text.Trim());
                    ListaFiltro.Mes = Convert.ToInt16(textBoxMes.Text.Trim());
                    _selecciono = true;
                }
                // sexo
                if (checkBoxSexo.Checked)
                {
                    string _sexo = (radioButtonFem.Checked) ? "F" : "M";
                    ListaFiltro.genero = _sexo;
                    _selecciono = true;
                }
                // por modulo

                if (comboBoxModulo.SelectedIndex > 0)
                {
                    ListaFiltro.Modulos = comboBoxModulo.SelectedValue.ToString();
                    _seleccionoModulo = true;
                }

                //DIAGNOSTICO
                if (comboBoxDiagnostico.SelectedIndex > 0)
                {

                    ListaFiltro.diagnostico_id = Convert.ToInt32(comboBoxDiagnostico.SelectedValue);
                    _selecciono = true;
                }

                //CULTIVOS
                if(checkBoxCultivo.Visible)
                {
                    //if(checkBoxPOS.Checked)
                    //{
                    //    _listaFiltro.UltimoCultivo = "POS";
                    //    _selecciono = true;
                    //}
                    //if (checkBoxNEG.Checked)
                    //{
                    //    _listaFiltro.UltimoCultivo = "NEG";
                    //    _selecciono = true;
                    //}
                    //if (checkBoxPEN.Checked)
                    //{
                    //    _listaFiltro.UltimoCultivo = "PEN";
                    //    _selecciono = true;
                    //}


                }
               
                //EN CASO DE HABER SELECCIONADO UN MODULO... PRIMERO HAGO UN PRE FILTRADO DE TODA LA LISTA POR ESE CAMPPO
                if (_seleccionoModulo)
                {
                    //_listaFinal = _listaEspera.Where(x => x.Modulos.Contains(ListaFiltro.Modulos)).ToList();
                    // ListaFiltro.Modulos = null; //PARA QUE NO LO TOME EN EL ARMADO DEL PREDICADO

                }
                // FIN PRE FILTRADO



                if (!_selecciono)
                {


                    //COMO NO SELECCIONO NADA.. CARGO LA LISTA...NORMALMENTE
                    TraeListaEspera(false, true);

                }

                else
                {


                    //Separacion de las propiedades que el usuario seleccionó
                    var properties = ListaFiltro
                    .GetType()
                    .GetProperties()
                    .Where(x => x.GetValue(ListaFiltro, null) != null && x.GetValue(ListaFiltro, null).ToString() != "0");



                    //Creacion de un diccionario que contendrá nombre de la propiedad y valor
                    var diccionario = properties.ToDictionary(propiedad => propiedad.Name, propiedad => propiedad.GetValue(ListaFiltro, null));

                    //Creacion del predicado
                    IEnumerable<string> filtros = diccionario.Keys.Select( (clave, index) => string.Format("{0} == @{1}", clave, index));
                    
                    string predicado = string.Join(" and ", filtros);


                    //resultado
                    var resultado = _listaEspera.AsQueryable()
                    .Where(predicado, diccionario.Values.ToArray());




                    dataGridViewLista.Rows.Clear();
                    int indice = 0;
                    foreach (var item in resultado)
                    {
                        indice = dataGridViewLista.Rows.Add();

                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_PUNTAJE].Value = (item.Puntaje == 999999999) ? "Recomendado" : item.Puntaje.ToString(); // PUNTAJE
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_FECHA].Value = Convert.ToDateTime(item.fechaIngreso).ToShortDateString(); //FECHA INGRESO A LA LISTA
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_OS].Value = item.ObraSocial; //OBRA SOCIAL
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_APELLIDO].Value = item.apellido; //APELLIDO
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_NOMBRE].Value = item.nombre; //NOMBRE
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_EDAD].Value = item.edad; //EDAD
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEXO].Value = item.genero; //GENERO
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_DIAGNOSTICO].Value = item.Diagnostico; // DIAGNOSTICO
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CULTIVO].Value = item.UltimoCultivo; // ULTIMO CULTIVO
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_FHISOPADO].Value = Convert.ToDateTime(item.UltimaFecha).ToShortDateString(); // ULTIMO FECHA CULTIVO
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_VTO_HISPODADO].Value = Convert.ToDateTime(item.UltimoVto).ToShortDateString(); // ULTIMO  VTO CULTIVO
                                                                                                                                                               //SI ESTA VENCIDO LO PINTO DE ROJO
                        if (item.UltimoCultivo != "PEN")
                        {
                            int result = DateTime.Compare(Convert.ToDateTime(item.UltimoVto), Convert.ToDateTime(DateTime.Now));
                            if (result < 0)
                            {
                                dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_VTO_HISPODADO].Style.BackColor = Color.Red;
                            }

                        }
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_MODULOS].Value = item.Modulos; // MODULOS
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_DESCRIP_DERIVA].Value = item.DescripDeriva; // DERIVA
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_OBS].Value = item.obs; //OBS

                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEDE_ID].Value = item.sedeSugerida; // SEDE SUGERIDA_ID
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_SEDE].Value = item.Sede; //SEDE
                        dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CAMA_DADA].Value = (item.camaDada == true) ? "S" : "N"; //PIDE HABITACION INDIVIDAUL

                        string _historiaHisopado = string.Empty;
                        int i = 0;
                        foreach (MED_CultivosListaEspera itemCultivo in _Mod.MED_CultivosListaEspera.ToList().Where(x => x.espera_id == item.espera_id).OrderByDescending(x => x.Fecha))
                        {
                            if (i == 0)
                            {
                                _historiaHisopado = "Cultivo: " + itemCultivo.Cultivo.ToString() + " - Fecha: " + Convert.ToDateTime(itemCultivo.Fecha).ToShortDateString() + "  F.Vto: " + Convert.ToDateTime(itemCultivo.FechaVto).ToShortDateString() + "\n\r";
                            }
                            else
                            {
                                _historiaHisopado = _historiaHisopado + "Cultivo: " + itemCultivo.Cultivo.ToString() + " - Fecha: " + Convert.ToDateTime(itemCultivo.Fecha).ToShortDateString() + " F.Vto: " + Convert.ToDateTime(itemCultivo.FechaVto).ToShortDateString() + "\n\r";
                            }
                            i++;
                            dataGridViewLista.Rows[indice].Cells[(int)Col_Visor.COL_CULTIVO].ToolTipText = _historiaHisopado;
                        }
                        

                        indice++;

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxCultivo_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCultivo.Visible = (checkBoxCultivo.Checked) ? true : false;
        }

        private void dataGridViewLista_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewLista.IsCurrentCellDirty)
                dataGridViewLista.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewLista_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxEliminados.Checked) //SOLO PARA ELIMINADOS
            {
                if (e.Button == MouseButtons.Right)
                {
                    //ESTO PARA ASEGURAR QUE ESTOY SELECCIONADO UNA CELDA DEL GRID
                    DataGridView.HitTestInfo Hitest = dataGridViewLista.HitTest(e.X, e.Y);
                    if (Hitest.Type == DataGridViewHitTestType.Cell)
                    {
                        if (Hitest.RowIndex >= 0)
                        {
                            dataGridViewLista.CurrentCell = dataGridViewLista.Rows[Hitest.RowIndex].Cells[Hitest.ColumnIndex];
                            dataGridViewLista.Rows[Hitest.RowIndex].Selected = true;

                            ContextMenuStrip m = new ContextMenuStrip();

                            //m.MenuItems.Add(new MenuItem("Egreso Lista Espera"));
                            //m.MenuItems.Add(new MenuItem("Copy"));
                            //m.MenuItems.Add(new MenuItem("Paste"));

                            // m.Show(dataGridViewListaEspera, new Point(e.X, e.Y));
                            m.Items.Add("Reingresar a Lista de Espera", null, ReingresoListaEspera);

                            m.Show(dataGridViewLista, new Point(e.X, e.Y));
                        }
                    }
                }

            }
        }

        private void dataGridViewLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {


                    _listaEsperaUpdate = Convert.ToInt32(dataGridViewLista.Rows[e.RowIndex].Cells[(int)Col_Visor.COL_ESPERA_ID].Value);// LISTAESPERA_ID

                }

            }
            catch (Exception ex)
            {


            }
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxEliminados.Checked)
            {

                TraerEliminados();
            }
        }

        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxEliminados.Checked)
            {

                TraerEliminados();
            }
        }

        private void checkBoxEliminados_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(checkBoxEliminados.Checked)
                {
                    TraerEliminados();
                    labelMouse.Visible = true;
                }
                else
                {
                    TraeListaEspera(false, false);
                    labelMouse.Visible = false;
                }

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == this.dataGridViewLista.Columns["Cultivo"].Index)
            //{

            //    DataGridViewCell cell = this.dataGridViewLista.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //    if (e.Value.Equals("Cultivo"))
            //    {
            //     cell.ToolTipText = e.Value.ToString() ;
            //    }
            //    //else if (e.Value.Equals("**"))
            //    //{
            //    //    cell.ToolTipText = "bad";
            //    //}
            //    //else if (e.Value.Equals("***"))
            //    //{
            //    //    cell.ToolTipText = "good";
            //    //}
            //    //else if (e.Value.Equals("****"))
            //    //{
            //    //    cell.ToolTipText = "very good";
            //    //}
            //}
        }
    }
}
