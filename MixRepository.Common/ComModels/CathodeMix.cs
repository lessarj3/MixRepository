using System;
using System.Data.Entity;  /*you need to add in order to be able to reference DbContext and DbSet*/
using System.ComponentModel.DataAnnotations; /*This loads the validation features*/

namespace MixRepository.Common.ComModels
{
    public class Mix
    {
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Range(0.0, 100.0)] /*Valitdation for CFx*/
        public decimal CFx  { get; set; }

        [Range(0.0, 100.0)] /*Valitdation for SVO*/
        public decimal SVO { get; set; }

        [Range(0.0, 100.0)] /*Valitdation for Carbon*/
        public decimal Carbon { get; set; }

        [Range(0.0, 100.0)] /*Valitdation for Binder*/
        public decimal Binder { get; set; }

        [Range(0.0, 20)] /*Valitdation for Ratio*/
        public decimal Ratio { get; set; }


    }

    //The CathodeMixDBContext class represents the Entity Framework cathode mix database context, 
    //which handles fetching, storing, and updating CathodeMix class instances in a database.
    //The CathodeMixDBContext derives from the DbContext base class provided by the Entity Framework.
    public class MixDBContext : DbContext
    {
        public DbSet<Mix> Mixes { get; set; }
    }
}