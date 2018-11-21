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
    public class PrestacionDao
    {
      

        public Prestacion getPrestacionBycod(string cod_prestacion)
        {
            string sql = "Select * from Prestaciones where  cod_prestacion = '" + cod_prestacion + "'";
            DataTable oTabla;
            Prestacion oPrestacion = null/* TODO Change to default(_) if this is not a reference type */;

            oTabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (oTabla.Rows.Count > 0)
                oPrestacion = map_presta(oTabla.Rows[0]);

            return oPrestacion;
        }


       
        public IList<Prestacion> getAll()
        {
            List<Prestacion> lst = new List<Prestacion>();
            string sql = "Select * from Prestaciones ";
            Prestacion oPrestacion = null/* TODO Change to default(_) if this is not a reference type */;

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
                lst.Add(map_presta(row));

            return lst;
        }

       
        public IList<Prestacion> getByFilters(List<object> @params)
        {
            List<Prestacion> lst = new List<Prestacion>();
            string sql = "Select * from Prestaciones WHERE";
            Prestacion oPrestacion = null/* TODO Change to default(_) if this is not a reference type */;

            if (@params[0] != null)
                sql += " cod_prestacion LIKE '%' + @param1 + '%' ";

            if (@params[1] != null)
                sql += " nombre LIKE  @param2 + '%' ";
           

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQLConParametros(sql, @params).Rows)
                lst.Add(map_presta(row));

            return lst;
        }

        // Funciones CRUD
        public bool create(Prestacion oPrestacion)
        {
            string str_sql;

            str_sql = "INSERT INTO Prestaciones ( cod_prestacion, nombre, descripcion) VALUES('";
            str_sql += oPrestacion.cod_prestacion + "','";
            str_sql += oPrestacion.nombre + "','";
            str_sql += oPrestacion.descripcion +"')";
            MessageBox.Show(str_sql);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().EjecutarSQL(str_sql) == 1);
        }
        // Funciones CRUD

        public bool update(Prestacion oPrestacion)
        {
            string str_sql;

           str_sql = "UPDATE Prestaciones SET cod_prestacion = '";
            str_sql += oPrestacion.cod_prestacion + "', nombre = '";
            str_sql += oPrestacion.nombre + "' , descripcion = '";
            str_sql += oPrestacion.descripcion + "'";
            str_sql += " WHERE id_prestacion = " + oPrestacion.id_prestacion.ToString();

           MessageBox.Show(str_sql);
            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().EjecutarSQL(str_sql) == 1);
            

        }

        // Función auxiliar responsable de MAPPEAR una fila de Prestacions a un objeto Prestacion
        private Prestacion map_presta(DataRow row)
        {
            Prestacion oPrestacion = new Prestacion();

            oPrestacion.id_prestacion = Convert.ToInt32(row["id_prestacion"].ToString());
            oPrestacion.cod_prestacion = row["cod_prestacion"].ToString(); 
            oPrestacion.nombre = row["nombre"].ToString();
            oPrestacion.descripcion = row["descripcion"].ToString();
            
            return oPrestacion;
        }
    }



}
