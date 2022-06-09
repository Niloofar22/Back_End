using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcApi.Model;

namespace MvcApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase

    {


        private readonly MyContext db;
        public CRUDController(MyContext context)
        {
            db = context;
        }
        // GET: api/CRUD
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovies()
        {

            return await db.Movies.ToListAsync();
        }


        // GET: api/CRUD/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetAMovie(int id)
        {

            var movies = await db.Movies.FindAsync(id);
            if (movies == null)
            {
                return NotFound();
            }
            return movies;


        }


        // POST: api/CRUD
        [HttpPost]
        public async Task<ActionResult<Movie>> Create(Movie movies)
        {
            try
            {

                db.Movies.Add(movies);
                await db.SaveChangesAsync();

                return Accepted();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return NotFound();
            }
        }


        // PUT: api/CRUD/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> EditAMovie(Movie movies)
        {
            try
            {


                db.Entry(movies).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");


            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return NotFound();
            }
        }


        // DELETE: api/CRUD/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> Delete(int id)
        {
            try
            {
                var movie = await db.Movies.FindAsync(id);

                if (movie == null)
                {
                    return NotFound();
                }
                db.Movies.Remove(movie);
                await db.SaveChangesAsync();
                return Ok();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return NotFound();
            }
        }

    }   }