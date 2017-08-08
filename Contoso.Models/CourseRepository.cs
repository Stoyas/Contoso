using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Contoso.Model;

namespace Contoso.Data
{
    public class CourseRepository : IRepository<Courses>
    {
        public void CreateNew(Courses obj)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spCreateCourse";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.Parameters.AddWithValue("@TITLE", obj.Title);
            cmd.Parameters.AddWithValue("@CREDITS", obj.Credits);
            cmd.Parameters.AddWithValue("@DEPARTMENTID", obj.DepartmentId);
            cmd.Parameters.AddWithValue("@CREATEDDATE", obj.CreatedDate);
            cmd.Parameters.AddWithValue("@CREATEDBY", obj.CreatedBy);
            cmd.Parameters.AddWithValue("@UPDATEDDATE", obj.UpdateDate);
            cmd.Parameters.AddWithValue("@UPDATEDBY", obj.UpdatedBy);
            
            cmd.ExecuteNonQuery();
            con.Close();

            cmd.Dispose();
            con.Dispose();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Courses> GetAll()
        {
            throw new NotImplementedException();
        }

        public Courses GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Courses obj)
        {
            throw new NotImplementedException();
        }
    }
}
