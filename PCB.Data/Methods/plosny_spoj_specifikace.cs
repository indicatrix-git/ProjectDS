using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class plosny_spoj_specifikace
    {
        EntityObject data;

        public void PripravVrstvyDleKodu(EntityObject data)
        {
            this.data = data;

            // nemaslam

            if (this.kod == "4B")
            {
                this.pridatVrstvu(1, 2, 80, 0.61m, "CZ", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.61m, "AB", 3);
            }

            if (this.kod == "6B")
            {
                this.pridatVrstvu(1, 2, 80, 0.2m, "EZ", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.2m, "CD", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(2, 2, 80, 0.2m, "AB", 5);
            }

            if (this.kod == "8B")
            {
                this.pridatVrstvu(1, 2, 80, 0.2m, "GZ", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.2m, "EF", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(1, 2, 80, 0.2m, "CD", 5);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(2, 2, 80, 0.2m, "AB", 7);
            }

            if (this.kod == "10B")
            {
                this.pridatVrstvu(1, 2, 80, 0.2m, "IZ", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.2m, "GH", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(1, 2, 80, 0.2m, "EF", 5);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(1, 2, 80, 0.2m, "CD", 7);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 8);
                this.pridatVrstvu(2, 2, 80, 0.2m, "AB", 9);
            }

            if (this.kod == "12B")
            {
                this.pridatVrstvu(1, 2, 80, 0.2m, "KZ", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.2m, "ÏJ", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(1, 2, 80, 0.2m, "GH", 5);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(1, 2, 80, 0.2m, "EF", 7);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 8);
                this.pridatVrstvu(1, 2, 80, 0.2m, "CD", 9);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 10);
                this.pridatVrstvu(2, 2, 80, 0.2m, "AB", 11);
            }

            if (this.kod =="J." || this.kod == "J0")
            {
                this.pridatVrstvu(1, 1, 3, 1.50m, "A", 1);
            }

            if (this.kod == "J1") 
            {
                this.pridatVrstvu(1, 27, 4, 1.50m, "B", 1);
            }

            if (this.kod == "J2")
            {
                this.pridatVrstvu(1, 59, null, 1.50m, "", 1);
                this.pridatVrstvu(1, 60, null, 0.050m, "", 2);
                this.pridatVrstvu(1, 5, 170, null, "A", 3);
            }

            if (this.kod =="O.")
            {
                this.pridatVrstvu(1, 1, 70, 1.50m, "AB", 1);
            }

            if (this.kod == "N.")
            {
                this.pridatVrstvu(1, 1, 80, 1.50m, "AB", 1);
            }

            if (this.kod == "4A")
            {
                // maslam 4vrstva
                this.pridatVrstvu(1, 5, 160, null, "Z", 1);
                this.pridatVrstvu(1, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 35, null, 0.18m, null, 3);
                this.pridatVrstvu(1, 2, 80, 0.90m, "BC", 4);
                this.pridatVrstvu(1, 35, null, 0.18m, null, 5);
                this.pridatVrstvu(1, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(1, 5, 160, null, "A", 7);
            }

            if (this.kod == "6A")
            {

                // maslam 6vrstva
                this.pridatVrstvu(1, 5, 160, null, "Z", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.41m, "DE", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(1, 2, 80, 0.41m, "BC", 5);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(1, 5, 160, null, "A", 7);
            }

            if (this.kod == "8A")
            {
                // maslam 8vrstva
                this.pridatVrstvu(1, 5, 160, null, "Z", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.20m, "FG", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(1, 2, 80, 0.20m, "DE", 5);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(1, 2, 80, 0.20m, "BC", 7);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 8);
                this.pridatVrstvu(1, 5, 160, null, "A", 9);
            }

            if (this.kod == "10A")
            {
                // maslam 10vrstva
                this.pridatVrstvu(1, 5, 160, null, "Z", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.20m, "HI", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(1, 2, 80, 0.20m, "FG", 5);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(1, 2, 80, 0.20m, "DE", 7);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 8);
                this.pridatVrstvu(1, 2, 80, 0.20m, "BC", 9);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 10);
                this.pridatVrstvu(1, 5, 160, null, "A", 11);
            }

            if (this.kod == "12A")
            {
                // maslam 12vrstva
                this.pridatVrstvu(1, 5, 160, null, "Z", 1);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 2);
                this.pridatVrstvu(1, 2, 80, 0.20m, "JK", 3);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 4);
                this.pridatVrstvu(1, 2, 80, 0.20m, "HI", 5);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 6);
                this.pridatVrstvu(1, 2, 80, 0.20m, "FG", 7);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 8);
                this.pridatVrstvu(1, 2, 80, 0.20m, "DE", 9);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 10);
                this.pridatVrstvu(1, 2, 80, 0.20m, "BC", 11);
                this.pridatVrstvu(2, 33, null, 0.10m, null, 12);
                this.pridatVrstvu(1, 5, 160, null, "A", 13);
            }

            if (this.kod == "S.")
            {
                this.pridatVrstvu(1, 16, null, null, "A", 1);
            }

            if (this.kod == "SN")
            {
                this.pridatVrstvu(1, 14, null, null, "A", 1);
            }

            if (data is produkt && this.kod != "SN" && this.kod != "S.")
            {
                motivyCu();
                motivyOdmaskovani();
                motivyZlato();
            }
        }

        public void motivyCu()
        {
            List<string> medA = new List<string>() { "E2", "O.", "4A", "6A", "8A", "10A", "12A", "4B", "6B", "8B", "10B", "12B", "W2", "W4", "W6" };
            List<string> medB = new List<string>() { "E2", "O.", "W2" };
            List<string> medZ = new List<string>() { "4A", "6A", "8A", "10A", "12A", "4B", "6B", "8B", "10B", "12B", "W4", "W6" };

            motiv med = new motiv();
            med.motiv_typ_id = (int)motiv_typ.Value.med;
            med.vrstva = medA.Contains(this.kod) ? "A" : "";
            med.vrstva1 = medB.Contains(this.kod) ? "B" : "";

            if (medZ.Contains(this.kod))
            {
                med.vrstva1 = "Z";
            }

            if (medA.Contains(this.kod) || medB.Contains(this.kod) || medZ.Contains(this.kod))
            {
                ((produkt)data).motivs.Add(med);
            }
        }

        public void motivyZlato()
        {
            List<string> medA = new List<string>() { "E1", "E2", "J.", "J0", "O.", "N.", "4A", "6A", "8A", "10A", "12A", "4B", "6B", "8B", "10B", "12B", "W1", "W2", "W4", "W6" };
            List<string> medB = new List<string>() { "E2", "O.", "N.", "W2" };
            List<string> medZ = new List<string>() { "4A", "6A", "8A", "10A", "12A", "4B", "6B", "8B", "10B", "12B", "W4", "W6" };

            motiv med = new motiv();
            med.motiv_typ_id = (int)motiv_typ.Value.zlaceni;
            med.vrstva = medA.Contains(this.kod) ? "A" : "";
            med.vrstva1 = medB.Contains(this.kod) ? "B" : "";

            if (medZ.Contains(this.kod))
            {
                med.vrstva1 = "Z";
            }

            if ((medA.Contains(this.kod) || medB.Contains(this.kod) || medZ.Contains(this.kod)) && (((produkt)data).kod.Contains("Z")))
            {
                ((produkt)data).motivs.Add(med);
            }
        }

        public void motivyOdmaskovani()
        {
            List<string> medA = new List<string>() { "E1", "J.", "J0", "E2", "O.", "4A", "6A", "8A", "10A", "12A", "4B", "6B", "8B", "10B", "12B", "W2", "W4", "W6" };
            List<string> medB = new List<string>() { "E2", "O.", "N.", "W2" };
            List<string> medZ = new List<string>() { "4A", "6A", "8A", "10A", "12A", "4B", "6B", "8B", "10B", "12B", "W4", "W6" };

            motiv med = new motiv();
            med.motiv_typ_id = (int)motiv_typ.Value.odmaskovani;
            med.vrstva = (medA.Contains(this.kod) && (((produkt)data).kod.Contains("MA") || ((produkt)data).kod.Contains("MX"))) ? "RA" : "";
            med.vrstva1 = (medB.Contains(this.kod) && (((produkt)data).kod.Contains("MB") || ((produkt)data).kod.Contains("MX"))) ? "RB" : "";

            if (medZ.Contains(this.kod) && ((produkt)data).kod.Contains("MX"))
            {
                med.vrstva1 = "RZ";
            }

            if ((((produkt)data).kod.Contains("MB") || ((produkt)data).kod.Contains("MX") || ((produkt)data).kod.Contains("MA")))
            {
                ((produkt)data).motivs.Add(med);
            }
        }

        public void pridatVrstvu(int pocetDesek, int material, int? cu, decimal? tlouska, string strana, int poradi)
        {
            vrstva item = new vrstva();
            item.pocet = pocetDesek;
            item.material_id = material;
            item.vrstva_cu_id = cu;
            item.tloustka_mm = tlouska;
            item.strana = strana;

            item.poradi = poradi;

            if (this.data is produkt)
            {
                item.produkt = (produkt)data;
                ((produkt)data).vrstvas.Add(item);
            }
            else
            {
                item.nabidka_polozka = (nabidka_polozka)data;
                ((nabidka_polozka)data).vrstvas.Add(item);
            }

        }
    }
}
