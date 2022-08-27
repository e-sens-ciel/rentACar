using DAL;
using Microsoft.Data.SqlClient;
using MODELS.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LoginCheckQuery
    {
        //private readonly CarContext _carContext;

        //public LoginCheckQuery(CarContext carContext)
        //{
        //    _carContext = carContext;

        //}

        SqlConnection con = new SqlConnection("Data Source = ZOULI\\SQLSERVER; Initial Catalog = RentACar; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public int LoginCheck(Client ad)
        {
            SqlCommand com = new SqlCommand("SP_Client", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Email", ad.Email);
            com.Parameters.AddWithValue("@MotDePasse", ad.MotDePasse);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}
