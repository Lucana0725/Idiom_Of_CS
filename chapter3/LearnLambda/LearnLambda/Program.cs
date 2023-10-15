using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LearnLambda {
	internal static class Program {
		static void Main(string[] args) {
			var word = "gateman";
			var result = word.Reverse();
			Console.WriteLine(result);
			
		}
		
		public static string Reverse(this string str) {
			if (string.IsNullOrWhiteSpace(str)) { return string.Empty; }
			char[] chars = str.ToCharArray();
			Array.Reverse(chars);
			return new string(chars);
		}
	}
}
