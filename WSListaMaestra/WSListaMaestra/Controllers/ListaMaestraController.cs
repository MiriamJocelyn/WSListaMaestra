using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WSListaMaestra.Models;
using static WSListaMaestra.Models.JsonLista;

namespace WSListaMaestra.Controllers
{
	[EnableCors("*", "*", "*")]
	public class ListaMaestraController : ApiController
	{
		public static string Archivocfg = @"C:\Glasfirma\ListaMaestra\Config.cfg";
		public static string rutaArchivoLog = @"C:\Glasfirma\ListaMaestra";

		[HttpPost]
		[Route("ListaM/ConsultaNivel")]
		public List<Nivel> ConsultaNivel()
		{
			ProcesoLista nivel = new ProcesoLista();

			return nivel.ConsultaNivel();
		}
		[HttpPost]
		[Route("ListaM/ConsultaArea")]
		public List<Area> ConsultaArea()
		{
			ProcesoLista area = new ProcesoLista();

			return area.ConsultaArea();
		}
		[HttpPost]
		[Route("ListaM/ConsultaLista")]
		public List<ListaMaestra> ConsultaLista(JsonListaM Doc)
		{
			ProcesoLista lista = new ProcesoLista();

			return lista.ConsultaLista(Doc);
		}


	}

}