using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using PCB.Base;
using PCB.Data;
using PCB.Data.CustomObjects;
using PCB.Gui;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB
{
    public partial class frmProduktDetail : frmBaseDetail
    {
        public ProduktAkce TypAkce { get; set; }
        public enum ProduktAkce { novaDPS = 0, zmenaDPS = 1, zmenaIV = 2, kopie = 3 }

        public frmProduktDetail()
        {
            InitializeComponent();

            this.cbFazet.Properties.DataSource = new int[] { 60, 40 };
            this.cmbFazetFreza.Properties.DataSource = new int[] { 120, 90, 60 };

#if !DEBUG
            gridColumn52.Visible = false;
            gridColumn53.Visible = false;
#endif
        }

        public override void setReadonly(Control.ControlCollection cs)
        {
            if (((produkt)this.entityObject).zamek ?? false)
            {

                base.setReadonly(cs);

            }
            else
            {
                if (!this.HasPravoZapis(prava.Value.TPVTechnickaDokumentace))
                {
                    base.setReadonly(cs);
                }
            }

            if (this.HasPravoZapis(prava.Value.ObchodZakaznik))
            {
                btnNovyZak.Enabled = true;
                btnOdstrMozniObjednavatele.Enabled = true;
                btnUlozit.Enabled = true;
            }

            if (this.HasPravoZapis(prava.Value.PripravarDatProTestovani))
            {
                mePoznamka.ReadOnly = false;
                cbPozadavekNaOptickyTest.ReadOnly = false;
                chbAOI.ReadOnly = false;
                chbET.ReadOnly = false;
                cbAOICombo.ReadOnly = false;
                cbETCombo.ReadOnly = false;

                dateEditAOI.ReadOnly = false;
                dateEditET.ReadOnly = false;

                btnUlozit.Enabled = true;
            }

            if (this.HasPravoZapis(prava.Value.TechnologieTechnickaDokumentace))
            {
                btnTechPoznamkaPridat.Enabled = true;
                btnTechnologickaPoznamkaOdstranit.Enabled = true;

                btnOpOdstr.Enabled = true;
                btnPrenestZKodu.Enabled = true;
                btnPrevzitZJineDesky.Enabled = true;

                chbSP.ReadOnly = false;
                chbTP.ReadOnly = false;
                btnSpecialniPostupDolu.Enabled = true;
                btnSpecialniPostupNahoru.Enabled = true;
                btnHromadne.Enabled = true;


                btnUlozit.Enabled = true;

            }


            btnTechnologickyPostup.Enabled = true;
            btnStorno.Enabled = true;
            btnHelp.Enabled = true;
            btnKontrola.Enabled = true;
            btnMaterial.Enabled = true;
            cbAktivni.Enabled = true;
            cbSPAktivni.Enabled = true;
        }

        public override void LoadData(System.Data.Entity.Core.Objects.DataClasses.EntityObject entity)
        {
            base.LoadData(entity);

            if (this.FormMode == mode.novy)
            {
                if (this.entityObject == null)
                {
                    this.entityObject = new produkt();
                    ((produkt)this.entityObject).sestavil = this.PrihlasenyUzivatelId;
                    ((produkt)this.entityObject).d_sestaveno = PCB.Data.DBHelper.DateTimeNow();
                    ((produkt)this.entityObject).uzivatel_sestavil = this.DBContext.uzivatels.Where(item => item.uzivatel_id == ((produkt)this.entityObject).sestavil).First();

                    film f = new film();
                    f.film_typ_id = 1; // všechny
                    f.vrstva = "";
                    f.oznaceni = string.Format("P{0}C{1}B-{2}", ((produkt)this.entityObject).d_sestaveno.Value.Day.ToString().PadLeft(2, '0') + ((produkt)this.entityObject).d_sestaveno.Value.Month.ToString().PadLeft(2, '0'),
                            ((produkt)this.entityObject).d_sestaveno.Value.Year.ToString().Substring(2, 2),
                            ((produkt)this.entityObject).uzivatel_sestavil.Inicialy);
                    ((produkt)this.entityObject).films.Add(f);

                }

                if (TypAkce == ProduktAkce.kopie)
                {
                    film f = new film();
                    f.film_typ_id = 1; // všechny
                    f.vrstva = "";
                    ((produkt)this.entityObject).uzivatel_sestavil = this.DBContext.uzivatels.Where(item => item.uzivatel_id == ((produkt)this.entityObject).sestavil).First();

                    f.oznaceni = string.Format("P{0}C{1}B-{2}", ((produkt)this.entityObject).d_sestaveno.Value.Day.ToString().PadLeft(2, '0') + ((produkt)this.entityObject).d_sestaveno.Value.Month.ToString().PadLeft(2, '0'),
                            ((produkt)this.entityObject).d_sestaveno.Value.Year.ToString().Substring(2, 2),
                            ((produkt)this.entityObject).uzivatel_sestavil.Inicialy);
                    ((produkt)this.entityObject).films.Add(f);
                }

                ((produkt)this.entityObject).d_sestaveno = PCB.Data.DBHelper.DateTimeNow();

                ((produkt)this.entityObject).sestavil = this.PrihlasenyUzivatelId;
                ((produkt)this.entityObject).uzivatel_sestavil = this.DBContext.uzivatels.Where(item => item.uzivatel_id == ((produkt)this.entityObject).sestavil).First();

                ((produkt)this.entityObject).produkt_stav_id = (int)produkt_stav.Value.aktivni;
                ((produkt)this.entityObject).konstrukt_trida = 5;
            }
            else
            {
                AktivnostPolicekDleKodu();

                if (TypAkce == ProduktAkce.zmenaIV)
                {
                    produkt_revize pr = new produkt_revize();
                    if (((produkt)this.entityObject).produkt_revizes.Count == 0)
                    {
                        pr.revize = 1;
                    }
                    else
                    {
                        pr.revize = ((produkt)this.entityObject).produkt_revizes.Max(item => item.revize) + 1;
                    }

                    pr.d_zapsano = PCB.Data.DBHelper.DateTimeNow();
                    pr.uzivatel_id = this.PrihlasenyUzivatelId;

                    ((produkt)this.entityObject).zamek = false;
                    ((produkt)this.entityObject).produkt_revizes.Add(pr);
                }


                string strSQL = @"
SELECT DISTINCT 
obj.nazev AS obj_nazev_dps
FROM objednavka_polozka obj
JOIN produkt p ON p.produkt_id = obj.produkt_id 
WHERE obj.nazev is not null AND obj.nazev <> '' AND  p.produkt_id = " + ((produkt)this.entityObject).produkt_id;

                nazevDPSBindingSource.DataSource = DBHelper.SQLSelect(this.DBContext, strSQL);
            }

            zmenaBindingSource.DataSource = ((produkt)this.entityObject).zmenas;
            filmyBindingSource.DataSource = ((produkt)this.entityObject).films;

            motivCuBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med).ToList();
            motivZlaceniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.zlaceni).ToList();
            motivOdmaskovaniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.odmaskovani).ToList();

            mozniObjedBindingSource.DataSource = ((produkt)this.entityObject).mozni_objednavateles;
            skrytevrtaniBindingSource.DataSource = ((produkt)this.entityObject).skryte_vrtanis;
            vrstvaBindingSource.DataSource = ((produkt)this.entityObject).vrstvas;
            specialnipostupBindingSource.DataSource = ((produkt)this.entityObject).specialni_postups.Where(i => (i.aktivni ?? false) == cbSPAktivni.Checked).ToList();
            produktpoznamkaBindingSource.DataSource = ((produkt)this.entityObject).produkt_poznamkas.Where(i => (i.aktivni ?? false) == cbAktivni.Checked).ToList();
            produktrevizeBindingSource.DataSource = ((produkt)this.entityObject).produkt_revizes;

            produktBindingSource.DataSource = this.entityObject;
            souborTypBindingSource.DataSource = DBContext.soubor_typs.ToList();
            souborTypFrezovaniBindingSource.DataSource = DBContext.soubor_typ_frezovanis.ToList();
            orientacevrtaniBindingSource.DataSource = DBContext.orientace_vrtanis.ToList();
            snimatelnamaskatypBindingSource.DataSource = DBContext.snimatelna_maska_typs.ToList().OrderBy(i => i.snimatelna_maska_typ_id);
            smdtypidBindingSource.DataSource = DBContext.smd_typ_ids.ToList();
            lasertypBindingSource.DataSource = DBContext.laser_typs.ToList();
            laserdruhBindingSource.DataSource = DBContext.laser_druhs.ToList();

            uzivatelBindingSource2.DataSource =
            uzivatelBindingSource3.DataSource =
            uzivatelBindingSource4.DataSource =
                DBContext.uzivatels.ToList();

            cbBarvaMaska.Properties.DataSource = DBContext.barvas.ToList().OrderBy(o => o.barva_id);
            cbBarvaMaskaB.Properties.DataSource = DBContext.barvas.ToList().OrderBy(o => o.barva_id);
            cbPotiskBarva.Properties.DataSource = DBContext.barvas.Where(i => i.barva_id == 2 || i.barva_id == 3).ToList(); // bila a cerna omezeni
            cbPotiskBarvaB.Properties.DataSource = DBContext.barvas.Where(i => i.barva_id == 2 || i.barva_id == 3).ToList(); // bila a cerna omezeni


            oznacenifpdruhBindingSource.DataSource = DBContext.oznaceni_fp_druhs.ToList();
            oznacenifptypBindingSource.DataSource = DBContext.oznaceni_fp_typs.ToList();


            mustkyBindingSource.DataSource = DBContext.mustkies.ToList();
            slepevrtanidruhBindingSource.DataSource = DBContext.slepe_vrtani_druhs.ToList();
            slepevrtanitypBindingSource.DataSource = DBContext.slepe_vrtani_typs.ToList();

            vrstvacuBindingSource.DataSource = DBContext.vrstva_cus;
            materialBindingSource.DataSource = DBContext.materials.ToList();

            soubortypBindingSource1.DataSource =
            soubortypBindingSource2.DataSource =
            soubortypBindingSource3.DataSource =
            soubortypBindingSource4.DataSource =
            soubortypBindingSource5.DataSource =
            soubortypBindingSource6.DataSource = DBContext.soubor_typs.ToList();

            uzivatelBindingSource.DataSource = DBContext.uzivatels.ToList();

            filmtypBindingSource.DataSource = DBContext.film_typs.OrderBy(i => i.film_typ_id).ToList();
            uzivatelBindingSource1.DataSource = DBContext.uzivatels.ToList();
            vrtanicuBindingSource.DataSource = DBContext.vrtani_cus.ToList();
            slepevrtanitypBindingSource1.DataSource = DBContext.slepe_vrtani_typs.ToList();

            cbVetsiSpVnejsi.Properties.DataSource = new ItemPCB[]
            {
              new ItemPCB() { Name = "0,10", Value = 0.10 },
              new ItemPCB() { Name = "0,125", Value = 0.125 },
              new ItemPCB() { Name = "0,15", Value = 0.15 },
              new ItemPCB() { Name = "0,20", Value = 0.20 },
              new ItemPCB() { Name = "0,30", Value = 0.30 }
            };

            cbMkVetsiVnejsi.Properties.DataSource = new ItemPCB[]
            {
              new ItemPCB() { Name = "0,10", Value = 0.10 },
              new ItemPCB() { Name = "0,125", Value = 0.125 },
              new ItemPCB() { Name = "0,15", Value = 0.15 },
              new ItemPCB() { Name = "0,20", Value = 0.20 },
              new ItemPCB() { Name = "0,30", Value = 0.30 }
            };

            cbIzVetsiVnejsi.Properties.DataSource = new ItemPCB[]
            {
              new ItemPCB() { Name = "0,10", Value = 0.10 },
              new ItemPCB() { Name = "0,125", Value = 0.125 },
              new ItemPCB() { Name = "0,15", Value = 0.15 },
              new ItemPCB() { Name = "0,20", Value = 0.20 },
              new ItemPCB() { Name = "0,30", Value = 0.30 }
            };

            cbVvVetsi.Properties.DataSource = new ItemPCB[]
            {
              new ItemPCB() { Name = "0,25", Value = 0.25 },
              new ItemPCB() { Name = "0,30", Value = 0.30 }
            };



            cbVetsiSpVnitrni.Properties.DataSource = new ItemPCB[]
            {
              new ItemPCB() { Name = "0,10", Value = 0.10 },
              new ItemPCB() { Name = "0,125", Value = 0.12 },
              new ItemPCB() { Name = "0,15", Value = 0.15 },
              new ItemPCB() { Name = "0,20", Value = 0.20 },
              new ItemPCB() { Name = "0,30", Value = 0.30 }
            };

            cbMkVetsiVnitrni.Properties.DataSource = new ItemPCB[]
            {
              new ItemPCB() { Name = "0,10", Value = 0.10 },
              new ItemPCB() { Name = "0,125", Value = 0.125 },
              new ItemPCB() { Name = "0,15", Value = 0.15 },
              new ItemPCB() { Name = "0,20", Value = 0.20 },
              new ItemPCB() { Name = "0,30", Value = 0.30 }
            };

            cbIzVetsiVnitrni.Properties.DataSource = new ItemPCB[]
            {
              new ItemPCB() { Name = "0,10", Value = 0.10 },
              new ItemPCB() { Name = "0,125", Value = 0.125 },
              new ItemPCB() { Name = "0,15", Value = 0.15 },
              new ItemPCB() { Name = "0,20", Value = 0.20 },
              new ItemPCB() { Name = "0,30", Value = 0.30 }
            };

            lblZamek.Visible = (((produkt)this.entityObject).zamek ?? false);

            vychoziCheckboxy();

            chbTP.Checked = ((produkt)this.entityObject).technologicka_poznamka.HasValue ? ((produkt)this.entityObject).technologicka_poznamka.Value : false;
            chbNT.Checked = ((produkt)this.entityObject).nestandartni_technologie.HasValue ? ((produkt)this.entityObject).nestandartni_technologie.Value : false;
            chbSP.Checked = ((produkt)this.entityObject).specialni_postup.HasValue ? ((produkt)this.entityObject).specialni_postup.Value : false;
            chbLaminace.Checked = ((produkt)this.entityObject).laminace_materialu.HasValue ? ((produkt)this.entityObject).laminace_materialu.Value : false;
        }

        private void vychoziCheckboxy()
        {
            cb_barva(this.chbSP, null);
            cb_barva(this.chbTP, null);
            cb_barva(this.chbNT, null);
            cb_barva(this.chbLaminace, null);
            cb_barva(this.cbDodrzetMaterial, null);


            memoEdit4.ReadOnly = !chbLaminace.Checked;
            txtNarazeciKonektory.ReadOnly = !chbNarKonektory.Checked;

            btnLaminaceHelp.Enabled = chbLaminace.Checked;
        }

        private void AktivnostPolicekDleKodu()
        {
            if (((produkt)this.entityObject).plosny_spoj_specifikace_id == null)
            {
                ((produkt)this.entityObject).plosny_spoj_specifikace_id = 1;
            }

            ((produkt)this.entityObject).plosny_spoj_specifikace = this.DBContext.plosny_spoj_specifikaces.Where(item => item.plosny_spoj_specifikace_id == ((produkt)this.entityObject).plosny_spoj_specifikace_id).First();

            if (((produkt)this.entityObject).ObsahujeKod("E1;J.;J0;W1;J1;E2;O.;N.;W2"))
            {
                cbMkVetsiVnejsi.Enabled = true;
                cbIzVetsiVnejsi.Enabled = true;
                cbVetsiSpVnejsi.Enabled = true;

                cbMkVetsiVnitrni.Enabled = false;
                cbIzVetsiVnitrni.Enabled = false;
                cbVetsiSpVnitrni.Enabled = false;

                cbVvVetsi.Enabled = false;
            }


            if (((produkt)this.entityObject).ObsahujeKod("4A;6A;8A;10A;12A;4B;6B;8B;10B;12B;W4;W6;"))
            {
                cbMkVetsiVnejsi.Enabled = true;
                cbIzVetsiVnejsi.Enabled = true;
                cbVetsiSpVnejsi.Enabled = true;

                cbMkVetsiVnitrni.Enabled = true;
                cbIzVetsiVnitrni.Enabled = true;
                cbVetsiSpVnitrni.Enabled = true;

                cbVvVetsi.Enabled = true;
            }


        }

        public override void SaveData()
        {
            if (this.FormMode == mode.novy)
            {
                ((produkt)this.entityObject).sestavil = this.PrihlasenyUzivatelId;
                ((produkt)this.entityObject).d_sestaveno = PCB.Data.DBHelper.DateTimeNow();
                this.DBContext.produkts.AddObject((produkt)this.entityObject);
            }

            base.SaveData();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            // bude to textak ze souboru na disku, nestandartniTechnologie.txt 
            frmNapoveda.Set(@"
1. v případě nedodržení hodnot návrhu DPS v závislosti na požadované tloušce Cu 
<br>  2.Potisk s minimální výškou písma menší než 0,8 mm 
<br> a tlouškou čáry mezi 0,12 - 0,15 mm. 
<br><br> 3.Základní materiál DUROID, CUCLAD, PYRALUX, TACONIC 
<br> 4. Tolerance frézování menší než 0,20 mm 
<br> 5. Flexi-rigid DPS  
<br> 6. Celoplošné galvanické zlacení  

");
        }




        private void cb_barva(object sender, EventArgs e)
        {

            if (sender is CheckEdit)
            {
                if (((CheckEdit)sender).Checked)
                {
                    ((CheckEdit)sender).ForeColor = Color.Red;
                }
                else
                {
                    ((CheckEdit)sender).ForeColor = Color.Black;
                }


                if (((CheckEdit)sender).Name == "chbTP")
                {
                    tabPageTechnologickaPoznamka.PageVisible = ((CheckEdit)sender).Checked;
                }

                if (((CheckEdit)sender).Name == "chbSP")
                {
                    tabPageSpecialniPostup.PageVisible = ((CheckEdit)sender).Checked;
                }
            }

            if (sender is RadioButton)
            {
                if (((RadioButton)sender).Checked)
                {
                    ((RadioButton)sender).ForeColor = Color.Red;
                }
                else
                {
                    ((RadioButton)sender).ForeColor = Color.Black;
                }


                if (((RadioButton)sender).Name == "chbTP")
                {
                    tabPageTechnologickaPoznamka.PageVisible = ((RadioButton)sender).Checked;
                }

                if (((RadioButton)sender).Name == "chbSP")
                {
                    tabPageSpecialniPostup.PageVisible = ((RadioButton)sender).Checked;
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // textak, odkaz na sitovy disk, pres notepad
            frmNapoveda.Set("1. čistý rozměr panelu >= 300x200mm plus mezikruzi <= 0.15mm<br> 2. mezikruzi menší 0.125mm <br> 3. karbonová pasta <br> 4 zlacene konektory <br> 5. slepé vrtání <br> 6. požadavek přesného drážkování <br> 7. pokud základní materiál DUROID tl. 0,13 mm");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            frmNapoveda.Set(@"
<br> Jednostrané a oboustranné DPS <br> <br> 
Označení: <b>UL E194267 PCBS</b> <br> 
Základní materiál: <b>DE104, IS400</b> - min. tl. mat. <b>0,46 mm</b>, max. tl. Cu <b>70 µm </b> <br>
Nelze u DPS se zaplňovanými otvory <br> <br>

Vícevrstvé DPS <br> <br> 
Označení: <b>UL E194267 PCBM</b> <br> 
Základní materiál <b>DE104, IS400</b> - max. tl. Cu  vnitřní vrst. <b>105 µm</b> a vnější vrst. <b>70 µm </b><br> <br>
<br>
Nelze u DPS se zaplňovanými otvory <br> <br>

");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set("1.Pokud FLEX-RIGID DPS <br> 2.Pokud základní materiál DUROID tl. 0,13 mm <br> 3. zaplňované otvory <br> 4. skryté vrtání");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set("Snímatelnou masku nanášenou sítotiskem nelze aplikovat přes neprokovené otvory a nelze ji nanášet oboustranně přes jeden otvor.<br> Lze jej aplikovat pouze na DPS s povrchovou upravou HAL.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set("Pokud se na DPS vyskytuje obvod BGA nutno připravit filmy na DIAZZO.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // spusti se zvoleny soubor
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set("Možné užití určuje po dohodě technolog. <br> Provádí se od středu panelu.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set("Možné užití určuje po dohodě technolog. <br> Provádí se od spodní hrany panelu.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmCiselnikVet frm = new frmCiselnikVet();
            if (frm.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (CheckButtonItem v in frm.VybraneVety)
                {
                    txtPozn.EditValue += v.Name + "\r\n";
                }
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set(@"
Celková tloušťka DPS: <br />
 do 1 mm ± 0.10
<br> do 2 mm ± 0.15 
<br> 2,0 - 2,9 mm ± 0.20 
<br> 3,0 - 3,6 mm ± 0.25  ");
        }

        private void btnPripravVrstvy_Click(object sender, EventArgs e)
        {
            produkt p = (produkt)this.entityObject;

            if (string.IsNullOrEmpty(p.kodVypocitany))
            {
                frmNapoveda.Set("Kód DPS musí být vyplněn!");
                return;
            }

            p.plosny_spoj_specifikace.PripravVrstvyDleKodu(p);

            motivCuBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med).ToList();
            motivOdmaskovaniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.odmaskovani).ToList();
            motivZlaceniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.zlaceni).ToList();
        }


        private void button15_Click(object sender, EventArgs e)
        {
            // to do na sit soubor
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            frmNapoveda.Set("Možno u čistého rozměru panelu při technologii <br> MASLAM 260 mm  <br> NEMASLAM 220 mm <br> DPSTHERMALCLAD 280 mm.");
        }

        private void btnNapovedaVicePokoveni_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set("Pozor, při zadávání vrtacích nástrojů - nutno navýšit minimálně o dalších 0,05 mm.");
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            frmNapoveda.Set("Pokud poměr (hloubka / průměr) >= 0,80 je nutno generovat krycí filmy fotorezistu. ");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmNapoveda.Set("Tlouštka 200 u DPS s minimální tlouškou Cu 105µ.");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmNapoveda.Set("Nutno generovat krycí filmy fotorezistu.");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmNapoveda.Set("Pozor, při volbě vrtacích nástrojů vzhledem k požadované povrchové úpravě. ");
        }

        private void btnEditZakaznik_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmZakaznikSeznam seznam = new frmZakaznikSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                ((produkt)this.entityObject).zakaznik_id = ((zakaznik)seznam.entityObject).zakaznik_id;
                ((produkt)this.entityObject).zakaznik = this.DBContext.zakazniks.Where(item => item.zakaznik_id == ((zakaznik)seznam.entityObject).zakaznik_id).First();
                btnEditZakaznik.Text = ((produkt)this.entityObject).zakaznik.interni_nazev;

                // vyplnuje se pouze jednou a to u noveho.
                if (String.IsNullOrEmpty(((produkt)this.entityObject).uloziste))
                {
                    ((produkt)this.entityObject).uloziste = ((produkt)this.entityObject).zakaznik.interni_nazev;
                }
            }
        }

        private void btnUlozit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl1.Focus();
            frmProduktWorkflow workflow = new frmProduktWorkflow();
            if (workflow.ShowForm(this) == DialogResult.OK)
            {
                if (workflow.Stav != 0)
                {
                    ((produkt)this.entityObject).produkt_stav = this.DBContext.produkt_stavs.Where(i => i.produkt_stav_id == workflow.Stav).First();
                }


                if (this.TypAkce == frmProduktDetail.ProduktAkce.kopie)
                {
                    this.Ulozit();
                }
                else if (this.TypAkce == frmProduktDetail.ProduktAkce.zmenaDPS)
                {
                    this.Ulozit(frmProduktDetail.ProduktAkce.zmenaDPS);
                    this.Close();
                }
                else if (this.TypAkce == frmProduktDetail.ProduktAkce.zmenaIV)
                {
                    this.Ulozit(frmProduktDetail.ProduktAkce.zmenaIV);
                }
                else
                {
                    this.Ulozit();
                }

            }

        }

        private void btnZavrit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Storno();
        }

        private void btnPridat_click(object sender, EventArgs e)
        {

        }

        private void btnVrstvaPridat_Click(object sender, EventArgs e)
        {
            ((produkt)this.entityObject).vrstvas.Add(new vrstva());
        }

        private void btnEditKodDPS_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmCiselnikKodDPS frm = new frmCiselnikKodDPS(frmCiselnikKodDPS.Value.produkt);

            frm.entityObject = ((produkt)this.entityObject);
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                string kod = ((produkt)this.entityObject).kodVypocitany;
                btnEditKodDPS.Text = kod;
                ((produkt)this.entityObject).kod = kod;
                AktivnostPolicekDleKodu();
            }
        }

        private void btnVrstvaOdstranit_Click(object sender, EventArgs e)
        {
            if (vrstvaBindingSource.Current != null)
            {
                this.DBContext.DeleteObject((vrstva)vrstvaBindingSource.Current);
            }
        }

        private void btnNovyFilm_Click(object sender, EventArgs e)
        {
            film film = new film();
            film.produkt_id = ((produkt)this.entityObject).produkt_id;
            film.film_typ_id = 1;
            film.vrstva = "";
            film.oznaceni = string.Format("P{0}C{1}B-{2}", DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0'),
                            DateTime.Now.Year.ToString().Substring(2, 2),
                            AppHelper.Uzivatel.Inicialy);

            ((produkt)this.entityObject).films.Add(film);
        }

        private void btnNovyCuMotiv_Click(object sender, EventArgs e)
        {
            motiv motiv = new motiv();
            motiv.produkt_id = ((produkt)this.entityObject).produkt_id;
            motiv.motiv_typ_id = (int)motiv_typ.Value.med;
            ((produkt)this.entityObject).motivs.Add(motiv);
            motivCuBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med).ToList();
        }

        private void btnTechnologickaPoznamkaNova_Click(object sender, EventArgs e)
        {
            frmTechnologickaPoznamkaDetail frm = new frmTechnologickaPoznamkaDetail();
            frm.parentEntityObject = this.entityObject;
            frm.ShowDetailNovy(this);
        }

        private void btnTechnologickaPoznamkaSmazat_Click(object sender, EventArgs e)
        {
            if (produktpoznamkaBindingSource.Current != null)
            {
                //((produkt)this.entityObject).produkt_poznamkas.Remove((produkt_poznamka)produktpoznamkaBindingSource.Current);
                this.DBContext.DeleteObject((produkt_poznamka)produktpoznamkaBindingSource.Current);
            }
        }

        private void gridControlTechnologickaPoznamka_DoubleClick(object sender, EventArgs e)
        {
            if (produktpoznamkaBindingSource.Current != null)
            {
                frmTechnologickaPoznamkaDetail frm = new frmTechnologickaPoznamkaDetail();
                frm.parentEntityObject = this.entityObject;
                frm.ShowDetail(this, (produkt_poznamka)produktpoznamkaBindingSource.Current);
            }
        }

        private void btnOpNovy_Click(object sender, EventArgs e)
        {
            frmSpecialniPostupDetail frm = new frmSpecialniPostupDetail();
            frm.parentEntityObject = this.entityObject;
            frm.ShowDetailNovy(this);
            refreshSpecialniPostup();
        }

        private void gridControlOperace_DoubleClick(object sender, EventArgs e)
        {
            if (specialnipostupBindingSource.Current != null)
            {
                frmSpecialniPostupDetail frm = new frmSpecialniPostupDetail();
                frm.parentEntityObject = this.entityObject;
                frm.ShowDetail(this, (specialni_postup)specialnipostupBindingSource.Current);
            }
        }

        private void btnOpOdstr_Click(object sender, EventArgs e)
        {
            if (specialnipostupBindingSource.Current != null)
            {
                ((specialni_postup)specialnipostupBindingSource.Current).aktivni = false;
                refreshSpecialniPostup();
            }
        }

        private void btnNovyZak_Click(object sender, EventArgs e)
        {
            frmZakaznikSeznam zakaznik = new frmZakaznikSeznam();
            zakaznik.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (zakaznik.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                mozni_objednavatele mo = new mozni_objednavatele();
                mo.produkt_id = ((produkt)this.entityObject).produkt_id;
                mo.zakaznik_id = ((zakaznik)zakaznik.entityObject).zakaznik_id;
                ((produkt)this.entityObject).mozni_objednavateles.Add(mo);
            }
        }

        private void btnOdstrMozniObjednavatele_Click(object sender, EventArgs e)
        {
            if (mozniObjedBindingSource.Current != null)
            {
                //((produkt)this.entityObject).mozni_objednavateles.Remove((mozni_objednavatele)mozniObjedBindingSource.Current);
                this.DBContext.DeleteObject((mozni_objednavatele)mozniObjedBindingSource.Current);
            }
        }

        private void btnNovySlepVrt_Click(object sender, EventArgs e)
        {
            skryte_vrtani sv = new skryte_vrtani();
            sv.produkt = (produkt)this.entityObject;
            ((produkt)this.entityObject).skryte_vrtanis.Add(sv);
        }

        private void btnOdstrSlepVrt_Click(object sender, EventArgs e)
        {
            if (skrytevrtaniBindingSource.Current != null)
            {
                ((produkt)this.entityObject).skryte_vrtanis.Remove((skryte_vrtani)skrytevrtaniBindingSource.Current);
                //this.DBContext.DeleteObject((skryte_vrtani)skrytevrtaniBindingSource.Current);
            }
        }

        private void btnZmenaNovy_Click(object sender, EventArgs e)
        {
            zmena z = new zmena();
            z.rok = PCB.Data.DBHelper.DateTimeNow().Year;
            z.cislo = 1;
            z.d_zmena = PCB.Data.DBHelper.DateTimeNow();
            z.uzivatel_id = this.PrihlasenyUzivatelId;

            z.produkt = (produkt)this.entityObject;
            ((produkt)this.entityObject).zmenas.Add(z);
        }

        private void btnOdstranitZmenyDPS_Click(object sender, EventArgs e)
        {
            if (zmenaBindingSource.Current != null)
            {
                //((produkt)this.entityObject).zmenas.Remove((zmena)zmenaBindingSource.Current);
                this.DBContext.DeleteObject((zmena)zmenaBindingSource.Current);
            }
        }

        private void btnPrenestZKodu_Click(object sender, EventArgs e)
        {
            int i = 0;
            ((produkt)this.entityObject).LoadSeznamOperaci(this.DBContext, true);

            if (((produkt)this.entityObject).SeznamOperaci == null) return;

            foreach (operace op in ((produkt)this.entityObject).SeznamOperaci.OrderBy(o => o.poradi))
            {
                i++;
                specialni_postup sp = new specialni_postup();
                sp.operace_id = op.operace_id;
                sp.poradi = i;
                sp.produkt_id = ((produkt)this.entityObject).produkt_id;
                sp.d_zapsal = PCB.Data.DBHelper.DateTimeNow();
                sp.zapsal_uzivatel_id = this.PrihlasenyUzivatelId;
                sp.aktivni = true;
                ((produkt)this.entityObject).specialni_postups.Add(sp);
            }
            refreshSpecialniPostup();
        }

        private void btnOdstranitFilm_Click(object sender, EventArgs e)
        {
            if (filmyBindingSource.Current != null && this.FormMode == mode.editace)
            {
                this.DBContext.DeleteObject((film)filmyBindingSource.Current);
            }

            if (filmyBindingSource.Current != null && this.FormMode == mode.novy)
            {
                ((produkt)this.entityObject).films.Remove((film)filmyBindingSource.Current);
            }
        }

        private void btnCuMotivOdstr_Click(object sender, EventArgs e)
        {
            if (motivCuBindingSource.Current != null && this.FormMode == mode.editace)
            {
                this.DBContext.DeleteObject((motiv)motivCuBindingSource.Current);
            }

            if (motivCuBindingSource.Current != null && this.FormMode == mode.novy)
            {
                ((produkt)this.entityObject).motivs.Remove((motiv)motivCuBindingSource.Current);
            }

            motivCuBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med).ToList();

        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            tabControl1.Focus();


            // pokud jde normlane rovnou z menu (neni odkaz - nahled)
            if (this.ParentFormBase is frmBaseSeznam)
            {
                frmKontrola frm = new frmKontrola();
                if (frm.ShowDetail(this, this.entityObject) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                frmProduktWorkflow workflow = new frmProduktWorkflow();
                workflow.entityObject = this.entityObject;
                if (workflow.ShowForm(this) == DialogResult.OK)
                {
                    if (workflow.Stav != 0)
                    {
                        ((produkt)this.entityObject).produkt_stav = this.DBContext.produkt_stavs.Where(i => i.produkt_stav_id == workflow.Stav).First();
                    }



                    //((produkt)this.entityObject).zakaznik == ((produkt)this.entityObject).nazev



                    if (this.TypAkce == frmProduktDetail.ProduktAkce.kopie)
                    {
                        this.Ulozit();
                    }
                    else if (this.TypAkce == frmProduktDetail.ProduktAkce.zmenaDPS)
                    {
                        this.Ulozit(frmProduktDetail.ProduktAkce.zmenaDPS);
                        this.Close();
                    }
                    else if (this.TypAkce == frmProduktDetail.ProduktAkce.zmenaIV)
                    {
                        this.Ulozit(frmProduktDetail.ProduktAkce.zmenaIV);
                    }
                    else
                    {
                        this.Ulozit();
                    }
                }
            }

        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Storno();
        }

        private void btnEditMaterial_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            frmMaterialSeznam frm = new frmMaterialSeznam();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((vrstva)vrstvaBindingSource.Current).material_id = ((material)frm.entityObject).material_id;
                gridView1.FocusedRowHandle = -1;
            }
        }

        private void btnEditCuVrstva_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            frmCiselnikCu frm = new frmCiselnikCu();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((vrstva)vrstvaBindingSource.Current).vrstva_cu_id = ((vrstva_cu)frm.entityObject).vrstva_cu_id;
                gridView1.FocusedRowHandle = -1;
            }
        }

        private void btnVrstvaOdstranitVse_Click(object sender, EventArgs e)
        {
            foreach (vrstva item in ((produkt)this.entityObject).vrstvas.ToList())
            {
                this.DBContext.DeleteObject(item);
            }

        }

        private void btnOpOdstrVse_Click(object sender, EventArgs e)
        {
            foreach (specialni_postup item in ((produkt)this.entityObject).specialni_postups.ToList())
            {
                item.aktivni = false;
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            /* GridView View = sender as GridView;
             if (e.RowHandle >= 0)
             {
                 DataRow row = View.(e.RowHandle);
                 if (row!=null && row["material"].ToString() != "aaaa")
                 {
                     e.Appearance.BackColor = Color.Salmon;
                     e.Appearance.BackColor2 = Color.SeaShell;
                 }
             }*/
        }



        private void btnTechnologickyPostup_Click(object sender, EventArgs e)
        {
            ((produkt)this.entityObject).LoadSeznamOperaci();
            bindingSourceTechnologickyPostup.DataSource = ((produkt)this.entityObject).SeznamOperaci;
        }

        private void btnVrstvaNahoru_Click(object sender, EventArgs e)
        {
            vrstva vr = (vrstva)vrstvaBindingSource.Current;
            vrstva vr1 = ((IEnumerable<vrstva>)vrstvaBindingSource.DataSource).Where(i => i.poradi == (vr.poradi - 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {

                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                vrstvaBindingSource.Position = vrstvaBindingSource.IndexOf(vr);
                gcVrstvy.Refresh();
            }

        }

        private void btnVrstvaDolu_Click(object sender, EventArgs e)
        {
            vrstva vr = (vrstva)vrstvaBindingSource.Current;
            vrstva vr1 = ((IEnumerable<vrstva>)vrstvaBindingSource.DataSource).Where(i => i.poradi == (vr.poradi + 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {
                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                vrstvaBindingSource.Position = vrstvaBindingSource.IndexOf(vr);
                gcVrstvy.Refresh();
            }

        }

        private void btnSpecialniPostupNahoru_Click(object sender, EventArgs e)
        {
            specialni_postup vr = (specialni_postup)specialnipostupBindingSource.Current;
            specialni_postup vr1 = ((IEnumerable<specialni_postup>)specialnipostupBindingSource.DataSource).Where(i => i.aktivni == true && i.poradi == (vr.poradi - 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {
                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                specialnipostupBindingSource.Position = specialnipostupBindingSource.IndexOf(vr);
                refreshSpecialniPostup();
            }
        }

        private void btnSpecialniPostupDolu_Click(object sender, EventArgs e)
        {

            specialni_postup vr = (specialni_postup)specialnipostupBindingSource.Current;
            specialni_postup vr1 = ((IEnumerable<specialni_postup>)specialnipostupBindingSource.DataSource).Where(i => i.aktivni == true && i.poradi == (vr.poradi + 1)).FirstOrDefault();

            if ((vr1 != null) && (vr != null))
            {

                int puvodniPoradi = vr.poradi;
                int novePoradi = vr1.poradi;

                vr.poradi = novePoradi;
                vr1.poradi = puvodniPoradi;

                specialnipostupBindingSource.Position = specialnipostupBindingSource.IndexOf(vr);
                refreshSpecialniPostup();
            }


        }

        private void btnTechPoznamkaPridat_Click(object sender, EventArgs e)
        {
            frmTechnologickaPoznamkaDetail detail = new frmTechnologickaPoznamkaDetail();
            detail.parentEntityObject = this.entityObject;
            detail.FormMode = mode.novy;
            detail.ShowDetailNovy(this);

            refreshProduktPoznamka();

        }

        private void refreshProduktPoznamka()
        {
            produktpoznamkaBindingSource.DataSource = ((produkt)this.entityObject).produkt_poznamkas.Where(i => !cbAktivni.Checked ? true : (i.aktivni ?? false) == cbAktivni.Checked);
        }

        private void btnTechnologicePoznamkaDetail_Click(object sender, EventArgs e)
        {
            if ((produkt_poznamka)produktpoznamkaBindingSource.Current != null)
            {
                frmTechnologickaPoznamkaDetail detail = new frmTechnologickaPoznamkaDetail();
                detail.parentEntityObject = this.entityObject;
                detail.ShowDetail(this, (produkt_poznamka)produktpoznamkaBindingSource.Current);
            }
        }

        private void btnTechnologickaPoznamkaOdstranit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((produkt_poznamka)produktpoznamkaBindingSource.Current != null)
                {
                    ((produkt_poznamka)produktpoznamkaBindingSource.Current).aktivni = false;
                    this.refreshProduktPoznamka();
                }
            } catch(Exception exp) { }
        }

        private void btnTechnologickaPoznamkaOdstranitVse_Click(object sender, EventArgs e)
        {
            foreach (produkt_poznamka item in ((produkt)this.entityObject).produkt_poznamkas.ToList())
            {
                this.DBContext.DeleteObject(item);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (((produkt)this.entityObject).zakaznik != null)
            {
                frmNapoveda.Set(((produkt)this.entityObject).zakaznik.GetPoznamkyTPV());
            }
        }


        private void btnNapovedaKT_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Konstrukční třídy\Tabulka 2.bmp");
        }

        private void btnNapovedaNT_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Definice zakázek v režimu NT - nestandardní technologie\Podmínky pro zadávání DPS v režimu NT.doc");
        }

        private void btnNapovedaSP_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Definice zakázek v režimu SP - speciální postup\Podmínky pro zadávání DPS v režimu SP.doc");
        }

        private void btnNapovedaParametryNavrhu_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Paramerty návrhu vzhledem k požadované tl. Cu\Tabulka 1.bmp");
        }

        private void btnNapovedaInspekta_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Definice rozměrů DPS k použití na Inspecta\Podmínky pro zadávání DPS na INSPECTA.doc");
        }

        private void btnNapovedaOlec_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Definice DPS k použití na Olec\Podmínky pro zadávání DPS na OLEC.doc");
        }

        private void btnNapovedaUL_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Podmínky pro zadávání DPS s označením UL normy\Podmínky pro zadávání DPS s označením UL normy.doc");
        }

        private void btnNapovedaPaketVrtani_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Paketování vrtání\Zásady pro nastavení paketu při vrtání.doc");
        }

        private void btnNapovedaFrezovaniPaket_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Paketování frézování\Zásady pro nastavení paketu při frézování.doc");
        }

        private void btnNapovedaFrezovaniFa(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Fazetování konektorů\Fazetování konektorů.doc");
        }

        private void btnPoradiKodu_Click(object sender, EventArgs e)
        {
            frmKodPoradi frm = new frmKodPoradi();
            frm.entityObject = this.entityObject;
            frm.ShowDialog();
        }

        private void btnPoradiDesek_Click(object sender, EventArgs e)
        {
            frmKodPoradi frmKod = new frmKodPoradi();
            frmKod.entityObject = this.entityObject;
            if (frmKod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ((produkt)this.entityObject).kod = ((produkt)this.entityObject).kodVypocitany;

                btnEditKodDPS.Text = ((produkt)this.entityObject).kod;
            }
        }

        private void btnKontrola_Click(object sender, EventArgs e)
        {

            if (((produkt)this.entityObject).kod == "")
            {
                MessageBox.Show("Nemáte vyplněný kód.");

            }
            else
            {
                frmKontrola frm = new frmKontrola();
                frm.ShowDetail(this, this.entityObject);
            }

        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;

                string strana = (string)View.GetRowCellValue(e.RowHandle, View.Columns["strana"]);
                if (strana != null && strana != "" && strana.Length > 0)
                {
                    e.Appearance.BackColor = Color.LightGray;
                }

            }
        }

        private void btnDoplnitTlousku_Click(object sender, EventArgs e)
        {
            decimal tlouska = 0;
            foreach (vrstva v in ((produkt)this.entityObject).vrstvas)
            {
                tlouska += (v.tloustka_mm ?? 0) * v.pocet;
            }

            ((produkt)this.entityObject).celkova_tloustka = tlouska;
        }

        private void btnRevizeNovy_Click(object sender, EventArgs e)
        {

            produkt_revize pr = new produkt_revize();
            pr.revize = ((produkt)this.entityObject).produkt_revizes.Sum(i => i.revize) > 0 ?
                        ((produkt)this.entityObject).produkt_revizes.Max(i => i.revize) + 1 :
                        1;
            pr.d_zapsano = PCB.Data.DBHelper.DateTimeNow();
            pr.poznamka = "";
            pr.uzivatel_id = this.PrihlasenyUzivatelId;

            ((produkt)this.entityObject).produkt_revizes.Add(pr);
        }

        private void btnRevizeOdstranit_Click(object sender, EventArgs e)
        {
            if ((produkt_revize)produktrevizeBindingSource.Current != null)
            {
                this.DBContext.DeleteObject((produkt_revize)produktrevizeBindingSource.Current);
            }
        }

        private void dateEditNewPrintB_EditValueChanging(object sender, ChangingEventArgs e)
        {
            ((produkt)this.entityObject).newprint_uzivatel_strana_b_id = this.PrihlasenyUzivatelId;
        }

        private void dateEditNewPrintA_EditValueChanging(object sender, ChangingEventArgs e)
        {
            ((produkt)this.entityObject).newprint_uzivatel_strana_a_id = this.PrihlasenyUzivatelId;
        }

        private void dateEditAOI_EditValueChanging(object sender, ChangingEventArgs e)
        {
            ((produkt)this.entityObject).aoi_zapsal_id = this.PrihlasenyUzivatelId;
        }

        private void dateEditET_EditValueChanging(object sender, ChangingEventArgs e)
        {
            ((produkt)this.entityObject).zapsal_et_id = this.PrihlasenyUzivatelId;
        }

        private void txtTolerHorni_EditValueChanged(object sender, EventArgs e)
        {
            decimal number;

            if (decimal.TryParse(this.txtTolerHorni.Text, out number))
            {
                this.txtTolerHorni.EditValue = number;
                ((produkt)this.entityObject).tolerance_dolni = number;
            }
            else
            {
                this.txtTolerHorni.EditValue = null;
                ((produkt)this.entityObject).tolerance_dolni = null;
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmMaterialSeznam frm = new frmMaterialSeznam();
            frm.ShowDialog();
        }

        private void btnSkladMaterialuOdkaz_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"x:\SpolecnaData\Info\Skladové_zásoby_PCB10.pdf", true);
        }

        private void btnZlaceni_Click(object sender, EventArgs e)
        {
            motiv motiv = new motiv();
            motiv.produkt = (produkt)this.entityObject;
            motiv.motiv_typ_id = (int)motiv_typ.Value.zlaceni;
            ((produkt)this.entityObject).motivs.Add(motiv);

            motivZlaceniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.zlaceni).ToList();
        }

        private void btnOdmaskovaniNovy_Click(object sender, EventArgs e)
        {
            motiv motiv = new motiv();
            motiv.produkt = (produkt)this.entityObject;
            motiv.motiv_typ_id = (int)motiv_typ.Value.odmaskovani;
            ((produkt)this.entityObject).motivs.Add(motiv);
            motivOdmaskovaniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.odmaskovani).ToList();
        }

        private void btnGalvanickeZlaceniOdstranit_Click(object sender, EventArgs e)
        {
            if (motivZlaceniBindingSource.Current != null && this.FormMode == mode.editace)
            {
                this.DBContext.DeleteObject((motiv)motivZlaceniBindingSource.Current);
            }

            if (motivZlaceniBindingSource.Current != null && this.FormMode == mode.novy)
            {
                ((produkt)this.entityObject).motivs.Remove((motiv)motivZlaceniBindingSource.Current);
            }

            motivZlaceniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.zlaceni).ToList();
        }

        private void btnOdmaskovaniOdstranit_Click(object sender, EventArgs e)
        {
            if (motivOdmaskovaniBindingSource.Current != null && this.FormMode == mode.editace)
            {
                this.DBContext.DeleteObject((motiv)motivOdmaskovaniBindingSource.Current);
            }

            if (motivOdmaskovaniBindingSource.Current != null && this.FormMode == mode.novy)
            {
                ((produkt)this.entityObject).motivs.Remove((motiv)motivOdmaskovaniBindingSource.Current);
            }

            motivOdmaskovaniBindingSource.DataSource = ((produkt)this.entityObject).motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.odmaskovani).ToList();


        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            frmNapoveda.Set(@"Nutno generovat krycí filmy fotorezistu + pokud DPS s flexibilní maskou, nutno frézovat výřez v masce pro kontaktování rámečku.");
        }


        private void btnNapovedaZapln_Click(object sender, EventArgs e)
        {
            AppHelper.ZobrazSoubor(@"Zaplňované otvory\Zaplňované otvory.doc");
        }

        private void chbLaminace_CheckedChanged(object sender, EventArgs e)
        {
            vychoziCheckboxy();
        }

        private void chbNarKonektory_CheckedChanged(object sender, EventArgs e)
        {
            vychoziCheckboxy();
        }

        private void chbAOI_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                ((produkt)entityObject).aoi_zapsal_id = this.PrihlasenyUzivatelId;
                ((produkt)entityObject).aoi_datum = PCB.Data.DBHelper.DateTimeNow();

            }
            else
            {
                ((produkt)entityObject).uzivatel_aoi_zapsal_id = null;
                ((produkt)entityObject).aoi_datum = null;
            }

            dateEditAOI.Update();
            cbAOICombo.Update();
        }

        private void chbET_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                ((produkt)entityObject).zapsal_et_id = this.PrihlasenyUzivatelId;
                ((produkt)entityObject).et_datum = PCB.Data.DBHelper.DateTimeNow();
            }
            else
            {
                ((produkt)entityObject).uzivatel_zapsal_et_id = null;
                ((produkt)entityObject).et_datum = null;
            }

            dateEditET.Update();
            cbETCombo.Update();
        }

        private void cbSPAktivni_CheckedChanged(object sender, EventArgs e)
        {
            refreshSpecialniPostup();

        }

        private void refreshSpecialniPostup()
        {
            specialnipostupBindingSource.DataSource = ((produkt)this.entityObject).specialni_postups.Where(i => !cbSPAktivni.Checked ? true : (i.aktivni ?? false) == cbSPAktivni.Checked);
        }

        private void cbAktivni_CheckedChanged(object sender, EventArgs e)
        {
            refreshProduktPoznamka();
        }

        private void btnPrevzitZJineDesky_Click(object sender, EventArgs e)
        {
            frmProduktSeznam seznam = new frmProduktSeznam();
            seznam.SeznamMode = frmBaseSeznam.modeCiselnik.vyberCiselnik;
            if (seznam.ShowForm(this) == System.Windows.Forms.DialogResult.OK)
            {
                produkt p = ((produkt)seznam.entityObject);
                if (p == null)
                    return;

                if (p.specialni_postup ?? false)
                {
                    foreach (specialni_postup sp in p.specialni_postups)
                    {
                        specialni_postup newsp = new specialni_postup();
                        newsp.operace_id = sp.operace_id;
                        newsp.poradi = sp.poradi;
                        newsp.technologicka_poznamka = sp.technologicka_poznamka;
                        newsp.zapsal_uzivatel_id = this.PrihlasenyUzivatelId;

                        ((produkt)this.entityObject).specialni_postups.Add(newsp);
                    }
                }
                else
                {
                    int i = 0;
                    p.LoadSeznamOperaci(this.DBContext, true);

                    if (p.SeznamOperaci == null) return;

                    foreach (operace op in p.SeznamOperaci.OrderBy(o => o.poradi))
                    {
                        var poznamka = ((produkt)this.entityObject).produkt_poznamkas.Where(w => w.operace_id == op.operace_id && (w.aktivni ?? true)).FirstOrDefault();
                        
                        i++;
                        specialni_postup sp = new specialni_postup();
                        sp.operace_id = op.operace_id;
                        sp.poradi = i;
                        if (poznamka != null)
                        {
                            sp.technologicka_poznamka = poznamka.poznamka;
                        }
                        sp.produkt_id = ((produkt)this.entityObject).produkt_id;
                        sp.d_zapsal = PCB.Data.DBHelper.DateTimeNow();
                        sp.zapsal_uzivatel_id = this.PrihlasenyUzivatelId;
                        sp.aktivni = true;
                        ((produkt)this.entityObject).specialni_postups.Add(sp);
                    }
                }
                refreshSpecialniPostup();
            }
        }



        private void btnHromadne_Click(object sender, EventArgs e)
        {
            frmOperaceVyber frm = new frmOperaceVyber();
            if (frm.ShowDetailNovy(this) == System.Windows.Forms.DialogResult.OK)
            {
                int i = 0;
                foreach (operace o in frm.Vybrano)
                {
                    i++;
                    specialni_postup sp = new specialni_postup();
                    sp.operace_id = o.operace_id;
                    sp.zapsal_uzivatel_id = this.PrihlasenyUzivatelId;
                    sp.d_zapsal = DBHelper.DateTimeNow();
                    sp.aktivni = true;
                    sp.technologicka_poznamka = o.Poznamka;
                    sp.poradi = ((produkt)this.entityObject).specialni_postups.Count > 0 ? ((produkt)this.entityObject).specialni_postups.Max(item => item.poradi) + 1 : 1;


                    ((produkt)this.entityObject).specialni_postups.Add(sp);
                }

                refreshSpecialniPostup();
            }
        }
     
        private void number_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
           // this.base_number_ParseEditValue(sender, e);
        }

        private void int_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
           // this.base_int_ParseEditValue(sender, e);
        }
      
        private void gridControlOperace_DoubleClick_1(object sender, EventArgs e)
        {
            if (!((produkt)this.entityObject).zamek ?? false)
            {
                if (!this.HasPravoZapis(prava.Value.TechnologieTechnickaDokumentace, prava.Value.TPVTechnickaDokumentace))
                {
                    return;
                }

                frmSpecialniPostupPoznamka frm = new frmSpecialniPostupPoznamka();
                if (specialnipostupBindingSource.Current != null)
                {
                    specialni_postup vybrany = (specialni_postup)specialnipostupBindingSource.Current;

                    specialni_postup sp = new specialni_postup();
                    sp.poradi = vybrany.poradi;
                    sp.operace_id = vybrany.operace_id;
                    sp.technologicka_poznamka = vybrany.technologicka_poznamka;
                    sp.zapsal_uzivatel_id = this.PrihlasenyUzivatelId;
                    sp.d_zapsal = DBHelper.DateTimeNow();
                    sp.aktivni = true;

                    frm.entityObject = sp;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        vybrany.aktivni = false;
                        ((produkt)this.entityObject).specialni_postups.Add(sp);
                        refreshSpecialniPostup();
                    }
                }
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',', '.' };
            string text_Total = txtTotal.Text;
            string text_TotalHrPan = txtTotalHrPan.Text;
            string[] strTotal = text_Total.Split(delimiterChars);
            string[] strTotalHrPan = text_TotalHrPan.Split(delimiterChars);

            txtTotal.Text = strTotal[0];
            txtTotalHrPan.Text = strTotalHrPan[0];
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnLaminaceHelp_Click(object sender, EventArgs e)
        {
            frmNapoveda.Set(@"Při stisku ENTER se vytvoří další operace v průvodce.");
        }

        private void txtRozToler_EditValueChanged(object sender, EventArgs e)
        {
            decimal number;

            if (decimal.TryParse(this.txtRozToler.Text, out number))
            {
                this.txtRozToler.EditValue = number;
                ((produkt)this.entityObject).tolerance_cististeho_rozmeru_dolni = number;
            }
            else
            {
                this.txtRozToler.EditValue = null;
                ((produkt)this.entityObject).tolerance_cististeho_rozmeru_dolni = null;
            }
        }

        private void txtMinVrtak_EditValueChanged(object sender, EventArgs e)
        {
            decimal number;

            if (decimal.TryParse(this.txtMinVrtak.Text, out number))
            {
                this.txtMinVrtak.EditValue = number;
                ((produkt)this.entityObject).zapln_min_vrtak = number;
            }
            else
            {
                this.txtMinVrtak.EditValue = null;
                ((produkt)this.entityObject).zapln_min_vrtak = null;
            }
        }

        private void gridControlTechnologickyPostup_Click(object sender, EventArgs e)
        {

        }

        private void txtVrtakMin_EditValueChanged(object sender, EventArgs e)
        {
            decimal number;

            if (decimal.TryParse(this.txtVrtakMin.Text, out number))
            {
                this.txtVrtakMin.EditValue = number;
                ((produkt)this.entityObject).min_vrtak_vrtani = number;
            }
            else
            {
                this.txtVrtakMin.EditValue = null;
                ((produkt)this.entityObject).min_vrtak_vrtani = null;
            }
        }
    }
}
