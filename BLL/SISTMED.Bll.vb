':.: Generated  with Solar Generation Studio :.: 
' Plugin Version: 1.0.0.0

' - Classes derivadas de Tablas - 

Imports Entities.Procedures

Namespace Tables

    Partial Public Class MED_SOLICITA_MEDICAMENTO_NUEVO
        Inherits DAL.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal medicamento_id As System.Int32) As List(Of Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.medicamento_id, DAL.SqlEnums.OperandEnum.Equal, medicamento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO) As Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal medicamento_id As System.Int32, ByVal bejerman_id As System.String, ByVal medicamento As System.String, ByVal presentacion_id As System.Int32, ByVal unidaddemedida_id As System.Int32, ByVal autoriza As System.Boolean, ByVal suministracompra As System.Boolean, ByVal usuariosolicita_id As System.Int32, ByVal fechasolicita As System.DateTime, ByVal usuarioautoriza_id As System.Int32, ByVal fechaautoriza As System.DateTime, ByVal pendiente As System.Boolean, ByVal bejermanalta As System.Boolean, ByVal inactivo As System.Boolean) As Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO
            Try
                Dim NewItem As New Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO
                With NewItem
                    .MEDICAMENTO_ID = medicamento_id
                    .BEJERMAN_ID = bejerman_id
                    .MEDICAMENTO = medicamento
                    .PRESENTACION_ID = presentacion_id
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .AUTORIZA = autoriza
                    .SUMINISTRACOMPRA = suministracompra
                    .USUARIOSOLICITA_ID = usuariosolicita_id
                    .FECHASOLICITA = fechasolicita
                    .USUARIOAUTORIZA_ID = usuarioautoriza_id
                    .FECHAAUTORIZA = fechaautoriza
                    .PENDIENTE = pendiente
                    .BEJERMANALTA = bejermanalta
                    .INACTIVO = inactivo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal medicamento_id As System.Int32, ByVal bejerman_id As System.String, ByVal medicamento As System.String, ByVal presentacion_id As System.Int32, ByVal unidaddemedida_id As System.Int32, ByVal autoriza As System.Boolean, ByVal suministracompra As System.Boolean, ByVal usuariosolicita_id As System.Int32, ByVal fechasolicita As System.DateTime, ByVal usuarioautoriza_id As System.Int32, ByVal fechaautoriza As System.DateTime, ByVal pendiente As System.Boolean, ByVal bejermanalta As System.Boolean, ByVal inactivo As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO
                With NewItem
                    .MEDICAMENTO_ID = medicamento_id
                    .BEJERMAN_ID = bejerman_id
                    .MEDICAMENTO = medicamento
                    .PRESENTACION_ID = presentacion_id
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .AUTORIZA = autoriza
                    .SUMINISTRACOMPRA = suministracompra
                    .USUARIOSOLICITA_ID = usuariosolicita_id
                    .FECHASOLICITA = fechasolicita
                    .USUARIOAUTORIZA_ID = usuarioautoriza_id
                    .FECHAAUTORIZA = fechaautoriza
                    .PENDIENTE = pendiente
                    .BEJERMANALTA = bejermanalta
                    .INACTIVO = inactivo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal medicamento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO
                With NewItem
                    .MEDICAMENTO_ID = medicamento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TBL_MENUS
        Inherits DAL.Tables.TBL_MENUS
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_MENUS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_menu As System.Int32) As List(Of Entities.Tables.TBL_MENUS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Menu, DAL.SqlEnums.OperandEnum.Equal, id_menu)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_MENUS) As Entities.Tables.TBL_MENUS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_menu As System.Int32, ByVal id_menupadre As System.Int32, ByVal descripcionmenu As System.String, ByVal posicionmenu As System.Int32, ByVal habilitadomenu As System.Boolean, ByVal urlmenu As System.String, ByVal formularioasociado As System.Boolean) As Entities.Tables.TBL_MENUS
            Try
                Dim NewItem As New Entities.Tables.TBL_MENUS
                With NewItem
                    .ID_MENU = id_menu
                    .ID_MENUPADRE = id_menupadre
                    .DESCRIPCIONMENU = descripcionmenu
                    .POSICIONMENU = posicionmenu
                    .HABILITADOMENU = habilitadomenu
                    .URLMENU = urlmenu
                    .FORMULARIOASOCIADO = formularioasociado

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_MENUS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_menu As System.Int32, ByVal id_menupadre As System.Int32, ByVal descripcionmenu As System.String, ByVal posicionmenu As System.Int32, ByVal habilitadomenu As System.Boolean, ByVal urlmenu As System.String, ByVal formularioasociado As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_MENUS
                With NewItem
                    .ID_MENU = id_menu
                    .ID_MENUPADRE = id_menupadre
                    .DESCRIPCIONMENU = descripcionmenu
                    .POSICIONMENU = posicionmenu
                    .HABILITADOMENU = habilitadomenu
                    .URLMENU = urlmenu
                    .FORMULARIOASOCIADO = formularioasociado

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_MENUS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_menu As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_MENUS
                With NewItem
                    .ID_MENU = id_menu

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_MENUS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TBL_PERFILES
        Inherits DAL.Tables.TBL_PERFILES
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_PERFILES)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_perfil As System.Int32) As List(Of Entities.Tables.TBL_PERFILES)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Perfil, DAL.SqlEnums.OperandEnum.Equal, id_perfil)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_PERFILES) As Entities.Tables.TBL_PERFILES
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_perfil As System.Int32, ByVal nombreperfil As System.String, ByVal descripcionperfil As System.String) As Entities.Tables.TBL_PERFILES
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILES
                With NewItem
                    .ID_PERFIL = id_perfil
                    .NOMBREPERFIL = nombreperfil
                    .DESCRIPCIONPERFIL = descripcionperfil

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_PERFILES) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_perfil As System.Int32, ByVal nombreperfil As System.String, ByVal descripcionperfil As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILES
                With NewItem
                    .ID_PERFIL = id_perfil
                    .NOMBREPERFIL = nombreperfil
                    .DESCRIPCIONPERFIL = descripcionperfil

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_PERFILES) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_perfil As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILES
                With NewItem
                    .ID_PERFIL = id_perfil

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_PERFILES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TBL_PERFILESPERMISOS
        Inherits DAL.Tables.TBL_PERFILESPERMISOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_PERFILESPERMISOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_perfilpermisos As System.Int32) As List(Of Entities.Tables.TBL_PERFILESPERMISOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_PerfilPermisos, DAL.SqlEnums.OperandEnum.Equal, id_perfilpermisos)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_PERFILESPERMISOS) As Entities.Tables.TBL_PERFILESPERMISOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_perfilpermisos As System.Int32, ByVal id_perfil As System.Int32, ByVal id_menu As System.Int32, ByVal lectura As System.Boolean, ByVal escritura As System.Boolean, ByVal eliminacion As System.Boolean) As Entities.Tables.TBL_PERFILESPERMISOS
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILESPERMISOS
                With NewItem
                    .ID_PERFILPERMISOS = id_perfilpermisos
                    .ID_PERFIL = id_perfil
                    .ID_MENU = id_menu
                    .LECTURA = lectura
                    .ESCRITURA = escritura
                    .ELIMINACION = eliminacion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_PERFILESPERMISOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_perfilpermisos As System.Int32, ByVal id_perfil As System.Int32, ByVal id_menu As System.Int32, ByVal lectura As System.Boolean, ByVal escritura As System.Boolean, ByVal eliminacion As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILESPERMISOS
                With NewItem
                    .ID_PERFILPERMISOS = id_perfilpermisos
                    .ID_PERFIL = id_perfil
                    .ID_MENU = id_menu
                    .LECTURA = lectura
                    .ESCRITURA = escritura
                    .ELIMINACION = eliminacion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_PERFILESPERMISOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_perfilpermisos As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_PERFILESPERMISOS
                With NewItem
                    .ID_PERFILPERMISOS = id_perfilpermisos

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_PERFILESPERMISOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TBL_USUARIOS
        Inherits DAL.Tables.TBL_USUARIOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.TBL_USUARIOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_usuario As System.Int32) As List(Of Entities.Tables.TBL_USUARIOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.Id_Usuario, DAL.SqlEnums.OperandEnum.Equal, id_usuario)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Entities.Tables.TBL_USUARIOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal contraseniausuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As System.Int32) As Entities.Tables.TBL_USUARIOS
            Try
                Dim NewItem As New Entities.Tables.TBL_USUARIOS
                With NewItem
                    .ID_USUARIO = id_usuario
                    .ID_PERFIL = id_perfil
                    .IDENTIFICADORUSUARIO = identificadorusuario
                    .CONTRASENIAUSUARIO = contraseniausuario
                    .NOMBREUSUARIO = nombreusuario
                    .INACTIVO = inactivo
                    .SECTOR_ID = sector_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal contraseniausuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_USUARIOS
                With NewItem
                    .ID_USUARIO = id_usuario
                    .ID_PERFIL = id_perfil
                    .IDENTIFICADORUSUARIO = identificadorusuario
                    .CONTRASENIAUSUARIO = contraseniausuario
                    .NOMBREUSUARIO = nombreusuario
                    .INACTIVO = inactivo
                    .SECTOR_ID = sector_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TBL_USUARIOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_usuario As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TBL_USUARIOS
                With NewItem
                    .ID_USUARIO = id_usuario

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TBL_USUARIOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class HABITACIONES
        Inherits DAL.Tables.HABITACIONES
        Public Overloads Function ItemList() As List(Of Entities.Tables.HABITACIONES)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal habitacion_id As System.Int32) As List(Of Entities.Tables.HABITACIONES)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.habitacion_id, DAL.SqlEnums.OperandEnum.Equal, habitacion_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.HABITACIONES) As Entities.Tables.HABITACIONES
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal habitacion_id As System.Int32, ByVal descripcion As System.String, ByVal piso_id As System.Int32, ByVal sede_id As System.Int32, ByVal baja As System.Int32) As Entities.Tables.HABITACIONES
            Try
                Dim NewItem As New Entities.Tables.HABITACIONES
                With NewItem
                    .HABITACION_ID = habitacion_id
                    .DESCRIPCION = descripcion
                    .PISO_ID = piso_id
                    .SEDE_ID = sede_id
                    .BAJA = baja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.HABITACIONES) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal habitacion_id As System.Int32, ByVal descripcion As System.String, ByVal piso_id As System.Int32, ByVal sede_id As System.Int32, ByVal baja As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.HABITACIONES
                With NewItem
                    .HABITACION_ID = habitacion_id
                    .DESCRIPCION = descripcion
                    .PISO_ID = piso_id
                    .SEDE_ID = sede_id
                    .BAJA = baja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.HABITACIONES) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal habitacion_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.HABITACIONES
                With NewItem
                    .HABITACION_ID = habitacion_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.HABITACIONES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class EMPRESA
        Inherits DAL.Tables.EMPRESA
        Public Overloads Function ItemList() As List(Of Entities.Tables.EMPRESA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal empresa_id As System.Int32) As List(Of Entities.Tables.EMPRESA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.empresa_id, DAL.SqlEnums.OperandEnum.Equal, empresa_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EMPRESA) As Entities.Tables.EMPRESA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal empresa_id As System.Int32, ByVal descripcion As System.String, ByVal ultimahistoriaclinica As System.Int32) As Entities.Tables.EMPRESA
            Try
                Dim NewItem As New Entities.Tables.EMPRESA
                With NewItem
                    .EMPRESA_ID = empresa_id
                    .DESCRIPCION = descripcion
                    .ULTIMAHISTORIACLINICA = ultimahistoriaclinica

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EMPRESA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal empresa_id As System.Int32, ByVal descripcion As System.String, ByVal ultimahistoriaclinica As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EMPRESA
                With NewItem
                    .EMPRESA_ID = empresa_id
                    .DESCRIPCION = descripcion
                    .ULTIMAHISTORIACLINICA = ultimahistoriaclinica

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EMPRESA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal empresa_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EMPRESA
                With NewItem
                    .EMPRESA_ID = empresa_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EMPRESA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PACIENTES
        Inherits DAL.Tables.PACIENTES
        Public Overloads Function ItemList() As List(Of Entities.Tables.PACIENTES)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Tables.PACIENTES)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.paciente_id, DAL.SqlEnums.OperandEnum.Equal, paciente_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PACIENTES) As Entities.Tables.PACIENTES
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal paciente_id As System.Int32, ByVal numerohistoriaclinica As System.Int32, ByVal numerointernacion As System.Int32, ByVal habitacion_id As System.Int32, ByVal sede_id As System.Int32, ByVal nombre As System.String, ByVal apellido As System.String, ByVal genero As System.Boolean, ByVal fechanacimiento As System.DateTime, ByVal tipodocumento_id As System.Int32, ByVal numerodocumento As System.Int32, ByVal diagnostico_id As System.Int32, ByVal fechaingreso As System.DateTime, ByVal obrasocial_id As System.String, ByVal numeroobrasocial As System.Int32, ByVal fechaegreso As System.DateTime, ByVal motivoegreso_id As System.Int32, ByVal acompaniante As System.Boolean, ByVal itempendiente As System.Boolean, ByVal prealta As System.Boolean, ByVal solicitudestudio As System.Boolean, ByVal solicitudtraslado As System.Boolean, ByVal interconsultapendiente As System.Boolean, ByVal altaautorizada As System.Boolean, ByVal hs_08 As System.Int32, ByVal hs_09 As System.Int32, ByVal hs_10 As System.Int32, ByVal hs_11 As System.Int32, ByVal hs_12 As System.Int32, ByVal hs_13 As System.Int32, ByVal hs_14 As System.Int32, ByVal hs_15 As System.Int32, ByVal hs_16 As System.Int32, ByVal hs_17 As System.Int32, ByVal hs_18 As System.Int32, ByVal hs_19 As System.Int32, ByVal hs_20 As System.Int32, ByVal hs_21 As System.Int32, ByVal hs_22 As System.Int32, ByVal hs_23 As System.Int32, ByVal hs_24 As System.Int32, ByVal hs_01 As System.Int32, ByVal hs_02 As System.Int32, ByVal hs_03 As System.Int32, ByVal hs_04 As System.Int32, ByVal hs_05 As System.Int32, ByVal hs_06 As System.Int32, ByVal hs_07 As System.Int32, ByVal hs_sh As System.Int32, ByVal usuario_id As System.Int32, ByVal respira As System.Boolean, ByVal contacto As System.Boolean, ByVal tqt As System.Boolean, ByVal arm As System.Boolean, ByVal oxigeno As System.Boolean, ByVal vo As System.Boolean, ByVal sng As System.Boolean, ByVal gastro As System.Boolean, ByVal sv As System.Boolean, ByVal cat As System.Boolean, ByVal talla As System.Boolean, ByVal talon As System.Boolean, ByVal sac As System.Boolean, ByVal isq As System.Boolean, ByVal fechamodificacion As System.DateTime, ByVal Pediatrico As System.Boolean) As Entities.Tables.PACIENTES
            Try
                Dim NewItem As New Entities.Tables.PACIENTES
                With NewItem
                    .PACIENTE_ID = paciente_id
                    .NUMEROHISTORIACLINICA = numerohistoriaclinica
                    .NUMEROINTERNACION = numerointernacion
                    .HABITACION_ID = habitacion_id
                    .SEDE_ID = sede_id
                    .NOMBRE = nombre
                    .APELLIDO = apellido
                    .GENERO = genero
                    .FECHANACIMIENTO = fechanacimiento
                    .TIPODOCUMENTO_ID = tipodocumento_id
                    .NUMERODOCUMENTO = numerodocumento
                    .DIAGNOSTICO_ID = diagnostico_id
                    .FECHAINGRESO = fechaingreso
                    .OBRASOCIAL_ID = obrasocial_id
                    .NUMEROOBRASOCIAL = numeroobrasocial
                    .FECHAEGRESO = fechaegreso
                    .MOTIVOEGRESO_ID = motivoegreso_id
                    .ACOMPANIANTE = acompaniante
                    .ITEMPENDIENTE = itempendiente
                    .PREALTA = prealta
                    .SOLICITUDESTUDIO = solicitudestudio
                    .SOLICITUDTRASLADO = solicitudtraslado
                    .INTERCONSULTAPENDIENTE = interconsultapendiente
                    .ALTAAUTORIZADA = altaautorizada
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .USUARIO_ID = usuario_id
                    .RESPIRA = respira
                    .CONTACTO = contacto
                    .TQT = tqt
                    .ARM = arm
                    .OXIGENO = oxigeno
                    .VO = vo
                    .SNG = sng
                    .GASTRO = gastro
                    .SV = sv
                    .CAT = cat
                    .TALLA = talla
                    .TALON = talon
                    .SAC = sac
                    .ISQ = isq
                    .FECHAMODIFICACION = fechamodificacion
                    .PEDIATRICO = Pediatrico

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PACIENTES) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal paciente_id As System.Int32, ByVal numerohistoriaclinica As System.Int32, ByVal numerointernacion As System.Int32, ByVal habitacion_id As System.Int32, ByVal sede_id As System.Int32, ByVal nombre As System.String, ByVal apellido As System.String, ByVal genero As System.Boolean, ByVal fechanacimiento As System.DateTime, ByVal tipodocumento_id As System.Int32, ByVal numerodocumento As System.Int32, ByVal diagnostico_id As System.Int32, ByVal fechaingreso As System.DateTime, ByVal obrasocial_id As System.String, ByVal numeroobrasocial As System.Int32, ByVal fechaegreso As System.DateTime, ByVal motivoegreso_id As System.Int32, ByVal acompaniante As System.Boolean, ByVal itempendiente As System.Boolean, ByVal prealta As System.Boolean, ByVal solicitudestudio As System.Boolean, ByVal solicitudtraslado As System.Boolean, ByVal interconsultapendiente As System.Boolean, ByVal altaautorizada As System.Boolean, ByVal hs_08 As System.Int32, ByVal hs_09 As System.Int32, ByVal hs_10 As System.Int32, ByVal hs_11 As System.Int32, ByVal hs_12 As System.Int32, ByVal hs_13 As System.Int32, ByVal hs_14 As System.Int32, ByVal hs_15 As System.Int32, ByVal hs_16 As System.Int32, ByVal hs_17 As System.Int32, ByVal hs_18 As System.Int32, ByVal hs_19 As System.Int32, ByVal hs_20 As System.Int32, ByVal hs_21 As System.Int32, ByVal hs_22 As System.Int32, ByVal hs_23 As System.Int32, ByVal hs_24 As System.Int32, ByVal hs_01 As System.Int32, ByVal hs_02 As System.Int32, ByVal hs_03 As System.Int32, ByVal hs_04 As System.Int32, ByVal hs_05 As System.Int32, ByVal hs_06 As System.Int32, ByVal hs_07 As System.Int32, ByVal hs_sh As System.Int32, ByVal usuario_id As System.Int32, ByVal respira As System.Boolean, ByVal contacto As System.Boolean, ByVal tqt As System.Boolean, ByVal arm As System.Boolean, ByVal oxigeno As System.Boolean, ByVal vo As System.Boolean, ByVal sng As System.Boolean, ByVal gastro As System.Boolean, ByVal sv As System.Boolean, ByVal cat As System.Boolean, ByVal talla As System.Boolean, ByVal talon As System.Boolean, ByVal sac As System.Boolean, ByVal isq As System.Boolean, ByVal fechamodificacion As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PACIENTES
                With NewItem
                    .PACIENTE_ID = paciente_id
                    .NUMEROHISTORIACLINICA = numerohistoriaclinica
                    .NUMEROINTERNACION = numerointernacion
                    .HABITACION_ID = habitacion_id
                    .SEDE_ID = sede_id
                    .NOMBRE = nombre
                    .APELLIDO = apellido
                    .GENERO = genero
                    .FECHANACIMIENTO = fechanacimiento
                    .TIPODOCUMENTO_ID = tipodocumento_id
                    .NUMERODOCUMENTO = numerodocumento
                    .DIAGNOSTICO_ID = diagnostico_id
                    .FECHAINGRESO = fechaingreso
                    .OBRASOCIAL_ID = obrasocial_id
                    .NUMEROOBRASOCIAL = numeroobrasocial
                    .FECHAEGRESO = fechaegreso
                    .MOTIVOEGRESO_ID = motivoegreso_id
                    .ACOMPANIANTE = acompaniante
                    .ITEMPENDIENTE = itempendiente
                    .PREALTA = prealta
                    .SOLICITUDESTUDIO = solicitudestudio
                    .SOLICITUDTRASLADO = solicitudtraslado
                    .INTERCONSULTAPENDIENTE = interconsultapendiente
                    .ALTAAUTORIZADA = altaautorizada
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .USUARIO_ID = usuario_id
                    .RESPIRA = respira
                    .CONTACTO = contacto
                    .TQT = tqt
                    .ARM = arm
                    .OXIGENO = oxigeno
                    .VO = vo
                    .SNG = sng
                    .GASTRO = gastro
                    .SV = sv
                    .CAT = cat
                    .TALLA = talla
                    .TALON = talon
                    .SAC = sac
                    .ISQ = isq
                    .FECHAMODIFICACION = fechamodificacion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PACIENTES) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal paciente_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PACIENTES
                With NewItem
                    .PACIENTE_ID = paciente_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PACIENTES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PACIENTES_HISTORIAL
        Inherits DAL.Tables.PACIENTES_HISTORIAL
        Public Overloads Function ItemList() As List(Of Entities.Tables.PACIENTES_HISTORIAL)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Tables.PACIENTES_HISTORIAL)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.paciente_id, DAL.SqlEnums.OperandEnum.Equal, paciente_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PACIENTES_HISTORIAL) As Entities.Tables.PACIENTES_HISTORIAL
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal paciente_id As System.Int32, ByVal numerohistoriaclinica As System.Int32, ByVal numerointernacion As System.Int32, ByVal habitacion_id As System.Int32, ByVal sede_id As System.Int32, ByVal nombre As System.String, ByVal apellido As System.String, ByVal genero As System.Boolean, ByVal fechanacimiento As System.DateTime, ByVal tipodocumento_id As System.Int32, ByVal numerodocumento As System.Int32, ByVal diagnostico_id As System.Int32, ByVal fechaingreso As System.DateTime, ByVal obrasocial_id As System.String, ByVal numeroobrasocial As System.Int32, ByVal fechaegreso As System.DateTime, ByVal motivoegreso_id As System.Int32, ByVal acompaniante As System.Boolean, ByVal itempendiente As System.Boolean, ByVal prealta As System.Boolean, ByVal solicitudestudio As System.Boolean, ByVal solicitudtraslado As System.Boolean, ByVal interconsultapendiente As System.Boolean, ByVal altaautorizada As System.Boolean, ByVal hs_08 As System.Int32, ByVal hs_09 As System.Int32, ByVal hs_10 As System.Int32, ByVal hs_11 As System.Int32, ByVal hs_12 As System.Int32, ByVal hs_13 As System.Int32, ByVal hs_14 As System.Int32, ByVal hs_15 As System.Int32, ByVal hs_16 As System.Int32, ByVal hs_17 As System.Int32, ByVal hs_18 As System.Int32, ByVal hs_19 As System.Int32, ByVal hs_20 As System.Int32, ByVal hs_21 As System.Int32, ByVal hs_22 As System.Int32, ByVal hs_23 As System.Int32, ByVal hs_24 As System.Int32, ByVal hs_01 As System.Int32, ByVal hs_02 As System.Int32, ByVal hs_03 As System.Int32, ByVal hs_04 As System.Int32, ByVal hs_05 As System.Int32, ByVal hs_06 As System.Int32, ByVal hs_07 As System.Int32, ByVal hs_sh As System.Int32, ByVal usuario_id As System.Int32, ByVal respira As System.Boolean, ByVal contacto As System.Boolean, ByVal tqt As System.Boolean, ByVal arm As System.Boolean, ByVal oxigeno As System.Boolean, ByVal vo As System.Boolean, ByVal sng As System.Boolean, ByVal gastro As System.Boolean, ByVal sv As System.Boolean, ByVal cat As System.Boolean, ByVal talla As System.Boolean, ByVal talon As System.Boolean, ByVal sac As System.Boolean, ByVal isq As System.Boolean, ByVal fechamodificacion As System.DateTime) As Entities.Tables.PACIENTES_HISTORIAL
            Try
                Dim NewItem As New Entities.Tables.PACIENTES_HISTORIAL
                With NewItem
                    .PACIENTE_ID = paciente_id
                    .NUMEROHISTORIACLINICA = numerohistoriaclinica
                    .NUMEROINTERNACION = numerointernacion
                    .HABITACION_ID = habitacion_id
                    .SEDE_ID = sede_id
                    .NOMBRE = nombre
                    .APELLIDO = apellido
                    .GENERO = genero
                    .FECHANACIMIENTO = fechanacimiento
                    .TIPODOCUMENTO_ID = tipodocumento_id
                    .NUMERODOCUMENTO = numerodocumento
                    .DIAGNOSTICO_ID = diagnostico_id
                    .FECHAINGRESO = fechaingreso
                    .OBRASOCIAL_ID = obrasocial_id
                    .NUMEROOBRASOCIAL = numeroobrasocial
                    .FECHAEGRESO = fechaegreso
                    .MOTIVOEGRESO_ID = motivoegreso_id
                    .ACOMPANIANTE = acompaniante
                    .ITEMPENDIENTE = itempendiente
                    .PREALTA = prealta
                    .SOLICITUDESTUDIO = solicitudestudio
                    .SOLICITUDTRASLADO = solicitudtraslado
                    .INTERCONSULTAPENDIENTE = interconsultapendiente
                    .ALTAAUTORIZADA = altaautorizada
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .USUARIO_ID = usuario_id
                    .RESPIRA = respira
                    .CONTACTO = contacto
                    .TQT = tqt
                    .ARM = arm
                    .OXIGENO = oxigeno
                    .VO = vo
                    .SNG = sng
                    .GASTRO = gastro
                    .SV = sv
                    .CAT = cat
                    .TALLA = talla
                    .TALON = talon
                    .SAC = sac
                    .ISQ = isq
                    .FECHAMODIFICACION = fechamodificacion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PACIENTES_HISTORIAL) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal paciente_id As System.Int32, ByVal numerohistoriaclinica As System.Int32, ByVal numerointernacion As System.Int32, ByVal habitacion_id As System.Int32, ByVal sede_id As System.Int32, ByVal nombre As System.String, ByVal apellido As System.String, ByVal genero As System.Boolean, ByVal fechanacimiento As System.DateTime, ByVal tipodocumento_id As System.Int32, ByVal numerodocumento As System.Int32, ByVal diagnostico_id As System.Int32, ByVal fechaingreso As System.DateTime, ByVal obrasocial_id As System.String, ByVal numeroobrasocial As System.Int32, ByVal fechaegreso As System.DateTime, ByVal motivoegreso_id As System.Int32, ByVal acompaniante As System.Boolean, ByVal itempendiente As System.Boolean, ByVal prealta As System.Boolean, ByVal solicitudestudio As System.Boolean, ByVal solicitudtraslado As System.Boolean, ByVal interconsultapendiente As System.Boolean, ByVal altaautorizada As System.Boolean, ByVal hs_08 As System.Int32, ByVal hs_09 As System.Int32, ByVal hs_10 As System.Int32, ByVal hs_11 As System.Int32, ByVal hs_12 As System.Int32, ByVal hs_13 As System.Int32, ByVal hs_14 As System.Int32, ByVal hs_15 As System.Int32, ByVal hs_16 As System.Int32, ByVal hs_17 As System.Int32, ByVal hs_18 As System.Int32, ByVal hs_19 As System.Int32, ByVal hs_20 As System.Int32, ByVal hs_21 As System.Int32, ByVal hs_22 As System.Int32, ByVal hs_23 As System.Int32, ByVal hs_24 As System.Int32, ByVal hs_01 As System.Int32, ByVal hs_02 As System.Int32, ByVal hs_03 As System.Int32, ByVal hs_04 As System.Int32, ByVal hs_05 As System.Int32, ByVal hs_06 As System.Int32, ByVal hs_07 As System.Int32, ByVal hs_sh As System.Int32, ByVal usuario_id As System.Int32, ByVal respira As System.Boolean, ByVal contacto As System.Boolean, ByVal tqt As System.Boolean, ByVal arm As System.Boolean, ByVal oxigeno As System.Boolean, ByVal vo As System.Boolean, ByVal sng As System.Boolean, ByVal gastro As System.Boolean, ByVal sv As System.Boolean, ByVal cat As System.Boolean, ByVal talla As System.Boolean, ByVal talon As System.Boolean, ByVal sac As System.Boolean, ByVal isq As System.Boolean, ByVal fechamodificacion As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PACIENTES_HISTORIAL
                With NewItem
                    .PACIENTE_ID = paciente_id
                    .NUMEROHISTORIACLINICA = numerohistoriaclinica
                    .NUMEROINTERNACION = numerointernacion
                    .HABITACION_ID = habitacion_id
                    .SEDE_ID = sede_id
                    .NOMBRE = nombre
                    .APELLIDO = apellido
                    .GENERO = genero
                    .FECHANACIMIENTO = fechanacimiento
                    .TIPODOCUMENTO_ID = tipodocumento_id
                    .NUMERODOCUMENTO = numerodocumento
                    .DIAGNOSTICO_ID = diagnostico_id
                    .FECHAINGRESO = fechaingreso
                    .OBRASOCIAL_ID = obrasocial_id
                    .NUMEROOBRASOCIAL = numeroobrasocial
                    .FECHAEGRESO = fechaegreso
                    .MOTIVOEGRESO_ID = motivoegreso_id
                    .ACOMPANIANTE = acompaniante
                    .ITEMPENDIENTE = itempendiente
                    .PREALTA = prealta
                    .SOLICITUDESTUDIO = solicitudestudio
                    .SOLICITUDTRASLADO = solicitudtraslado
                    .INTERCONSULTAPENDIENTE = interconsultapendiente
                    .ALTAAUTORIZADA = altaautorizada
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .USUARIO_ID = usuario_id
                    .RESPIRA = respira
                    .CONTACTO = contacto
                    .TQT = tqt
                    .ARM = arm
                    .OXIGENO = oxigeno
                    .VO = vo
                    .SNG = sng
                    .GASTRO = gastro
                    .SV = sv
                    .CAT = cat
                    .TALLA = talla
                    .TALON = talon
                    .SAC = sac
                    .ISQ = isq
                    .FECHAMODIFICACION = fechamodificacion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PACIENTES_HISTORIAL) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal paciente_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PACIENTES_HISTORIAL
                With NewItem
                    .PACIENTE_ID = paciente_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PACIENTES_HISTORIAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class SEDES
        Inherits DAL.Tables.SEDES
        Public Overloads Function ItemList() As List(Of Entities.Tables.SEDES)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal sede_id As System.Int32) As List(Of Entities.Tables.SEDES)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.sede_id, DAL.SqlEnums.OperandEnum.Equal, sede_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.SEDES) As Entities.Tables.SEDES
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal sede_id As System.Int32, ByVal descripcion As System.String, ByVal empresa_id As System.Int32) As Entities.Tables.SEDES
            Try
                Dim NewItem As New Entities.Tables.SEDES
                With NewItem
                    .SEDE_ID = sede_id
                    .DESCRIPCION = descripcion
                    .EMPRESA_ID = empresa_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.SEDES) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal sede_id As System.Int32, ByVal descripcion As System.String, ByVal empresa_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.SEDES
                With NewItem
                    .SEDE_ID = sede_id
                    .DESCRIPCION = descripcion
                    .EMPRESA_ID = empresa_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.SEDES) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal sede_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.SEDES
                With NewItem
                    .SEDE_ID = sede_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.SEDES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PROCEDIMIENTOS
        Inherits DAL.Tables.PROCEDIMIENTOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.PROCEDIMIENTOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal procedimiento_id As System.Int32) As List(Of Entities.Tables.PROCEDIMIENTOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.procedimiento_id, DAL.SqlEnums.OperandEnum.Equal, procedimiento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PROCEDIMIENTOS) As Entities.Tables.PROCEDIMIENTOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal procedimiento_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.PROCEDIMIENTOS
            Try
                Dim NewItem As New Entities.Tables.PROCEDIMIENTOS
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PROCEDIMIENTOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal procedimiento_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PROCEDIMIENTOS
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PROCEDIMIENTOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal procedimiento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PROCEDIMIENTOS
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PROCEDIMIENTOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class CONTACTOPACIENTE
        Inherits DAL.Tables.CONTACTOPACIENTE
        Public Overloads Function ItemList() As List(Of Entities.Tables.CONTACTOPACIENTE)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal contacto_id As System.Int32) As List(Of Entities.Tables.CONTACTOPACIENTE)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.contacto_id, DAL.SqlEnums.OperandEnum.Equal, contacto_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.CONTACTOPACIENTE) As Entities.Tables.CONTACTOPACIENTE
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal contacto_id As System.Int32, ByVal nombre As System.String, ByVal apellido As System.String, ByVal tel1 As System.String, ByVal tel2 As System.String, ByVal tel3 As System.String, ByVal relacion As System.String, ByVal paciente_id As System.Int32) As Entities.Tables.CONTACTOPACIENTE
            Try
                Dim NewItem As New Entities.Tables.CONTACTOPACIENTE
                With NewItem
                    .CONTACTO_ID = contacto_id
                    .NOMBRE = nombre
                    .APELLIDO = apellido
                    .TEL1 = tel1
                    .TEL2 = tel2
                    .TEL3 = tel3
                    .RELACION = relacion
                    .PACIENTE_ID = paciente_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.CONTACTOPACIENTE) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal contacto_id As System.Int32, ByVal nombre As System.String, ByVal apellido As System.String, ByVal tel1 As System.String, ByVal tel2 As System.String, ByVal tel3 As System.String, ByVal relacion As System.String, ByVal paciente_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.CONTACTOPACIENTE
                With NewItem
                    .CONTACTO_ID = contacto_id
                    .NOMBRE = nombre
                    .APELLIDO = apellido
                    .TEL1 = tel1
                    .TEL2 = tel2
                    .TEL3 = tel3
                    .RELACION = relacion
                    .PACIENTE_ID = paciente_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.CONTACTOPACIENTE) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal contacto_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.CONTACTOPACIENTE
                With NewItem
                    .CONTACTO_ID = contacto_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.CONTACTOPACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PERTENENCIASPACIENTE
        Inherits DAL.Tables.PERTENENCIASPACIENTE
        Public Overloads Function ItemList() As List(Of Entities.Tables.PERTENENCIASPACIENTE)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id As System.Int32) As List(Of Entities.Tables.PERTENENCIASPACIENTE)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id, DAL.SqlEnums.OperandEnum.Equal, id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PERTENENCIASPACIENTE) As Entities.Tables.PERTENENCIASPACIENTE
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id As System.Int32, ByVal paciente_id As System.Int32, ByVal nombrepaciente As System.String, ByVal fecha_alta As System.DateTime, ByVal motivoalta_id As System.Int32, ByVal supervisorenf As System.String, ByVal gobernante As System.String, ByVal cantbolsas As System.Int32, ByVal obssede As System.String, ByVal fechadeposito As System.DateTime, ByVal fechalegales As System.DateTime, ByVal fecharetiro As System.DateTime, ByVal respretiro As System.Int32, ByVal obsretiro As System.String, ByVal cantllamados As System.Int32, ByVal fechalimite As System.DateTime, ByVal estado_id As System.Int32, ByVal mailsalertas As System.String, ByVal sede As System.String) As Entities.Tables.PERTENENCIASPACIENTE
            Try
                Dim NewItem As New Entities.Tables.PERTENENCIASPACIENTE
                With NewItem
                    .ID = id
                    .PACIENTE_ID = paciente_id
                    .NOMBREPACIENTE = nombrepaciente
                    .FECHA_ALTA = fecha_alta
                    .MOTIVOALTA_ID = motivoalta_id
                    .SUPERVISORENF = supervisorenf
                    .GOBERNANTE = gobernante
                    .CANTBOLSAS = cantbolsas
                    .OBSSEDE = obssede
                    .FECHADEPOSITO = fechadeposito
                    .FECHALEGALES = fechalegales
                    .FECHARETIRO = fecharetiro
                    .RESPRETIRO = respretiro
                    .OBSRETIRO = obsretiro
                    .CANTLLAMADOS = cantllamados
                    .FECHALIMITE = fechalimite
                    .ESTADO_ID = estado_id
                    .MAILSALERTAS = mailsalertas
                    .SEDE = sede

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PERTENENCIASPACIENTE) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id As System.Int32, ByVal paciente_id As System.Int32, ByVal nombrepaciente As System.String, ByVal fecha_alta As System.DateTime, ByVal motivoalta_id As System.Int32, ByVal supervisorenf As System.String, ByVal gobernante As System.String, ByVal cantbolsas As System.Int32, ByVal obssede As System.String, ByVal fechadeposito As System.DateTime, ByVal fechalegales As System.DateTime, ByVal fecharetiro As System.DateTime, ByVal respretiro As System.Int32, ByVal obsretiro As System.String, ByVal cantllamados As System.Int32, ByVal fechalimite As System.DateTime, ByVal estado_id As System.Int32, ByVal mailsalertas As System.String, ByVal sede As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PERTENENCIASPACIENTE
                With NewItem
                    .ID = id
                    .PACIENTE_ID = paciente_id
                    .NOMBREPACIENTE = nombrepaciente
                    .FECHA_ALTA = fecha_alta
                    .MOTIVOALTA_ID = motivoalta_id
                    .SUPERVISORENF = supervisorenf
                    .GOBERNANTE = gobernante
                    .CANTBOLSAS = cantbolsas
                    .OBSSEDE = obssede
                    .FECHADEPOSITO = fechadeposito
                    .FECHALEGALES = fechalegales
                    .FECHARETIRO = fecharetiro
                    .RESPRETIRO = respretiro
                    .OBSRETIRO = obsretiro
                    .CANTLLAMADOS = cantllamados
                    .FECHALIMITE = fechalimite
                    .ESTADO_ID = estado_id
                    .MAILSALERTAS = mailsalertas
                    .SEDE = sede

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PERTENENCIASPACIENTE) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PERTENENCIASPACIENTE
                With NewItem
                    .ID = id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PERTENENCIASPACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MOTIVOEGRESO
        Inherits DAL.Tables.MOTIVOEGRESO
        Public Overloads Function ItemList() As List(Of Entities.Tables.MOTIVOEGRESO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal motivoegreso_id As System.Int32) As List(Of Entities.Tables.MOTIVOEGRESO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.motivoEgreso_id, DAL.SqlEnums.OperandEnum.Equal, motivoegreso_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MOTIVOEGRESO) As Entities.Tables.MOTIVOEGRESO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal motivoegreso_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.MOTIVOEGRESO
            Try
                Dim NewItem As New Entities.Tables.MOTIVOEGRESO
                With NewItem
                    .MOTIVOEGRESO_ID = motivoegreso_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MOTIVOEGRESO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal motivoegreso_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MOTIVOEGRESO
                With NewItem
                    .MOTIVOEGRESO_ID = motivoegreso_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MOTIVOEGRESO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal motivoegreso_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MOTIVOEGRESO
                With NewItem
                    .MOTIVOEGRESO_ID = motivoegreso_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MOTIVOEGRESO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class ESTADOSPERTENENCIASPACIENTE
        Inherits DAL.Tables.ESTADOSPERTENENCIASPACIENTE
        Public Overloads Function ItemList() As List(Of Entities.Tables.ESTADOSPERTENENCIASPACIENTE)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal estado_id As System.Int32) As List(Of Entities.Tables.ESTADOSPERTENENCIASPACIENTE)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.estado_id, DAL.SqlEnums.OperandEnum.Equal, estado_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.ESTADOSPERTENENCIASPACIENTE) As Entities.Tables.ESTADOSPERTENENCIASPACIENTE
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal estado_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.ESTADOSPERTENENCIASPACIENTE
            Try
                Dim NewItem As New Entities.Tables.ESTADOSPERTENENCIASPACIENTE
                With NewItem
                    .ESTADO_ID = estado_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.ESTADOSPERTENENCIASPACIENTE) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal estado_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.ESTADOSPERTENENCIASPACIENTE
                With NewItem
                    .ESTADO_ID = estado_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.ESTADOSPERTENENCIASPACIENTE) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal estado_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.ESTADOSPERTENENCIASPACIENTE
                With NewItem
                    .ESTADO_ID = estado_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.ESTADOSPERTENENCIASPACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_DILUYENTE
        Inherits DAL.Tables.MED_DILUYENTE
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_DILUYENTE)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal diluyente_id As System.Int32) As List(Of Entities.Tables.MED_DILUYENTE)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.diluyente_id, DAL.SqlEnums.OperandEnum.Equal, diluyente_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_DILUYENTE) As Entities.Tables.MED_DILUYENTE
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal diluyente_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.MED_DILUYENTE
            Try
                Dim NewItem As New Entities.Tables.MED_DILUYENTE
                With NewItem
                    .DILUYENTE_ID = diluyente_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_DILUYENTE) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal diluyente_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_DILUYENTE
                With NewItem
                    .DILUYENTE_ID = diluyente_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_DILUYENTE) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal diluyente_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_DILUYENTE
                With NewItem
                    .DILUYENTE_ID = diluyente_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_DILUYENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_EVENTO
        Inherits DAL.Tables.MED_EVENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_EVENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal evento_id As System.Int32) As List(Of Entities.Tables.MED_EVENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.evento_id, DAL.SqlEnums.OperandEnum.Equal, evento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_EVENTO) As Entities.Tables.MED_EVENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal evento_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.MED_EVENTO
            Try
                Dim NewItem As New Entities.Tables.MED_EVENTO
                With NewItem
                    .EVENTO_ID = evento_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_EVENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal evento_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_EVENTO
                With NewItem
                    .EVENTO_ID = evento_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_EVENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal evento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_EVENTO
                With NewItem
                    .EVENTO_ID = evento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_EVENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_HORARIODESUMINISTRO
        Inherits DAL.Tables.MED_HORARIODESUMINISTRO
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_HORARIODESUMINISTRO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal horariodesuministro_id As System.Int32) As List(Of Entities.Tables.MED_HORARIODESUMINISTRO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.horarioDeSuministro_id, DAL.SqlEnums.OperandEnum.Equal, horariodesuministro_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_HORARIODESUMINISTRO) As Entities.Tables.MED_HORARIODESUMINISTRO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal horariodesuministro_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.MED_HORARIODESUMINISTRO
            Try
                Dim NewItem As New Entities.Tables.MED_HORARIODESUMINISTRO
                With NewItem
                    .HORARIODESUMINISTRO_ID = horariodesuministro_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_HORARIODESUMINISTRO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal horariodesuministro_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_HORARIODESUMINISTRO
                With NewItem
                    .HORARIODESUMINISTRO_ID = horariodesuministro_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_HORARIODESUMINISTRO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal horariodesuministro_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_HORARIODESUMINISTRO
                With NewItem
                    .HORARIODESUMINISTRO_ID = horariodesuministro_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_HORARIODESUMINISTRO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_NUMERO
        Inherits DAL.Tables.MED_NUMERO
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_NUMERO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal numero_id As System.Int32) As List(Of Entities.Tables.MED_NUMERO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.numero_id, DAL.SqlEnums.OperandEnum.Equal, numero_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_NUMERO) As Entities.Tables.MED_NUMERO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal numero_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.MED_NUMERO
            Try
                Dim NewItem As New Entities.Tables.MED_NUMERO
                With NewItem
                    .NUMERO_ID = numero_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_NUMERO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal numero_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_NUMERO
                With NewItem
                    .NUMERO_ID = numero_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_NUMERO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal numero_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_NUMERO
                With NewItem
                    .NUMERO_ID = numero_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_NUMERO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_PERIODO
        Inherits DAL.Tables.MED_PERIODO
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_PERIODO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal periodo_id As System.Int32) As List(Of Entities.Tables.MED_PERIODO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.periodo_id, DAL.SqlEnums.OperandEnum.Equal, periodo_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_PERIODO) As Entities.Tables.MED_PERIODO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal periodo_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.MED_PERIODO
            Try
                Dim NewItem As New Entities.Tables.MED_PERIODO
                With NewItem
                    .PERIODO_ID = periodo_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_PERIODO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal periodo_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_PERIODO
                With NewItem
                    .PERIODO_ID = periodo_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_PERIODO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal periodo_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_PERIODO
                With NewItem
                    .PERIODO_ID = periodo_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_PERIODO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_PRESENTACION
        Inherits DAL.Tables.MED_PRESENTACION
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_PRESENTACION)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal presentacion_id As System.Int32) As List(Of Entities.Tables.MED_PRESENTACION)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.presentacion_id, DAL.SqlEnums.OperandEnum.Equal, presentacion_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_PRESENTACION) As Entities.Tables.MED_PRESENTACION
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal presentacion_id As System.Int32, ByVal descripcion As System.String, ByVal unidaddemedida_id As System.Int32) As Entities.Tables.MED_PRESENTACION
            Try
                Dim NewItem As New Entities.Tables.MED_PRESENTACION
                With NewItem
                    .PRESENTACION_ID = presentacion_id
                    .DESCRIPCION = descripcion
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_PRESENTACION) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal presentacion_id As System.Int32, ByVal descripcion As System.String, ByVal unidaddemedida_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_PRESENTACION
                With NewItem
                    .PRESENTACION_ID = presentacion_id
                    .DESCRIPCION = descripcion
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_PRESENTACION) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal presentacion_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_PRESENTACION
                With NewItem
                    .PRESENTACION_ID = presentacion_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_PRESENTACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_HISTORIAL_SUMINISTRO_MEDICACION
        Inherits DAL.Procedures.MED_GET_HISTORIAL_SUMINISTRO_MEDICACION
        Public Function ItemList(ByVal suministro_medicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal tipoget As System.String) As List(Of Entities.Procedures.MED_GET_HISTORIAL_SUMINISTRO_MEDICACION)
            Return MyBase.Items(suministro_medicacion_id, paciente_id, medicamento_id, tipoget)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_HISTORIAL_SUMINISTRO_MEDICACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_SUMINISTRO_MEDICACION
        Inherits DAL.Procedures.MED_GET_SUMINISTRO_MEDICACION
        Public Function ItemList(ByVal suministro_medicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal tipoget As System.String) As List(Of Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION)
            Return MyBase.Items(suministro_medicacion_id, paciente_id, medicamento_id, tipoget)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_UNIDADDEMEDIDA
        Inherits DAL.Tables.MED_UNIDADDEMEDIDA
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_UNIDADDEMEDIDA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal unidaddemedida_id As System.Int32) As List(Of Entities.Tables.MED_UNIDADDEMEDIDA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.unidadDeMedida_id, DAL.SqlEnums.OperandEnum.Equal, unidaddemedida_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_UNIDADDEMEDIDA) As Entities.Tables.MED_UNIDADDEMEDIDA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal unidaddemedida_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.MED_UNIDADDEMEDIDA
            Try
                Dim NewItem As New Entities.Tables.MED_UNIDADDEMEDIDA
                With NewItem
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_UNIDADDEMEDIDA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal unidaddemedida_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_UNIDADDEMEDIDA
                With NewItem
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_UNIDADDEMEDIDA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal unidaddemedida_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_UNIDADDEMEDIDA
                With NewItem
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_UNIDADDEMEDIDA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_VIA
        Inherits DAL.Tables.MED_VIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_VIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal via_id As System.Int32) As List(Of Entities.Tables.MED_VIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.via_id, DAL.SqlEnums.OperandEnum.Equal, via_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_VIA) As Entities.Tables.MED_VIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal via_id As System.Int32, ByVal descripcion As System.String, ByVal inactivo As System.Boolean) As Entities.Tables.MED_VIA
            Try
                Dim NewItem As New Entities.Tables.MED_VIA
                With NewItem
                    .VIA_ID = via_id
                    .DESCRIPCION = descripcion
                    .INACTIVO = inactivo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_VIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal via_id As System.Int32, ByVal descripcion As System.String, ByVal inactivo As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_VIA
                With NewItem
                    .VIA_ID = via_id
                    .DESCRIPCION = descripcion
                    .INACTIVO = inactivo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_VIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal via_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_VIA
                With NewItem
                    .VIA_ID = via_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_VIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_MEDICAMENTO_VIA
        Inherits DAL.Tables.MED_MEDICAMENTO_VIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_MEDICAMENTO_VIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal medicamentovia_id As System.Int32, ByVal medicamento_id As System.String, ByVal via_id As System.Int32) As List(Of Entities.Tables.MED_MEDICAMENTO_VIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.medicamentoVia_id, DAL.SqlEnums.OperandEnum.Equal, medicamentovia_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.medicamento_id, DAL.SqlEnums.OperandEnum.Equal, medicamento_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.via_id, DAL.SqlEnums.OperandEnum.Equal, via_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_MEDICAMENTO_VIA) As Entities.Tables.MED_MEDICAMENTO_VIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal medicamentovia_id As System.Int32, ByVal medicamento_id As System.String, ByVal via_id As System.Int32) As Entities.Tables.MED_MEDICAMENTO_VIA
            Try
                Dim NewItem As New Entities.Tables.MED_MEDICAMENTO_VIA
                With NewItem
                    .MEDICAMENTOVIA_ID = medicamentovia_id
                    .MEDICAMENTO_ID = medicamento_id
                    .VIA_ID = via_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_MEDICAMENTO_VIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal medicamentovia_id As System.Int32, ByVal medicamento_id As System.String, ByVal via_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_MEDICAMENTO_VIA
                With NewItem
                    .MEDICAMENTOVIA_ID = medicamentovia_id
                    .MEDICAMENTO_ID = medicamento_id
                    .VIA_ID = via_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_MEDICAMENTO_VIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal medicamentovia_id As System.Int32, ByVal medicamento_id As System.String, ByVal via_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_MEDICAMENTO_VIA
                With NewItem
                    .MEDICAMENTOVIA_ID = medicamentovia_id
                    .MEDICAMENTO_ID = medicamento_id
                    .VIA_ID = via_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_MEDICAMENTO_VIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_ENFERMERIA
        Inherits DAL.Tables.PRO_ENFERMERIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_ENFERMERIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal enfermeria_id As System.Int32) As List(Of Entities.Tables.PRO_ENFERMERIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.enfermeria_id, DAL.SqlEnums.OperandEnum.Equal, enfermeria_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_ENFERMERIA) As Entities.Tables.PRO_ENFERMERIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal enfermeria_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal controlvital As System.Boolean, ByVal frecuenciacardiaca As System.Boolean, ByVal frecuenciarespiratoria As System.Boolean, ByVal temperaturaaxilar As System.Boolean, ByVal diuresis As System.Boolean, ByVal glucemiacapilar As System.Boolean, ByVal multistickorina As System.Boolean, ByVal controlsaturacion As System.Boolean, ByVal medicionresiduosgastrico As System.Boolean, ByVal ecg As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_ENFERMERIA
            Try
                Dim NewItem As New Entities.Tables.PRO_ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTROLVITAL = controlvital
                    .FRECUENCIACARDIACA = frecuenciacardiaca
                    .FRECUENCIARESPIRATORIA = frecuenciarespiratoria
                    .TEMPERATURAAXILAR = temperaturaaxilar
                    .DIURESIS = diuresis
                    .GLUCEMIACAPILAR = glucemiacapilar
                    .MULTISTICKORINA = multistickorina
                    .CONTROLSATURACION = controlsaturacion
                    .MEDICIONRESIDUOSGASTRICO = medicionresiduosgastrico
                    .ECG = ecg
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_ENFERMERIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal enfermeria_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal controlvital As System.Boolean, ByVal frecuenciacardiaca As System.Boolean, ByVal frecuenciarespiratoria As System.Boolean, ByVal temperaturaaxilar As System.Boolean, ByVal diuresis As System.Boolean, ByVal glucemiacapilar As System.Boolean, ByVal multistickorina As System.Boolean, ByVal controlsaturacion As System.Boolean, ByVal medicionresiduosgastrico As System.Boolean, ByVal ecg As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTROLVITAL = controlvital
                    .FRECUENCIACARDIACA = frecuenciacardiaca
                    .FRECUENCIARESPIRATORIA = frecuenciarespiratoria
                    .TEMPERATURAAXILAR = temperaturaaxilar
                    .DIURESIS = diuresis
                    .GLUCEMIACAPILAR = glucemiacapilar
                    .MULTISTICKORINA = multistickorina
                    .CONTROLSATURACION = controlsaturacion
                    .MEDICIONRESIDUOSGASTRICO = medicionresiduosgastrico
                    .ECG = ecg
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_ENFERMERIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal enfermeria_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_ENFERMERIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GENERICO
        Inherits DAL.Tables.PRO_GENERICO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_GENERICO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal generico_id As System.Int32) As List(Of Entities.Tables.PRO_GENERICO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.generico_id, DAL.SqlEnums.OperandEnum.Equal, generico_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_GENERICO) As Entities.Tables.PRO_GENERICO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal generico_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_GENERICO
            Try
                Dim NewItem As New Entities.Tables.PRO_GENERICO
                With NewItem
                    .GENERICO_ID = generico_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_GENERICO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal generico_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_GENERICO
                With NewItem
                    .GENERICO_ID = generico_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_GENERICO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal generico_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_GENERICO
                With NewItem
                    .GENERICO_ID = generico_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_GENERICO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_ENFERMERIA
        Inherits DAL.Tables.PRO_HISTORIAL_ENFERMERIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_ENFERMERIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal enfermeria_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_ENFERMERIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.enfermeria_id, DAL.SqlEnums.OperandEnum.Equal, enfermeria_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_ENFERMERIA) As Entities.Tables.PRO_HISTORIAL_ENFERMERIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal enfermeria_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal controlvital As System.Boolean, ByVal frecuenciacardiaca As System.Boolean, ByVal frecuenciarespiratoria As System.Boolean, ByVal temperaturaaxilar As System.Boolean, ByVal diuresis As System.Boolean, ByVal glucemiacapilar As System.Boolean, ByVal multistickorina As System.Boolean, ByVal controlsaturacion As System.Boolean, ByVal medicionresiduosgastrico As System.Boolean, ByVal ecg As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_ENFERMERIA
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTROLVITAL = controlvital
                    .FRECUENCIACARDIACA = frecuenciacardiaca
                    .FRECUENCIARESPIRATORIA = frecuenciarespiratoria
                    .TEMPERATURAAXILAR = temperaturaaxilar
                    .DIURESIS = diuresis
                    .GLUCEMIACAPILAR = glucemiacapilar
                    .MULTISTICKORINA = multistickorina
                    .CONTROLSATURACION = controlsaturacion
                    .MEDICIONRESIDUOSGASTRICO = medicionresiduosgastrico
                    .ECG = ecg
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_ENFERMERIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal enfermeria_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal controlvital As System.Boolean, ByVal frecuenciacardiaca As System.Boolean, ByVal frecuenciarespiratoria As System.Boolean, ByVal temperaturaaxilar As System.Boolean, ByVal diuresis As System.Boolean, ByVal glucemiacapilar As System.Boolean, ByVal multistickorina As System.Boolean, ByVal controlsaturacion As System.Boolean, ByVal medicionresiduosgastrico As System.Boolean, ByVal ecg As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTROLVITAL = controlvital
                    .FRECUENCIACARDIACA = frecuenciacardiaca
                    .FRECUENCIARESPIRATORIA = frecuenciarespiratoria
                    .TEMPERATURAAXILAR = temperaturaaxilar
                    .DIURESIS = diuresis
                    .GLUCEMIACAPILAR = glucemiacapilar
                    .MULTISTICKORINA = multistickorina
                    .CONTROLSATURACION = controlsaturacion
                    .MEDICIONRESIDUOSGASTRICO = medicionresiduosgastrico
                    .ECG = ecg
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_ENFERMERIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal enfermeria_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_ENFERMERIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_GENERICO
        Inherits DAL.Tables.PRO_HISTORIAL_GENERICO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_GENERICO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal generico_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_GENERICO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.generico_id, DAL.SqlEnums.OperandEnum.Equal, generico_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_GENERICO) As Entities.Tables.PRO_HISTORIAL_GENERICO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal generico_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_GENERICO
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_GENERICO
                With NewItem
                    .GENERICO_ID = generico_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_GENERICO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal generico_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_GENERICO
                With NewItem
                    .GENERICO_ID = generico_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_GENERICO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal generico_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_GENERICO
                With NewItem
                    .GENERICO_ID = generico_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_GENERICO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_POSOLOGIA
        Inherits DAL.Tables.PRO_HISTORIAL_POSOLOGIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_POSOLOGIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal posologia_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_POSOLOGIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.posologia_id, DAL.SqlEnums.OperandEnum.Equal, posologia_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_POSOLOGIA) As Entities.Tables.PRO_HISTORIAL_POSOLOGIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal posologia_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal planoral As System.String, ByVal hiposodica As System.Boolean, ByVal sinliquidos As System.Boolean, ByVal liquidosfinos As System.Boolean, ByVal liquidosespesos As System.Boolean, ByVal liquidosaligerados As System.Boolean, ByVal supcontrol As System.Boolean, ByVal asistencia As System.Boolean, ByVal picado As System.Boolean, ByVal cortado As System.Boolean, ByVal hipograsa As System.Boolean, ByVal alimento_id As System.Int32, ByVal alimentovelocidad As System.Int32, ByVal gavageintervalo_id As System.Int32, ByVal gavagecantidad As System.Int32, ByVal preparado_id As System.Int32, ByVal preparadovelocidad As System.Int32, ByVal ayunofecha As System.DateTime, ByVal ayunohora As System.DateTime, ByVal liquidofecha As System.DateTime, ByVal liquidohora As System.DateTime, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_POSOLOGIA
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_POSOLOGIA
                With NewItem
                    .POSOLOGIA_ID = posologia_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLANORAL = planoral
                    .HIPOSODICA = hiposodica
                    .SINLIQUIDOS = sinliquidos
                    .LIQUIDOSFINOS = liquidosfinos
                    .LIQUIDOSESPESOS = liquidosespesos
                    .LIQUIDOSALIGERADOS = liquidosaligerados
                    .SUPCONTROL = supcontrol
                    .ASISTENCIA = asistencia
                    .PICADO = picado
                    .CORTADO = cortado
                    .HIPOGRASA = hipograsa
                    .ALIMENTO_ID = alimento_id
                    .ALIMENTOVELOCIDAD = alimentovelocidad
                    .GAVAGEINTERVALO_ID = gavageintervalo_id
                    .GAVAGECANTIDAD = gavagecantidad
                    .PREPARADO_ID = preparado_id
                    .PREPARADOVELOCIDAD = preparadovelocidad
                    .AYUNOFECHA = ayunofecha
                    .AYUNOHORA = ayunohora
                    .LIQUIDOFECHA = liquidofecha
                    .LIQUIDOHORA = liquidohora
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_POSOLOGIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal posologia_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal planoral As System.String, ByVal hiposodica As System.Boolean, ByVal sinliquidos As System.Boolean, ByVal liquidosfinos As System.Boolean, ByVal liquidosespesos As System.Boolean, ByVal liquidosaligerados As System.Boolean, ByVal supcontrol As System.Boolean, ByVal asistencia As System.Boolean, ByVal picado As System.Boolean, ByVal cortado As System.Boolean, ByVal hipograsa As System.Boolean, ByVal alimento_id As System.Int32, ByVal alimentovelocidad As System.Int32, ByVal gavageintervalo_id As System.Int32, ByVal gavagecantidad As System.Int32, ByVal preparado_id As System.Int32, ByVal preparadovelocidad As System.Int32, ByVal ayunofecha As System.DateTime, ByVal ayunohora As System.DateTime, ByVal liquidofecha As System.DateTime, ByVal liquidohora As System.DateTime, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_POSOLOGIA
                With NewItem
                    .POSOLOGIA_ID = posologia_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLANORAL = planoral
                    .HIPOSODICA = hiposodica
                    .SINLIQUIDOS = sinliquidos
                    .LIQUIDOSFINOS = liquidosfinos
                    .LIQUIDOSESPESOS = liquidosespesos
                    .LIQUIDOSALIGERADOS = liquidosaligerados
                    .SUPCONTROL = supcontrol
                    .ASISTENCIA = asistencia
                    .PICADO = picado
                    .CORTADO = cortado
                    .HIPOGRASA = hipograsa
                    .ALIMENTO_ID = alimento_id
                    .ALIMENTOVELOCIDAD = alimentovelocidad
                    .GAVAGEINTERVALO_ID = gavageintervalo_id
                    .GAVAGECANTIDAD = gavagecantidad
                    .PREPARADO_ID = preparado_id
                    .PREPARADOVELOCIDAD = preparadovelocidad
                    .AYUNOFECHA = ayunofecha
                    .AYUNOHORA = ayunohora
                    .LIQUIDOFECHA = liquidofecha
                    .LIQUIDOHORA = liquidohora
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_POSOLOGIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal posologia_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_POSOLOGIA
                With NewItem
                    .POSOLOGIA_ID = posologia_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_POSOLOGIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO
        Inherits DAL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal suministrodeprocedimiento_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.suministroDeProcedimiento_id, DAL.SqlEnums.OperandEnum.Equal, suministrodeprocedimiento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO) As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal suministrodeprocedimiento_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal tipoprocedimiento_id As System.Int32, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificiacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal enfermeria_id As System.Int32, ByVal posologia_id As System.Int32, ByVal generico_id As System.Int32, ByVal colocacionviaperiferica_id As System.Int32, ByVal cuidadooral_id As System.Int32, ByVal cuidadopostural_id As System.Int32, ByVal php_id As System.Int32, ByVal proteccionfisica_id As System.Int32) As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO
                With NewItem
                    .SUMINISTRODEPROCEDIMIENTO_ID = suministrodeprocedimiento_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .TIPOPROCEDIMIENTO_ID = tipoprocedimiento_id
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICIACION = fechamodificiacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .ENFERMERIA_ID = enfermeria_id
                    .POSOLOGIA_ID = posologia_id
                    .GENERICO_ID = generico_id
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .CUIDADOORAL_ID = cuidadooral_id
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PHP_ID = php_id
                    .PROTECCIONFISICA_ID = proteccionfisica_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal suministrodeprocedimiento_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal tipoprocedimiento_id As System.Int32, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificiacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal enfermeria_id As System.Int32, ByVal posologia_id As System.Int32, ByVal generico_id As System.Int32, ByVal colocacionviaperiferica_id As System.Int32, ByVal cuidadooral_id As System.Int32, ByVal cuidadopostural_id As System.Int32, ByVal php_id As System.Int32, ByVal proteccionfisica_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO
                With NewItem
                    .SUMINISTRODEPROCEDIMIENTO_ID = suministrodeprocedimiento_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .TIPOPROCEDIMIENTO_ID = tipoprocedimiento_id
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICIACION = fechamodificiacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .ENFERMERIA_ID = enfermeria_id
                    .POSOLOGIA_ID = posologia_id
                    .GENERICO_ID = generico_id
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .CUIDADOORAL_ID = cuidadooral_id
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PHP_ID = php_id
                    .PROTECCIONFISICA_ID = proteccionfisica_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal suministrodeprocedimiento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO
                With NewItem
                    .SUMINISTRODEPROCEDIMIENTO_ID = suministrodeprocedimiento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_SUMINISTRODEPROCEDIMIENTO
        Inherits DAL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal suministrodeprocedimiento_id As System.Int32) As List(Of Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.suministroDeProcedimiento_id, DAL.SqlEnums.OperandEnum.Equal, suministrodeprocedimiento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO) As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal suministrodeprocedimiento_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal tipoprocedimiento_id As System.Int32, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificiacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal enfermeria_id As System.Int32, ByVal posologia_id As System.Int32, ByVal generico_id As System.Int32, ByVal colocacionviaperiferica_id As System.Int32, ByVal cuidadooral_id As System.Int32, ByVal cuidadopostural_id As System.Int32, ByVal php_id As System.Int32, ByVal proteccionfisica_id As System.Int32) As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO
            Try
                Dim NewItem As New Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO
                With NewItem
                    .SUMINISTRODEPROCEDIMIENTO_ID = suministrodeprocedimiento_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .TIPOPROCEDIMIENTO_ID = tipoprocedimiento_id
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICIACION = fechamodificiacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .ENFERMERIA_ID = enfermeria_id
                    .POSOLOGIA_ID = posologia_id
                    .GENERICO_ID = generico_id
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .CUIDADOORAL_ID = cuidadooral_id
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PHP_ID = php_id
                    .PROTECCIONFISICA_ID = proteccionfisica_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal suministrodeprocedimiento_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal tipoprocedimiento_id As System.Int32, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificiacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal enfermeria_id As System.Int32, ByVal posologia_id As System.Int32, ByVal generico_id As System.Int32, ByVal colocacionviaperiferica_id As System.Int32, ByVal cuidadooral_id As System.Int32, ByVal cuidadopostural_id As System.Int32, ByVal php_id As System.Int32, ByVal proteccionfisica_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO
                With NewItem
                    .SUMINISTRODEPROCEDIMIENTO_ID = suministrodeprocedimiento_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .TIPOPROCEDIMIENTO_ID = tipoprocedimiento_id
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICIACION = fechamodificiacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .ENFERMERIA_ID = enfermeria_id
                    .POSOLOGIA_ID = posologia_id
                    .GENERICO_ID = generico_id
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .CUIDADOORAL_ID = cuidadooral_id
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PHP_ID = php_id
                    .PROTECCIONFISICA_ID = proteccionfisica_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal suministrodeprocedimiento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO
                With NewItem
                    .SUMINISTRODEPROCEDIMIENTO_ID = suministrodeprocedimiento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_POSOLOGIA
        Inherits DAL.Tables.PRO_POSOLOGIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_POSOLOGIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal posologia_id As System.Int32) As List(Of Entities.Tables.PRO_POSOLOGIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.posologia_id, DAL.SqlEnums.OperandEnum.Equal, posologia_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_POSOLOGIA) As Entities.Tables.PRO_POSOLOGIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal posologia_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal planoral As System.String, ByVal hiposodica As System.Boolean, ByVal sinliquidos As System.Boolean, ByVal liquidosfinos As System.Boolean, ByVal liquidosespesos As System.Boolean, ByVal liquidosaligerados As System.Boolean, ByVal supcontrol As System.Boolean, ByVal asistencia As System.Boolean, ByVal picado As System.Boolean, ByVal cortado As System.Boolean, ByVal hipograsa As System.Boolean, ByVal alimento_id As System.Int32, ByVal alimentovelocidad As System.Int32, ByVal gavageintervalo_id As System.Int32, ByVal gavagecantidad As System.Int32, ByVal preparado_id As System.Int32, ByVal preparadovelocidad As System.Int32, ByVal ayunofecha As System.DateTime, ByVal ayunohora As System.DateTime, ByVal liquidofecha As System.DateTime, ByVal liquidohora As System.DateTime, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_POSOLOGIA
            Try
                Dim NewItem As New Entities.Tables.PRO_POSOLOGIA
                With NewItem
                    .POSOLOGIA_ID = posologia_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLANORAL = planoral
                    .HIPOSODICA = hiposodica
                    .SINLIQUIDOS = sinliquidos
                    .LIQUIDOSFINOS = liquidosfinos
                    .LIQUIDOSESPESOS = liquidosespesos
                    .LIQUIDOSALIGERADOS = liquidosaligerados
                    .SUPCONTROL = supcontrol
                    .ASISTENCIA = asistencia
                    .PICADO = picado
                    .CORTADO = cortado
                    .HIPOGRASA = hipograsa
                    .ALIMENTO_ID = alimento_id
                    .ALIMENTOVELOCIDAD = alimentovelocidad
                    .GAVAGEINTERVALO_ID = gavageintervalo_id
                    .GAVAGECANTIDAD = gavagecantidad
                    .PREPARADO_ID = preparado_id
                    .PREPARADOVELOCIDAD = preparadovelocidad
                    .AYUNOFECHA = ayunofecha
                    .AYUNOHORA = ayunohora
                    .LIQUIDOFECHA = liquidofecha
                    .LIQUIDOHORA = liquidohora
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_POSOLOGIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal posologia_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal planoral As System.String, ByVal hiposodica As System.Boolean, ByVal sinliquidos As System.Boolean, ByVal liquidosfinos As System.Boolean, ByVal liquidosespesos As System.Boolean, ByVal liquidosaligerados As System.Boolean, ByVal supcontrol As System.Boolean, ByVal asistencia As System.Boolean, ByVal picado As System.Boolean, ByVal cortado As System.Boolean, ByVal hipograsa As System.Boolean, ByVal alimento_id As System.Int32, ByVal alimentovelocidad As System.Int32, ByVal gavageintervalo_id As System.Int32, ByVal gavagecantidad As System.Int32, ByVal preparado_id As System.Int32, ByVal preparadovelocidad As System.Int32, ByVal ayunofecha As System.DateTime, ByVal ayunohora As System.DateTime, ByVal liquidofecha As System.DateTime, ByVal liquidohora As System.DateTime, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_POSOLOGIA
                With NewItem
                    .POSOLOGIA_ID = posologia_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLANORAL = planoral
                    .HIPOSODICA = hiposodica
                    .SINLIQUIDOS = sinliquidos
                    .LIQUIDOSFINOS = liquidosfinos
                    .LIQUIDOSESPESOS = liquidosespesos
                    .LIQUIDOSALIGERADOS = liquidosaligerados
                    .SUPCONTROL = supcontrol
                    .ASISTENCIA = asistencia
                    .PICADO = picado
                    .CORTADO = cortado
                    .HIPOGRASA = hipograsa
                    .ALIMENTO_ID = alimento_id
                    .ALIMENTOVELOCIDAD = alimentovelocidad
                    .GAVAGEINTERVALO_ID = gavageintervalo_id
                    .GAVAGECANTIDAD = gavagecantidad
                    .PREPARADO_ID = preparado_id
                    .PREPARADOVELOCIDAD = preparadovelocidad
                    .AYUNOFECHA = ayunofecha
                    .AYUNOHORA = ayunohora
                    .LIQUIDOFECHA = liquidofecha
                    .LIQUIDOHORA = liquidohora
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_POSOLOGIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal posologia_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_POSOLOGIA
                With NewItem
                    .POSOLOGIA_ID = posologia_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_POSOLOGIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_TIPO_PROCEDIMIENTO
        Inherits DAL.Tables.PRO_TIPO_PROCEDIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_TIPO_PROCEDIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal tipoprocedimineto_id As System.Int32) As List(Of Entities.Tables.PRO_TIPO_PROCEDIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.tipoProcedimineto_id, DAL.SqlEnums.OperandEnum.Equal, tipoprocedimineto_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_TIPO_PROCEDIMIENTO) As Entities.Tables.PRO_TIPO_PROCEDIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal tipoprocedimineto_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.PRO_TIPO_PROCEDIMIENTO
            Try
                Dim NewItem As New Entities.Tables.PRO_TIPO_PROCEDIMIENTO
                With NewItem
                    .TIPOPROCEDIMINETO_ID = tipoprocedimineto_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_TIPO_PROCEDIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal tipoprocedimineto_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_TIPO_PROCEDIMIENTO
                With NewItem
                    .TIPOPROCEDIMINETO_ID = tipoprocedimineto_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_TIPO_PROCEDIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal tipoprocedimineto_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_TIPO_PROCEDIMIENTO
                With NewItem
                    .TIPOPROCEDIMINETO_ID = tipoprocedimineto_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_TIPO_PROCEDIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_ALIMENTO
        Inherits DAL.Tables.PRO_ALIMENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_ALIMENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal alimento_id As System.Int32) As List(Of Entities.Tables.PRO_ALIMENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.alimento_id, DAL.SqlEnums.OperandEnum.Equal, alimento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_ALIMENTO) As Entities.Tables.PRO_ALIMENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal alimento_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.PRO_ALIMENTO
            Try
                Dim NewItem As New Entities.Tables.PRO_ALIMENTO
                With NewItem
                    .ALIMENTO_ID = alimento_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_ALIMENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal alimento_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_ALIMENTO
                With NewItem
                    .ALIMENTO_ID = alimento_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_ALIMENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal alimento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_ALIMENTO
                With NewItem
                    .ALIMENTO_ID = alimento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_ALIMENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GAVAGEINTERVALO
        Inherits DAL.Tables.PRO_GAVAGEINTERVALO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_GAVAGEINTERVALO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal gavage_intervalo_id As System.Int32) As List(Of Entities.Tables.PRO_GAVAGEINTERVALO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.gavage_intervalo_id, DAL.SqlEnums.OperandEnum.Equal, gavage_intervalo_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_GAVAGEINTERVALO) As Entities.Tables.PRO_GAVAGEINTERVALO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal gavage_intervalo_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.PRO_GAVAGEINTERVALO
            Try
                Dim NewItem As New Entities.Tables.PRO_GAVAGEINTERVALO
                With NewItem
                    .GAVAGE_INTERVALO_ID = gavage_intervalo_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_GAVAGEINTERVALO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal gavage_intervalo_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_GAVAGEINTERVALO
                With NewItem
                    .GAVAGE_INTERVALO_ID = gavage_intervalo_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_GAVAGEINTERVALO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal gavage_intervalo_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_GAVAGEINTERVALO
                With NewItem
                    .GAVAGE_INTERVALO_ID = gavage_intervalo_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_GAVAGEINTERVALO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_PREPARADO
        Inherits DAL.Tables.PRO_PREPARADO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_PREPARADO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal preparado_id As System.Int32) As List(Of Entities.Tables.PRO_PREPARADO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.preparado_id, DAL.SqlEnums.OperandEnum.Equal, preparado_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_PREPARADO) As Entities.Tables.PRO_PREPARADO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal preparado_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.PRO_PREPARADO
            Try
                Dim NewItem As New Entities.Tables.PRO_PREPARADO
                With NewItem
                    .PREPARADO_ID = preparado_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_PREPARADO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal preparado_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PREPARADO
                With NewItem
                    .PREPARADO_ID = preparado_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_PREPARADO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal preparado_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PREPARADO
                With NewItem
                    .PREPARADO_ID = preparado_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_PREPARADO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TIPODOCUMENTO
        Inherits DAL.Tables.TIPODOCUMENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.TIPODOCUMENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal tipodocumento_id As System.Int32) As List(Of Entities.Tables.TIPODOCUMENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.tipoDocumento_id, DAL.SqlEnums.OperandEnum.Equal, tipodocumento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.TIPODOCUMENTO) As Entities.Tables.TIPODOCUMENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal tipodocumento_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.TIPODOCUMENTO
            Try
                Dim NewItem As New Entities.Tables.TIPODOCUMENTO
                With NewItem
                    .TIPODOCUMENTO_ID = tipodocumento_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.TIPODOCUMENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal tipodocumento_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TIPODOCUMENTO
                With NewItem
                    .TIPODOCUMENTO_ID = tipodocumento_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.TIPODOCUMENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal tipodocumento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.TIPODOCUMENTO
                With NewItem
                    .TIPODOCUMENTO_ID = tipodocumento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.TIPODOCUMENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_COLOCACION_VIA_PERIFERICA
        Inherits DAL.Tables.PRO_COLOCACION_VIA_PERIFERICA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal colocacionviaperiferica_id As System.Int32) As List(Of Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.colocacionViaPeriferica_id, DAL.SqlEnums.OperandEnum.Equal, colocacionviaperiferica_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA) As Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal colocacionviaperiferica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal abocathnumero_id As System.String, ByVal parchetegaderm As System.Boolean, ByVal infusion As System.Boolean, ByVal via As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA
            Try
                Dim NewItem As New Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA
                With NewItem
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ABOCATHNUMERO_ID = abocathnumero_id
                    .PARCHETEGADERM = parchetegaderm
                    .INFUSION = infusion
                    .VIA = via
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal colocacionviaperiferica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal abocathnumero_id As System.String, ByVal parchetegaderm As System.Boolean, ByVal infusion As System.Boolean, ByVal via As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA
                With NewItem
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ABOCATHNUMERO_ID = abocathnumero_id
                    .PARCHETEGADERM = parchetegaderm
                    .INFUSION = infusion
                    .VIA = via
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal colocacionviaperiferica_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA
                With NewItem
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_CUIDADO_ORAL
        Inherits DAL.Tables.PRO_CUIDADO_ORAL
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_CUIDADO_ORAL)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal cuidadooral_id As System.Int32) As List(Of Entities.Tables.PRO_CUIDADO_ORAL)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.cuidadoOral_id, DAL.SqlEnums.OperandEnum.Equal, cuidadooral_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_CUIDADO_ORAL) As Entities.Tables.PRO_CUIDADO_ORAL
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal cuidadooral_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal placadescanso As System.Boolean, ByVal mordillo As System.Boolean, ByVal clorhexidina As System.Boolean, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_CUIDADO_ORAL
            Try
                Dim NewItem As New Entities.Tables.PRO_CUIDADO_ORAL
                With NewItem
                    .CUIDADOORAL_ID = cuidadooral_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLACADESCANSO = placadescanso
                    .MORDILLO = mordillo
                    .CLORHEXIDINA = clorhexidina
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_CUIDADO_ORAL) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal cuidadooral_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal placadescanso As System.Boolean, ByVal mordillo As System.Boolean, ByVal clorhexidina As System.Boolean, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_CUIDADO_ORAL
                With NewItem
                    .CUIDADOORAL_ID = cuidadooral_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLACADESCANSO = placadescanso
                    .MORDILLO = mordillo
                    .CLORHEXIDINA = clorhexidina
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_CUIDADO_ORAL) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal cuidadooral_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_CUIDADO_ORAL
                With NewItem
                    .CUIDADOORAL_ID = cuidadooral_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_CUIDADO_ORAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_CUIDADO_POSTURAL
        Inherits DAL.Tables.PRO_CUIDADO_POSTURAL
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_CUIDADO_POSTURAL)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal cuidadopostural_id As System.Int32) As List(Of Entities.Tables.PRO_CUIDADO_POSTURAL)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.cuidadoPostural_id, DAL.SqlEnums.OperandEnum.Equal, cuidadopostural_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_CUIDADO_POSTURAL) As Entities.Tables.PRO_CUIDADO_POSTURAL
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal cuidadopostural_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal cabecera As System.Int32, ByVal rotar As System.Int32, ByVal movilizacionenbloque As System.Boolean, ByVal almohadon As System.Boolean, ByVal elevadorinodoros As System.Boolean, ByVal trianguloseparadorentrepierna As System.Boolean, ByVal evitaapoyotalon As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_CUIDADO_POSTURAL
            Try
                Dim NewItem As New Entities.Tables.PRO_CUIDADO_POSTURAL
                With NewItem
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CABECERA = cabecera
                    .ROTAR = rotar
                    .MOVILIZACIONENBLOQUE = movilizacionenbloque
                    .ALMOHADON = almohadon
                    .ELEVADORINODOROS = elevadorinodoros
                    .TRIANGULOSEPARADORENTREPIERNA = trianguloseparadorentrepierna
                    .EVITAAPOYOTALON = evitaapoyotalon
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_CUIDADO_POSTURAL) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal cuidadopostural_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal cabecera As System.Int32, ByVal rotar As System.Int32, ByVal movilizacionenbloque As System.Boolean, ByVal almohadon As System.Boolean, ByVal elevadorinodoros As System.Boolean, ByVal trianguloseparadorentrepierna As System.Boolean, ByVal evitaapoyotalon As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_CUIDADO_POSTURAL
                With NewItem
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CABECERA = cabecera
                    .ROTAR = rotar
                    .MOVILIZACIONENBLOQUE = movilizacionenbloque
                    .ALMOHADON = almohadon
                    .ELEVADORINODOROS = elevadorinodoros
                    .TRIANGULOSEPARADORENTREPIERNA = trianguloseparadorentrepierna
                    .EVITAAPOYOTALON = evitaapoyotalon
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_CUIDADO_POSTURAL) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal cuidadopostural_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_CUIDADO_POSTURAL
                With NewItem
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_CUIDADO_POSTURAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA
        Inherits DAL.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal colocacionviaperiferica_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.colocacionViaPeriferica_id, DAL.SqlEnums.OperandEnum.Equal, colocacionviaperiferica_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA) As Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal colocacionviaperiferica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal abocathnumero_id As System.String, ByVal parchetegaderm As System.Boolean, ByVal infusion As System.Boolean, ByVal via As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA
                With NewItem
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ABOCATHNUMERO_ID = abocathnumero_id
                    .PARCHETEGADERM = parchetegaderm
                    .INFUSION = infusion
                    .VIA = via
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal colocacionviaperiferica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal abocathnumero_id As System.String, ByVal parchetegaderm As System.Boolean, ByVal infusion As System.Boolean, ByVal via As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA
                With NewItem
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ABOCATHNUMERO_ID = abocathnumero_id
                    .PARCHETEGADERM = parchetegaderm
                    .INFUSION = infusion
                    .VIA = via
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal colocacionviaperiferica_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA
                With NewItem
                    .COLOCACIONVIAPERIFERICA_ID = colocacionviaperiferica_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_CUIDADO_ORAL
        Inherits DAL.Tables.PRO_HISTORIAL_CUIDADO_ORAL
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal cuidadooral_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.cuidadoOral_id, DAL.SqlEnums.OperandEnum.Equal, cuidadooral_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL) As Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal cuidadooral_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal placadescanso As System.Boolean, ByVal mordillo As System.Boolean, ByVal clorhexidina As System.Boolean, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL
                With NewItem
                    .CUIDADOORAL_ID = cuidadooral_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLACADESCANSO = placadescanso
                    .MORDILLO = mordillo
                    .CLORHEXIDINA = clorhexidina
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal cuidadooral_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal placadescanso As System.Boolean, ByVal mordillo As System.Boolean, ByVal clorhexidina As System.Boolean, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL
                With NewItem
                    .CUIDADOORAL_ID = cuidadooral_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .PLACADESCANSO = placadescanso
                    .MORDILLO = mordillo
                    .CLORHEXIDINA = clorhexidina
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal cuidadooral_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL
                With NewItem
                    .CUIDADOORAL_ID = cuidadooral_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_CUIDADO_POSTURAL
        Inherits DAL.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal cuidadopostural_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.cuidadoPostural_id, DAL.SqlEnums.OperandEnum.Equal, cuidadopostural_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL) As Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal cuidadopostural_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal cabecera As System.Int32, ByVal rotar As System.Int32, ByVal movilizacionenbloque As System.Boolean, ByVal almohadon As System.Boolean, ByVal elevadorinodoros As System.Boolean, ByVal trianguloseparadorentrepierna As System.Boolean, ByVal evitaapoyotalon As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL
                With NewItem
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CABECERA = cabecera
                    .ROTAR = rotar
                    .MOVILIZACIONENBLOQUE = movilizacionenbloque
                    .ALMOHADON = almohadon
                    .ELEVADORINODOROS = elevadorinodoros
                    .TRIANGULOSEPARADORENTREPIERNA = trianguloseparadorentrepierna
                    .EVITAAPOYOTALON = evitaapoyotalon
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal cuidadopostural_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal cabecera As System.Int32, ByVal rotar As System.Int32, ByVal movilizacionenbloque As System.Boolean, ByVal almohadon As System.Boolean, ByVal elevadorinodoros As System.Boolean, ByVal trianguloseparadorentrepierna As System.Boolean, ByVal evitaapoyotalon As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL
                With NewItem
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CABECERA = cabecera
                    .ROTAR = rotar
                    .MOVILIZACIONENBLOQUE = movilizacionenbloque
                    .ALMOHADON = almohadon
                    .ELEVADORINODOROS = elevadorinodoros
                    .TRIANGULOSEPARADORENTREPIERNA = trianguloseparadorentrepierna
                    .EVITAAPOYOTALON = evitaapoyotalon
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal cuidadopostural_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL
                With NewItem
                    .CUIDADOPOSTURAL_ID = cuidadopostural_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_PROTECCION_FISICA
        Inherits DAL.Tables.PRO_HISTORIAL_PROTECCION_FISICA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal proteccionfisica_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.proteccionFisica_id, DAL.SqlEnums.OperandEnum.Equal, proteccionfisica_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA) As Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal proteccionfisica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal contencionfisica As System.Boolean, ByVal colchonaire As System.Boolean, ByVal barandascama As System.Boolean, ByVal cascoproteccion As System.Boolean, ByVal chiripasilla As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA
                With NewItem
                    .PROTECCIONFISICA_ID = proteccionfisica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTENCIONFISICA = contencionfisica
                    .COLCHONAIRE = colchonaire
                    .BARANDASCAMA = barandascama
                    .CASCOPROTECCION = cascoproteccion
                    .CHIRIPASILLA = chiripasilla
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal proteccionfisica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal contencionfisica As System.Boolean, ByVal colchonaire As System.Boolean, ByVal barandascama As System.Boolean, ByVal cascoproteccion As System.Boolean, ByVal chiripasilla As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA
                With NewItem
                    .PROTECCIONFISICA_ID = proteccionfisica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTENCIONFISICA = contencionfisica
                    .COLCHONAIRE = colchonaire
                    .BARANDASCAMA = barandascama
                    .CASCOPROTECCION = cascoproteccion
                    .CHIRIPASILLA = chiripasilla
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal proteccionfisica_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA
                With NewItem
                    .PROTECCIONFISICA_ID = proteccionfisica_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_PROTECCION_FISICA
        Inherits DAL.Tables.PRO_PROTECCION_FISICA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_PROTECCION_FISICA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal proteccionfisica_id As System.Int32) As List(Of Entities.Tables.PRO_PROTECCION_FISICA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.proteccionFisica_id, DAL.SqlEnums.OperandEnum.Equal, proteccionfisica_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_PROTECCION_FISICA) As Entities.Tables.PRO_PROTECCION_FISICA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal proteccionfisica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal contencionfisica As System.Boolean, ByVal colchonaire As System.Boolean, ByVal barandascama As System.Boolean, ByVal cascoproteccion As System.Boolean, ByVal chiripasilla As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_PROTECCION_FISICA
            Try
                Dim NewItem As New Entities.Tables.PRO_PROTECCION_FISICA
                With NewItem
                    .PROTECCIONFISICA_ID = proteccionfisica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTENCIONFISICA = contencionfisica
                    .COLCHONAIRE = colchonaire
                    .BARANDASCAMA = barandascama
                    .CASCOPROTECCION = cascoproteccion
                    .CHIRIPASILLA = chiripasilla
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_PROTECCION_FISICA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal proteccionfisica_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal contencionfisica As System.Boolean, ByVal colchonaire As System.Boolean, ByVal barandascama As System.Boolean, ByVal cascoproteccion As System.Boolean, ByVal chiripasilla As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PROTECCION_FISICA
                With NewItem
                    .PROTECCIONFISICA_ID = proteccionfisica_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .CONTENCIONFISICA = contencionfisica
                    .COLCHONAIRE = colchonaire
                    .BARANDASCAMA = barandascama
                    .CASCOPROTECCION = cascoproteccion
                    .CHIRIPASILLA = chiripasilla
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_PROTECCION_FISICA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal proteccionfisica_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PROTECCION_FISICA
                With NewItem
                    .PROTECCIONFISICA_ID = proteccionfisica_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_PROTECCION_FISICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGAS
        Inherits DAL.Tables.PRORROGAS
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRORROGAS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal prorroga_id As System.Int32) As List(Of Entities.Tables.PRORROGAS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.prorroga_id, DAL.SqlEnums.OperandEnum.Equal, prorroga_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRORROGAS) As Entities.Tables.PRORROGAS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal prorroga_id As System.Int32, ByVal paciente_id As System.Int32, ByVal fechaprorroga As System.DateTime, ByVal usuario_id As System.Int32, ByVal antecedentes As System.String, ByVal estadoalingreso As System.String, ByVal estadoprorroga As System.Boolean) As Entities.Tables.PRORROGAS
            Try
                Dim NewItem As New Entities.Tables.PRORROGAS
                With NewItem
                    .PRORROGA_ID = prorroga_id
                    .PACIENTE_ID = paciente_id
                    .FECHAPRORROGA = fechaprorroga
                    .USUARIO_ID = usuario_id
                    .ANTECEDENTES = antecedentes
                    .ESTADOALINGRESO = estadoalingreso
                    .ESTADOPRORROGA = estadoprorroga

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRORROGAS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal prorroga_id As System.Int32, ByVal paciente_id As System.Int32, ByVal fechaprorroga As System.DateTime, ByVal usuario_id As System.Int32, ByVal antecedentes As System.String, ByVal estadoalingreso As System.String, ByVal estadoprorroga As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRORROGAS
                With NewItem
                    .PRORROGA_ID = prorroga_id
                    .PACIENTE_ID = paciente_id
                    .FECHAPRORROGA = fechaprorroga
                    .USUARIO_ID = usuario_id
                    .ANTECEDENTES = antecedentes
                    .ESTADOALINGRESO = estadoalingreso
                    .ESTADOPRORROGA = estadoprorroga

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRORROGAS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal prorroga_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRORROGAS
                With NewItem
                    .PRORROGA_ID = prorroga_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRORROGAS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGASITEM
        Inherits DAL.Tables.PRORROGASITEM
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRORROGASITEM)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id As System.Int32) As List(Of Entities.Tables.PRORROGASITEM)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id, DAL.SqlEnums.OperandEnum.Equal, id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRORROGASITEM) As Entities.Tables.PRORROGASITEM
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id As System.Int32, ByVal prorroga_id As System.Int32, ByVal evolucion As System.String, ByVal kinesiomuscular As System.Boolean, ByVal kinesiomusculartxt As System.String, ByVal fono As System.Boolean, ByVal fonotxt As System.String, ByVal terapiaocup As System.Boolean, ByVal terapiaocuptxt As System.String, ByVal psicologia As System.Boolean, ByVal psicologiatxt As System.String, ByVal nutricion As System.Boolean, ByVal nutriciontxt As System.String, ByVal musicoterapia As System.Boolean, ByVal musicoterapiatxt As System.String, ByVal fechamodificacion As System.DateTime, ByVal usuariomodifica As System.Int32, ByVal tipo As System.String) As Entities.Tables.PRORROGASITEM
            Try
                Dim NewItem As New Entities.Tables.PRORROGASITEM
                With NewItem
                    .ID = id
                    .PRORROGA_ID = prorroga_id
                    .EVOLUCION = evolucion
                    .KINESIOMUSCULAR = kinesiomuscular
                    .KINESIOMUSCULARTXT = kinesiomusculartxt
                    .FONO = fono
                    .FONOTXT = fonotxt
                    .TERAPIAOCUP = terapiaocup
                    .TERAPIAOCUPTXT = terapiaocuptxt
                    .PSICOLOGIA = psicologia
                    .PSICOLOGIATXT = psicologiatxt
                    .NUTRICION = nutricion
                    .NUTRICIONTXT = nutriciontxt
                    .MUSICOTERAPIA = musicoterapia
                    .MUSICOTERAPIATXT = musicoterapiatxt
                    .FECHAMODIFICACION = fechamodificacion
                    .USUARIOMODIFICA = usuariomodifica
                    .TIPO = tipo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRORROGASITEM) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id As System.Int32, ByVal prorroga_id As System.Int32, ByVal evolucion As System.String, ByVal kinesiomuscular As System.Boolean, ByVal kinesiomusculartxt As System.String, ByVal fono As System.Boolean, ByVal fonotxt As System.String, ByVal terapiaocup As System.Boolean, ByVal terapiaocuptxt As System.String, ByVal psicologia As System.Boolean, ByVal psicologiatxt As System.String, ByVal nutricion As System.Boolean, ByVal nutriciontxt As System.String, ByVal musicoterapia As System.Boolean, ByVal musicoterapiatxt As System.String, ByVal fechamodificacion As System.DateTime, ByVal usuariomodifica As System.Int32, ByVal tipo As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRORROGASITEM
                With NewItem
                    .ID = id
                    .PRORROGA_ID = prorroga_id
                    .EVOLUCION = evolucion
                    .KINESIOMUSCULAR = kinesiomuscular
                    .KINESIOMUSCULARTXT = kinesiomusculartxt
                    .FONO = fono
                    .FONOTXT = fonotxt
                    .TERAPIAOCUP = terapiaocup
                    .TERAPIAOCUPTXT = terapiaocuptxt
                    .PSICOLOGIA = psicologia
                    .PSICOLOGIATXT = psicologiatxt
                    .NUTRICION = nutricion
                    .NUTRICIONTXT = nutriciontxt
                    .MUSICOTERAPIA = musicoterapia
                    .MUSICOTERAPIATXT = musicoterapiatxt
                    .FECHAMODIFICACION = fechamodificacion
                    .USUARIOMODIFICA = usuariomodifica
                    .TIPO = tipo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRORROGASITEM) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRORROGASITEM
                With NewItem
                    .ID = id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRORROGASITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_HISTORIAL_SUMINISTRODEMEDICACION
        Inherits DAL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal suministrodemedicacion_id As System.Int32) As List(Of Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.suministroDeMedicacion_id, DAL.SqlEnums.OperandEnum.Equal, suministrodemedicacion_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION) As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal suministrodemedicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal fechainicio As System.DateTime, ByVal dosis As System.Decimal, ByVal presentacion_id As System.Int32, ByVal unidaddemedida_id As System.Int32, ByVal potencia As System.String, ByVal via_id As System.Int32, ByVal viatieneotro As System.Boolean, ByVal viaotro As System.String, ByVal diluyente_id As System.Int32, ByVal ml As System.Decimal, ByVal durante_id As System.Int32, ByVal periodo_id As System.Int32, ByVal lapsodetiempo As System.Boolean, ByVal lapsodetiempohasta As System.DateTime, ByVal horariodesuministro_id As System.Int32, ByVal horarioevento As System.String, ByVal evento As System.String, ByVal horariootro As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal hs_sh As System.Boolean) As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION
            Try
                Dim NewItem As New Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION
                With NewItem
                    .SUMINISTRODEMEDICACION_ID = suministrodemedicacion_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .FECHAINICIO = fechainicio
                    .DOSIS = dosis
                    .PRESENTACION_ID = presentacion_id
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .POTENCIA = potencia
                    .VIA_ID = via_id
                    .VIATIENEOTRO = viatieneotro
                    .VIAOTRO = viaotro
                    .DILUYENTE_ID = diluyente_id
                    .ML = ml
                    .DURANTE_ID = durante_id
                    .PERIODO_ID = periodo_id
                    .LAPSODETIEMPO = lapsodetiempo
                    .LAPSODETIEMPOHASTA = lapsodetiempohasta
                    .HORARIODESUMINISTRO_ID = horariodesuministro_id
                    .HORARIOEVENTO = horarioevento
                    .EVENTO = evento
                    .HORARIOOTRO = horariootro
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal suministrodemedicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal fechainicio As System.DateTime, ByVal dosis As System.Decimal, ByVal presentacion_id As System.Int32, ByVal unidaddemedida_id As System.Int32, ByVal potencia As System.String, ByVal via_id As System.Int32, ByVal viatieneotro As System.Boolean, ByVal viaotro As System.String, ByVal diluyente_id As System.Int32, ByVal ml As System.Decimal, ByVal durante_id As System.Int32, ByVal periodo_id As System.Int32, ByVal lapsodetiempo As System.Boolean, ByVal lapsodetiempohasta As System.DateTime, ByVal horariodesuministro_id As System.Int32, ByVal horarioevento As System.String, ByVal evento As System.String, ByVal horariootro As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal hs_sh As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION
                With NewItem
                    .SUMINISTRODEMEDICACION_ID = suministrodemedicacion_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .FECHAINICIO = fechainicio
                    .DOSIS = dosis
                    .PRESENTACION_ID = presentacion_id
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .POTENCIA = potencia
                    .VIA_ID = via_id
                    .VIATIENEOTRO = viatieneotro
                    .VIAOTRO = viaotro
                    .DILUYENTE_ID = diluyente_id
                    .ML = ml
                    .DURANTE_ID = durante_id
                    .PERIODO_ID = periodo_id
                    .LAPSODETIEMPO = lapsodetiempo
                    .LAPSODETIEMPOHASTA = lapsodetiempohasta
                    .HORARIODESUMINISTRO_ID = horariodesuministro_id
                    .HORARIOEVENTO = horarioevento
                    .EVENTO = evento
                    .HORARIOOTRO = horariootro
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal suministrodemedicacion_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION
                With NewItem
                    .SUMINISTRODEMEDICACION_ID = suministrodemedicacion_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_SUMINISTRODEMEDICACION
        Inherits DAL.Tables.MED_SUMINISTRODEMEDICACION
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_SUMINISTRODEMEDICACION)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal suministrodemedicacion_id As System.Int32) As List(Of Entities.Tables.MED_SUMINISTRODEMEDICACION)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.suministroDeMedicacion_id, DAL.SqlEnums.OperandEnum.Equal, suministrodemedicacion_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_SUMINISTRODEMEDICACION) As Entities.Tables.MED_SUMINISTRODEMEDICACION
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal suministrodemedicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal fechainicio As System.DateTime, ByVal dosis As System.Decimal, ByVal presentacion_id As System.Int32, ByVal unidaddemedida_id As System.Decimal, ByVal potencia As System.String, ByVal via_id As System.Int32, ByVal viatieneotro As System.Boolean, ByVal viaotro As System.String, ByVal diluyente_id As System.Int32, ByVal ml As System.Decimal, ByVal durante_id As System.Int32, ByVal periodo_id As System.Int32, ByVal lapsodetiempo As System.Boolean, ByVal lapsodetiempohasta As System.DateTime, ByVal horariodesuministro_id As System.Int32, ByVal horarioevento As System.String, ByVal evento As System.String, ByVal horariootro As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal hs_sh As System.Boolean) As Entities.Tables.MED_SUMINISTRODEMEDICACION
            Try
                Dim NewItem As New Entities.Tables.MED_SUMINISTRODEMEDICACION
                With NewItem
                    .SUMINISTRODEMEDICACION_ID = suministrodemedicacion_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .FECHAINICIO = fechainicio
                    .DOSIS = dosis
                    .PRESENTACION_ID = presentacion_id
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .POTENCIA = potencia
                    .VIA_ID = via_id
                    .VIATIENEOTRO = viatieneotro
                    .VIAOTRO = viaotro
                    .DILUYENTE_ID = diluyente_id
                    .ML = ml
                    .DURANTE_ID = durante_id
                    .PERIODO_ID = periodo_id
                    .LAPSODETIEMPO = lapsodetiempo
                    .LAPSODETIEMPOHASTA = lapsodetiempohasta
                    .HORARIODESUMINISTRO_ID = horariodesuministro_id
                    .HORARIOEVENTO = horarioevento
                    .EVENTO = evento
                    .HORARIOOTRO = horariootro
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_SUMINISTRODEMEDICACION) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal suministrodemedicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal fechainicio As System.DateTime, ByVal dosis As System.Decimal, ByVal presentacion_id As System.Int32, ByVal unidaddemedida_id As System.Decimal, ByVal potencia As System.String, ByVal via_id As System.Int32, ByVal viatieneotro As System.Boolean, ByVal viaotro As System.String, ByVal diluyente_id As System.Int32, ByVal ml As System.Decimal, ByVal durante_id As System.Int32, ByVal periodo_id As System.Int32, ByVal lapsodetiempo As System.Boolean, ByVal lapsodetiempohasta As System.DateTime, ByVal horariodesuministro_id As System.Int32, ByVal horarioevento As System.String, ByVal evento As System.String, ByVal horariootro As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal hs_sh As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_SUMINISTRODEMEDICACION
                With NewItem
                    .SUMINISTRODEMEDICACION_ID = suministrodemedicacion_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .FECHAINICIO = fechainicio
                    .DOSIS = dosis
                    .PRESENTACION_ID = presentacion_id
                    .UNIDADDEMEDIDA_ID = unidaddemedida_id
                    .POTENCIA = potencia
                    .VIA_ID = via_id
                    .VIATIENEOTRO = viatieneotro
                    .VIAOTRO = viaotro
                    .DILUYENTE_ID = diluyente_id
                    .ML = ml
                    .DURANTE_ID = durante_id
                    .PERIODO_ID = periodo_id
                    .LAPSODETIEMPO = lapsodetiempo
                    .LAPSODETIEMPOHASTA = lapsodetiempohasta
                    .HORARIODESUMINISTRO_ID = horariodesuministro_id
                    .HORARIOEVENTO = horarioevento
                    .EVENTO = evento
                    .HORARIOOTRO = horariootro
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_SUMINISTRODEMEDICACION) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal suministrodemedicacion_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_SUMINISTRODEMEDICACION
                With NewItem
                    .SUMINISTRODEMEDICACION_ID = suministrodemedicacion_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_SUMINISTRODEMEDICACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class HC
        Inherits DAL.Tables.HC
        Public Overloads Function ItemList() As List(Of Entities.Tables.HC)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal hc_id As System.Int32) As List(Of Entities.Tables.HC)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.HC_id, DAL.SqlEnums.OperandEnum.Equal, hc_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.HC) As Entities.Tables.HC
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal hc_id As System.Int32, ByVal paciente_id As System.Int32, ByVal tipo As System.String, ByVal fecha As System.DateTime, ByVal usuario_id As System.Int32, ByVal texto As System.String) As Entities.Tables.HC
            Try
                Dim NewItem As New Entities.Tables.HC
                With NewItem
                    .HC_ID = hc_id
                    .PACIENTE_ID = paciente_id
                    .TIPO = tipo
                    .FECHA = fecha
                    .USUARIO_ID = usuario_id
                    .TEXTO = texto

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.HC) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal hc_id As System.Int32, ByVal paciente_id As System.Int32, ByVal tipo As System.String, ByVal fecha As System.DateTime, ByVal usuario_id As System.Int32, ByVal texto As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.HC
                With NewItem
                    .HC_ID = hc_id
                    .PACIENTE_ID = paciente_id
                    .TIPO = tipo
                    .FECHA = fecha
                    .USUARIO_ID = usuario_id
                    .TEXTO = texto

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.HC) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal hc_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.HC
                With NewItem
                    .HC_ID = hc_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.HC)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class SECTORES
        Inherits DAL.Tables.SECTORES
        Public Overloads Function ItemList() As List(Of Entities.Tables.SECTORES)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal sector_id As System.Int32) As List(Of Entities.Tables.SECTORES)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.sector_id, DAL.SqlEnums.OperandEnum.Equal, sector_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.SECTORES) As Entities.Tables.SECTORES
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal sector_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.SECTORES
            Try
                Dim NewItem As New Entities.Tables.SECTORES
                With NewItem
                    .SECTOR_ID = sector_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.SECTORES) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal sector_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.SECTORES
                With NewItem
                    .SECTOR_ID = sector_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.SECTORES) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal sector_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.SECTORES
                With NewItem
                    .SECTOR_ID = sector_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.SECTORES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class ENFERMERIA
        Inherits DAL.Tables.ENFERMERIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.ENFERMERIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal enfermeria_id As System.Int32) As List(Of Entities.Tables.ENFERMERIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.enfermeria_id, DAL.SqlEnums.OperandEnum.Equal, enfermeria_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.ENFERMERIA) As Entities.Tables.ENFERMERIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal enfermeria_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.Int32, ByVal dosis As System.Int32, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.String, ByVal hs_sh As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime) As Entities.Tables.ENFERMERIA
            Try
                Dim NewItem As New Entities.Tables.ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .DOSIS = dosis
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.ENFERMERIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal enfermeria_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.Int32, ByVal dosis As System.Int32, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.String, ByVal hs_sh As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .DOSIS = dosis
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.ENFERMERIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal enfermeria_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.ENFERMERIA
                With NewItem
                    .ENFERMERIA_ID = enfermeria_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.ENFERMERIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class FARMACIA
        Inherits DAL.Tables.FARMACIA
        Public Overloads Function ItemList() As List(Of Entities.Tables.FARMACIA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal farmacia_id As System.Int32) As List(Of Entities.Tables.FARMACIA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.farmacia_id, DAL.SqlEnums.OperandEnum.Equal, farmacia_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.FARMACIA) As Entities.Tables.FARMACIA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal farmacia_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal dosis As System.Decimal, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal hs_sh As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime) As Entities.Tables.FARMACIA
            Try
                Dim NewItem As New Entities.Tables.FARMACIA
                With NewItem
                    .FARMACIA_ID = farmacia_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .DOSIS = dosis
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.FARMACIA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal farmacia_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal dosis As System.Decimal, ByVal hs_08 As System.Boolean, ByVal hs_09 As System.Boolean, ByVal hs_10 As System.Boolean, ByVal hs_11 As System.Boolean, ByVal hs_12 As System.Boolean, ByVal hs_13 As System.Boolean, ByVal hs_14 As System.Boolean, ByVal hs_15 As System.Boolean, ByVal hs_16 As System.Boolean, ByVal hs_17 As System.Boolean, ByVal hs_18 As System.Boolean, ByVal hs_19 As System.Boolean, ByVal hs_20 As System.Boolean, ByVal hs_21 As System.Boolean, ByVal hs_22 As System.Boolean, ByVal hs_23 As System.Boolean, ByVal hs_24 As System.Boolean, ByVal hs_01 As System.Boolean, ByVal hs_02 As System.Boolean, ByVal hs_03 As System.Boolean, ByVal hs_04 As System.Boolean, ByVal hs_05 As System.Boolean, ByVal hs_06 As System.Boolean, ByVal hs_07 As System.Boolean, ByVal hs_sh As System.Boolean, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.FARMACIA
                With NewItem
                    .FARMACIA_ID = farmacia_id
                    .PACIENTE_ID = paciente_id
                    .MEDICAMENTO_ID = medicamento_id
                    .DOSIS = dosis
                    .HS_08 = hs_08
                    .HS_09 = hs_09
                    .HS_10 = hs_10
                    .HS_11 = hs_11
                    .HS_12 = hs_12
                    .HS_13 = hs_13
                    .HS_14 = hs_14
                    .HS_15 = hs_15
                    .HS_16 = hs_16
                    .HS_17 = hs_17
                    .HS_18 = hs_18
                    .HS_19 = hs_19
                    .HS_20 = hs_20
                    .HS_21 = hs_21
                    .HS_22 = hs_22
                    .HS_23 = hs_23
                    .HS_24 = hs_24
                    .HS_01 = hs_01
                    .HS_02 = hs_02
                    .HS_03 = hs_03
                    .HS_04 = hs_04
                    .HS_05 = hs_05
                    .HS_06 = hs_06
                    .HS_07 = hs_07
                    .HS_SH = hs_sh
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.FARMACIA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal farmacia_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.FARMACIA
                With NewItem
                    .FARMACIA_ID = farmacia_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.FARMACIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_PROCEDIMIENTODESCARTABLE
        Inherits DAL.Tables.PRO_PROCEDIMIENTODESCARTABLE
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal procedimiento_id As System.Int32, ByVal descartable_id As System.String) As List(Of Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.procedimiento_id, DAL.SqlEnums.OperandEnum.Equal, procedimiento_id)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.descartable_id, DAL.SqlEnums.OperandEnum.Equal, descartable_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE) As Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal procedimiento_id As System.Int32, ByVal descartable_id As System.String, ByVal imprimible As System.Boolean, ByVal cantidad As System.Decimal) As Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE
            Try
                Dim NewItem As New Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .DESCARTABLE_ID = descartable_id
                    .IMPRIMIBLE = imprimible
                    .CANTIDAD = cantidad

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal procedimiento_id As System.Int32, ByVal descartable_id As System.String, ByVal imprimible As System.Boolean, ByVal cantidad As System.Decimal) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .DESCARTABLE_ID = descartable_id
                    .IMPRIMIBLE = imprimible
                    .CANTIDAD = cantidad

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal procedimiento_id As System.Int32, ByVal descartable_id As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .DESCARTABLE_ID = descartable_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_PROCEDIMIENTO
        Inherits DAL.Tables.PRO_PROCEDIMIENTO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_PROCEDIMIENTO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal procedimiento_id As System.Int32) As List(Of Entities.Tables.PRO_PROCEDIMIENTO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.procedimiento_id, DAL.SqlEnums.OperandEnum.Equal, procedimiento_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_PROCEDIMIENTO) As Entities.Tables.PRO_PROCEDIMIENTO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal procedimiento_id As System.Int32, ByVal descripcion As System.String, ByVal tipoprocedimiento_id As System.Int32, ByVal inactivo As System.Boolean) As Entities.Tables.PRO_PROCEDIMIENTO
            Try
                Dim NewItem As New Entities.Tables.PRO_PROCEDIMIENTO
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .DESCRIPCION = descripcion
                    .TIPOPROCEDIMIENTO_ID = tipoprocedimiento_id
                    .INACTIVO = inactivo

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_PROCEDIMIENTO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal procedimiento_id As System.Int32, ByVal descripcion As System.String, ByVal tipoprocedimiento_id As System.Int32, ByVal inactivo As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PROCEDIMIENTO
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .DESCRIPCION = descripcion
                    .TIPOPROCEDIMIENTO_ID = tipoprocedimiento_id
                    .INACTIVO = inactivo

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_PROCEDIMIENTO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal procedimiento_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PROCEDIMIENTO
                With NewItem
                    .PROCEDIMIENTO_ID = procedimiento_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_PROCEDIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_FRASCO
        Inherits DAL.Tables.PRO_FRASCO
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_FRASCO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal frasco_id As System.Int32) As List(Of Entities.Tables.PRO_FRASCO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.frasco_id, DAL.SqlEnums.OperandEnum.Equal, frasco_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_FRASCO) As Entities.Tables.PRO_FRASCO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal frasco_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.PRO_FRASCO
            Try
                Dim NewItem As New Entities.Tables.PRO_FRASCO
                With NewItem
                    .FRASCO_ID = frasco_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_FRASCO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal frasco_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_FRASCO
                With NewItem
                    .FRASCO_ID = frasco_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_FRASCO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal frasco_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_FRASCO
                With NewItem
                    .FRASCO_ID = frasco_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_FRASCO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GOTA_HORA
        Inherits DAL.Tables.PRO_GOTA_HORA
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_GOTA_HORA)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal gotahora_id As System.Int32) As List(Of Entities.Tables.PRO_GOTA_HORA)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.gotaHora_id, DAL.SqlEnums.OperandEnum.Equal, gotahora_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_GOTA_HORA) As Entities.Tables.PRO_GOTA_HORA
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal gotahora_id As System.Int32, ByVal descripcion As System.String) As Entities.Tables.PRO_GOTA_HORA
            Try
                Dim NewItem As New Entities.Tables.PRO_GOTA_HORA
                With NewItem
                    .GOTAHORA_ID = gotahora_id
                    .DESCRIPCION = descripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_GOTA_HORA) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal gotahora_id As System.Int32, ByVal descripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_GOTA_HORA
                With NewItem
                    .GOTAHORA_ID = gotahora_id
                    .DESCRIPCION = descripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_GOTA_HORA) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal gotahora_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_GOTA_HORA
                With NewItem
                    .GOTAHORA_ID = gotahora_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_GOTA_HORA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_HISTORIAL_PHP
        Inherits DAL.Tables.PRO_HISTORIAL_PHP
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_HISTORIAL_PHP)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal php_id As System.Int32) As List(Of Entities.Tables.PRO_HISTORIAL_PHP)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.php_id, DAL.SqlEnums.OperandEnum.Equal, php_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_PHP) As Entities.Tables.PRO_HISTORIAL_PHP
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal php_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal ml_100 As System.Boolean, ByVal ml_250 As System.Boolean, ByVal ml_500 As System.Boolean, ByVal ml_1000 As System.Boolean, ByVal bic As System.Boolean, ByVal gotahora_id As System.Int32, ByVal mlhora As System.Int32, ByVal mldia As System.Int32, ByVal frascouno_id As System.Int32, ByVal aditivouno_id As System.String, ByVal frascodos_id As System.Int32, ByVal aditivodos_id As System.String, ByVal frascotres_id As System.Int32, ByVal aditivotres_id As System.String, ByVal frascocuatro_id As System.Int32, ByVal aditivocuatro_id As System.String, ByVal frascocinco_id As System.Int32, ByVal aditivocinco_id As System.String, ByVal frascoseis_id As System.Int32, ByVal aditivoseis_id As System.String, ByVal frascosiete_id As System.Int32, ByVal aditivosiete_id As System.String, ByVal frascoocho_id As System.Int32, ByVal aditivoocho_id As System.String, ByVal frasconueve_id As System.Int32, ByVal aditivonueve_id As System.String, ByVal frascodiez_id As System.Int32, ByVal aditivodiez_id As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_HISTORIAL_PHP
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_PHP
                With NewItem
                    .PHP_ID = php_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ML_100 = ml_100
                    .ML_250 = ml_250
                    .ML_500 = ml_500
                    .ML_1000 = ml_1000
                    .BIC = bic
                    .GOTAHORA_ID = gotahora_id
                    .MLHORA = mlhora
                    .MLDIA = mldia
                    .FRASCOUNO_ID = frascouno_id
                    .ADITIVOUNO_ID = aditivouno_id
                    .FRASCODOS_ID = frascodos_id
                    .ADITIVODOS_ID = aditivodos_id
                    .FRASCOTRES_ID = frascotres_id
                    .ADITIVOTRES_ID = aditivotres_id
                    .FRASCOCUATRO_ID = frascocuatro_id
                    .ADITIVOCUATRO_ID = aditivocuatro_id
                    .FRASCOCINCO_ID = frascocinco_id
                    .ADITIVOCINCO_ID = aditivocinco_id
                    .FRASCOSEIS_ID = frascoseis_id
                    .ADITIVOSEIS_ID = aditivoseis_id
                    .FRASCOSIETE_ID = frascosiete_id
                    .ADITIVOSIETE_ID = aditivosiete_id
                    .FRASCOOCHO_ID = frascoocho_id
                    .ADITIVOOCHO_ID = aditivoocho_id
                    .FRASCONUEVE_ID = frasconueve_id
                    .ADITIVONUEVE_ID = aditivonueve_id
                    .FRASCODIEZ_ID = frascodiez_id
                    .ADITIVODIEZ_ID = aditivodiez_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_PHP) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal php_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal ml_100 As System.Boolean, ByVal ml_250 As System.Boolean, ByVal ml_500 As System.Boolean, ByVal ml_1000 As System.Boolean, ByVal bic As System.Boolean, ByVal gotahora_id As System.Int32, ByVal mlhora As System.Int32, ByVal mldia As System.Int32, ByVal frascouno_id As System.Int32, ByVal aditivouno_id As System.String, ByVal frascodos_id As System.Int32, ByVal aditivodos_id As System.String, ByVal frascotres_id As System.Int32, ByVal aditivotres_id As System.String, ByVal frascocuatro_id As System.Int32, ByVal aditivocuatro_id As System.String, ByVal frascocinco_id As System.Int32, ByVal aditivocinco_id As System.String, ByVal frascoseis_id As System.Int32, ByVal aditivoseis_id As System.String, ByVal frascosiete_id As System.Int32, ByVal aditivosiete_id As System.String, ByVal frascoocho_id As System.Int32, ByVal aditivoocho_id As System.String, ByVal frasconueve_id As System.Int32, ByVal aditivonueve_id As System.String, ByVal frascodiez_id As System.Int32, ByVal aditivodiez_id As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_PHP
                With NewItem
                    .PHP_ID = php_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ML_100 = ml_100
                    .ML_250 = ml_250
                    .ML_500 = ml_500
                    .ML_1000 = ml_1000
                    .BIC = bic
                    .GOTAHORA_ID = gotahora_id
                    .MLHORA = mlhora
                    .MLDIA = mldia
                    .FRASCOUNO_ID = frascouno_id
                    .ADITIVOUNO_ID = aditivouno_id
                    .FRASCODOS_ID = frascodos_id
                    .ADITIVODOS_ID = aditivodos_id
                    .FRASCOTRES_ID = frascotres_id
                    .ADITIVOTRES_ID = aditivotres_id
                    .FRASCOCUATRO_ID = frascocuatro_id
                    .ADITIVOCUATRO_ID = aditivocuatro_id
                    .FRASCOCINCO_ID = frascocinco_id
                    .ADITIVOCINCO_ID = aditivocinco_id
                    .FRASCOSEIS_ID = frascoseis_id
                    .ADITIVOSEIS_ID = aditivoseis_id
                    .FRASCOSIETE_ID = frascosiete_id
                    .ADITIVOSIETE_ID = aditivosiete_id
                    .FRASCOOCHO_ID = frascoocho_id
                    .ADITIVOOCHO_ID = aditivoocho_id
                    .FRASCONUEVE_ID = frasconueve_id
                    .ADITIVONUEVE_ID = aditivonueve_id
                    .FRASCODIEZ_ID = frascodiez_id
                    .ADITIVODIEZ_ID = aditivodiez_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_HISTORIAL_PHP) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal php_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_HISTORIAL_PHP
                With NewItem
                    .PHP_ID = php_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_HISTORIAL_PHP)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_PHP
        Inherits DAL.Tables.PRO_PHP
        Public Overloads Function ItemList() As List(Of Entities.Tables.PRO_PHP)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal php_id As System.Int32) As List(Of Entities.Tables.PRO_PHP)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.php_id, DAL.SqlEnums.OperandEnum.Equal, php_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.PRO_PHP) As Entities.Tables.PRO_PHP
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal php_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal ml_100 As System.Boolean, ByVal ml_250 As System.Boolean, ByVal ml_500 As System.Boolean, ByVal ml_1000 As System.Boolean, ByVal bic As System.Boolean, ByVal gotahora_id As System.Int32, ByVal mlhora As System.Int32, ByVal mldia As System.Int32, ByVal frascouno_id As System.Int32, ByVal aditivouno_id As System.String, ByVal frascodos_id As System.Int32, ByVal aditivodos_id As System.String, ByVal frascotres_id As System.Int32, ByVal aditivotres_id As System.String, ByVal frascocuatro_id As System.Int32, ByVal aditivocuatro_id As System.String, ByVal frascocinco_id As System.Int32, ByVal aditivocinco_id As System.String, ByVal frascoseis_id As System.Int32, ByVal aditivoseis_id As System.String, ByVal frascosiete_id As System.Int32, ByVal aditivosiete_id As System.String, ByVal frascoocho_id As System.Int32, ByVal aditivoocho_id As System.String, ByVal frasconueve_id As System.Int32, ByVal aditivonueve_id As System.String, ByVal frascodiez_id As System.Int32, ByVal aditivodiez_id As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Entities.Tables.PRO_PHP
            Try
                Dim NewItem As New Entities.Tables.PRO_PHP
                With NewItem
                    .PHP_ID = php_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ML_100 = ml_100
                    .ML_250 = ml_250
                    .ML_500 = ml_500
                    .ML_1000 = ml_1000
                    .BIC = bic
                    .GOTAHORA_ID = gotahora_id
                    .MLHORA = mlhora
                    .MLDIA = mldia
                    .FRASCOUNO_ID = frascouno_id
                    .ADITIVOUNO_ID = aditivouno_id
                    .FRASCODOS_ID = frascodos_id
                    .ADITIVODOS_ID = aditivodos_id
                    .FRASCOTRES_ID = frascotres_id
                    .ADITIVOTRES_ID = aditivotres_id
                    .FRASCOCUATRO_ID = frascocuatro_id
                    .ADITIVOCUATRO_ID = aditivocuatro_id
                    .FRASCOCINCO_ID = frascocinco_id
                    .ADITIVOCINCO_ID = aditivocinco_id
                    .FRASCOSEIS_ID = frascoseis_id
                    .ADITIVOSEIS_ID = aditivoseis_id
                    .FRASCOSIETE_ID = frascosiete_id
                    .ADITIVOSIETE_ID = aditivosiete_id
                    .FRASCOOCHO_ID = frascoocho_id
                    .ADITIVOOCHO_ID = aditivoocho_id
                    .FRASCONUEVE_ID = frasconueve_id
                    .ADITIVONUEVE_ID = aditivonueve_id
                    .FRASCODIEZ_ID = frascodiez_id
                    .ADITIVODIEZ_ID = aditivodiez_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.PRO_PHP) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal php_id As System.Int32, ByVal paciente_id As System.Int32, ByVal procedimiento_id As System.Int32, ByVal ml_100 As System.Boolean, ByVal ml_250 As System.Boolean, ByVal ml_500 As System.Boolean, ByVal ml_1000 As System.Boolean, ByVal bic As System.Boolean, ByVal gotahora_id As System.Int32, ByVal mlhora As System.Int32, ByVal mldia As System.Int32, ByVal frascouno_id As System.Int32, ByVal aditivouno_id As System.String, ByVal frascodos_id As System.Int32, ByVal aditivodos_id As System.String, ByVal frascotres_id As System.Int32, ByVal aditivotres_id As System.String, ByVal frascocuatro_id As System.Int32, ByVal aditivocuatro_id As System.String, ByVal frascocinco_id As System.Int32, ByVal aditivocinco_id As System.String, ByVal frascoseis_id As System.Int32, ByVal aditivoseis_id As System.String, ByVal frascosiete_id As System.Int32, ByVal aditivosiete_id As System.String, ByVal frascoocho_id As System.Int32, ByVal aditivoocho_id As System.String, ByVal frasconueve_id As System.Int32, ByVal aditivonueve_id As System.String, ByVal frascodiez_id As System.Int32, ByVal aditivodiez_id As System.String, ByVal observacion As System.String, ByVal usuario_id As System.Int32, ByVal fechaaltasistema As System.DateTime, ByVal fechamodificacion As System.DateTime, ByVal fechabaja As System.DateTime, ByVal motivobaja As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PHP
                With NewItem
                    .PHP_ID = php_id
                    .PACIENTE_ID = paciente_id
                    .PROCEDIMIENTO_ID = procedimiento_id
                    .ML_100 = ml_100
                    .ML_250 = ml_250
                    .ML_500 = ml_500
                    .ML_1000 = ml_1000
                    .BIC = bic
                    .GOTAHORA_ID = gotahora_id
                    .MLHORA = mlhora
                    .MLDIA = mldia
                    .FRASCOUNO_ID = frascouno_id
                    .ADITIVOUNO_ID = aditivouno_id
                    .FRASCODOS_ID = frascodos_id
                    .ADITIVODOS_ID = aditivodos_id
                    .FRASCOTRES_ID = frascotres_id
                    .ADITIVOTRES_ID = aditivotres_id
                    .FRASCOCUATRO_ID = frascocuatro_id
                    .ADITIVOCUATRO_ID = aditivocuatro_id
                    .FRASCOCINCO_ID = frascocinco_id
                    .ADITIVOCINCO_ID = aditivocinco_id
                    .FRASCOSEIS_ID = frascoseis_id
                    .ADITIVOSEIS_ID = aditivoseis_id
                    .FRASCOSIETE_ID = frascosiete_id
                    .ADITIVOSIETE_ID = aditivosiete_id
                    .FRASCOOCHO_ID = frascoocho_id
                    .ADITIVOOCHO_ID = aditivoocho_id
                    .FRASCONUEVE_ID = frasconueve_id
                    .ADITIVONUEVE_ID = aditivonueve_id
                    .FRASCODIEZ_ID = frascodiez_id
                    .ADITIVODIEZ_ID = aditivodiez_id
                    .OBSERVACION = observacion
                    .USUARIO_ID = usuario_id
                    .FECHAALTASISTEMA = fechaaltasistema
                    .FECHAMODIFICACION = fechamodificacion
                    .FECHABAJA = fechabaja
                    .MOTIVOBAJA = motivobaja

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.PRO_PHP) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal php_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.PRO_PHP
                With NewItem
                    .PHP_ID = php_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.PRO_PHP)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_DIAGNOSTICO
        Inherits DAL.Tables.MED_DIAGNOSTICO
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_DIAGNOSTICO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id10 As System.String) As List(Of Entities.Tables.MED_DIAGNOSTICO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id10, DAL.SqlEnums.OperandEnum.Equal, id10)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_DIAGNOSTICO) As Entities.Tables.MED_DIAGNOSTICO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id10 As System.String, ByVal dec10 As System.String, ByVal grp10 As System.String) As Entities.Tables.MED_DIAGNOSTICO
            Try
                Dim NewItem As New Entities.Tables.MED_DIAGNOSTICO
                With NewItem
                    .ID10 = id10
                    .DEC10 = dec10
                    .GRP10 = grp10

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_DIAGNOSTICO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id10 As System.String, ByVal dec10 As System.String, ByVal grp10 As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_DIAGNOSTICO
                With NewItem
                    .ID10 = id10
                    .DEC10 = dec10
                    .GRP10 = grp10

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_DIAGNOSTICO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id10 As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_DIAGNOSTICO
                With NewItem
                    .ID10 = id10

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_DIAGNOSTICO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_DIAGNOSTICO_PACIENTE
        Inherits DAL.Tables.MED_DIAGNOSTICO_PACIENTE
        Public Overloads Function ItemList() As List(Of Entities.Tables.MED_DIAGNOSTICO_PACIENTE)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal diagnostico_id As System.Int32) As List(Of Entities.Tables.MED_DIAGNOSTICO_PACIENTE)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.diagnostico_id, DAL.SqlEnums.OperandEnum.Equal, diagnostico_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.MED_DIAGNOSTICO_PACIENTE) As Entities.Tables.MED_DIAGNOSTICO_PACIENTE
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal diagnostico_id As System.Int32, ByVal paciente_id As System.Int32, ByVal principalcapituloingreso_id As System.String, ByVal principalrubroingreso_id As System.String, ByVal principalsubrubroingreso_id As System.String, ByVal principalitemingreso_id As System.String, ByVal secundariocapituloingreso_id As System.String, ByVal secundariorubroingreso_id As System.String, ByVal secundariosubrubroingreso_id As System.String, ByVal secundarioitemingreso_id As System.String, ByVal terciariocapituloingreso_id As System.String, ByVal terciariorubroingreso_id As System.String, ByVal terciariosubrubroingreso_id As System.String, ByVal terciarioitemingreso_id As System.String, ByVal principalcapituloegreso_id As System.String, ByVal principalrubroegreso_id As System.String, ByVal principalsubrubroegreso_id As System.String, ByVal principalitemegreso_id As System.String, ByVal secundariocapituloegreso_id As System.String, ByVal secundariorubroegreso_id As System.String, ByVal secundariosubrubroegreso_id As System.String, ByVal secundarioitemegreso_id As System.String, ByVal terciariocapituloegreso_id As System.String, ByVal terciariorubroegreso_id As System.String, ByVal terciariosubrubroegreso_id As System.String, ByVal terciarioitemegreso_id As System.String, ByVal usuario_id As System.Int32, ByVal fechaalta As System.DateTime, ByVal fechamodificacion As System.DateTime) As Entities.Tables.MED_DIAGNOSTICO_PACIENTE
            Try
                Dim NewItem As New Entities.Tables.MED_DIAGNOSTICO_PACIENTE
                With NewItem
                    .DIAGNOSTICO_ID = diagnostico_id
                    .PACIENTE_ID = paciente_id
                    .PRINCIPALCAPITULOINGRESO_ID = principalcapituloingreso_id
                    .PRINCIPALRUBROINGRESO_ID = principalrubroingreso_id
                    .PRINCIPALSUBRUBROINGRESO_ID = principalsubrubroingreso_id
                    .PRINCIPALITEMINGRESO_ID = principalitemingreso_id
                    .SECUNDARIOCAPITULOINGRESO_ID = secundariocapituloingreso_id
                    .SECUNDARIORUBROINGRESO_ID = secundariorubroingreso_id
                    .SECUNDARIOSUBRUBROINGRESO_ID = secundariosubrubroingreso_id
                    .SECUNDARIOITEMINGRESO_ID = secundarioitemingreso_id
                    .TERCIARIOCAPITULOINGRESO_ID = terciariocapituloingreso_id
                    .TERCIARIORUBROINGRESO_ID = terciariorubroingreso_id
                    .TERCIARIOSUBRUBROINGRESO_ID = terciariosubrubroingreso_id
                    .TERCIARIOITEMINGRESO_ID = terciarioitemingreso_id
                    .PRINCIPALCAPITULOEGRESO_ID = principalcapituloegreso_id
                    .PRINCIPALRUBROEGRESO_ID = principalrubroegreso_id
                    .PRINCIPALSUBRUBROEGRESO_ID = principalsubrubroegreso_id
                    .PRINCIPALITEMEGRESO_ID = principalitemegreso_id
                    .SECUNDARIOCAPITULOEGRESO_ID = secundariocapituloegreso_id
                    .SECUNDARIORUBROEGRESO_ID = secundariorubroegreso_id
                    .SECUNDARIOSUBRUBROEGRESO_ID = secundariosubrubroegreso_id
                    .SECUNDARIOITEMEGRESO_ID = secundarioitemegreso_id
                    .TERCIARIOCAPITULOEGRESO_ID = terciariocapituloegreso_id
                    .TERCIARIORUBROEGRESO_ID = terciariorubroegreso_id
                    .TERCIARIOSUBRUBROEGRESO_ID = terciariosubrubroegreso_id
                    .TERCIARIOITEMEGRESO_ID = terciarioitemegreso_id
                    .USUARIO_ID = usuario_id
                    .FECHAALTA = fechaalta
                    .FECHAMODIFICACION = fechamodificacion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.MED_DIAGNOSTICO_PACIENTE) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal diagnostico_id As System.Int32, ByVal paciente_id As System.Int32, ByVal principalcapituloingreso_id As System.String, ByVal principalrubroingreso_id As System.String, ByVal principalsubrubroingreso_id As System.String, ByVal principalitemingreso_id As System.String, ByVal secundariocapituloingreso_id As System.String, ByVal secundariorubroingreso_id As System.String, ByVal secundariosubrubroingreso_id As System.String, ByVal secundarioitemingreso_id As System.String, ByVal terciariocapituloingreso_id As System.String, ByVal terciariorubroingreso_id As System.String, ByVal terciariosubrubroingreso_id As System.String, ByVal terciarioitemingreso_id As System.String, ByVal principalcapituloegreso_id As System.String, ByVal principalrubroegreso_id As System.String, ByVal principalsubrubroegreso_id As System.String, ByVal principalitemegreso_id As System.String, ByVal secundariocapituloegreso_id As System.String, ByVal secundariorubroegreso_id As System.String, ByVal secundariosubrubroegreso_id As System.String, ByVal secundarioitemegreso_id As System.String, ByVal terciariocapituloegreso_id As System.String, ByVal terciariorubroegreso_id As System.String, ByVal terciariosubrubroegreso_id As System.String, ByVal terciarioitemegreso_id As System.String, ByVal usuario_id As System.Int32, ByVal fechaalta As System.DateTime, ByVal fechamodificacion As System.DateTime) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_DIAGNOSTICO_PACIENTE
                With NewItem
                    .DIAGNOSTICO_ID = diagnostico_id
                    .PACIENTE_ID = paciente_id
                    .PRINCIPALCAPITULOINGRESO_ID = principalcapituloingreso_id
                    .PRINCIPALRUBROINGRESO_ID = principalrubroingreso_id
                    .PRINCIPALSUBRUBROINGRESO_ID = principalsubrubroingreso_id
                    .PRINCIPALITEMINGRESO_ID = principalitemingreso_id
                    .SECUNDARIOCAPITULOINGRESO_ID = secundariocapituloingreso_id
                    .SECUNDARIORUBROINGRESO_ID = secundariorubroingreso_id
                    .SECUNDARIOSUBRUBROINGRESO_ID = secundariosubrubroingreso_id
                    .SECUNDARIOITEMINGRESO_ID = secundarioitemingreso_id
                    .TERCIARIOCAPITULOINGRESO_ID = terciariocapituloingreso_id
                    .TERCIARIORUBROINGRESO_ID = terciariorubroingreso_id
                    .TERCIARIOSUBRUBROINGRESO_ID = terciariosubrubroingreso_id
                    .TERCIARIOITEMINGRESO_ID = terciarioitemingreso_id
                    .PRINCIPALCAPITULOEGRESO_ID = principalcapituloegreso_id
                    .PRINCIPALRUBROEGRESO_ID = principalrubroegreso_id
                    .PRINCIPALSUBRUBROEGRESO_ID = principalsubrubroegreso_id
                    .PRINCIPALITEMEGRESO_ID = principalitemegreso_id
                    .SECUNDARIOCAPITULOEGRESO_ID = secundariocapituloegreso_id
                    .SECUNDARIORUBROEGRESO_ID = secundariorubroegreso_id
                    .SECUNDARIOSUBRUBROEGRESO_ID = secundariosubrubroegreso_id
                    .SECUNDARIOITEMEGRESO_ID = secundarioitemegreso_id
                    .TERCIARIOCAPITULOEGRESO_ID = terciariocapituloegreso_id
                    .TERCIARIORUBROEGRESO_ID = terciariorubroegreso_id
                    .TERCIARIOSUBRUBROEGRESO_ID = terciariosubrubroegreso_id
                    .TERCIARIOITEMEGRESO_ID = terciarioitemegreso_id
                    .USUARIO_ID = usuario_id
                    .FECHAALTA = fechaalta
                    .FECHAMODIFICACION = fechamodificacion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.MED_DIAGNOSTICO_PACIENTE) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal diagnostico_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.MED_DIAGNOSTICO_PACIENTE
                With NewItem
                    .DIAGNOSTICO_ID = diagnostico_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.MED_DIAGNOSTICO_PACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class EST_LABORATORIOCAB
        Inherits DAL.Tables.EST_LABORATORIOCAB

        Public Function GrabaLaboratorio(ByVal Items As List(Of Entities.Tables.EST_LABORATORIOITEMS), ByVal ItemCab As Entities.Tables.EST_LABORATORIOCAB)

            Dim _proximoID As Integer
            Dim _prox As New DAL.Procedures.EST_MAXIDLABORATORIO

            If _prox.Items().Count > 0 Then
                _proximoID = _prox.Resultset(0).id_solicitud + 1
            Else
                _proximoID = 1
            End If

            Dim NewCab As New DAL.Tables.EST_LABORATORIOCAB
            Dim ItemLab As New Entities.Tables.EST_LABORATORIOITEMS


            Try

                'ESTABLEZCO LA TRANSACCION
                NewCab.BeginTransaction()

                'GUARDO LA CABECERA
                ItemCab.ID_SOLICITUD = _proximoID
                NewCab.Add(ItemCab)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewLABCItem As New DAL.Tables.EST_LABORATORIOITEMS(NewCab)

                Dim i As Int16
                i = 0
                For Each _itemcuerpo As Entities.Tables.EST_LABORATORIOITEMS In Items
                    ItemLab = New Entities.Tables.EST_LABORATORIOITEMS()
                    ItemLab.ESTUDIO_ID = _itemcuerpo.ESTUDIO_ID
                    ItemLab.NROITEM = i + 1
                    ItemLab.ESTADO_ID = _itemcuerpo.ESTADO_ID
                    ItemLab.ID_SOLICITUD = _proximoID

                    'VOY GRABANDO LOS ITEMS
                    NewLABCItem.Add(ItemLab)
                    i = i + 1
                Next

                'HAGO EL COMMIT
                NewCab.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewCab.EndTransaction(False)
                Return False
            End Try
        End Function

        Public Function ActualizaLaboratorio(ByVal Items As List(Of Entities.Tables.EST_LABORATORIOITEMS), ByVal ItemCab As Entities.Tables.EST_LABORATORIOCAB)

            Dim NewCab As New DAL.Tables.EST_LABORATORIOCAB
            Dim ItemLab As New Entities.Tables.EST_LABORATORIOITEMS


            Try

                'ESTABLEZCO LA TRANSACCION
                NewCab.BeginTransaction()

                'ACTUALIZO LA CABECERA
                NewCab.Update(ItemCab)

                'CONSTRUCTOR QUE MANIPULA LA TRANSCACCION
                Dim NewLABCItem As New DAL.Tables.EST_LABORATORIOITEMS(NewCab)

                For Each _itemcuerpo As Entities.Tables.EST_LABORATORIOITEMS In Items

                    ItemLab = New Entities.Tables.EST_LABORATORIOITEMS()
                    ItemLab.NROITEM = _itemcuerpo.NROITEM
                    ItemLab.ID_SOLICITUD = _itemcuerpo.ID_SOLICITUD
                    'VOY BORRANDO LOS ITEMS
                    NewLABCItem.Remove(ItemLab)

                Next

                Dim i As Int16
                i = 0

                For Each _itemcuerpo As Entities.Tables.EST_LABORATORIOITEMS In Items

                    ItemLab = New Entities.Tables.EST_LABORATORIOITEMS()
                    ItemLab.ESTUDIO_ID = _itemcuerpo.ESTUDIO_ID
                    ItemLab.NROITEM = i + 1
                    ItemLab.ESTADO_ID = _itemcuerpo.ESTADO_ID
                    ItemLab.ID_SOLICITUD = _itemcuerpo.ID_SOLICITUD

                    'VOY GRABANDO LOS ITEMS
                    NewLABCItem.Add(ItemLab)
                    i = i + 1
                Next

                'HAGO EL COMMIT
                NewCab.EndTransaction(True)
                Return True


            Catch ex As Exception
                'POR CUALQUIER ERRRO HAGO EL ROLLBACK
                NewCab.EndTransaction(False)
                Return False
            End Try
        End Function
        Public Overloads Function ItemList() As List(Of Entities.Tables.EST_LABORATORIOCAB)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_solicitud As System.Int32) As List(Of Entities.Tables.EST_LABORATORIOCAB)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id_solicitud, DAL.SqlEnums.OperandEnum.Equal, id_solicitud)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EST_LABORATORIOCAB) As Entities.Tables.EST_LABORATORIOCAB
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_solicitud As System.Int32, ByVal paciente_id As System.Int32, ByVal fechasolicitud As System.DateTime, ByVal tipo As System.Int32, ByVal otrosestudios As System.String, ByVal observacionesmed As System.String, ByVal observacionesbioq As System.String, ByVal estado_id As System.Int32, ByVal usuario_id As System.Int32) As Entities.Tables.EST_LABORATORIOCAB
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOCAB
                With NewItem
                    .ID_SOLICITUD = id_solicitud
                    .PACIENTE_ID = paciente_id
                    .FECHASOLICITUD = fechasolicitud
                    .TIPO = tipo
                    .OTROSESTUDIOS = otrosestudios
                    .OBSERVACIONESMED = observacionesmed
                    .OBSERVACIONESBIOQ = observacionesbioq
                    .ESTADO_ID = estado_id
                    .USUARIO_ID = usuario_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EST_LABORATORIOCAB) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_solicitud As System.Int32, ByVal paciente_id As System.Int32, ByVal fechasolicitud As System.DateTime, ByVal tipo As System.Int32, ByVal otrosestudios As System.String, ByVal observacionesmed As System.String, ByVal observacionesbioq As System.String, ByVal estado_id As System.Int32, ByVal usuario_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOCAB
                With NewItem
                    .ID_SOLICITUD = id_solicitud
                    .PACIENTE_ID = paciente_id
                    .FECHASOLICITUD = fechasolicitud
                    .TIPO = tipo
                    .OTROSESTUDIOS = otrosestudios
                    .OBSERVACIONESMED = observacionesmed
                    .OBSERVACIONESBIOQ = observacionesbioq
                    .ESTADO_ID = estado_id
                    .USUARIO_ID = usuario_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EST_LABORATORIOCAB) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_solicitud As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOCAB
                With NewItem
                    .ID_SOLICITUD = id_solicitud

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EST_LABORATORIOCAB)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class EST_LABORATORIODETERMINACIONES
        Inherits DAL.Tables.EST_LABORATORIODETERMINACIONES
        Public Overloads Function ItemList() As List(Of Entities.Tables.EST_LABORATORIODETERMINACIONES)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal estudio_id As System.Int32) As List(Of Entities.Tables.EST_LABORATORIODETERMINACIONES)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.estudio_id, DAL.SqlEnums.OperandEnum.Equal, estudio_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EST_LABORATORIODETERMINACIONES) As Entities.Tables.EST_LABORATORIODETERMINACIONES
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal estudio_id As System.Int32, ByVal descestudio As System.String, ByVal tipoestudio_id As System.Int32, ByVal inhabilitado As System.Boolean) As Entities.Tables.EST_LABORATORIODETERMINACIONES
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIODETERMINACIONES
                With NewItem
                    .ESTUDIO_ID = estudio_id
                    .DESCESTUDIO = descestudio
                    .TIPOESTUDIO_ID = tipoestudio_id
                    .INHABILITADO = inhabilitado

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EST_LABORATORIODETERMINACIONES) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal estudio_id As System.Int32, ByVal descestudio As System.String, ByVal tipoestudio_id As System.Int32, ByVal inhabilitado As System.Boolean) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIODETERMINACIONES
                With NewItem
                    .ESTUDIO_ID = estudio_id
                    .DESCESTUDIO = descestudio
                    .TIPOESTUDIO_ID = tipoestudio_id
                    .INHABILITADO = inhabilitado

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EST_LABORATORIODETERMINACIONES) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal estudio_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIODETERMINACIONES
                With NewItem
                    .ESTUDIO_ID = estudio_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EST_LABORATORIODETERMINACIONES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : EST_LABORATORIOESTADOS
    ''' Descripcion  : 
    ''' Fecha de creación: jueves, 29 de septiembre de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class EST_LABORATORIOESTADOS
        Inherits DAL.Tables.EST_LABORATORIOESTADOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.EST_LABORATORIOESTADOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal estado_id As System.Int32) As List(Of Entities.Tables.EST_LABORATORIOESTADOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.estado_id, DAL.SqlEnums.OperandEnum.Equal, estado_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EST_LABORATORIOESTADOS) As Entities.Tables.EST_LABORATORIOESTADOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal estado_id As System.Int32, ByVal descripcionestado As System.String) As Entities.Tables.EST_LABORATORIOESTADOS
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOESTADOS
                With NewItem
                    .ESTADO_ID = estado_id
                    .DESCRIPCIONESTADO = descripcionestado

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EST_LABORATORIOESTADOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal estado_id As System.Int32, ByVal descripcionestado As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOESTADOS
                With NewItem
                    .ESTADO_ID = estado_id
                    .DESCRIPCIONESTADO = descripcionestado

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EST_LABORATORIOESTADOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal estado_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOESTADOS
                With NewItem
                    .ESTADO_ID = estado_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EST_LABORATORIOESTADOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : EST_LABORATORIOITEMS
    ''' Descripcion  : 
    ''' Fecha de creación: jueves, 29 de septiembre de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class EST_LABORATORIOITEMS
        Inherits DAL.Tables.EST_LABORATORIOITEMS
        Public Overloads Function ItemList() As List(Of Entities.Tables.EST_LABORATORIOITEMS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal id_solicitud As System.Int32, ByVal nroitem As System.Int32) As List(Of Entities.Tables.EST_LABORATORIOITEMS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.id_solicitud, DAL.SqlEnums.OperandEnum.Equal, id_solicitud)
                MyBase.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, ColumnEnum.nroItem, DAL.SqlEnums.OperandEnum.Equal, nroitem)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EST_LABORATORIOITEMS) As Entities.Tables.EST_LABORATORIOITEMS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal id_solicitud As System.Int32, ByVal nroitem As System.Int32, ByVal estudio_id As System.Int32, ByVal estado_id As System.Int32) As Entities.Tables.EST_LABORATORIOITEMS
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOITEMS
                With NewItem
                    .ID_SOLICITUD = id_solicitud
                    .NROITEM = nroitem
                    .ESTUDIO_ID = estudio_id
                    .ESTADO_ID = estado_id

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EST_LABORATORIOITEMS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal id_solicitud As System.Int32, ByVal nroitem As System.Int32, ByVal estudio_id As System.Int32, ByVal estado_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOITEMS
                With NewItem
                    .ID_SOLICITUD = id_solicitud
                    .NROITEM = nroitem
                    .ESTUDIO_ID = estudio_id
                    .ESTADO_ID = estado_id

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EST_LABORATORIOITEMS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal id_solicitud As System.Int32, ByVal nroitem As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOITEMS
                With NewItem
                    .ID_SOLICITUD = id_solicitud
                    .NROITEM = nroitem

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EST_LABORATORIOITEMS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : EST_LABORATORIOTIPOESTUDIO
    ''' Descripcion  : 
    ''' Fecha de creación: jueves, 29 de septiembre de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class EST_LABORATORIOTIPOESTUDIO
        Inherits DAL.Tables.EST_LABORATORIOTIPOESTUDIO
        Public Overloads Function ItemList() As List(Of Entities.Tables.EST_LABORATORIOTIPOESTUDIO)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal tipoestudio_id As System.Int32) As List(Of Entities.Tables.EST_LABORATORIOTIPOESTUDIO)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.tipoEstudio_id, DAL.SqlEnums.OperandEnum.Equal, tipoestudio_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EST_LABORATORIOTIPOESTUDIO) As Entities.Tables.EST_LABORATORIOTIPOESTUDIO
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal tipoestudio_id As System.Int32, ByVal descripciontipoest As System.String) As Entities.Tables.EST_LABORATORIOTIPOESTUDIO
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOTIPOESTUDIO
                With NewItem
                    .TIPOESTUDIO_ID = tipoestudio_id
                    .DESCRIPCIONTIPOEST = descripciontipoest

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EST_LABORATORIOTIPOESTUDIO) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal tipoestudio_id As System.Int32, ByVal descripciontipoest As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOTIPOESTUDIO
                With NewItem
                    .TIPOESTUDIO_ID = tipoestudio_id
                    .DESCRIPCIONTIPOEST = descripciontipoest

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EST_LABORATORIOTIPOESTUDIO) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal tipoestudio_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOTIPOESTUDIO
                With NewItem
                    .TIPOESTUDIO_ID = tipoestudio_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EST_LABORATORIOTIPOESTUDIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : EST_LABORATORIOTIPOS
    ''' Descripcion  : 
    ''' Fecha de creación: jueves, 29 de septiembre de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class EST_LABORATORIOTIPOS
        Inherits DAL.Tables.EST_LABORATORIOTIPOS
        Public Overloads Function ItemList() As List(Of Entities.Tables.EST_LABORATORIOTIPOS)
            Return MyBase.Items
        End Function

        Public Overloads Function ItemList(ByVal tipo_id As System.Int32) As List(Of Entities.Tables.EST_LABORATORIOTIPOS)
            Try
                MyBase.WhereParameter.Add(ColumnEnum.tipo_id, DAL.SqlEnums.OperandEnum.Equal, tipo_id)

                Return MyBase.Items
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function
        Public Overloads Function AddItem(ByVal Item As Entities.Tables.EST_LABORATORIOTIPOS) As Entities.Tables.EST_LABORATORIOTIPOS
            Return MyBase.Add(Item)
        End Function

        Public Overloads Function AddItem(ByVal tipo_id As System.Int32, ByVal tipodescripcion As System.String) As Entities.Tables.EST_LABORATORIOTIPOS
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOTIPOS
                With NewItem
                    .TIPO_ID = tipo_id
                    .TIPODESCRIPCION = tipodescripcion

                End With
                MyBase.Add(NewItem)
                Return NewItem
            Catch Ex As Exception
                Throw Ex
                Return Nothing
            End Try
        End Function

        Public Overloads Function UpdateItem(ByVal Item As Entities.Tables.EST_LABORATORIOTIPOS) As Boolean
            Return MyBase.Update(Item)
        End Function

        Public Overloads Function UpdateItem(ByVal tipo_id As System.Int32, ByVal tipodescripcion As System.String) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOTIPOS
                With NewItem
                    .TIPO_ID = tipo_id
                    .TIPODESCRIPCION = tipodescripcion

                End With
                Return MyBase.Update(NewItem)
            Catch Ex As Exception
                Throw Ex
            End Try
        End Function

        Public Overloads Function RemoveItem(ByVal Item As Entities.Tables.EST_LABORATORIOTIPOS) As Boolean
            Return MyBase.Remove(Item)
        End Function

        Public Overloads Function RemoveItem(ByVal tipo_id As System.Int32) As Boolean
            Try
                Dim NewItem As New Entities.Tables.EST_LABORATORIOTIPOS
                With NewItem
                    .TIPO_ID = tipo_id

                End With
                Return MyBase.Remove(NewItem)
            Catch Ex As Exception
                Throw (Ex)
            End Try
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Tables.EST_LABORATORIOTIPOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '


