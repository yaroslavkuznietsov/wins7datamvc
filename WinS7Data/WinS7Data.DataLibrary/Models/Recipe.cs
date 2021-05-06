using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinS7Data.DataLibrary.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public int ToolCode { get; set; }
        public string ToolName { get; set; }

        public int? DatHEId { get; set; }
        public DatHE DatHE { get; set; }
        public int? DatConfigId { get; set; }
        public DatConfig DatConfig { get; set; }
        public int? DatN2Id { get; set; }
        public DatN2 DatN2 { get; set; }
        public int? DatWerkzeugId { get; set; }
        public DatWerkzeug DatWerkzeug { get; set; }
        public List<DatMWerkzeug> DatMWerkzeugs { get; set; }

        public Recipe()
        {
            DatMWerkzeugs = new List<DatMWerkzeug>();
        }
    }
}
