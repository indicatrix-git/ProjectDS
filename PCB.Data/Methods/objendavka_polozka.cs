using PCB.Data.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class objednavka_polozka
    {
        public List<CenikRadka> GetCenikPolozky(pcb_develEntities dbContext)
        {
            List<CenikRadka> vysledek = new List<CenikRadka>();


            if (this.produkt.skryte_vrtanis.Count > 0)
            {
                CenikRadka c = new CenikRadka();
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.skryteVrtani).First();
                c.pocitaSplochou = true;
                vysledek.Add(c);
            }



            #region druh desky
            if (this.plosny_spoj_specifikace_id.HasValue)
            {
                CenikRadka c = new CenikRadka();
                c.pocitaSplochou = true;
                c.typovaCena = true;
                c.Pocet = 1;

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostranne).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt7).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovene).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt5).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt6).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt7).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt8).First();
                }


                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovene).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt5).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt6).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt7).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostranne).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt8).First();
                }


                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt6).First();
                }
                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt8).First();
                }


                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt8).First();
                }


                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.produkt.konstrukt_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.produkt.konstrukt_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.produkt.konstrukt_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.produkt.konstrukt_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.produkt.konstrukt_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt8).First();
                }

                c.Sazba = c.GetSazba(this);

                vysledek.Add(c);
            }

            #endregion

            #region povrchove upravy

            if (this.produkt.ObsahujeKod("C")) //imersni_cin 
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.imerzniCin).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }
            if (this.produkt.ObsahujeKod("H")) // hall
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.HAL).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.produkt.ObsahujeKod("Q")) // imerzni zlaceni
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.imerzniZlaceni).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.produkt.ObsahujeKod("Z")) // zlacene konektory
            {
                CenikRadka c = new CenikRadka();
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.zlaceniKonektoru).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);

            }

            if (this.produkt.ObsahujeKod("G")) // oraganicky povlak
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.organickyPovlak).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }


            #endregion


            // drazkovani 
            if (this.produkt.ObsahujeKod("D1"))
            {
                decimal drazCelkem = this.produkt.vd_delsi_pocet ?? 0 + this.produkt.vd_kratsi_pocet ?? 0;
                CenikRadka c = new CenikRadka();
                c.Pocet = drazCelkem / 10;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.drazkovanIPanelu).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if ((this.produkt.pocet_otvoru_vrtani ?? 0) > 0)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.produkt.pocet_otvoru_vrtani ?? 0;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.vrtani).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.produkt.ObsahujeKod("F1")) // frezovani
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.produkt.delka_frezovani ?? 0;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.frezovaniKlasicke).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.produkt.ObsahujeKod("F2"))
            {
                CenikRadka c = new CenikRadka();
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.frezovaniMustky).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.produkt.ObsahujeKod("F1") && this.produkt.ObsahujeKod("F2")) // frezovani
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pausal = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaFrezovani).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            #region pausaly

            if (this.produkt.ObsahujeKod("V1A") ||
 this.produkt.ObsahujeKod("V1B") ||
 this.produkt.ObsahujeKod("V1X") ||
 this.produkt.ObsahujeKod("V2A") ||
 this.produkt.ObsahujeKod("V2B") ||
 this.produkt.ObsahujeKod("V2X") ||
 this.produkt.ObsahujeKod("V3A") ||
 this.produkt.ObsahujeKod("V3B") ||
 this.produkt.ObsahujeKod("V3X"))
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaVodivaPasta).First();
                c.pausal = true;
                c.Poradi = 999;
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);

            }

            CenikRadka cTPV = new CenikRadka();
            cTPV.Pocet = 1;
            cTPV.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.pripravaTPV).First();
            cTPV.Poradi = 999;
            cTPV.pausal = true;
            cTPV.Sazba = cTPV.GetSazba(this);
            vysledek.Add(cTPV);

            CenikRadka cTPVPripravaDat = new CenikRadka();
            cTPVPripravaDat.Pocet = 1;
            cTPVPripravaDat.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.pripravaData).First();
            cTPVPripravaDat.Poradi = 999;
            cTPVPripravaDat.pausal = true;
            cTPVPripravaDat.Sazba = cTPVPripravaDat.GetSazba(this);
            vysledek.Add(cTPVPripravaDat);

            CenikRadka cTPVPripravaSitoTisk = new CenikRadka();
            cTPVPripravaSitoTisk.Pocet = 1;
            cTPVPripravaSitoTisk.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaSitotisk).First();
            cTPVPripravaSitoTisk.Poradi = 999;
            cTPVPripravaSitoTisk.pausal = true;
            cTPVPripravaSitoTisk.Sazba = cTPVPripravaSitoTisk.GetSazba(this);
            vysledek.Add(cTPVPripravaSitoTisk);

            CenikRadka cTPVPripravaFrezovani = new CenikRadka();
            cTPVPripravaFrezovani.Pocet = 1;
            cTPVPripravaFrezovani.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaFrezovani).First();
            cTPVPripravaFrezovani.Poradi = 999;
            cTPVPripravaFrezovani.pausal = true;
            cTPVPripravaFrezovani.Sazba = cTPVPripravaFrezovani.GetSazba(this);
            vysledek.Add(cTPVPripravaFrezovani);


            CenikRadka cPostovne = new CenikRadka();
            cPostovne.Pocet = 1;
            cPostovne.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.postovneAbalne).First();
            cPostovne.Poradi = 999;
            cPostovne.pausal = true;
            cPostovne.Sazba = cPostovne.GetSazba(this);
            vysledek.Add(cPostovne);

            #endregion

            // elektricky test

            if (this.produkt.ObsahujeKod("T"))
            {

                if (this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSJ ||
                    this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSnevrtaneJ0 ||
                  this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO ||
                    this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN)
                {
                    if ((this.produkt.konstrukt_trida ?? 0) < 5)
                    {
                        CenikRadka c = new CenikRadka();
                        c.Pocet = 1;
                        c.pocitaSplochou = true;
                        c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestJO).First();
                        c.Sazba = c.GetSazba(this);
                        vysledek.Add(c);
                    }

                    if ((this.produkt.konstrukt_trida ?? 0) == 5)
                    {
                        CenikRadka c = new CenikRadka();
                        c.Pocet = 1;
                        c.pocitaSplochou = true;
                        c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestJO5kt).First();
                        c.Sazba = c.GetSazba(this);
                        vysledek.Add(c);
                    }

                    if ((this.produkt.konstrukt_trida ?? 0) == 6)
                    {
                        CenikRadka c = new CenikRadka();
                        c.Pocet = 1;
                        c.pocitaSplochou = true;
                        c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestJO6kt).First();
                        c.Sazba = c.GetSazba(this);
                        vysledek.Add(c);
                    }

                    if ((this.produkt.konstrukt_trida ?? 0) == 7)
                    {
                        CenikRadka c = new CenikRadka();
                        c.Pocet = 1;
                        c.pocitaSplochou = true;
                        c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestJO7kt).First();
                        c.Sazba = c.GetSazba(this);
                        vysledek.Add(c);
                    }
                }

            
                if (this.plosny_spoj_specifikace.PocetVrstva == 4)
                {
                    CenikRadka c = new CenikRadka();
                    c.Pocet = 1;
                    c.pocitaSplochou = true;
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestviceVrstva4).First();
                    c.Sazba = c.GetSazba(this);
                    vysledek.Add(c);
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 6)
                {
                    CenikRadka c = new CenikRadka();
                    c.Pocet = 1;
                    c.pocitaSplochou = true;
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestviceVrstva6).First();
                    c.Sazba = c.GetSazba(this);
                    vysledek.Add(c);
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8)
                {
                    CenikRadka c = new CenikRadka();
                    c.Pocet = 1;
                    c.pocitaSplochou = true;
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestviceVrstva8).First();
                    c.Sazba = c.GetSazba(this);
                    vysledek.Add(c);
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10)
                {
                    CenikRadka c = new CenikRadka();
                    c.Pocet = 1;
                    c.pocitaSplochou = true;
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestviceVrstva10).First();
                    c.Sazba = c.GetSazba(this);
                    vysledek.Add(c);
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12)
                {
                    CenikRadka c = new CenikRadka();
                    c.Pocet = 1;
                    c.pocitaSplochou = true;
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestviceVrstva12).First();
                    c.Sazba = c.GetSazba(this);
                    vysledek.Add(c);
                }

            }

            if (this.produkt.ObsahujeKod("MA") || this.produkt.ObsahujeKod("MB") || this.produkt.ObsahujeKod("MX")) // nepajiva maska
            {


                CenikRadka c = new CenikRadka();
                c.pocitaSplochou = true;
                if (this.produkt.ObsahujeKod("MA") || this.produkt.ObsahujeKod("MB"))
                {
                    c.Pocet = 1;
                }
                else
                {
                    c.Pocet = 2;
                }
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.nepajivaMaska1strana).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);

                if (this.produkt.maska_barva_id != 1)
                {
                    CenikRadka cJinaBarva = new CenikRadka();
                    cJinaBarva.pocitaSplochou = true;
                    cJinaBarva.Pocet = c.Pocet;
                    cJinaBarva.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.nepajivaMaskaJinaNezZelena).First();
                    cJinaBarva.Sazba = c.GetSazba(this);
                    vysledek.Add(cJinaBarva);
                }

            }

            if (this.produkt.ObsahujeKod("PA") || this.produkt.ObsahujeKod("PB") || this.produkt.ObsahujeKod("PX")) // potisk
            {

                CenikRadka c = new CenikRadka();
                c.pocitaSplochou = true;

                if (this.produkt.ObsahujeKod("PA") || this.produkt.ObsahujeKod("PB"))
                {
                    c.Pocet = 1;
                }
                else
                {
                    c.Pocet = 2;
                }

                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.sitotisk).First();
                vysledek.Add(c);

                CenikRadka cPriprava = new CenikRadka();
                cPriprava.Pocet = 1;
                cPriprava.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaSitotisk).First();
                cPriprava.pausal = true;
                vysledek.Add(cPriprava);
            }

            if (this.produkt.ObsahujeKod("SA") || this.produkt.ObsahujeKod("SB") || this.produkt.ObsahujeKod("SX")) // snimatelna maska
            {
                CenikRadka c = new CenikRadka();
                c.pocitaSplochou = true;
                if (this.produkt.ObsahujeKod("SA") || this.produkt.ObsahujeKod("SB"))
                {
                    c.Pocet = 1;
                }
                else
                {
                    c.Pocet = 2;
                }

                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.snimatelnaMaska).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);

                CenikRadka cPriprava = new CenikRadka();
                cPriprava.Pocet = 1;
                cPriprava.pausal = true;
                cPriprava.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaSnimatelnaMaska).First();
                cPriprava.Sazba = cPriprava.GetSazba(this);
                vysledek.Add(cPriprava);
            }

            if (
this.produkt.ObsahujeKod("V1A") ||
this.produkt.ObsahujeKod("V1B") ||
this.produkt.ObsahujeKod("V1X") ||
this.produkt.ObsahujeKod("V2A") ||
this.produkt.ObsahujeKod("V2B") ||
this.produkt.ObsahujeKod("V2X") ||
this.produkt.ObsahujeKod("V3A") ||
this.produkt.ObsahujeKod("V3B") ||
this.produkt.ObsahujeKod("V3X"))
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.vodivaPasta).First();
                vysledek.Add(c);
            }

            // filmy vice vrstve
            if (this.produkt.plosny_spoj_specifikace.PocetVrstva > 0)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.produkt.plosny_spoj_specifikace.PocetVrstva;
                c.pausal = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.produkt.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSJ || (this.produkt.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSnevrtaneJ0))
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).First();
                c.pausal = true;
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.produkt.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN || this.produkt.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 2;
                c.pausal = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            return vysledek;
        }

        public int GetPocetAlPlechu()
        {
            Dictionary<int, int> item = new Dictionary<int, int>();
            item.Add(1, 5);
            item.Add(2, 5);
            item.Add(3, 5);
            item.Add(4, 5);
            item.Add(5, 10);
            item.Add(6, 10);
            item.Add(7, 10);
            item.Add(8, 10);
            item.Add(9, 12);
            item.Add(10, 13);
            item.Add(11, 15);
            item.Add(12, 15);
            item.Add(13, 17);
            item.Add(14, 18);
            item.Add(15, 19);
            item.Add(16, 20);
            item.Add(17, 22);
            item.Add(18, 23);
            item.Add(19, 24);
            item.Add(20, 25);
            item.Add(21, 27);
            item.Add(22, 28);
            item.Add(23, 29);
            item.Add(24, 30);
            item.Add(25, 32);
            item.Add(26, 33);
            item.Add(27, 34);
            item.Add(28, 35);
            item.Add(29, 37);
            item.Add(30, 38);
            item.Add(31, 39);
            item.Add(32, 40);
            item.Add(33, 42);
            item.Add(34, 43);
            item.Add(35, 44);
            item.Add(36, 45);
            item.Add(37, 47);
            item.Add(38, 48);
            item.Add(39, 49);
            item.Add(40, 50);
            item.Add(41, 52);
            item.Add(42, 53);
            item.Add(43, 54);
            item.Add(44, 55);
            item.Add(45, 57);
            item.Add(46, 58);

            if (this.produkt == null)
            {
                return 0;
            }
            else
            {
                decimal pocetks = this.pozadovano_pocet ?? 0 + this.tech_pridavek ?? 0 + this.tech_pridavek_nahrad ?? 0;
                decimal panelizace = this.produkt.hruby_panel_suma ?? 0;

                int pocetPrirezu = Convert.ToInt32(Math.Round((pocetks / panelizace), 0));
                if (pocetPrirezu > 0)
                {
                    return item[pocetPrirezu] * (this.produkt.konstrukt_trida.Value >= 7 ? 2 : 1);
                }
                else
                {
                    return 0;
                }

            }

        }

        public objednavka_polozka Copy()
        {
            objednavka_polozka newObj = new objednavka_polozka();

            newObj.nabidka_polozka_id = this.nabidka_polozka_id;
            newObj.majitel_zakaznik_id = this.majitel_zakaznik_id;
            newObj.objednavatel_zakaznik_id = this.objednavatel_zakaznik_id;
            newObj.produkt_id = this.produkt_id;
            newObj.plosny_spoj_specifikace_id = this.plosny_spoj_specifikace_id;
            newObj.plosny_spoj_druh_id = this.plosny_spoj_druh_id;
            newObj.stav_objednavka_id = this.stav_objednavka_id;
            newObj.pozadovano_pocet = this.pozadovano_pocet;
            newObj.tech_pridavek = this.tech_pridavek;
            newObj.tech_pridavek_nahrad = this.tech_pridavek_nahrad;
            newObj.vyrobni_pridavek = this.vyrobni_pridavek;
            newObj.plocha_dps = this.plocha_dps;
            newObj.tech_priprava_frezovani = this.tech_priprava_frezovani;
            newObj.zdruzeny_motiv = this.zdruzeny_motiv;
            newObj.pozn_z_tpv = this.pozn_z_tpv;
            newObj.zadal_id = this.zadal_id;
            newObj.vice_prace_tpv = this.vice_prace_tpv;
            newObj.kompl_data_tpv = this.kompl_data_tpv;
            newObj.d_zadal = this.d_zadal;
            newObj.smluv_cena = this.smluv_cena;
            newObj.nazev = this.nazev;
            newObj.pocet = this.pocet;
            newObj.doprava_id = this.doprava_id;
            newObj.doruceni_nazev = this.doruceni_nazev;
            newObj.doruceni_ulice = this.doruceni_ulice;
            newObj.doruceni_misto = this.doruceni_misto;
            newObj.doruceni_psc = this.doruceni_psc;
            newObj.zakladni_cena = this.zakladni_cena;
            newObj.cenikova_cena = this.cenikova_cena;
            newObj.vychozi_cena = this.vychozi_cena;
            newObj.d_prirazeno = this.d_prirazeno;
            newObj.prirazeno_id = this.prirazeno_id;
            newObj.dodrzet_termin = this.dodrzet_termin;
            newObj.vzorkova_vyroba = this.vzorkova_vyroba;
            newObj.cenik_id = this.cenik_id;
            newObj.cislo_objednavka = this.cislo_objednavka;

            return newObj;
        }
    }
}

