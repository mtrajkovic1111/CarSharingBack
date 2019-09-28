using APPLICATION.Interfaces;
using AutoMapper;
using CarSharingWebAPI.DTOS;
using DOMAIN.Entities;
using INFRA.DATA;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CarSharingWebAPI.Controllers
{
   // [AllowAnonymous]
    public class UsersController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private IUserAppService _userAppService;
    
    public UsersController(IUnitOfWork<Context> uow, IUserAppService userAppService)
    {
            _uow = uow;
            _userAppService = userAppService;
    }
        public IHttpActionResult GetAllUsers()
        {
            var users = _userAppService.GetAll();
            return Ok(users);
        }

        public IHttpActionResult GetUser(int id)
        {
            var userById = _userAppService.GetById(id);

            if (userById == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();

            return Ok(Mapper.Map<User, UserDTO>(userById));
        }
        // GET api/Users/email
       // [AllowAnonymous]
        [Route("api/users/email")]
        public IHttpActionResult GetUserByEmail(string email)
        {
            var user = _userAppService.FindUserByEmail(email);
            return Ok(Mapper.Map<User, UserDTO>(user));
        }

        [Route("api/users/totalusers")]
        public IHttpActionResult GetTotalUsers()
        {
            var users = _userAppService.TotalNumberOfusers();
            return Ok(users);
        }


        // GET api/Users/Username
        // [AllowAnonymous]
        [Route("api/users/username")]
        public IHttpActionResult GetUserByUsername(string username)
        {
            var user = _userAppService.FindUserByUsername(username);
            return Ok(Mapper.Map<User, UserDTO>(user));
        }


        [HttpPost]
        public IHttpActionResult CreateUser(UserDTO userDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = Mapper.Map<UserDTO, User>(userDto);
            _userAppService.Add(user);
            _uow.Save();

            userDto.Id = user.Id;
            return Created(new Uri(Request.RequestUri + "/" + user.Id), userDto);

        }

        //[HttpPut]
        //public IHttpActionResult UpdateUser(int id, UserDTO userDTO)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var userFromDb = _userAppService.GetById(id);

        //    if (userFromDb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    //Mapper.Map<VariantDTO, Variant>(variantDTO, variantFromDb);    
        //    Mapper.Map(userDTO, userFromDb);
        //    _uow.Save();
        //    return Ok();
        //}

        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {
            var userFromDb = _userAppService.GetById(id);
            if (userFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<User, UserDTO>(userFromDb);

            _userAppService.Remove(userFromDb);
            _uow.Save();
            return Ok();


        }


        //[AllowAnonymous]
        //[HttpPut]

        //public IHttpActionResult AddProfilePicture(int id, HttpPostedFileBase uploadedFile)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    if (uploadedFile != null && uploadedFile.ContentLength > 0)
        //    {
        //        var userFromDb = _userAppService.GetById(id);
        //        if (userFromDb == null)
        //            throw new HttpResponseException(HttpStatusCode.NotFound);

        //        using (var reader = new BinaryReader(uploadedFile.InputStream))
        //        {
        //            userFromDb.ProfilePicture = reader.ReadBytes(uploadedFile.ContentLength);
        //        }
        //    }

        //    _uow.Save();
        //    return Ok();

        //}

        //[AllowAnonymous]
        [Route("api/users/edit")]
        [HttpPut]

        public IHttpActionResult EditUser(int id, UserDTO userDTO)
        {

            var userFromDb = _userAppService.GetById(id);
            if (userFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            userFromDb.Name = userDTO.Name;
            userFromDb.Surname = userDTO.Surname;
            userFromDb.DateOfBirth = userDTO.DateOfBirth;
            userFromDb.Email = userDTO.Email;
            userFromDb.Username = userDTO.Username;
            //userFromDb.ContactPhone = userDTO.ContactPhone;

            _uow.Save();
            return Ok();

        }

        [Route("api/users/phone")]
        [HttpPut]

        public IHttpActionResult AddUserPhone (int id, UserDTO userDTO)
        {

            var userFromDb = _userAppService.GetById(id);
            if (userFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

           userFromDb.ContactPhone = userDTO.ContactPhone;

            _uow.Save();
            return Ok();

        }


        // [AllowAnonymous]
        [HttpPut]

        public IHttpActionResult AddProfilePicture(int id)
        {

            var userFromDb = _userAppService.GetById(id);
            if (userFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            string imgName = null;
            var httpRequest = HttpContext.Current.Request;

            var postedFile = httpRequest.Files["uploadedFile"];



            using (var reader = new BinaryReader(postedFile.InputStream))
            {
                userFromDb.ProfilePicture = reader.ReadBytes(postedFile.ContentLength);
            }


            _uow.Save();
            return Ok();

        }








        //[AllowAnonymous]
        //[HttpPut]
        //public HttpResponseMessage UploadJsonFile(int id)
        //{
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    var httpRequest = HttpContext.Current.Request;
        //    if (httpRequest.Files.Count > 0)
        //    {
        //        foreach (string file in httpRequest.Files)
        //        {
        //            var postedFile = httpRequest.Files[file];
        //            var userFromDb = _userAppService.GetById(id);
        //            if (userFromDb == null)
        //                throw new HttpResponseException(HttpStatusCode.NotFound);

        //            using (var reader = new BinaryReader(postedFile.InputStream))
        //            {
        //                userFromDb.ProfilePicture = reader.ReadBytes(postedFile.ContentLength);
        //            }
        //            _uow.Save();

        //        }
        //    }
        //    return response;
        //}


    }
}
