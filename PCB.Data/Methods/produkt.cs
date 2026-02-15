using PCB.Data;
using PCB.Data.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class produkt
    {

        // zapise k filtru popisek
        public void VypisPopisek(string popisek, string filtr)
        {
            foreach (operace o in this.seznamOperaci)
            {
                if (o.filtr == filtr)
                {
                    o.Popisek = popisek;
                }
            }
        }

        /// <summary>
        /// vlozi pozadovany filtr
        /// </summary>
        /// <param name="filtr"></param>
        public void filtr(string filtr)
        {
            foreach (operace o in this.seznamOperaci)
            {
                if (o.filtr == filtr)
                {
                    o.Vybrano = true;
                }
            }
        }

        /// <summary>
        /// pro kod prida pozadovany filtr
        /// </summary>
        /// <param name="kod"></param>
        /// <param name="filtr"></param>
        public void filtr(string kod, string filtr)
        {
            foreach (operace o in this.seznamOperaci)
            {
                if (o.kod == kod)
                {
                    if (o.filtr == filtr)
                    {
                        o.Vybrano = true;
                    }
                }
            }

        }


        public void LoadSeznamOperaci()
        {
            LoadSeznamOperaci(new pcb_develEntities(), false);
        }

        public void LoadSeznamOperaci(pcb_develEntities dbContext)
        {
            LoadSeznamOperaci(dbContext, false);
        }


        /// <summary>
        /// sestavi seznam operaci pro danny produkt
        /// </summary>
        /// <param name="dbContext"></param>
        
        public void pridatVrstvu(int pocetDesek, int material, int? cu, decimal? tlouska, string strana, int poradi)
        {
            vrstva item = new vrstva();
            item.pocet = pocetDesek;
            item.material_id = material;
            item.vrstva_cu_id = cu;
            item.tloustka_mm = tlouska;
            item.strana = strana;
            item.produkt = this;
            item.poradi = poradi;

            this.vrstvas.Add(item);
        }

        public produkt CopyProdukt(bool withRevize, bool withFilm, bool zmena)
        {
            produkt pNovy = new produkt();
            produkt p = this;

            pNovy.potisk_barva_id = p.potisk_barva_id;
            pNovy.potisk_barva_b_id = p.potisk_barva_b_id;

            pNovy.maska_barva_id = p.maska_barva_id;
            pNovy.maska_barva_b_id = p.maska_barva_b_id;

            pNovy.laser_druh_id = p.laser_druh_id;
            pNovy.oznaceni_fp_druh_id = p.oznaceni_fp_druh_id;
            pNovy.oznaceni_fp_typ_id = p.oznaceni_fp_typ_id;
            pNovy.smd_typ_id = p.smd_typ_id;
            pNovy.slepe_vrtani_typ_id = p.slepe_vrtani_typ_id;
            pNovy.snimatelna_maska_typ_id = p.snimatelna_maska_typ_id;
            pNovy.slepe_vrtani_druh_id = p.slepe_vrtani_druh_id;
            pNovy.laser_typ_id = p.laser_typ_id;
            pNovy.zakaznik_id = p.zakaznik_id;
            pNovy.uloziste = p.uloziste;
            pNovy.dodal_drill = p.dodal_drill;
            pNovy.dodal_gerber_data = p.dodal_gerber_data;
            pNovy.dodal_vykres = p.dodal_vykres;
            pNovy.dodal_film = p.dodal_film;
            pNovy.pocet_fp = p.pocet_fp;
            pNovy.archivace = p.archivace;
            pNovy.nazev = p.nazev;
            pNovy.motiv = p.motiv;
            pNovy.d_sestaveno = PCB.Data.DBHelper.DateTimeNow();
            pNovy.makro = p.makro;
            pNovy.konstrukt_trida = p.konstrukt_trida;
            pNovy.nestandartni_technologie = p.nestandartni_technologie;
            pNovy.specialni_postup = p.specialni_postup;
            pNovy.technologicka_poznamka = p.technologicka_poznamka;
            pNovy.celkova_tloustka = p.celkova_tloustka;
            pNovy.tolerance_horni = p.tolerance_horni;
            pNovy.tolerance_dolni = p.tolerance_dolni;
            pNovy.laminace_materialu = p.laminace_materialu;
            pNovy.cisty_rozmer_dps_x = p.cisty_rozmer_dps_x;
            pNovy.cisty_rozmer_dps_y = p.cisty_rozmer_dps_y;
            pNovy.tolerance_cististeho_rozmeru_horni = p.tolerance_cististeho_rozmeru_horni;
            pNovy.tolerance_cististeho_rozmeru_dolni = p.tolerance_cististeho_rozmeru_dolni;
            pNovy.zakladni_panel_x = p.zakladni_panel_x;
            pNovy.zakladni_panel_y = p.zakladni_panel_y;
            pNovy.zakladni_panel_suma = p.zakladni_panel_suma;
            pNovy.cisty_panel_x = p.cisty_panel_x;
            pNovy.cisty_panel_y = p.cisty_panel_y;
            pNovy.hruby_panel_x = p.hruby_panel_x;
            pNovy.hruby_panel_y = p.hruby_panel_y;
            pNovy.hruby_panel_suma = p.hruby_panel_suma;
            pNovy.sp2 = p.sp2;
            pNovy.mk = p.mk;
            pNovy.iz = p.iz;
            pNovy.vv = p.vv;
            pNovy.mk_vnejsi = p.mk_vnejsi;
            pNovy.iz_vnejsi = p.iz_vnejsi;
            pNovy.kor_vrstvy_vnejsi = p.kor_vrstvy_vnejsi;
            pNovy.kor_vrstvy_vnitrni = p.kor_vrstvy_vnitrni;
            pNovy.inspecta = p.inspecta;
            pNovy.reg_multilayer = p.reg_multilayer;
            pNovy.olec = p.olec;
            pNovy.vice_pokoveni = p.vice_pokoveni;
            pNovy.test_msd = p.test_msd;
            pNovy.tloustka_maska = p.tloustka_maska;
            pNovy.tloustka_maska_b = p.tloustka_maska_b;
            pNovy.newprint_uzivatel_strana_a_id = p.newprint_uzivatel_strana_a_id;
            pNovy.newprint_uzivatel_strana_b_id = p.newprint_uzivatel_strana_b_id;
            pNovy.d_newprint_strana_a = p.d_newprint_strana_a;
            pNovy.d_newprint_strana_b = p.d_newprint_strana_b;
            pNovy.ul = p.ul;
            pNovy.datovy_soubor = p.datovy_soubor;
            pNovy.paket_vrtani = p.paket_vrtani;
            pNovy.osa_vrtani = p.osa_vrtani;
            pNovy.min_vrtak_vrtani = p.min_vrtak_vrtani;
            pNovy.pocet_otvoru_vrtani = p.pocet_otvoru_vrtani;
            pNovy.naraz_konekt = p.naraz_konekt;
            pNovy.vrtani_poznamka = p.vrtani_poznamka;
            pNovy.paket_frezovani = p.paket_frezovani;
            pNovy.s_kamerou = p.s_kamerou;
            pNovy.delka_frezovani = p.delka_frezovani;
            pNovy.zabruseni_mustku = p.zabruseni_mustku;
            pNovy.hloubkove_frezovani_s_kamerou = p.hloubkove_frezovani_s_kamerou;
            pNovy.frezeovani_pul_otvoru = p.frezeovani_pul_otvoru;
            pNovy.fazetovani_lisovna = p.fazetovani_lisovna;
            pNovy.fazetetovani_lis_hodnota = p.fazetetovani_lis_hodnota;
            pNovy.technologicke_frezovani = p.technologicke_frezovani;
            pNovy.technologicke_frezovani_delka = p.technologicke_frezovani_delka;
            pNovy.zapln_min_vrtak = p.zapln_min_vrtak;
            pNovy.zapln_pocet_otv = p.zapln_pocet_otv;
            pNovy.prokovovene_drazky = p.prokovovene_drazky;
            pNovy.zaplnovane_paket = p.zaplnovane_paket;
            pNovy.pokovene_zahloubene_otvory_id = p.pokovene_zahloubene_otvory_id;
            pNovy.prokovene_hl_frezovani_id = p.prokovene_hl_frezovani_id;
            pNovy.prokovene_drazky_id = p.prokovene_drazky_id;
            pNovy.nepokov_zahl_otvory_id = p.nepokov_zahl_otvory_id;
            pNovy.neprokovene_paket = p.neprokovene_paket;
            pNovy.prokovene_paket = p.prokovene_paket;
            pNovy.zapsal_et_id = p.zapsal_et_id;
            pNovy.neprok_otvory_s_kamerou = p.neprok_otvory_s_kamerou;
            pNovy.zahl_pocet_otvoru = p.zahl_pocet_otvoru;
            pNovy.zahl_paket = p.zahl_paket;
            pNovy.vd_delsi_pocet = p.vd_delsi_pocet;
            pNovy.vd_kratsi_pocet = p.vd_kratsi_pocet;
            pNovy.vd_jadro = p.vd_jadro;
            pNovy.vd_kratsi_jadro = p.vd_kratsi_jadro;
            pNovy.vd_delsi_detail = p.vd_delsi_detail;
            pNovy.vd_kratsi_detail = p.vd_kratsi_detail;
            pNovy.aoi = p.aoi;
            pNovy.aoi_zapsal_id = p.aoi_zapsal_id;
            pNovy.aoi_datum = p.aoi_datum;
            pNovy.neprokovene__id = p.neprokovene__id;
            pNovy.hloubkove_frezovani_id = p.hloubkove_frezovani_id;
            pNovy.mustky_id = p.mustky_id;
            pNovy.orientace_vrtani_id = p.orientace_vrtani_id;
            pNovy.sestavil = p.sestavil;
            pNovy.et = p.et;
            pNovy.et_datum = p.et_datum;
            pNovy.et_poznamka = p.et_poznamka;
            pNovy.poznamka = p.poznamka;
            pNovy.sablona = p.sablona;
            pNovy.vrtani_cu_id = p.vrtani_cu_id;
            pNovy.produkt_stav_id = p.produkt_stav_id;
            pNovy.mps = p.mps;
            pNovy.laser_delka = p.laser_delka;
            pNovy.laminace_definice = p.laminace_definice;
            pNovy.plosny_spoj_specifikace_id = p.plosny_spoj_specifikace_id;
            pNovy.aspect_ratio = p.aspect_ratio;
            pNovy.fazetovani_freza = p.fazetovani_freza;
            pNovy.fazetetovani_freza_hodnota = p.fazetetovani_freza_hodnota;
            pNovy.kod = p.kod;

            pNovy.KopieZProduktu = p;

            // vrstvy
            foreach (vrstva v in p.vrstvas)
            {
                vrstva vNew = new vrstva();
                vNew.poradi = v.poradi;
                vNew.material_id = v.material_id;
                vNew.pocet = v.pocet;
                vNew.vrstva_cu_id = v.vrstva_cu_id;
                vNew.strana = v.strana;
                vNew.produkt_id = pNovy.produkt_id;

                vNew.tloustka_mm = v.tloustka_mm;

                pNovy.vrstvas.Add(vNew);
            }


            // skryte vrtani
            foreach (skryte_vrtani v in p.skryte_vrtanis)
            {
                skryte_vrtani skryte = new skryte_vrtani();
                skryte.produkt_id = pNovy.produkt_id;
                skryte.paket = v.paket;
                skryte.pocet_otvoru = v.pocet_otvoru;
                skryte.min_vrtak = v.min_vrtak;
                skryte.vrstva = v.vrstva;

                pNovy.skryte_vrtanis.Add(skryte);
            }

            // poznamky
            foreach (produkt_poznamka pp in p.produkt_poznamkas)
            {
                produkt_poznamka poznamka = new produkt_poznamka();
                poznamka.produkt_id = pNovy.produkt_id;
                poznamka.uzivatel_id = pp.uzivatel.uzivatel_id;
                poznamka.poznamka = pp.poznamka;
                poznamka.operace = pp.operace;
                poznamka.d_zapsano = PCB.Data.DBHelper.DateTimeNow();
                pNovy.produkt_poznamkas.Add(poznamka);
            }

            if (withFilm)
            {
                // filmy
                foreach (film item in p.films)
                {
                    film film = new film();
                    film.produkt_id = pNovy.produkt_id;
                    film.film_typ_id = item.film_typ_id;
                    film.oznaceni = item.oznaceni;
                    film.vrstva = item.vrstva;
                    pNovy.films.Add(film);
                }
            }

            if (zmena)
            {
                // zmeny
                foreach (zmena item in p.zmenas)
                {
                    zmena z = new zmena();
                    z.produkt_id = pNovy.produkt_id;
                    z.cislo = item.cislo;
                    z.d_zmena = item.d_zmena;
                    z.rok = item.rok;
                    z.uzivatel_id = item.uzivatel_id;
                    pNovy.zmenas.Add(z);
                }
            }

            // motiv cu
            foreach (motiv item in p.motivs)
            {
                motiv m = new motiv();
                m.motiv_typ_id = item.motiv_typ_id;
                m.produkt_id = pNovy.produkt_id;
                m.plocha1 = item.plocha1;
                m.plocha2 = item.plocha2;
                m.vrstva = item.vrstva;
                m.vrstva1 = item.vrstva1;

                pNovy.motivs.Add(m);
            }

            // mozni objednavatele
            foreach (mozni_objednavatele item in p.mozni_objednavateles)
            {
                mozni_objednavatele mo = new mozni_objednavatele();
                mo.produkt_id = pNovy.produkt_id;
                mo.zakaznik_id = item.zakaznik_id;
                pNovy.mozni_objednavateles.Add(mo);
            }

            // specialni postup
            foreach (specialni_postup item in p.specialni_postups)
            {
                specialni_postup sp = new specialni_postup();
                sp.produkt = pNovy;
                sp.d_zapsal = item.d_zapsal;
                sp.operace_id = item.operace_id;
                sp.poradi = item.poradi;
                sp.odepisovat = item.odepisovat;
                sp.technologicka_poznamka = item.technologicka_poznamka;
                sp.zapsal_uzivatel_id= item.zapsal_uzivatel_id;
                pNovy.specialni_postups.Add(sp);
            }

            // postup
            foreach (produkt_postup item in p.produkt_postups)
            {
                produkt_postup pp = new produkt_postup();
                pp.produkt_id = pNovy.produkt_id;
                pp.postup_id = item.postup_id;
                pNovy.produkt_postups.Add(pp);
            }

            // revize
            if (withRevize)
            {
                foreach (produkt_revize item in p.produkt_revizes)
                {
                    produkt_revize pr = new produkt_revize();
                    pr.produkt_id = pNovy.produkt_id;
                    pr.uzivatel_id = item.uzivatel_id;
                    pr.poznamka = item.poznamka;
                    pr.d_zapsano = item.d_zapsano;
                    pNovy.produkt_revizes.Add(pr);
                }
            }
            return pNovy;

        }
    }
}
