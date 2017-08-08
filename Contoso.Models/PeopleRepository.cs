using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Contoso.Model;

namespace Contoso.Data
{
    public class PeopleRepository : IRepository<People>
    {
        public void CreateNew(People obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spCreatePeople1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@id", obj.ID);
            cmd.Parameters.AddWithValue("@LASTNAME", obj.LastName);
            cmd.Parameters.AddWithValue("@FIRSTNAME", obj.FirstName);
            cmd.Parameters.AddWithValue("@MIDDLENAME", obj.MiddleName);
            cmd.Parameters.AddWithValue("@AGE", obj.Age);

            cmd.Parameters.AddWithValue("@ADDRESSLINE1", obj.AddressLine1);

            cmd.Parameters.AddWithValue("@STATE", obj.State);


            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public void DeleteById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spDeleteById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public List<People> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spGetAll";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataReader rdr = cmd.ExecuteReader();
            List<People> lstPeople = new List<People>();
            while (rdr.Read())
            {
                People pl = new People();
                pl.ID = Convert.ToInt32(rdr["id"]);
                pl.LastName = rdr["LASTNAME"].ToString();
                pl.FirstName = rdr["FIRSTNAME"].ToString();
                pl.MiddleName = rdr["MIDDLENAME"].ToString();
                pl.Age = Convert.ToInt32(rdr["AGE"]);
                pl.Email = rdr["EMAIL"].ToString();
                pl.PhoneNo = rdr["PHONE"].ToString();
                pl.AddressLine1 = rdr["ADDRESSLINE1"].ToString();
                pl.AddressLine2 = rdr["ADDRESSLINE2"].ToString();
                pl.UnitOrApartmentNo = rdr["UNITORAPARTMENTNUMBER"].ToString();
                pl.City = rdr["CITY"].ToString();
                pl.State = rdr["state"].ToString();
                pl.Zipcode = rdr["ZIPCODE"].ToString();
                pl.Createddate = Convert.ToDateTime(rdr["CREATEDDATE"]);
                pl.CreatedBy = rdr["CREATEDBY"].ToString();
                pl.UpdateDate = Convert.ToDateTime(rdr["UPDATEDATE"]);
                pl.UpdatedBy = rdr["UPDATEDBY"].ToString();
                pl.Password = rdr["PASSWORD"].ToString();
                pl.Salt = rdr["SALT"].ToString();
                pl.Islocked = Convert.ToBoolean(rdr["ISLOCKED"]);
                pl.LastUpdateDate = Convert.ToDateTime(rdr["LASTLOCKEDDATETIME"]);
                pl.FailedAttempts = Convert.ToInt32(rdr["FAILEDATTEMPTS"]);
                lstPeople.Add(pl);
            }
            con.Close();

            cmd.Dispose();
            con.Dispose();

            return lstPeople;
        }

        public People GetById(int id)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            People pl = new People();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spGetPeopleById";
            cmd.CommandType = CommandType.StoredProcedure;   // second version
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader rdr = cmd.ExecuteReader();  
            pl.ID = Convert.ToInt32(rdr["id"]);
            pl.LastName = rdr["LASTNAME"].ToString();
            pl.FirstName = rdr["FIRSTNAME"].ToString();
            pl.MiddleName = rdr["MIDDLENAME"].ToString();
            pl.Age = Convert.ToInt32(rdr["AGE"]);
            pl.Email = rdr["EMAIL"].ToString();
            pl.PhoneNo = rdr["PHONE"].ToString();
            pl.AddressLine1 = rdr["ADDRESSLINE1"].ToString();
            pl.AddressLine2 = rdr["ADDRESSLINE2"].ToString();
            pl.UnitOrApartmentNo = rdr["UNITORAPARTMENTNUMBER"].ToString();
            pl.City = rdr["CITY"].ToString();
            pl.State = rdr["state"].ToString();
            pl.Zipcode = rdr["ZIPCODE"].ToString();
            pl.Createddate = Convert.ToDateTime(rdr["CREATEDDATE"]);
            pl.CreatedBy = rdr["CREATEDBY"].ToString();
            pl.UpdateDate = Convert.ToDateTime(rdr["UPDATEDATE"]);
            pl.UpdatedBy = rdr["UPDATEDBY"].ToString();
            pl.Password = rdr["PASSWORD"].ToString();
            pl.Salt = rdr["SALT"].ToString();
            pl.Islocked = Convert.ToBoolean(rdr["ISLOCKED"]);
            pl.LastUpdateDate = Convert.ToDateTime(rdr["LASTLOCKEDDATETIME"]);
            pl.FailedAttempts = Convert.ToInt32(rdr["FAILEDATTEMPTS"]);
                        
            con.Close();

            cmd.Dispose();
            con.Dispose();

            return pl;
        }

        public void Update(People obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@id", obj.ID);
            cmd.Parameters.AddWithValue("@LASTNAME", obj.LastName);
            cmd.Parameters.AddWithValue("@FIRSTNAME", obj.FirstName);
            cmd.Parameters.AddWithValue("@MIDDLENAME", obj.MiddleName);
            cmd.Parameters.AddWithValue("@AGE", obj.Age);
            cmd.Parameters.AddWithValue("@EMAIL", obj.Email);
            cmd.Parameters.AddWithValue("@PHONE", obj.PhoneNo);
            cmd.Parameters.AddWithValue("@ADDRESSLINE1", obj.AddressLine1);
            cmd.Parameters.AddWithValue("@ADDRESSLINE2", obj.AddressLine2);
            cmd.Parameters.AddWithValue("@UNITORAPARTMENTNUMBER", obj.UnitOrApartmentNo);
            cmd.Parameters.AddWithValue("@CITY", obj.City);
            cmd.Parameters.AddWithValue("@STATE", obj.State);
            cmd.Parameters.AddWithValue("@ZIPCODE", obj.Zipcode);
            cmd.Parameters.AddWithValue("@CREATEDDATE", obj.Createddate);
            cmd.Parameters.AddWithValue("@CREATEDBY", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@UPDATEDATE", obj.UpdateDate);
            cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UpdatedBy);
            cmd.Parameters.AddWithValue("@PASSWORD", obj.Password);
            cmd.Parameters.AddWithValue("@SALT", obj.Salt);
            cmd.Parameters.AddWithValue("@ISLOCKED", obj.Islocked);
            cmd.Parameters.AddWithValue("@LASTLOCKEDDATETIME", obj.LastUpdateDate);
            cmd.Parameters.AddWithValue("@FAILEDATTEMPTS", obj.FailedAttempts);
        }


    }
}
