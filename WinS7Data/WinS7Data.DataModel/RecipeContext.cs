using System.Data.Entity;
using WinS7Data.DataLibrary.Models;

namespace WinS7Data.DataModel
{
    public class RecipeContext:DbContext
    {
        public RecipeContext()
        : base("name=DefaultConnection")
        {
        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<DatHE> DatHEs { get; set; }
        public DbSet<DatConfig> DatConfigs { get; set; }
        public DbSet<DatN2> DatN2s { get; set; }
        public DbSet<DatWerkzeug> DatWerkzeugs { get; set; }
        public DbSet<DatMWerkzeug> DatMWerkzeugs { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.UDTConfigSchritt> UDTConfigSchritts { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.Schritt> Schritts { get; set; }
    }
}
