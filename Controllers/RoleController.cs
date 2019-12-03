/*using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using dotnetvuelo.Models;

namespace dotnetvuelo.Controllers
{
    //agregue route y api
    [ApiController]
    [Route("[controller]/[action]")]    
    public class RoleController : ControllerBase //agregue Base
    {    
        // POST: role/apost
        [HttpPost]
        public async Task<ActionResult<RoleModel>> aPost(RoleModel payload)
        {
            using (var context = new VuelosContext())
            {
                context.RoleM.Add(payload);
                await context.SaveChangesAsync();
            }
            return Ok(payload);
        }
         
        // GET: role/aget/4
        [HttpGet("{id?}")]
        public async Task<ActionResult<RoleModel>> aGet(int? id)
        {
            using (var context = new VuelosContext()) 
            {  
                if (id == null)  
                {                            
                    var rolvar = context.RoleM.ToList();
                    return Ok(rolvar); 
                }
                var aw = await context.RoleM.FindAsync(id); 

                return NotFound(aw);  
            }     
        }  

        // PUT: role/aput/4
        [HttpPut("{id}")]
        public async Task<ActionResult<RoleModel>> aPut(int id, [FromBody]RoleModel payload) //el frombody es opcional
        {
            using (var context = new VuelosContext())
            {   
                var aw = await context.RoleM.FindAsync(id);  

                if (aw == null)
                {
                    return BadRequest("id not found");
                }  

                aw.rolename = payload.rolename;

                context.Update(aw); 
                await context.SaveChangesAsync();   
                return Ok(aw); 
            }     
        } 

        // DELETE: role/adel/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RoleModel>> aDel(int id)
        {   
            using(var context = new VuelosContext()){

                var aw = await context.RoleM.FindAsync(id);

                if (aw == null)
                {
                    return NotFound();
                }
                
                context.RoleM.Remove(aw);
                await context.SaveChangesAsync();

                return Ok(aw);
            }            
        }  
    }
}*/

/*        
    11111111111111111111111111111111  dir de host
    11111110101010010000000000101010 mask de arriba
    --------------------------------- AND
    10101010201201020102012010201201 => 10.23.12.3  dir de la red

    11111111111111111111111111111111  dir de host
    11111110101010010000000000101010 NOT mask de arriba
    --------------------------------- OR
    10101010201201020102012010201201 => 10.23.12.3  dir de broadcast        
*/
