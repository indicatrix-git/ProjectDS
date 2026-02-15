using PCB.Data.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class nabidka_polozka
    {
        public List<CenikRadka> GetCenikPolozky(pcb_develEntities dbContext)
        {
            List<CenikRadka> vysledek = new List<CenikRadka>();


            if (this.skryte.HasValue && this.skryte.Value)
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


                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostranne).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt7).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovene).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt5).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt6).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt7).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneNeprokovenekt8).First();
                }


                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneProkovene).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneProkovenekt5).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneProkovenekt6).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneProkovenekt7).First();
                }

                if (this.plosny_spoj_specifikace_id == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.oboustraneProkovenekt8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostranne).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 1 && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.jednostrannekt8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 4 && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva4kt8).First();
                }


                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt6).First();
                }
                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 6 && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva6kt8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 8 && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva8kt8).First();
                }


                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 10 && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva10kt8).First();
                }


                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.konstrukcni_trida ?? 0) < 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.konstrukcni_trida ?? 0) == 5)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt5).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.konstrukcni_trida ?? 0) == 6)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt6).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.konstrukcni_trida ?? 0) == 7)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt7).First();
                }

                if (this.plosny_spoj_specifikace.PocetVrstva == 12 && (this.konstrukcni_trida ?? 0) == 8)
                {
                    c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.viceVrstva12kt8).First();
                }

                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }


            #endregion

            #region povrchove upravy

            if (this.imersni_cin ?? false)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.imerzniCin).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }
            if (this.hal ?? false)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.HAL).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.imersni_zlaceni ?? false)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.imerzniZlaceni).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.zlacene_konektory ?? false)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.zlacene_konektory_plocha ?? 0;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.zlaceniKonektoru).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.organicky_povlak.HasValue)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.organickyPovlak).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }
            if (this.celkove_galv_zlaceni ?? false)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.celkove_galv_zlaceni_ploch ?? 0;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.celoplosneGalvanickeZlaceni).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }
            if (this.zlacene_konektory ?? false)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.zlacene_konektory_plocha ?? 0;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.zlaceniKonektoru).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            #endregion

            // drazkovani s daty
            if (this.pocet_vd_delsi.HasValue || this.pocet_vd_kratsi.HasValue)
            {
                decimal drazCelkem = (this.pocet_vd_delsi ?? 0) + (this.pocet_vd_kratsi ?? 0);
                CenikRadka c = new CenikRadka();
                c.Pocet = drazCelkem / 10;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.drazkovanIPanelu).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.pocet_otvoru.HasValue && this.pocet_otvoru.Value > 0)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.pocet_otvoru.Value;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.vrtani).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.frezovani_delka.HasValue)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = (this.frezovani_delka.Value);
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.frezovaniKlasicke).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.frezovani_delka.HasValue)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.pausal = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaFrezovani).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            #region pausaly

            if (this.vodiva_pasta.HasValue && this.vodiva_pasta > 0)
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


            CenikRadka cPostovne = new CenikRadka();
            cPostovne.Pocet = 1;
            cPostovne.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.postovneAbalne).First();
            cPostovne.Poradi = 999;
            cPostovne.pausal = true;
            cPostovne.Sazba = cPostovne.GetSazba(this);
            vysledek.Add(cPostovne);



            #endregion

            // elektricky test

            if (this.elektricky_test.HasValue && this.elektricky_test.Value)
            {
                if (this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSJ ||
                   this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSnevrtaneJ0 ||
                 this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO ||
                   this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN)
                {
                    if ((this.konstrukcni_trida ?? 0) < 5)
                    {
                        CenikRadka c = new CenikRadka();
                        c.Pocet = 1;
                        c.pocitaSplochou = true;
                        c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestJO).First();
                        c.Sazba = c.GetSazba(this);
                        vysledek.Add(c);
                    }

                    if ((this.konstrukcni_trida ?? 0) == 5)
                    {
                        CenikRadka c = new CenikRadka();
                        c.Pocet = 1;
                        c.pocitaSplochou = true;
                        c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestJO5kt).First();
                        c.Sazba = c.GetSazba(this);
                        vysledek.Add(c);
                    }

                    if ((this.konstrukcni_trida ?? 0) == 6)
                    {
                        CenikRadka c = new CenikRadka();
                        c.Pocet = 1;
                        c.pocitaSplochou = true;
                        c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.elektrickyTestJO6kt).First();
                        c.Sazba = c.GetSazba(this);
                        vysledek.Add(c);
                    }

                    if ((this.konstrukcni_trida ?? 0) == 7)
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

            if (this.nepajiva_maska_x.HasValue && this.nepajiva_maska_x.Value > 0 && this.nepajiva_maska_tloustka.HasValue)
            {
                CenikRadka c = new CenikRadka();
                c.pocitaSplochou = true;
                c.Pocet = (this.nepajiva_maska_x ?? 0) * (this.nepajiva_maska_tloustka ?? 0);
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.nepajivaMaska1strana).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);

                if (this.nepajiva_maska_barva_id.HasValue && this.nepajiva_maska_barva_id != 1)
                {
                    CenikRadka cJinaBarva = new CenikRadka();
                    cJinaBarva.pocitaSplochou = true;
                    cJinaBarva.Pocet = this.nepajiva_maska_x.Value * this.nepajiva_maska_tloustka.Value;
                    cJinaBarva.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.nepajivaMaskaJinaNezZelena).First();
                    cJinaBarva.Sazba = c.GetSazba(this);
                    vysledek.Add(cJinaBarva);
                }

            }

            if (this.potisk.HasValue && this.potisk.Value > 0)
            {
                CenikRadka c = new CenikRadka();
                c.pocitaSplochou = true;
                c.Pocet = this.potisk.Value;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.sitotisk).First();
                vysledek.Add(c);

                CenikRadka cPriprava = new CenikRadka();
                cPriprava.Pocet = 1;
                cPriprava.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.PripravaSitotisk).First();
                cPriprava.pausal = true;
                vysledek.Add(cPriprava);
            }

            if (this.snimatelna_maska.HasValue && this.snimatelna_maska.Value > 0)
            {
                CenikRadka c = new CenikRadka();
                c.pocitaSplochou = true;
                c.Pocet = snimatelna_maska.Value;
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

            if (this.vodiva_pasta.HasValue && this.vodiva_pasta.Value > 0)
            {

                CenikRadka c = new CenikRadka();
                c.Pocet = this.vodiva_pasta.Value;
                c.pocitaSplochou = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.vodivaPasta).First();
                vysledek.Add(c);
            }

            // filmy vice vrstve
            if (vice_vrstvy.HasValue)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = this.plosny_spoj_specifikace.PocetVrstva;
                c.pausal = true;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).First();
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSJ || this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladjednostranneDPSnevrtaneJ0)
            {
                CenikRadka c = new CenikRadka();
                c.Pocet = 1;
                c.Polozka = dbContext.cenik_polozkas.Where(i => i.cenik_polozka_id == (int)cenik_polozka.Value.filmovePredlohyNaVrstvu).First();
                c.pausal = true;
                c.Sazba = c.GetSazba(this);
                vysledek.Add(c);
            }

            if (this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustanneDPSneprokovenneN || this.plosny_spoj_specifikace_id.Value == (int)plosny_spoj_specifikace.Value.ZakladoboustranneDPSO)
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

    }
}

