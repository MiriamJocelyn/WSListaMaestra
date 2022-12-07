using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSListaMaestra.Models
{
	public class JsonLista
	{
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
	}
}