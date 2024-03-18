﻿using BarcodePrint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BarcodePrint._Repositories
{
    public class DefectRepository : BaseRepository, IDefectRepository
    {
        //Constructor
        public DefectRepository(string connetionString) 
        { 
            this.connectionString = connetionString;
        }

        //Methods
        public void Add(DefectModel defectmodel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Defect_Names values (@Id, @PartId @DefectName)";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = defectmodel.Id1;
                command.Parameters.Add("@PartId", SqlDbType.VarChar).Value = defectmodel.PartId1;
                command.Parameters.Add("@DefectName", SqlDbType.VarChar).Value = defectmodel.DefectName1;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE from Defect_Names WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(DefectModel defectmodel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Defect_Names set Id=@Id, PartId=@PartId, DefectName=@DefectName WHERE Id=@Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = defectmodel.Id1;
                command.Parameters.Add("@PartId", SqlDbType.VarChar).Value=defectmodel.PartId1;
                command.Parameters.Add("@DefectName", SqlDbType.VarChar).Value = defectmodel.DefectName1;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<DefectModel> GetAll()
        {
            var defectList = new List<DefectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * from Defect_Names ORDER BY Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var defectModel = new DefectModel();
                        defectModel.Id1 = (int)reader[0];
                        defectModel.PartId1 = reader[1].ToString();
                        defectModel.DefectName1 = reader[2].ToString();
                        defectList.Add(defectModel);
                    }

                }
            }

            return defectList;
        }

        public IEnumerable<DefectModel> GetByValue(string value)
        {
            var defectList = new List<DefectModel>();
            int defectId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string defectName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * from Defect_Names 
                                        WHERE Id = @Id OR DefectName like @DefectName+'%'
                                        ORDER BY Id desc";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = defectId;
                command.Parameters.Add("@DefectName", SqlDbType.VarChar).Value = defectName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var defectModel = new DefectModel();
                        defectModel.Id1 = (int)reader[0];
                        defectModel.PartId1 = reader[1].ToString();
                        defectModel.DefectName1 = reader[2].ToString();
                        defectList.Add(defectModel);
                    }

                }
            }

            return defectList;
        }
    }
}
