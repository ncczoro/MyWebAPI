using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.DataAccess.Ef;
using WebAPI.DataAccess.Ef.Repositories;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        private UserServices userServices = new UserServices();

        //[HttpPost]
        //[Route("landing/communications/outboundcommunication/send")]
        //public HttpResponseMessage SendOutboundCommunication(List<OutboundCommunicationSendDto> outboundCommunicationSendDtos) { }

        [HttpGet]
        [Route("user/all")]
        public IEnumerable<User> GetUserAll()
        {
            return userServices.GetUsers();
        }

        //public IHttpActionResult GetUser(int id)
        //{
        //    return Ok(User);
        //}
        [HttpPost]
        [Route("user/create")]
        public IHttpActionResult CreateUser(User postUser)
        {
            var isSave = userServices.SaveUser(postUser);
            if (isSave)
                return Ok();
            return BadRequest();
        }

        [HttpPut]
        [Route("user/edit")]
        public IHttpActionResult EditUser(User putUser)
        {
            var isUpdated = userServices.UpdateUser(putUser.ID, putUser);
            if (isUpdated)
                return Ok();
            return BadRequest();
        }

        [HttpDelete]
        [Route("user/delete")]
        public IHttpActionResult DeleteUser(int id)
        {
           var isDeleted =  userServices.DeteleUser(id);
            if (isDeleted)
                return Ok();
            return BadRequest();

        }
    }
} 

