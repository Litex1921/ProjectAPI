using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoesSizeConverter;


namespace ShoeConverterREST.Controllers
{
    public class ConvertController : ApiController
    {
        [HttpGet]
        [Route("api/converter")]
        public HttpResponseMessage Convert([FromUri] double centimeters, [FromUri]string type) {
            UsShoeSizeConverter converter = new UsShoeSizeConverter();
            ShoeCategories category = ShoeCategories.Women;
            if (type.ToLower().Equals("men")) {
                category = ShoeCategories.Men;
            }
            ShoeSize size = converter.GetForCentimeters(centimeters, category);
            return Request.CreateResponse(HttpStatusCode.OK, size);
          
        }
    }
}