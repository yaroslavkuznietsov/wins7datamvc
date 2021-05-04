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
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public int? DatHeId { get; set; }
        public int? DatConfigId { get; set; }
        public int? DatN2Id { get; set; }
        public int? DatWkzId { get; set; }
        public int? MWkz54030Id { get; set; }
        public int? MWkz54040Id { get; set; }
        public int? MWkz54050Id { get; set; }
        public int? MWkz54060Id { get; set; }
        public int? MWkz54070Id { get; set; }
        public DatHE DatHe { get; set; }
        public DatConfig DatConfig { get; set; }
        public DatN2 DatN2 { get; set; }
        public DatWerkzeug DatWkz { get; set; }
        public DatMWerkzeug DatMWkz54030 { get; set; }
        public DatMWerkzeug DatMWkz54040 { get; set; }
        public DatMWerkzeug DatMWkz54050 { get; set; }
        public DatMWerkzeug DatMWkz54060 { get; set; }
        public DatMWerkzeug DatMWkz54070 { get; set; }
    }
}
