﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppRestaurantDB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RestaurantDBEntities : DbContext
    {
        public RestaurantDBEntities()
            : base("name=RestaurantDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PR> PRs { get; set; }
        public virtual DbSet<PRLine> PRLines { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<UploadFile> UploadFiles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VehicleMakeModel> VehicleMakeModels { get; set; }
        public virtual DbSet<VehicleModel> VehicleModels { get; set; }
        public virtual DbSet<MenuLeft> MenuLefts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    
        public virtual int CreateEmployees(string employeeCode, string firstName, string lastName, string emailID, string city, string country)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateEmployees", employeeCodeParameter, firstNameParameter, lastNameParameter, emailIDParameter, cityParameter, countryParameter);
        }
    
        public virtual int DeleteEmployees(string employeeCode)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmployees", employeeCodeParameter);
        }
    
        public virtual ObjectResult<GetAllEmployees_Result> GetAllEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllEmployees_Result>("GetAllEmployees");
        }
    
        public virtual ObjectResult<GetByCodeEmployees_Result> GetByCodeEmployees(string employeeCode)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByCodeEmployees_Result>("GetByCodeEmployees", employeeCodeParameter);
        }
    
        public virtual int LockedUsers(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LockedUsers", userNameParameter);
        }
    
        public virtual ObjectResult<string> LoginUsers(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoginUsers", userNameParameter);
        }
    
        public virtual int RegisterUsers(string userName, string passWord, Nullable<System.DateTime> createdDate, string createdBy, byte[] userImage, Nullable<bool> locked, string note, string socialAccount1, string socialAccount2, string socialAccount3, string socialAccount4)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            var userImageParameter = userImage != null ?
                new ObjectParameter("UserImage", userImage) :
                new ObjectParameter("UserImage", typeof(byte[]));
    
            var lockedParameter = locked.HasValue ?
                new ObjectParameter("Locked", locked) :
                new ObjectParameter("Locked", typeof(bool));
    
            var noteParameter = note != null ?
                new ObjectParameter("Note", note) :
                new ObjectParameter("Note", typeof(string));
    
            var socialAccount1Parameter = socialAccount1 != null ?
                new ObjectParameter("SocialAccount1", socialAccount1) :
                new ObjectParameter("SocialAccount1", typeof(string));
    
            var socialAccount2Parameter = socialAccount2 != null ?
                new ObjectParameter("SocialAccount2", socialAccount2) :
                new ObjectParameter("SocialAccount2", typeof(string));
    
            var socialAccount3Parameter = socialAccount3 != null ?
                new ObjectParameter("SocialAccount3", socialAccount3) :
                new ObjectParameter("SocialAccount3", typeof(string));
    
            var socialAccount4Parameter = socialAccount4 != null ?
                new ObjectParameter("SocialAccount4", socialAccount4) :
                new ObjectParameter("SocialAccount4", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegisterUsers", userNameParameter, passWordParameter, createdDateParameter, createdByParameter, userImageParameter, lockedParameter, noteParameter, socialAccount1Parameter, socialAccount2Parameter, socialAccount3Parameter, socialAccount4Parameter);
        }
    
        public virtual ObjectResult<SelectEmployees_Result> SelectEmployees(string employeeCode)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectEmployees_Result>("SelectEmployees", employeeCodeParameter);
        }
    
        public virtual int UnLockedUsers(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UnLockedUsers", userNameParameter);
        }
    
        public virtual int UpdateEmployees(string employeeCode, string firstName, string lastName, string emailID, string city, string country)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmployees", employeeCodeParameter, firstNameParameter, lastNameParameter, emailIDParameter, cityParameter, countryParameter);
        }
    
        public virtual int CreateEmployee(string employeeCode, string firstName, string lastName, string emailID)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateEmployee", employeeCodeParameter, firstNameParameter, lastNameParameter, emailIDParameter);
        }
    
        public virtual int DeleteEmployee(string employeeCode)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmployee", employeeCodeParameter);
        }
    
        public virtual ObjectResult<GetAllEmployee_Result> GetAllEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllEmployee_Result>("GetAllEmployee");
        }
    
        public virtual ObjectResult<GetByCodeEmployee_Result> GetByCodeEmployee(string employeeCode)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByCodeEmployee_Result>("GetByCodeEmployee", employeeCodeParameter);
        }
    
        public virtual int LockedUser(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LockedUser", userNameParameter);
        }
    
        public virtual ObjectResult<string> LoginUser(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoginUser", userNameParameter);
        }
    
        public virtual int RegisterUser(string userName, string passWord, Nullable<System.DateTime> createdDate, string createdBy, byte[] userImage, Nullable<bool> locked, string note, string socialAccount1, string socialAccount2, string socialAccount3, string socialAccount4)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            var userImageParameter = userImage != null ?
                new ObjectParameter("UserImage", userImage) :
                new ObjectParameter("UserImage", typeof(byte[]));
    
            var lockedParameter = locked.HasValue ?
                new ObjectParameter("Locked", locked) :
                new ObjectParameter("Locked", typeof(bool));
    
            var noteParameter = note != null ?
                new ObjectParameter("Note", note) :
                new ObjectParameter("Note", typeof(string));
    
            var socialAccount1Parameter = socialAccount1 != null ?
                new ObjectParameter("SocialAccount1", socialAccount1) :
                new ObjectParameter("SocialAccount1", typeof(string));
    
            var socialAccount2Parameter = socialAccount2 != null ?
                new ObjectParameter("SocialAccount2", socialAccount2) :
                new ObjectParameter("SocialAccount2", typeof(string));
    
            var socialAccount3Parameter = socialAccount3 != null ?
                new ObjectParameter("SocialAccount3", socialAccount3) :
                new ObjectParameter("SocialAccount3", typeof(string));
    
            var socialAccount4Parameter = socialAccount4 != null ?
                new ObjectParameter("SocialAccount4", socialAccount4) :
                new ObjectParameter("SocialAccount4", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegisterUser", userNameParameter, passWordParameter, createdDateParameter, createdByParameter, userImageParameter, lockedParameter, noteParameter, socialAccount1Parameter, socialAccount2Parameter, socialAccount3Parameter, socialAccount4Parameter);
        }
    
        public virtual ObjectResult<SelectEmployee_Result> SelectEmployee(string employeeCode)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectEmployee_Result>("SelectEmployee", employeeCodeParameter);
        }
    
        public virtual int UnLockedUser(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UnLockedUser", userNameParameter);
        }
    
        public virtual int UpdateEmployee(string employeeCode, string firstName, string lastName, string emailID)
        {
            var employeeCodeParameter = employeeCode != null ?
                new ObjectParameter("EmployeeCode", employeeCode) :
                new ObjectParameter("EmployeeCode", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmployee", employeeCodeParameter, firstNameParameter, lastNameParameter, emailIDParameter);
        }
    
        public virtual int CreateUploadFile(string uploadFileName, string uploadFilePath, string uploadFileVersion, Nullable<int> subCatagoryId)
        {
            var uploadFileNameParameter = uploadFileName != null ?
                new ObjectParameter("UploadFileName", uploadFileName) :
                new ObjectParameter("UploadFileName", typeof(string));
    
            var uploadFilePathParameter = uploadFilePath != null ?
                new ObjectParameter("UploadFilePath", uploadFilePath) :
                new ObjectParameter("UploadFilePath", typeof(string));
    
            var uploadFileVersionParameter = uploadFileVersion != null ?
                new ObjectParameter("UploadFileVersion", uploadFileVersion) :
                new ObjectParameter("UploadFileVersion", typeof(string));
    
            var subCatagoryIdParameter = subCatagoryId.HasValue ?
                new ObjectParameter("SubCatagoryId", subCatagoryId) :
                new ObjectParameter("SubCatagoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateUploadFile", uploadFileNameParameter, uploadFilePathParameter, uploadFileVersionParameter, subCatagoryIdParameter);
        }
    
        public virtual int DeleteUploadFile(Nullable<int> uploadFileId)
        {
            var uploadFileIdParameter = uploadFileId.HasValue ?
                new ObjectParameter("UploadFileId", uploadFileId) :
                new ObjectParameter("UploadFileId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUploadFile", uploadFileIdParameter);
        }
    
        public virtual ObjectResult<GetAllUploadFile_Result> GetAllUploadFile()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUploadFile_Result>("GetAllUploadFile");
        }
    
        public virtual ObjectResult<GetByIdUploadFile_Result> GetByIdUploadFile(Nullable<int> uploadFileId)
        {
            var uploadFileIdParameter = uploadFileId.HasValue ?
                new ObjectParameter("UploadFileId", uploadFileId) :
                new ObjectParameter("UploadFileId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdUploadFile_Result>("GetByIdUploadFile", uploadFileIdParameter);
        }
    
        public virtual int UpdateUploadFile(Nullable<int> uploadFileId, string uploadFileName, string uploadFilePath, string uploadFileVersion, Nullable<int> subCatagoryId, byte[] uploadFileImage)
        {
            var uploadFileIdParameter = uploadFileId.HasValue ?
                new ObjectParameter("UploadFileId", uploadFileId) :
                new ObjectParameter("UploadFileId", typeof(int));
    
            var uploadFileNameParameter = uploadFileName != null ?
                new ObjectParameter("UploadFileName", uploadFileName) :
                new ObjectParameter("UploadFileName", typeof(string));
    
            var uploadFilePathParameter = uploadFilePath != null ?
                new ObjectParameter("UploadFilePath", uploadFilePath) :
                new ObjectParameter("UploadFilePath", typeof(string));
    
            var uploadFileVersionParameter = uploadFileVersion != null ?
                new ObjectParameter("UploadFileVersion", uploadFileVersion) :
                new ObjectParameter("UploadFileVersion", typeof(string));
    
            var subCatagoryIdParameter = subCatagoryId.HasValue ?
                new ObjectParameter("SubCatagoryId", subCatagoryId) :
                new ObjectParameter("SubCatagoryId", typeof(int));
    
            var uploadFileImageParameter = uploadFileImage != null ?
                new ObjectParameter("UploadFileImage", uploadFileImage) :
                new ObjectParameter("UploadFileImage", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUploadFile", uploadFileIdParameter, uploadFileNameParameter, uploadFilePathParameter, uploadFileVersionParameter, subCatagoryIdParameter, uploadFileImageParameter);
        }
    
        public virtual int CreateOrder(Nullable<int> paymentTypeId, Nullable<int> customerId, string orderNumber, Nullable<System.DateTime> orderDate, Nullable<decimal> finalTotal)
        {
            var paymentTypeIdParameter = paymentTypeId.HasValue ?
                new ObjectParameter("PaymentTypeId", paymentTypeId) :
                new ObjectParameter("PaymentTypeId", typeof(int));
    
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            var orderNumberParameter = orderNumber != null ?
                new ObjectParameter("OrderNumber", orderNumber) :
                new ObjectParameter("OrderNumber", typeof(string));
    
            var orderDateParameter = orderDate.HasValue ?
                new ObjectParameter("OrderDate", orderDate) :
                new ObjectParameter("OrderDate", typeof(System.DateTime));
    
            var finalTotalParameter = finalTotal.HasValue ?
                new ObjectParameter("FinalTotal", finalTotal) :
                new ObjectParameter("FinalTotal", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateOrder", paymentTypeIdParameter, customerIdParameter, orderNumberParameter, orderDateParameter, finalTotalParameter);
        }
    
        public virtual int CreateOrderDetail(Nullable<int> orderId, Nullable<int> itemId, Nullable<decimal> quantity, Nullable<decimal> unitPrice, Nullable<decimal> discount, Nullable<decimal> total)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(decimal));
    
            var unitPriceParameter = unitPrice.HasValue ?
                new ObjectParameter("UnitPrice", unitPrice) :
                new ObjectParameter("UnitPrice", typeof(decimal));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("Discount", discount) :
                new ObjectParameter("Discount", typeof(decimal));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("Total", total) :
                new ObjectParameter("Total", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateOrderDetail", orderIdParameter, itemIdParameter, quantityParameter, unitPriceParameter, discountParameter, totalParameter);
        }
    
        public virtual int DeleteOrder(Nullable<int> orderId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteOrder", orderIdParameter);
        }
    
        public virtual int DeleteOrderDetail(Nullable<int> orderDetailId)
        {
            var orderDetailIdParameter = orderDetailId.HasValue ?
                new ObjectParameter("OrderDetailId", orderDetailId) :
                new ObjectParameter("OrderDetailId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteOrderDetail", orderDetailIdParameter);
        }
    
        public virtual ObjectResult<GetAllCustomer_Result> GetAllCustomer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllCustomer_Result>("GetAllCustomer");
        }
    
        public virtual ObjectResult<GetAllItem_Result> GetAllItem()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllItem_Result>("GetAllItem");
        }
    
        public virtual ObjectResult<GetAllOrder_Result> GetAllOrder()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllOrder_Result>("GetAllOrder");
        }
    
        public virtual ObjectResult<GetAllOrderDetail_Result> GetAllOrderDetail()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllOrderDetail_Result>("GetAllOrderDetail");
        }
    
        public virtual ObjectResult<GetAllPaymentType_Result> GetAllPaymentType()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPaymentType_Result>("GetAllPaymentType");
        }
    
        public virtual ObjectResult<GetByIdOrder_Result> GetByIdOrder(Nullable<int> orderId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdOrder_Result>("GetByIdOrder", orderIdParameter);
        }
    
        public virtual ObjectResult<GetByIdOrderDetail_Result> GetByIdOrderDetail(Nullable<int> orderDetailId)
        {
            var orderDetailIdParameter = orderDetailId.HasValue ?
                new ObjectParameter("OrderDetailId", orderDetailId) :
                new ObjectParameter("OrderDetailId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdOrderDetail_Result>("GetByIdOrderDetail", orderDetailIdParameter);
        }
    
        public virtual ObjectResult<GetByOrderIdOrderDetail_Result> GetByOrderIdOrderDetail(Nullable<int> orderId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByOrderIdOrderDetail_Result>("GetByOrderIdOrderDetail", orderIdParameter);
        }
    
        public virtual int UpdateOrder(Nullable<int> orderId, Nullable<int> paymentTypeId, Nullable<int> customerId, string orderNumber, Nullable<System.DateTime> orderDate, Nullable<decimal> finalTotal)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var paymentTypeIdParameter = paymentTypeId.HasValue ?
                new ObjectParameter("PaymentTypeId", paymentTypeId) :
                new ObjectParameter("PaymentTypeId", typeof(int));
    
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            var orderNumberParameter = orderNumber != null ?
                new ObjectParameter("OrderNumber", orderNumber) :
                new ObjectParameter("OrderNumber", typeof(string));
    
            var orderDateParameter = orderDate.HasValue ?
                new ObjectParameter("OrderDate", orderDate) :
                new ObjectParameter("OrderDate", typeof(System.DateTime));
    
            var finalTotalParameter = finalTotal.HasValue ?
                new ObjectParameter("FinalTotal", finalTotal) :
                new ObjectParameter("FinalTotal", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateOrder", orderIdParameter, paymentTypeIdParameter, customerIdParameter, orderNumberParameter, orderDateParameter, finalTotalParameter);
        }
    
        public virtual int UpdateOrderDetail(Nullable<int> orderDetailId, Nullable<decimal> quantity, Nullable<decimal> unitPrice, Nullable<decimal> discount, Nullable<decimal> total)
        {
            var orderDetailIdParameter = orderDetailId.HasValue ?
                new ObjectParameter("OrderDetailId", orderDetailId) :
                new ObjectParameter("OrderDetailId", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(decimal));
    
            var unitPriceParameter = unitPrice.HasValue ?
                new ObjectParameter("UnitPrice", unitPrice) :
                new ObjectParameter("UnitPrice", typeof(decimal));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("Discount", discount) :
                new ObjectParameter("Discount", typeof(decimal));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("Total", total) :
                new ObjectParameter("Total", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateOrderDetail", orderDetailIdParameter, quantityParameter, unitPriceParameter, discountParameter, totalParameter);
        }
    
        public virtual ObjectResult<GetByIdCustomer_Result> GetByIdCustomer(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdCustomer_Result>("GetByIdCustomer", customerIdParameter);
        }
    
        public virtual ObjectResult<GetByIdPaymentType_Result> GetByIdPaymentType(Nullable<int> paymentTypeId)
        {
            var paymentTypeIdParameter = paymentTypeId.HasValue ?
                new ObjectParameter("PaymentTypeId", paymentTypeId) :
                new ObjectParameter("PaymentTypeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdPaymentType_Result>("GetByIdPaymentType", paymentTypeIdParameter);
        }
    
        public virtual ObjectResult<GetAllPR_Result> GetAllPR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPR_Result>("GetAllPR");
        }
    
        public virtual ObjectResult<string> GetMaxPRNo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetMaxPRNo");
        }
    }
}
