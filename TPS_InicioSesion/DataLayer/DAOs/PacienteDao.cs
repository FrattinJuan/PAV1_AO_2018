using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_AO_2018.BusinessLayer;
using System.Windows.Forms;

namespace PAV1_AO_2018.DataLayer.DAOs
{
    public class PacienteDao
    {
      
        public Paciente getPacienteByName(string nombre)
        {
           // string sql = "Select x.* from Pacientes x, where x.nombre = '" + nombre + "'";
            String sql = "Select x.*, z.n_tipo, z.cod_tipo as tipoDoc_paciente from Pacientes x, TiposDocumento z where  x.tipoDocumento = z.cod_tipo AND x.nombre = '" + nombre + "'";
            DataTable oTabla;
            Paciente oPaciente = null/* TODO Change to default(_) if this is not a reference type */;

            oTabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (oTabla.Rows.Count > 0)
                oPaciente = map_paciente(oTabla.Rows[0]);

            return oPaciente;
        }

        public IList<Paciente> getByFilters(List<object> @params)
        {
            List<Paciente> lst = new List<Paciente>();

            string sql = "Select x.*, z.n_tipo, z.cod_tipo as tipoDoc_cliente from Pacientes x, TiposDocumento z where  x.tipoDocumento  = z.cod_tipo AND x.estado = 'S'";  /*revisar esto*/
            Paciente oPaciente = null/* TODO Change to default(_) if this is not a reference type */;
           
            if (@params[0] != null)
                sql += " AND x.nombre LIKE '%' + @param1 + '%' ";

            if (@params[1] != null)
                sql += " AND x.nroDocumento LIKE  @param2 + '%' ";

            if (@params[2] != null)
                sql += " AND x.apellido LIKE '%' + @param3 + '%' ";

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQLConParametros(sql, @params).Rows)
                lst.Add(map_paciente(row));

            return lst;
            
          
        }

        // Permite recuperar todos los usuarios cargados
        public IList<Paciente> getAll()
        {
            List<Paciente> lst = new List<Paciente>();
            string sql = "Select x.*, z.n_tipo, z.cod_tipo as tipoDoc_cliente from Pacientes x, TiposDocumento z where  x.tipoDocumento = z.cod_tipo AND x.estado = 'S'" ;
            Paciente oPaciente = null/* TODO Change to default(_) if this is not a reference type */;

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
                lst.Add(map_paciente(row));

            return lst;
        }

        // Funciones CRUD
        public bool create(Paciente oPaciente)

   
        {
            DataTable tabla = new DataTable();
            string str_sql1;

            str_sql1 = "INSERT INTO Odontogramas(descripcion) VALUES('Danilo') ";
            BDHelper.getBDHelper().EjecutarSQL(str_sql1);
            tabla = BDHelper.getBDHelper().ConsultaSQL("SELECT MAX(cod_odontograma) From Odontogramas");

            string str_sql;

            str_sql = "INSERT INTO Pacientes (nombre, apellido, fechaNac, tipoDocumento, nroDocumento,domicilio, telefono, obraSocial, estado, id_odontograma) VALUES('";
            str_sql += oPaciente.nombre + "','";
            str_sql += oPaciente.apellido + "','";
            str_sql += oPaciente.fechaNacimiento + "','";
            str_sql += oPaciente.cod_tipoDoc + "','";
            str_sql += oPaciente.nroDocumento + "','";
            str_sql += oPaciente.domicilio + "',";
            
            if (oPaciente.telefono == "")
            {
                str_sql += "NULL" + ",'";
            }
            else
            {
                str_sql += "'" + oPaciente.telefono + "','";

            }
            str_sql += oPaciente.obraSocial + "','S','";
            str_sql += tabla.Rows[0][0] + "')";

            MessageBox.Show(str_sql1);
            MessageBox.Show(str_sql);
            MessageBox.Show(tabla.Rows[0][0].ToString());

           
            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().EjecutarSQL(str_sql) == 1);
        }
       

        public bool update(Paciente oPaciente)
        {
            string str_sql;
            str_sql = "UPDATE Pacientes SET nombre = '";
            str_sql += oPaciente.nombre + "', apellido = '";
            str_sql += oPaciente.apellido + "' , fechaNac = '";
            str_sql += oPaciente.fechaNacimiento + "' , tipoDocumento = '";
            str_sql += oPaciente.cod_tipoDoc + "' , nroDocumento = '";
            str_sql += oPaciente.nroDocumento + "', domicilio = '";
            str_sql += oPaciente.domicilio + "' , telefono = ";
            if (oPaciente.telefono == "")
            {
                str_sql += "NULL" + ",";
            }
            else
            {
                str_sql += "'" + oPaciente.telefono + "',";
            }
            str_sql += " obraSocial = '";
            str_sql += oPaciente.obraSocial + "' , estado = '";
            str_sql += oPaciente.estado + "'";


            str_sql += " WHERE id_paciente = " + oPaciente.id_paciente.ToString();

            MessageBox.Show(str_sql);

            
            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().EjecutarSQL(str_sql) == 1);
            
        }

        // Función auxiliar responsable de MAPPEAR una fila de Pacientes a un objeto Paciente
        private Paciente map_paciente(DataRow row)
        {
            Paciente oPaciente = new Paciente();

           
            oPaciente.id_paciente = Convert.ToInt32(row["id_paciente"].ToString());
            oPaciente.nombre = row["nombre"].ToString();
            oPaciente.apellido = row["apellido"].ToString();
            oPaciente.fechaNacimiento = row["fechaNac"].ToString();
            oPaciente.tipoDocumento = row["n_tipo"].ToString();
            oPaciente.nroDocumento = row["nroDocumento"].ToString();
            oPaciente.domicilio = row["domicilio"].ToString();
            oPaciente.telefono = row["telefono"].ToString();
            oPaciente.obraSocial = row["obraSocial"].ToString();
            oPaciente.estado = row["estado"].ToString();
            return oPaciente;
        }
          

    }
}
