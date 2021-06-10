using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WinS7Data.DataLibrary.Models
{
    // Defines that you want to serialize this class
    [Serializable()]
    public class DatN2 : ISerializable
    {
        //property
        [XmlIgnoreAttribute]
        public int Id { get; set; }
        [XmlIgnoreAttribute]
        [Display(Name = "RFID")]
        public int ToolCode { get; set; }
        [XmlIgnoreAttribute]
        [Display(Name = "Tool")]
        public string ToolName { get; set; }

        [Display(Name = "PV01")]
        public Propventil Propventil01 { get; set; } = new Propventil();
        [Display(Name = "PV02")]
        public Propventil Propventil02 { get; set; } = new Propventil();
        [Display(Name = "PV03")]
        public Propventil Propventil03 { get; set; } = new Propventil();
        [Display(Name = "PV04")]
        public Propventil Propventil04 { get; set; } = new Propventil();
        [Display(Name = "PV05")]
        public Propventil Propventil05 { get; set; } = new Propventil();
        [Display(Name = "PV06")]
        public Propventil Propventil06 { get; set; } = new Propventil();
        [Display(Name = "PV07")]
        public Propventil Propventil07 { get; set; } = new Propventil();
        [Display(Name = "PV08")]
        public Propventil Propventil08 { get; set; } = new Propventil();
        [Display(Name = "PV09")]
        public Propventil Propventil09 { get; set; } = new Propventil();
        [Display(Name = "PV10")]
        public Propventil Propventil10 { get; set; } = new Propventil();
        [Display(Name = "PV11")]
        public Propventil Propventil11 { get; set; } = new Propventil();
        [Display(Name = "PV12")]
        public Propventil Propventil12 { get; set; } = new Propventil();
        [Display(Name = "PV13")]
        public Propventil Propventil13 { get; set; } = new Propventil();
        [Display(Name = "PV14")]
        public Propventil Propventil14 { get; set; } = new Propventil();
        [Display(Name = "PV15")]
        public Propventil Propventil15 { get; set; } = new Propventil();
        [Display(Name = "PV16")]
        public Propventil Propventil16 { get; set; } = new Propventil();
        [Display(Name = "PV17")]
        public Propventil Propventil17 { get; set; } = new Propventil();
        [Display(Name = "PV18")]
        public Propventil Propventil18 { get; set; } = new Propventil();
        [Display(Name = "PV19")]
        public Propventil Propventil19 { get; set; } = new Propventil();
        [Display(Name = "PV20")]
        public Propventil Propventil20 { get; set; } = new Propventil();
        [Display(Name = "PV21")]
        public Propventil Propventil21 { get; set; } = new Propventil();
        [Display(Name = "PV22")]
        public Propventil Propventil22 { get; set; } = new Propventil();
        [Display(Name = "PV23")]
        public Propventil Propventil23 { get; set; } = new Propventil();
        [Display(Name = "PV24")]
        public Propventil Propventil24 { get; set; } = new Propventil();
        [Display(Name = "PV25")]
        public Propventil Propventil25 { get; set; } = new Propventil();
        [Display(Name = "PV26")]
        public Propventil Propventil26 { get; set; } = new Propventil();
        [Display(Name = "PV27")]
        public Propventil Propventil27 { get; set; } = new Propventil();
        [Display(Name = "PV28")]
        public Propventil Propventil28 { get; set; } = new Propventil();
        [Display(Name = "PV29")]
        public Propventil Propventil29 { get; set; } = new Propventil();
        [Display(Name = "PV30")]
        public Propventil Propventil30 { get; set; } = new Propventil();
        [Display(Name = "PV31")]
        public Propventil Propventil31 { get; set; } = new Propventil();
        [Display(Name = "PV32")]
        public Propventil Propventil32 { get; set; } = new Propventil();
        [Display(Name = "PV33")]
        public Propventil Propventil33 { get; set; } = new Propventil();
        [Display(Name = "PV34")]
        public Propventil Propventil34 { get; set; } = new Propventil();
        [Display(Name = "PV35")]
        public Propventil Propventil35 { get; set; } = new Propventil();
        [Display(Name = "PV36")]
        public Propventil Propventil36 { get; set; } = new Propventil();
        [Display(Name = "PV37")]
        public Propventil Propventil37 { get; set; } = new Propventil();
        [Display(Name = "PV38")]
        public Propventil Propventil38 { get; set; } = new Propventil();
        [Display(Name = "PV31")]
        public Propventil Propventil39 { get; set; } = new Propventil();
        [Display(Name = "PV40")]
        public Propventil Propventil40 { get; set; } = new Propventil();
        public Propventil Propventil41 { get; set; } = new Propventil();
        public Propventil Propventil42 { get; set; } = new Propventil();
        public Propventil Propventil43 { get; set; } = new Propventil();
        public Propventil Propventil44 { get; set; } = new Propventil();
        public Propventil Propventil45 { get; set; } = new Propventil();
        public Propventil Propventil46 { get; set; } = new Propventil();
        public Propventil Propventil47 { get; set; } = new Propventil();
        public Propventil Propventil48 { get; set; } = new Propventil();
        public Propventil Propventil49 { get; set; } = new Propventil();
        public Propventil Propventil50 { get; set; } = new Propventil();
        public Propventil Propventil51 { get; set; } = new Propventil();
        public Propventil Propventil52 { get; set; } = new Propventil();
        public Propventil Propventil53 { get; set; } = new Propventil();
        public Propventil Propventil54 { get; set; } = new Propventil();
        public Propventil Propventil55 { get; set; } = new Propventil();
        public Propventil Propventil56 { get; set; } = new Propventil();
        public Propventil Propventil57 { get; set; } = new Propventil();
        public Propventil Propventil58 { get; set; } = new Propventil();
        public Propventil Propventil59 { get; set; } = new Propventil();
        public Propventil Propventil60 { get; set; } = new Propventil();

        //ctor
        public DatN2() { }


        // Serialization function (Stores Object Data in File)
        // SerializationInfo holds the key value pairs
        // StreamingContext can hold additional info
        // but we aren't using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

        // The deserialize function (Removes Object Data from File)
        public DatN2(SerializationInfo info, StreamingContext ctxt)
        {
        }
    }

    // Defines that you want to serialize this class
    [Serializable()]
    public class Propventil
    {
        //property
        [Display(Name = "Soll")]
        public double Soll { get; set; } = 0.0;
        [Display(Name = "T+")]
        public double ToleranzPlus { get; set; } = 0.0;
        [Display(Name = "T-")]
        public double ToleranzMinus { get; set; } = 0.0;
        [Display(Name = "Vrz")]
        public double Einschaltverzoegerung { get; set; } = 0.0;

        //ctor
        public Propventil() { }
    }
}
