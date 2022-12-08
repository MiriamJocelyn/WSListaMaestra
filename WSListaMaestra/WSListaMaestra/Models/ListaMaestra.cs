using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSListaMaestra.Models
{
	public class ListaMaestra
	{
		public string estatus { get; set; }
		public int nivel { get; set; }
		public string area { get; set; }
		public string Doc { get; set; }
		public string Codigo { get; set; }
		public string Originador { get; set; }
		public string NomDocumento { get; set; }
		public DateTime FechaElaboracion { get; set; }
		public string RevisionActual { get; set; }
		public string Elaboracion { get; set; }
		public string RevisionAprobacion { get; set; }
		public string AprobadoInvolucrados { get; set; }
		public string Difusion { get; set; }
		public DateTime FechaUltimaRevision { get; set; }
		public string Observaciones { get; set; }
	}
}