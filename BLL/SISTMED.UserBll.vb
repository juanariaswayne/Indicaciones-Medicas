 ':.: Generated  with Solar Generation Studio :.: 
 ' Plugin Version: 1.0.0.0

 ' - Classes derivadas de Tablas - 

Namespace Tables

    Partial Public Class ANALISISDELABORATORIO

    End Class 'ANALISISDELABORATORIO
    Partial Public Class CONTACTOPACIENTE

    End Class 'CONTACTOPACIENTE
    Partial Public Class DIAGNOSTICOS

    End Class 'DIAGNOSTICOS
    Partial Public Class DISTRIBUCIONMEDICAMENTO

    End Class 'DISTRIBUCIONMEDICAMENTO
    Partial Public Class HABITACIONES

    End Class 'HABITACIONES
    Partial Public Class HORARIOS

    End Class 'HORARIOS
    Partial Public Class LABORATORIOPACIENTE

    End Class 'LABORATORIOPACIENTE
    Partial Public Class MEDICACIONPACIENTE

    End Class 'MEDICACIONPACIENTE
    Partial Public Class MODALIDADRESPIRATORIA

    End Class 'MODALIDADRESPIRATORIA
    Partial Public Class NUTRICIONPACIENTE

    End Class 'NUTRICIONPACIENTE
    Partial Public Class PACIENTES

        Inherits DAL.Tables.PACIENTES
        Public Overloads Function AltaPaciente(ByVal ItemPaciente As Entities.Tables.PACIENTES, ByVal ItemPertenencias As Entities.Tables.PERTENENCIASPACIENTE) As Boolean

            Dim NewPaciente As New DAL.Tables.PACIENTES

            Try
                'ESTABLEZCO LA TRANSACCION
                NewPaciente.BeginTransaction()

                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewPaciente.Update(ItemPaciente) ' GUARDO LA FECHA DE BAJA EN LA TABLA PACIENTES 


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPertenenciasPaciente As New DAL.Tables.PERTENENCIASPACIENTE(NewPaciente)

                NewPertenenciasPaciente.Add(ItemPertenencias)


                'HAGO EL COMMIT
                NewPaciente.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewPaciente.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function IngresoPaciente(ByVal ItemPaciente As Entities.Tables.PACIENTES, ByVal ItemNumeroHistoriaClinica As Entities.Tables.EMPRESA) As Boolean

            Dim NewPaciente As New DAL.Tables.PACIENTES

            Try
                'ESTABLEZCO LA TRANSACCION
                NewPaciente.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewPaciente.Add(ItemPaciente) ' GUARDO LA FECHA DE BAJA EN LA TABLA PACIENTES 
                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewNumeroHistoriaClinica As New DAL.Tables.EMPRESA(NewPaciente)
                NewNumeroHistoriaClinica.Update(ItemNumeroHistoriaClinica)

                'HAGO EL COMMIT
                NewPaciente.EndTransaction(True)
                Return True
            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewPaciente.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaIngresoPaciente(ByVal ItemPacienteHistorial As Entities.Tables.PACIENTES_HISTORIAL, ByVal ItemPaciente As Entities.Tables.PACIENTES) As Boolean

            Dim NewPacienteHistorial As New DAL.Tables.PACIENTES_HISTORIAL

            Try
                'ESTABLEZCO LA TRANSACCION
                NewPacienteHistorial.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewPacienteHistorial.Add(ItemPacienteHistorial) ' GUARDO LA FECHA DE BAJA EN LA TABLA PACIENTES 
                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPaciente As New DAL.Tables.PACIENTES(NewPacienteHistorial)
                NewPaciente.Update(ItemPaciente)

                'HAGO EL COMMIT
                NewPacienteHistorial.EndTransaction(True)
                Return True
            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewPacienteHistorial.EndTransaction(False)
                Return False
            End Try

        End Function

    End Class 'PACIENTES
    Partial Public Class MED_SUMINISTRODEMEDICACION

        Inherits DAL.Tables.MED_SUMINISTRODEMEDICACION
        Public Overloads Function AltaSuministroDeMedicacion(ByVal ItemSuministroDeMedicamento As Entities.Tables.MED_SUMINISTRODEMEDICACION, ByVal ItemSuministroHistorial As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION) As Boolean

            Dim NewSuministroDeMedicamento As New DAL.Tables.MED_SUMINISTRODEMEDICACION

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeMedicamento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeMedicamento.Add(ItemSuministroDeMedicamento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewHorarioFijo As New DAL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION(NewSuministroDeMedicamento)
                NewHorarioFijo.Add(ItemSuministroHistorial)

                'HAGO EL COMMIT
                NewSuministroDeMedicamento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeMedicamento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaSuministroDeMedicacion(ByVal ItemSuministroDeMedicamento As Entities.Tables.MED_SUMINISTRODEMEDICACION, ByVal ItemSuministroHistorial As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION) As Boolean

            Dim NewSuministroDeMedicamento As New DAL.Tables.MED_SUMINISTRODEMEDICACION

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeMedicamento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeMedicamento.Update(ItemSuministroDeMedicamento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewHorarioFijo As New DAL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION(NewSuministroDeMedicamento)
                NewHorarioFijo.Add(ItemSuministroHistorial)

                'HAGO EL COMMIT
                NewSuministroDeMedicamento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeMedicamento.EndTransaction(False)
                Return False
            End Try

        End Function

    End Class

    Partial Public Class MED_MEDICAMENTO_VIA

        Inherits DAL.Tables.MED_MEDICAMENTO_VIA
        Public Overloads Function AltaMedicamentoNuevo(ByVal ItemMedicamentoVia As Entities.Tables.MED_MEDICAMENTO_VIA, ByVal ItemMedicamentoNuevo As Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO) As Boolean

            Dim NewMedicamentoVia As New DAL.Tables.MED_MEDICAMENTO_VIA

            Try
                'ESTABLEZCO LA TRANSACCION
                NewMedicamentoVia.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewMedicamentoVia.Add(ItemMedicamentoVia)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewMedicamentoNuevo As New DAL.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO(NewMedicamentoVia)
                NewMedicamentoNuevo.Update(ItemMedicamentoNuevo)

                'HAGO EL COMMIT
                NewMedicamentoVia.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewMedicamentoVia.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaSuministroDeMedicacion(ByVal ItemSuministroDeMedicamento As Entities.Tables.MED_SUMINISTRODEMEDICACION, ByVal ItemSuministroHistorial As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION) As Boolean

            Dim NewSuministroDeMedicamento As New DAL.Tables.MED_SUMINISTRODEMEDICACION

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeMedicamento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeMedicamento.Update(ItemSuministroDeMedicamento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewHorarioFijo As New DAL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION(NewSuministroDeMedicamento)
                NewHorarioFijo.Add(ItemSuministroHistorial)

                'HAGO EL COMMIT
                NewSuministroDeMedicamento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeMedicamento.EndTransaction(False)
                Return False
            End Try

        End Function

    End Class
    Partial Public Class PROCEDIMIENTODESCARTABLE

    End Class 'PROCEDIMIENTODESCARTABLE
    Partial Public Class PROCEDIMIENTOPACIENTE

    End Class 'PROCEDIMIENTOPACIENTE
    Partial Public Class PROCEDIMIENTOS

    End Class 'PROCEDIMIENTOS
    Partial Public Class SEDES

    End Class 'SEDES

    Partial Public Class PRO_SUMINISTRODEPROCEDIMIENTO

        Inherits DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

        'ENFERMERIA
        Public Overloads Function AltaEnfermeria(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemEnfermeria As Entities.Tables.PRO_ENFERMERIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewEnfermeria As New DAL.Tables.PRO_ENFERMERIA(NewSuministroDeProcedimiento)
                NewEnfermeria.Add(ItemEnfermeria)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaEnfermeria(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemEnfermeria As Entities.Tables.PRO_ENFERMERIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewEnfermeria As New DAL.Tables.PRO_ENFERMERIA(NewSuministroDeProcedimiento)
                NewEnfermeria.Update(ItemEnfermeria)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialEnfermeria(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemEnfermeria As Entities.Tables.PRO_HISTORIAL_ENFERMERIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewEnfermeria As New DAL.Tables.PRO_HISTORIAL_ENFERMERIA(NewSuministroDeProcedimiento)
                NewEnfermeria.Add(ItemEnfermeria)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'POSOLOGIA
        Public Overloads Function AltaPosologia(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPosologia As Entities.Tables.PRO_POSOLOGIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPosologia As New DAL.Tables.PRO_POSOLOGIA(NewSuministroDeProcedimiento)
                NewPosologia.Add(ItemPosologia)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaPosologia(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPosologia As Entities.Tables.PRO_POSOLOGIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPosologia As New DAL.Tables.PRO_POSOLOGIA(NewSuministroDeProcedimiento)
                NewPosologia.Update(ItemPosologia)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialPosologia(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPosologia As Entities.Tables.PRO_HISTORIAL_POSOLOGIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPosologia As New DAL.Tables.PRO_HISTORIAL_POSOLOGIA(NewSuministroDeProcedimiento)
                NewPosologia.Add(ItemPosologia)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'GENERICO
        Public Overloads Function AltaGenerico(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemGenerico As Entities.Tables.PRO_GENERICO) As Boolean

            Dim NewGenerico As New DAL.Tables.PRO_GENERICO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewGenerico.BeginTransaction()



                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION

                NewGenerico.Add(ItemGenerico)

                Dim newSuministro = New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO(NewGenerico)

                ItemSuministroDeProcedimiento.GENERICO_ID = ItemGenerico.GENERICO_ID
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                newSuministro.Add(ItemSuministroDeProcedimiento)


                'HAGO EL COMMIT
                NewGenerico.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewGenerico.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaGenerico(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemGenerico As Entities.Tables.PRO_GENERICO) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewGenerico As New DAL.Tables.PRO_GENERICO(NewSuministroDeProcedimiento)
                NewGenerico.Update(ItemGenerico)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialGenerico(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemGenerico As Entities.Tables.PRO_HISTORIAL_GENERICO) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewGenerico As New DAL.Tables.PRO_HISTORIAL_GENERICO(NewSuministroDeProcedimiento)
                NewGenerico.Add(ItemGenerico)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'COLOCACIÓN VÍA PERIFERICA
        Public Overloads Function AltaColocacionViaPeriferica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemColocacionViaPeriferica As Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewColocacionViaPeriferica As New DAL.Tables.PRO_COLOCACION_VIA_PERIFERICA(NewSuministroDeProcedimiento)
                NewColocacionViaPeriferica.Add(ItemColocacionViaPeriferica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaColocacionViaPeriferica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemColocacionViaPeriferica As Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewColocacionViaPeriferica As New DAL.Tables.PRO_COLOCACION_VIA_PERIFERICA(NewSuministroDeProcedimiento)
                NewColocacionViaPeriferica.Update(ItemColocacionViaPeriferica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialColocacionViaPeriferica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemColocacionViaPeriferica As Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewColocacionViaPeriferica As New DAL.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA(NewSuministroDeProcedimiento)
                NewColocacionViaPeriferica.Add(ItemColocacionViaPeriferica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'CUIDADO ORAL
        Public Overloads Function AltaCuidadoOral(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoOral As Entities.Tables.PRO_CUIDADO_ORAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoOral As New DAL.Tables.PRO_CUIDADO_ORAL(NewSuministroDeProcedimiento)
                NewCuidadoOral.Add(ItemCuidadoOral)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaCuidadoOral(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoOral As Entities.Tables.PRO_CUIDADO_ORAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoOral As New DAL.Tables.PRO_CUIDADO_ORAL(NewSuministroDeProcedimiento)
                NewCuidadoOral.Update(ItemCuidadoOral)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialCuidadoOral(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoOral As Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoOral As New DAL.Tables.PRO_HISTORIAL_CUIDADO_ORAL(NewSuministroDeProcedimiento)
                NewCuidadoOral.Add(ItemCuidadoOral)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'CUIDADO POSTURAL
        Public Overloads Function AltaCuidadoPostural(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoPostural As Entities.Tables.PRO_CUIDADO_POSTURAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoPostural As New DAL.Tables.PRO_CUIDADO_POSTURAL(NewSuministroDeProcedimiento)
                NewCuidadoPostural.Add(ItemCuidadoPostural)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaCuidadoPostural(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoPostural As Entities.Tables.PRO_CUIDADO_POSTURAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoPostural As New DAL.Tables.PRO_CUIDADO_POSTURAL(NewSuministroDeProcedimiento)
                NewCuidadoPostural.Update(ItemCuidadoPostural)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialCuidadoPostural(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoPostural As Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoPostural As New DAL.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL(NewSuministroDeProcedimiento)
                NewCuidadoPostural.Add(ItemCuidadoPostural)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'PROTECCIÓN FISICA
        Public Overloads Function AltaProteccionFisica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemProteccionFisica As Entities.Tables.PRO_PROTECCION_FISICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewProteccionFisica As New DAL.Tables.PRO_PROTECCION_FISICA(NewSuministroDeProcedimiento)
                NewProteccionFisica.Add(ItemProteccionFisica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaProteccionFisica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemProteccionFisica As Entities.Tables.PRO_PROTECCION_FISICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewProteccionFisica As New DAL.Tables.PRO_PROTECCION_FISICA(NewSuministroDeProcedimiento)
                NewProteccionFisica.Update(ItemProteccionFisica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialProteccionFisica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemProteccionFisica As Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewProteccionFisica As New DAL.Tables.PRO_HISTORIAL_PROTECCION_FISICA(NewSuministroDeProcedimiento)
                NewProteccionFisica.Add(ItemProteccionFisica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'PHP
        Public Overloads Function AltaPhp(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPhp As Entities.Tables.PRO_PHP) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPhp As New DAL.Tables.PRO_PHP(NewSuministroDeProcedimiento)
                NewPhp.Add(ItemPhp)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function ModificaPhp(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPhp As Entities.Tables.PRO_PHP) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Update(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPhp As New DAL.Tables.PRO_PHP(NewSuministroDeProcedimiento)
                NewPhp.Update(ItemPhp)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
        Public Overloads Function AltaHistorialPhp(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPhp As Entities.Tables.PRO_HISTORIAL_PHP) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPhp As New DAL.Tables.PRO_HISTORIAL_PHP(NewSuministroDeProcedimiento)
                NewPhp.Add(ItemPhp)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

    End Class 'PRO_SUMINISTRODEPROCEDIMIENTO
    Partial Public Class PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

        Inherits DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

        'ENFERMERIA
        Public Overloads Function AltaHistorialEnfermeria(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemEnfermeria As Entities.Tables.PRO_HISTORIAL_ENFERMERIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewEnfermeria As New DAL.Tables.PRO_HISTORIAL_ENFERMERIA(NewSuministroDeProcedimiento)
                NewEnfermeria.Add(ItemEnfermeria)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'POSOLOGIA
        Public Overloads Function AltaHistorialPosologia(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPosologia As Entities.Tables.PRO_HISTORIAL_POSOLOGIA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPosologia As New DAL.Tables.PRO_HISTORIAL_POSOLOGIA(NewSuministroDeProcedimiento)
                NewPosologia.Add(ItemPosologia)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'GENERICO
        Public Overloads Function AltaHistorialGenerico(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemGenerico As Entities.Tables.PRO_HISTORIAL_GENERICO) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewGenerico As New DAL.Tables.PRO_HISTORIAL_GENERICO(NewSuministroDeProcedimiento)
                NewGenerico.Add(ItemGenerico)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'COLOCACIÓN VÍA PERIFERICA
        Public Overloads Function AltaHistorialColocacionViaPeriferica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemColocacionVioPeriferica As Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewColocacionVioPeriferica As New DAL.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA(NewSuministroDeProcedimiento)
                NewColocacionVioPeriferica.Add(ItemColocacionVioPeriferica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'CUIDADO ORAL
        Public Overloads Function AltaHistorialCuidadoOral(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoOral As Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoOral As New DAL.Tables.PRO_HISTORIAL_CUIDADO_ORAL(NewSuministroDeProcedimiento)
                NewCuidadoOral.Add(ItemCuidadoOral)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'CUIDADO POSTURAL
        Public Overloads Function AltaHistorialCuidadoPostural(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemCuidadoPostural As Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewCuidadoPostural As New DAL.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL(NewSuministroDeProcedimiento)
                NewCuidadoPostural.Add(ItemCuidadoPostural)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'PROTECCIÓN FISICA
        Public Overloads Function AltaHistorialProteccionFisica(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemProteccionFisica As Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewProteccionFisica As New DAL.Tables.PRO_HISTORIAL_PROTECCION_FISICA(NewSuministroDeProcedimiento)
                NewProteccionFisica.Add(ItemProteccionFisica)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function

        'PHP
        Public Overloads Function AltaHistorialPhp(ByVal ItemSuministroDeProcedimiento As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO, ByVal ItemPhp As Entities.Tables.PRO_HISTORIAL_PHP) As Boolean

            Dim NewSuministroDeProcedimiento As New DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

            Try
                'ESTABLEZCO LA TRANSACCION
                NewSuministroDeProcedimiento.BeginTransaction()
                'GUARDO LA CABECERA, COMPLETO EL OBJETO
                NewSuministroDeProcedimiento.Add(ItemSuministroDeProcedimiento)


                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewPhp As New DAL.Tables.PRO_HISTORIAL_PHP(NewSuministroDeProcedimiento)
                NewPhp.Add(ItemPhp)

                'HAGO EL COMMIT
                NewSuministroDeProcedimiento.EndTransaction(True)
                Return True

            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewSuministroDeProcedimiento.EndTransaction(False)
                Return False
            End Try

        End Function
    End Class 'PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO

End Namespace 'Tables

Namespace Procedures


End Namespace 'Procedures

Namespace Views

End Namespace 'Views
