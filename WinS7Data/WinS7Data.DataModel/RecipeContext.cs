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

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.Teilekontrolle> Teilekontrolles { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.WerkzeugConfig> WerkzeugConfigs { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.NameOfInput> NameOfInputs { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.TimeOfVentil> TimeOfVentils { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.ParameterSchritteClass> ParameterSchritteClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.AbholAchseA1A2Class> AbholAchseA1A2Class { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.AbholSchrittClass> AbholSchrittClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.AktivierungSchritteClass> AktivierungSchritteClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.HEVorpositionSchrittClass> HEVorpositionSchrittClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.HEVorpositionAchseA1A2Class> HEVorpositionAchseA1A2Class { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.Warm1SchrittClass> Warm1SchrittClass { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.Warm1AchseA1A2Class> Warm1AchseA1A2Class { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.Warm1AchseA3Class> Warm1AchseA3Class { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.AchsenStromClass> AchsenStromClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.ZaehlerClass> ZaehlerClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.AktivierungN2GasClass> AktivierungN2GasClass { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.AktivierungSontigesClass> AktivierungSontigesClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.BursterDigiforceKraftWegClass> BursterDigiforceKraftWegClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.BursterDigiforceMinsdestkraftClass> BursterDigiforceMinsdestkraftClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.IRCameraClass> IRCameraClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.DMXCheckClass> DMXCheckClasses { get; set; }

        public System.Data.Entity.DbSet<WinS7Data.DataLibrary.Models.Ausgleichshub> Ausgleichshubs { get; set; }
    }
}
