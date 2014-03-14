using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace XamarinA
{
	public class AccountCore
	{
		public static IDictionary<string, string> Dictionary(string FName, string LName, string Age, string Email)
		{
			IDictionary<string, string> d = new Dictionary<string, string> ();
			d.Add ("FName",FName);
			d.Add ("LName", LName);
			d.Add ("Age",Age);
			d.Add ("Email",Email);
			return d;
		}
	}
}