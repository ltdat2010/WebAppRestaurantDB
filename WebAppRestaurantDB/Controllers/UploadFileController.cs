using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebAppRestaurantDB.Models;
using WebAppRestaurantDB.Repositories;
using WebAppRestaurantDB.ViewModels;

namespace WebAppRestaurantDB.Controllers
{
    public class UploadFileController : Controller
    {
        UploadFileRepository _uploadFileRepository = new UploadFileRepository();

        // GET: UploadFile
        public ActionResult IdxUploadFile()
        {
            //var files = Directory.GetFiles(Server.MapPath("~/Uploaded/pdf/"))
            //            .Where(f => Path.GetExtension(f).Equals(".pdf"))
            //            .Select(f => new { FileName = Path.GetFileName(f) });

            return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var AllObj = _uploadFileRepository.GetAll();
            return Json(new { data = AllObj }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UploadFile()
        {
            // Checking no of files injected in Request object  
            if (Request.Files.Count > 0)
            {
                try
                {
                    //  Get all files from Request object  
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        //string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";  
                        //string filename = Path.GetFileName(Request.Files[i].FileName);  

                        HttpPostedFileBase file = files[i];
                        string fname;

                        // Checking for Internet Explorer  
                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\' });
                            fname = testfiles[testfiles.Length - 1];
                        }
                        else
                        {
                            fname = file.FileName;
                        }

                        // Get the complete folder path and store the file inside it.  
                        fname = Path.Combine(Server.MapPath("~/Upload/pdf"), fname);
                        //fname = Path.Combine("C:/Users/dat.lt.IT-LAP-02/source/repos/WebAppRestaurantDB/WebAppRestaurantDB/Upload/", fname);
                        file.SaveAs(fname);
                    }
                    // Returns message that successfully uploaded  
                    return Json("File Uploaded Successfully!");
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selected.");
            }

        }

        [HttpPost]
        public JsonResult UploadFileImage(UploadFileViewModel uploadFileViewModel)
        {
            RestaurantDBEntities db = new RestaurantDBEntities();
            int imgId = 0;

            ////var file = model.UploadFileImageWrapper;
            ////  Get all files from Request object  
            //HttpFileCollectionBase files = Request.Files;
            //HttpPostedFileBase file = files[0];
            HttpPostedFileBase file = uploadFileViewModel.httpPostedUploadFileImage;

            byte[] imagebyte = null;
            if (file != null)
            {
                // Get the complete folder path and store the file inside it.  
                string fname = Path.Combine(Server.MapPath("~/Upload/img/temp"), file.FileName);
                file.SaveAs(fname);
                BinaryReader reader = new BinaryReader(file.InputStream);
                imagebyte = reader.ReadBytes(file.ContentLength);
                //Not use mapper
                //Using directly to Model
                UploadFile img = new UploadFile();
                img.UploadFileName = file.FileName;
                img.UploadFileImage = imagebyte;
                img.UploadFilePath = "/Upload/img/temp/" + file.FileName;
                img.UploadFileId = uploadFileViewModel.UploadFileId;
                img.SubCatagoryId = uploadFileViewModel.SubCatagoryId;
                img.UploadFileVersion = uploadFileViewModel.UploadFileVersion;
                //DBset
                db.UploadFiles.Add(img);
                db.SaveChanges();
                imgId = img.UploadFileId;
            }
            return Json(imgId, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DisplayingImage(int UploadFileId)
        {
            RestaurantDBEntities db = new RestaurantDBEntities();

            var img = db.UploadFiles.SingleOrDefault(x => x.UploadFileId == UploadFileId);
            return File(img.UploadFileImage, "image/jpg");
        }

        [HttpGet]
        public ActionResult GetAttachment(string Path)
        {
            var fileStream = new FileStream(Server.MapPath("~/Upload/pdf/Frontline.pdf"),
                                             FileMode.Open,
                                             FileAccess.Read
                                           );
            var fsResult = new FileStreamResult(fileStream, "application/pdf");
            return fsResult;
        }

    }
}