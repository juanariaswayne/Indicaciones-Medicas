using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace MenuSistema
{
    public class Cls_Menus
    {

        #region Miembros de la clase
        private int id_menu;
        private int id_menupadre;
        private string descripcionmenu;
        private int posicionmenu;
        private int habilitadomenu;
        private string urlmenu;
        private int formularioasociado;
        private int id_perfil;
        private string condicionadicional;
        #endregion

        #region "Propiedades de la clase"

        public int Id_Menu
        {
            get
            {
                return id_menu;
            }
            set
            {
                id_menu = value;

            }
        }


        public int Id_MenuPadre
        {
            get
            {
                return id_menupadre;
            }
            set
            {
                id_menupadre = value;

            }
        }


        public string DescripcionMenu
        {
            get
            {
                return descripcionmenu;
            }
            set
            {
                descripcionmenu = value;

            }
        }

        public int PosicionMenu
        {
            get
            {
                return posicionmenu;
            }
            set
            {
                posicionmenu = value;

            }
        }


        public int HabilitadoMenu
        {
            get
            {
                return habilitadomenu;
            }
            set
            {
                habilitadomenu = value;

            }
        }

        public string UrlMenu
        {
            get
            {
                return urlmenu;
            }
            set
            {
                urlmenu = value;

            }
        }

        public int FormularioAsociado
        {
            get
            {
                return formularioasociado;
            }
            set
            {
                formularioasociado = value;

            }
        }

        public int Id_Perfil
        {
            get
            {
                return id_perfil;
            }
            set
            {
                id_perfil = value;

            }
        }

        public string CondicionAdicional
        {
            get
            {
                return condicionadicional;
            }
            set
            {
                condicionadicional = value;
            }
        }

        #endregion

        public DataTable BuscarPerfilesPermisos()
        {
            DataTable dt = new DataTable();
            //Construyendo la condición
            string condicion = "";
            if (id_menu > 0) condicion += " AND Id_Menu =" + id_menu;
            if (id_menupadre > 0) condicion += " AND Id_MenuPadre =" + id_menupadre;
            if (descripcionmenu.Length > 0) condicion += " AND DescripcionMenu Like '%" + descripcionmenu + "%'";
            if (posicionmenu > 0) condicion += " AND PosicionMenu =" + posicionmenu;
            if (habilitadomenu > 0) condicion += " AND HabilitadoMenu =" + habilitadomenu;
            if (urlmenu.Length > 0) condicion += " AND UrlMenu Like '%" + urlmenu + "%'";
            if (formularioasociado > 0) condicion += " AND FormularioAsociado =" + formularioasociado;
            if (id_perfil > 0) condicion += " AND Id_Perfil =" + id_perfil;
            if (condicionadicional.Length > 0) condicion += " AND " + condicionadicional;
            if (condicion != "") condicion = " WHERE " + condicion.Substring(5);

            BLL.Procedures._BUSCARPERFILESPERMISOS _buscaPerfiles = new BLL.Procedures._BUSCARPERFILESPERMISOS();

            //BLL.Views.QRY_PERFILESPERMISOS _buscaPerfiles = new BLL.Views.QRY_PERFILESPERMISOS();
            //if (id_menu > 0) _buscaPerfiles.WhereParameter.Add(BLL.Views.QRY_PERFILESPERMISOS.ColumnEnum.Id_Menu, DAL.SqlEnums.OperandEnum.Equal, id_menu);
            //if (id_menupadre > 0) _buscaPerfiles.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, BLL.Views.QRY_PERFILESPERMISOS.ColumnEnum.Id_MenuPadre, DAL.SqlEnums.OperandEnum.Equal, id_menupadre);

            dt.TableName = "PerfilesPermisos";
            DataColumn _column = new DataColumn();
            _column.ColumnName = "Id_Menu";
            dt.Columns.Add(_column);

            _column = new DataColumn();

            _column.ColumnName = "Id_MenuPadre";
            dt.Columns.Add(_column);

            _column = new DataColumn();
            _column.ColumnName = "descripcionmenu";
            dt.Columns.Add(_column);

            _column = new DataColumn();
            _column.ColumnName = "posicionmenu";
            dt.Columns.Add(_column);

            _column = new DataColumn();
            _column.ColumnName = "habilitadomenu";
            dt.Columns.Add(_column);

            _column = new DataColumn();
            _column.ColumnName = "urlmenu";
            dt.Columns.Add(_column);

            _column = new DataColumn();
            _column.ColumnName = "formularioasociado";
            dt.Columns.Add(_column);

            _column = new DataColumn();
            _column.ColumnName = "id_perfil";
            dt.Columns.Add(_column);

            try
            {
                //RETORNO EN UN DATATABLE LOS PERMISOS DE ESTE PERFIL, O SEA TRAE TODOS LOS FORMULARIOS DE ESTE PERFIL
                foreach (Entities.Procedures._BUSCARPERFILESPERMISOS per in _buscaPerfiles.ItemList(condicion))
                {
                    dt.Rows.Add(
                        per.id_menu,
                        per.id_menupadre,
                        per.descripcionmenu,
                        per.posicionmenu,
                        per.habilitadomenu,
                        per.urlmenu,
                        per.formularioasociado,
                        per.id_perfil
                        );

                }
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }//buscar

        public List<Entities.Procedures._VALIDACREDENCIAL> ValidarCredenciales(string nombreUsuario, string contrasenia)
        {
            //VALIDO USUARIO Y CLAVE, ME TRAIGO EL ID DE USUARIO Y SU PERFIL
            BLL.Procedures._VALIDACREDENCIAL Credencial = new BLL.Procedures._VALIDACREDENCIAL();

            try
            {
                //LA CLAVE YA VIENE ENCRIPTADA
                return Credencial.ItemList(nombreUsuario, contrasenia);

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public DataTable MenusWindowsDelPerfil(Int32 id_Perfil)
        {
            HabilitadoMenu = 1;
            Id_Perfil = id_Perfil;
            DescripcionMenu = "";
            UrlMenu = "";
            CondicionAdicional = "";
            return BuscarPerfilesPermisos();
        }

        public List<Entities.Procedures._OBTENERPERMISOS> ObtenerPermisos(int id_Perfil, int Menu_id, ref bool lectura, ref  bool escritura, ref bool elimina)
        {
            BLL.Procedures._OBTENERPERMISOS Per = new BLL.Procedures._OBTENERPERMISOS();

            try
            {

                if (Per.Items(id_Perfil, Menu_id).Count > 0)
                {
                    lectura = Per.Result[0].lectura;
                    escritura = Per.Result[0].escritura;
                    elimina = Per.Result[0].eliminacion;

                    return Per.Result;

                }
                else
                {

                    return null;

                }
            }
            catch (Exception ex)
            {
                return null;

            }
        }
    }
}
