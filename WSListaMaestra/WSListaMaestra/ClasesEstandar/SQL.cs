using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WSListaMaestra.Controllers;

namespace WSListaMaestra.ClasesEstandar
{
	public class SQL
	{
		public Conexion con = new Conexion();
		public DataSet Procedimiento(string nombre, SqlParameter[] parametros)
		{
			List<Configtxt.ObjetoAccesos> ListaAccesos = new List<Configtxt.ObjetoAccesos>();
			ListaAccesos = Configtxt.ObtencionAccesos(ListaMaestraController.Archivocfg);

			SqlConnection conn = new SqlConnection("Server=" + ListaAccesos[0].sqlServidor+";Database="+ ListaAccesos[0].dbName+";Uid="+ ListaAccesos[0].dBuser+";Pwd="+ ListaAccesos[0].dBpass);

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = nombre;
			cmd.Connection = conn;
			cmd.Parameters.AddRange(parametros);
			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter(cmd);

			da.Fill(ds);
			return ds;
		}
		public void ConvertFromDataTable<TTarget>(DataTable sourceData, DataRow rowData, TTarget targetData)
		{
			var sourceProps = typeof(TTarget).GetProperties().Where(x => x.CanWrite && sourceData.Columns.Contains(x.Name)).ToList();
			var destProps = typeof(TTarget).GetProperties().Where(x => x.CanWrite).ToList();

			foreach (var sourceProp in sourceProps)
			{
				if (destProps.Any(x => x.Name == sourceProp.Name))
				{
					var p = destProps.First(x => x.Name == sourceProp.Name);
					if (p.CanWrite)
						p.SetValue(targetData, rowData[sourceProp.Name], null);
				}
			}
		}

	}
}