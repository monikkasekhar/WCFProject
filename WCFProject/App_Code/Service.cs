using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	Connectionclass obj = new Connectionclass();

	public string balancecheck(string accno)
    {
		string sel = "select Balance_Amount from Account_Tab where Account_Number='"+accno+"'";
		SqlDataReader dr = obj.Fn_ExeReader(sel);
		string bal = "";
		while(dr.Read())
        {
			bal = dr["Balance_Amount"].ToString();

        }
		return bal;
    }
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
