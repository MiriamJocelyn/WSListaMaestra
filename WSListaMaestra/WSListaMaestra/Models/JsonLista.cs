using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WSListaMaestra.Models
{
	public class JsonLista
	{
		[DataContract]
		public class JsonNivel
		{
			public int nivel { get; set; }
		}
		public class JsonArea
		{
			public string area { get; set; }
		}
		public class JsonListaM
		{
			public string estatus { get; set; }
			public int nivel { get; set; }
			public string area { get; set; }
		}
		public class JsonUpdate
		{
			public string codigo { get; set; }
			public string elaboracion { get; set; }
			public string revision { get; set; }
			public string aprobado { get; set; }
			public string difusion { get; set; }
		}
		public class UpdateLista
		{
			[DataMember(Name = "Codigo")]
			public string Codigo { get; set; }
			[DataMember(Name = "Descripcion")]
			public string Descripcion { get; set; }
		}
	}
}