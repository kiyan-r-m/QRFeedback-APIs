using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;


namespace QR_Feedback.Models
{
    public class adminDataAccessLayer
    {
        private IConfiguration Configuration;

        public adminDataAccessLayer(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IEnumerable<Districts> GetDistricts()
        {
            List<Districts> data = new List<Districts>();
            using (SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("QRDB")))
            {
                SqlCommand cmd = new SqlCommand("getDistricts", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Districts district = new Districts();
                    district.DistrictId = Convert.ToInt32(rdr["districtID"]);
                    district.DistrictName = Convert.ToString(rdr["districtName"]);
                    data.Add(district);
                }
                con.Close();
            }
            return data;
        }

        public IEnumerable<Stations> getStations()
        {
            List<Stations> data = new List<Stations>();
            using (SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("QRDB")))
            {
                SqlCommand cmd = new SqlCommand("getStations", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Stations station = new Stations();
                    station.PoliceStationId = Convert.ToInt32(rdr["policeStationID"]);
                    station.Area = Convert.ToString(rdr["area"]);
                    station.District = Convert.ToString(rdr["districtName"]);
                    station.SubDivision = Convert.ToString(rdr["subDivisionName"]);
                    data.Add(station);
                }
                con.Close();
            }
            return data;
        }

        public IEnumerable<Stations> getStationsBySubdivision(int id)
        {
            List<Stations> data = new List<Stations>();
            using (SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("QRDB")))
            {
                SqlCommand cmd = new SqlCommand("getStationsBySubdivision", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@subdivisionid", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Stations station = new Stations();
                    station.PoliceStationId = Convert.ToInt32(rdr["policeStationID"]);
                    station.Area = Convert.ToString(rdr["area"]);
                    data.Add(station);
                }
                con.Close();
            }
            return data;
        }

        public IEnumerable<Subdivisions> getSubDivisionsByDistrict(int id)
        {
            List<Subdivisions> data = new List<Subdivisions>();
            using (SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("QRDB")))
            {
                SqlCommand cmd = new SqlCommand("getSubDivisionsByDistrict", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@districtid", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Subdivisions subdivision = new Subdivisions();
                    subdivision.SubDivisionId = Convert.ToInt32(rdr["subDivisionID"]);
                    subdivision.SubDivisionName = Convert.ToString(rdr["subDivisionName"]);
                    data.Add(subdivision);
                }
                con.Close();
            }
            return data;
        }

        public int deleteDistrict(int id)
        {
            using (SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("QRDB")))
            {
                SqlCommand cmd = new SqlCommand("deleteDistricts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@districtID", id);
                con.Open();
                int check = cmd.ExecuteNonQuery();
                con.Close();
                return check;


            }
        }

    }
}
