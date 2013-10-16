using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqSample
{
	#region ClasePrincipal
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<EntidadUsuarios> listadatos = new List<EntidadUsuarios> ();
			string Nombre="", APaterno="", AMaterno="";
			int Edad=0;
			bool ingresar = true;
			Console.WriteLine ("---Ejemplo uso Linq---");
			while (ingresar) {
				Console.WriteLine ("Ingresa Nombre (string)");
				Nombre = Console.ReadLine ();
				Console.WriteLine ("Ingresa A. Paterno (string)");
				APaterno = Console.ReadLine ();
				Console.WriteLine ("Ingresa A. Materno (string)");
				AMaterno = Console.ReadLine ();
				Console.WriteLine ("Ingresa Edad (int)");
				Edad = int.Parse(Console.ReadLine ());
				EntidadUsuarios usuario = new EntidadUsuarios ();
				usuario.Nombre = Nombre;
				usuario.APaterno = APaterno;
				usuario.AMaterno = AMaterno;
				usuario.Edad = Edad;
				listadatos.Add (usuario);
				bool correcto=false;
				while (!correcto) {
					Console.WriteLine ("Deseas ingresar un nuevo registro S/N");
					string res = Console.ReadLine ().ToUpper();
					if (res == "S") {
						ingresar = true;
						correcto = true;
					} else if (res == "N") {
						ingresar = false;
						correcto = true;
					} else {
						correcto = false;
					}
				}
			}
			Console.WriteLine ("");
			Console.WriteLine ("Ordenados Por Nombre");
			var OrdenadosNombre = (from p in listadatos select p).OrderBy(c => c.Nombre);
			foreach (EntidadUsuarios x in OrdenadosNombre) {
				Console.WriteLine (x.Nombre+" "+x.APaterno+" "+x.AMaterno+" "+x.Edad);
			}


			Console.WriteLine ("");
			Console.WriteLine ("Ordenados Por Edad");
			var OrdenadosEdad = (from p in listadatos select p).OrderBy(c => c.Edad);
			foreach (EntidadUsuarios x in OrdenadosEdad) {
				Console.WriteLine (x.Nombre+" "+x.APaterno+" "+x.AMaterno+" "+x.Edad);
			}


			Console.WriteLine ("");
			Console.WriteLine ("Mayores de Edad");
			var MayoresdeEdad = from p in listadatos where p.Edad >= 18 select p;
			foreach (EntidadUsuarios x in MayoresdeEdad) {
				Console.WriteLine (x.Nombre+" "+x.APaterno+" "+x.AMaterno+" "+x.Edad);
			}


			Console.ReadLine ();
		}
	}
	#endregion
	#region EntidadUsuario
	public class EntidadUsuarios
	{
		public string Nombre{ get; set;}
		public string APaterno { get; set;}
		public string AMaterno{ get; set;}
		public int Edad { get; set;}
	}
	#endregion
}
