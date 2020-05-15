using DemoCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using DemoCoreApp.ViewModels;

namespace DemoCoreApp.DBAccess
{
    public class DBAccessRepo : IOwnerVehicleRepo
    {
        readonly AppDBAccess _dBAccess;

        public DBAccessRepo()
        {
            _dBAccess = new AppDBAccess();
        }

        public void UpsertVehicleInfo(Vehicle vehicle, int ownerId)
        {
            using (var connection = new SqlConnection(_dBAccess.sqlConnection))
            {
                SqlCommand cmd = new SqlCommand("[dbo].[UpSert_VehicleData]", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                cmd.Parameters.Add("@OwnerID", SqlDbType.Int).Value = ownerId;
                cmd.Parameters.Add("@Color", SqlDbType.NVarChar).Value = vehicle.Color;
                cmd.Parameters.Add("@Model", SqlDbType.NVarChar).Value = vehicle.Model;
                cmd.Parameters.Add("@Make", SqlDbType.NVarChar).Value = vehicle.Make;
                cmd.Parameters.Add("@RegistrationNumber", SqlDbType.NVarChar).Value = vehicle.RegistrationNumber;
                cmd.Parameters.Add("@VehicleID ", SqlDbType.Int).Value = (vehicle.VehicleId != null)? vehicle.VehicleId : 0;
                connection.Open();
                cmd.ExecuteReader();
                connection.Close();
            }
        }

        public OwnerVehicleViewModel GetOwnerVehicleInfo(string registrationNumber)
        {
            var viewModel = new OwnerVehicleViewModel();

            var Num = registrationNumber;
            using (var connection = new SqlConnection(_dBAccess.sqlConnection))
            {
                SqlCommand cmd = new SqlCommand("[dbo].[GetOwnerVehicleInfoByRegistrationNumber]", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                cmd.Parameters.Add("@RegistrationNumber", SqlDbType.NVarChar).Value = registrationNumber;
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        viewModel.Vehicle = MapVehicleInfo(reader);

                        viewModel.Owner = MapOwnerInfo(reader);
                    }
                }
                connection.Close();
            }
            return viewModel;
        }


