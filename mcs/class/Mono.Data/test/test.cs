using System;
using System.Data;
using System.Data.SqlClient;
using Mono.Data;

namespace testclient
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{

		public static void TestProviderFactory()
		{
			Console.WriteLine("Get Connection");
			IDbConnection conn=ProviderFactory.CreateConnectionFromConfig("PubsConnStr");
		 	Console.WriteLine("Open Connection");	
			conn.Open();
			IDbCommand cmd=conn.CreateCommand();
			cmd.CommandText="select * from authors";
			IDataReader reader=cmd.ExecuteReader();			
			reader.Read();
			Console.WriteLine(reader[0].ToString());
			Console.ReadLine();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			TestProviderFactory();

		}
	}
}
