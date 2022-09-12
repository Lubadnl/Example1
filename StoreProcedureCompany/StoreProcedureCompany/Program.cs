using System.Data.SqlClient;
using System.Data;

SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
SqlCommand com = new SqlCommand("CompanyNameForCustId", cn);
com.CommandType = CommandType.StoredProcedure;

SqlParameter p1 = new SqlParameter("@custid", SqlDbType.NChar);
p1.Value = "ANATR";
com.Parameters.Add(p1);

com.Parameters.Add(new SqlParameter("@compname", SqlDbType.NVarChar, 40));
com.Parameters[1].Direction = ParameterDirection.Output;
cn.Open();

com.ExecuteNonQuery();
Console.WriteLine(com.Parameters["@compname"].Value);

cn.Close();