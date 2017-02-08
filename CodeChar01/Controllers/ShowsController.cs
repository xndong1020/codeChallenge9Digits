using CodeChar01.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;

namespace CodeChar01.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShowsController : ApiController
    {
        //[HttpPost]        
        //public IHttpActionResult Post([FromBody]string requestString)
        //{
        //    try
        //    {
        //        var request = JsonConvert.DeserializeObject<RequestObject>(requestString);

        //        if (request == null)
        //            throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(new { error = "Could not decode request: JSON parsing failed" })));

        //        var result = request?.payload
        //            .Where(x => x.drm == true && x.episodeCount > 0)
        //            .Select(x => new { image = x.image?.showImage, slug = x.slug, title = x.title })
        //            .ToList();

        //        return Ok(result);
        //    }
        //    catch (Exception)
        //    {
        //        throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(new { error = "Could not decode request: JSON parsing failed" })));
        //    }
        //}

        [HttpPost]
        public IHttpActionResult Post([FromBody]RequestObject request)
        {
            try
            {
                if (!ModelState.IsValid || request?.Payload == null)
                    throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(new { error = "Could not decode request: JSON parsing failed" })));

                var result = request?.Payload
                   .Where(x => x.Drm == true && x.EpisodeCount > 0)
                   .Select(x => new { image = x.Image?.ShowImage, slug = x.Slug, title = x.Title })
                   .ToList();

                return Ok(new { response = result });
            }
            catch (Exception)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(new { error = "Could not decode request: JSON parsing failed" })));
            }
        }
    }
}
