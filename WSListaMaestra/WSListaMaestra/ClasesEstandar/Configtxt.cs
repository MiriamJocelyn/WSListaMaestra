using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSListaMaestra.ClasesEstandar
{
	public class Configtxt
	{
		public class ObjetoAccesos
		{
			private string sapServidor = string.Empty;
			private string sapBase = string.Empty;
			private string sapUser = string.Empty;
			private string sapPass = string.Empty;
			private string SapSqlServer = string.Empty;
			private string SapSqlUser = string.Empty;
			private string SapSqlPass = string.Empty;
			private string SqlServidor = string.Empty;
			private string DBuser = string.Empty;
			private string DBpass = string.Empty;
			private string DBName = string.Empty;
			private string LicenseServer = string.Empty;
			private string SLDServer = string.Empty;

			public string SapServidor
			{
				get { return sapServidor; }
				set { sapServidor = value; }
			}
			public string SapBase
			{
				get { return sapBase; }
				set { sapBase = value; }
			}
			public string SapUser
			{
				get { return sapUser; }
				set { sapUser = value; }
			}
			public string SapPass
			{
				get { return sapPass; }
				set { sapPass = value; }
			}
			public string sapSqlServer
			{
				get { return SapSqlServer; }
				set { SapSqlServer = value; }
			}
			public string sapSqlUser
			{
				get { return SapSqlUser; }
				set { SapSqlUser = value; }
			}
			public string sapSqlPass
			{
				get { return SapSqlPass; }
				set { SapSqlPass = value; }
			}
			public string sqlServidor
			{
				get { return SqlServidor; }
				set { SqlServidor = value; }
			}
			public string dBuser
			{
				get { return DBuser; }
				set { DBuser = value; }
			}
			public string dBpass
			{
				get { return DBpass; }
				set { DBpass = value; }
			}
			public string dbName
			{
				get { return DBName; }
				set { DBName = value; }
			}
			public string licenseServer
			{
				get { return LicenseServer; }
				set { LicenseServer = value; }
			}
			public string sLDServer
			{
				get { return SLDServer; }
				set { SLDServer = value; }
			}
		}
		static public List<ObjetoAccesos> ObtencionAccesos(string rutaArchivoCfg)
		{
			Configtxt.ObjetoAccesos oAccesos = new Configtxt.ObjetoAccesos();
			List<Configtxt.ObjetoAccesos> oAccesosList = new List<Configtxt.ObjetoAccesos>();
			string sLine;
			int i = 0;
			System.IO.StreamReader file = new System.IO.StreamReader(rutaArchivoCfg);

			try
			{
				while ((sLine = file.ReadLine()) != null)
				{
					if (sLine.Contains("SapServidor"))
					{
						i = sLine.IndexOf(':');
						oAccesos.SapServidor = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SapBase"))
					{
						i = sLine.IndexOf(':');
						oAccesos.SapBase = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SapUser"))
					{
						i = sLine.IndexOf(':');
						oAccesos.SapUser = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SapPass"))
					{
						i = sLine.IndexOf(':');
						oAccesos.SapPass = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SapSqlServer"))
					{
						i = sLine.IndexOf(':');
						oAccesos.sapSqlServer = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SapSqlUser"))
					{
						i = sLine.IndexOf(':');
						oAccesos.sapSqlUser = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SapSqlPass"))
					{
						i = sLine.IndexOf(':');
						oAccesos.sapSqlPass = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SqlServidor"))
					{
						i = sLine.IndexOf(':');
						oAccesos.sqlServidor = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("DBuser"))
					{
						i = sLine.IndexOf(':');
						oAccesos.dBuser = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("DBpass"))
					{
						i = sLine.IndexOf(':');
						oAccesos.dBpass = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("DBName"))
					{
						i = sLine.IndexOf(':');
						oAccesos.dbName = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("LicenseServer"))
					{
						i = sLine.IndexOf(':');
						oAccesos.licenseServer = sLine.Substring(i + 1);
					}
					else if (sLine.Contains("SLDServer"))
					{
						i = sLine.IndexOf(':');
						oAccesos.sLDServer = sLine.Substring(i + 1);
					}
					oAccesosList.Add(oAccesos);
				}//While de lectura
			}
			catch (Exception e)
			{
				System.Console.WriteLine("Excepcion al obtener accesos del archivo Config: " + e);
			}
			finally
			{
				file.Close();
			}
			return oAccesosList;
		}
	}
}