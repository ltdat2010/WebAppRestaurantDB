using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Repositories
{

    public class UploadFileRepository
    {        
        SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RestaurantDBSQL"].ConnectionString);
        UploadFileRepository _uploadFileRepository;

        public void UploadfileRepository()
        {
            _uploadFileRepository = new UploadFileRepository();
        }

        [HttpGet]
        public IEnumerable<UploadFileViewModel> GetAll()
        {
            var ListUploadFile = new List<UploadFileViewModel>();

            SqlCommand _sqlCommand = new SqlCommand("GetAllUploadFile", _sqlConnection);
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlConnection.Open();
            SqlDataReader _sqlDataReader =  _sqlCommand.ExecuteReader();
            while(_sqlDataReader.Read())
            {
                UploadFileViewModel _uploadFile = new UploadFileViewModel();

                _uploadFile.UploadFileId = int.Parse(_sqlDataReader["UploadFileId"].ToString());
                _uploadFile.UploadFileName = _sqlDataReader["UploadFileName"].ToString();
                _uploadFile.UploadFilePath = _sqlDataReader["UploadFilePath"].ToString();
                _uploadFile.UploadFileVersion = _sqlDataReader["UploadFileVersion"].ToString();
                _uploadFile.SubCatagoryId = int.Parse(_sqlDataReader["SubCatagoryId"].ToString());
                _uploadFile.UploadFileImageBase64 = Convert.ToBase64String((byte[])_sqlDataReader["UploadFileImage"]);
                ListUploadFile.Add(_uploadFile);
            }

            return ListUploadFile;            
        }


    }
}