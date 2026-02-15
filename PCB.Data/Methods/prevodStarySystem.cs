using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public class OldSystemNames
    {
        public OldSystemNames(bool prevest)
        {
            this.Childs = new List<OldSystemNames>();
            this.Prevest = prevest;
        }
        public OldSystemNames(string dbName, string systemName, object value, bool prevest = false)
        {
            this.Childs = new List<OldSystemNames>();
            this.DBName = dbName;
            this.SystemName = systemName;
            this.Value = value;
            this.Prevest = prevest;
        }
        public bool Prevest { get; set; }
        public string DBName { get; set; }
        public string SystemName { get; set; }
        private object value;
        public object Value
        {
            get
            {
                if (this.Childs != null && this.Childs.Count > 0)
                {
                    return String.Join(" | ", this.Childs.Select(s => s.Value));
                }
                else
                {
                    return value;
                }
            }
            set
            {
                this.value = value;
            }
        }

        public void SetValue(object value)
        {
            this.Value = value;
        }
        public List<OldSystemNames> Childs { get; set; }

        public static List<OldSystemNames> Init(DataRowView row)
        {
            List<OldSystemNames> result = new List<OldSystemNames>();
            result.Add(new OldSystemNames("ODBER", "Zakaznik", row["ODBER"], true));
            result.Add(new OldSystemNames("PS_NAZ", "Naz. DPS", row["PS_NAZ"], true));
            result.Add(new OldSystemNames("LABEL", "V motivu", row["LABEL"], true));
            result.Add(new OldSystemNames("PS_KOD", "Kod. DPS", row["PS_KOD"], true));
            result.Add(new OldSystemNames("SPKOD", "Spec. p.", row["SPKOD"], true));
            result.Add(new OldSystemNames("DODDOK", "DD", row["DODDOK"], true));
            result.Add(new OldSystemNames("HODNDOK", "Mak", row["HODNDOK"], true));
            result.Add(new OldSystemNames("FILMPOC", "Poc.FP", row["FILMPOC"], true));
            result.Add(new OldSystemNames("ARCH", "Arch.", row["ARCH"], true));
            result.Add(new OldSystemNames("KT", "K.tr.", row["KT"], true));
            result.Add(new OldSystemNames("NAROCTECH", "N.tech", row["NAROCTECH"], true));

            OldSystemNames tmp = new OldSystemNames(true);
            tmp.SystemName = "S";
            tmp.Childs.Add(new OldSystemNames("DATDOK", "", row["DATDOK"], true));
            tmp.Childs.Add(new OldSystemNames("KODDOK", "", row["KODDOK"], true));
            result.Add(tmp);

            tmp = new OldSystemNames(false);
            tmp.SystemName = "Z";
            tmp.Childs.Add(new OldSystemNames("ZMENACIS", "", row["ZMENACIS"]));
            tmp.Childs.Add(new OldSystemNames("ZMENADAT", "", row["ZMENADAT"]));
            tmp.Childs.Add(new OldSystemNames("ZMENACI2", "", row["ZMENACI2"]));
            tmp.Childs.Add(new OldSystemNames("ZMENADA2", "", row["ZMENADA2"]));
            result.Add(tmp);

            tmp = new OldSystemNames(false);
            tmp.SystemName = "M";
            tmp.Childs.Add(new OldSystemNames("MAT_V", "", row["MAT_V"]));
            tmp.Childs.Add(new OldSystemNames("MAT_T", "", row["MAT_T"]));
            tmp.Childs.Add(new OldSystemNames("MAT_MC", "", row["MAT_MC"]));
            tmp.Childs.Add(new OldSystemNames("MAT_P", "", row["MAT_P"]));
            tmp.Childs.Add(new OldSystemNames("MAT", "", row["MAT"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("CU_FOL", "Cu f", row["CU_FOL"]));

            tmp = new OldSystemNames(false);
            tmp.SystemName = "Celk. tl.";
            tmp.Childs.Add(new OldSystemNames("TL_PS", "", row["TL_PS"]));
            tmp.Childs.Add(new OldSystemNames("TL_TOL", "", row["TL_TOL"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("LAYERMAP", "Skl", row["LAYERMAP"]));

            tmp = new OldSystemNames(true);
            tmp.SystemName = "Cisty.r.DPS";
            tmp.Childs.Add(new OldSystemNames("CR_A", "", row["CR_A"]));
            tmp.Childs.Add(new OldSystemNames("CR_B", "", row["CR_B"]));
            tmp.Childs.Add(new OldSystemNames("CR_KOD", "", row["CR_KOD"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("CR_TOL", "Toler.c.r", row["CR_TOL"]));

            tmp = new OldSystemNames(true);
            tmp.SystemName = "Zak.panel";
            tmp.Childs.Add(new OldSystemNames("ZP_A", "", row["ZP_A"]));
            tmp.Childs.Add(new OldSystemNames("ZP_B", "", row["ZP_B"]));
            tmp.Childs.Add(new OldSystemNames("ZP_NASOB", "", row["ZP_NASOB"]));
            result.Add(tmp);

            tmp = new OldSystemNames(true);
            tmp.SystemName = "Cis.pan.PCB";
            tmp.Childs.Add(new OldSystemNames("RC_A", "", row["RC_A"]));
            tmp.Childs.Add(new OldSystemNames("RC_B", "", row["RC_B"]));
            result.Add(tmp);

            tmp = new OldSystemNames(true);
            tmp.SystemName = "Hr.pan.PCB";
            tmp.Childs.Add(new OldSystemNames("HR_A", "", row["HR_A"]));
            tmp.Childs.Add(new OldSystemNames("HR_B", "", row["HR_B"]));
            tmp.Childs.Add(new OldSystemNames("NASOB", "", row["NASOB"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("MINTRK", "sp", row["MINTRK"]));
            result.Add(new OldSystemNames("MINRIN", "mk", row["MINRIN"]));
            result.Add(new OldSystemNames("MINSPA", "iz", row["MINSPA"]));
            result.Add(new OldSystemNames("MINSPVV", "vv", row["MINSPVV"]));
            result.Add(new OldSystemNames("MPSAB", "MPS", row["MPSAB"], true));
            result.Add(new OldSystemNames("INSPEC", "Ins", row["INSPEC"], true));
            result.Add(new OldSystemNames("NREG", "RegML", row["NREG"], true));
            result.Add(new OldSystemNames("AUTREG", "OLEC", row["AUTREG"], true));
            result.Add(new OldSystemNames("KOREKCE", "Kor.vv", row["KOREKCE"]));
            result.Add(new OldSystemNames("REZSV", "Resist SV", row["REZSV"], true));
            result.Add(new OldSystemNames("SNIMMASK", "Snim mas", row["SNIMMASK"], true));

            tmp = new OldSystemNames(true);
            tmp.SystemName = "Cu-motiv(A/B)";
            tmp.Childs.Add(new OldSystemNames("CU_A", "", row["CU_A"]));
            tmp.Childs.Add(new OldSystemNames("CU_B", "", row["CU_B"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("PLFR4", "FR4 u kodu W", row["PLFR4"]));
            result.Add(new OldSystemNames("KODMASK", "Maska bar", row["KODMASK"], true));
            result.Add(new OldSystemNames("TL_MAS", "tl.", row["TL_MAS"], true));
            result.Add(new OldSystemNames("UPRPMASK", "Upr.pred mas.", row["UPRPMASK"]));
            result.Add(new OldSystemNames("KODPOTI", "Potisk bar", row["KODPOTI"], true));

            tmp = new OldSystemNames(true);
            tmp.SystemName = "NP";
            tmp.Childs.Add(new OldSystemNames("DATANPRI", "", row["DATANPRI"]));
            tmp.Childs.Add(new OldSystemNames("DATUMNPRI", "", row["DATUMNPRI"]));
            tmp.Childs.Add(new OldSystemNames("KODNPRI", "", row["KODNPRI"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("ZLAC_PL", "Zlac.kon (cm2)", row["ZLAC_PL"]));
            result.Add(new OldSystemNames("PLMONT", "SMD", row["PLMONT"], true));
            result.Add(new OldSystemNames("MSD", "Test MSD", row["MSD"], true));
            result.Add(new OldSystemNames("LEPITET", "Lepit ET", row["LEPITET"]));
            result.Add(new OldSystemNames("LKOD", "Laser", row["LKOD"], true));
            result.Add(new OldSystemNames("DFP", "Ozn.FP", row["DFP"], true));
            result.Add(new OldSystemNames("ULFP", "UL", row["ULFP"], true));
            result.Add(new OldSystemNames("POZN1", "Pozn.", row["POZN1"]));
            result.Add(new OldSystemNames("POZN2", "Pozn.", row["POZN2"]));
            result.Add(new OldSystemNames("POZN3", "Pozn.", row["POZN3"]));
            result.Add(new OldSystemNames("POZNTD", "Poznamka TPV", row["POZNTD"] != DBNull.Value ? System.Text.Encoding.UTF8.GetString(row["POZNTD"] as byte[]) : ""));
            result.Add(new OldSystemNames("POZNTECH", "Poznamka TECH", row["POZNTECH"] != DBNull.Value ? System.Text.Encoding.UTF8.GetString(row["POZNTECH"] as byte[]) : ""));
            result.Add(new OldSystemNames("DATAAOI", "AOI", row["DATAAOI"], true));

            result.Add(new OldSystemNames("DATAETATG", "ET", row["DATAETATG"], true));
            result.Add(new OldSystemNames("VRT_S", "Datovy soubor", row["VRT_S"], true));
            result.Add(new OldSystemNames("LENZ", "Pak.na", row["LENZ"], true));
            result.Add(new OldSystemNames("PAKET", "po", row["PAKET"], true));
            result.Add(new OldSystemNames("OSA", "osa", row["OSA"], true));
            result.Add(new OldSystemNames("CU_VRT", "Cu", row["CU_VRT"], true));
            result.Add(new OldSystemNames("POC_OTV", "P.otv", row["POC_OTV"]));
            result.Add(new OldSystemNames("MINVRT", "Min.vrt", row["MINVRT"], true));

            tmp = new OldSystemNames(true);
            tmp.SystemName = "Narazeci kon.";
            tmp.Childs.Add(new OldSystemNames("NARAZ", "", row["NARAZ"]));
            tmp.Childs.Add(new OldSystemNames("NKONEKT", "", row["NKONEKT"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("SLEPEVR", "VIA slepe", row["SLEPEVR"], true));
            result.Add(new OldSystemNames("PROKDRAZ", "Prok.draz.", row["PROKDRAZ"]));

            tmp = new OldSystemNames(true);
            tmp.SystemName = "VD dl";
            tmp.Childs.Add(new OldSystemNames("VD_A_POC", "", row["VD_A_POC"]));
            tmp.Childs.Add(new OldSystemNames("VD_A_TXT", "", row["VD_A_TXT"]));
            result.Add(tmp);

            tmp = new OldSystemNames(true);
            tmp.SystemName = "VD kr";
            tmp.Childs.Add(new OldSystemNames("VD_B_POC", "", row["VD_B_POC"]));
            tmp.Childs.Add(new OldSystemNames("VD_B_TXT", "", row["VD_B_TXT"]));
            result.Add(tmp);

            result.Add(new OldSystemNames("FRPAKET", "Paketovat po", row["FRPAKET"], true));
            result.Add(new OldSystemNames("FRMUST", "Mustky", row["FRMUST"], true));
            result.Add(new OldSystemNames("FRKAM", "Mustky s kamerou", row["FRKAM"]));
            result.Add(new OldSystemNames("FREZ", "Delka", row["FREZ"], true));
            result.Add(new OldSystemNames("NPFR", "Neprok.otv", row["NPFR"], true));

            return result;
        }

        public static Dictionary<string, string> KodPracovnika = new Dictionary<string, string>()
        {
            { "D", "Dub Miroslav" },
            { "KO", "Komenda Aleš" },
            { "DV", "Dvořák Vladimír" },
            { "PV", "Pechač Vladimír" },
            { "B", "Bron Zdeněk" },
            { "PO", "Povolný Aleš" },
            { "M", "Měchura Vlastimil" },
            { "Z", "Zeman Martin" },
            { "P", "Pešek Zdeněk" },
            { "PA", "Pávová Petra" },
            { "ME", "Mestek David" },
            { "C", "Černík Jiří" },
            { "JZ", "Janovský Zdeněk" }
        };

        public static Dictionary<string, barva.Value> KodBarvyMaska = new Dictionary<string, barva.Value>()
        {
            { "BI", barva.Value.bila },
            { "CR", barva.Value.cerna },
            { "CV", barva.Value.cervena },
            { "MO", barva.Value.modra },
            { "", barva.Value.zelena_mass }
        };

        public static Dictionary<string, barva.Value> KodBarvyPotisk = new Dictionary<string, barva.Value>()
        {
            { "BI", barva.Value.bila },
            { "CR", barva.Value.cerna },
            { "ZL", barva.Value.bila },
            { "", barva.Value.bila }
        };
    }

    public partial class produkt
    {
        public static produkt Prevod(DataRowView row)
        {
            int tmpInt;
            decimal tmpDecimal;
            DateTime tmpDateTime;

            List<OldSystemNames> names = OldSystemNames.Init(row);

            pcb_develEntities db = new pcb_develEntities();

            produkt p = new produkt();
            #region PS_KOD
            string kod = row["PS_KOD"].ToString();
            List<string> kody = new List<string>();
            string typ = kod.Substring(0, 2);
            for (int i = 2; i < kod.Length; i++)
            {
                if (kod[i] == 'P' || kod[i] == 'M' || kod[i] == 'D' || kod[i] == 'S' || kod[i] == 'F')
                {
                    kody.Add(kod[i].ToString() + kod[i + 1].ToString());
                    i++;
                }
                else if (kod[i] == 'V')
                {
                    kody.Add(kod[i].ToString() + kod[i + 1].ToString() + kod[i + 2].ToString());
                    i++; i++;
                }
                else
                {
                    kody.Add(kod[i].ToString());
                }
            }
            List<produkt_postup> tmpListPostup = new List<produkt_postup>();

            foreach (string k in kody)
            {
                postup postup = db.postups.Where(item => item.kod == k).FirstOrDefault();
                if (postup != null)
                {
                    produkt_postup pp = new produkt_postup();
                    pp.postup_id = postup.postup_id;
                    tmpListPostup.Add(pp);

                    p.kod = row["PS_KOD"].ToString();
                }
                else
                {
                    tmpListPostup.Clear();
                    names.Where(w => w.DBName == "PS_KOD").First().Prevest = false;

                    p.kod = "";
                    break;
                }
            }

            foreach(var pp in tmpListPostup)
            {
                p.produkt_postups.Add(pp);
            }

            if (!String.IsNullOrWhiteSpace(p.kod))
            {
                plosny_spoj_specifikace pss = db.plosny_spoj_specifikaces.Where(item => item.kod == typ).FirstOrDefault();
                if (pss != null)
                {
                    p.plosny_spoj_specifikace_id = pss.plosny_spoj_specifikace_id;
                }
            }

            #endregion 

            #region ODBER
            string strZak = row["ODBER"].ToString().ToUpper().Trim();
            zakaznik z = db.zakazniks.Where(item => item.interni_nazev.ToUpper() == strZak).FirstOrDefault();
            if (z == null)
            {
                z = new zakaznik();
                z.interni_nazev = strZak;
                z.nazev = strZak;
                db.zakazniks.AddObject(z);
            }

            p.zakaznik_id = z.zakaznik_id;
            p.zakaznik = z;
            #endregion  

            p.nazev = row["PS_NAZ"].ToString();
            p.motiv = row["LABEL"].ToString();
            p.specialni_postup = row["SPKOD"] != DBNull.Value && row["SPKOD"].ToString() == "A";

            if (row["DODDOK"] != DBNull.Value)
            {
                p.dodal_drill = row["DODDOK"].ToString().Contains("D");
                p.dodal_gerber_data = row["DODDOK"].ToString().Contains("G");
                p.dodal_vykres = row["DODDOK"].ToString().Contains("V");
                p.dodal_film = row["DODDOK"].ToString().Contains("F");
            }

            p.makro = row["HODNDOK"].ToString();


            if (int.TryParse(row["FILMPOC"].ToString(), out tmpInt))
            {
                p.pocet_fp = tmpInt;
            }

            p.archivace = row["ARCH"] != DBNull.Value && row["ARCH"].ToString() == "A";

            if (int.TryParse(row["KT"].ToString(), out tmpInt))
            {
                p.konstrukt_trida = tmpInt;
            }

            p.nestandartni_technologie = row["NAROCTECH"] != DBNull.Value && row["NAROCTECH"].ToString() == "A";

            string kodUzivatel = row["KODDOK"].ToString(); // ToDo - uzivatel sestavil
            if (OldSystemNames.KodPracovnika.ContainsKey(kodUzivatel))
            {
                var zamestanec = db.uzivatels.ToList().Where(w => w.celeJmeno == OldSystemNames.KodPracovnika[kodUzivatel]).FirstOrDefault();
                p.uzivatel_sestavil = zamestanec;
            }


            p.d_sestaveno = DateTime.Parse(row["DATDOK"].ToString());


            if (decimal.TryParse(row["CR_A"].ToString(), out tmpDecimal))
            {
                p.cisty_rozmer_dps_x = tmpDecimal == 0 ? (decimal?)null : tmpDecimal; 
            }

            if (decimal.TryParse(row["CR_B"].ToString(), out tmpDecimal))
            {
                p.cisty_rozmer_dps_y = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["ZP_A"].ToString(), out tmpDecimal))
            {
                p.zakladni_panel_x = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["ZP_B"].ToString(), out tmpDecimal))
            {
                p.zakladni_panel_y = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["ZP_NASOB"].ToString(), out tmpDecimal))
            {
                p.zakladni_panel_suma = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["RC_A"].ToString(), out tmpDecimal))
            {
                p.cisty_panel_x = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["RC_B"].ToString(), out tmpDecimal))
            {
                p.cisty_panel_y = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["HR_A"].ToString(), out tmpDecimal))
            {
                p.hruby_panel_x = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["HR_B"].ToString(), out tmpDecimal))
            {
                p.hruby_panel_y = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["NASOB"].ToString(), out tmpDecimal))
            {
                p.hruby_panel_suma = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (decimal.TryParse(row["MPSAB"].ToString(), out tmpDecimal))
            {
                p.mps = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            p.inspecta = row["INSPEC"] != DBNull.Value && row["INSPEC"].ToString() == "A";
            p.reg_multilayer = row["NREG"] != DBNull.Value && row["NREG"].ToString() == "A";
            p.olec = row["AUTREG"] != DBNull.Value && row["AUTREG"].ToString() == "A";

            if (row["REZSV"].ToString() == "A")
            {
                p.slepe_vrtani_typ_id = 1; // Ze strany A
            }

            if (row["REZSV"].ToString() == "Z")
            {
                p.slepe_vrtani_typ_id = 2; // Ze strany Z
            }

            if (row["REZSV"].ToString() == "X")
            {
                p.slepe_vrtani_typ_id = 3; // Z oboustran
            }

            if (p.ObsahujeKod("SA;SB;SX"))
            {
                if (row["SNIMMASK"] == DBNull.Value)
                {
                    p.snimatelna_maska_typ_id = 3; // oběma zpusoby
                }
                else if (row["SNIMMASK"].ToString() == "K")
                {
                    p.snimatelna_maska_typ_id = 2; // kaptonova paska
                }
                else if (row["SNIMMASK"].ToString() == "S")
                {
                    p.snimatelna_maska_typ_id = 1; // sitotisk
                }
            }

            motiv m = new motiv();
            m.motiv_typ_id = (int)motiv_typ.Value.med;
            m.produkt_id = p.produkt_id;
            m.vrstva = "A";
            m.vrstva1 = "Z";
            if (decimal.TryParse(row["CU_A"].ToString(), out tmpDecimal))
            {
                m.plocha1 = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;

            }
            if (decimal.TryParse(row["CU_B"].ToString(), out tmpDecimal))
            {
                m.plocha2 = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }
            p.motivs.Add(m);


            // barvy maska 

            if (p.ObsahujeKod("MA") || p.ObsahujeKod("MX"))
            {
                barva.Value barvaMaska;
                if (OldSystemNames.KodBarvyMaska.TryGetValue(row["KODMASK"].ToString(), out barvaMaska))
                {
                    p.maska_barva_id = (int)barvaMaska;
                }

                if (row["KODMASK"].ToString() == "AT")
                {
                    names.Where(w => w.DBName == "KODMASK").First().Prevest = false;
                }
            }

            if (p.ObsahujeKod("MB") || p.ObsahujeKod("MX"))
            {
                barva.Value barvaMaska;
                if (OldSystemNames.KodBarvyMaska.TryGetValue(row["KODMASK"].ToString(), out barvaMaska))
                {
                    p.maska_barva_b_id = (int)barvaMaska;
                }

                if (row["KODMASK"].ToString() == "AT")
                {
                    names.Where(w => w.DBName == "KODMASK").First().Prevest = false;
                }
            }

            // barvy maska

            // barvy potisk

            if (p.ObsahujeKod("PA") || p.ObsahujeKod("PX"))
            {
                if (row["DATANPRI"].ToString() == "A")
                {
                    if (DateTime.TryParse(row["DATUMNPRI"].ToString(), out tmpDateTime))
                    {
                        p.d_newprint_strana_a = tmpDateTime;
                    }

                    var kodUzivatelNewPrint = row["KODNPRI"].ToString();
                    var zamestanec = db.uzivatels.ToList().Where(w => w.celeJmeno == OldSystemNames.KodPracovnika[kodUzivatelNewPrint]).FirstOrDefault();
                    p.uzivatel_newprint_uzivatel_strana_a_id = zamestanec;
                }
                else
                {
                    barva.Value barvaPotisk;
                    if (OldSystemNames.KodBarvyPotisk.TryGetValue(row["KODPOTI"].ToString(), out barvaPotisk))
                    {
                        p.potisk_barva_id = (int)barvaPotisk;
                    }

                    if (row["KODPOTI"].ToString() == "AT")
                    {
                        names.Where(w => w.DBName == "KODPOTI").First().Prevest = false;
                    }
                }
            }

            if (p.ObsahujeKod("PB") || p.ObsahujeKod("PX"))
            {
                if (row["DATANPRI"].ToString() == "A")
                {
                    if (DateTime.TryParse(row["DATUMNPRI"].ToString(), out tmpDateTime))
                    {
                        p.d_newprint_strana_b = tmpDateTime;
                    }

                    var kodUzivatelNewPrint = row["KODNPRI"].ToString();
                    var zamestanec = db.uzivatels.ToList().Where(w => w.celeJmeno == OldSystemNames.KodPracovnika[kodUzivatelNewPrint]).FirstOrDefault();
                    p.uzivatel_newprint_uzivatel_strana_b_id = zamestanec;
                }
                else
                {
                    barva.Value barvaPotisk;
                    if (OldSystemNames.KodBarvyPotisk.TryGetValue(row["KODPOTI"].ToString(), out barvaPotisk))
                    {
                        p.potisk_barva_b_id = (int)barvaPotisk;
                    }

                    if (row["KODPOTI"].ToString() == "AT")
                    {
                        names.Where(w => w.DBName == "KODPOTI").First().Prevest = false;
                    }
                }
            }

            // barvy potisk

            if (row["PLMONT"].ToString() == "0")
            {
                p.smd_typ_id = 1;
            }
            else if (row["PLMONT"].ToString() == "1")
            {
                p.smd_typ_id = 2;
            }
            else if (row["PLMONT"].ToString() == "2")
            {
                p.smd_typ_id = 3;
            }

            p.test_msd = row["MSD"] != DBNull.Value && row["MSD"].ToString() == "A";

            if (row["DFP"].ToString().Length > 0)
            {
                if (row["DFP"].ToString()[0] == 'L')
                {
                    p.oznaceni_fp_typ_id = 1;
                }
                if (row["DFP"].ToString()[0] == 'M')
                {
                    p.oznaceni_fp_typ_id = 2;
                }
                if (row["DFP"].ToString()[0] == 'P')
                {
                    p.oznaceni_fp_typ_id = 3;
                }
            }
            if (row["DFP"].ToString().Length > 1)
            {
                if (row["DFP"].ToString()[1] == 'T')
                {
                    p.oznaceni_fp_druh_id = 1;
                }
                if (row["DFP"].ToString()[1] == 'M')
                {
                    p.oznaceni_fp_druh_id = 2;
                }
            }

            if (row["ULFP"].ToString().Contains("L"))
            {
                p.ul = 1;
            }
            if (row["ULFP"].ToString().Contains("M"))
            {
                p.ul = 2;
            }
            if (row["ULFP"].ToString().Contains("P"))
            {
                p.ul = 3;
            }

            p.aoi = row["DATAAOI"].ToString() == "A";
            p.et = row["DATAETATG"].ToString() == "A";

            p.datovy_soubor = row["VRT_S"].ToString();

            if (row["LENZ"] != DBNull.Value)
            {
                p.orientace_vrtani_id = 1;
            }

            if (int.TryParse(row["PAKET"].ToString(), out tmpInt))
            {
                p.paket_vrtani = tmpInt == 0 ? (int?)null : tmpInt;
            }            
            p.osa_vrtani = row["OSA"].ToString();


            if (row["CU_VRT"].ToString().ToUpper() == "NAHORU")
            {
                p.vrtani_cu_id = 1;
            }

            if (row["CU_VRT"].ToString().ToUpper() == "DOLU")
            {
                p.vrtani_cu_id = 2;
            }

            if (decimal.TryParse(row["MINVRT"].ToString(), out tmpDecimal))
            {
                p.min_vrtak_vrtani = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            p.naraz_konekt = row["NARAZ"].ToString() == "A";
            p.naraz_kon_poznamka = row["NKONEKT"].ToString();

            if (row["SLEPEVR"].ToString() == "A")
            {
                p.slepe_vrtani_druh_id = 1;
            }
            if (row["SLEPEVR"].ToString() == "Z")
            {
                p.slepe_vrtani_druh_id = 2;
            }
            if (row["SLEPEVR"].ToString() == "X")
            {
                p.slepe_vrtani_druh_id = 3;
            }

            if (int.TryParse(row["VD_A_POC"].ToString(), out tmpInt))
            {
                p.vd_delsi_pocet = tmpInt == 0 ? (int?)null : tmpInt;
            }
            p.vd_delsi_detail = row["VD_A_TXT"].ToString();

            if (int.TryParse(row["VD_B_POC"].ToString(), out tmpInt))
            {
                p.vd_kratsi_pocet = tmpInt == 0 ? (int?)null : tmpInt;
            }
            p.vd_kratsi_detail = row["VD_B_TXT"].ToString();

            if (int.TryParse(row["FRPAKET"].ToString(), out tmpInt))
            {
                p.paket_frezovani = tmpInt == 0 ? (int?)null : tmpInt;
            }

            if (row["FRMUST"].ToString() == "O")
            {
                p.mustky_id = 1;
            }
            if (row["FRMUST"].ToString() == "I")
            {
                p.mustky_id = 2;
            }

            if (decimal.TryParse(row["FREZ"].ToString(), out tmpDecimal))
            {
                p.delka_frezovani = tmpDecimal == 0 ? (decimal?)null : tmpDecimal;
            }

            if (row["NPFR"].ToString() == "A")
            {
                p.neprokovene__id = 1;
            }
            if (row["NPFR"].ToString() == "F")
            {
                p.neprokovene__id = 2;
            }


            if (row["LKOD"].ToString().Contains("D"))
            {
                p.laser_typ_id = 1;
            }
            if (row["LKOD"].ToString().Contains("P"))
            {
                p.laser_typ_id = 2;
            }
            if (row["LKOD"].ToString().Contains("F"))
            {
                p.laser_druh_id = 1;
            }


                

            //p.celkova_tloustka = decimal.Parse(row["TL_PS"].ToString());


            //string tltol = row["TL_TOL"].ToString();
            //if (tltol.Contains("+-"))
            //{
            //    if (tltol.Replace("+-", "").Trim() != "")
            //    {
            //        decimal hodnota = decimal.Parse(tltol.Replace("+-", "").Replace(".", ","));
            //        p.tolerance_horni = hodnota;
            //        p.tolerance_dolni = hodnota;
            //    }
            //}
            //if (!tltol.Contains("+-") && tltol.Length > 0)
            //{
            //    decimal hodnota = decimal.Parse(tltol.Replace(".", ","));
            //    p.tolerance_horni = hodnota;
            //}

            //p.pocet_otvoru_vrtani = int.Parse(row["POC_OTV"].ToString());
            //
            //

            foreach (OldSystemNames n in names.Where(w => !w.Prevest))
            {
                p.stary_system_poznamka += (String.Format("{0} | {1}", n.SystemName.PadRight(20), n.Value) + Environment.NewLine);
            }

            foreach (OldSystemNames n in names)
            {
                p.stary_system_nahled += (String.Format("{0} | {1}", n.SystemName.PadRight(20), n.Value) + Environment.NewLine);
            }

            //foreach (DataColumn col in row.DataView.ToTable().Columns)
            //{
            //    p.stary_system_nahled += col.ToString() + ": " + row[col.ColumnName].ToString() + ";\n";
            //}


            p.produkt_stav_id = (int)produkt_stav.Value.prevedeno;

            db.produkts.AddObject(p);
            db.SaveChanges();

            return p;
        }

    }
}
