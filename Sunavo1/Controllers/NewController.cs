using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace sunova.Controllers
{
    [RoutePrefix("api/New")]
    public class NewController : ApiController
    {
        //[Authorize]
        
       
            List<Data> dat = new List<Data>();
            [HttpGet]
            [Route]
            public IEnumerable<Data> Get()
            {




                HttpResponseMessage response = new HttpResponseMessage();

                Data temp = new Data();

                using (var client = new HttpClient())
                {
                   
                    // client.BaseAddress = new Uri("https://mobiledev.sunovacu.ca/api/Values/GetCars");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    response = client.GetAsync("https://mobiledev.sunovacu.ca/api/Values/GetCars").Result;

                    dat = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(response.Content.ReadAsStringAsync().Result.ToString());
                    return dat;
                }
            }

          
        }
    }

