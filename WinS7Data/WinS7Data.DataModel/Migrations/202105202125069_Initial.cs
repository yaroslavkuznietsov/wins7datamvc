namespace WinS7Data.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToolCode = c.Int(nullable: false),
                        ToolName = c.String(),
                        AP_Id = c.Int(),
                        AU_Id = c.Int(),
                        AV_Id = c.Int(),
                        GS_Id = c.Int(),
                        KU_Id = c.Int(),
                        PN_Id = c.Int(),
                        PT_Id = c.Int(),
                        Reserve_Id = c.Int(),
                        RO_Id = c.Int(),
                        T1_Id = c.Int(),
                        T2_Id = c.Int(),
                        TK_Id = c.Int(),
                        WE_Id = c.Int(),
                        WKZOB_Id = c.Int(),
                        WKZUN_Id = c.Int(),
                        WV_Id = c.Int(),
                        ZYA_Id = c.Int(),
                        ZYE_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schritts", t => t.AP_Id)
                .ForeignKey("dbo.Schritts", t => t.AU_Id)
                .ForeignKey("dbo.Schritts", t => t.AV_Id)
                .ForeignKey("dbo.Schritts", t => t.GS_Id)
                .ForeignKey("dbo.Schritts", t => t.KU_Id)
                .ForeignKey("dbo.Schritts", t => t.PN_Id)
                .ForeignKey("dbo.Schritts", t => t.PT_Id)
                .ForeignKey("dbo.Schritts", t => t.Reserve_Id)
                .ForeignKey("dbo.Schritts", t => t.RO_Id)
                .ForeignKey("dbo.Schritts", t => t.T1_Id)
                .ForeignKey("dbo.Schritts", t => t.T2_Id)
                .ForeignKey("dbo.Teilekontrolles", t => t.TK_Id)
                .ForeignKey("dbo.Schritts", t => t.WE_Id)
                .ForeignKey("dbo.WerkzeugConfigs", t => t.WKZOB_Id)
                .ForeignKey("dbo.WerkzeugConfigs", t => t.WKZUN_Id)
                .ForeignKey("dbo.Schritts", t => t.WV_Id)
                .ForeignKey("dbo.Schritts", t => t.ZYA_Id)
                .ForeignKey("dbo.Schritts", t => t.ZYE_Id)
                .Index(t => t.AP_Id)
                .Index(t => t.AU_Id)
                .Index(t => t.AV_Id)
                .Index(t => t.GS_Id)
                .Index(t => t.KU_Id)
                .Index(t => t.PN_Id)
                .Index(t => t.PT_Id)
                .Index(t => t.Reserve_Id)
                .Index(t => t.RO_Id)
                .Index(t => t.T1_Id)
                .Index(t => t.T2_Id)
                .Index(t => t.TK_Id)
                .Index(t => t.WE_Id)
                .Index(t => t.WKZOB_Id)
                .Index(t => t.WKZUN_Id)
                .Index(t => t.WV_Id)
                .Index(t => t.ZYA_Id)
                .Index(t => t.ZYE_Id);
            
            CreateTable(
                "dbo.Schritts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OB_Id = c.Int(),
                        OB_IG_Id = c.Int(),
                        UN_Id = c.Int(),
                        UN_IG_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UDTConfigSchritts", t => t.OB_Id)
                .ForeignKey("dbo.UDTConfigSchritts", t => t.OB_IG_Id)
                .ForeignKey("dbo.UDTConfigSchritts", t => t.UN_Id)
                .ForeignKey("dbo.UDTConfigSchritts", t => t.UN_IG_Id)
                .Index(t => t.OB_Id)
                .Index(t => t.OB_IG_Id)
                .Index(t => t.UN_Id)
                .Index(t => t.UN_IG_Id);
            
            CreateTable(
                "dbo.UDTConfigSchritts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        E_01_16 = c.Short(nullable: false),
                        E_17_32 = c.Short(nullable: false),
                        E_Vakuum = c.Short(nullable: false),
                        A_Vakuum = c.Short(nullable: false),
                        A_Ventile_1_8 = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teilekontrolles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OB_Id = c.Int(),
                        UN_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UDTConfigSchritts", t => t.OB_Id)
                .ForeignKey("dbo.UDTConfigSchritts", t => t.UN_Id)
                .Index(t => t.OB_Id)
                .Index(t => t.UN_Id);
            
            CreateTable(
                "dbo.WerkzeugConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Id = c.Int(),
                        Time_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NameOfInputs", t => t.Name_Id)
                .ForeignKey("dbo.TimeOfVentils", t => t.Time_Id)
                .Index(t => t.Name_Id)
                .Index(t => t.Time_Id);
            
            CreateTable(
                "dbo.NameOfInputs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EO01 = c.String(),
                        EO02 = c.String(),
                        EO03 = c.String(),
                        EO04 = c.String(),
                        EO05 = c.String(),
                        EO06 = c.String(),
                        EO07 = c.String(),
                        EO08 = c.String(),
                        EO09 = c.String(),
                        EO10 = c.String(),
                        EO11 = c.String(),
                        EO12 = c.String(),
                        EO13 = c.String(),
                        EO14 = c.String(),
                        EO15 = c.String(),
                        EO16 = c.String(),
                        EO17 = c.String(),
                        EO18 = c.String(),
                        EO19 = c.String(),
                        EO20 = c.String(),
                        EO21 = c.String(),
                        EO22 = c.String(),
                        EO23 = c.String(),
                        EO24 = c.String(),
                        EO25 = c.String(),
                        EO26 = c.String(),
                        EO27 = c.String(),
                        EO28 = c.String(),
                        EO29 = c.String(),
                        EO30 = c.String(),
                        EO31 = c.String(),
                        EO32 = c.String(),
                        VO121 = c.String(),
                        VO141 = c.String(),
                        VO122 = c.String(),
                        VO142 = c.String(),
                        VO123 = c.String(),
                        VO143 = c.String(),
                        VO124 = c.String(),
                        VO144 = c.String(),
                        VO125 = c.String(),
                        VO145 = c.String(),
                        VO126 = c.String(),
                        VO146 = c.String(),
                        VO127 = c.String(),
                        VO147 = c.String(),
                        VO128 = c.String(),
                        VO148 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TimeOfVentils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TVO121 = c.Short(nullable: false),
                        TVO141 = c.Short(nullable: false),
                        TVO122 = c.Short(nullable: false),
                        TVO142 = c.Short(nullable: false),
                        TVO123 = c.Short(nullable: false),
                        TVO143 = c.Short(nullable: false),
                        TVO124 = c.Short(nullable: false),
                        TVO144 = c.Short(nullable: false),
                        TVO125 = c.Short(nullable: false),
                        TVO145 = c.Short(nullable: false),
                        TVO126 = c.Short(nullable: false),
                        TVO146 = c.Short(nullable: false),
                        TVO127 = c.Short(nullable: false),
                        TVO147 = c.Short(nullable: false),
                        TVO128 = c.Short(nullable: false),
                        TVO148 = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DatHEs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToolCode = c.Int(nullable: false),
                        ToolName = c.String(),
                        HK01_TempSoll = c.Short(nullable: false),
                        HK01_ToleranzPlus = c.Short(nullable: false),
                        HK01_ToleranzMinus = c.Short(nullable: false),
                        HK01_TempTaktung = c.Short(nullable: false),
                        HK01_Impulsdauer = c.Short(nullable: false),
                        HK01_Pausendauer = c.Short(nullable: false),
                        HK01_OffsetAT = c.Short(nullable: false),
                        HK01_PiAT = c.Short(nullable: false),
                        HK01_TMaxAT = c.Short(nullable: false),
                        HK01_Aktiv = c.Boolean(nullable: false),
                        HK02_TempSoll = c.Short(nullable: false),
                        HK02_ToleranzPlus = c.Short(nullable: false),
                        HK02_ToleranzMinus = c.Short(nullable: false),
                        HK02_TempTaktung = c.Short(nullable: false),
                        HK02_Impulsdauer = c.Short(nullable: false),
                        HK02_Pausendauer = c.Short(nullable: false),
                        HK02_OffsetAT = c.Short(nullable: false),
                        HK02_PiAT = c.Short(nullable: false),
                        HK02_TMaxAT = c.Short(nullable: false),
                        HK02_Aktiv = c.Boolean(nullable: false),
                        HK03_TempSoll = c.Short(nullable: false),
                        HK03_ToleranzPlus = c.Short(nullable: false),
                        HK03_ToleranzMinus = c.Short(nullable: false),
                        HK03_TempTaktung = c.Short(nullable: false),
                        HK03_Impulsdauer = c.Short(nullable: false),
                        HK03_Pausendauer = c.Short(nullable: false),
                        HK03_OffsetAT = c.Short(nullable: false),
                        HK03_PiAT = c.Short(nullable: false),
                        HK03_TMaxAT = c.Short(nullable: false),
                        HK03_Aktiv = c.Boolean(nullable: false),
                        HK04_TempSoll = c.Short(nullable: false),
                        HK04_ToleranzPlus = c.Short(nullable: false),
                        HK04_ToleranzMinus = c.Short(nullable: false),
                        HK04_TempTaktung = c.Short(nullable: false),
                        HK04_Impulsdauer = c.Short(nullable: false),
                        HK04_Pausendauer = c.Short(nullable: false),
                        HK04_OffsetAT = c.Short(nullable: false),
                        HK04_PiAT = c.Short(nullable: false),
                        HK04_TMaxAT = c.Short(nullable: false),
                        HK04_Aktiv = c.Boolean(nullable: false),
                        HK05_TempSoll = c.Short(nullable: false),
                        HK05_ToleranzPlus = c.Short(nullable: false),
                        HK05_ToleranzMinus = c.Short(nullable: false),
                        HK05_TempTaktung = c.Short(nullable: false),
                        HK05_Impulsdauer = c.Short(nullable: false),
                        HK05_Pausendauer = c.Short(nullable: false),
                        HK05_OffsetAT = c.Short(nullable: false),
                        HK05_PiAT = c.Short(nullable: false),
                        HK05_TMaxAT = c.Short(nullable: false),
                        HK05_Aktiv = c.Boolean(nullable: false),
                        HK06_TempSoll = c.Short(nullable: false),
                        HK06_ToleranzPlus = c.Short(nullable: false),
                        HK06_ToleranzMinus = c.Short(nullable: false),
                        HK06_TempTaktung = c.Short(nullable: false),
                        HK06_Impulsdauer = c.Short(nullable: false),
                        HK06_Pausendauer = c.Short(nullable: false),
                        HK06_OffsetAT = c.Short(nullable: false),
                        HK06_PiAT = c.Short(nullable: false),
                        HK06_TMaxAT = c.Short(nullable: false),
                        HK06_Aktiv = c.Boolean(nullable: false),
                        HK07_TempSoll = c.Short(nullable: false),
                        HK07_ToleranzPlus = c.Short(nullable: false),
                        HK07_ToleranzMinus = c.Short(nullable: false),
                        HK07_TempTaktung = c.Short(nullable: false),
                        HK07_Impulsdauer = c.Short(nullable: false),
                        HK07_Pausendauer = c.Short(nullable: false),
                        HK07_OffsetAT = c.Short(nullable: false),
                        HK07_PiAT = c.Short(nullable: false),
                        HK07_TMaxAT = c.Short(nullable: false),
                        HK07_Aktiv = c.Boolean(nullable: false),
                        HK08_TempSoll = c.Short(nullable: false),
                        HK08_ToleranzPlus = c.Short(nullable: false),
                        HK08_ToleranzMinus = c.Short(nullable: false),
                        HK08_TempTaktung = c.Short(nullable: false),
                        HK08_Impulsdauer = c.Short(nullable: false),
                        HK08_Pausendauer = c.Short(nullable: false),
                        HK08_OffsetAT = c.Short(nullable: false),
                        HK08_PiAT = c.Short(nullable: false),
                        HK08_TMaxAT = c.Short(nullable: false),
                        HK08_Aktiv = c.Boolean(nullable: false),
                        HK09_TempSoll = c.Short(nullable: false),
                        HK09_ToleranzPlus = c.Short(nullable: false),
                        HK09_ToleranzMinus = c.Short(nullable: false),
                        HK09_TempTaktung = c.Short(nullable: false),
                        HK09_Impulsdauer = c.Short(nullable: false),
                        HK09_Pausendauer = c.Short(nullable: false),
                        HK09_OffsetAT = c.Short(nullable: false),
                        HK09_PiAT = c.Short(nullable: false),
                        HK09_TMaxAT = c.Short(nullable: false),
                        HK09_Aktiv = c.Boolean(nullable: false),
                        HK10_TempSoll = c.Short(nullable: false),
                        HK10_ToleranzPlus = c.Short(nullable: false),
                        HK10_ToleranzMinus = c.Short(nullable: false),
                        HK10_TempTaktung = c.Short(nullable: false),
                        HK10_Impulsdauer = c.Short(nullable: false),
                        HK10_Pausendauer = c.Short(nullable: false),
                        HK10_OffsetAT = c.Short(nullable: false),
                        HK10_PiAT = c.Short(nullable: false),
                        HK10_TMaxAT = c.Short(nullable: false),
                        HK10_Aktiv = c.Boolean(nullable: false),
                        HK11_TempSoll = c.Short(nullable: false),
                        HK11_ToleranzPlus = c.Short(nullable: false),
                        HK11_ToleranzMinus = c.Short(nullable: false),
                        HK11_TempTaktung = c.Short(nullable: false),
                        HK11_Impulsdauer = c.Short(nullable: false),
                        HK11_Pausendauer = c.Short(nullable: false),
                        HK11_OffsetAT = c.Short(nullable: false),
                        HK11_PiAT = c.Short(nullable: false),
                        HK11_TMaxAT = c.Short(nullable: false),
                        HK11_Aktiv = c.Boolean(nullable: false),
                        HK12_TempSoll = c.Short(nullable: false),
                        HK12_ToleranzPlus = c.Short(nullable: false),
                        HK12_ToleranzMinus = c.Short(nullable: false),
                        HK12_TempTaktung = c.Short(nullable: false),
                        HK12_Impulsdauer = c.Short(nullable: false),
                        HK12_Pausendauer = c.Short(nullable: false),
                        HK12_OffsetAT = c.Short(nullable: false),
                        HK12_PiAT = c.Short(nullable: false),
                        HK12_TMaxAT = c.Short(nullable: false),
                        HK12_Aktiv = c.Boolean(nullable: false),
                        HK13_TempSoll = c.Short(nullable: false),
                        HK13_ToleranzPlus = c.Short(nullable: false),
                        HK13_ToleranzMinus = c.Short(nullable: false),
                        HK13_TempTaktung = c.Short(nullable: false),
                        HK13_Impulsdauer = c.Short(nullable: false),
                        HK13_Pausendauer = c.Short(nullable: false),
                        HK13_OffsetAT = c.Short(nullable: false),
                        HK13_PiAT = c.Short(nullable: false),
                        HK13_TMaxAT = c.Short(nullable: false),
                        HK13_Aktiv = c.Boolean(nullable: false),
                        HK14_TempSoll = c.Short(nullable: false),
                        HK14_ToleranzPlus = c.Short(nullable: false),
                        HK14_ToleranzMinus = c.Short(nullable: false),
                        HK14_TempTaktung = c.Short(nullable: false),
                        HK14_Impulsdauer = c.Short(nullable: false),
                        HK14_Pausendauer = c.Short(nullable: false),
                        HK14_OffsetAT = c.Short(nullable: false),
                        HK14_PiAT = c.Short(nullable: false),
                        HK14_TMaxAT = c.Short(nullable: false),
                        HK14_Aktiv = c.Boolean(nullable: false),
                        HK15_TempSoll = c.Short(nullable: false),
                        HK15_ToleranzPlus = c.Short(nullable: false),
                        HK15_ToleranzMinus = c.Short(nullable: false),
                        HK15_TempTaktung = c.Short(nullable: false),
                        HK15_Impulsdauer = c.Short(nullable: false),
                        HK15_Pausendauer = c.Short(nullable: false),
                        HK15_OffsetAT = c.Short(nullable: false),
                        HK15_PiAT = c.Short(nullable: false),
                        HK15_TMaxAT = c.Short(nullable: false),
                        HK15_Aktiv = c.Boolean(nullable: false),
                        HK16_TempSoll = c.Short(nullable: false),
                        HK16_ToleranzPlus = c.Short(nullable: false),
                        HK16_ToleranzMinus = c.Short(nullable: false),
                        HK16_TempTaktung = c.Short(nullable: false),
                        HK16_Impulsdauer = c.Short(nullable: false),
                        HK16_Pausendauer = c.Short(nullable: false),
                        HK16_OffsetAT = c.Short(nullable: false),
                        HK16_PiAT = c.Short(nullable: false),
                        HK16_TMaxAT = c.Short(nullable: false),
                        HK16_Aktiv = c.Boolean(nullable: false),
                        HK17_TempSoll = c.Short(nullable: false),
                        HK17_ToleranzPlus = c.Short(nullable: false),
                        HK17_ToleranzMinus = c.Short(nullable: false),
                        HK17_TempTaktung = c.Short(nullable: false),
                        HK17_Impulsdauer = c.Short(nullable: false),
                        HK17_Pausendauer = c.Short(nullable: false),
                        HK17_OffsetAT = c.Short(nullable: false),
                        HK17_PiAT = c.Short(nullable: false),
                        HK17_TMaxAT = c.Short(nullable: false),
                        HK17_Aktiv = c.Boolean(nullable: false),
                        HK18_TempSoll = c.Short(nullable: false),
                        HK18_ToleranzPlus = c.Short(nullable: false),
                        HK18_ToleranzMinus = c.Short(nullable: false),
                        HK18_TempTaktung = c.Short(nullable: false),
                        HK18_Impulsdauer = c.Short(nullable: false),
                        HK18_Pausendauer = c.Short(nullable: false),
                        HK18_OffsetAT = c.Short(nullable: false),
                        HK18_PiAT = c.Short(nullable: false),
                        HK18_TMaxAT = c.Short(nullable: false),
                        HK18_Aktiv = c.Boolean(nullable: false),
                        HK19_TempSoll = c.Short(nullable: false),
                        HK19_ToleranzPlus = c.Short(nullable: false),
                        HK19_ToleranzMinus = c.Short(nullable: false),
                        HK19_TempTaktung = c.Short(nullable: false),
                        HK19_Impulsdauer = c.Short(nullable: false),
                        HK19_Pausendauer = c.Short(nullable: false),
                        HK19_OffsetAT = c.Short(nullable: false),
                        HK19_PiAT = c.Short(nullable: false),
                        HK19_TMaxAT = c.Short(nullable: false),
                        HK19_Aktiv = c.Boolean(nullable: false),
                        HK20_TempSoll = c.Short(nullable: false),
                        HK20_ToleranzPlus = c.Short(nullable: false),
                        HK20_ToleranzMinus = c.Short(nullable: false),
                        HK20_TempTaktung = c.Short(nullable: false),
                        HK20_Impulsdauer = c.Short(nullable: false),
                        HK20_Pausendauer = c.Short(nullable: false),
                        HK20_OffsetAT = c.Short(nullable: false),
                        HK20_PiAT = c.Short(nullable: false),
                        HK20_TMaxAT = c.Short(nullable: false),
                        HK20_Aktiv = c.Boolean(nullable: false),
                        HK21_TempSoll = c.Short(nullable: false),
                        HK21_ToleranzPlus = c.Short(nullable: false),
                        HK21_ToleranzMinus = c.Short(nullable: false),
                        HK21_TempTaktung = c.Short(nullable: false),
                        HK21_Impulsdauer = c.Short(nullable: false),
                        HK21_Pausendauer = c.Short(nullable: false),
                        HK21_OffsetAT = c.Short(nullable: false),
                        HK21_PiAT = c.Short(nullable: false),
                        HK21_TMaxAT = c.Short(nullable: false),
                        HK21_Aktiv = c.Boolean(nullable: false),
                        HK22_TempSoll = c.Short(nullable: false),
                        HK22_ToleranzPlus = c.Short(nullable: false),
                        HK22_ToleranzMinus = c.Short(nullable: false),
                        HK22_TempTaktung = c.Short(nullable: false),
                        HK22_Impulsdauer = c.Short(nullable: false),
                        HK22_Pausendauer = c.Short(nullable: false),
                        HK22_OffsetAT = c.Short(nullable: false),
                        HK22_PiAT = c.Short(nullable: false),
                        HK22_TMaxAT = c.Short(nullable: false),
                        HK22_Aktiv = c.Boolean(nullable: false),
                        HK23_TempSoll = c.Short(nullable: false),
                        HK23_ToleranzPlus = c.Short(nullable: false),
                        HK23_ToleranzMinus = c.Short(nullable: false),
                        HK23_TempTaktung = c.Short(nullable: false),
                        HK23_Impulsdauer = c.Short(nullable: false),
                        HK23_Pausendauer = c.Short(nullable: false),
                        HK23_OffsetAT = c.Short(nullable: false),
                        HK23_PiAT = c.Short(nullable: false),
                        HK23_TMaxAT = c.Short(nullable: false),
                        HK23_Aktiv = c.Boolean(nullable: false),
                        HK24_TempSoll = c.Short(nullable: false),
                        HK24_ToleranzPlus = c.Short(nullable: false),
                        HK24_ToleranzMinus = c.Short(nullable: false),
                        HK24_TempTaktung = c.Short(nullable: false),
                        HK24_Impulsdauer = c.Short(nullable: false),
                        HK24_Pausendauer = c.Short(nullable: false),
                        HK24_OffsetAT = c.Short(nullable: false),
                        HK24_PiAT = c.Short(nullable: false),
                        HK24_TMaxAT = c.Short(nullable: false),
                        HK24_Aktiv = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DatMWerkzeugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToolCode = c.Int(nullable: false),
                        ToolName = c.String(),
                        MachineId = c.Int(nullable: false),
                        WerkzeughoeheA1 = c.Int(nullable: false),
                        WerkzeughoeheA2 = c.Int(nullable: false),
                        HeizelementhoeheObenA3 = c.Int(nullable: false),
                        HeizelementhoeheUntenA3 = c.Int(nullable: false),
                        WarmpositionA3 = c.Int(nullable: false),
                        BestueckungspositionA1 = c.Int(nullable: false),
                        BestueckungspositionA2 = c.Int(nullable: false),
                        PruefpositionA1 = c.Int(nullable: false),
                        PruefpositionA2 = c.Int(nullable: false),
                        IRKameraTriggerpositionA3 = c.Int(nullable: false),
                        Recipe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id, cascadeDelete: true)
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToolCode = c.Int(nullable: false),
                        ToolName = c.String(),
                        DatHEId = c.Int(),
                        DatConfigId = c.Int(),
                        DatN2Id = c.Int(),
                        DatWerkzeugId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DatConfigs", t => t.DatConfigId)
                .ForeignKey("dbo.DatHEs", t => t.DatHEId)
                .ForeignKey("dbo.DatN2", t => t.DatN2Id)
                .ForeignKey("dbo.DatWerkzeugs", t => t.DatWerkzeugId)
                .Index(t => t.DatHEId)
                .Index(t => t.DatConfigId)
                .Index(t => t.DatN2Id)
                .Index(t => t.DatWerkzeugId);
            
            CreateTable(
                "dbo.DatN2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToolCode = c.Int(nullable: false),
                        ToolName = c.String(),
                        Propventil01_Soll = c.Double(nullable: false),
                        Propventil01_ToleranzPlus = c.Double(nullable: false),
                        Propventil01_ToleranzMinus = c.Double(nullable: false),
                        Propventil01_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil02_Soll = c.Double(nullable: false),
                        Propventil02_ToleranzPlus = c.Double(nullable: false),
                        Propventil02_ToleranzMinus = c.Double(nullable: false),
                        Propventil02_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil03_Soll = c.Double(nullable: false),
                        Propventil03_ToleranzPlus = c.Double(nullable: false),
                        Propventil03_ToleranzMinus = c.Double(nullable: false),
                        Propventil03_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil04_Soll = c.Double(nullable: false),
                        Propventil04_ToleranzPlus = c.Double(nullable: false),
                        Propventil04_ToleranzMinus = c.Double(nullable: false),
                        Propventil04_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil05_Soll = c.Double(nullable: false),
                        Propventil05_ToleranzPlus = c.Double(nullable: false),
                        Propventil05_ToleranzMinus = c.Double(nullable: false),
                        Propventil05_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil06_Soll = c.Double(nullable: false),
                        Propventil06_ToleranzPlus = c.Double(nullable: false),
                        Propventil06_ToleranzMinus = c.Double(nullable: false),
                        Propventil06_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil07_Soll = c.Double(nullable: false),
                        Propventil07_ToleranzPlus = c.Double(nullable: false),
                        Propventil07_ToleranzMinus = c.Double(nullable: false),
                        Propventil07_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil08_Soll = c.Double(nullable: false),
                        Propventil08_ToleranzPlus = c.Double(nullable: false),
                        Propventil08_ToleranzMinus = c.Double(nullable: false),
                        Propventil08_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil09_Soll = c.Double(nullable: false),
                        Propventil09_ToleranzPlus = c.Double(nullable: false),
                        Propventil09_ToleranzMinus = c.Double(nullable: false),
                        Propventil09_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil10_Soll = c.Double(nullable: false),
                        Propventil10_ToleranzPlus = c.Double(nullable: false),
                        Propventil10_ToleranzMinus = c.Double(nullable: false),
                        Propventil10_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil11_Soll = c.Double(nullable: false),
                        Propventil11_ToleranzPlus = c.Double(nullable: false),
                        Propventil11_ToleranzMinus = c.Double(nullable: false),
                        Propventil11_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil12_Soll = c.Double(nullable: false),
                        Propventil12_ToleranzPlus = c.Double(nullable: false),
                        Propventil12_ToleranzMinus = c.Double(nullable: false),
                        Propventil12_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil13_Soll = c.Double(nullable: false),
                        Propventil13_ToleranzPlus = c.Double(nullable: false),
                        Propventil13_ToleranzMinus = c.Double(nullable: false),
                        Propventil13_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil14_Soll = c.Double(nullable: false),
                        Propventil14_ToleranzPlus = c.Double(nullable: false),
                        Propventil14_ToleranzMinus = c.Double(nullable: false),
                        Propventil14_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil15_Soll = c.Double(nullable: false),
                        Propventil15_ToleranzPlus = c.Double(nullable: false),
                        Propventil15_ToleranzMinus = c.Double(nullable: false),
                        Propventil15_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil16_Soll = c.Double(nullable: false),
                        Propventil16_ToleranzPlus = c.Double(nullable: false),
                        Propventil16_ToleranzMinus = c.Double(nullable: false),
                        Propventil16_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil17_Soll = c.Double(nullable: false),
                        Propventil17_ToleranzPlus = c.Double(nullable: false),
                        Propventil17_ToleranzMinus = c.Double(nullable: false),
                        Propventil17_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil18_Soll = c.Double(nullable: false),
                        Propventil18_ToleranzPlus = c.Double(nullable: false),
                        Propventil18_ToleranzMinus = c.Double(nullable: false),
                        Propventil18_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil19_Soll = c.Double(nullable: false),
                        Propventil19_ToleranzPlus = c.Double(nullable: false),
                        Propventil19_ToleranzMinus = c.Double(nullable: false),
                        Propventil19_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil20_Soll = c.Double(nullable: false),
                        Propventil20_ToleranzPlus = c.Double(nullable: false),
                        Propventil20_ToleranzMinus = c.Double(nullable: false),
                        Propventil20_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil21_Soll = c.Double(nullable: false),
                        Propventil21_ToleranzPlus = c.Double(nullable: false),
                        Propventil21_ToleranzMinus = c.Double(nullable: false),
                        Propventil21_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil22_Soll = c.Double(nullable: false),
                        Propventil22_ToleranzPlus = c.Double(nullable: false),
                        Propventil22_ToleranzMinus = c.Double(nullable: false),
                        Propventil22_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil23_Soll = c.Double(nullable: false),
                        Propventil23_ToleranzPlus = c.Double(nullable: false),
                        Propventil23_ToleranzMinus = c.Double(nullable: false),
                        Propventil23_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil24_Soll = c.Double(nullable: false),
                        Propventil24_ToleranzPlus = c.Double(nullable: false),
                        Propventil24_ToleranzMinus = c.Double(nullable: false),
                        Propventil24_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil25_Soll = c.Double(nullable: false),
                        Propventil25_ToleranzPlus = c.Double(nullable: false),
                        Propventil25_ToleranzMinus = c.Double(nullable: false),
                        Propventil25_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil26_Soll = c.Double(nullable: false),
                        Propventil26_ToleranzPlus = c.Double(nullable: false),
                        Propventil26_ToleranzMinus = c.Double(nullable: false),
                        Propventil26_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil27_Soll = c.Double(nullable: false),
                        Propventil27_ToleranzPlus = c.Double(nullable: false),
                        Propventil27_ToleranzMinus = c.Double(nullable: false),
                        Propventil27_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil28_Soll = c.Double(nullable: false),
                        Propventil28_ToleranzPlus = c.Double(nullable: false),
                        Propventil28_ToleranzMinus = c.Double(nullable: false),
                        Propventil28_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil29_Soll = c.Double(nullable: false),
                        Propventil29_ToleranzPlus = c.Double(nullable: false),
                        Propventil29_ToleranzMinus = c.Double(nullable: false),
                        Propventil29_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil30_Soll = c.Double(nullable: false),
                        Propventil30_ToleranzPlus = c.Double(nullable: false),
                        Propventil30_ToleranzMinus = c.Double(nullable: false),
                        Propventil30_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil31_Soll = c.Double(nullable: false),
                        Propventil31_ToleranzPlus = c.Double(nullable: false),
                        Propventil31_ToleranzMinus = c.Double(nullable: false),
                        Propventil31_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil32_Soll = c.Double(nullable: false),
                        Propventil32_ToleranzPlus = c.Double(nullable: false),
                        Propventil32_ToleranzMinus = c.Double(nullable: false),
                        Propventil32_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil33_Soll = c.Double(nullable: false),
                        Propventil33_ToleranzPlus = c.Double(nullable: false),
                        Propventil33_ToleranzMinus = c.Double(nullable: false),
                        Propventil33_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil34_Soll = c.Double(nullable: false),
                        Propventil34_ToleranzPlus = c.Double(nullable: false),
                        Propventil34_ToleranzMinus = c.Double(nullable: false),
                        Propventil34_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil35_Soll = c.Double(nullable: false),
                        Propventil35_ToleranzPlus = c.Double(nullable: false),
                        Propventil35_ToleranzMinus = c.Double(nullable: false),
                        Propventil35_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil36_Soll = c.Double(nullable: false),
                        Propventil36_ToleranzPlus = c.Double(nullable: false),
                        Propventil36_ToleranzMinus = c.Double(nullable: false),
                        Propventil36_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil37_Soll = c.Double(nullable: false),
                        Propventil37_ToleranzPlus = c.Double(nullable: false),
                        Propventil37_ToleranzMinus = c.Double(nullable: false),
                        Propventil37_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil38_Soll = c.Double(nullable: false),
                        Propventil38_ToleranzPlus = c.Double(nullable: false),
                        Propventil38_ToleranzMinus = c.Double(nullable: false),
                        Propventil38_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil39_Soll = c.Double(nullable: false),
                        Propventil39_ToleranzPlus = c.Double(nullable: false),
                        Propventil39_ToleranzMinus = c.Double(nullable: false),
                        Propventil39_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil40_Soll = c.Double(nullable: false),
                        Propventil40_ToleranzPlus = c.Double(nullable: false),
                        Propventil40_ToleranzMinus = c.Double(nullable: false),
                        Propventil40_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil41_Soll = c.Double(nullable: false),
                        Propventil41_ToleranzPlus = c.Double(nullable: false),
                        Propventil41_ToleranzMinus = c.Double(nullable: false),
                        Propventil41_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil42_Soll = c.Double(nullable: false),
                        Propventil42_ToleranzPlus = c.Double(nullable: false),
                        Propventil42_ToleranzMinus = c.Double(nullable: false),
                        Propventil42_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil43_Soll = c.Double(nullable: false),
                        Propventil43_ToleranzPlus = c.Double(nullable: false),
                        Propventil43_ToleranzMinus = c.Double(nullable: false),
                        Propventil43_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil44_Soll = c.Double(nullable: false),
                        Propventil44_ToleranzPlus = c.Double(nullable: false),
                        Propventil44_ToleranzMinus = c.Double(nullable: false),
                        Propventil44_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil45_Soll = c.Double(nullable: false),
                        Propventil45_ToleranzPlus = c.Double(nullable: false),
                        Propventil45_ToleranzMinus = c.Double(nullable: false),
                        Propventil45_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil46_Soll = c.Double(nullable: false),
                        Propventil46_ToleranzPlus = c.Double(nullable: false),
                        Propventil46_ToleranzMinus = c.Double(nullable: false),
                        Propventil46_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil47_Soll = c.Double(nullable: false),
                        Propventil47_ToleranzPlus = c.Double(nullable: false),
                        Propventil47_ToleranzMinus = c.Double(nullable: false),
                        Propventil47_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil48_Soll = c.Double(nullable: false),
                        Propventil48_ToleranzPlus = c.Double(nullable: false),
                        Propventil48_ToleranzMinus = c.Double(nullable: false),
                        Propventil48_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil49_Soll = c.Double(nullable: false),
                        Propventil49_ToleranzPlus = c.Double(nullable: false),
                        Propventil49_ToleranzMinus = c.Double(nullable: false),
                        Propventil49_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil50_Soll = c.Double(nullable: false),
                        Propventil50_ToleranzPlus = c.Double(nullable: false),
                        Propventil50_ToleranzMinus = c.Double(nullable: false),
                        Propventil50_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil51_Soll = c.Double(nullable: false),
                        Propventil51_ToleranzPlus = c.Double(nullable: false),
                        Propventil51_ToleranzMinus = c.Double(nullable: false),
                        Propventil51_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil52_Soll = c.Double(nullable: false),
                        Propventil52_ToleranzPlus = c.Double(nullable: false),
                        Propventil52_ToleranzMinus = c.Double(nullable: false),
                        Propventil52_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil53_Soll = c.Double(nullable: false),
                        Propventil53_ToleranzPlus = c.Double(nullable: false),
                        Propventil53_ToleranzMinus = c.Double(nullable: false),
                        Propventil53_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil54_Soll = c.Double(nullable: false),
                        Propventil54_ToleranzPlus = c.Double(nullable: false),
                        Propventil54_ToleranzMinus = c.Double(nullable: false),
                        Propventil54_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil55_Soll = c.Double(nullable: false),
                        Propventil55_ToleranzPlus = c.Double(nullable: false),
                        Propventil55_ToleranzMinus = c.Double(nullable: false),
                        Propventil55_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil56_Soll = c.Double(nullable: false),
                        Propventil56_ToleranzPlus = c.Double(nullable: false),
                        Propventil56_ToleranzMinus = c.Double(nullable: false),
                        Propventil56_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil57_Soll = c.Double(nullable: false),
                        Propventil57_ToleranzPlus = c.Double(nullable: false),
                        Propventil57_ToleranzMinus = c.Double(nullable: false),
                        Propventil57_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil58_Soll = c.Double(nullable: false),
                        Propventil58_ToleranzPlus = c.Double(nullable: false),
                        Propventil58_ToleranzMinus = c.Double(nullable: false),
                        Propventil58_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil59_Soll = c.Double(nullable: false),
                        Propventil59_ToleranzPlus = c.Double(nullable: false),
                        Propventil59_ToleranzMinus = c.Double(nullable: false),
                        Propventil59_Einschaltverzoegerung = c.Double(nullable: false),
                        Propventil60_Soll = c.Double(nullable: false),
                        Propventil60_ToleranzPlus = c.Double(nullable: false),
                        Propventil60_ToleranzMinus = c.Double(nullable: false),
                        Propventil60_Einschaltverzoegerung = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DatWerkzeugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToolCode = c.Int(nullable: false),
                        ToolName = c.String(),
                        AchsenStrom_Id = c.Int(),
                        AktivierungN2Gas_Id = c.Int(),
                        AktivierungSchritte_Id = c.Int(),
                        AktivierungSontiges_Id = c.Int(),
                        Ausgleichshub_Id = c.Int(),
                        BursterDigiforceKraftWeg_Id = c.Int(),
                        BursterDigiforceMinsdestkraft_Id = c.Int(),
                        DMXCheck_Id = c.Int(),
                        IRCamera_Id = c.Int(),
                        Kennung_Id = c.Int(),
                        ParameterSchritte_Id = c.Int(),
                        Zaehler_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AchsenStromClasses", t => t.AchsenStrom_Id)
                .ForeignKey("dbo.AktivierungN2GasClass", t => t.AktivierungN2Gas_Id)
                .ForeignKey("dbo.AktivierungSchritteClasses", t => t.AktivierungSchritte_Id)
                .ForeignKey("dbo.AktivierungSontigesClasses", t => t.AktivierungSontiges_Id)
                .ForeignKey("dbo.Ausgleichshubs", t => t.Ausgleichshub_Id)
                .ForeignKey("dbo.BursterDigiforceKraftWegClasses", t => t.BursterDigiforceKraftWeg_Id)
                .ForeignKey("dbo.BursterDigiforceMinsdestkraftClasses", t => t.BursterDigiforceMinsdestkraft_Id)
                .ForeignKey("dbo.DMXCheckClasses", t => t.DMXCheck_Id)
                .ForeignKey("dbo.IRCameraClasses", t => t.IRCamera_Id)
                .ForeignKey("dbo.KennungClasses", t => t.Kennung_Id)
                .ForeignKey("dbo.ParameterSchritteClasses", t => t.ParameterSchritte_Id)
                .ForeignKey("dbo.ZaehlerClasses", t => t.Zaehler_Id)
                .Index(t => t.AchsenStrom_Id)
                .Index(t => t.AktivierungN2Gas_Id)
                .Index(t => t.AktivierungSchritte_Id)
                .Index(t => t.AktivierungSontiges_Id)
                .Index(t => t.Ausgleichshub_Id)
                .Index(t => t.BursterDigiforceKraftWeg_Id)
                .Index(t => t.BursterDigiforceMinsdestkraft_Id)
                .Index(t => t.DMXCheck_Id)
                .Index(t => t.IRCamera_Id)
                .Index(t => t.Kennung_Id)
                .Index(t => t.ParameterSchritte_Id)
                .Index(t => t.Zaehler_Id);
            
            CreateTable(
                "dbo.AchsenStromClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FuegekraftMaxA1 = c.Short(nullable: false),
                        FuegekraftMinA1 = c.Short(nullable: false),
                        FuegekraftMaxA2 = c.Short(nullable: false),
                        FuegekraftMinA2 = c.Short(nullable: false),
                        Strommessung = c.Byte(nullable: false),
                        FuegenStart = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AktivierungN2GasClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        N2G1 = c.Boolean(nullable: false),
                        N2G2 = c.Boolean(nullable: false),
                        N2G3 = c.Boolean(nullable: false),
                        N2G4 = c.Boolean(nullable: false),
                        Reserve5 = c.Boolean(nullable: false),
                        Reserve6 = c.Boolean(nullable: false),
                        Reserve7 = c.Boolean(nullable: false),
                        Reserve8 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AktivierungSchritteClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SpannenT1 = c.Boolean(nullable: false),
                        SpannenT2 = c.Boolean(nullable: false),
                        Abholtakt = c.Boolean(nullable: false),
                        Prueftakt = c.Boolean(nullable: false),
                        WarmVor = c.Boolean(nullable: false),
                        WarmEnde = c.Boolean(nullable: false),
                        Auswerfer = c.Boolean(nullable: false),
                        Roboter = c.Boolean(nullable: false),
                        Reserve4 = c.Boolean(nullable: false),
                        Reserve5 = c.Boolean(nullable: false),
                        Reserve6 = c.Boolean(nullable: false),
                        Reserve7 = c.Boolean(nullable: false),
                        Reserve8 = c.Boolean(nullable: false),
                        Reserve9 = c.Boolean(nullable: false),
                        StopNachFuegen = c.Boolean(nullable: false),
                        OeffnenNachFuegen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AktivierungSontigesClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExternerE1 = c.Boolean(nullable: false),
                        ExternerE2 = c.Boolean(nullable: false),
                        ExternePruefung1 = c.Boolean(nullable: false),
                        ExternePruefung2 = c.Boolean(nullable: false),
                        OptionUmschaltung1 = c.Boolean(nullable: false),
                        Reserve6 = c.Boolean(nullable: false),
                        Reserve7 = c.Boolean(nullable: false),
                        Reserve8 = c.Boolean(nullable: false),
                        Reserve9 = c.Boolean(nullable: false),
                        Reserve10 = c.Boolean(nullable: false),
                        Reserve11 = c.Boolean(nullable: false),
                        Reserve12 = c.Boolean(nullable: false),
                        Reserve13 = c.Boolean(nullable: false),
                        Reserve14 = c.Boolean(nullable: false),
                        Reserve15 = c.Boolean(nullable: false),
                        Reserve16 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ausgleichshubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Links = c.Double(nullable: false),
                        Rechts = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BursterDigiforceKraftWegClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FuegewegKraftNest1 = c.Byte(nullable: false),
                        FuegewegKraftNest2 = c.Byte(nullable: false),
                        BursterProgrammNest1 = c.Short(nullable: false),
                        BursterProgrammNest2 = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BursterDigiforceMinsdestkraftClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BursterMindestKraftAktiv = c.Boolean(nullable: false),
                        MindestkraftSollNest1 = c.Single(nullable: false),
                        MindestkraftToleranzPlusNest1 = c.Single(nullable: false),
                        MindestkraftToleranzMinusNest1 = c.Single(nullable: false),
                        MindestkraftSollNest2 = c.Single(nullable: false),
                        MindestkraftToleranzPlusNest2 = c.Single(nullable: false),
                        MindestkraftToleranzMinusNest2 = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DMXCheckClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayDifferenceSet = c.Int(nullable: false),
                        ActiveDMXCheck = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IRCameraClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KameraSchalter = c.Byte(nullable: false),
                        KameraLuftschleier = c.Int(nullable: false),
                        KameraStartFuegenNachIR = c.Int(nullable: false),
                        KameraFehlerVrzNachIR = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KennungClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProgrammName = c.String(),
                        RFIDHE = c.Byte(nullable: false),
                        RFIDOB = c.Byte(nullable: false),
                        RFIDUN = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParameterSchritteClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Abhol_Id = c.Int(),
                        Fuege_Id = c.Int(),
                        HEVorposition_Id = c.Int(),
                        Schmelzbild_Id = c.Int(),
                        Warm1_Id = c.Int(),
                        Warm2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AbholSchrittClasses", t => t.Abhol_Id)
                .ForeignKey("dbo.FuegeSchrittClasses", t => t.Fuege_Id)
                .ForeignKey("dbo.HEVorpositionSchrittClasses", t => t.HEVorposition_Id)
                .ForeignKey("dbo.SchmelzbildSchrittClasses", t => t.Schmelzbild_Id)
                .ForeignKey("dbo.Warm1SchrittClass", t => t.Warm1_Id)
                .ForeignKey("dbo.Warm2SchrittClass", t => t.Warm2_Id)
                .Index(t => t.Abhol_Id)
                .Index(t => t.Fuege_Id)
                .Index(t => t.HEVorposition_Id)
                .Index(t => t.Schmelzbild_Id)
                .Index(t => t.Warm1_Id)
                .Index(t => t.Warm2_Id);
            
            CreateTable(
                "dbo.AbholSchrittClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_Id = c.Int(),
                        A2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AbholAchseA1A2Class", t => t.A1_Id)
                .ForeignKey("dbo.AbholAchseA1A2Class", t => t.A2_Id)
                .Index(t => t.A1_Id)
                .Index(t => t.A2_Id);
            
            CreateTable(
                "dbo.AbholAchseA1A2Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VorPosition = c.Int(nullable: false),
                        EndPosition = c.Int(nullable: false),
                        Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuegeSchrittClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kuehlzeit = c.Int(nullable: false),
                        A1_Id = c.Int(),
                        A2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FuegeAchseA1Class", t => t.A1_Id)
                .ForeignKey("dbo.FuegeAchseA2Class", t => t.A2_Id)
                .Index(t => t.A1_Id)
                .Index(t => t.A2_Id);
            
            CreateTable(
                "dbo.FuegeAchseA1Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VorPosition = c.Int(nullable: false),
                        EndPosition = c.Int(nullable: false),
                        Geschwindigkeit = c.Int(nullable: false),
                        OeffnungswegNachFuegen = c.Int(nullable: false),
                        RueckhubGeschwingkeitFuegen = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuegeAchseA2Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VorPosition = c.Int(nullable: false),
                        EndPosition = c.Int(nullable: false),
                        Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HEVorpositionSchrittClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_Id = c.Int(),
                        A2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HEVorpositionAchseA1A2Class", t => t.A1_Id)
                .ForeignKey("dbo.HEVorpositionAchseA1A2Class", t => t.A2_Id)
                .Index(t => t.A1_Id)
                .Index(t => t.A2_Id);
            
            CreateTable(
                "dbo.HEVorpositionAchseA1A2Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SchmelzbildSchrittClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchmelzbildAchseA1Class", t => t.A1_Id)
                .Index(t => t.A1_Id);
            
            CreateTable(
                "dbo.SchmelzbildAchseA1Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warm1SchrittClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Zeit = c.Int(nullable: false),
                        A1_Id = c.Int(),
                        A2_Id = c.Int(),
                        A3_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Warm1AchseA1A2Class", t => t.A1_Id)
                .ForeignKey("dbo.Warm1AchseA1A2Class", t => t.A2_Id)
                .ForeignKey("dbo.Warm1AchseA3Class", t => t.A3_Id)
                .Index(t => t.A1_Id)
                .Index(t => t.A2_Id)
                .Index(t => t.A3_Id);
            
            CreateTable(
                "dbo.Warm1AchseA1A2Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warm1AchseA3Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warm2SchrittClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Zeit = c.Int(nullable: false),
                        A1_Id = c.Int(),
                        A2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Warm2AchseA1A2Class", t => t.A1_Id)
                .ForeignKey("dbo.Warm2AchseA1A2Class", t => t.A2_Id)
                .Index(t => t.A1_Id)
                .Index(t => t.A2_Id);
            
            CreateTable(
                "dbo.Warm2AchseA1A2Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ZaehlerClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NIONF = c.Short(nullable: false),
                        NIOVF = c.Short(nullable: false),
                        Stueckzaehler = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DatMWerkzeugs", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipes", "DatWerkzeugId", "dbo.DatWerkzeugs");
            DropForeignKey("dbo.DatWerkzeugs", "Zaehler_Id", "dbo.ZaehlerClasses");
            DropForeignKey("dbo.DatWerkzeugs", "ParameterSchritte_Id", "dbo.ParameterSchritteClasses");
            DropForeignKey("dbo.ParameterSchritteClasses", "Warm2_Id", "dbo.Warm2SchrittClass");
            DropForeignKey("dbo.Warm2SchrittClass", "A2_Id", "dbo.Warm2AchseA1A2Class");
            DropForeignKey("dbo.Warm2SchrittClass", "A1_Id", "dbo.Warm2AchseA1A2Class");
            DropForeignKey("dbo.ParameterSchritteClasses", "Warm1_Id", "dbo.Warm1SchrittClass");
            DropForeignKey("dbo.Warm1SchrittClass", "A3_Id", "dbo.Warm1AchseA3Class");
            DropForeignKey("dbo.Warm1SchrittClass", "A2_Id", "dbo.Warm1AchseA1A2Class");
            DropForeignKey("dbo.Warm1SchrittClass", "A1_Id", "dbo.Warm1AchseA1A2Class");
            DropForeignKey("dbo.ParameterSchritteClasses", "Schmelzbild_Id", "dbo.SchmelzbildSchrittClasses");
            DropForeignKey("dbo.SchmelzbildSchrittClasses", "A1_Id", "dbo.SchmelzbildAchseA1Class");
            DropForeignKey("dbo.ParameterSchritteClasses", "HEVorposition_Id", "dbo.HEVorpositionSchrittClasses");
            DropForeignKey("dbo.HEVorpositionSchrittClasses", "A2_Id", "dbo.HEVorpositionAchseA1A2Class");
            DropForeignKey("dbo.HEVorpositionSchrittClasses", "A1_Id", "dbo.HEVorpositionAchseA1A2Class");
            DropForeignKey("dbo.ParameterSchritteClasses", "Fuege_Id", "dbo.FuegeSchrittClasses");
            DropForeignKey("dbo.FuegeSchrittClasses", "A2_Id", "dbo.FuegeAchseA2Class");
            DropForeignKey("dbo.FuegeSchrittClasses", "A1_Id", "dbo.FuegeAchseA1Class");
            DropForeignKey("dbo.ParameterSchritteClasses", "Abhol_Id", "dbo.AbholSchrittClasses");
            DropForeignKey("dbo.AbholSchrittClasses", "A2_Id", "dbo.AbholAchseA1A2Class");
            DropForeignKey("dbo.AbholSchrittClasses", "A1_Id", "dbo.AbholAchseA1A2Class");
            DropForeignKey("dbo.DatWerkzeugs", "Kennung_Id", "dbo.KennungClasses");
            DropForeignKey("dbo.DatWerkzeugs", "IRCamera_Id", "dbo.IRCameraClasses");
            DropForeignKey("dbo.DatWerkzeugs", "DMXCheck_Id", "dbo.DMXCheckClasses");
            DropForeignKey("dbo.DatWerkzeugs", "BursterDigiforceMinsdestkraft_Id", "dbo.BursterDigiforceMinsdestkraftClasses");
            DropForeignKey("dbo.DatWerkzeugs", "BursterDigiforceKraftWeg_Id", "dbo.BursterDigiforceKraftWegClasses");
            DropForeignKey("dbo.DatWerkzeugs", "Ausgleichshub_Id", "dbo.Ausgleichshubs");
            DropForeignKey("dbo.DatWerkzeugs", "AktivierungSontiges_Id", "dbo.AktivierungSontigesClasses");
            DropForeignKey("dbo.DatWerkzeugs", "AktivierungSchritte_Id", "dbo.AktivierungSchritteClasses");
            DropForeignKey("dbo.DatWerkzeugs", "AktivierungN2Gas_Id", "dbo.AktivierungN2GasClass");
            DropForeignKey("dbo.DatWerkzeugs", "AchsenStrom_Id", "dbo.AchsenStromClasses");
            DropForeignKey("dbo.Recipes", "DatN2Id", "dbo.DatN2");
            DropForeignKey("dbo.Recipes", "DatHEId", "dbo.DatHEs");
            DropForeignKey("dbo.Recipes", "DatConfigId", "dbo.DatConfigs");
            DropForeignKey("dbo.DatConfigs", "ZYE_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "ZYA_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "WV_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "WKZUN_Id", "dbo.WerkzeugConfigs");
            DropForeignKey("dbo.DatConfigs", "WKZOB_Id", "dbo.WerkzeugConfigs");
            DropForeignKey("dbo.WerkzeugConfigs", "Time_Id", "dbo.TimeOfVentils");
            DropForeignKey("dbo.WerkzeugConfigs", "Name_Id", "dbo.NameOfInputs");
            DropForeignKey("dbo.DatConfigs", "WE_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "TK_Id", "dbo.Teilekontrolles");
            DropForeignKey("dbo.Teilekontrolles", "UN_Id", "dbo.UDTConfigSchritts");
            DropForeignKey("dbo.Teilekontrolles", "OB_Id", "dbo.UDTConfigSchritts");
            DropForeignKey("dbo.DatConfigs", "T2_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "T1_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "RO_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "Reserve_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "PT_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "PN_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "KU_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "GS_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "AV_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "AU_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "AP_Id", "dbo.Schritts");
            DropForeignKey("dbo.Schritts", "UN_IG_Id", "dbo.UDTConfigSchritts");
            DropForeignKey("dbo.Schritts", "UN_Id", "dbo.UDTConfigSchritts");
            DropForeignKey("dbo.Schritts", "OB_IG_Id", "dbo.UDTConfigSchritts");
            DropForeignKey("dbo.Schritts", "OB_Id", "dbo.UDTConfigSchritts");
            DropIndex("dbo.Warm2SchrittClass", new[] { "A2_Id" });
            DropIndex("dbo.Warm2SchrittClass", new[] { "A1_Id" });
            DropIndex("dbo.Warm1SchrittClass", new[] { "A3_Id" });
            DropIndex("dbo.Warm1SchrittClass", new[] { "A2_Id" });
            DropIndex("dbo.Warm1SchrittClass", new[] { "A1_Id" });
            DropIndex("dbo.SchmelzbildSchrittClasses", new[] { "A1_Id" });
            DropIndex("dbo.HEVorpositionSchrittClasses", new[] { "A2_Id" });
            DropIndex("dbo.HEVorpositionSchrittClasses", new[] { "A1_Id" });
            DropIndex("dbo.FuegeSchrittClasses", new[] { "A2_Id" });
            DropIndex("dbo.FuegeSchrittClasses", new[] { "A1_Id" });
            DropIndex("dbo.AbholSchrittClasses", new[] { "A2_Id" });
            DropIndex("dbo.AbholSchrittClasses", new[] { "A1_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Warm2_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Warm1_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Schmelzbild_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "HEVorposition_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Fuege_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Abhol_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "Zaehler_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "ParameterSchritte_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "Kennung_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "IRCamera_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "DMXCheck_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "BursterDigiforceMinsdestkraft_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "BursterDigiforceKraftWeg_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "Ausgleichshub_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "AktivierungSontiges_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "AktivierungSchritte_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "AktivierungN2Gas_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "AchsenStrom_Id" });
            DropIndex("dbo.Recipes", new[] { "DatWerkzeugId" });
            DropIndex("dbo.Recipes", new[] { "DatN2Id" });
            DropIndex("dbo.Recipes", new[] { "DatConfigId" });
            DropIndex("dbo.Recipes", new[] { "DatHEId" });
            DropIndex("dbo.DatMWerkzeugs", new[] { "Recipe_Id" });
            DropIndex("dbo.WerkzeugConfigs", new[] { "Time_Id" });
            DropIndex("dbo.WerkzeugConfigs", new[] { "Name_Id" });
            DropIndex("dbo.Teilekontrolles", new[] { "UN_Id" });
            DropIndex("dbo.Teilekontrolles", new[] { "OB_Id" });
            DropIndex("dbo.Schritts", new[] { "UN_IG_Id" });
            DropIndex("dbo.Schritts", new[] { "UN_Id" });
            DropIndex("dbo.Schritts", new[] { "OB_IG_Id" });
            DropIndex("dbo.Schritts", new[] { "OB_Id" });
            DropIndex("dbo.DatConfigs", new[] { "ZYE_Id" });
            DropIndex("dbo.DatConfigs", new[] { "ZYA_Id" });
            DropIndex("dbo.DatConfigs", new[] { "WV_Id" });
            DropIndex("dbo.DatConfigs", new[] { "WKZUN_Id" });
            DropIndex("dbo.DatConfigs", new[] { "WKZOB_Id" });
            DropIndex("dbo.DatConfigs", new[] { "WE_Id" });
            DropIndex("dbo.DatConfigs", new[] { "TK_Id" });
            DropIndex("dbo.DatConfigs", new[] { "T2_Id" });
            DropIndex("dbo.DatConfigs", new[] { "T1_Id" });
            DropIndex("dbo.DatConfigs", new[] { "RO_Id" });
            DropIndex("dbo.DatConfigs", new[] { "Reserve_Id" });
            DropIndex("dbo.DatConfigs", new[] { "PT_Id" });
            DropIndex("dbo.DatConfigs", new[] { "PN_Id" });
            DropIndex("dbo.DatConfigs", new[] { "KU_Id" });
            DropIndex("dbo.DatConfigs", new[] { "GS_Id" });
            DropIndex("dbo.DatConfigs", new[] { "AV_Id" });
            DropIndex("dbo.DatConfigs", new[] { "AU_Id" });
            DropIndex("dbo.DatConfigs", new[] { "AP_Id" });
            DropTable("dbo.ZaehlerClasses");
            DropTable("dbo.Warm2AchseA1A2Class");
            DropTable("dbo.Warm2SchrittClass");
            DropTable("dbo.Warm1AchseA3Class");
            DropTable("dbo.Warm1AchseA1A2Class");
            DropTable("dbo.Warm1SchrittClass");
            DropTable("dbo.SchmelzbildAchseA1Class");
            DropTable("dbo.SchmelzbildSchrittClasses");
            DropTable("dbo.HEVorpositionAchseA1A2Class");
            DropTable("dbo.HEVorpositionSchrittClasses");
            DropTable("dbo.FuegeAchseA2Class");
            DropTable("dbo.FuegeAchseA1Class");
            DropTable("dbo.FuegeSchrittClasses");
            DropTable("dbo.AbholAchseA1A2Class");
            DropTable("dbo.AbholSchrittClasses");
            DropTable("dbo.ParameterSchritteClasses");
            DropTable("dbo.KennungClasses");
            DropTable("dbo.IRCameraClasses");
            DropTable("dbo.DMXCheckClasses");
            DropTable("dbo.BursterDigiforceMinsdestkraftClasses");
            DropTable("dbo.BursterDigiforceKraftWegClasses");
            DropTable("dbo.Ausgleichshubs");
            DropTable("dbo.AktivierungSontigesClasses");
            DropTable("dbo.AktivierungSchritteClasses");
            DropTable("dbo.AktivierungN2GasClass");
            DropTable("dbo.AchsenStromClasses");
            DropTable("dbo.DatWerkzeugs");
            DropTable("dbo.DatN2");
            DropTable("dbo.Recipes");
            DropTable("dbo.DatMWerkzeugs");
            DropTable("dbo.DatHEs");
            DropTable("dbo.TimeOfVentils");
            DropTable("dbo.NameOfInputs");
            DropTable("dbo.WerkzeugConfigs");
            DropTable("dbo.Teilekontrolles");
            DropTable("dbo.UDTConfigSchritts");
            DropTable("dbo.Schritts");
            DropTable("dbo.DatConfigs");
        }
    }
}
