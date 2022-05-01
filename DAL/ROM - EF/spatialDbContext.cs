using BE;
using BE.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// connection string -  Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
namespace DAL
{
    /// <summary>
    /// ORM - O/R mapper - ENTITY FRAMEWORK - Connection to Firebase (CodeFirst)
    /// </summary>
    public class spatialDbContext : DbContext
    {
        public spatialDbContext() : base("SpacialDb")
        {
            Database.SetInitializer<spatialDbContext>(new CreateDatabaseIfNotExists<spatialDbContext>());
        }

        // define the sets of objects
        public DbSet<Satelite> Satelites { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Asteroid> Asteroids { get; set; }
        public DbSet<DayPicture> DayPictures { get; set; }
        public DbSet<MediaNasa>  MediaNasaUrls{ get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        #region ADD
        public async Task<Planet> AddPlanet(Planet newPlanet)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    var retPlanet = ctx.Planets.Add(newPlanet); // using the sets from spatialdbctx 
                    await ctx.SaveChangesAsync();
                    return retPlanet;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Asteroid> AddAsteroid(Asteroid newAsteroid)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    var ast = new Asteroid(newAsteroid.Id) { Id = newAsteroid.Id,  Close_approach_date = newAsteroid.Close_approach_date, 
                                                             Name = newAsteroid.Name,  Diameter = newAsteroid.Diameter,  
                                                             Is_potentially_hazardous_asteroid = newAsteroid.Is_potentially_hazardous_asteroid,
                                                             Nasa_jpl_url = newAsteroid.Nasa_jpl_url, Orbiting_body = newAsteroid.Orbiting_body};//AsteroidMaterials = newAsteroid.AsteroidMaterials
                    ctx.Asteroids.Add(ast);
                    await ctx.SaveChangesAsync();
                    return ast;

                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Satelite> AddSatelite(Satelite newSatelite)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    //var retSatelite = new Satelite(newSatelite.Id) { /*storeId = var.storeId*/ };
                    ctx.Satelites.Add(newSatelite);
                    await ctx.SaveChangesAsync();
                    return newSatelite;//retSatelite
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<DayPicture> AddApod(DayPicture newApod)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    
                    ctx.DayPictures.Add(newApod);
                    await ctx.SaveChangesAsync();
                    return newApod;//retSatelite
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<MediaNasa> AddMedia(MediaNasa newMedia)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {

                    ctx.MediaNasaUrls.Add(newMedia);
                    await ctx.SaveChangesAsync();
                    return newMedia;//retSatelite
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion ADD

        #region DELETE 

        /// <summary>
        /// func that will remve the requested Planet.
        /// </summary>
        /// <param name="itemId">object id to remove</param>
        public async Task<Planet> RemovePlanet(int itemId)
        {

            using (var ctx = new spatialDbContext())
            {
                var item = ctx.Planets.Find(itemId);
                ctx.Planets.Remove(item);
                await ctx.SaveChangesAsync();
                return item;    
            }
        }

        /// <summary>
        /// func that will remve the requested Asteroid.
        /// </summary>
        /// <param name="asteroidId">object id to remove</param>
        public async Task<Asteroid> RemoveAsteroid(int asteroidId)
        {
            using (var ctx = new spatialDbContext())
            {
                var item = ctx.Asteroids.Find(asteroidId);
                ctx.Asteroids.Remove(item);
                await ctx.SaveChangesAsync();
                return item;
            }
        }

        /// <summary>
        /// func that will remove the requested Satelite.
        /// </summary>
        /// <param name="itemId">object id to remove</param>
        public async Task<Satelite> RemoveSatelite(int itemId) // or need void??
        {

            using (var ctx = new spatialDbContext())
            {
                var item = ctx.Satelites.Find(itemId);
                ctx.Satelites.Remove(item);
                await ctx.SaveChangesAsync();
                return item;
            }
        }


        #endregion DELETE

        #region UPDATE DB

        public async Task<Planet> updatePlanet(Planet planet)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    var item = ctx.Planets.Where(x => x.Id == planet.Id).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(planet);
                        await ctx.SaveChangesAsync();
                    }
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Satelite> updateSatelite(Satelite satelite)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    var item = ctx.Satelites.Where(x => x.Id == satelite.Id).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(satelite);
                        await ctx.SaveChangesAsync();
                    }
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion UPDATE DB

        //region of all funcs that return all our set of this obj.
        #region GET ALL


        public async Task<IEnumerable<Planet>> GetPlanets() //Task<IEnumerable<Planet>>
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    return await Task.FromResult(ctx.Planets.ToList<Planet>());
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<IEnumerable<Asteroid>> GetAsteroids()
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                   return await Task.FromResult(ctx.Asteroids.ToList<Asteroid>());
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<IEnumerable<Satelite>> GetSatelites()
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    return await Task.FromResult(ctx.Satelites.ToList<Satelite>());
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        #endregion GET ALL

        //region of all funcs that return all our set of this obj.
        #region GET ONE
        public async Task<Planet> returnPlanet(int planetId)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    var item = ctx.Planets.Where(x => x.Id == planetId).SingleOrDefault();
                    return await Task.FromResult(item);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Asteroid> returnAsteroid(int asteroidId)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    var item = ctx.Asteroids.Where(x => x.Id == asteroidId).SingleOrDefault();
                    return item;// need to add await
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Satelite> returnSatelite(int sateliteId)
        {
            try
            {
                using (var ctx = new spatialDbContext())
                {
                    var item = ctx.Satelites.Where(x => x.Id == sateliteId).SingleOrDefault();
                    return item; // need to add await
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion GET ONE
    }

}