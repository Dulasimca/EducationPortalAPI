﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationPortalAPI.ManageSQL;
using System.Data;
using Newtonsoft.Json;

namespace EducationPortalAPI.Controllers.Forms
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationFormController : ControllerBase
    {
        [HttpPost("{id}")]
        public Tuple<bool, int, string> Post(RegistrationFormEntity registrationForm = null)
        {
            ManageSQLConnection manageSQLConnection = new ManageSQLConnection();

            //Check the document Approval
            List<KeyValuePair<string, string>> sqlParameters = new List<KeyValuePair<string, string>>();
            sqlParameters.Add(new KeyValuePair<string, string>("@ID", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@slno1", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@FirstName", registrationForm.FirstName));
            sqlParameters.Add(new KeyValuePair<string, string>("@LastName", Convert.ToString(registrationForm.LastName)));
            sqlParameters.Add(new KeyValuePair<string, string>("@DateofBirth",Convert.ToString(registrationForm.DateofBirth)));
            sqlParameters.Add(new KeyValuePair<string, string>("@Gender", Convert.ToString(registrationForm.Gender)));
            sqlParameters.Add(new KeyValuePair<string, string>("@Nationality", registrationForm.Nationality));
            sqlParameters.Add(new KeyValuePair<string, string>("@Class", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@Section", registrationForm.Section));
            sqlParameters.Add(new KeyValuePair<string, string>("@slno1", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@StudentPhotoFileName", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@Caste", Convert.ToString(registrationForm.Caste)));
            sqlParameters.Add(new KeyValuePair<string, string>("@ID", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@slno1", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@Addressinfo", registrationForm.Addressinfo));
            sqlParameters.Add(new KeyValuePair<string, string>("@PermanentAddress", Convert.ToString(registrationForm.PermanentAddress)));
            sqlParameters.Add(new KeyValuePair<string, string>("@SchoolId", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@slno1", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@PhoneNumber", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@EmailId", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@slno1", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@FatherName", Convert.ToString(registrationForm.FatherName)));

            sqlParameters.Add(new KeyValuePair<string, string>("@FatherOccupation", Convert.ToString(registrationForm.FatherOccupation)));
            sqlParameters.Add(new KeyValuePair<string, string>("@FatherMobileNo", registrationForm.FatherMobileNo));
            sqlParameters.Add(new KeyValuePair<string, string>("@MotherName", Convert.ToString(registrationForm.MotherName)));
            sqlParameters.Add(new KeyValuePair<string, string>("@MotherOccupation", registrationForm.MotherOccupation));
            sqlParameters.Add(new KeyValuePair<string, string>("@MotherMobileNo", Convert.ToString(registrationForm.MotherMobileNo)));
            sqlParameters.Add(new KeyValuePair<string, string>("@StudentPhotoFileName", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@Caste", Convert.ToString(registrationForm.Caste)));
            sqlParameters.Add(new KeyValuePair<string, string>("@Nameoflastschool", registrationForm.Nameoflastschool));
            sqlParameters.Add(new KeyValuePair<string, string>("@LastchoolTelephone", Convert.ToString(registrationForm.LastchoolTelephone)));
            sqlParameters.Add(new KeyValuePair<string, string>("@DistrictId", Convert.ToString(registrationForm.DistrictId)));
            sqlParameters.Add(new KeyValuePair<string, string>("@Postalcode", Convert.ToString(registrationForm.Postalcode)));
            sqlParameters.Add(new KeyValuePair<string, string>("@EmailId_parent", registrationForm.EmailId_parent));
            sqlParameters.Add(new KeyValuePair<string, string>("@slno1", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@GaurdianName", registrationForm.GaurdianName));
            sqlParameters.Add(new KeyValuePair<string, string>("@EmailId", registrationForm.ID));
            sqlParameters.Add(new KeyValuePair<string, string>("@GaurdianOccupation", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@FatherName", Convert.ToString(registrationForm.slno)));


            sqlParameters.Add(new KeyValuePair<string, string>("@FatherPhotoFileName", Convert.ToString(registrationForm.FatherPhotoFileName)));
            sqlParameters.Add(new KeyValuePair<string, string>("@MotherPhotoFilName", registrationForm.MotherPhotoFilName));
            sqlParameters.Add(new KeyValuePair<string, string>("@GaurdianPhotoFileName", Convert.ToString(registrationForm.GaurdianPhotoFileName)));
            sqlParameters.Add(new KeyValuePair<string, string>("@GaurdianName", registrationForm.GaurdianName));
            sqlParameters.Add(new KeyValuePair<string, string>("@RoleId", Convert.ToString(registrationForm.RoleId)));
            sqlParameters.Add(new KeyValuePair<string, string>("@GaurdianOccupation", Convert.ToString(registrationForm.slno)));
            sqlParameters.Add(new KeyValuePair<string, string>("@FatherName", Convert.ToString(registrationForm.RoleId)));

            var resut = manageSQLConnection.InsertData("InsertRegistrationGetRegistration", sqlParameters, "slno");
             return resut;

        }

        [HttpGet("{id}")]
        public string Get()
        {
            ManageSQLConnection manageSQLConnection = new ManageSQLConnection();

            //Check the document Approval
            List<KeyValuePair<string, string>> sqlParameters = new List<KeyValuePair<string, string>>();
            sqlParameters.Add(new KeyValuePair<string, string>("@Type"," 2"));
           var data= manageSQLConnection.GetDataSetValues("GetRegistration", sqlParameters);
            return JsonConvert.SerializeObject(data.Tables[0]);
        }
    }
    public class RegistrationFormEntity
    {

        public int slno { get; set; }
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateofJoining { get; set; }
        public string Gender { get; set; }
        public string Medium { get; set; }
        public string Nationality { get; set; }
        public string BloodGroup { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string StudentPhotoFileName { get; set; }
        public string Caste { get; set; }
        public string Addressinfo { get; set; }
        public string PermanentAddress { get; set; }
        public int SchoolId { get; set; }
        public string PhoneNumber { get; set; }
        public string AltNumber { get; set; }
        public string EmailId { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherMobileNo { get; set; }
        public string FatherEmailid { get; set; }
        public string MotherName { get; set; }
        public string MotherOccupation { get; set; }
        public string MotherMobileNo { get; set; }
        public string MotherEmailid { get; set; }
        public string Nameoflastschool { get; set; }
        public string LastchoolTelephone { get; set; }
        public int DistrictId { get; set; }
        public string Postalcode { get; set; }
        public string LanguageSpoken { get; set; }
        public string EmailId_parent { get; set; }
        public string GaurdianName { get; set; }
        public string GaurdianOccupation { get; set; }
        public string GaurdianMobileNo { get; set; }
        public string GaurdianEmailid { get; set; }
        public string FatherPhotoFileName { get; set; }
        public string MotherPhotoFilName { get; set; }
        public string GaurdianPhotoFileName { get; set; }
        public int RoleId { get; set; }
        public string UserId { get; set; }
    }
}