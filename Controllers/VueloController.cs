using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using dotnetvuelo.Models;

namespace dotnetvuelo.Controllers
{
    //agregue route y api
    [ApiController]
    [Route("[controller]/[action]")]    
    public class VueloController : ControllerBase //agregue Base
    {    
        // POST: vuelo/apost
        [HttpPost]
        public async Task<ActionResult<VueloModel>> aPost(VueloModel payload)
        {
            using (var context = new VueloContext())
            {
                context.VueloM.Add(payload);
                await context.SaveChangesAsync();
            }
            return Ok(payload);
        }
         
        // GET: vuelo/aget/4
        [HttpGet("{id?}")]
        public async Task<ActionResult<VueloModel>> aGet(int? id)
        {
            using (var context = new VueloContext()) 
            {  
                if (id == null)  
                {                            
                    var vuelovar = context.VueloM.ToList();
                    return Ok(vuelovar); 
                }
                var aw = await context.VueloM.FindAsync(id); 

                return NotFound(aw);  
            }     
        }  

        // PUT: vuelo/aput/4
        [HttpPut("{id}")]
        public async Task<ActionResult<VueloModel>> aPut(int id, [FromBody]VueloModel payload) //el frombody es opcional
        {
            using (var context = new VueloContext())
            {   
                var aw = await context.VueloM.FindAsync(id);  

                if (aw == null)
                {
                    return BadRequest("id not found");
                }  

                aw.source = payload.source;
                aw.dest = payload.dest;
                //aw.aval = payload.aval;
                aw.status = payload.status; 

                context.Update(aw); 
                await context.SaveChangesAsync();   
                return Ok(aw); 
            }     
        } 

        // DELETE: vuelo/adel/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VueloModel>> aDel(int id)
        {   
            using(var context = new VueloContext()){

                var aw = await context.VueloM.FindAsync(id);

                if (aw == null)
                {
                    return NotFound();
                }
                
                context.VueloM.Remove(aw);
                await context.SaveChangesAsync();

                return Ok(aw);
            }            
        }  
    }
}