End Namespace 'Tables

Namespace Joins
    Partial Public Class HABITACIONES
        Inherits DAL.Joins.HABITACIONES
        Public Function ItemList() As List(Of Entities.Joins.HABITACIONES)
            Return MyBase.Items
        End Function

        Public Function AddItem(ByVal Item As Entities.Joins.HABITACIONES)
            Return MyBase.Add(Item)
        End Function


        Public Function UpdateItem(ByVal Item As Entities.Joins.HABITACIONES)
            Return MyBase.Update(Item)
        End Function

        Public Function RemoveItem(ByVal Item As Entities.Joins.HABITACIONES)
            Return MyBase.Remove(Item)
        End Function

        Public ReadOnly Property Result() As List(Of Entities.Joins.HABITACIONES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

End Namespace 'Joins

Namespace Procedures
    Partial Public Class MED_GET_MEDICAMENTO_BEJERMAN
        Inherits DAL.Procedures.MED_GET_MEDICAMENTO_BEJERMAN
        Public Function ItemList(ByVal medicamento_id As System.String) As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_BEJERMAN)
            Return MyBase.Items(medicamento_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_BEJERMAN)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_MEDICAMENTO_INDICACION_MEDICA
        Inherits DAL.Procedures.MED_GET_MEDICAMENTO_INDICACION_MEDICA
        Public Function ItemList(ByVal medicamento_id As System.String, ByVal inactivo As System.Boolean) As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_INDICACION_MEDICA)
            Return MyBase.Items(medicamento_id, inactivo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_INDICACION_MEDICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_MEDICAMENTO_SOLICITADO
        Inherits DAL.Procedures.MED_GET_MEDICAMENTO_SOLICITADO
        Public Function ItemList(ByVal autoriza As System.Boolean, ByVal pendiente As System.Boolean) As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_SOLICITADO)
            Return MyBase.Items(autoriza, pendiente)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_SOLICITADO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_DIAGNOSTICO_PACIENTE
        Inherits DAL.Procedures.MED_GET_DIAGNOSTICO_PACIENTE
        Public Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_PACIENTE)
            Return MyBase.Items(paciente_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_PACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class GET_PISO_POR_SEDE
        Inherits DAL.Procedures.GET_PISO_POR_SEDE
        Public Function ItemList(ByVal sede_id As System.Int32) As List(Of Entities.Procedures.GET_PISO_POR_SEDE)
            Return MyBase.Items(sede_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.GET_PISO_POR_SEDE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_PHP
        Inherits DAL.Procedures.PRO_GET_PHP
        Public Function ItemList(ByVal php_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_PHP)
            Return MyBase.Items(php_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_PHP)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_PHP_ADITIVO
        Inherits DAL.Procedures.PRO_GET_PHP_ADITIVO
        Public Function ItemList() As List(Of Entities.Procedures.PRO_GET_PHP_ADITIVO)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_PHP_ADITIVO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_MEDICAMENTO_VIA
        Inherits DAL.Procedures.MED_GET_MEDICAMENTO_VIA
        Public Function ItemList(ByVal medicamento_id As System.String, ByVal inactivo As System.Boolean) As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_VIA)
            Return MyBase.Items(medicamento_id, inactivo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_MEDICAMENTO_VIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_VIA
        Inherits DAL.Procedures.MED_GET_VIA
        Public Function ItemList(ByVal inactivo As System.String) As List(Of Entities.Procedures.MED_GET_VIA)
            Return MyBase.Items(inactivo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_VIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MAP_GET_HORARIO_MEDICAMENTO
        Inherits DAL.Procedures.MAP_GET_HORARIO_MEDICAMENTO
        Public Function ItemList(ByVal paciente_id As System.Int32, ByVal hs As System.String) As List(Of Entities.Procedures.MAP_GET_HORARIO_MEDICAMENTO)
            Return MyBase.Items(paciente_id, hs)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MAP_GET_HORARIO_MEDICAMENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class GET_PACIENTE
        Inherits DAL.Procedures.GET_PACIENTE
        Public Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Procedures.GET_PACIENTE)
            Return MyBase.Items(paciente_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.GET_PACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class OBTIENEULTIMAHISTORIACLINICA
        Inherits DAL.Procedures.OBTIENEULTIMAHISTORIACLINICA
        Public Function ItemList(ByVal empresa_id As System.Int32) As List(Of Entities.Procedures.OBTIENEULTIMAHISTORIACLINICA)
            Return MyBase.Items(empresa_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.OBTIENEULTIMAHISTORIACLINICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEOBRASSOCIALES
        Inherits DAL.Procedures.TRAEOBRASSOCIALES
        Public Function ItemList() As List(Of Entities.Procedures.TRAEOBRASSOCIALES)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEOBRASSOCIALES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEHABITACIONESLIBRES
        Inherits DAL.Procedures.TRAEHABITACIONESLIBRES
        Public Function ItemList(ByVal sede As Int32, ByVal actualiza As Int32, ByVal habid As Int32) As List(Of Entities.Procedures.TRAEHABITACIONESLIBRES)
            Return MyBase.Items(sede, actualiza, habid)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEHABITACIONESLIBRES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEMEDICAMENTOS
        Inherits DAL.Procedures.TRAEMEDICAMENTOS
        Public Function ItemList(ByVal medicamento_id As System.String) As List(Of Entities.Procedures.TRAEMEDICAMENTOS)
            Return MyBase.Items(medicamento_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEMEDICAMENTOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEMEDICACIONPACIENTE
        Inherits DAL.Procedures.TRAEMEDICACIONPACIENTE
        Public Function ItemList(ByVal paciente As System.Int32) As List(Of Entities.Procedures.TRAEMEDICACIONPACIENTE)
            Return MyBase.Items(paciente)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEMEDICACIONPACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '   
    Partial Public Class _BUSCARPERFILESPERMISOS
        Inherits DAL.Procedures._BUSCARPERFILESPERMISOS
        Public Function ItemList(ByVal vsql As System.String) As List(Of Entities.Procedures._BUSCARPERFILESPERMISOS)
            Return MyBase.Items(vsql)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._BUSCARPERFILESPERMISOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _MENUES_HIJOS
        Inherits DAL.Procedures._MENUES_HIJOS
        Public Function ItemList(ByVal padre As System.Int32) As List(Of Entities.Procedures._MENUES_HIJOS)
            Return MyBase.Items(padre)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._MENUES_HIJOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _MENUES_PADRES
        Inherits DAL.Procedures._MENUES_PADRES
        Public Function ItemList() As List(Of Entities.Procedures._MENUES_PADRES)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._MENUES_PADRES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _MENUES_PADRES_E_HIJOS
        Inherits DAL.Procedures._MENUES_PADRES_E_HIJOS
        Public Function ItemList(ByVal padre As System.Int32, ByVal perfil As System.Int32) As List(Of Entities.Procedures._MENUES_PADRES_E_HIJOS)
            Return MyBase.Items(padre, perfil)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._MENUES_PADRES_E_HIJOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _OBTENERPERMISOS
        Inherits DAL.Procedures._OBTENERPERMISOS
        Public Function ItemList(ByVal perfil As System.Int32, ByVal idmenu As System.Int32) As List(Of Entities.Procedures._OBTENERPERMISOS)
            Return MyBase.Items(perfil, idmenu)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._OBTENERPERMISOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _OBTENERPERMISOS_PORMODULO
        Inherits DAL.Procedures._OBTENERPERMISOS_PORMODULO
        Public Function ItemList(ByVal perfil As System.Int32, ByVal idmenu As System.Int32) As List(Of Entities.Procedures._OBTENERPERMISOS_PORMODULO)
            Return MyBase.Items(perfil, idmenu)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._OBTENERPERMISOS_PORMODULO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _TBL_USUARIOS_UPDATE_SIN_CLAVE
        Inherits DAL.Procedures._TBL_USUARIOS_UPDATE_SIN_CLAVE

        Public Function UpdateUsuario(ByVal id_usuario As System.Int32, ByVal id_perfil As System.Int32, ByVal identificadorusuario As System.String, ByVal nombreusuario As System.String, ByVal inactivo As System.Boolean, ByVal sector_id As Integer) As Object
            Return MyBase.ActualizaSinClave(id_usuario, id_perfil, identificadorusuario, nombreusuario, inactivo, sector_id)

        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _VALIDACREDENCIAL
        Inherits DAL.Procedures._VALIDACREDENCIAL
        Public Function ItemList(ByVal nombreusuario As System.String, ByVal contrasenia As System.String) As List(Of Entities.Procedures._VALIDACREDENCIAL)
            Return MyBase.Items(nombreusuario, contrasenia)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures._VALIDACREDENCIAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class ULTIMA_POSICION_MENU
        Inherits DAL.Procedures.ULTIMA_POSICION_MENU
        Public Function ItemList(ByVal menuapadre As System.Int32) As List(Of Entities.Procedures.ULTIMA_POSICION_MENU)
            Return MyBase.Items(menuapadre)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.ULTIMA_POSICION_MENU)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAECONTACTOSPACIENTE
        Inherits DAL.Procedures.TRAECONTACTOSPACIENTE
        Public Function ItemList(ByVal paciente As System.Int32) As List(Of Entities.Procedures.TRAECONTACTOSPACIENTE)
            Return MyBase.Items(paciente)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAECONTACTOSPACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEPACIENTESDEALTA
        Inherits DAL.Procedures.TRAEPACIENTESDEALTA
        Public Function ItemList() As List(Of Entities.Procedures.TRAEPACIENTESDEALTA)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEPACIENTESDEALTA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAECANTIDADLLAMADOSPACIENTE
        Inherits DAL.Procedures.TRAECANTIDADLLAMADOSPACIENTE
        Public Function ItemList(ByVal paciente As System.Int32) As List(Of Entities.Procedures.TRAECANTIDADLLAMADOSPACIENTE)
            Return MyBase.Items(paciente)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAECANTIDADLLAMADOSPACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class ACTUALIZACANTLLAMADOS
        Inherits DAL.Procedures.ACTUALIZACANTLLAMADOS
        Public Function ActualizaLllamados(ByVal id As System.Int32, ByVal cantbolsasdeposito As System.Int32) As Object
            Return MyBase.Items(id, cantbolsasdeposito)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class UPDATEFECHABAJAPACIENTE
        Inherits DAL.Procedures.UPDATEFECHABAJAPACIENTE
        Public Function ItemList(ByVal fegreso As System.DateTime, ByVal paciente_id As System.Int32) As Object
            Return MyBase.Items(fegreso, paciente_id)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEPACIENTESPERTENECIA
        Inherits DAL.Procedures.TRAEPACIENTESPERTENECIA
        Public Function ItemList() As List(Of Entities.Procedures.TRAEPACIENTESPERTENECIA)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEPACIENTESPERTENECIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class OBTIENEULTIMOID
        Inherits DAL.Procedures.OBTIENEULTIMOID
        Public Function ItemList(ByVal tabla As System.String) As List(Of Entities.Procedures.OBTIENEULTIMOID)
            Return MyBase.Items(tabla)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.OBTIENEULTIMOID)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_HISTORIAL_SUMINISTRO_MEDICACION
        Inherits DAL.Procedures.MED_GET_HISTORIAL_SUMINISTRO_MEDICACION
        Public Function ItemList(ByVal suministro_medicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal tipoget As System.String) As List(Of Entities.Procedures.MED_GET_HISTORIAL_SUMINISTRO_MEDICACION)
            Return MyBase.Items(suministro_medicacion_id, paciente_id, medicamento_id, tipoget)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_HISTORIAL_SUMINISTRO_MEDICACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_SUMINISTRO_MEDICACION
        Inherits DAL.Procedures.MED_GET_SUMINISTRO_MEDICACION
        Public Function ItemList(ByVal suministro_medicacion_id As System.Int32, ByVal paciente_id As System.Int32, ByVal medicamento_id As System.String, ByVal tipoget As System.String) As List(Of Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION)
            Return MyBase.Items(suministro_medicacion_id, paciente_id, medicamento_id, tipoget)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_PROCEDIMIENTO
        Inherits DAL.Procedures.PRO_GET_PROCEDIMIENTO
        Public Function ItemList(ByVal procedimiento As System.String) As List(Of Entities.Procedures.PRO_GET_PROCEDIMIENTO)
            Return MyBase.Items(procedimiento)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_PROCEDIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_PROCEDIMIENTO_PACIENTE
        Inherits DAL.Procedures.PRO_GET_PROCEDIMIENTO_PACIENTE
        Public Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_PROCEDIMIENTO_PACIENTE)
            Return MyBase.Items(paciente_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_PROCEDIMIENTO_PACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_ENFERMERIA
        Inherits DAL.Procedures.PRO_GET_ENFERMERIA
        Public Function ItemList(ByVal enfermeria_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_ENFERMERIA)
            Return MyBase.Items(enfermeria_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_ENFERMERIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_GENERICO
        Inherits DAL.Procedures.PRO_GET_GENERICO
        Public Function ItemList(ByVal generico_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_GENERICO)
            Return MyBase.Items(generico_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_GENERICO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_POSOLOGIA
        Inherits DAL.Procedures.PRO_GET_POSOLOGIA
        Public Function ItemList(ByVal posologia_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_POSOLOGIA)
            Return MyBase.Items(posologia_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_POSOLOGIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_ABOCATH_NUMERO
        Inherits DAL.Procedures.PRO_GET_ABOCATH_NUMERO
        Public Function ItemList() As List(Of Entities.Procedures.PRO_GET_ABOCATH_NUMERO)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_ABOCATH_NUMERO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_COLOCACION_VIA_PERIFERICA
        Inherits DAL.Procedures.PRO_GET_COLOCACION_VIA_PERIFERICA
        Public Function ItemList(ByVal colocacion_via_periferica_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_COLOCACION_VIA_PERIFERICA)
            Return MyBase.Items(colocacion_via_periferica_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_COLOCACION_VIA_PERIFERICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_CUIDADO_ORAL
        Inherits DAL.Procedures.PRO_GET_CUIDADO_ORAL
        Public Function ItemList(ByVal cuidado_oral_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_CUIDADO_ORAL)
            Return MyBase.Items(cuidado_oral_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_CUIDADO_ORAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_CUIDADO_POSTURAL
        Inherits DAL.Procedures.PRO_GET_CUIDADO_POSTURAL
        Public Function ItemList(ByVal cuidado_postural_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_CUIDADO_POSTURAL)
            Return MyBase.Items(cuidado_postural_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_CUIDADO_POSTURAL)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_PROTECCION_FISICA
        Inherits DAL.Procedures.PRO_GET_PROTECCION_FISICA
        Public Function ItemList(ByVal proteccion_fisica_id As System.Int32) As List(Of Entities.Procedures.PRO_GET_PROTECCION_FISICA)
            Return MyBase.Items(proteccion_fisica_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_PROTECCION_FISICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGACABECERAGET
        Inherits DAL.Procedures.PRORROGACABECERAGET
        Public Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Procedures.PRORROGACABECERAGET)
            Return MyBase.Items(paciente_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRORROGACABECERAGET)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGADETALLEGET
        Inherits DAL.Procedures.PRORROGADETALLEGET
        Public Function ItemList(ByVal prorroga_id As Int32, ByVal tipo As String, ByVal informe As String, ByVal prorrogaitemid As Int32) As List(Of Entities.Procedures.PRORROGADETALLEGET)
            Return MyBase.Items(prorroga_id, tipo, informe, prorrogaitemid)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRORROGADETALLEGET)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGADETALLE
        Inherits DAL.Procedures.PRORROGADETALLE
        Public Function ItemList(ByVal id_prorroga As System.Int32) As List(Of Entities.Procedures.PRORROGADETALLE)
            Return MyBase.Items(id_prorroga)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRORROGADETALLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGAEVOLUCIONDETALLE
        Inherits DAL.Procedures.PRORROGAEVOLUCIONDETALLE
        Public Function ItemList(ByVal id_prorrogaitem As System.Int32) As List(Of Entities.Procedures.PRORROGAEVOLUCIONDETALLE)
            Return MyBase.Items(id_prorrogaitem)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRORROGAEVOLUCIONDETALLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGASULTIMAMODIFICACION
        Inherits DAL.Procedures.PRORROGASULTIMAMODIFICACION
        Public Function ItemList(ByVal prorroga_id As Int32, ByVal tipo As String) As List(Of Entities.Procedures.PRORROGASULTIMAMODIFICACION)
            Return MyBase.Items(prorroga_id, tipo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRORROGASULTIMAMODIFICACION)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class GET_PACIENTE_POR_SEDE
        Inherits DAL.Procedures.GET_PACIENTE_POR_SEDE
        Public Function ItemList(ByVal sede_id As System.Int32, ByVal piso_id As System.Int32) As List(Of Entities.Procedures.GET_PACIENTE_POR_SEDE)
            Return MyBase.Items(sede_id, piso_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.GET_PACIENTE_POR_SEDE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRORROGAULTIMODETALLE
        Inherits DAL.Procedures.PRORROGAULTIMODETALLE
        Public Function ItemList(ByVal id_prorroga As Int32) As List(Of Entities.Procedures.PRORROGAULTIMODETALLE)
            Return MyBase.Items(id_prorroga)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRORROGAULTIMODETALLE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_HORARIOS_PACIENTE
        Inherits DAL.Procedures.MED_GET_HORARIOS_PACIENTE
        Public Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Procedures.MED_GET_HORARIOS_PACIENTE)
            Return MyBase.Items(paciente_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_HORARIOS_PACIENTE)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_UP_HORARIOS_PACIENTE
        Inherits DAL.Procedures.MED_UP_HORARIOS_PACIENTE
        Public Function ItemList(ByVal paciente_id As System.Int32, ByVal hs_08 As System.Int32, ByVal hs_09 As System.Int32, ByVal hs_10 As System.Int32, ByVal hs_11 As System.Int32, ByVal hs_12 As System.Int32, ByVal hs_13 As System.Int32, ByVal hs_14 As System.Int32, ByVal hs_15 As System.Int32, ByVal hs_16 As System.Int32, ByVal hs_17 As System.Int32, ByVal hs_18 As System.Int32, ByVal hs_19 As System.Int32, ByVal hs_20 As System.Int32, ByVal hs_21 As System.Int32, ByVal hs_22 As System.Int32, ByVal hs_23 As System.Int32, ByVal hs_24 As System.Int32, ByVal hs_01 As System.Int32, ByVal hs_02 As System.Int32, ByVal hs_03 As System.Int32, ByVal hs_04 As System.Int32, ByVal hs_05 As System.Int32, ByVal hs_06 As System.Int32, ByVal hs_07 As System.Int32, ByVal hs_sh As System.Int32) As Object
            Return MyBase.Items(paciente_id, hs_08, hs_09, hs_10, hs_11, hs_12, hs_13, hs_14, hs_15, hs_16, hs_17, hs_18, hs_19, hs_20, hs_21, hs_22, hs_23, hs_24, hs_01, hs_02, hs_03, hs_04, hs_05, hs_06, hs_07, hs_sh)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class HC_TRAEDATOS
        Inherits DAL.Procedures.HC_TRAEDATOS
        Public Function ItemList(ByVal paciente_id As System.Int32, ByVal tipo As System.String) As List(Of Entities.Procedures.HC_TRAEDATOS)
            Return MyBase.Items(paciente_id, tipo)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.HC_TRAEDATOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEDESCARTABLES
        Inherits DAL.Procedures.TRAEDESCARTABLES
        Public Function ItemList(ByVal descartable As System.String) As List(Of Entities.Procedures.TRAEDESCARTABLES)
            Return MyBase.Items(descartable)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEDESCARTABLES)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class TRAEDESCARTABLESPROCEDIMIENTO
        Inherits DAL.Procedures.TRAEDESCARTABLESPROCEDIMIENTO
        Public Function ItemList(ByVal procedimiento As System.Int32) As List(Of Entities.Procedures.TRAEDESCARTABLESPROCEDIMIENTO)
            Return MyBase.Items(procedimiento)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.TRAEDESCARTABLESPROCEDIMIENTO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class _PRO_BORRARDESCARTABLESPROC
        Inherits DAL.Procedures._PRO_BORRARDESCARTABLESPROC
        Public Function ItemList(ByVal procid As System.Int32) As Object
            Return MyBase.Items(procid)
        End Function
        Public ReadOnly Property Result() As Object
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class PRO_GET_PROCEDIMIENTOTODOS
        Inherits DAL.Procedures.PRO_GET_PROCEDIMIENTOTODOS
        Public Function ItemList(ByVal procedimiento As System.String) As List(Of Entities.Procedures.PRO_GET_PROCEDIMIENTOTODOS)
            Return MyBase.Items(procedimiento)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.PRO_GET_PROCEDIMIENTOTODOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_SUMINISTRO_MEDICACION_HISTORICO
        Inherits DAL.Procedures.MED_GET_SUMINISTRO_MEDICACION_HISTORICO
        Public Function ItemList(ByVal paciente_id As System.Int32) As List(Of Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION_HISTORICO)
            Return MyBase.Items(paciente_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION_HISTORICO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_DIAGNOSTICO_CAPITULO
        Inherits DAL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO
        Public Function ItemList() As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_DIAGNOSTICO_RUBRO
        Inherits DAL.Procedures.MED_GET_DIAGNOSTICO_RUBRO
        Public Function ItemList(ByVal grupo_id As System.String) As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO)
            Return MyBase.Items(grupo_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_DIAGNOSTICO_SUBRUBRO
        Inherits DAL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO
        Public Function ItemList(ByVal grupo_id As System.String) As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO)
            Return MyBase.Items(grupo_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class MED_GET_DIAGNOSTICO_ITEM
        Inherits DAL.Procedures.MED_GET_DIAGNOSTICO_ITEM
        Public Function ItemList(ByVal capitulo_id As System.String) As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM)
            Return MyBase.Items(capitulo_id)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '
    Partial Public Class EST_MAXIDLABORATORIO
        Inherits DAL.Procedures.EST_MAXIDLABORATORIO
        Public Function ItemList() As List(Of Entities.Procedures.EST_MAXIDLABORATORIO)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EST_MAXIDLABORATORIO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EST_LABORATORIO_TRAEPEDIDOS
        Inherits DAL.Procedures.EST_LABORATORIO_TRAEPEDIDOS
        Public Function ItemList(ByVal paciente_id As System.Int32, ByVal estado As System.Int32, ByVal tipo As System.Int32, ByVal sector As System.String, ByVal fecha As System.DateTime, ByVal fecha_hasta As System.DateTime, ByVal inf As System.String) As List(Of Entities.Procedures.EST_LABORATORIO_TRAEPEDIDOS)
            Return MyBase.Items(paciente_id, estado, tipo, sector, fecha, fecha_hasta, inf)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEPEDIDOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EST_LABORATORIO_TRAEUNPEDIDO
        Inherits DAL.Procedures.EST_LABORATORIO_TRAEUNPEDIDO
        Public Function ItemList(ByVal id_solicitud As System.Int32) As List(Of Entities.Procedures.EST_LABORATORIO_TRAEUNPEDIDO)
            Return MyBase.Items(id_solicitud)
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEUNPEDIDO)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    Partial Public Class EST_LABORATORIO_TRAEANALISISCLINICA
        Inherits DAL.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA
        Public Function ItemList() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : EST_LABORATORIO_TRAEANALISISDERIVADOS
    ''' Descripcion  : 
    ''' Fecha de creación: jueves, 29 de septiembre de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class EST_LABORATORIO_TRAEANALISISDERIVADOS
        Inherits DAL.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS
        Public Function ItemList() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

    ''' <summary>
    ''' Nombre de la Clase   : EST_LABORATORIO_TRAEANALISISMICROBIOLOGIA
    ''' Descripcion  : 
    ''' Fecha de creación: jueves, 29 de septiembre de 2016
    ''' </summary>
    ''' <remarks></remarks>
    Partial Public Class EST_LABORATORIO_TRAEANALISISMICROBIOLOGIA
        Inherits DAL.Procedures.EST_LABORATORIO_TRAEANALISISMICROBIOLOGIA
        Public Function ItemList() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEANALISISMICROBIOLOGIA)
            Return MyBase.Items()
        End Function
        Public ReadOnly Property Result() As List(Of Entities.Procedures.EST_LABORATORIO_TRAEANALISISMICROBIOLOGIA)
            Get
                Return MyBase.Resultset
            End Get
        End Property

    End Class '

End Namespace 'Procedures

Namespace Views

End Namespace 'Views
