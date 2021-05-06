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
                        OB_E_01_16 = c.Short(nullable: false),
                        OB_E_17_32 = c.Short(nullable: false),
                        OB_E_Vakuum = c.Short(nullable: false),
                        OB_A_Vakuum = c.Short(nullable: false),
                        OB_A_Ventile_1_8 = c.Short(nullable: false),
                        OB_IG_E_01_16 = c.Short(nullable: false),
                        OB_IG_E_17_32 = c.Short(nullable: false),
                        OB_IG_E_Vakuum = c.Short(nullable: false),
                        OB_IG_A_Vakuum = c.Short(nullable: false),
                        OB_IG_A_Ventile_1_8 = c.Short(nullable: false),
                        UN_E_01_16 = c.Short(nullable: false),
                        UN_E_17_32 = c.Short(nullable: false),
                        UN_E_Vakuum = c.Short(nullable: false),
                        UN_A_Vakuum = c.Short(nullable: false),
                        UN_A_Ventile_1_8 = c.Short(nullable: false),
                        UN_IG_E_01_16 = c.Short(nullable: false),
                        UN_IG_E_17_32 = c.Short(nullable: false),
                        UN_IG_E_Vakuum = c.Short(nullable: false),
                        UN_IG_A_Vakuum = c.Short(nullable: false),
                        UN_IG_A_Ventile_1_8 = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teilekontrolles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OB_E_01_16 = c.Short(nullable: false),
                        OB_E_17_32 = c.Short(nullable: false),
                        OB_E_Vakuum = c.Short(nullable: false),
                        OB_A_Vakuum = c.Short(nullable: false),
                        OB_A_Ventile_1_8 = c.Short(nullable: false),
                        UN_E_01_16 = c.Short(nullable: false),
                        UN_E_17_32 = c.Short(nullable: false),
                        UN_E_Vakuum = c.Short(nullable: false),
                        UN_A_Vakuum = c.Short(nullable: false),
                        UN_A_Ventile_1_8 = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WerkzeugConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_EO01 = c.String(),
                        Name_EO02 = c.String(),
                        Name_EO03 = c.String(),
                        Name_EO04 = c.String(),
                        Name_EO05 = c.String(),
                        Name_EO06 = c.String(),
                        Name_EO07 = c.String(),
                        Name_EO08 = c.String(),
                        Name_EO09 = c.String(),
                        Name_EO10 = c.String(),
                        Name_EO11 = c.String(),
                        Name_EO12 = c.String(),
                        Name_EO13 = c.String(),
                        Name_EO14 = c.String(),
                        Name_EO15 = c.String(),
                        Name_EO16 = c.String(),
                        Name_EO17 = c.String(),
                        Name_EO18 = c.String(),
                        Name_EO19 = c.String(),
                        Name_EO20 = c.String(),
                        Name_EO21 = c.String(),
                        Name_EO22 = c.String(),
                        Name_EO23 = c.String(),
                        Name_EO24 = c.String(),
                        Name_EO25 = c.String(),
                        Name_EO26 = c.String(),
                        Name_EO27 = c.String(),
                        Name_EO28 = c.String(),
                        Name_EO29 = c.String(),
                        Name_EO30 = c.String(),
                        Name_EO31 = c.String(),
                        Name_EO32 = c.String(),
                        Name_VO121 = c.String(),
                        Name_VO141 = c.String(),
                        Name_VO122 = c.String(),
                        Name_VO142 = c.String(),
                        Name_VO123 = c.String(),
                        Name_VO143 = c.String(),
                        Name_VO124 = c.String(),
                        Name_VO144 = c.String(),
                        Name_VO125 = c.String(),
                        Name_VO145 = c.String(),
                        Name_VO126 = c.String(),
                        Name_VO146 = c.String(),
                        Name_VO127 = c.String(),
                        Name_VO147 = c.String(),
                        Name_VO128 = c.String(),
                        Name_VO148 = c.String(),
                        Time_TVO121 = c.Short(nullable: false),
                        Time_TVO141 = c.Short(nullable: false),
                        Time_TVO122 = c.Short(nullable: false),
                        Time_TVO142 = c.Short(nullable: false),
                        Time_TVO123 = c.Short(nullable: false),
                        Time_TVO143 = c.Short(nullable: false),
                        Time_TVO124 = c.Short(nullable: false),
                        Time_TVO144 = c.Short(nullable: false),
                        Time_TVO125 = c.Short(nullable: false),
                        Time_TVO145 = c.Short(nullable: false),
                        Time_TVO126 = c.Short(nullable: false),
                        Time_TVO146 = c.Short(nullable: false),
                        Time_TVO127 = c.Short(nullable: false),
                        Time_TVO147 = c.Short(nullable: false),
                        Time_TVO128 = c.Short(nullable: false),
                        Time_TVO148 = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DatHEs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                        Kennung_ProgrammName = c.String(),
                        Kennung_RFIDHE = c.Byte(nullable: false),
                        Kennung_RFIDOB = c.Byte(nullable: false),
                        Kennung_RFIDUN = c.Byte(nullable: false),
                        AktivierungSchritte_SpannenT1 = c.Boolean(nullable: false),
                        AktivierungSchritte_SpannenT2 = c.Boolean(nullable: false),
                        AktivierungSchritte_Abholtakt = c.Boolean(nullable: false),
                        AktivierungSchritte_Prueftakt = c.Boolean(nullable: false),
                        AktivierungSchritte_WarmVor = c.Boolean(nullable: false),
                        AktivierungSchritte_WarmEnde = c.Boolean(nullable: false),
                        AktivierungSchritte_Auswerfer = c.Boolean(nullable: false),
                        AktivierungSchritte_Roboter = c.Boolean(nullable: false),
                        AktivierungSchritte_Reserve4 = c.Boolean(nullable: false),
                        AktivierungSchritte_Reserve5 = c.Boolean(nullable: false),
                        AktivierungSchritte_Reserve6 = c.Boolean(nullable: false),
                        AktivierungSchritte_Reserve7 = c.Boolean(nullable: false),
                        AktivierungSchritte_Reserve8 = c.Boolean(nullable: false),
                        AktivierungSchritte_Reserve9 = c.Boolean(nullable: false),
                        AktivierungSchritte_StopNachFuegen = c.Boolean(nullable: false),
                        AktivierungSchritte_OeffnenNachFuegen = c.Boolean(nullable: false),
                        AchsenStrom_FuegekraftMaxA1 = c.Short(nullable: false),
                        AchsenStrom_FuegekraftMinA1 = c.Short(nullable: false),
                        AchsenStrom_FuegekraftMaxA2 = c.Short(nullable: false),
                        AchsenStrom_FuegekraftMinA2 = c.Short(nullable: false),
                        AchsenStrom_Strommessung = c.Byte(nullable: false),
                        AchsenStrom_FuegenStart = c.Short(nullable: false),
                        Zaehler_NIONF = c.Short(nullable: false),
                        Zaehler_NIOVF = c.Short(nullable: false),
                        Zaehler_Stueckzaehler = c.Short(nullable: false),
                        AktivierungN2Gas_N2G1 = c.Boolean(nullable: false),
                        AktivierungN2Gas_N2G2 = c.Boolean(nullable: false),
                        AktivierungN2Gas_N2G3 = c.Boolean(nullable: false),
                        AktivierungN2Gas_N2G4 = c.Boolean(nullable: false),
                        AktivierungN2Gas_Reserve5 = c.Boolean(nullable: false),
                        AktivierungN2Gas_Reserve6 = c.Boolean(nullable: false),
                        AktivierungN2Gas_Reserve7 = c.Boolean(nullable: false),
                        AktivierungN2Gas_Reserve8 = c.Boolean(nullable: false),
                        AktivierungSontiges_ExternerE1 = c.Boolean(nullable: false),
                        AktivierungSontiges_ExternerE2 = c.Boolean(nullable: false),
                        AktivierungSontiges_ExternePruefung1 = c.Boolean(nullable: false),
                        AktivierungSontiges_ExternePruefung2 = c.Boolean(nullable: false),
                        AktivierungSontiges_OptionUmschaltung1 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve6 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve7 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve8 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve9 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve10 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve11 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve12 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve13 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve14 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve15 = c.Boolean(nullable: false),
                        AktivierungSontiges_Reserve16 = c.Boolean(nullable: false),
                        BursterDigiforceKraftWeg_FuegewegKraftNest1 = c.Byte(nullable: false),
                        BursterDigiforceKraftWeg_FuegewegKraftNest2 = c.Byte(nullable: false),
                        BursterDigiforceKraftWeg_BursterProgrammNest1 = c.Short(nullable: false),
                        BursterDigiforceKraftWeg_BursterProgrammNest2 = c.Short(nullable: false),
                        BursterDigiforceMinsdestkraft_BursterMindestKraftAktiv = c.Boolean(nullable: false),
                        BursterDigiforceMinsdestkraft_MindestkraftSollNest1 = c.Single(nullable: false),
                        BursterDigiforceMinsdestkraft_MindestkraftToleranzPlusNest1 = c.Single(nullable: false),
                        BursterDigiforceMinsdestkraft_MindestkraftToleranzMinusNest1 = c.Single(nullable: false),
                        BursterDigiforceMinsdestkraft_MindestkraftSollNest2 = c.Single(nullable: false),
                        BursterDigiforceMinsdestkraft_MindestkraftToleranzPlusNest2 = c.Single(nullable: false),
                        BursterDigiforceMinsdestkraft_MindestkraftToleranzMinusNest2 = c.Single(nullable: false),
                        IRCamera_KameraSchalter = c.Byte(nullable: false),
                        IRCamera_KameraLuftschleier = c.Int(nullable: false),
                        IRCamera_KameraStartFuegenNachIR = c.Int(nullable: false),
                        IRCamera_KameraFehlerVrzNachIR = c.Int(nullable: false),
                        DMXCheck_DayDifferenceSet = c.Int(nullable: false),
                        DMXCheck_ActiveDMXCheck = c.Boolean(nullable: false),
                        Ausgleichshub_Links = c.Double(nullable: false),
                        Ausgleichshub_Rechts = c.Double(nullable: false),
                        ParameterSchritte_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParameterSchritteClasses", t => t.ParameterSchritte_Id)
                .Index(t => t.ParameterSchritte_Id);
            
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
                        A1_VorPosition = c.Int(nullable: false),
                        A1_EndPosition = c.Int(nullable: false),
                        A1_Geschwindigkeit = c.Int(nullable: false),
                        A2_VorPosition = c.Int(nullable: false),
                        A2_EndPosition = c.Int(nullable: false),
                        A2_Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuegeSchrittClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_VorPosition = c.Int(nullable: false),
                        A1_EndPosition = c.Int(nullable: false),
                        A1_Geschwindigkeit = c.Int(nullable: false),
                        A1_OeffnungswegNachFuegen = c.Int(nullable: false),
                        A1_RueckhubGeschwingkeitFuegen = c.Int(nullable: false),
                        A2_VorPosition = c.Int(nullable: false),
                        A2_EndPosition = c.Int(nullable: false),
                        A2_Geschwindigkeit = c.Int(nullable: false),
                        Kuehlzeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HEVorpositionSchrittClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_Position = c.Int(nullable: false),
                        A1_Geschwindigkeit = c.Int(nullable: false),
                        A2_Position = c.Int(nullable: false),
                        A2_Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SchmelzbildSchrittClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_Position = c.Int(nullable: false),
                        A1_Geschwindigkeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warm1SchrittClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_Position = c.Int(nullable: false),
                        A1_Geschwindigkeit = c.Int(nullable: false),
                        A2_Position = c.Int(nullable: false),
                        A2_Geschwindigkeit = c.Int(nullable: false),
                        A3_Position = c.Int(nullable: false),
                        Zeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warm2SchrittClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A1_Position = c.Int(nullable: false),
                        A1_Geschwindigkeit = c.Int(nullable: false),
                        A2_Position = c.Int(nullable: false),
                        A2_Geschwindigkeit = c.Int(nullable: false),
                        Zeit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DatMWerkzeugs", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipes", "DatWerkzeugId", "dbo.DatWerkzeugs");
            DropForeignKey("dbo.DatWerkzeugs", "ParameterSchritte_Id", "dbo.ParameterSchritteClasses");
            DropForeignKey("dbo.ParameterSchritteClasses", "Warm2_Id", "dbo.Warm2SchrittClass");
            DropForeignKey("dbo.ParameterSchritteClasses", "Warm1_Id", "dbo.Warm1SchrittClass");
            DropForeignKey("dbo.ParameterSchritteClasses", "Schmelzbild_Id", "dbo.SchmelzbildSchrittClasses");
            DropForeignKey("dbo.ParameterSchritteClasses", "HEVorposition_Id", "dbo.HEVorpositionSchrittClasses");
            DropForeignKey("dbo.ParameterSchritteClasses", "Fuege_Id", "dbo.FuegeSchrittClasses");
            DropForeignKey("dbo.ParameterSchritteClasses", "Abhol_Id", "dbo.AbholSchrittClasses");
            DropForeignKey("dbo.Recipes", "DatN2Id", "dbo.DatN2");
            DropForeignKey("dbo.Recipes", "DatHEId", "dbo.DatHEs");
            DropForeignKey("dbo.Recipes", "DatConfigId", "dbo.DatConfigs");
            DropForeignKey("dbo.DatConfigs", "ZYE_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "ZYA_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "WV_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "WKZUN_Id", "dbo.WerkzeugConfigs");
            DropForeignKey("dbo.DatConfigs", "WKZOB_Id", "dbo.WerkzeugConfigs");
            DropForeignKey("dbo.DatConfigs", "WE_Id", "dbo.Schritts");
            DropForeignKey("dbo.DatConfigs", "TK_Id", "dbo.Teilekontrolles");
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
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Warm2_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Warm1_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Schmelzbild_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "HEVorposition_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Fuege_Id" });
            DropIndex("dbo.ParameterSchritteClasses", new[] { "Abhol_Id" });
            DropIndex("dbo.DatWerkzeugs", new[] { "ParameterSchritte_Id" });
            DropIndex("dbo.Recipes", new[] { "DatWerkzeugId" });
            DropIndex("dbo.Recipes", new[] { "DatN2Id" });
            DropIndex("dbo.Recipes", new[] { "DatConfigId" });
            DropIndex("dbo.Recipes", new[] { "DatHEId" });
            DropIndex("dbo.DatMWerkzeugs", new[] { "Recipe_Id" });
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
            DropTable("dbo.Warm2SchrittClass");
            DropTable("dbo.Warm1SchrittClass");
            DropTable("dbo.SchmelzbildSchrittClasses");
            DropTable("dbo.HEVorpositionSchrittClasses");
            DropTable("dbo.FuegeSchrittClasses");
            DropTable("dbo.AbholSchrittClasses");
            DropTable("dbo.ParameterSchritteClasses");
            DropTable("dbo.DatWerkzeugs");
            DropTable("dbo.DatN2");
            DropTable("dbo.Recipes");
            DropTable("dbo.DatMWerkzeugs");
            DropTable("dbo.DatHEs");
            DropTable("dbo.WerkzeugConfigs");
            DropTable("dbo.Teilekontrolles");
            DropTable("dbo.Schritts");
            DropTable("dbo.DatConfigs");
        }
    }
}
