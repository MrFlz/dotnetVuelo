/*using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using dotnetvuelo.Models;

namespace dotnetvuelo.Controllers
{
    //agregue route y api
    [ApiController]
    [Route("[controller]/[action]")]    
    public class UserController : ControllerBase //agregue Base
    {    
        // POST: user/apost
        [HttpPost]
        public async Task<ActionResult<UserModel>> aPost(UserModel payload)
        {
            using (var context = new VuelosContext())
            {
                context.UserM.Add(payload);
                await context.SaveChangesAsync();
            }
            return Ok(payload);
        }
         
        // GET: user/aget/4
        [HttpGet("{id?}")]
        public async Task<ActionResult<UserModel>> aGet(int? id)
        {
            using (var context = new VueloContext()) 
            {  
                if (id == null)  
                {                            
                    var usuvar = context.UserM.ToList();
                    return Ok(usuvar); 
                }
                var aw = await context.UserM.FindAsync(id); 

                return NotFound(aw);  
            }     
        }  

        // PUT: user/aput/4
        [HttpPut("{id}")]
        public async Task<ActionResult<UserModel>> aPut(int id, [FromBody]UserModel payload) //el frombody es opcional
        {
            using (var context = new VueloContext())
            {   
                var aw = await context.UserM.FindAsync(id);  

                if (aw == null)
                {
                    return BadRequest("id not found");
                } 

                aw.nickname = payload.nickname;
                aw.pass = payload.pass;

                context.Update(aw); 
                await context.SaveChangesAsync();   
                return Ok(aw); 
            }     
        } 

        // DELETE: user/adel/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserModel>> aDel(int id)
        {   
            using(var context = new VueloContext()){

                var aw = await context.UserM.FindAsync(id);

                if (aw == null)
                {
                    return NotFound();
                }
                
                context.UserM.Remove(aw);
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