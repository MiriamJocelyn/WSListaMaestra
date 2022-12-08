using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using WSListaMaestra.ClasesEstandar;
using static WSListaMaestra.Models.JsonLista;

namespace WSListaMaestra.Models
{
	public class ProcesoLista
	{
		public Conexion conSAP = new Conexion();
		public SQL sql = new SQL();

		public List<Nivel> ConsultaNivel()
		{
			List<Nivel> data = new List<Nivel>();
			DataSet ds = new DataSet();
			ds = conSAP.Procedimiento("dbo.sPNivel", null);
			using (DataTable temp = ds.Tables[0])
			{
				if (temp.Rows.Count > 0)
				{
					foreach (DataRow row in temp.Rows)
					{
						Nivel res = new Nivel();
						sql.ConvertFromDataTable<Nivel>(temp, row, res);
						data.Add(res);
					}
				}
			}
			return data;
		}
		public List<Area> ConsultaArea()
		{
			List<Area> data = new List<Area>();
			DataSet ds = new DataSet();
			ds = conSAP.Procedimiento("dbo.sPArea", null);
			using (DataTable temp = ds.Tables[0])
			{
				if (temp.Rows.Count > 0)
				{
					foreach (DataRow row in temp.Rows)
					{
						Area res = new Area();
						sql.ConvertFromDataTable<Area>(temp, row, res);
						data.Add(res);
					}
				}
			}
			return data;
		}
		public List<ListaMaestra> ConsultaLista(JsonListaM json)
		{
			List<ListaMaestra> lista = new List<ListaMaestra>();
			if (json != null)
			{
				//verificar el JSON
				var jsonString = new JavaScriptSerializer().Serialize(json);
				string estatus = json.estatus;
				int nivel = json.nivel;
				string area = json.area;

				SqlParameter[] param = new SqlParameter[3];
				param[0] = new SqlParameter("@estatus", SqlDbType.VarChar);
				param[1] = new SqlParameter("@nivel", SqlDbType.Int);
				param[2] = new SqlParameter("@area", SqlDbType.VarChar);
				param[0].Value = estatus;
				param[1].Value = nivel;
				param[2].Value = area;
				DataSet ds = new DataSet();
				ds = conSAP.Procedimiento("dbo.sPLista", param);
				using (DataTable temp = ds.Tables[0])
				{
					if (temp.Rows.Count > 0)
					{
						foreach (DataRow row in temp.Rows)
						{
							ListaMaestra res = new ListaMaestra();
							sql.ConvertFromDataTable<ListaMaestra>(temp, row, res);
							lista.Add(res);
						}
					}
				}

			}
			return lista;
		}
		public List<UpdateLista> Update(JsonUpdate json)
		{
			List<UpdateLista> lista = new List<UpdateLista>();
			if (json != null)
			{
				//verificar el JSON
				var jsonString = new JavaScriptSerializer().Serialize(json);
				string codigo = json.codigo;
				string elaboracion = json.elaboracion;
				string revision = json.revision;
				string aprobado = json.aprobado;
				string difusion = json.difusion;

				SqlParameter[] param = new SqlParameter[5];
				param[0] = new SqlParameter("@estatus", SqlDbType.VarChar);
				param[1] = new SqlParameter("@nivel", SqlDbType.Int);
				param[2] = new SqlParameter("@area", SqlDbType.VarChar);
				param[3] = new SqlParameter("@area", SqlDbType.VarChar);
				param[4] = new SqlParameter("@area", SqlDbType.VarChar);
				param[0].Value = codigo;
				param[1].Value = elaboracion;
				param[2].Value = revision;
				param[3].Value = aprobado;
				param[4].Value = difusion;
				DataSet ds = new DataSet();
				ds = conSAP.Procedimiento("dbo.sPUpdateLista", param);
				using (DataTable temp = ds.Tables[0])
				{
					if (temp.Rows.Count > 0)
					{
						foreach (DataRow row in temp.Rows)
						{
							UpdateLista res = new UpdateLista();
							sql.ConvertFromDataTable<UpdateLista>(temp, row, res);
							lista.Add(res);
						}
					}
				}

			}
			return lista;
		}
	}
}