        public List<Vehicle> GetAllVehicles()
        {
            var listOfVehicles = new List<Vehicle>();
            using (var conncetion = new SqlConnection(_dBAccess.sqlConnection))
            {
                SqlCommand cmd = new SqlCommand("[dbo].[GetAllVehicles]", conncetion)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                conncetion.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listOfVehicles.Add(MapVehicleInfo(reader));
                    }
                }
                conncetion.Close();
            }
            return listOfVehicles;
        }

        public void UpSertOwenrInfo(Owner owner)
        {
            var isSqlSuccessful = true;
            var connection = new SqlConnection(_dBAccess.sqlConnection);
            try
            {

                using (connection)
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[UpSert_OwnerData]", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    cmd.Parameters.Add("@OwnerID", SqlDbType.NVarChar).Value = owner.Id;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = owner.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = owner.LastName;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = owner.PhoneNumber;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = owner.Email;
                    cmd.Parameters.Add("@UnitNumber ", SqlDbType.NVarChar).Value = owner.UnitNumber;
                    cmd.Parameters.Add("@ApartmentNumber ", SqlDbType.NVarChar).Value = owner.ApartmentNumber;
                    connection.Open();
                    cmd.ExecuteReader();
                    //connection.Close();
                }
            }
            catch (SqlException ex)
            {
                isSqlSuccessful = false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public int ValidateOwnerInfo(string email, string apartmentNum)
        {
            int ownerId = 0;
            using (var connection = new SqlConnection(_dBAccess.sqlConnection))
            {
                SqlCommand cmd = new SqlCommand("[dbo].[ValidateOwnerInfo]", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@ApartmentNumber", SqlDbType.NVarChar).Value = apartmentNum;
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ownerId = reader["OwnerId"] != DBNull.Value ? Convert.ToInt32(reader["OwnerId"]) : 0;
                    }
                }
                connection.Close();
            }
            return ownerId;
        }

        //public bool Login(string email, string password)
        //{
        //    bool IsValid = false;
        //    var connection = new SqlConnection(_dBAccess.sqlConnection);
        //    try
        //    {

        //        using (connection)
        //        {
        //            SqlCommand cmd = new SqlCommand("[dbo].[Login]", connection)
        //            {
        //                CommandType = CommandType.StoredProcedure,
        //            };
        //            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
        //            cmd.Parameters.Add("@Password ", SqlDbType.NVarChar).Value = password;
        //            cmd.Parameters.Add("@IsValid", SqlDbType.Bit).Direction = ParameterDirection.Output;
        //            connection.Open();
        //            cmd.ExecuteReader();
        //            IsValid = Convert.ToBoolean(cmd.Parameters["@IsValid"].Value);
        //            connection.Close();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {

        //    }
        //    finally
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //    }
        //    return IsValid;
        //}

        public int Login(string email, string password)
        {
            int ownerId = 0;
            var connection = new SqlConnection(_dBAccess.sqlConnection);
            try
            {

                using (connection)
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[Login]", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                    cmd.Parameters.Add("@Password ", SqlDbType.NVarChar).Value = password;
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ownerId = reader["OwnerId"] != DBNull.Value ? Convert.ToInt32(reader["OwnerId"]) : 0;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return ownerId;
        }

        public Vehicle GetVehicleInfo(int vehicleId)
        {
            var vehicle = new Vehicle();
            using (var connection = new SqlConnection(_dBAccess.sqlConnection))
            {
                SqlCommand cmd = new SqlCommand("[dbo].[GetVehicleInfo]", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                cmd.Parameters.Add("@VehicleID ", SqlDbType.Int).Value = vehicleId;
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vehicle = MapVehicleInfo(reader);
                    }
                }
                connection.Close();
            }
            return vehicle;
        }

        public Vehicle MapVehicleInfo(IDataReader reader)
        {
            var vehicle = new Vehicle()
            {
                VehicleId = reader["VehicleId"] is DBNull ? 0 : Convert.ToInt32(reader["VehicleId"]),
                Make = reader["Make"] is DBNull ? string.Empty : Convert.ToString(reader["Make"]),
                Color = reader["Color"] is DBNull ? string.Empty : Convert.ToString(reader["Color"]),
                Model = reader["Model"] is DBNull ? string.Empty : Convert.ToString(reader["Model"]),
                RegistrationNumber = reader["RegistrationNumber"] is DBNull ? string.Empty : Convert.ToString(reader["RegistrationNumber"]),
                RegistrationDate = Convert.ToDateTime(reader["RegistrationDate"]),
                VehicleOwnerId = reader["OwnerId"] is DBNull ? 0 : Convert.ToInt32(reader["OwnerId"]),
            };
            return vehicle;
        }

        public Owner MapOwnerInfo(IDataReader reader)
        {
            var owner = new Owner()
            {
                FirstName = reader["FirstName"] is DBNull ? string.Empty : Convert.ToString(reader["FirstName"]),
                LastName = reader["LastName"] is DBNull ? string.Empty : Convert.ToString(reader["LastName"]),
                ApartmentNumber = reader["ApartmentNumber"] is DBNull ? string.Empty : Convert.ToString(reader["ApartmentNumber"]),
                Email = reader["Email"] is DBNull ? string.Empty : Convert.ToString(reader["Email"]),
                PhoneNumber = reader["PhoneNumber"] is DBNull ? string.Empty : Convert.ToString(reader["PhoneNumber"]),
                UnitNumber = reader["FirstName"] is DBNull ? string.Empty : Convert.ToString(reader["UnitNumber"]),
                Id = reader["OwnerId"] is DBNull ? 0 : Convert.ToInt32(reader["OwnerId"])
            };
            return owner;
        }
    }
}
