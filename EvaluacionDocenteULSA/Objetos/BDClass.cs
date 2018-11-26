using EvaluacionDocenteULSA.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace UrbaniaIntranet.Objetos
{
    public class BDClass
    {

        public SqlConnection conectar;
        public SqlConnection conectarCheck;

        String tbl = String.Empty;
        String ipDisplay = String.Empty;
        private string connStrng;

        internal DataTable cargaCmbxZonas()
        {
            throw new NotImplementedException();
        }

        public BDClass()
        {
            ConexionOpen();
        }
        public string getConnStrng()
        {
            return connStrng;
        }

        #region Inicializa Conexion
        public void ConexionOpen()
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            try
            {//Data source=172.168.1.67\\REPCASETAS;Initial Catalog=Telepeaje;User Id=sa;Password=Er3t4ihv; MultipleActiveResultSets=True
                string ConnString = "Data source=WEBSERVER;Initial Catalog=ULSA;User Id=sa;Password=Er3t4ihv; MultipleActiveResultSets=True";
                connStrng = ConnString;

                conectar = new SqlConnection(ConnString);
                conectarCheck = new SqlConnection(ConnString);
            }
            catch (SqlException ex)
            {
                EventLog.WriteEntry("BDClass", "CONEXION_OPEN" + ex.Message);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("BDClass", "CONEXION_OPEN" + ex.Message);
            }
        }
        #endregion

        #region Abre Conexion
        private bool AbreConexion()
        {
            try
            {
                if (conectar.State != System.Data.ConnectionState.Open)
                {
                    ConexionOpen();
                    conectar.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                //string metodo = "AbreConexion";
                this.CerrarConexion();
                conectar.Close();
                EventLog.WriteEntry("BDClass", "ABRIR_CONEXION" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("BDClass", "ABRIR_CONEXION" + ex.Message);
                return false;
            }
        }

        private bool AbreConexionCheck()
        {
            try
            {
                if (conectarCheck.State != System.Data.ConnectionState.Open)
                {
                    conectarCheck.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                //string metodo = "AbreConexion";
                this.CerrarConexion();
                conectarCheck.Close();
                EventLog.WriteEntry("BDClass", "ABRE_CONEXION_CHECK" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("BDClass", "ABRE_CONEXION_CHECK" + ex.Message);
                return false;
            }
        }
        #endregion

        #region Cierra Conexion
        private bool CerrarConexion()
        {
            try
            {
                if (conectar.State != System.Data.ConnectionState.Closed)
                {
                    conectar.Close();
                    conectar.Dispose();
                }
                return true;
            }
            catch (SqlException ex)
            {
                //string metodo = "CerrarConexion";
                string linea = ex.StackTrace.Substring(ex.StackTrace.Length - 8, 8);

                EventLog.WriteEntry("BDClass", "CERRAR_CONEXION" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("BDClass", "CERRAR_CONEXION" + ex.Message);
                return false;
            }
        }
        #endregion

        #region Reportes
        #region Reporte_INF_PROPIEDAD
      


        public DataTable cargaMaestros(string id)
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_GET_MATERIAS", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_MATERIAS" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_MATERIAS" + ex.Message);
                }
            }
            return null;
        }

        public DataTable cargaCmbxTipoPago()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_CMBX_MODOPAGO", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;

                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_MODOPAGO" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_MODOPAGO" + ex.Message);
                }
            }
            return null;
        }
        public DataTable cargaCmbxColonias()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_CMBX_COLONIAS", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;

                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_COLONIAS" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_COLONIAS" + ex.Message);
                }
            }
            return null;
        }
        public DataTable cargaCmbxTipoPropiedad()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_CMBX_TIPOPROPIEDAD", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;

                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_TIPOPROPIEDAD" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_TIPOPROPIEDAD" + ex.Message);
                }
            }
            return null;
        }

        public DataTable cargaCmbxClientes()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_CMBX_CLIENTES", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;

                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_CLIENTES" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_CLIENTES" + ex.Message);
                }
            }
            return null;
        }
        public DataTable ExpPropiedad()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("REP_EXP_PROPIEDADES", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "REP_EXP_PROPIEDADES" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "REP_EXP_PROPIEDADES" + ex.Message);

                }
                return null;
            }
            return null;
        }
        #endregion
        #region Reporte_ESTATUS_PROPIEDAD
        public DataTable getStatusPropiedad(string estatus)
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_EST_PROPIEDAD", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@estatus", estatus);
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EST_PROPIEDAD" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EST_PROPIEDAD" + ex.Message);
                }
            }
            return null;
        }
        #endregion
        #region Reporte_SP_REP_VP
        public DataTable getReporteVP()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_REP_VP", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_VP" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_VP" + ex.Message);
                }
            }
            return null;
        }
        #endregion
        #region Reporte_SP_REP_CP
        public DataTable getReporteCP()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_REP_CP", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_CP" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_CP" + ex.Message);
                }
            }
            return null;
        }
        #endregion
        #region Reporte_SP_REP_CLIENTES
        public DataTable getCliente()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_REP_CLIENTES", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_CLIENTES" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_CLIENTES" + ex.Message);
                }
            }
            return null;
        }
        public DataTable getEquipamiento()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_GET_EQUIPAMENTO", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_EQUIPAMENTO" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_EQUIPAMENTO" + ex.Message);
                }
            }
            return null;
        }
      
        public DataTable getEncasa()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_GET_ENCASA", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_ENCASA" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_ENCASA" + ex.Message);
                }
            }
            return null;
        }
        public DataTable getMedio()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_GET_MEDIO", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_MEDIO" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_MEDIO" + ex.Message);
                }
            }
            return null;
        }

        public DataTable getMateriales()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_GET_MATERIALES", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_MATERIALES" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_MATERIALES" + ex.Message);
                }
            }
            return null;
        }
      
        public DataTable getTipoPago()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_GET_TIPOSPAGO", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_TIPOSPAGO" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_TIPOSPAGO" + ex.Message);
                }
            }
            return null;
        }
        public DataTable ExpClientes()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("REP_EXP_CLIENTES", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "REP_EXP_CLIENTES" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "REP_EXP_CLIENTES" + ex.Message);
                }
            }
            return null;
        }
        #endregion
        #region Reporte_SP_REP_CAMPANA
        public DataTable getCampana(string estatus)
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_REP_CAMPANA", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fecha", estatus);
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_CAMPANA" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_REP_CAMPANA" + ex.Message);
                }
            }
            return null;
        }
        #endregion
        #endregion
        #region catalogos 
        #region Clientes
        public DataTable cargaCmbxPro()
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_CMBX_PROPIEDADES", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;

                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_PROPIEDADES" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CMBX_PROPIEDADES" + ex.Message);
                }
            }
            return null;
        }
        public DataTable listClientes(string filter)
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_CAT_CLIENTESLIST", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@filter", filter);
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CAT_CLIENTESLIST" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_CAT_CLIENTESLIST" + ex.Message);
                }
            }
            return null;
        }
        public DataTable listLLamadas(string filter)
        {
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_BITACORA_LLAMADAS", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", filter);
                    read = cmd.ExecuteReader();
                    table.Load(read);
                    read.Close();
                    CerrarConexion();
                    return table;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_BITACORA_LLAMADAS" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_BITACORA_LLAMADAS" + ex.Message);
                }
            }
            return null;
        }
      


        public Int64 get_id()
        {
            Int64 valid = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_GET_ID", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valid = read.GetInt64(0);
                    }
                    read.Close();
                    CerrarConexion();
                    return valid;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_ID" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_GET_ID" + ex.Message);
                }
            }
            return 0;
        }

        public int UpdateEquipamiento(string id,string equipo,int valid)
        {
            int valide = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_EDIT_EQUIPO", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EQUIPO", equipo);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@valid", valid);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valide = read.GetInt32(0);
                    }
                    read.Close();
                    CerrarConexion();
                    return valide;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_EQUIPO" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_EQUIPO" + ex.Message);
                }
            }
            return 0;
        }

        public int UpdateEncasa(string id, string equipo, int valid)
        {
            int valide = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_EDIT_ENCASA", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EQUIPO", equipo);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@valid", valid);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valide = read.GetInt32(0);
                    }
                    read.Close();
                    CerrarConexion();
                    return valide;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_EQUIPO" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_EQUIPO" + ex.Message);
                }
            }
            return 0;
        }
        public int UpdateMedio(string id, string equipo, int valid)
        {
            int valide = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_EDIT_MediosContacto", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EQUIPO", equipo);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@valid", valid);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valide = read.GetInt32(0);
                    }
                    read.Close();
                    CerrarConexion();
                    return valide;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_MediosContacto" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_MediosContacto" + ex.Message);
                }
            }
            return 0;
        }

        public int UpdateMaterial(string id, string equipo, int valid)
        {
            int valide = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_EDIT_MATERIAL", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EQUIPO", equipo);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@valid", valid);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valide = read.GetInt32(0);
                    }
                    read.Close();
                    CerrarConexion();
                    return valide;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_MATERIAL" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_EDIT_MATERIAL" + ex.Message);
                }
            }
            return 0;
        }
        public int UpdateTiposPagos(string id, string equipo, int valid)
        {
            int valide = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_EDIT_TiposPagos", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EQUIPO", equipo);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@valid", valid);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valide = read.GetInt32(0);
                    }
                    read.Close();
                    CerrarConexion();
                    return valide;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "[SP_EDIT_TiposPagos]" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "[SP_EDIT_TiposPagos]" + ex.Message);
                }
            }
            return 0;
        }

      

        public string login(string user,string pass)
        {
            string valid = "";
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_LOGIN", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user",user);
                    cmd.Parameters.AddWithValue("@pass",pass);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valid  = read.GetString(0);


                    }
                    read.Close();
                    CerrarConexion();
                    return valid;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_AGENDA_CITA" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_AGENDA_CITA" + ex.Message);
                }
            }
            return "";
        }
        public int insLlamada(string id, string llamada)
        {
            int valid = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_INS_BITACORA_LLAMADAS", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@LLAMADA", llamada);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valid = read.GetInt32(0);


                    }
                    read.Close();
                    CerrarConexion();
                    return valid;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_INS_BITACORA_LLAMADAS" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_INS_BITACORA_LLAMADAS" + ex.Message);
                }
            }
            return 0;
        }

        public int insEvaluacion(ObjResultado obj)
        {
            int valid = 0;
            if (this.AbreConexion())
            {
                try
                {
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SP_INS_EVALUACION", conectar);
                    SqlDataReader read;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_ALUMNO",obj.ID_ALUMNO );
                    cmd.Parameters.AddWithValue("@ID_DOCENTE", obj.ID_DOCENTE);
                    cmd.Parameters.AddWithValue("@A1", obj.A1);
                    cmd.Parameters.AddWithValue("@B1", obj.B1);
                    cmd.Parameters.AddWithValue("@C1", obj.C1);
                    cmd.Parameters.AddWithValue("@D1", obj.D1);
                    cmd.Parameters.AddWithValue("@E1", obj.E1);
                    cmd.Parameters.AddWithValue("@F1", obj.F1);
                    cmd.Parameters.AddWithValue("@G1", obj.G1);
                    cmd.Parameters.AddWithValue("@H1", obj.H1);
                    cmd.Parameters.AddWithValue("@H2", obj.H2);
                    cmd.Parameters.AddWithValue("@COMENTARIO", obj.COMENTARIO);
                    cmd.Parameters.AddWithValue("@COMENTARIOA", obj.COMENTARIOA);
                    cmd.Parameters.AddWithValue("@COMENTARIOB", obj.COMENTARIOB);
                    cmd.Parameters.AddWithValue("@COMENTARIOC", obj.COMENTARIOC);
                    cmd.Parameters.AddWithValue("@COMENTARIOD", obj.COMENTARIOD);
                    cmd.Parameters.AddWithValue("@COMENTARIOE", obj.COMENTARIOE);
                    cmd.Parameters.AddWithValue("@COMENTARIOF", obj.COMENTARIOF);
                    cmd.Parameters.AddWithValue("@COMENTARIOG", obj.COMENTARIOG);
                    cmd.Parameters.AddWithValue("@IDPC", obj.IDPC);
                    cmd.Parameters.AddWithValue("@SECCION", obj.SECCION);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        valid = read.GetInt32(0);


                    }
                    read.Close();
                    CerrarConexion();
                    return valid;
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_INS_EVALUACION" + ex.Message);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("BDClass", "SP_INS_EVALUACION" + ex.Message);
                }
            }
            return 0;
        }


        #endregion
        #endregion

    }
}