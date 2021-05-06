using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WinS7Data.DataLibrary.Models
{
    // Defines that you want to serialize this class
    [Serializable()]
    public class DatMWerkzeug : ISerializable
    {
        //property
        [XmlIgnoreAttribute]
        public int Id { get; set; }
        [XmlIgnoreAttribute]
        public int MachineId { get; set; }
        public int WerkzeughoeheA1 { get; set; } = 0;
        public int WerkzeughoeheA2 { get; set; } = 0;
        public int HeizelementhoeheObenA3 { get; set; } = 0;
        public int HeizelementhoeheUntenA3 { get; set; } = 0;
        public int WarmpositionA3 { get; set; } = 0;
        public int BestueckungspositionA1 { get; set; } = 0;
        public int BestueckungspositionA2 { get; set; } = 0;
        public int PruefpositionA1 { get; set; } = 0;
        public int PruefpositionA2 { get; set; } = 0;
        public int IRKameraTriggerpositionA3 { get; set; } = 0;


        //ctor
        public DatMWerkzeug() { }


        // Serialization function (Stores Object Data in File)
        // SerializationInfo holds the key value pairs
        // StreamingContext can hold additional info
        // but we aren't using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

        // The deserialize function (Removes Object Data from File)
        public DatMWerkzeug(SerializationInfo info, StreamingContext ctxt)
        {
        }
    }
}
