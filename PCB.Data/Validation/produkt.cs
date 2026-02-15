using PCB.Data.CustomObjects;
using PCB.Data.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class produkt : IValidatableObject
    {
        Dictionary<int, kontrola> SeznamKontrol;


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ls = new List<ValidationResult>();
            if (this.zakaznik_id == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Zákazník")));
            }
            if (String.IsNullOrEmpty(this.nazev))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Název DPS")));
            }

            if (this.d_sestaveno == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Sestaveno")));
            }

            if (this.sestavil == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Kdo sestavil")));
            }

            if (string.IsNullOrEmpty(this.kod))
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Kód")));
                return ls;
            }

            if (this.vrstvas.Count == 0)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Definice skladby desky")));
            }


            if (this.cisty_rozmer_dps_x == null || this.cisty_rozmer_dps_y == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Čístý rozměr DPS")));
            }

            if (this.cisty_panel_x == null || this.cisty_panel_y == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Čístý rozměr panelu DPS")));
            }

            if (this.hruby_panel_x == null || this.hruby_panel_y == null || this.hruby_panel_suma == null)
            {
                ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Hrubý rozměr panelu DPS")));
            }

            //if (!this.ObsahujeKod("SN;S."))
            //{
            //    if (this.zakladni_panel_x == null && this.zakladni_panel_y == null)
            //    {
            //        ls.Add(new ValidationResult(string.Format(Hlasky.NeniVyplno, "Zákaznický panel")));
            //    }
            //}

            if (this.poznamka != null && this.poznamka.Split('\n').Count() > 4)
            {
                ls.Add(new ValidationResult("Poznámka může obsahovat max 4 řádky, více není podporováno."));
            }

            pcb_develEntities db = (pcb_develEntities)validationContext.Items["Db"];

            List<int> produkt_stav_active = new List<int>() { (int)produkt_stav.Value.aktivni, (int)produkt_stav.Value.kOdeslani, (int)produkt_stav.Value.odeslane };


            if (db.produkts.Where(w =>
                w.sablona == this.sablona &&
                w.zakaznik_id == this.zakaznik_id &&
                w.nazev == this.nazev &&
                w.produkt_id != this.produkt_id &&
                produkt_stav_active.Contains(w.produkt_stav_id)
            ).ToList().Where(w =>
                (this.KopieZProduktu == null ||
                this.KopieZProduktu.produkt_stav_id != (int)produkt_stav.Value.neaktivni ||
                (this.KopieZProduktu.produkt_stav_id == (int)produkt_stav.Value.neaktivni && this.KopieZProduktu.produkt_id != w.produkt_id))).Any())
            {
                ls.Add(new ValidationResult(String.Format("Produkt \"{0}\" pro zákazníka \"{1}\", je již aktivní.", this.nazev, this.ZakaznikNazev)));
            }


            foreach (produkt_revize pr in this.produkt_revizes)
            {
                if (pr.poznamka == null || pr.poznamka == "")
                {
                    ls.Add(new ValidationResult("Není vyplněň popis u revize"));
                }
            }



            return ls;
        }


        private List<KontrolaItem> hlaskyZKontroly;
        public List<KontrolaItem> HlaskyZKontroly
        {
            get
            {
                return hlaskyZKontroly;
            }
        }


        public int vyskytKodu(string s)
        {
            string[] pole = s.Split(';');

            int pocet = 0;
            foreach (string item in pole)
            {
                if (this.ObsahujeKod(item))
                {
                    pocet++;
                }
            }
            return pocet;
        }

        public bool poradi(string s)
        {
            string[] vysl = s.Split(';');
            if (this.kod == null)
                return false;

            return (this.kod.IndexOf(vysl[0]) < this.kod.IndexOf(vysl[1])) && (this.ObsahujeKod(vysl[0]) && this.ObsahujeKod(vysl[1]));

        }

        private void hlaska(int cisloErroru)
        {
            hlaska(cisloErroru, "");
        }

        private void hlaska(int cisloErroru, string dodatek)
        {
            kontrola kontrola;
            if (SeznamKontrol.TryGetValue(cisloErroru, out kontrola))
            {
                if (dodatek != "")
                {
                    dodatek = " - " + dodatek;
                }

                KontrolaItem item = new KontrolaItem();
                item.Text = kontrola.popis + dodatek;
                item.Kod = kontrola.kontrola_id.ToString().PadLeft(4, '0');
                item.Fatalni = kontrola.fatalni;
                item.Propustna = kontrola.fatalni ? false : true;
                item.Tiskova = kontrola.tiskova;

                item.Level += item.Fatalni ? "F" : "P";
                item.Level += item.Tiskova ? "T" : "";

                this.hlaskyZKontroly.Add(item);
            }

        }


        private List<string> KontrolaVnitrni()
        {

            List<string> lsResult = new List<string>();
            int mez = 0;

            if (this.ObsahujeKod("E1;J.;J0;W1"))
            {
                //    strana = "A";
                mez = motivy.mez(this.vrstvas.Where(i => i.vrstva_cu_id != null && i.strana == "A").First().vrstva_cu.nazev);
            }

            if (this.plosny_spoj_specifikace == null)
            {
                lsResult.Add("Není zadán plošný spoj specifikace.");
            }
            else
            {
                if (this.plosny_spoj_specifikace.kod == "N.")
                {
                    //strana = "B";
                    mez = motivy.mez(this.vrstvas.Where(i => i.vrstva_cu_id != null && i.strana == "AB").First().vrstva_cu.nazev);
                }

                if (this.plosny_spoj_specifikace.kod == "J1")
                {
                    //strana = "B";
                    mez = motivy.mez(this.vrstvas.Where(i => i.vrstva_cu_id != null && i.strana == "B").First().vrstva_cu.nazev);
                }
            }

            // vice vrstve
            if (this.ObsahujeKod("4A;6A;8A;10A;12A;4B;6B;8B;10B;12B;"))
            {
                List<vrstva> v = this.vrstvas.Where(i => i.vrstva_cu_id != null && !i.strana.Contains("A") && !i.strana.Contains("Z")).ToList();

                foreach (vrstva vr in v)
                {
                    int hodnota = motivy.mez(vr.vrstva_cu.nazev);
                    if (hodnota > mez)
                    {
                        mez = hodnota;
                    }

                }
            }

            if (mez == 0)
            {
                return lsResult;
            }



            List<motivy> lsHodnoty = new List<motivy>();

            // vnejsi
            lsHodnoty.Add(new motivy() { tl_Cu = 9, min_spoj = 0.1m, min_izolacni_mezera = 0.1m, min_mezikruzi = 0.1m });
            lsHodnoty.Add(new motivy() { tl_Cu = 12, min_spoj = 0.1m, min_izolacni_mezera = 0.1m, min_mezikruzi = 0.1m });
            lsHodnoty.Add(new motivy() { tl_Cu = 18, min_spoj = 0.125m, min_izolacni_mezera = 0.125m, min_mezikruzi = 0.125m });
            lsHodnoty.Add(new motivy() { tl_Cu = 35, min_spoj = 0.15m, min_izolacni_mezera = 0.15m, min_mezikruzi = 0.15m });
            lsHodnoty.Add(new motivy() { tl_Cu = 70, min_spoj = 0.25m, min_izolacni_mezera = 0.2m, min_mezikruzi = 0.25m });
            lsHodnoty.Add(new motivy() { tl_Cu = 105, min_spoj = 0.3m, min_izolacni_mezera = 0.3m, min_mezikruzi = 0.3m });
            lsHodnoty.Add(new motivy() { tl_Cu = 140, min_spoj = 0.4m, min_izolacni_mezera = 0.4m, min_mezikruzi = 0.4m });
            lsHodnoty.Add(new motivy() { tl_Cu = 210, min_spoj = 0.5m, min_izolacni_mezera = 0.5m, min_mezikruzi = 0.5m });
            lsHodnoty.Add(new motivy() { tl_Cu = 400, min_spoj = 0.8m, min_izolacni_mezera = 0.7m, min_mezikruzi = 0.8m });


            // kontrola min_spoj

            if (this.ObsahujeKod("4A;6A;8A;10A;12A;4B;6B;8B;10B;12B;"))
            {

                if (this.sp2.HasValue)
                {
                    decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_spoj;

                    if (tabulka >= sp2)
                    {
                        lsResult.Add("Minimální spoj neodpovídá technickým podmínkám !");
                    }
                }

                // kontrola min_iz

                if (this.mk.HasValue)
                {
                    decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_izolacni_mezera;

                    if (tabulka >= mk)
                    {
                        lsResult.Add("Minimalní mezikruží neodpovídá technickým podmínkám !");
                    }
                }

                if (this.iz.HasValue)
                {
                    decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_mezikruzi;

                    if (tabulka >= iz)
                    {
                        lsResult.Add("Minimalní izolační mezera neodpovídá technickým podmínkám !");
                    }
                }
            }



            if (this.ObsahujeKod("E1;J.;J0;N.;W1;J1"))
            {

                if (this.sp2_vnejsi.HasValue)
                {
                    decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_spoj;

                    if (tabulka >= sp2_vnejsi)
                    {
                        lsResult.Add("Minimalní spoj neodpovídá technickým podmínkám !");
                    }
                }

                // kontrola min_iz

                if (this.mk_vnejsi.HasValue)
                {
                    decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_izolacni_mezera;

                    if (tabulka >= mk_vnejsi)
                    {
                        lsResult.Add("Minimalní mezikruži neodpovídá technickým podmínkám !");
                    }
                }

                if (this.iz_vnejsi.HasValue)
                {
                    decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_mezikruzi;

                    if (tabulka >= iz_vnejsi)
                    {
                        lsResult.Add("Minimalní izolační mezera neodpovídá technickým podmínkám !");
                    }
                }
            }



            return lsResult;
        }

        private List<string> KontrolaVnejsi()
        {
            List<string> lsResult = new List<string>();
            int mez = 0;

            if (this.vrstvas.Count == 0)
            {
                return lsResult;
            }

            if (this.ObsahujeKod("E2;O.;W2;"))
            {
                mez = motivy.mez(this.vrstvas.Where(i => i.vrstva_cu_id != null && i.strana == "AB").First().vrstva_cu.nazev);
            }


            // vice vrstve
            if (this.ObsahujeKod("4A;6A;8A;10A;12A;4B;6B;8B;10B;12B;"))
            {
                List<vrstva> v = this.vrstvas.Where(i => i.vrstva_cu_id != null && (i.strana.Contains("A") || i.strana.Contains("Z"))).ToList();

                foreach (vrstva vr in v)
                {
                    int hodnota = motivy.mez(vr.vrstva_cu.nazev);
                    if (hodnota > mez)
                    {
                        mez = hodnota;
                    }

                }

            }

            if (mez == 0)
            {
                return lsResult;
            }

            List<motivy> lsHodnoty = new List<motivy>();

            // vnejsi
            lsHodnoty.Add(new motivy() { tl_Cu = 9, min_spoj = 0.1m, min_izolacni_mezera = 0.1m, min_mezikruzi = 0.1m });
            lsHodnoty.Add(new motivy() { tl_Cu = 12, min_spoj = 0.1m, min_izolacni_mezera = 0.1m, min_mezikruzi = 0.1m });
            lsHodnoty.Add(new motivy() { tl_Cu = 18, min_spoj = 0.125m, min_izolacni_mezera = 0.125m, min_mezikruzi = 0.125m });
            lsHodnoty.Add(new motivy() { tl_Cu = 35, min_spoj = 0.2m, min_izolacni_mezera = 0.15m, min_mezikruzi = 0.2m });
            lsHodnoty.Add(new motivy() { tl_Cu = 70, min_spoj = 0.3m, min_izolacni_mezera = 0.2m, min_mezikruzi = 0.25m });
            lsHodnoty.Add(new motivy() { tl_Cu = 105, min_spoj = 0.4m, min_izolacni_mezera = 0.3m, min_mezikruzi = 0.35m });
            lsHodnoty.Add(new motivy() { tl_Cu = 140, min_spoj = 0.5m, min_izolacni_mezera = 0.4m, min_mezikruzi = 0.45m });
            lsHodnoty.Add(new motivy() { tl_Cu = 210, min_spoj = 0.6m, min_izolacni_mezera = 0.5m, min_mezikruzi = 0.55m });
            lsHodnoty.Add(new motivy() { tl_Cu = 400, min_spoj = 0.9m, min_izolacni_mezera = 0.8m, min_mezikruzi = 0.9m });


            // kontrola min_spoj

            if (this.sp2_vnejsi.HasValue)
            {
                decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_spoj;

                if (tabulka >= sp2_vnejsi)
                {
                    lsResult.Add("Minimalní spoj neodpovídá technickým podmínkám !");
                }
            }

            // kontrola min_iz

            if (this.mk_vnejsi.HasValue)
            {
                decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_mezikruzi;

                if (tabulka >= mk_vnejsi)
                {
                    lsResult.Add("Minimalní mezikruží neodpovídá technickým podmínkám !");
                }
            }

            if (this.iz_vnejsi.HasValue)
            {
                decimal tabulka = lsHodnoty.Where(i => i.tl_Cu == mez).First().min_izolacni_mezera;

                if (tabulka >= iz_vnejsi)
                {
                    lsResult.Add("Minimalní izolační neodpovídá technickým podmínkám !");
                }
            }

            return lsResult;
        }

        public void SestavKontrolySablona()
        {
            // zalozi se vzdy nova kolekce
            this.hlaskyZKontroly = new List<KontrolaItem>();
            this.SeznamKontrol = new Dictionary<int, kontrola>();

            pcb_develEntities dbContext = new pcb_develEntities();
            this.SeznamKontrol = dbContext.kontrolas.Where(i => i.aktivni).ToDictionary(i => i.kontrola_id, i => i);

            if (this.ObsahujeKod("S.") && (this.ObsahujeMaterial("AG") || this.ObsahujeMaterial("FOLIE") || ((this.cisty_rozmer_dps_y ?? 0) > 300) && (this.celkova_tloustka ?? 0) == 0.1m))
            {
                hlaska(48);
            }

            // je-li sablona && minimalni ploska s
            if (ObsahujeKod("S.;SN") && (this.mps ?? 0) == 0)
            {
                hlaska(57);
            }

            if (this.ObsahujeKod("S.") && (this.mps ?? 0) < 0.13m)
            {
                hlaska(79);
            }

            if (dbContext.produkts.Where(item =>
                item.zakaznik_id == this.zakaznik_id &&
                item.nazev == this.nazev && item.produkt_stav_id != (int)produkt_stav.Value.neaktivni && this.produkt_stav_id != (int)produkt_stav.Value.neaktivni).Count() > 1)
            {
                hlaska(117);
            }

        }


        public void SestavKontroly()
        {
            // zalozi se vzdy nova kolekce
            this.hlaskyZKontroly = new List<KontrolaItem>();
            this.SeznamKontrol = new Dictionary<int, kontrola>();

            pcb_develEntities dbContext = new pcb_develEntities();
            this.SeznamKontrol = dbContext.kontrolas.Where(i => i.aktivni).ToDictionary(i => i.kontrola_id, i => i);


            if (ObsahujeKod("L") && !ObsahujeKod("E1;E2"))
            {
                hlaska(1);
            }

            if ((ObsahujeKod("PA;PB;PX") && ObsahujeKod("E1;E2")))
            {
                hlaska(3);
            }

            if (ObsahujeKod("V1A;V1B;V1X;V2A;V2B;V2X;V3A;V3B;V3X") && ObsahujeKod("E1;E2;J1"))
            {
                hlaska(4);
            }

            if (ObsahujeKod("V1A;V1B;V1X;V2A;V2B;V2X;V3A;V3B;V3X") && (ObsahujeKod("C") || ObsahujeKod("Q")))
            {
                hlaska(5);
            }

            if ((ObsahujeKod("SB;SA;SX") && ObsahujeKod("E1;E2;J1")))
            {
                hlaska(7);
            }

            if (ObsahujeKod("SA;SB;SX") && ObsahujeKod("I;C;Q;G") && (this.snimatelna_maska_typ_id == 2 || this.snimatelna_maska_typ_id == 3))
            {
                hlaska(8);
            }

            if (ObsahujeKod("J1") && ObsahujeKod("Z;I;C;Q"))
            {
                hlaska(9);
            }


            if (ObsahujeKod("Z") && ObsahujeKod("E1;E2;") && !ObsahujeKod("I"))
            {
                hlaska(10);
            }

            if (ObsahujeKod("Z") && ObsahujeKod("C;Q;G"))
            {
                hlaska(11);
            }

            if (ObsahujeKod("R") && ObsahujeKod("4A;4B;6A,6B;8A;8B;10A;10B;12A;12B;J1"))
            {
                hlaska(12);
            }


            if (vyskytKodu("H;C;G;Q;I") > 1)
            {
                hlaska(16);
            }

            if (poradi("D3;F1") || poradi("D3;F2") || poradi("R;F2") || poradi("R;F1"))
            {
                hlaska(17);
            }

            if ((poradi("F2;D1") || poradi("F2;D2") || poradi("F2;D3")) && this.mustky == null)
            {
                hlaska(18);
            }


            if (ObsahujeKod("E1;E2;W1;W2;W4;W6;4A;4B;6A;6A;6B;8A;8B;10A;10B;12A;12B") && !ObsahujeKod("T"))
            {
                hlaska(20);
            }

            if (ObsahujeKod("J.;N.;J1") && this.konstrukt_trida >= 6)
            {
                hlaska(21);
            }

            if (ObsahujeKod("O.") && (this.konstrukt_trida >= 5) && !ObsahujeKod("T"))
            {
                hlaska(22);
            }


            if (ObsahujeKod("E1;E2;W1;W2;W4;W6;") && ObsahujeKod("Q"))
            {
                hlaska(26);
            }

            if (((this.nestandartni_technologie ?? false) == false && ObsahujeKod("Q")))
            {
                hlaska(27);
            }

            if (ObsahujeKod("D1;D2;D3"))
            {
                int splneno_drazky = 0;
                if ((vd_kratsi_detail ?? "") != "" && ((vd_kratsi_jadro ?? 0) != 0) && ((vd_kratsi_pocet ?? 0) != 0))
                {
                    splneno_drazky += 1;

                }

                if ((vd_jadro ?? 0) != 0 && ((vd_delsi_detail ?? "") != "") && ((vd_delsi_pocet ?? 0) != 0))
                {
                    splneno_drazky += 1;

                }
                if (splneno_drazky == 0)
                {
                    hlaska(29);
                }
            }

            if (!ObsahujeKod("D1;D2;D3"))
            {
                decimal drazky = (this.vd_delsi_pocet ?? 0) + (this.vd_kratsi_pocet ?? 0);

                if (drazky > 0)
                {
                    hlaska(30);
                }
            }

            if (ObsahujeKod("D1;D2;D3") && ObsahujeKod("J1;J0;J1;O.;N.;4A;4B;6A;6B;8A;8B;10A;10B;12A;12B"))
            {
                decimal tlouska = 0;

                if (ObsahujeKod("J1;J0;J1;O.;N."))
                {
                    tlouska = this.vrstvas.Sum(i => (i.tloustka_mm ?? 0));
                }

                if (ObsahujeKod("4A;4B;6A;6B;8A;8B;10A;10B;12A;12B"))
                {
                    tlouska = this.celkova_tloustka ?? 0;
                }

                if (!(tlouska >= 0.6m && tlouska <= 2.4m))
                {
                    hlaska(31);
                }
            }

            if (ObsahujeKod("J1;J0;J1;O.;N.;4A;4B;6A;6B;8A;8B;10A;10B;12A;12B") && ObsahujeKod("R"))
            {

                decimal tlouska = 0;

                if (ObsahujeKod("J1;J0;O.;N."))
                {
                    tlouska = this.vrstvas.Sum(i => (i.tloustka_mm ?? 0));
                }

                if (ObsahujeKod("4A;4B;6A;6B;8A;8B;10A;10B;12A;12B"))
                {
                    tlouska = this.celkova_tloustka ?? 0;
                }

                if (tlouska > 2.2m && this.ObsahujeKod("R"))
                {
                    hlaska(32);
                }
            }

            if (!ObsahujeKod("Z"))
            {

                int vysl = this.motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.zlaceni).Count();

                if (vysl > 0)
                {
                    hlaska(33);
                }
            }

            if (ObsahujeKod("Z"))
            {
                decimal vysl = this.motivs.
                    Where(i => i.motiv_typ_id == (int)motiv_typ.Value.zlaceni).
                    Sum(i => (i.plocha1 ?? 0) + (i.plocha2 ?? 0));

                if (vysl == 0)
                {
                    hlaska(34);
                }

            }

            if (ObsahujeKod("F1;F2"))
            {
                if ((this.paket_frezovani ?? 0) == 0 || (this.delka_frezovani ?? 0) == 0)
                {
                    hlaska(35);
                }
            }


            if (!ObsahujeKod("F1;F2"))
            {
                if ((this.paket_frezovani ?? 0) > 0 || (this.delka_frezovani ?? 0) > 0 || (this.mustky != null))
                {
                    hlaska(36);
                }
            }

            if (this.prokovene_drazky_id == 1 && (this.prokovene_paket ?? 0) == 0)
            {
                hlaska(38);
            }

            if (this.ObsahujeKod("4B;6A;6B;8A;8B;10A;10B;12A;12B") && !(this.reg_multilayer ?? false))
            {
                hlaska(42);
            }



            if ((this.celkova_tloustka ?? 0) == 0 && this.ObsahujeKod("4A;4B;6A;6B;8A;8B;10A;10B;12A;12B;W4;W6"))
            {
                hlaska(50);
            }

            if (this.ObsahujeKod("Q"))
            {
                decimal vysl = this.motivs.
                    Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med).
                    Sum(i => (i.plocha1 ?? 0) + (i.plocha2 ?? 0));
                if (vysl == 0)
                {
                    hlaska(55);
                };
            }

            if (ObsahujeKod("E2;O.;4A;4B;6A;6B;8A;8B;10A;10B;12A;12B;W1;W2;W4;W6"))
            {
                decimal vysl = this.motivs.
                    Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med).
                    Sum(i => (i.plocha1 ?? 0) + (i.plocha2 ?? 0));

                if (vysl == 0)
                {
                    hlaska(56);
                }
            }


            if (((this.hruby_panel_x ?? 0) * (this.hruby_panel_y ?? 0) == 0) ||
                (this.hruby_panel_y ?? 0) > (this.hruby_panel_x ?? 0)
                ||
                ((this.zakladni_panel_x.HasValue && this.zakladni_panel_y.HasValue
                ) &&
                (((this.zakladni_panel_x ?? 0) * (this.zakladni_panel_y ?? 0) == 0) ||
                (this.zakladni_panel_y ?? 0) > (this.zakladni_panel_x ?? 0)))
                ||
                ((this.cisty_panel_x ?? 0) * (this.cisty_panel_y ?? 0) == 0) ||
                (this.cisty_panel_y ?? 0) > (this.cisty_panel_x ?? 0)
                ||
                ((this.cisty_rozmer_dps_x ?? 0) * (this.cisty_rozmer_dps_y ?? 0) == 0) ||
                (this.cisty_rozmer_dps_y ?? 0) > (this.cisty_rozmer_dps_x ?? 0)

                )
            {
                hlaska(58);
            }

            // nasobnost u hrubeho panelu
            if ((this.hruby_panel_suma ?? 0) == 0)
            {
                hlaska(59);
            }


            // nasobnost u hrubeho panelu
            if ((this.zakladni_panel_suma ?? 0) == 0 && ((this.zakladni_panel_x ?? 0) * (this.zakladni_panel_y ?? 0)) > 0)
            {
                hlaska(113);
            }



            if ((this.cisty_rozmer_dps_x ?? 0) > (this.cisty_panel_x ?? 0) || (this.cisty_rozmer_dps_y ?? 0) > (this.cisty_panel_y ?? 0))
            {
                hlaska(61);
            }

            if (this.ObsahujeKod("J.;J0;O.;N.;"))
            {
                if ((this.cisty_panel_x ?? 0) < 230 || (this.cisty_panel_y ?? 0) < 150)
                {

                    hlaska(62);
                }
            }

            if (this.ObsahujeKod("4A;"))
            {
                if ((this.cisty_panel_x ?? 0) < 260 || (this.cisty_panel_y ?? 0) < 150)
                {

                    hlaska(62);
                }
            }

            if (this.ObsahujeKod("4B;6A;6B;8A;8B;10A;10B;12B;12A"))
            {
                if ((this.cisty_panel_x ?? 0) < 220 || (this.cisty_panel_y ?? 0) < 150)
                {

                    hlaska(62);
                }
            }

            if (this.ObsahujeKod("J1;"))
            {
                if ((this.cisty_panel_x ?? 0) < 280 || (this.cisty_panel_y ?? 0) < 168)
                {

                    hlaska(62);
                }
            }

            if (((this.hruby_panel_x ?? 0) <= (this.cisty_panel_x ?? 0)) || ((this.hruby_panel_y ?? 0) <= (this.cisty_panel_y ?? 0)))
            {
                hlaska(65);
            }

            if (this.zakladni_panel_x.HasValue && this.zakladni_panel_y.HasValue)
            {
                if (((this.cisty_rozmer_dps_x ?? 0) > (this.zakladni_panel_x ?? 0)) || ((this.cisty_rozmer_dps_y ?? 0) > (this.zakladni_panel_y ?? 0)))
                {
                    hlaska(67);
                }
            }

            if (((this.cisty_panel_x ?? 0) < (this.zakladni_panel_x ?? 0)) || ((this.cisty_panel_y ?? 0) < (this.zakladni_panel_y ?? 0)))
            {
                hlaska(68);
            }

            if (this.oznaceni_fp_typ != null || this.oznaceni_fp_druh != null)
            {
                hlaska(70);
            }

            if ((this.paket_vrtani ?? 0) == 0)
            {
                hlaska(71);
            }

            if ((this.min_vrtak_vrtani ?? 0) == 0)
            {
                hlaska(72);
            }

            if ((this.pocet_otvoru_vrtani ?? 0) == 0)
            {
                hlaska(73);
            }

            if (string.IsNullOrEmpty(this.osa_vrtani) || this.osa_vrtani == "X")
            {
                hlaska(75);
            }

            if (this.ObsahujeKod("J.") && (((this.vrtani_cu_id.HasValue && this.vrtani_cu_id == (int)vrtani_cu.Value.dolu)) || !this.vrtani_cu_id.HasValue))
            {
                hlaska(76);
            }

            if (this.ObsahujeKod("J1") && (((this.vrtani_cu_id.HasValue && this.vrtani_cu_id == (int)vrtani_cu.Value.nahoru)) || !this.vrtani_cu_id.HasValue))
            {
                hlaska(77);
            }

            if ((this.naraz_konekt ?? false) == true && String.IsNullOrEmpty(this.naraz_kon_poznamka))
            {
                hlaska(81);
            }

            if (this.vrstvas.Count == 0)
            {
                hlaska(83);
            }

            if (this.ObsahujeKod("PA") && this.potisk_barva_id.HasValue && this.potisk_barva_id != 2 && this.d_newprint_strana_a.HasValue)
            {
                hlaska(85);
            }

            if (this.ObsahujeKod("PB") && this.potisk_barva_b_id.HasValue && this.potisk_barva_b_id != 2 && this.d_newprint_strana_b.HasValue)
            {
                hlaska(85);
            }

            if (this.ObsahujeKod("PX"))
            {
                if (this.potisk_barva_id.HasValue && this.potisk_barva_id != 2 && this.d_newprint_strana_a.HasValue)
                {
                    hlaska(85);
                }

                if (this.potisk_barva_b_id.HasValue && this.potisk_barva_b_id != 2 && this.d_newprint_strana_b.HasValue)
                {
                    hlaska(85);
                }
            }




            if (this.ObsahujeKod("MA;MB;MX"))
            {
                // pokud se rovnani
                if (this.maska_barva_id.HasValue && this.potisk_barva_id.HasValue && this.potisk_barva_id == this.maska_barva_id)
                {
                    hlaska(86);
                }

                // pokud se rovnani pro stranu B
                if (this.maska_barva_b_id.HasValue && this.potisk_barva_b_id.HasValue && this.potisk_barva_b_id == this.maska_barva_b_id)
                {
                    hlaska(86);
                }
            }


            decimal tlouskad = 0;
            if (this.ObsahujeKod("O."))
            {
                tlouskad = this.vrstvas.Sum(i => i.tloustka_mm ?? 0);
            }
            else
            {
                tlouskad = this.celkova_tloustka ?? 0;
            }

            if ((tlouskad / this.min_vrtak_vrtani) > 7 && this.ObsahujeKod("E2;O.;4A;4B;6A;6B;8A;8B;10A;10B;12A;12B;W1;W2;W4;W6"))
            {
                hlaska(78);
            }

            if (this.ObsahujeKod("PA;") && !this.d_newprint_strana_a.HasValue)
            {
                hlaska(84);
            }
            if (this.ObsahujeKod("PB;") && !this.d_newprint_strana_b.HasValue)
            {
                hlaska(84);
            }
            if (this.ObsahujeKod("PX;") && (!this.d_newprint_strana_b.HasValue || !this.d_newprint_strana_a.HasValue))
            {
                hlaska(84);
            }


            if ((this.ObsahujeKod("SA;SB;SX") && this.snimatelna_maska_typ == null))
            {
                hlaska(82);
            }

            if (this.ObsahujeKod("SA;SB;SX") && (this.snimatelna_maska_typ == null || ((this.snimatelna_maska_typ_id == 1 || this.snimatelna_maska_typ_id == 3))))
            {
                hlaska(88);
            }


            int mezeError = 0;
            foreach (string item in this.KontrolaVnitrni())
            {

                hlaska(47, item);
            }

            foreach (string item in this.KontrolaVnejsi())
            {
                hlaska(47, item);
            }



            int minpridA = 0;
            int minpridB = 0;

            if (this.ObsahujeKod("J1"))
            {
                if (this.ObsahujeKod("D1;D2;D3"))
                {
                    minpridA = 35;
                    minpridB = 35;
                }

                if (this.ObsahujeKod("F1;F2"))
                {
                    minpridA = 40;
                    minpridB = 40;
                }
            }

            if (this.ObsahujeKod("J0;J.;N.;O.") && this.ObsahujeKod("D1;D2;D3;R"))
            {
                minpridA = 40;
                minpridB = 40;
            }

            if (this.ObsahujeKod("J0;J.;O.;N.") && this.ObsahujeKod("F1;F2;"))
            {
                minpridA = 50;
                minpridB = 50;
            }


            if (this.ObsahujeKod("O.;") && this.ObsahujeKod("D1;D2;D3;R") && (this.neprokovene__id != null || this.nepokov_zahl_otvory_id != null))
            {
                minpridA = 50;
                minpridB = 40;
            }

            if (this.ObsahujeKod("4A;E1;E2;W1;W2"))
            {
                minpridA = 50;
                minpridB = 50;
            }

            if (this.ObsahujeKod("4B;6A;6B;8A;8B;10A;10B;12A;12B"))
            {
                minpridA = 80;
                minpridB = 80;
            }



            if (((this.hruby_panel_x ?? 0) - (this.cisty_panel_x ?? 0) < minpridA) ||
                ((this.hruby_panel_y ?? 0) - (this.cisty_panel_y ?? 0) < minpridB))
            {
                hlaska(66);
            }

            if (this.ObsahujeKod("MA;MB;MX"))
            {
                decimal nejvetsi = 0;
                foreach (vrstva v in this.vrstvas)
                {
                    // if (v.strana == "A" || v.strana == "Z" || v.strana == "AB")
                    {
                        int cislo = 0;
                        int cislo1 = 0;
                        decimal vysl = 0;

                        if (v.vrstva_cu != null)
                        {
                            if (v.vrstva_cu.nazev.Contains("/"))
                            {
                                cislo = int.Parse(v.vrstva_cu.nazev.Split('/')[0]);
                                cislo1 = int.Parse(v.vrstva_cu.nazev.Split('/')[1]);

                                if (cislo > cislo1)
                                {
                                    vysl = cislo;
                                }

                                if (cislo < cislo1)
                                {
                                    vysl = cislo1;
                                }

                                if (cislo == cislo1)
                                {
                                    vysl = cislo;
                                }
                            }
                            else
                            {
                                vysl = int.Parse(v.vrstva_cu.nazev);
                            }
                        }


                        if (vysl > nejvetsi)
                        {
                            nejvetsi = vysl;
                        }


                    }
                }

                if (this.ObsahujeKod("MA"))
                {
                    if (nejvetsi >= 100 && (tloustka_maska ?? 0) == 0)
                    {
                        hlaska(87);
                    }
                }

                if (this.ObsahujeKod("MB"))
                {
                    if (nejvetsi >= 100 && (tloustka_maska_b ?? 0) == 0)
                    {
                        hlaska(87);
                    }
                }

                if (this.ObsahujeKod("MX"))
                {
                    if (nejvetsi >= 100 && (tloustka_maska ?? 0) == 0)
                    {
                        hlaska(87);
                    }

                    if (nejvetsi >= 100 && (tloustka_maska_b ?? 0) == 0)
                    {
                        hlaska(87);
                    }
                }
            }

            if (this.ObsahujeKod("Z") && (this.fazetovani_lisovna ?? false))
            {
                hlaska(89);

                if (this.ObsahujeKod("4A;4B;6A;6B;8A;8B;10A;10B;12A;12B;W4;W6"))
                {
                    hlaska(90);
                }
            }

            if ((this.ObsahujeKod("D1") || this.mustky != null) && ((zakladni_panel_x ?? 0) * (zakladni_panel_y ?? 0)) == 0)
            {

                hlaska(91);

            }

            if (this.ObsahujeKod("E1;E2;W1;W2;W4;W6") && this.ObsahujeKod("Z") && (this.ObsahujeKod("MA;MB;MX")))
            {
                hlaska(92);
            }


            if ((this.slepe_vrtani_druh_id ?? 0) > 0)
            {
                hlaska(93);
            }

            if ((this.slepe_vrtani_druh_id ?? 0) > 0 && (this.slepe_vrtani_typ_id ?? 0) == 0)
            {
                hlaska(101);
            }

            // retro, mozna se ani pouzivat nebude

            if ((this.reg_multilayer ?? false) && this.d_sestaveno.HasValue)
            {
                TimeSpan rozdil = this.d_sestaveno.Value - (new DateTime(2004, 7, 1));
                if (rozdil.TotalSeconds < 0)
                {
                    hlaska(95);
                }
            }

            if ((this.naraz_konekt ?? false))
            {
                hlaska(96);

            }

            if ((this.vrstvas.
                Where(i => i.material == null || i.material.nazev == null || !i.material.nazev.Contains("FOLIE")).
                Where(i => i.material == null || i.material.nazev == null || !i.material.nazev.Contains("THERMA")).
                Where(i => i.material == null || i.material.nazev == null || !i.material.nazev.Contains("IS400")).
                Where(i => i.material == null || i.material.nazev == null || !i.material.nazev.Contains("DE104"))).Count() > 0)
            {
                hlaska(97);
            }

            if ((this.test_msd ?? false))
            {
                hlaska(99);
            }

            if ((this.prokovene_drazky_id ?? 0) == 1 || (this.pokovene_zahloubene_otvory_id ?? 0) == 1 || (this.prokovene_hl_frezovani_id ?? 0) == 1)
            {
                hlaska(100);
            }

            if (this.poradi("I;MA") || this.poradi("I;MB") || this.poradi("I;MX"))
            {
                hlaska(102);
            }


            if (this.ObsahujeKod("J1;4A;4B;6A;6B;8A;8B;10A;10B;12A;12B;W4;W6") && !(this.inspecta ?? false))
            {
                hlaska(37);
            }

            if (this.ObsahujeKod("Z") && !(this.olec ?? false))
            {
                hlaska(39);
            }

            if ((this.olec ?? false) && (this.cisty_panel_x ?? 0) < 260)
            {
                hlaska(40);
            }


            if (this.ObsahujeMaterial("IS410;IS620;DUROID;CUCLAD;PYRALUX") && !(this.nestandartni_technologie ?? false))
            {
                hlaska(41);
            }

            if (this.ObsahujeMaterial("TACONIC;") && !(this.nestandartni_technologie ?? false))
            {
                hlaska(44);
            }

            if (this.ObsahujeKod("Q") && (this.min_vrtak_vrtani ?? 0) < 0.6m)
            {
                hlaska(45);
            }


            if ((((this.tolerance_cististeho_rozmeru_horni.HasValue && (this.tolerance_cististeho_rozmeru_horni ?? 0) < 0.2m)) || (this.tolerance_cististeho_rozmeru_dolni.HasValue && (this.tolerance_cististeho_rozmeru_dolni ?? 0) < 0.2m)) && !(this.nestandartni_technologie ?? false))
            {
                hlaska(49);
            }

            if (this.ObsahujeKod("W1;W2;W4;W6") && !(this.nestandartni_technologie ?? false))
            {
                hlaska(51);
            }

            if (!(this.specialni_postup ?? false))
            {
                int hlaska52 = 0;

                if (this.ObsahujeKod("W1;W2;W4;W6"))
                {
                    hlaska52 += 1;
                }

                if (this.skryte_vrtanis.Count > 0)
                {
                    hlaska52 += 1;
                }

                if (this.ObsahujeMaterial("DUROID;"))
                {
                    hlaska52 += 1;
                }

                if ((this.zapln_min_vrtak ?? 0) > 0)
                {
                    hlaska52 += 1;
                }

                if ((this.zapln_pocet_otv ?? 0) > 0)
                {
                    hlaska52 += 1;
                }


                if (hlaska52 > 0)
                {
                    hlaska(52);
                }

            }

            if (this.ObsahujeKod("Z") && !(this.s_kamerou ?? false))
            {
                hlaska(53);
            }

            int pocetMinSpatne = 0;
            if ((this.min_vrtak_vrtani.HasValue && this.min_vrtak_vrtani.Value < 0.2m) || (this.zapln_min_vrtak.HasValue && this.zapln_min_vrtak.Value < 0.2m))
            {
                pocetMinSpatne++;
            }


            foreach (skryte_vrtani sv in this.skryte_vrtanis)
            {
                if (sv.min_vrtak < 0.2m)
                {
                    pocetMinSpatne++;

                }
            }
            if (pocetMinSpatne > 0)
            {
                hlaska(54);
            }


            if (this.ObsahujeKod("D1;D2;D3") && ((this.vd_jadro ?? 0) < 0.2m || (this.vd_kratsi_jadro ?? 0) < 0.2m))
            {
                hlaska(80);
            }

            if (this.ObsahujeKod("E1;E2;") && this.ObsahujeKod("PA;PB;PX"))
            {
                hlaska(103);
            }

            if (this.ObsahujeKod("E1;E2;W1;W2;W4;W6") && this.ObsahujeKod("Q;H;G"))
            {
                hlaska(104);
            }

            if (this.ObsahujeKod("H") && ((this.hruby_panel_x ?? 0) > 600 || (this.hruby_panel_y ?? 0) > 550))
            {
                hlaska(105);
            }

            if (this.ObsahujeKod("I") && ((this.hruby_panel_x ?? 0) > 700 || (this.hruby_panel_y ?? 0) > 600))
            {
                hlaska(106);
            }

            if (this.ObsahujeKod("C") && ((this.hruby_panel_x ?? 0) > 800 || (this.hruby_panel_y ?? 0) > 550))
            {
                hlaska(107);
            }

            if (this.ObsahujeKod("Z") && ((this.hruby_panel_x ?? 0) > 490 || (this.hruby_panel_y ?? 0) > 300))
            {
                hlaska(108);
            }

            if (this.ObsahujeKod("Q") && ((this.hruby_panel_x ?? 0) > 490 || (this.hruby_panel_y ?? 0) > 300))
            {
                hlaska(109);
            }

            if (this.ObsahujeKod("G") && ((this.hruby_panel_x ?? 0) > 740 || (this.hruby_panel_y ?? 0) > 550))
            {
                hlaska(110);
            }

            if (this.ObsahujeKod("Q"))
            {
                hlaska(111);
            }


            if (!(this.olec ?? false) && (this.mk_vnejsi.HasValue) && (this.mk_vnejsi ?? 0) <= 0.15m && ((this.cisty_panel_x ?? 0) >= 300 || (this.cisty_panel_y ?? 0) >= 200))
            {
                hlaska(112);
            }

            if (!(this.olec ?? false) && this.mk_vnejsi.HasValue && (this.mk_vnejsi ?? 0) <= 0.125m)
            {
                hlaska(112);
            }

            if (!(this.olec ?? false) && this.ObsahujeKod("V1A;V1B;V1X;V2A;V2B;V3A;V3B;V3X"))
            {
                hlaska(112);
            }

            if (!(this.olec ?? false) && (this.slepe_vrtani_druh_id ?? 0) > 0)
            {
                hlaska(112);
            }

            //if ((this.olec ?? false) && this.ObsahujeKod("D1;D2;D3"))
            //{
            //    hlaska("E114;pokud existuje požadavek na přesné drážkování", "P");
            //}

            if (!(this.olec ?? false))
            {
                foreach (vrstva v in this.vrstvas)
                {
                    if (v.material.nazev.Contains("DUROID") && (v.tloustka_mm ?? 0) <= 0.13m)
                    {
                        hlaska(112);
                    }
                }

            }


            if ((this.paket_vrtani ?? 0) > 1 && (((this.min_vrtak_vrtani ?? 0) > 0.2m && (this.min_vrtak_vrtani ?? 0) <= 0.45m) || (this.mk_vnejsi ?? 0) <= 0.2m && this.mk_vnejsi.HasValue))
            {
                hlaska(74);
            }

            if ((this.paket_vrtani ?? 0) > 2 && (((this.min_vrtak_vrtani ?? 0) > 0.5m && (this.min_vrtak_vrtani ?? 0) <= 0.75m) || (((this.mk_vnejsi ?? 0) <= 0.3m && this.mk_vnejsi.HasValue))))
            {
                hlaska(74);
            }

            if ((this.paket_vrtani ?? 0) > 3 && ((this.min_vrtak_vrtani ?? 0) >= 0.8m || (this.mk_vnejsi.HasValue)))
            {
                hlaska(74);
            }


            if (((this.min_vrtak_vrtani ?? 0) >= 0.5m && (this.min_vrtak_vrtani ?? 0) <= 0.75m))
            {
                if (((this.paket_vrtani ?? 0) * this.tlouskaDleMat) > 3 && this.ObsahujeKod("J.;O.;N.;J1;"))
                {
                    hlaska(74);
                }

                if (((this.paket_vrtani ?? 0) * this.celkova_tloustka) > 3 && this.ObsahujeKod("4A;4B;6A;6B;8A;8B;10A;10B;12A;12B"))
                {
                    hlaska(74);
                }
            }

            if ((this.min_vrtak_vrtani ?? 0) >= 0.8m)
            {
                if (((this.paket_vrtani ?? 0) * this.tlouskaDleMat) > 4.5m && this.ObsahujeKod("J.;O.;N.;J1;"))
                {
                    hlaska(74);
                }

                if (((this.paket_vrtani ?? 0) * this.celkova_tloustka) > 4.5m && this.ObsahujeKod("4A;4B;6A;6B;8A;8B;10A;10B;12A;12B"))
                {
                    hlaska(74);
                }
            }

            int med = 0;
            foreach (vrstva v in this.vrstvas.Where(i => i.strana != null && (i.strana.Contains("A") || i.strana.Contains("B") || i.strana.Contains("Z"))))
            {
                if (v.vrstva_cu != null)
                {
                    int pom = motivy.mez(v.vrstva_cu.nazev);
                    if (pom > med)
                    {
                        med = pom;
                    }
                }
            }

            if ((this.paket_vrtani ?? 0) > 2 && med >= 70)
            {
                hlaska(74);
            }

            if ((this.orientace_vrtani_id ?? 0) == 0)
            {
                hlaska(114);
            }

            if ((this.ObsahujeKod("SA;SB;SX") && ((this.snimatelna_maska_typ_id ?? 0) == 1 || (this.snimatelna_maska_typ_id ?? 0) == 3)))
            {
                hlaska(115);
            }

            if ((this.aspect_ratio ?? 0) >= 0.8m && (this.slepe_vrtani_typ_id ?? 0) == 0)
            {
                hlaska(116);
            }

            if (this.ObsahujeKod("MA") && !this.maska_barva_id.HasValue)
            {
                hlaska(13);
            }

            if (this.ObsahujeKod("MB") && !this.maska_barva_b_id.HasValue)
            {
                hlaska(13);
            }

            if (this.ObsahujeKod("MX") && (!this.maska_barva_b_id.HasValue || !this.maska_barva_id.HasValue)) // ToDo - kontrola stejnych barev
            {
                hlaska(13);
            }

            //ToDo
            if (this.ObsahujeKod("PA") && (!this.potisk_barva_id.HasValue && !this.d_newprint_strana_a.HasValue))
            {
                hlaska(14);
            }

            if (this.ObsahujeKod("PB") && (!this.potisk_barva_b_id.HasValue && !this.d_newprint_strana_b.HasValue))
            {
                hlaska(14);
            }

            if (this.ObsahujeKod("PX") && ((!this.potisk_barva_id.HasValue && !this.d_newprint_strana_a.HasValue) || (!this.potisk_barva_b_id.HasValue && !this.d_newprint_strana_b.HasValue)))
            {
                hlaska(14);
            }

            if (this.ObsahujeKod("MX") && this.barva_maska_barva_id != this.barva_maska_barva_b_id)
            {
                hlaska(117);
            }

        }

    }



}
