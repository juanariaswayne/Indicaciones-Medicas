using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Principal.Clases
{
    public class IndicacionesBLL
    {
       
        public class Modulo
        {
             SISTMEDEntities _Mod = new  SISTMEDEntities();
            public bool ModuloNew(MED_Modulo _modulo)
            {
                try
                {
                    _Mod.MED_Modulo.Add(_modulo);

                    _Mod.SaveChanges();


                    return true;
                }

                catch (Exception ex)//
                {
                    return false;
                    
                }

            }

            public bool ModuloUpdate(MED_Modulo _modulo)
            {
                try
                {

                    _Mod.Entry(_modulo).State = System.Data.Entity.EntityState.Modified;

                    _Mod.SaveChanges();


                    return true;
                }

                catch (Exception ex)
                {
                    return false;

                }

            }


        }

        public class ListaEspera
        {
             SISTMEDEntities _Mod = new  SISTMEDEntities();
            public bool ListaNew(MED_ListaEspera _lista, List<MED_ListaEsperaModulo> _listModulos, List<MED_PuntajeAdicionalListaEspera> _listFactor, List<MED_CultivosListaEspera> _cultivos)
            {

                try
                {
                    _Mod.MED_ListaEspera.Add(_lista);

                    int _idListaGenerada = _lista.espera_id;

                    foreach (MED_ListaEsperaModulo item in _listModulos)
                    {
                        item.espera_id = _idListaGenerada;
                        _Mod.MED_ListaEsperaModulo.Add(item);

                    }
                    

                    if (_cultivos.Count > 0)
                    {
                        foreach (MED_CultivosListaEspera item in _cultivos)
                        {
                            item.espera_id = _idListaGenerada;
                            _Mod.MED_CultivosListaEspera.Add(item);

                        }

                    }

                    if (_listFactor.Count > 0)
                    {
                        foreach (MED_PuntajeAdicionalListaEspera item in _listFactor)
                        {
                            item.espera_id = _idListaGenerada;
                            _Mod.MED_PuntajeAdicionalListaEspera.Add(item);

                        }

                    }

                    _Mod.SaveChanges();

                    return true;
                }

                catch(Exception ex)
                {
                    return false;

                }
                
            }

            public bool ListaUpdate(MED_ListaEspera _lista, List<MED_ListaEsperaModulo> _listModulos, List<MED_PuntajeAdicionalListaEspera> _listFactor, List<MED_CultivosListaEspera> _cultivos)
            {

                try
                {
                    //PRIMERO BORRO LOS MODULOS Y CARGO TODOS DE NUEVO..
                    var _remove = (from P in _Mod.MED_ListaEsperaModulo where P.espera_id == _lista.espera_id  select P).ToList();
                    foreach (var item in _remove)
                    {
                        _Mod.MED_ListaEsperaModulo.Remove(item);

                    }

                    //LUEGO INSERTO TODOS DE NUEVO                   
                    foreach (MED_ListaEsperaModulo item in _listModulos)
                    {
                        item.espera_id = _lista.espera_id;
                        _Mod.MED_ListaEsperaModulo.Add(item);
                    }

                    //ACTUALIZO OTROS FACTORES DE PUNTAJE... PUEDE ESTAR AGREGANDO O BORRANDO.....
                    //PRIMERO BORRO LOS QUE TENGA ASIGNADO
                    var  _removeFactor = (from F in _Mod.MED_PuntajeAdicionalListaEspera where F.espera_id == _lista.espera_id select F).ToList();
                    foreach (var item in _removeFactor)
                    {
                        _Mod.MED_PuntajeAdicionalListaEspera.Remove(item);

                    }
                    //AHORA SI LA LISTA TIENE DATOS.. INSERTRO LOS NUEVOS
                    if (_listFactor.Count > 0)
                    {
                        foreach (MED_PuntajeAdicionalListaEspera item in _listFactor)
                        {
                            item.espera_id = _lista.espera_id;
                            _Mod.MED_PuntajeAdicionalListaEspera.Add(item);
                        }
                    }
                    //FIN FACTOR PUNTAJE ADICIONAL

                    //ACTUALIZO TABLAS DE CULTIVOS
                    var _removeCultivos = (from F in _Mod.MED_CultivosListaEspera where F.espera_id == _lista.espera_id select F).ToList();
                    foreach(var item in _removeCultivos)
                    {
                        _Mod.MED_CultivosListaEspera.Remove(item);
                    }
                    //AHORA INSERTO NUEVOS
                    if (_cultivos.Count > 0)
                    {
                        foreach (MED_CultivosListaEspera item in _cultivos)
                        {
                            item.espera_id = _lista.espera_id;
                            _Mod.MED_CultivosListaEspera.Add(item);

                        }

                    }
                    //FIN CULTIVOS

                    //ACTUALIZO TABLA LISTA DE ESPERA
                    _Mod.Entry(_lista).State = System.Data.Entity.EntityState.Modified;

                    _Mod.SaveChanges();

                    return true;
                }

                catch (Exception ex)
                {
                    return false;

                }

            }

            public bool ReingresaListaEspera (Int32 _listaEspera)
            {
                try
                {
                    MED_ListaEspera _espera = new MED_ListaEspera();
                    //ESTAS 2 LINEAS DE ABAJO ES IMPORTANTE PARA PODER MODIFICAR SOLO ALGUNOS CAMPOS
                    _Mod.Configuration.AutoDetectChangesEnabled = false;
                    _Mod.Configuration.ValidateOnSaveEnabled = false;

                    _espera.espera_id = _listaEspera;
                    _espera.fechaEgreso = null;
                    _espera.motivoEgreso_id = null;

                    //AHORA MARCO LOS CAMPOS QUE SE MODIFICAN
                    _Mod.MED_ListaEspera.Attach(_espera);
                    _Mod.Entry(_espera).Property(m => m.fechaEgreso).IsModified = true;
                    _Mod.Entry(_espera).Property(m => m.motivoEgreso_id).IsModified = true;

                    // **** ACTUALIZO LA TABLA
                    _Mod.SaveChanges();

                    return true;
                }

                catch(Exception ex)
                {

                    return false;
                }

             }

        }

        public class Paciente
        {
            SISTMEDEntities _Mod = new SISTMEDEntities();
            public bool IngresaPaciente(Pacientes _pac, List<MED_PacienteModulo> _listModPac ,Int32 _listaEsperaId, bool _reingreso, int _pacienteIdIM)
            {
                using (var dbContextTransaction = _Mod.Database.BeginTransaction())
                {
                    try
                    {
                        if (!_reingreso)
                        {

                            //ESTAS 2 LINEAS DE ABAJO ES IMPORTANTE PARA PODER MODIFICAR SOLO ALGUNOS CAMPOS
                            _Mod.Configuration.AutoDetectChangesEnabled = false;
                            _Mod.Configuration.ValidateOnSaveEnabled = false;

                            // ******   INSERTO EN TABLA PACIENTE ****************
                            _Mod.Pacientes.Add(_pac);

                            // ******  AHORA INSERTO LOS MODULOS SELECCIONADOS ************
                            foreach (MED_PacienteModulo item in _listModPac)
                            {
                                item.paciente_id = _pac.paciente_id; //ESTO PORQUE EL EF DEVUELVE EL ID CREAEDO EN EL MISMO OBJETO
                                _Mod.MED_PacienteModulo.Add(item);

                            }
                            // ***** AHORA ACTUALIZO LA TABLA MED_LISTAESPERA, PARA MARCAR QUE EGRESÓ *****
                            MED_ListaEspera _espera = new MED_ListaEspera();
                            _espera.fechaEgreso = Convert.ToDateTime(DateTime.Now); //fecha de egreso
                                                                                    //_espera.obs = obs;                                      // OJOOOO VER SI ESTO ESTA BIEN DE MODIFICAR LAS OBS 
                            _espera.espera_id = _listaEsperaId;                     // id lista espera
                            _espera.habitacion_id = _pac.habitacion_id;             // habitacion id.. puede venir en null

                            //AHORA MARCO LOS CAMPOS QUE SE MODIFICAN
                            _Mod.MED_ListaEspera.Attach(_espera);
                            _Mod.Entry(_espera).Property(m => m.fechaEgreso).IsModified = true;
                            _Mod.Entry(_espera).Property(m => m.habitacion_id).IsModified = true;

                            // **** ACTUALIZO LAS TABLAS
                            _Mod.SaveChanges();
                            dbContextTransaction.Commit();
                            return true;
                        }

                        // *************  ES UN REINGRESO ****************************************
                        if(_reingreso)
                        {
                            //ESTAS 2 LINEAS DE ABAJO ES IMPORTANTE PARA PODER MODIFICAR SOLO ALGUNOS CAMPOS
                            _Mod.Configuration.AutoDetectChangesEnabled = false;
                            _Mod.Configuration.ValidateOnSaveEnabled = false;

                            //ACTUALIZO LA TABLA DE PACIENTES
                            _pac.paciente_id = _pacienteIdIM;
                            //ANTES DE ACTUALIZAR GUARDO EL HISTORIAL DE ESTE PACIENTE
                            _Mod.AgregaHistorialPaciente(_pacienteIdIM);
                            //fin GUARDA HISTORIAL

                            _Mod.Pacientes.Attach(_pac);
                            _Mod.Entry(_pac).Property(m => m.habitacion_id).IsModified = true;
                            _Mod.Entry(_pac).Property(m => m.fechaIngreso).IsModified = true;
                            _Mod.Entry(_pac).Property(m => m.responsabe).IsModified = true;
                            _Mod.Entry(_pac).Property(m => m.vinculo).IsModified = true;
                            _Mod.Entry(_pac).Property(m => m.telefono).IsModified = true;
                            _Mod.Entry(_pac).Property(m => m.diagnostico_id).IsModified = true;
                            _Mod.Entry(_pac).Property(m => m.sede_id).IsModified = true;
                            _Mod.Entry(_pac).Property(m => m.usuario_id).IsModified = true;

                            //BORRO TODOS LOS MODULOS ASIGNADOS ANTERIORMENTE
                            //PRIMERO BORRO LOS QUE TENGA ASIGNADO
                            var _removeModulo = (from F in _Mod.MED_PacienteModulo where F.paciente_id == _pacienteIdIM select F).ToList();
                            foreach (var item in _removeModulo)
                            {
                                _Mod.MED_PacienteModulo.Remove(item);

                            }

                            //FIN BORRA MODULOS

                            // ******  AHORA INSERTO LOS MODULOS SELECCIONADOS ************
                            foreach (MED_PacienteModulo item in _listModPac)
                            {
                                item.paciente_id = _pac.paciente_id; //ESTO PORQUE EL EF DEVUELVE EL ID CREAEDO EN EL MISMO OBJETO
                                _Mod.MED_PacienteModulo.Add(item);

                            }

                            // ***** AHORA ACTUALIZO LA TABLA MED_LISTAESPERA, PARA MARCAR QUE EGRESÓ *****
                            MED_ListaEspera _espera = new MED_ListaEspera();
                            _espera.fechaEgreso = Convert.ToDateTime(DateTime.Now); //fecha de egreso
                            //_espera.obs = obs;       // OJOOOO VER SI ESTO ESTA BIEN DE MODIFICAR LAS OBS 
                            _espera.espera_id = _listaEsperaId;                     // id lista espera
                            _espera.habitacion_id = _pac.habitacion_id;             // habitacion id.. puede venir en null

                            //AHORA MARCO LOS CAMPOS QUE SE MODIFICAN
                            _Mod.MED_ListaEspera.Attach(_espera);
                            _Mod.Entry(_espera).Property(m => m.fechaEgreso).IsModified = true;
                            _Mod.Entry(_espera).Property(m => m.habitacion_id).IsModified = true;

                            // **** ACTUALIZO LAS TABLAS
                            _Mod.SaveChanges();
                            dbContextTransaction.Commit();

                            return true;
                        }

                        return true;
                    }

                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                        return false;

                    }

                }
            }



        }

        public class Derivacion
        {
            SISTMEDEntities _Mod = new SISTMEDEntities();
            public bool DerivacionNew(MED_Derivacion _deriva)
            {
                try
                {
                    _Mod.MED_Derivacion.Add(_deriva);

                    _Mod.SaveChanges();


                    return true;
                }

                catch (Exception ex)
                {
                    return false;

                }

            }

            public bool DerivacionUpdate(MED_Derivacion _deriva)
            {
                try
                {

                    _Mod.Entry(_deriva).State = System.Data.Entity.EntityState.Modified;

                    _Mod.SaveChanges();


                    return true;
                }

                catch (Exception ex)
                {
                    return false;

                }

            }

        }

        public class Mail
        {
            SISTMEDEntities _Mod = new SISTMEDEntities();



            public bool IngresaMail(List<MED_Mails> _listaMail, int _sede ,int _sector)
            {
                try
                {
                    //primero borro todos los mails. luego los ingreso de nuevo...
                    var _removeMail = (from F in _Mod.MED_Mails where F.sede_id == _sede && F.sector_id == _sector select F).ToList();
                    foreach (var item in _removeMail)
                    {
                        _Mod.MED_Mails.Remove(item);

                    }
                    //FIN BORRA MAILS

                    //AHORA INSERTO LOS NUEVOS
                    if (_listaMail.Count > 0)
                    {
                        foreach (MED_Mails item in _listaMail)
                        {
                            _Mod.MED_Mails.Add(item);

                        }

                    }
                    //FIN CULTIVOS

                    
                    _Mod.SaveChanges();


                    return true;
                }

               

                  catch (Exception ex)
                {

                    return false;
                }
            }

        }

    }
}
