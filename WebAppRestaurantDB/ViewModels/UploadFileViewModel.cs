using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppRestaurantDB.ViewModels
{
    public class UploadFileViewModel
    {
        public UploadFileViewModel()
        {

        }
        public int UploadFileId { get; set; }
        public string UploadFileName { get; set; }
        public string UploadFilePath { get; set; }
        public string UploadFileVersion { get; set; }
        public Nullable<int> SubCatagoryId { get; set; }
        public byte[] UploadFileImage { get; set; }
        public string UploadFileImageBase64 { get; set; }
        public HttpPostedFileBase httpPostedUploadFileImage { get; set; }
    }
}