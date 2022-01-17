using shoes_shop_linq_to_sql.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace shoes_shop_linq_to_sql.Controllers.API
{
    public class KidesShoesController : ApiController
    {
       static string connectionString = "Data Source=desktop-5e70rm2;Initial Catalog=ShoesDataBase;Integrated Security=True;Pooling=False";
        ShoesDataContextDataContext datacontext = new ShoesDataContextDataContext(connectionString);


        // GET: api/KidesShoes
        public IHttpActionResult Get()
        {
            try
            {
                List<KidsShoe> listOfShoes = datacontext.KidsShoes.ToList();
                return Ok(new { listOfShoes });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/KidesShoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                KidsShoe Shoes = datacontext.KidsShoes.First((item) => item.Id == id);
                return Ok(new { Shoes });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/KidesShoes
        public IHttpActionResult Post([FromBody]KidsShoe obj)
        {
            try
            {
                datacontext.KidsShoes.InsertOnSubmit(obj);
                datacontext.SubmitChanges();

                return Ok("add");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/KidesShoes/5
        public IHttpActionResult Put(int id, [FromBody]KidsShoe obj)
        {
            try
            {
                KidsShoe Shoes = datacontext.KidsShoes.First((item) => item.Id == id);
                Shoes.company = obj.company;
                Shoes.material = obj.material;
                Shoes.Instock = obj.Instock;
                Shoes.size = obj.size;
                Shoes.price = obj.price;

                datacontext.SubmitChanges();
                return Ok("Update");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/KidesShoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                KidsShoe Shoes = datacontext.KidsShoes.First((item) => item.Id == id);
                datacontext.KidsShoes.DeleteOnSubmit(Shoes);
                datacontext.SubmitChanges();

                return Ok("Deleted");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
