using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapicrud.Models;

namespace webapicrud.Controllers
{
    public class CrudapiController : ApiController
    {
        web_api_crud_dbEntities db = new web_api_crud_dbEntities();
        [HttpGet]
        public IHttpActionResult GetEmployees()
        {
            List<Employee> list = db.Employees.ToList();

            return Ok(list);
        }
    }
}
