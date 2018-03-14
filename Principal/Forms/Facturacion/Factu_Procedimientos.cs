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
    public partial class Factu_Procedimientos : MetroForm
    {
        #region Variables

        SISTMEDEntities E = new SISTMEDEntities();

        private enum Col_Procedimiento
        {
            SUMINISTRO_ID = 0,
            ID_PROCEDIMIENTO,
            ID_GENERICO,
            INICIO,
            ID_SUMINISTRO,
            PROCEDIMIENTO,
            HORARIO,
            DIAS,
            OBS,
            FIN,
            CHECK,
            TIPO
        }

        private enum Col_Descartables
        {
            ID_CIERRE = 0,
            ID_SUMINISTRO,
            COD_DESCARTABLE,
            DESCARTABLE,
            CANTIDAD,
            TIPO
        }
        #endregion

        #region Funciones
        public Factu_Procedimientos()
        {
            InitializeComponent();
        }

        private string HorarioSuministroProc(PRO_SuministroDeProcedimiento_Historico _itemProcedimiento)
        {
            try
            {
                String _Horario;
                _Horario = "";
                if (_itemProcedimiento.h00 == true) //Turno Noche
                {
                    _Horario = "24-" + _Horario;
                }
                if (_itemProcedimiento.h23 == true)
                {
                    _Horario = "23-" + _Horario;
                }
                if (_itemProcedimiento.h22 == true)
                {
                    _Horario = "22-" + _Horario;
                }
                if (_itemProcedimiento.h21 == true)
                {
                    _Horario = "21-" + _Horario;
                }
                if (_itemProcedimiento.h20 == true)
                {
                    _Horario = "20-" + _Horario;
                }
                if (_itemProcedimiento.h19 == true)
                {
                    _Horario = "19-" + _Horario;
                }
                if (_itemProcedimiento.h18 == true)
                {
                    _Horario = "18-" + _Horario;
                }
                if (_itemProcedimiento.h17 == true)
                {
                    _Horario = "17-" + _Horario;
                }
                if (_itemProcedimiento.h16 == true)
                {
                    _Horario = "16-" + _Horario;
                }
                if (_itemProcedimiento.h15 == true)
                {
                    _Horario = "15-" + _Horario;
                }
                if (_itemProcedimiento.h14 == true)
                {
                    _Horario = "14-" + _Horario;
                }
                if (_itemProcedimiento.h13 == true)
                {
                    _Horario = "13-" + _Horario;
                }
                if (_itemProcedimiento.h12 == true)
                {
                    _Horario = "12-" + _Horario;
                }
                if (_itemProcedimiento.h11 == true)
                {
                    _Horario = "11-" + _Horario;
                }
                if (_itemProcedimiento.h10 == true)
                {
                    _Horario = "10-" + _Horario;
                }
                if (_itemProcedimiento.h09 == true)
                {
                    _Horario = "09-" + _Horario;
                }
                if (_itemProcedimiento.h08 == true)
                {
                    _Horario = "08-" + _Horario;
                }
                if (_itemProcedimiento.h07 == true)
                {
                    _Horario = "07-" + _Horario;
                }
                if (_itemProcedimiento.h06 == true)
                {
                    _Horario = "06-" + _Horario;
                }
                if (_itemProcedimiento.h05 == true)
                {
                    _Horario = "05-" + _Horario;
                }
                if (_itemProcedimiento.h04 == true)
                {
                    _Horario = "04-" + _Horario;
                }
                if (_itemProcedimiento.h03 == true)
                {
                    _Horario = "03-" + _Horario;
                }
                if (_itemProcedimiento.h02 == true)
                {
                    _Horario = "02-" + _Horario;
                }
                if (_itemProcedimiento.h01 == true)
                {
                    _Horario = "01-" + _Horario;
                }
                if (_itemProcedimiento.SegunNecesidad == true) //Otro horario
                {
                    _Horario = "Segun Necesidad";
                }
                if (_itemProcedimiento.UnicaVez == true)
                {
                    _Horario = "Unica Vez";
                }
                if (_itemProcedimiento.h01 == false && _itemProcedimiento.h02 == false && _itemProcedimiento.h03 == false && _itemProcedimiento.h04 == false && _itemProcedimiento.h05 == false
                    && _itemProcedimiento.h06 == false && _itemProcedimiento.h07 == false
                    && _itemProcedimiento.h08 == false && _itemProcedimiento.h09 == false && _itemProcedimiento.h10 == false && _itemProcedimiento.h11 == false && _itemProcedimiento.h12 == false
                    && _itemProcedimiento.h13 == false && _itemProcedimiento.h14 == false && _itemProcedimiento.h15 == false && _itemProcedimiento.h16 == false && _itemProcedimiento.h17 == false
                    && _itemProcedimiento.h18 == false && _itemProcedimiento.h19 == false && _itemProcedimiento.h20 == false && _itemProcedimiento.h21 == false
                    && _itemProcedimiento.h22 == false && _itemProcedimiento.h23 == false && _itemProcedimiento.h00 == false && _itemProcedimiento.SegunNecesidad == null && _itemProcedimiento.UnicaVez == null)
                {
                    _Horario = "Segun Necesidadd";
                }

                return _Horario;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DiasSuministroProc(PRO_SuministroDeProcedimiento_Historico _itemProcedimiento)
        {
            try
            {
                String _Dias;
                _Dias = "";

                if (_itemProcedimiento.Lunes == true)
                {
                    _Dias = "Lunes-" + _Dias;
                }
                if (_itemProcedimiento.Martes == true)
                {
                    _Dias = "Martes-" + _Dias;
                }
                if (_itemProcedimiento.Miercoles == true)
                {
                    _Dias = "Miercoles-" + _Dias;
                }
                if (_itemProcedimiento.Jueves == true)
                {
                    _Dias = "Jueves-" + _Dias;
                }
                if (_itemProcedimiento.Viernes == true)
                {
                    _Dias = "Viernes-" + _Dias;
                }
                if (_itemProcedimiento.Sabado == true)
                {
                    _Dias = "Sabado-" + _Dias;
                }
                if (_itemProcedimiento.Domingo == true)
                {
                    _Dias = "Domingo" + _Dias;
                }
                if (_itemProcedimiento.SegunNecesidad == true)
                {
                    _Dias = "Segun Necesidadd" + _Dias;
                }
                if (_itemProcedimiento.Lunes == true && _itemProcedimiento.Martes == true && _itemProcedimiento.Miercoles == true && _itemProcedimiento.Jueves == true && _itemProcedimiento.Viernes == true && _itemProcedimiento.Sabado == true && _itemProcedimiento.Domingo == true)
                {
                    _Dias = "Todos los dias";
                }

                return _Dias;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObservacionNutricion(int _nutricionID)
        {
            try
            {
                string obs = E.PRO_Posologia.Find(_nutricionID).observacion.ToString();
                return obs;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void traeIndicacioneProcedimientos(int _paciente)
        {
            dataGridViewProcedimientos.Rows.Clear();
            dataGridViewDescartables.Rows.Clear();
            int indice;
            foreach (var item in E.PRO_SuministroDeProcedimiento_Historico.Where(pro => pro.paciente_id == _paciente && (pro.fechaBaja >= dateDesde.Value && pro.fechaBaja <= dateHasta.Value || pro.fechaBaja == null)))
            {
                indice = dataGridViewProcedimientos.Rows.Add();
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.SUMINISTRO_ID].Value = item.suministroDeProcedimiento_id;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value = item.suministro_original;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = item.procedimiento_id;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_GENERICO].Value = item.generico_id;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.INICIO].Value = item.fechaAltaSistema.Value.ToString();
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value = item.procedimiento_id == null ? "SIN PROCEDIMIENTO" : item.PRO_Procedimiento.descripcion;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.FIN].Value = item.fechaBaja == null ? "" : item.fechaBaja.Value.ToString();
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.CHECK].Value = item.impFactu == null? true : item.impFactu;

                if (item.tipoProcedimiento_id == 3) //Procedimientos comunes
                {
                    if (HorarioSuministroProc(item) == "")
                    {
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = null;
                    }
                    else
                    {
                        string _Horario = HorarioSuministroProc(item).Substring(0, HorarioSuministroProc(item).Length - 1);
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = _Horario;
                    }

                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = DiasSuministroProc(item);
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.TIPO].Value = "COM";
                }
                else if (item.tipoProcedimiento_id == 2)//Nutricion
                {
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = "Segun necesidad";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = "Todos los dias";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = item.posologia_id;
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.OBS].Value = ObservacionNutricion(item.posologia_id == null ? 0 : Convert.ToInt32(item.posologia_id));
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.TIPO].Value = "NUT";
                }
                else if (item.tipoProcedimiento_id == 8)// PHP
                {
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = "Segun necesidad";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = "Todos los dias";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = item.php_id;
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.OBS].Value = "PHP";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.TIPO].Value = "PHP";
                }

            }
        }
        #endregion

        #region Eventos
        private void Factu_Procedimientos_Load(object sender, EventArgs e)
        {
            dateDesde.Value = Convert.ToDateTime("01/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
            dateHasta.Value = dateDesde.Value.AddMonths(1).AddDays(-1);
            traeIndicacioneProcedimientos(Clases.Paciente.PacienteIngresado);
        }
        #endregion

        private void dataGridViewProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dataGridViewProcedimientos.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProcedimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_GENERICO].Value != null)
                {
                    Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2 _Generico = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2();
                    _Generico.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                    _Generico.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Generico.Tipo_Procedimiento_Id = 3;
                    _Generico.Generico_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_GENERICO].Value);
                    _Generico.Paciente_Id = Clases.Paciente.PacienteIngresado;
                    _Generico.Factu = true;
                    _Generico.ShowDialog();
                }
                else if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.TIPO].Value.ToString() == "NUT")
                {
                    Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion _Nutricion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion();
                    _Nutricion.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                    _Nutricion.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Nutricion.Tipo_Procedimiento_Id = 2;
                    _Nutricion.Nutricion_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Nutricion.Paciente_Id = Clases.Paciente.PacienteIngresado;
                    _Nutricion.ShowDialog();
                }
                else if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.TIPO].Value.ToString() == "PHP")
                {
                    Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2 _Php = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2();
                    _Php.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                    _Php.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Php.Tipo_Procedimiento_Id = 8;
                    //_Php.Php_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PHP_ID].Value);
                    _Php.Paciente_Id = Clases.Paciente.PacienteIngresado;
                    _Php.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDescartables(int _suministroID)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();


                var q = from asoc in E.PRO_Asociacion_Procedimiento
                        join art in E.ARTICULO on asoc.articulo_id equals art.art_CodGen
                        where asoc.suministro_procedimiento_id == _suministroID
                        select new { asoc, art };

                int indice;
                foreach (var _itemDescartable in q)
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _itemDescartable.asoc.suministro_procedimiento_id;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemDescartable.asoc.articulo_id;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = _itemDescartable.art.art_DescGen + " " + _itemDescartable.art.artele_Desc1 + " " + _itemDescartable.art.artele_Desc2;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = _itemDescartable.asoc.cantidad;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = _itemDescartable.asoc.tipo_articulo;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDescartablesNutricion(int _suministroID, int _nutricionID)
        {
            var q = from n in E.PRO_Posologia
                    where n.posologia_id == _nutricionID
                    select n;

            int indice;
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";

                }
            }
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id2 != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id2;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id2.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";

                }
            }
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id3 != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id3;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id3.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";

                }
            }
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id4 != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id4;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id4.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";

                }
            }
        }

        private string TraeDescripcionArticulo(string _articuloID)
        {
            try
            {
                string articulo = E.ARTICULO.Find(_articuloID).art_DescGen + " " + E.ARTICULO.Find(_articuloID).artele_Desc1 + " " + E.ARTICULO.Find(_articuloID).artele_Desc2;
                return articulo;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProcedimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Procedimiento.CHECK)
                {
                    if (dataGridViewProcedimientos.CurrentRow != null)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.CHECK] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_GENERICO].Value != null)
                            {
                                TraeDescartables(Convert.ToInt32(dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value));
                            }
                            else
                            {
                                TraeDescartablesNutricion(Convert.ToInt32(dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value), Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value));
                            }

                        }

                        if (Convert.ToBoolean(cellSelecion.Value) == false)
                        {
                            for (int i = 0; i < dataGridViewDescartables.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value) == Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value))
                                {
                                    dataGridViewDescartables.Rows[i].Visible = false;
                                }
                            }

                            for (int i = 0; i < dataGridViewDescartables.Rows.Count; i++)
                            {
                                if (dataGridViewDescartables.Rows[i].Visible == false)
                                {
                                    dataGridViewDescartables.Rows.RemoveAt(i);
                                }
                            }
                        }
                    }
                }



                if (e.ColumnIndex == (int)Col_Procedimiento.CHECK)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.CHECK] as DataGridViewCheckBoxCell;

                    SISTMEDEntities E = new SISTMEDEntities();
                    E.Configuration.ValidateOnSaveEnabled = false;

                    int _suministroID = Convert.ToInt32(dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.SUMINISTRO_ID].Value);

                    PRO_SuministroDeProcedimiento_Historico _hist = new PRO_SuministroDeProcedimiento_Historico { suministroDeProcedimiento_id = _suministroID, impFactu = Convert.ToBoolean(cellSelecion.Value) };
                    E.PRO_SuministroDeProcedimiento_Historico.Attach(_hist);
                    E.Entry(_hist).Property(f => f.impFactu).IsModified = true;
                    E.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateDesde_ValueChanged(object sender, EventArgs e)
        {
            traeIndicacioneProcedimientos(Clases.Paciente.PacienteIngresado);
        }

        private void dateHasta_ValueChanged(object sender, EventArgs e)
        {
            traeIndicacioneProcedimientos(Clases.Paciente.PacienteIngresado);
        }

        private void dataGridViewProcedimientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == ' ')
                {
                    if (Convert.ToBoolean(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.CHECK].Value) == false)
                    {
                        dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.CHECK].Value = true;
                    }
                    else
                    {
                        dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.CHECK].Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
