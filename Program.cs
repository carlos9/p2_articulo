/*
 * Created by SharpDevelop.
 * User: Choche
 * Date: 03/10/2014
 * Time: 11:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p2_articulo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Dame la cantidad del Producto 1:");
			int pro1 = int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la Descripcion del producto 1:");
			string des1 = Console.ReadLine();
			Console.WriteLine("Dame el Precio Unitario del producto 1:");
			int  pre1 = int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la cantidad del Producto 2:");
			int pro2 = int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la Descripcion 2:");
			string des2 = Console.ReadLine();
			Console.WriteLine("Dame el Precio Unitario 2:");
			int  pre2 = int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la cantidad del Producto 3:");
			int pro3= int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la Descripcion 3:");
			string des3= Console.ReadLine();
			Console.WriteLine("Dame el Precio Unitario 3:");
			int  pre3= int.Parse( Console.ReadLine());
			int resul1 = pre1*pro1;
			int resul2 = pre2*pro2;
			int resul3 = pre3*pro3;
			
			
			Console.WriteLine(" " +pro1+ "  " + des1 + "  " + resul1);
			Console.WriteLine(" " +pro2+ "  " + des2 + "  " + resul2);
			Console.WriteLine(" " +pro3+ "  " + des3 + "  " + resul3);
		
			
			int subt = resul1+resul2+resul3;
			Double iva = subt * 0.16;
			Double total = subt + iva;
			
			Console.WriteLine(" Subtotal =" +subt);
			Console.WriteLine(" Iva =" +iva);
			Console.WriteLine(" Total =" +total);
			Console.ReadKey(true);
			
			Console.WriteLine("Gracias por su preferencia!!!");
			
		}
	}
}