using pcb_develModel;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace pcb_develModel
{
    public partial class produkt
    {
        private string ColorMask(int id)
        {
            switch (id)
            {
                case 1:
                    return "Zelená - clona (MASS)";
                    break;
                case 2:
                    return "Bílá";
                    break;
                case 3:
                    return "Černá";
                    break;
                case 4:
                    return "Červená";
                    break;
                case 5:
                    return "Modrá";
                    break;
                case 6:
                    return "Zelená";
                    break;
                default:
                    return "Duha";
                    break;
            }
        }

        private string ColorPrint(int id)
        {
            switch (id)
            {
                case 2:
                    return "Bílá";
                    break;
                case 3:
                    return "Černá";
                    break;
                default:
                    return "Duha";
                    break;
            }
        }

        StringBuilder sbExceptionMessages = new StringBuilder();

        private void ExceptionsList(string message, string descError)
        {
            return;

            if (String.IsNullOrWhiteSpace(message)) return;

            MessageBox.Show("Popis chyby: " + descError + Environment.NewLine + "Seznam operací: " + message.ToString(), "Chybějící operace", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sbExceptionMessages.Clear();
        }



        public void LoadSeznamOperaci(pcb_develEntities dbContext, bool ignoreSpecialniPostup)
        {
            List<int> blackListOperace = new List<int>();

            List<operace> vysledek = null;
            bool zvolenSpecialniMaterial = false;

            if (ignoreSpecialniPostup == false)
            {
                if (this.specialni_postup ?? false)
                {
                    vysledek = new List<operace>();
                    foreach (specialni_postup sp in this.specialni_postups)
                    {
                        sp.operace.Poznamka = sp.technologicka_poznamka;
                        vysledek.Add(sp.operace);
                    }
                    this.seznamOperaci = vysledek;

                    return;
                }
            }

            if (this.KodSeznam.Count == 0)
            {
                return;
            }


            blackListOperace.Add(7979);

            vysledek = new List<operace>();


            string typDesky = this.KodSeznam[0];

            foreach (operace o in dbContext.operaces)
            {
                if (o.filtr.Contains(typDesky.Trim()) && o.kod.Trim() == "")
                {
                    vysledek.Add(o);
                }
            }


            /// doplneni pomecneho Y operaci pred drazkovani nebo frezovani


            List<string> kodSeznamFinal = new List<string>();

            bool pridano = false;
            for (int i = 0; i < this.KodSeznam.Count; i++)
            {
                kodSeznamFinal.Add(this.KodSeznam[i]);
                if (pridano == false && i + 1 < this.KodSeznam.Count && (this.KodSeznam[i + 1].Contains("F") || this.KodSeznam[i + 1].Contains("D")))
                {
                    kodSeznamFinal.Add("Y");
                    pridano = true;
                }

            }


            if (kodSeznamFinal.Where(item => item == "Y").Count() == 0)
            {
                kodSeznamFinal.Add("Y");
            }

            for (int i = 1; i < kodSeznamFinal.Count; i++)
            {
                vysledek.AddRange(dbContext.operaces.ToList().Where(item => item.filtr.Contains(typDesky.Trim()) && !string.IsNullOrEmpty(this.kod) && item.kod.Contains(kodSeznamFinal[i])).ToList());
            }








            // zaplnovane vrtani
            if ((this.zapln_min_vrtak ?? 0) == 0)
            {
                blackListOperace.AddRange(new List<int>() { 18, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 3003 });
            }
            else
            {
                blackListOperace.AddRange(new List<int>() { 31, 2009 });
            }


            // slepe vrtani
            if ((this.slepe_vrtani_druh_id ?? 0) == 0)
            {
                blackListOperace.AddRange(new List<int>() { 19, 20, 21, 59, 60, 61, 62, 63, 64, 65, 68, 48, 2004, 2005, 2006, 908, 909, 3003 });
            }
            else
            {
                blackListOperace.Add(46);
                if (this.slepe_vrtani_druh_id == 1) //A
                {
                    blackListOperace.AddRange(new List<int>() { 19, 20, 21, 64, 59, 61, 62, 2005, 2006, 3003 });

                    operace vrtaniParamMaterial = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                    if (vrtaniParamMaterial != null)
                    {
                        string param = ", slepé vrtání - jednostranné ";
                        vrtaniParamMaterial.nazev += param;
                    }

                    //operace vrtaniParamBezMaterial = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                    //if (vrtaniParamBezMaterial != null)
                    //{
                    //    string param = ", slepé vrtání - jednostranné ";
                    //    vrtaniParamBezMaterial.nazev += param;
                    //}

                }

                if (this.slepe_vrtani_druh_id == 2) //B
                {
                    blackListOperace.AddRange(new List<int>() { 19, 20, 21, 59, 60, 63, 62, 2004, 2006, 3003 });

                    operace vrtaniParamMaterial = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                    if (vrtaniParamMaterial != null)
                    {
                        string param = ", slepé vrtání - jednostranné ";
                        vrtaniParamMaterial.nazev += param;
                    }

                    //operace vrtaniParamBezMaterial = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                    //if (vrtaniParamBezMaterial != null)
                    //{
                    //    string param = ", slepé vrtání - jednostranné ";
                    //    vrtaniParamBezMaterial.nazev += param;
                    //}

                }

                if (this.slepe_vrtani_druh_id == 3) //Z
                {
                    blackListOperace.AddRange(new List<int>() { 19, 20, 21, 60, 61, 63, 64, 2004, 2005, 3003 });

                    operace vrtaniParamMaterial = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                    if (vrtaniParamMaterial != null)
                    {
                        string param = ", slepé vrtání - oboustranné ";
                        vrtaniParamMaterial.nazev += param;
                    }

                    //operace vrtaniParamBezMaterial = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                    //if (vrtaniParamBezMaterial != null)
                    //{
                    //    string param = ", slepé vrtání - oboustranné ";
                    //    vrtaniParamBezMaterial.nazev += param;
                    //}

                }

                if ((this.aspect_ratio ?? 0) < 0.8m)
                {
                    blackListOperace.AddRange(new List<int>() { 59, 60, 61, 62, 63, 64, 65, 908, 909, 68, 3003 });
                }
            }






            // vazba na material

            List<int> material = new List<int>() { 32, 33, 34, 17, 2002, 35, 47, 71, 57, 35, 47, 79, 71, 27, 35, 47, 71, 32, 71, 17, 28, 143, 907, 2003, 2010, 2011, 2012, 133, 121, 122 };
            List<int> materialVybrano = new List<int>();


            if (this.ObsahujeMaterial("duroid"))
            {
                materialVybrano.AddRange(new List<int>() { 17, 35, 47, 79, 71, 34, 2012 });
                zvolenSpecialniMaterial = true;

                operace vrtaniMaterial = vysledek.Where(item => item.operace_id == 2006).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Duroid";
                    vrtaniMaterial.nazev += param;
                }

                operace vrtaniMaterial_bezSlepe = vysledek.Where(item => item.operace_id == 17).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Duroid";
                    vrtaniMaterial_bezSlepe.nazev += param;
                }

            }

            if (this.ObsahujeMaterial("arlon"))
            {
                materialVybrano.AddRange(new List<int>() { 17, 57, 35, 47, 79, 71, 2011, 33 });
                zvolenSpecialniMaterial = true;

                operace vrtaniMaterial = vysledek.Where(item => item.operace_id == 2006).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Arlon";
                    vrtaniMaterial.nazev += param;
                }

                operace vrtaniMaterial_bezSlepe = vysledek.Where(item => item.operace_id == 17).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Arlon";
                    vrtaniMaterial_bezSlepe.nazev += param;
                }

            }

            if (this.ObsahujeMaterial("diclad"))
            {
                materialVybrano.AddRange(new List<int>() { 17, 27, 35, 47, 79, 71 });
                zvolenSpecialniMaterial = true;

                operace vrtaniMaterial = vysledek.Where(item => item.operace_id == 2006).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Diclad";
                    vrtaniMaterial.nazev += param;
                }

                operace vrtaniMaterial_bezSlepe = vysledek.Where(item => item.operace_id == 17).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Diclad";
                    vrtaniMaterial_bezSlepe.nazev += param;
                }

            }

            if (this.ObsahujeMaterial("roger"))
            {
                materialVybrano.AddRange(new List<int>() { 17, 32, 71, 17, 79, 2010 });
                zvolenSpecialniMaterial = true;

                operace vrtaniMaterial = vysledek.Where(item => item.operace_id == 2006).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Roger";
                    vrtaniMaterial.nazev += param;
                }

                operace vrtaniMaterial_bezSlepe = vysledek.Where(item => item.operace_id == 17).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry Roger";
                    vrtaniMaterial_bezSlepe.nazev += param;
                }

            }

            if (this.ObsahujeMaterial("is620"))
            {
                materialVybrano.AddRange(new List<int>() { 28, 907, 32, 79, 2010 });
                zvolenSpecialniMaterial = true;

                operace vrtaniMaterial = vysledek.Where(item => item.operace_id == 2006).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry IS620";
                    vrtaniMaterial.nazev += param;
                }

                operace vrtaniMaterial_bezSlepe = vysledek.Where(item => item.operace_id == 17).FirstOrDefault();
                if (vrtaniMaterial != null)
                {
                    string param = " s parametry IS620";
                    vrtaniMaterial_bezSlepe.nazev += param;
                }

            }

            blackListOperace.AddRange(material.Where(i => !materialVybrano.Contains(i)));


            // konstrukcni trida
            if (!(this.konstrukt_trida == 8 || (this.zapln_min_vrtak ?? 0) > 0))
            {
                blackListOperace.AddRange(new List<int>() { 67 });
            }

            if (this.konstrukt_trida < 6)
            {
                blackListOperace.AddRange(new List<int>() { 54 });
            }

            if (this.konstrukt_trida < 7)
            {
                blackListOperace.AddRange(new List<int>() { 87 });
            }

            if (this.ObsahujeKod("H"))
            {
                blackListOperace.AddRange(new List<int>() { 89 });
                if (!this.ObsahujeKod("PA;PB;PX"))
                {
                    blackListOperace.AddRange(new List<int>() { 92 });
                }
            }

            if (!this.ObsahujeKod("Z"))
            {
                blackListOperace.Add(144);
            }


            //MASKY

            //List<int> seznamMaska = new List<int>() { 77, 78, 79, 80, 81, 82, 83, 84, 85, 10013, 10014, 10015 };
            //foreach (int id in seznamMaska)
            //{
            //    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

            //    try
            //    {
            //        if (o != null)
            //        {
            //            string strana = "";

            //            if (this.ObsahujeKod("MX"))
            //            {
            //                strana = "AB";

            //                if ((this.maska_barva_id > 0 && this.maska_barva_b_id > 0) && (this.maska_barva_id == this.maska_barva_b_id))
            //                {
            //                    if (this.maska_barva_id == this.maska_barva_b_id)
            //                        o.nazev = o.nazev.Replace("{barva}", Farbicka(this.maska_barva_id.Value));
            //                }
            //            }
            //            else if (this.ObsahujeKod("MA"))
            //            {
            //                strana = "A";

            //                o.nazev = o.nazev.Replace("{barva}", Farbicka(this.maska_barva_id.Value));
            //            }
            //            else if (this.ObsahujeKod("MB"))
            //            {
            //                strana = "B";

            //                o.nazev = o.nazev.Replace("{barva}", Farbicka(this.maska_barva_b_id.Value));
            //            }
            //            else
            //            {
            //                strana = "";
            //            }

            //            o.nazev = o.nazev.Replace("{strana}", strana);
            //        }
            //    }
            //    catch (Exception exp) { }
            //}





            //if (this.ObsahujeKod("MA") || this.ObsahujeKod("MB") || this.ObsahujeKod("MX"))
            //{
            //    operace meb = vysledek.Where(item => item.operace_id == 71).FirstOrDefault();

            //    if (meb != null)
            //    {
            //        meb.poradi += 6;
            //        blackListOperace = blackListOperace.Where(item => item != 71).ToList();
            //    }
            //}






            List<int> seznamMaskaStrana = new List<int>()
            {
                77, 78, 79, 80, 81, 82, 10013, 10014, 10015,
                40000, 40001, 40002, 40003, 40004,
                50000, 50001, 50002, 50003, 50004,
                10013, 10014, 10015, 10017, 10019,
                200000, 200001, 200002, 200004,
                300000, 300001, 300002, 300004
            };

            foreach (int id in seznamMaskaStrana)
            {
                operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                if (o == null) continue;
                try
                {
                    string strana = "";

                    if (this.ObsahujeKod("MX") && o.kod == "MX")
                    {
                        strana = "AB";
                    }
                    else if (this.ObsahujeKod("MA") && o.kod == "MA")
                    {
                        strana = "A";
                    }
                    else if (this.ObsahujeKod("MB") && o.kod == "MB")
                    {
                        strana = "B";
                    }
                    else
                    {
                        strana = "";
                    }
                    o.nazev = o.nazev.Replace("{strana}", strana);
                }
                catch (Exception exp)
                {
                    sbExceptionMessages.AppendLine(exp.Message);
                }
            }

            ExceptionsList(sbExceptionMessages.ToString(), "Seznam maska, strana");





            List<int> seznamMaskaFarba_A = new List<int>() { 80, 81, 82, 10013, 10014, 10015, 10017, 10019 };
            foreach (int id in seznamMaskaFarba_A)
            {
                try
                {
                    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                    if (o != null)
                    {
                        o.nazev = o.nazev.Replace("{barva}", ColorMask(this.maska_barva_id.Value));
                    }
                }
                catch (Exception exp)
                {
                    sbExceptionMessages.AppendLine(exp.Message);
                }
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Seznam maska, barva A");

            List<int> seznamMaskaFarba_B = new List<int>() { 40000, 40001, 40002, 200000, 200001, 200002, 200004 };
            foreach (int id in seznamMaskaFarba_B)
            {
                try
                {
                    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                    if (o != null)
                    {
                        o.nazev = o.nazev.Replace("{barva}", ColorMask(this.maska_barva_b_id.Value));
                    }
                }
                catch (Exception exp)
                {
                    sbExceptionMessages.AppendLine(exp.Message);
                }
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Seznam maska, barva B");

            List<int> seznamMaskaFarba_AB = new List<int>() { 50000, 50001, 50002, 300000, 300001, 300002, 300004 };
            foreach (int id in seznamMaskaFarba_AB)
            {
                try
                {
                    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                    if (o != null)
                    {
                        o.nazev = o.nazev.Replace("{barva}", ColorMask(this.maska_barva_id.Value));
                    }
                }
                catch (Exception exp)
                {
                    sbExceptionMessages.AppendLine(exp.Message);
                }
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Seznam maska, barva AB");








            if (this.ObsahujeKod("MA") == true && this.ObsahujeKod("MB") == false && this.ObsahujeKod("MX") == false)
            {
                if (!(this.konstrukt_trida > 6 || zvolenSpecialniMaterial))
                {
                    blackListOperace.Add(79);
                }
                else
                {
                    blackListOperace.Remove(79);
                    blackListOperace.Add(77);
                }
            }
            else if (this.ObsahujeKod("MA") == false && this.ObsahujeKod("MB") == true && this.ObsahujeKod("MX") == false)
            {
                if (!(this.konstrukt_trida > 6 || zvolenSpecialniMaterial))
                {
                    blackListOperace.Add(79);
                }
                else
                {
                    blackListOperace.Remove(79);
                    blackListOperace.Add(77);
                }
            }
            else if (this.ObsahujeKod("MA") == true && this.ObsahujeKod("MB") == true && this.ObsahujeKod("MX") == false)
            {
                if (!(this.konstrukt_trida > 6 || zvolenSpecialniMaterial))
                {
                    blackListOperace.Add(79);
                }
                else
                {
                    blackListOperace.Remove(79);
                    blackListOperace.Add(77);
                }
            }
            else if (this.ObsahujeKod("MA") == false && this.ObsahujeKod("MB") == false && this.ObsahujeKod("MX") == true)
            {
                if (!(this.konstrukt_trida > 6 || zvolenSpecialniMaterial))
                {
                    blackListOperace.Add(79);
                }
                else
                {
                    //operace o = vysledek.Where(item => item.operace_id == 77).FirstOrDefault();
                    //o.poradi -= 97;

                    blackListOperace.Remove(79);
                    blackListOperace.Add(77);
                }
            }







            // RaHe - duvod proc se dava pryc kontrola pred vytvrzenim a je tam vicekrat MEB?

            try
            {
                if (this.konstrukt_trida > 6 || zvolenSpecialniMaterial)
                {
                    //blackListOperace.Add(88); //maska A
                    //blackListOperace.Add(40003); //maska B
                    //blackListOperace.Add(50003); //maska AB

                    //operace meb = vysledek.Where(item => item.operace_id == 71).FirstOrDefault();
                    //meb.poradi -= 6;
                }
                else if (this.konstrukt_trida < 7)
                {
                    blackListOperace.Add(87); //maska A
                    blackListOperace.Add(40004); //maska B
                    blackListOperace.Add(50004); //maska AB
                }
            }
            catch (Exception exp)
            {
                sbExceptionMessages.AppendLine(exp.Message);
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Konštrukční třída > 6, MEB");





            try
            {
                if (this.ObsahujeKod("J.") || this.ObsahujeKod("J0") || this.ObsahujeKod("J1"))
                {
                    if (this.ObsahujeKod("MA") && this.ObsahujeKod("MB"))
                    {
                        operace o = vysledek.Where(item => item.operace_id == 78).FirstOrDefault();
                        o.poradi -= 5100;
                    }

                    if (this.ObsahujeKod("MA") || this.ObsahujeKod("MB"))
                    {
                        operace o = vysledek.Where(item => item.operace_id == 78).FirstOrDefault();
                        o.poradi -= 5100;
                    }


                    if (this.konstrukt_trida > 6 || zvolenSpecialniMaterial)
                    {
                        operace o79 = vysledek.Where(item => item.operace_id == 79).FirstOrDefault();
                        if (o79 != null)
                            o79.poradi += 100;

                        blackListOperace.Add(78);
                    }
                    else
                    {
                        operace o78 = vysledek.Where(item => item.operace_id == 78).FirstOrDefault();
                        if (o78 != null)
                            o78.poradi += 5102 + 95;

                        blackListOperace.Add(79);
                    }
                }
            }
            catch (Exception exp)
            {
                sbExceptionMessages.AppendLine(exp.Message);
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Jednostranné desky, masky");






            if (this.maska_barva_id > 1 && this.maska_barva_b_id == null)
            {
                blackListOperace.Add(80); //maska A
                blackListOperace.Add(83); //2.maska A
                blackListOperace.Add(10013);
            }
            else if (this.maska_barva_id == 1 && this.maska_barva_b_id == null)
            {
                blackListOperace.Add(81); //maska A
                blackListOperace.Add(84); //2.maska A
                blackListOperace.Add(10014);
            }




            if (this.maska_barva_b_id > 1 && this.maska_barva_id == null)
            {
                blackListOperace.Add(40000); //maska B
                blackListOperace.Add(60001); //2.maska B
                blackListOperace.Add(200000);
            }
            else if (this.maska_barva_b_id == 1 && this.maska_barva_id == null)
            {
                blackListOperace.Add(40001); //maska B
                blackListOperace.Add(60002); //2.maska B
                blackListOperace.Add(200001);
            }




            if ((this.maska_barva_id > 1) && (this.maska_barva_b_id > 1))
            {
                if (this.maska_barva_id == this.maska_barva_b_id)
                {
                    blackListOperace.Add(50000); //maska AB (plati len pre masku MX)
                    blackListOperace.Add(60001); //2.maska B (zbytocne)
                    blackListOperace.Add(83); //2.maska A (zbytocne)
                    blackListOperace.Add(300000);
                }

                if (this.maska_barva_id != this.maska_barva_b_id)
                {
                    blackListOperace.Add(80); //maska A
                    blackListOperace.Add(83); //2.maska A
                    blackListOperace.Add(40000); //maska B
                    blackListOperace.Add(60001); //2.maska B
                    blackListOperace.Add(10013);
                    blackListOperace.Add(200000);
                }
            }
            else if ((this.maska_barva_id == 1) && (this.maska_barva_b_id > 1))
            {
                blackListOperace.Add(81); //maska A
                blackListOperace.Add(40000); //maska B
                blackListOperace.Add(84); //2.maska A
                blackListOperace.Add(60001); //2.maska B
                blackListOperace.Add(10014);
                blackListOperace.Add(200000);
            }
            else if ((this.maska_barva_b_id == 1) && (this.maska_barva_id > 1))
            {
                blackListOperace.Add(80); //maska A
                blackListOperace.Add(40001); //maska B
                blackListOperace.Add(83); //2.maska A
                blackListOperace.Add(60002); //2.maska B
                blackListOperace.Add(200001);
                blackListOperace.Add(10013);
            }
            else if ((this.maska_barva_id == 1) && (this.maska_barva_b_id == 1))
            {
                blackListOperace.Add(50001); //maska AB
                blackListOperace.Add(60002); //2.maska B
                blackListOperace.Add(84); //2.maska A
                blackListOperace.Add(10014);
                blackListOperace.Add(200001);
                blackListOperace.Add(300001);
            }






            //special MP - newprint

            try
            {
                if (this.d_newprint_strana_a.HasValue || this.d_newprint_strana_b.HasValue)
                {
                    var mxOperace = this.produkt_postups.Where(w => w.postup.kod == "MX").FirstOrDefault();

                    if (mxOperace != null)
                    {
                        var pxOperace = this.produkt_postups.Where(w => w.postup.kod == "PX").FirstOrDefault();
                        if (pxOperace != null)
                        {
                            if ((pxOperace.poradi - mxOperace.poradi) == 1)
                            {
                                operace o70001 = vysledek.Where(item => item.operace_id == 70001).FirstOrDefault();
                                operace o50003 = vysledek.Where(item => item.operace_id == 50003).FirstOrDefault();
                                o50003.poradi = o70001.poradi + 6 + 1000;
                            }
                        }
                    }
                }


                var maOperace = this.produkt_postups.Where(w => w.postup.kod == "MA").FirstOrDefault();
                var mbOperace = this.produkt_postups.Where(w => w.postup.kod == "MB").FirstOrDefault();

                if (maOperace != null)
                {
                    if (this.d_newprint_strana_a.HasValue)
                    {
                        var paOperace_newprint = this.produkt_postups.Where(w => w.postup.kod == "PA").FirstOrDefault();
                        if (paOperace_newprint != null)
                        {
                            if ((paOperace_newprint.poradi - maOperace.poradi) == 1)
                            {
                                if (this.ObsahujeKod("J0;J."))
                                {
                                    operace o10016 = vysledek.Where(item => item.operace_id == 10016).FirstOrDefault();
                                    operace o10017 = vysledek.Where(item => item.operace_id == 10017).FirstOrDefault();
                                    o10017.poradi = o10016.poradi + 6 + 1000;
                                }
                                else
                                {
                                    operace o86 = vysledek.Where(item => item.operace_id == 86).FirstOrDefault();
                                    if (o86 != null)
                                    {
                                        o86.poradi = o86.poradi - 1000;
                                    }
                                }
                            }
                        }
                    }
                }

                if (mbOperace != null)
                {
                    if (this.d_newprint_strana_b.HasValue)
                    {
                        var pbaOperace_newprint = this.produkt_postups.Where(w => w.postup.kod == "PB").FirstOrDefault();
                        if (pbaOperace_newprint != null)
                        {
                            if ((pbaOperace_newprint.poradi - mbOperace.poradi) == 1)
                            {
                                operace o70000 = vysledek.Where(item => item.operace_id == 70000).FirstOrDefault();
                                o70000.poradi = o70000.poradi - 1000;
                            }
                        }
                    }
                }

            }
            catch (Exception exp)
            {
                sbExceptionMessages.AppendLine(exp.Message);
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Úprava pořadí MX/PX, MA/PA, MB/PB");




            //2.NANASENI

            List<int> seznamDvojiNanaseni = new List<int>() { 83, 84, 85, 60001, 60002, 60003, 61001, 61002, 61003 };
            foreach (int id in seznamDvojiNanaseni)
            {
                operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                try
                {
                    if (o != null)
                    {
                        string strana = "";

                        if (o.kod == "MA;MX")
                        {
                            strana = "A";
                        }
                        else if (o.kod == "MB;MX")
                        {
                            strana = "B";
                        }
                        else if (o.kod == "MX")
                        {
                            strana = "AB";
                        }
                        else
                        {
                            strana = "";
                        }
                        o.nazev = o.nazev.Replace("{strana}", strana);
                    }
                }
                catch (Exception exp)
                {
                    sbExceptionMessages.AppendLine(exp.Message);
                }
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Dvojí nanášení MA/MX, MB/MX");






            try
            {
                List<int> seznamDvojiNanaseniBarva_A = new List<int>() { 83, 84, 85, 61001, 61002, 61003 };
                foreach (int id in seznamDvojiNanaseniBarva_A)
                {
                    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                    if (o != null)
                    {
                        o.nazev = o.nazev.Replace("{barva}", ColorMask(this.maska_barva_id.Value));
                    }
                }


                List<int> seznamDvojiNanaseniBarva_B = new List<int>() { 60001, 60002, 60003 };
                foreach (int id in seznamDvojiNanaseniBarva_B)
                {
                    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                    if (o != null)
                    {
                        o.nazev = o.nazev.Replace("{barva}", ColorMask(this.maska_barva_b_id.Value));
                    }
                }
            }
            catch (Exception exp)
            {
                sbExceptionMessages.AppendLine(exp.Message);
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Dvojí nanášení, barva A, B");






            if (this.tloustka_maska.HasValue == true && this.tloustka_maska_b.HasValue == false)
            {
                blackListOperace.Add(60000);
                blackListOperace.Add(60001);
                blackListOperace.Add(60002);
                blackListOperace.Add(60003);

                blackListOperace.Add(61000);
                blackListOperace.Add(61001);
                blackListOperace.Add(61002);
                blackListOperace.Add(61003);
            }
            else if (this.tloustka_maska_b.HasValue == true && this.tloustka_maska.HasValue == false)
            {
                blackListOperace.Add(83);
                blackListOperace.Add(84);
                blackListOperace.Add(85);
                blackListOperace.Add(2040);

                blackListOperace.Add(61000);
                blackListOperace.Add(61001);
                blackListOperace.Add(61002);
                blackListOperace.Add(61003);
            }
            else if ((this.tloustka_maska.HasValue == false) && (this.tloustka_maska_b.HasValue == false))
            {
                blackListOperace.Add(83);
                blackListOperace.Add(84);
                blackListOperace.Add(85);
                blackListOperace.Add(2040);

                blackListOperace.Add(60000);
                blackListOperace.Add(60001);
                blackListOperace.Add(60002);
                blackListOperace.Add(60003);

                blackListOperace.Add(61000);
                blackListOperace.Add(61001);
                blackListOperace.Add(61002);
                blackListOperace.Add(61003);
            }
            else if ((this.tloustka_maska.HasValue == true) && (this.tloustka_maska_b.HasValue == true))
            {
                if (this.ObsahujeKod("MX"))
                {
                    blackListOperace.Add(83);
                    blackListOperace.Add(84);
                    blackListOperace.Add(85);
                    blackListOperace.Add(2040);

                    blackListOperace.Add(60000);
                    blackListOperace.Add(60001);
                    blackListOperace.Add(60002);
                    blackListOperace.Add(60003);


                    if (this.maska_barva_id > 1 && this.maska_barva_b_id > 1)
                    {
                        blackListOperace.Add(61001);
                    }
                    else if (this.maska_barva_id == 1 && this.maska_barva_b_id == 1)
                    {
                        blackListOperace.Add(61002);
                    }
                }
            }





            //POTISKY

            List<int> seznamPotiskStrana = new List<int>()
            {
                86, 70000, 70001, 112, 80000, 80001, 89, 90000, 90001, 92, 100000, 100001,
                10016, 10018, 10021,
                200003, 200005, 200007,
                300003, 300005, 300007
            };

            foreach (int id in seznamPotiskStrana)
            {
                operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                try
                {
                    if (o != null)
                    {
                        string strana = "";

                        if (this.ObsahujeKod("PX") && o.kod == "PX")
                        {
                            strana = "AB";
                        }
                        else if (this.ObsahujeKod("PA") && o.kod == "PA")
                        {
                            strana = "A";
                        }
                        else if (this.ObsahujeKod("PB") && o.kod == "PB")
                        {
                            strana = "B";
                        }
                        else
                        {
                            strana = "";
                        }
                        o.nazev = o.nazev.Replace("{strana}", strana);
                    }
                }
                catch (Exception exp)
                {
                    sbExceptionMessages.AppendLine(exp.Message);
                }
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Dvojí nanášení, barva A, B");








            if (this.potisk_barva_id > 1 && this.potisk_barva_b_id == null)
            {
                List<int> seznamPotiskFarba_A = new List<int>() { 86, 112, 89, 92, 10018, 10021 };
                foreach (int id in seznamPotiskFarba_A)
                {
                    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                    if (o != null)
                    {
                        o.nazev = o.nazev.Replace("{barva}", ColorPrint(this.potisk_barva_id.Value));
                    }
                }

                blackListOperace.Add(90000); //potisk B
                blackListOperace.Add(100000); //potisk B_H
                blackListOperace.Add(200005);
                blackListOperace.Add(200007);
            }
            else if (this.potisk_barva_b_id > 1 && this.potisk_barva_id == null)
            {
                List<int> seznamPotiskFarba_B = new List<int>() { 70000, 80000, 90000, 100000, 200005, 200007 };
                foreach (int id in seznamPotiskFarba_B)
                {
                    operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                    if (o != null)
                    {
                        o.nazev = o.nazev.Replace("{barva}", ColorPrint(this.potisk_barva_b_id.Value));
                    }
                }

                blackListOperace.Add(89); //potisk A
                blackListOperace.Add(92); //potisk A_H
                blackListOperace.Add(10018);
                blackListOperace.Add(10021);
            }
            else if ((this.potisk_barva_id > 1) && (this.potisk_barva_b_id > 1))
            {

                if (this.potisk_barva_id == this.potisk_barva_b_id)
                {
                    List<int> seznamPotiskFarba_AB = new List<int>() { 70001, 80001, 90001, 100001, 300005, 300007 };
                    foreach (int id in seznamPotiskFarba_AB)
                    {
                        operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                        if (o != null)
                        {
                            o.nazev = o.nazev.Replace("{barva}", ColorPrint(this.potisk_barva_id.Value));
                        }
                    }

                    blackListOperace.Add(89); //potisk A
                    blackListOperace.Add(92); //potisk A_H
                    blackListOperace.Add(90000); //potisk B
                    blackListOperace.Add(100000); //potisk B_H
                    blackListOperace.Add(10018);
                    blackListOperace.Add(10021);
                    blackListOperace.Add(200005);
                    blackListOperace.Add(200007);
                }

                if (this.potisk_barva_id != this.potisk_barva_b_id)
                {
                    List<int> seznamPotiskFarba_A = new List<int>() { 86, 112, 89, 92, 10018, 10021 };
                    foreach (int id in seznamPotiskFarba_A)
                    {
                        operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                        if (o != null)
                        {
                            o.nazev = o.nazev.Replace("{barva}", ColorPrint(this.potisk_barva_id.Value));
                        }
                    }

                    List<int> seznamPotiskFarba_B = new List<int>() { 70000, 80000, 90000, 100000, 200005, 200007 };
                    foreach (int id in seznamPotiskFarba_B)
                    {
                        operace o = vysledek.Where(item => item.operace_id == id).FirstOrDefault();

                        if (o != null)
                        {
                            o.nazev = o.nazev.Replace("{barva}", ColorPrint(this.potisk_barva_b_id.Value));
                        }
                    }

                    blackListOperace.Add(90001); //potisk AB
                    blackListOperace.Add(100001); //potisk AB_H
                    blackListOperace.Add(300005);
                    blackListOperace.Add(300007);
                }
            }
            else
            {
                blackListOperace.Add(89);
                blackListOperace.Add(92);
                blackListOperace.Add(90000);
                blackListOperace.Add(90001);
                blackListOperace.Add(100000);
                blackListOperace.Add(100001);
                blackListOperace.Add(200005);
                blackListOperace.Add(200007);
                blackListOperace.Add(300005);
                blackListOperace.Add(300007);
                blackListOperace.Add(10018);
                blackListOperace.Add(10021);
            }








            if (((this._maska_barva_id ?? 0) == 0) && !this.ObsahujeKod("Q"))
            {
                //blackListOperace.Add(81);
                blackListOperace.Add(84);
                blackListOperace.Add(10014);
            }


            if (this.ObsahujeKod("Q"))
            {
                blackListOperace.Add(83);
                //blackListOperace.Add(80);
                blackListOperace.Add(10013);

                if (this.ObsahujeKod("J."))
                {
                    blackListOperace.Add(53);
                }
            }







            if ((this.konstrukt_trida ?? 0) < 7 && !zvolenSpecialniMaterial)
            {
                //blackListOperace.Add(79);
                blackListOperace.Add(46);
            }

            if (zvolenSpecialniMaterial || (this.konstrukt_trida ?? 0) > 6)
            {
                blackListOperace.Add(72);
                //blackListOperace.Add(77);
            }

            if (!(this.naraz_konekt ?? false))
            {
                blackListOperace.Add(2108);
            }



            if (this.ObsahujeKod("H"))
            {
                blackListOperace.Add(89);
                blackListOperace.Add(90000);
                blackListOperace.Add(90001);
                blackListOperace.Add(10018);
                blackListOperace.Add(200005);
                blackListOperace.Add(300005);

            }
            else if (!this.ObsahujeKod("H"))
            {
                blackListOperace.Add(92);
                blackListOperace.Add(100000);
                blackListOperace.Add(100001);
                blackListOperace.Add(10021);
                blackListOperace.Add(200007);
                blackListOperace.Add(300007);
            }


            if (this.ObsahujeKod("Z"))
            {
                if (this.d_newprint_strana_a.HasValue || this.d_newprint_strana_b.HasValue)
                {
                    blackListOperace.Add(112);
                    blackListOperace.Add(70000);
                    blackListOperace.Add(70001);
                }
            }
            else if (!this.ObsahujeKod("Z"))
            {
                if (this.d_newprint_strana_a.HasValue || this.d_newprint_strana_b.HasValue)
                {
                    blackListOperace.Add(112);
                    blackListOperace.Add(80000);
                    blackListOperace.Add(80001);
                }
            }



            if (this.ObsahujeKod("Z"))
            {
                blackListOperace.Add(112);
                blackListOperace.Add(76);
            }
            else
            {
                blackListOperace.Add(2105);
            }

            if ((this.konstrukt_trida ?? 0) < 7)
            {
                blackListOperace.Add(87);
            }

            if (!this.ObsahujeKod("PA;PB;PX") && !this.ObsahujeKod("H"))
            {
                blackListOperace.Add(92);
                blackListOperace.Add(100000);
                blackListOperace.Add(100001);
            }

            if (!(this.ObsahujeKod("I") && ((celkova_tloustka ?? 0) < 2)))
            {
                blackListOperace.Add(95);
                blackListOperace.Add(2);
                blackListOperace.Add(903);
            }

            if (this.ObsahujeKod("I") && this.ObsahujeKod("Z"))
            {
                blackListOperace.Add(98);
            }

            if (!(this.ObsahujeKod("Z") && (this.newprint_uzivatel_strana_a_id ?? 0 + this.newprint_uzivatel_strana_a_id ?? 0) > 0))
            {
                blackListOperace.Add(112);
            }

            if (this.ObsahujeKod("H") && this.ObsahujeKod("Z"))
            {
                blackListOperace.Add(114);
            }
            else
            {
                blackListOperace.Add(990);
                blackListOperace.Add(911);
            }

            if (!(this.fazetovani_lisovna ?? false))
            {
                blackListOperace.Add(114);
            }

            if (!this.ObsahujeKod("Z"))
            {
                blackListOperace.Add(144);

            }

            if (!this.pokovene_zahloubene_otvory_id.HasValue)
            {
                //blackListOperace.Add(2106);
            }

            if (!this.prokovene_hl_frezovani_id.HasValue)
            {
                blackListOperace.Add(2107);
            }



            if (this.fazetovani_freza.HasValue)
            {
                if (this.fazetovani_freza.Value == true && this.ObsahujeKod("I") && this.ObsahujeKod("Z") && this.ObsahujeKod("T"))
                {
                    blackListOperace.Add(2105);
                }
                else if (this.fazetovani_freza.Value == true && this.ObsahujeKod("Z") && this.ObsahujeKod("H") && this.ObsahujeKod("T"))
                {
                    blackListOperace.Add(2105);
                }
            }





            //NEWPRINTS


            if (this.d_newprint_strana_a.HasValue && this.d_newprint_strana_b.HasValue == false)
            {
                blackListOperace.Add(70000); //newprint B
                blackListOperace.Add(80000); //newprint B_H
                blackListOperace.Add(70001); //newprint AB
                blackListOperace.Add(80001); //potisk AB_H
                blackListOperace.Add(200003);
                blackListOperace.Add(300003);
            }
            else if (this.d_newprint_strana_b.HasValue && this.d_newprint_strana_a.HasValue == false)
            {
                blackListOperace.Add(86); //newprint A
                blackListOperace.Add(112); //newprint A_H
                blackListOperace.Add(70001); //newprint AB
                blackListOperace.Add(80001); //potisk AB_H
                blackListOperace.Add(10016);
                blackListOperace.Add(300003);
            }
            else if (this.d_newprint_strana_a.HasValue && this.d_newprint_strana_b.HasValue)
            {
                blackListOperace.Add(86); //newprint A
                blackListOperace.Add(112); //newprint A_H
                blackListOperace.Add(70000); //newprint B
                blackListOperace.Add(80000); //newprint B_H
                blackListOperace.Add(10016);
                blackListOperace.Add(200003);
            }
            else if (this.d_newprint_strana_a.HasValue == false && this.d_newprint_strana_b.HasValue == false)
            {
                blackListOperace.Add(86);
                blackListOperace.Add(112);
                blackListOperace.Add(70000);
                blackListOperace.Add(70001);
                blackListOperace.Add(80000);
                blackListOperace.Add(80001);
                blackListOperace.Add(300003);
                blackListOperace.Add(200003);
                blackListOperace.Add(10016);
            }







            if (this.ObsahujeKod("Z"))
            {
                if (!(this.fazetovani_freza ?? false))
                {
                    blackListOperace.Add(144);
                }
            }

            // vrtak
            if ((this.min_vrtak_vrtani ?? 0) > 0.25m || !this.min_vrtak_vrtani.HasValue)
            {
                blackListOperace.AddRange(new List<int>() { 22, 2007 });
            }

            if ((this.min_vrtak_vrtani ?? 0) > 0.2m || !this.min_vrtak_vrtani.HasValue)
            {
                blackListOperace.AddRange(new List<int>() { 24 });
            }


            if ((this.min_vrtak_vrtani ?? 0) > 0.3m)
            {
                blackListOperace.AddRange(new List<int>() { 32 });
            }


            if (!this.ObsahujeKod("Z") && (this.pozadovan_opticky_test_sn ?? false) == false)
            {
                blackListOperace.AddRange(new List<int>() { 75 });
            }

            // vypnuti Y

            if (!this.laser_druh_id.HasValue || !this.laser_typ_id.HasValue)
            {
                blackListOperace.Add(2100);
                blackListOperace.Add(2101);
            }

            if (!this.neprokovene__id.HasValue || (this.neprokovene__id.HasValue && this.neprokovene__id == 2))
            {
                blackListOperace.Add(2102);
            }

            if (!this.nepokov_zahl_otvory_id.HasValue || (this.nepokov_zahl_otvory_id.HasValue && this.nepokov_zahl_otvory_id == 2))
            {
                blackListOperace.Add(2102);
            }

            if (!this.hloubkove_frezovani_id.HasValue || (this.hloubkove_frezovani_id.HasValue && this.hloubkove_frezovani_id == 2))
            {
                blackListOperace.Add(2102);
            }

            if (!(this.fazetovani_lisovna ?? false))
            {
                blackListOperace.Add(3000);
            }

            if (!(this.zabruseni_mustku ?? false))
            {
                blackListOperace.Add(142);
            }

            //SA,SB,SX

            if (this.snimatelna_maska_typ_id == (int)snimatelna_maska_typ.Value.oboje || this.snimatelna_maska_typ_id == (int)snimatelna_maska_typ.Value.kaptonovaPaska)
            {
                blackListOperace.Add(127); // zrusi masku
            }

            if (this.snimatelna_maska_typ_id == (int)snimatelna_maska_typ.Value.sitotiskem)
            {
                blackListOperace.Add(128); // zrusi pasku
            }





            // pokoveni
            if (!(this.ObsahujeKod("I;Q;") && this.vice_pokoveni.HasValue && this.vice_pokoveni.Value))
            {
                blackListOperace.AddRange(new List<int>() { 56 });
            }

            if (!(this.ObsahujeKod("I;Q;Z")))
            {
                blackListOperace.AddRange(new List<int>() { 57 });
            }

            bool zrusitVratni = false;
            if (this.prokovene_drazky_id.HasValue || this.prokovene_drazky_id.HasValue || this.pokovene_zahloubene_otvory_id.HasValue)
            {
                if ((this.prokovene_hl_frezovani_id ?? 0) > 1)
                {
                    zrusitVratni = true;
                }

                if ((this.prokovene_drazky_id ?? 0) > 1)
                {
                    zrusitVratni = true;
                }

                if ((this.pokovene_zahloubene_otvory_id ?? 0) > 1)
                {
                    zrusitVratni = true;
                }
            }
            else
            {
                blackListOperace.AddRange(new List<int>() { 2008 });
            }

            if (zrusitVratni)
            {
                blackListOperace.AddRange(new List<int>() { 16,17,907,19,20,21,22,
2002,
2003,
2004,
2005,
2006,
2007
 });
            }

            // vyrazeni operaci pro q
            if (this.ObsahujeKod("Q"))
            {
                blackListOperace.AddRange(new List<int>() {
58,
59,
60,
61,
62,
63,
64,
65,
66,
67,
68,
69,
71,
72,
73,
74
                });
            }

            // vyrazeni zaplnovane otvory
            if ((this.zapln_min_vrtak ?? 0) == 0)
            {
                blackListOperace.AddRange(new List<int>() {
                2001,
2002,
2003,
2004,
2005,
2006,
2007,
2008,
2009,
2010,
2011,
2012,
2013,
2014,
2015
});

            }
            else
            {
                blackListOperace.Add(904);
            }






            try
            {
                if (this.ObsahujeKod("J.") || this.ObsahujeKod("J0") || this.ObsahujeKod("J1"))
                {
                    blackListOperace.Add(16);
                    blackListOperace.Add(17);

                    if (this.ObsahujeMaterial("arlon"))
                    {
                        operace o904_arlon = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                        string p_arlon = " s parametry Arlon (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                        o904_arlon.nazev += string.Format(p_arlon, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                    }
                    else if (this.ObsahujeMaterial("duroid"))
                    {
                        operace o904_arlon = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                        string p_arlon = " s parametry Duroid (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                        o904_arlon.nazev += string.Format(p_arlon, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                    }
                    else if (this.ObsahujeMaterial("diclad"))
                    {
                        operace o904_arlon = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                        string p_arlon = " s parametry Diclad (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                        o904_arlon.nazev += string.Format(p_arlon, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                    }
                    else if (this.ObsahujeMaterial("roger"))
                    {
                        operace o904_arlon = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                        string p_arlon = " s parametry Roger (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                        o904_arlon.nazev += string.Format(p_arlon, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                    }
                    else if (this.ObsahujeMaterial("is620"))
                    {
                        operace o904_arlon = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                        string p_arlon = " s parametry is620 (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                        o904_arlon.nazev += string.Format(p_arlon, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                    }
                    else
                    {
                        operace o904 = vysledek.Where(item => item.operace_id == 904).FirstOrDefault();
                        string param = " (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                        o904.nazev += string.Format(param, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                    }
                }

            }
            catch (Exception exp)
            {
                sbExceptionMessages.AppendLine(exp.Message);
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Jednostranné dosky, materiál");







            //VRTANI (samostatne + zaplnovane)

            try
            {
                #region VRTANI

                bool frezovani = false;

                const string VRTANI_PARAM = " (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";

                string prefixMaterial = " s parametry ";
                string tmpMaterial = "";

                if (this.ObsahujeMaterial("arlon") || this.ObsahujeMaterial("duroid") || this.ObsahujeMaterial("diclad")|| this.ObsahujeMaterial("roger"))
                {
                    tmpMaterial = "Arlon";
                }
                else if (false)
                {
                    tmpMaterial = "Duriod";
                }
                else if (false)
                {
                    tmpMaterial = "Diclad";
                }
                else if (false)
                {
                    tmpMaterial = "Roger";
                }
                else if (this.ObsahujeMaterial("is620"))
                {
                    tmpMaterial = "is620";
                }

                operace o904 = vysledek.Where(w => w.operace_id == 904).FirstOrDefault();
                operace o2001 = vysledek.Where(item => item.operace_id == 2001).FirstOrDefault();

                if (!string.IsNullOrEmpty(tmpMaterial))
                {
                    o904.nazev += prefixMaterial + tmpMaterial;
                    o2001.nazev += prefixMaterial + tmpMaterial;
                }
                o904.nazev += string.Format(VRTANI_PARAM, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                o2001.nazev += string.Format(VRTANI_PARAM, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                #endregion

                blackListOperace.AddRange(new int[] { 16, 17, 904904, 2008, 20012001, 2106, 2107, 30000 });

                if (this.prokovene_drazky_id == 1 || this.pokovene_zahloubene_otvory_id == 1 || this.prokovene_hl_frezovani_id == 1)
                {
                    operace frezovaniProkoveneHloubkove = vysledek.Where(item => item.operace_id == 2107).FirstOrDefault();

                    operace pokoveneZahloubeneOtvory = vysledek.Where(item => item.operace_id == 2106).FirstOrDefault();
                    pokoveneZahloubeneOtvory.poradi = frezovaniProkoveneHloubkove.poradi - 2m;

                    if (this.prokovene_drazky_id == 1)
                    {
                        blackListOperace.Remove(30000);
                        operace operaceFrezovaniProkovane = vysledek.Where(item => item.operace_id == 30000).First();
                        operaceFrezovaniProkovane.nazev += string.Format(" (paket: {0})", prokovene_paket ?? 0);

                    }
                    if (this.pokovene_zahloubene_otvory_id == 1)
                    {
                        blackListOperace.Remove(2106);
                    }
                    if (this.prokovene_hl_frezovani_id == 1)
                    {
                        blackListOperace.Remove(2107);
                    }
                }

                if (this.prokovene_drazky_id == 1 && this.prokovene_hl_frezovani_id == 2) //null_mix
                {
                    frezovani = true;
                    blackListOperace.AddRange(new int[] { 16, 30000, 2107, 2008, 904904 });

                    blackListOperace.Remove(20012001);

                    operace o20012001 = vysledek.Where(item => item.operace_id == 20012001).FirstOrDefault();
                    o20012001.nazev = string.Format("Frézování prokovené (paket: {0}) + Frézování prokovené hloubkové", prokovene_paket ?? 0);

                    if (!(this.zapln_min_vrtak.HasValue && this.zapln_pocet_otv.HasValue))
                    {
                        o20012001.poradi -= 20;
                    }
                }
                else if (this.prokovene_drazky_id == 2 && this.prokovene_hl_frezovani_id == 1) //null_mix
                {
                    frezovani = true;
                    blackListOperace.AddRange(new int[] { 16, 30000, 2107, 2008, 904904 });

                    blackListOperace.Remove(20012001);

                    operace o20012001 = vysledek.Where(item => item.operace_id == 20012001).FirstOrDefault();
                    o20012001.nazev = string.Format("Frézování prokovené hloubkové + Frézování prokovené (paket: {0})", prokovene_paket ?? 0);

                    if (!(this.zapln_min_vrtak.HasValue && this.zapln_pocet_otv.HasValue))
                    {
                        o20012001.poradi -= 20;
                    }
                }
                if (this.prokovene_drazky_id == 2 || this.pokovene_zahloubene_otvory_id == 2 || this.prokovene_hl_frezovani_id == 2)
                {
                    if (this.pokovene_zahloubene_otvory_id == 2)
                    {
                        blackListOperace.Add(2106);
                        o904.nazev += " + Vrtání prokov.zahl.otvorů";
                        o2001.nazev += " + Vrtání prokov.zahl.otvorů";
                    }
                    if (this.prokovene_drazky_id == 2 && !frezovani)
                    {
                        blackListOperace.Add(30000);
                        o904.nazev += string.Format(" + Frézování prokovené (paket: {0})", prokovene_paket ?? 0);
                        o2001.nazev += string.Format(" + Frézování prokovené (paket: {0})", prokovene_paket ?? 0);
                    }
                    if (this.prokovene_hl_frezovani_id == 2 && !frezovani)
                    {
                        blackListOperace.Add(2107);
                        o904.nazev += " + Frézování prokovené hloubkové";
                        o2001.nazev += " + Frézování prokovené hloubkové";

                    }
                }
                else if (this.prokovene_drazky_id == null && this.pokovene_zahloubene_otvory_id == null && this.prokovene_hl_frezovani_id == null)
                {
                    blackListOperace.AddRange(new int[] { 16, 17, 2106, 30000, 904904, 2008, 20012001 });
                }
            }
            catch (Exception exp)
            {
                sbExceptionMessages.AppendLine(exp.Message);
            }
            ExceptionsList(sbExceptionMessages.ToString(), "Vrtání s parametry a materiály");








            if (this.zapln_min_vrtak.HasValue && this.zapln_pocet_otv.HasValue)
            {
                operace pokoveneZahloubeneOtvory = vysledek.Where(item => item.operace_id == 2106).FirstOrDefault();
                pokoveneZahloubeneOtvory.poradi += 24.1m;

                operace prokoveneHlFrez = vysledek.Where(item => item.operace_id == 2107).FirstOrDefault();
                prokoveneHlFrez.poradi += 28.7m;

                operace pp = vysledek.Where(item => item.operace_id == 30000).FirstOrDefault();
                pp.poradi += 30.6m;

                //operace vrtaniDRPt = vysledek.Where(item => item.operace_id == 2001).FirstOrDefault();
                //string param = " (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                //vrtaniDRPt.nazev += string.Format(param, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));

                //if (this.prokovene_drazky_id == 2 && this.pokovene_zahloubene_otvory_id == 2 && this.prokovene_hl_frezovani_id == 2)
                //{
                //    operace vrtaniDRPd = vysledek.Where(item => item.operace_id == 2008).FirstOrDefault();
                //    string paramD = " (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                //    vrtaniDRPd.nazev += string.Format(paramD, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
                //    vrtaniDRPd.poradi -= 1;
                //}
            }













            //VRTANI+SLEPE+ZAPLN
            if (this.min_vrtak_vrtani.HasValue && this.pocet_otvoru_vrtani.HasValue && this.slepe_vrtani_druh_id != 0 && this.aspect_ratio != 0 && this.zapln_min_vrtak.HasValue && this.zapln_pocet_otv.HasValue)
            {
                List<int> neopacts_s = new List<int>() { 31, 32, 33, 34 };
                List<int> neopactsZaplnovane_s = new List<int>() { 2009, 2010, 2011, 2012 };


                if (this.zapln_min_vrtak.HasValue && (this.zapln_min_vrtak <= 0.35m))
                {
                    operace cisteniDRP = vysledek.Where(item => item.operace_id == 30).FirstOrDefault();
                    blackListOperace.Add(29);
                }
                else
                {
                    operace cisteniDRP = vysledek.Where(item => item.operace_id == 29).FirstOrDefault();
                    blackListOperace.Add(30);
                }


                foreach (operace neopact in vysledek.Where(item => neopacts_s.Contains(item.operace_id)))
                {
                    string param = "";

                    param = " min.vrt {0} počet otvorů: {1}";
                    neopact.nazev += string.Format(param, this.zapln_min_vrtak ?? 0, this.zapln_pocet_otv ?? 0);
                }


                if (this.min_vrtak_vrtani.HasValue && (this.min_vrtak_vrtani <= 0.35m))
                {
                    operace cisteniDR2 = vysledek.Where(item => item.operace_id == 2014).FirstOrDefault();
                    blackListOperace.Add(2013);
                }
                else
                {
                    operace cisteniDR2 = vysledek.Where(item => item.operace_id == 2013).FirstOrDefault();
                    blackListOperace.Add(2014);
                }

                foreach (operace neopact in vysledek.Where(item => neopactsZaplnovane_s.Contains(item.operace_id)))
                {
                    string param = " min.vrt {0} počet otvorů: {1}";
                    neopact.nazev += string.Format(param, this.min_vrtak_vrtani ?? 0, this.pocet_otvoru_vrtani ?? 0);
                }

            }
            //VRTANI - samostatne
            else if (this.min_vrtak_vrtani.HasValue && this.pocet_otvoru_vrtani.HasValue)
            {
                List<int> neopacts = new List<int>() { 31, 32, 33, 34 };
                List<int> neopactsZaplnovane = new List<int>() { 2009, 2010, 2011, 2012 };

                foreach (operace neopact in vysledek.Where(item => neopacts.Contains(item.operace_id)))
                {
                    string param = "";

                    param = " min.vrt {0} počet otvorů: {1}";
                    neopact.nazev += string.Format(param, this.min_vrtak_vrtani ?? 0, this.pocet_otvoru_vrtani ?? 0);
                }

                foreach (operace neopact in vysledek.Where(item => neopactsZaplnovane.Contains(item.operace_id)))
                {
                    string param = " min.vrt {0} počet otvorů: {1}";
                    neopact.nazev += string.Format(param, this.zapln_min_vrtak ?? 0, this.zapln_pocet_otv ?? 0);
                }

                if (this.min_vrtak_vrtani.HasValue && (this.min_vrtak_vrtani <= 0.35m))
                {
                    if (!this.ObsahujeKod("J.") || !this.ObsahujeKod("J0"))
                    {
                        operace cisteniDR2 = vysledek.Where(item => item.operace_id == 2014).FirstOrDefault();
                        blackListOperace.Add(2013);
                    }

                }
                else
                {
                    if (!this.ObsahujeKod("J.") || !this.ObsahujeKod("J0"))
                    {
                        operace cisteniDR2 = vysledek.Where(item => item.operace_id == 2013).FirstOrDefault();
                        blackListOperace.Add(2014);
                    }

                }

                if (this.min_vrtak_vrtani.HasValue && (this.min_vrtak_vrtani <= 0.35m))
                {
                    if (!this.ObsahujeKod("J.") || !this.ObsahujeKod("J0"))
                    {
                        operace cisteniDRP = vysledek.Where(item => item.operace_id == 30).FirstOrDefault();
                        blackListOperace.Add(29);
                    }
                }
                else
                {
                    if (!this.ObsahujeKod("J.") || !this.ObsahujeKod("J0"))
                    {
                        operace cisteniDRP = vysledek.Where(item => item.operace_id == 29).FirstOrDefault();
                        blackListOperace.Add(30);
                    }
                }
            }




            //ZAPLN - samostatne
            if (this.zapln_min_vrtak.HasValue && (this.min_vrtak_vrtani ?? 0) == 0 && (this.slepe_vrtani_druh == null))
            {
                blackListOperace.AddRange(new List<int>()
                {
                    2001,
                    2015,
                    2013,
                    2014
                });

                if (this.zapln_min_vrtak <= 0.35m)
                {
                    operace cisteniDRP = vysledek.Where(item => item.operace_id == 30).FirstOrDefault();
                    blackListOperace.Add(29);
                }
                else
                {
                    operace cisteniDRP = vysledek.Where(item => item.operace_id == 29).FirstOrDefault();
                    blackListOperace.Add(30);
                }

            }






            // trida < 6

            if ((this.konstrukt_trida ?? 0) < 6 && this.ObsahujeKod("O.") && !this.ObsahujeKod("T"))
            {
                blackListOperace.Add(116);
            }

            if ((this.konstrukt_trida ?? 0) > 6 && (!this.ObsahujeKod("Q")))
            {
                blackListOperace.Add(72);
                blackListOperace = blackListOperace.Where(item => item != 71).ToList();
            }


            // vyradi a pak na konci prida
            blackListOperace.AddRange(new List<int>() { 163, 164 });

            if ((this.zapln_min_vrtak ?? 0) > 0)
            {
                blackListOperace = blackListOperace.Where(item => item != 32 && item != 2010).ToList();
            }

            if ((this.slepe_vrtani_druh_id ?? 0) > 0)
            {
                blackListOperace = blackListOperace.Where(item => item != 32).ToList();
            }

            if (this.ObsahujeKod("Q"))
            {
                blackListOperace.Add(75);
                if (this.ObsahujeKod("MA;MB;MX"))
                {
                    blackListOperace.Add(77);
                }

            }
            else
            {
                blackListOperace.Add(50);
            }

            ////////////////THERMAL J1
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (this.poradi(string.Format("F{0};D{1}", i.ToString(), j.ToString())))
                    {
                        blackListOperace.Add(10031);
                    }
                }
            }


            if (this.ObsahujeKod("J1"))
            {
                blackListOperace.Add(10012);

                if (konstrukt_trida > 6)
                {
                    blackListOperace.Add(78);
                }
                else
                {
                    blackListOperace.Add(79);
                }
            }


            //////// E1;E2

            if (!this.ObsahujeKod("F1;F2"))
            {
                blackListOperace.Add(20036);
                blackListOperace.Add(20037);
                blackListOperace.Add(20038);
            }

            if (!this.ObsahujeKod("MA"))
            {
                blackListOperace.Add(20002);
                blackListOperace.Add(20006);
                blackListOperace.Add(20008);
            }


            if (!this.ObsahujeKod("MB"))
            {
                blackListOperace.Add(20003);
                blackListOperace.Add(20006);
                blackListOperace.Add(20009);
            }


            if (!this.ObsahujeKod("MX"))
            {
                blackListOperace.Add(20004);
                blackListOperace.Add(20006);
                blackListOperace.Add(20010);
            }


            if (!this.ObsahujeKod("L"))
            {
                blackListOperace.Add(20043);
                blackListOperace.Add(20011);
                blackListOperace.Add(20044);
            }

            if (!this.ObsahujeKod("MX;MA;MB;L"))
            {
                blackListOperace.Add(20026);
                blackListOperace.Add(20025);
                blackListOperace.Add(20028);
                blackListOperace.Add(20029);
                blackListOperace.Add(20030);
            }




            if (this.ObsahujeKod("J.") == false && !this.ObsahujeKod("J0") == false && !this.ObsahujeKod("J1") == false)
            {
                if (this.prokovene_drazky_id == null && this.pokovene_zahloubene_otvory_id == null && this.prokovene_hl_frezovani_id == null)
                {
                    if (this.ObsahujeKod("MX") || this.ObsahujeKod("MA") || this.ObsahujeKod("MB"))
                    {
                        blackListOperace.Add(20045);
                        blackListOperace.Add(904);
                    }
                }
            }




            if ((this.neprokovene__id ?? 0) == 1)
            {
                blackListOperace.Remove(20036);
            }

            if ((this.nepokov_zahl_otvory_id ?? 0) == 1)
            {
                blackListOperace.Remove(20037);
                blackListOperace.Remove(20038);
            }

            if ((this.neprokovene__id ?? 0) > 1 || (this.neprokovene__id ?? 0) == 0)
            {
                blackListOperace.Add(20039);
            }

            operace podlepy = vysledek.Where(item => item.operace_id == 20026).FirstOrDefault();
            if (podlepy != null && this.ObsahujeKod("L"))
            {
                string param = " + podlep/y";
                podlepy.nazev += string.Format(param);
            }

            if (podlepy != null && this.ObsahujeKod("MA;MB;MX"))
            {
                string param = " + maska";
                podlepy.nazev += string.Format(param);
            }


            vysledek = vysledek.Where(i => !blackListOperace.Contains(i.operace_id)).ToList();







            // prida konecne operace expedice a kontrola
            vysledek.AddRange(dbContext.operaces.ToList().Where(item => item.operace_id == 163 || item.operace_id == 164));
            // umela operace
            if (this.laminace_materialu ?? false)
            {
                vysledek.Add(new operace() { nazev = this.laminace_definice, poradi = 0 });
            }

            vysledek = vysledek.Where(item => item.operace_id != 0).ToList();

            // vrtani
            List<int> seznamVrtani = new List<int>() { 907, 18, 19, 20, 21, 17 };
            if (vysledek.Where(item => seznamVrtani.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 16).ToList();
            }

            // vrtani
            List<int> seznamVrtaniZaplnovane = new List<int>() { 2003, 2004, 2005, 2006, 2002 };
            if (vysledek.Where(item => seznamVrtaniZaplnovane.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 2001).ToList();
            }

            // zaplnovane
            List<int> seznamZaplnovaneOtvory = new List<int>() { 67 };
            if (vysledek.Where(item => seznamZaplnovaneOtvory.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 66).ToList();
            }

            if (vysledek.Where(item => item.operace_id == 18).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 16 && item.operace_id != 17 && item.operace_id != 907 && item.operace_id != 19 && item.operace_id != 20 && item.operace_id != 21).ToList();
            }

            // termal klad a organicky povlak
            if (this.ObsahujeKod("G") && this.ObsahujeKod("J1"))
            {
                if (vysledek.Where(item => item.operace_id == 118).Count() > 0)
                {
                    vysledek = vysledek.Where(item => item.operace_id != 138).ToList();
                }

            }

            // neopact
            List<int> seznamNeopact = new List<int>() { 32, 33, 34 };
            if (vysledek.Where(item => seznamNeopact.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 31).ToList();
            }

            List<int> seznamNeopactMat = new List<int>() { 33, 34 };
            if (vysledek.Where(item => seznamNeopactMat.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 32).ToList();
            }

            // neopact zaplnovane
            List<int> seznamNeopactZaplnovane = new List<int>() { 2010, 2011, 2012 };
            if (vysledek.Where(item => seznamNeopactZaplnovane.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 2009).ToList();
            }

            // neopact zaplnovane
            List<int> seznamNeopactZaplnovaneMat = new List<int>() { 2011, 2012 };
            if (vysledek.Where(item => seznamNeopactZaplnovaneMat.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 2010).ToList();
            }

            // 
            List<int> seznamkart = new List<int>() { 72 };
            if (vysledek.Where(item => seznamkart.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 71).ToList();
            }


            // mikrozaleptani
            List<int> seznamMicrozaleptani = new List<int>() { 47 };
            if (vysledek.Where(item => seznamMicrozaleptani.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 46).ToList();
            }

            // NavaleniForoRezistu
            if (this.ObsahujeKod("Q"))
            {
                List<int> seznamNavaleniForoRezistu = new List<int>() { 50 };
                if (vysledek.Where(item => seznamNavaleniForoRezistu.Contains(item.operace_id)).Count() > 0)
                {
                    vysledek = vysledek.Where(item => item.operace_id != 49).ToList();
                }
            }
            // potisk


            List<int> seznamPotiskVyr = new List<int>() { 86 };
            if (vysledek.Where(item => seznamPotiskVyr.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 89).ToList();
            }

            seznamPotiskVyr = new List<int>() { 89 };
            if (vysledek.Where(item => seznamPotiskVyr.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 86).ToList();
            }


            //kartacovani

            List<int> seznamNavaleniKartacovani = new List<int>() { 78 };
            if (vysledek.Where(item => seznamNavaleniKartacovani.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 77).ToList();
            }


            seznamNavaleniKartacovani = new List<int>() { 79 };
            if (vysledek.Where(item => seznamNavaleniKartacovani.Contains(item.operace_id)).Count() > 0)
            {
                //vysledek = vysledek.Where(item => item.operace_id != 78).ToList();
            }


            List<int> lsGalvanicke = new List<int>() { 55 };
            if ((this.slepe_vrtani_druh_id ?? 0) > 0)
            {
                foreach (operace o in vysledek.Where(item => lsGalvanicke.Contains(item.operace_id)))
                {
                    o.nazev += " (zvýšit bublání)";
                }

                if (this.aspect_ratio > 0.8m)
                {
                    foreach (operace o in vysledek.Where(item => lsGalvanicke.Contains(item.operace_id)))
                    {
                        o.nazev += " nechat v regálu - výbrus";
                    }
                }
            }

            if (this.vice_pokoveni ?? false)
            {
                foreach (operace o in vysledek.Where(item => lsGalvanicke.Contains(item.operace_id)))
                {
                    o.nazev += " Pokovení 2x!";
                }
            }


            List<int> lsVrtani = new List<int>() {16,
2001,
2002,
2003,
2004,
2005,
2006,
16,
17,
907,
19,
20,
21
};
            if ((this.prekryte_vrtani ?? 0) > 0)
            {

                foreach (operace o in vysledek.Where(item => lsVrtani.Contains(item.operace_id)))
                {
                    o.nazev += string.Format(" (překryté vrtání - posuv vrták Ø {0})", this.prekryte_vrtani.Value);
                }
            }

            List<int> lsSlepeVrtani = new List<int>() { 2004, 2005, 2006 };
            if (vysledek.Where(item => lsSlepeVrtani.Contains(item.operace_id)).Count() > 0)
            {
                vysledek = vysledek.Where(item => item.operace_id != 2001 && item.operace_id != 2002 && item.operace_id != 2003).ToList();
            }

            foreach (produkt_poznamka pp in this.produkt_poznamkas.Where(w => w.aktivni ?? false))
            {
                operace o = vysledek.Where(item => item.operace_id == pp.operace_id).FirstOrDefault();
                if (o != null)
                {
                    o.Poznamka = pp.poznamka;
                }
            }


            // drazkovani d1,d2,d3
            foreach (operace o in vysledek.Where(item => item.operace_id == 131 || item.operace_id == 134 || item.operace_id == 132))
            {
                if (o.operace_id == 132) //D1 // kolonkz 202
                {
                    o.nazev += string.Format(" {0}x{0}", this.zakladni_panel_x, this.zakladni_panel_y);
                }

                //if (o.operace_id == 134) // D3 // kolonkz 202
                //{
                //    o.nazev += string.Format(" {0}x{0}", this.cisty_rozmer_dps_x, this.cisty_rozmer_dps_y);
                //}

                o.nazev += string.Format("\nVD-dl: {0} jádro: {1} \nVD-kr: {2} jádro: {3} ", this.vd_delsi_detail ?? "", this.vd_jadro ?? 0.3m, this.vd_kratsi_detail ?? "", this.vd_kratsi_jadro ?? 0.3m);
            }


            // ToDo: RaHe
            List<int> prokoveneVrtani = new List<int>() { 16, 2002, 17, 2003, 907 };
            foreach (operace vrtani in vysledek.Where(item => prokoveneVrtani.Contains(item.operace_id)))
            {
                if (this.prokovene_drazky_id == 2)
                {
                    vrtani.nazev += " + prokovené drážky";
                }

                if (this.pokovene_zahloubene_otvory_id == 2)
                {
                    vrtani.nazev += " + prokovené zahloubené otvory";
                }

                if (this.prokovene_hl_frezovani_id == 2)
                {
                    vrtani.nazev += " + frézování prokovené hloubkové";
                }
            }

            List<int> prokoveneVrtaniParam = new List<int>() { 19, 2004, 20, 2005, 21, 2006, 2002, 17, 2003, 907, 16, 20007 };
            foreach (operace vrtanisl in vysledek.Where(item => prokoveneVrtaniParam.Contains(item.operace_id)))
            {
                string param = " (paket: {0}   min.vrt: {1}   počet otv: {2}  Cu: {3})";
                vrtanisl.nazev += string.Format(param, paket_vrtani ?? 0, min_vrtak_vrtani ?? 0, pocet_otvoru_vrtani ?? 0, (this.vrtani_cu != null ? this.vrtani_cu.nazev : ""));
            }

            operace vrtaniDRP = vysledek.Where(item => item.operace_id == 18).FirstOrDefault();
            if (vrtaniDRP != null)
            {
                string param = " (min.vrt: {0}   počet otv: {1})";
                vrtaniDRP.nazev += string.Format(param, zapln_min_vrtak ?? 0, zapln_pocet_otv ?? 0);
            }

            operace ostrih = vysledek.Where(item => item.operace_id == 23).FirstOrDefault();
            if (ostrih != null)
            {
                string param = " na rozměr: {0}x{1} mm";

                try
                {
                    ostrih.nazev += string.Format(param, this.OstrihPoVrtaniRorzmerX ?? 0, this.OstrihPoVrtaniRorzmerY ?? 0);
                }
                catch (Exception e)
                {

                }
            }

            operace vytvoreniMotivu = vysledek.Where(item => item.operace_id == 6).FirstOrDefault();
            if (vytvoreniMotivu != null)
            {
                string param = "";
                if (this.reg_multilayer ?? false)
                {
                    param = " registrace multilayer";
                }

                if (this.ObsahujeKod("4A") && (this.olec ?? false))
                {
                    param = " OLEC";
                }

                vytvoreniMotivu.nazev += string.Format(param);
            }

            operace vytvoreniMotivuStd = vysledek.Where(item => item.operace_id == 51).FirstOrDefault();
            if (vytvoreniMotivuStd != null && (this.olec ?? false))
            {
                string param = " OLEC";
                vytvoreniMotivuStd.nazev += string.Format(param);
            }

            operace newprint = vysledek.Where(item => item.operace_id == 86).FirstOrDefault();
            if (newprint != null)
            {
                string param = "\n data: {0} {1}";
                if (this.d_newprint_strana_a.HasValue)
                {
                    vytvoreniMotivuStd.nazev += string.Format(param, this.d_newprint_strana_a, this.uzivatel_newprint_uzivatel_strana_a_id.Inicialy);
                    //newPrintPoradie
                }

                if (this.d_newprint_strana_b.HasValue)
                {
                    vytvoreniMotivuStd.nazev += string.Format(param, this.d_newprint_strana_b, this.uzivatel_newprint_uzivatel_strana_b_id.Inicialy);
                }
            }


            operace fazetovaniLisovna = vysledek.Where(item => item.operace_id == 3000).FirstOrDefault();
            if (fazetovaniLisovna != null)
            {
                string param = " fazetování konektrou na " + this.fazetetovani_lis_hodnota;
                fazetovaniLisovna.nazev += string.Format(param);
            }

            operace fazetovaniFreza = vysledek.Where(item => item.operace_id == 144).FirstOrDefault();
            if (fazetovaniFreza != null)
            {
                string param = " fazetování konektrou na " + this.fazetetovani_freza_hodnota;
                fazetovaniFreza.nazev += string.Format(param);
            }

            operace elektrickyTest = vysledek.Where(item => item.operace_id == 116).FirstOrDefault();
            if (elektrickyTest != null && (this.test_msd ?? false))
            {
                string param = " MSD";
                elektrickyTest.nazev += string.Format(param);
            }

            operace strihani = vysledek.Where(item => item.operace_id == 1).FirstOrDefault();
            if (strihani != null)
            {
                string param = " paket na {0}, paket po {1} ks, osa {2}, cu: {3} ";
                strihani.nazev += string.Format(param, (this.orientace_vrtani != null ? this.orientace_vrtani.nazev : ""), this.paket_vrtani ?? 0, this.osa_vrtani, this.vrtani_cu != null ? this.vrtani_cu.nazev : "");
            }






            if (this.ObsahujeKod("J.") || this.ObsahujeKod("J0") || this.ObsahujeKod("O.") || this.ObsahujeKod("N."))
            {
                foreach (operace kontrolaFP in vysledek.Where(item => item.operace_id == 3001 || item.operace_id == 3002))
                {
                    string param = " {0} {1}";
                    kontrolaFP.nazev += string.Format(param, this.oznaceni_fp_typ != null ? this.oznaceni_fp_typ.nazev : "", this.oznaceni_fp_druh != null ? this.oznaceni_fp_druh.nazev : "");
                    kontrolaFP.poradi += 71;
                }
            }
            else
            {
                foreach (operace kontrolaFP in vysledek.Where(item => item.operace_id == 3001 || item.operace_id == 3002))
                {
                    string param = " {0} {1}";
                    kontrolaFP.nazev += string.Format(param, this.oznaceni_fp_typ != null ? this.oznaceni_fp_typ.nazev : "", this.oznaceni_fp_druh != null ? this.oznaceni_fp_druh.nazev : "");
                    kontrolaFP.poradi += 8;
                }
            }

            if (this.ObsahujeKod("Q"))
            {
                foreach (operace eleTest in vysledek.Where(item => item.operace_id == 76))
                {
                    string param = " {0} {1}";
                    eleTest.nazev += string.Format(param, this.oznaceni_fp_typ != null ? this.oznaceni_fp_typ.nazev : "", this.oznaceni_fp_druh != null ? this.oznaceni_fp_druh.nazev : "");
                    eleTest.poradi += 1027;
                }
            }







            operace laser = vysledek.Where(item => item.operace_id == 2101).FirstOrDefault();
            if (laser != null)
            {
                string param = " {0} {1}";
                laser.nazev += string.Format(param, this.laser_typ != null ? this.laser_typ.nazev : "", this.laser_druh != null ? this.laser_druh.nazev : "");
                laser.nazev += this.oznaceni_fp_druh != null ? this.oznaceni_fp_druh.nazev : "";
            }

            operace galvanickeZlaceni = vysledek.Where(item => item.operace_id == 110).FirstOrDefault();
            if (galvanickeZlaceni != null)
            {
                foreach (motiv vr in this.motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.zlaceni))
                {
                    string param = " ( strana {0} plocha: {1} dm2, strana {2} plocha {3} dm2 )";
                    galvanickeZlaceni.nazev += string.Format(param, vr.vrstva, vr.plocha1, vr.vrstva1, vr.plocha2);
                }
            }

            operace galvanickeMed = vysledek.Where(item => item.operace_id == 55).FirstOrDefault();
            if (galvanickeMed != null)
            {
                foreach (motiv vr in this.motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med))
                {
                    string param = " ( strana {0} plocha: {1} dm2, strana {2} plocha {3} dm2 )";
                    galvanickeMed.nazev += string.Format(param, vr.vrstva, vr.plocha1, vr.vrstva1, vr.plocha2);
                }
            }

            operace celoplosnezlaceni = vysledek.Where(item => item.operace_id == 102).FirstOrDefault();
            if (celoplosnezlaceni != null)
            {
                foreach (motiv vr in this.motivs.Where(i => i.motiv_typ_id == (int)motiv_typ.Value.med))
                {
                    string param = " ( strana {0} plocha: {1} dm2, strana {2} plocha {3} dm2 )";
                    celoplosnezlaceni.nazev += string.Format(param, vr.vrstva, vr.plocha1, vr.vrstva1, vr.plocha2);
                }
            }


            operace narazeneKon = vysledek.Where(item => item.operace_id == 2108).FirstOrDefault();
            if (narazeneKon != null)
            {
                narazeneKon.nazev += this.naraz_kon_poznamka;
            }


            //Leptání alkalické za asistence technologa 
            operace leptaniAlkalikceSTechnolog = vysledek.Where(w => w.operace_id == 67).FirstOrDefault();
            if (leptaniAlkalikceSTechnolog != null && (this.zapln_min_vrtak ?? 0) > 0)
            {
                leptaniAlkalikceSTechnolog.nazev += " - zapl. otvory";
            }












            List<int> frezovaniProkovene = new List<int>() { 904, 2008 };
            foreach (operace frvProk in vysledek.Where(item => frezovaniProkovene.Contains(item.operace_id)))
            {
                //string param = "( paket: {0} )";
                //frvProk.nazev += string.Format(param, prokovene_paket);
            }

            // frezovani f1,f2
            foreach (operace frezovani in vysledek.Where(item => (item.operace_id == 139 || item.operace_id == 138 || item.operace_id == 2102 || item.operace_id == 20040 || item.operace_id == 20041)))
            {

                if (frezovani.operace_id == 139 && this.mustky_id == 1)
                {
                    frezovani.nazev += "+ s můstky";
                    if ((this.zakladni_panel_x ?? 0) > 0)
                    {
                        frezovani.nazev += string.Format("{0}x{1}mm po {2} ks", this.zakladni_panel_x ?? 0, zakladni_panel_y ?? 0, zakladni_panel_suma ?? 0);
                    }
                }

                bool cistefrezovani = true;
                if (this.neprokovene__id.HasValue)
                {

                    int soubortyp = dbContext.soubor_typs.Where(item => item.soubor_typ_id == this.neprokovene__id).First().soubor_typ_id;
                    if (soubortyp == 1)
                    {
                        frezovani.nazev += " paket " + (this.neprokovene_paket ?? 0);
                        frezovani.nazev += " počet otvorů: " + (this.neprok_pocet_otvoru ?? 0);
                    }
                    else
                    {
                        frezovani.nazev += "+ neprok. otvory";
                        frezovani.nazev += " paket " + (this.paket_frezovani ?? 0);
                    }

                    if (soubortyp == 1)
                    {
                        if (this.neprok_otvory_s_kamerou ?? false)
                        {
                            frezovani.nazev += " s kamerou";
                        }
                    }
                    else
                    {
                        if (this.s_kamerou ?? false)
                        {
                            frezovani.nazev += " s kamerou";
                        }

                    }

                    cistefrezovani = false;

                }

                if (this.nepokov_zahl_otvory_id.HasValue)
                {

                    int soubortyp = dbContext.soubor_typs.Where(item => item.soubor_typ_id == this.nepokov_zahl_otvory_id).First().soubor_typ_id;
                    if (soubortyp == 1)
                    {

                        frezovani.nazev += " počet otvorů " + (this.neprok_pocet_otvoru ?? 0);
                    }
                    else
                    {
                        frezovani.nazev += "+ neprok. zahloubené otvory";
                        frezovani.nazev += " paket " + (this.paket_frezovani ?? 0);
                    }

                    if (soubortyp == 1)
                    {
                        if (this.neprok_otvory_s_kamerou ?? false)
                        {
                            frezovani.nazev += " s kamerou";
                        }
                    }
                    else
                    {
                        if (this.s_kamerou ?? false)
                        {
                            frezovani.nazev += " s kamerou";
                        }

                    }

                    cistefrezovani = false;

                }


                if (this.hloubkove_frezovani_id.HasValue)
                {

                    int soubortyp = dbContext.soubor_typs.Where(item => item.soubor_typ_id == this.hloubkove_frezovani_id).First().soubor_typ_id;
                    if (soubortyp == 1)
                    {

                        frezovani.nazev += " paket " + (this.neprokovene_paket ?? 0);
                    }
                    else
                    {
                        frezovani.nazev += "+ neprok. hloubkové frézování";
                        frezovani.nazev += " paket " + (this.paket_frezovani ?? 0);
                    }

                    if (soubortyp == 1)
                    {
                        if (this.hloubkove_frezovani_s_kamerou ?? false)
                        {
                            frezovani.nazev += " s kamerou";
                        }
                    }
                    else
                    {
                        if (this.s_kamerou ?? false)
                        {
                            frezovani.nazev += " s kamerou";
                        }

                    }

                    cistefrezovani = false;

                }

                if (this.frezeovani_pul_otvoru ?? false)
                {
                    frezovani.nazev += " + přefréz. otvorů levotoč. frézou";
                    frezovani.nazev += " dle tech. postupu č. 2";
                    frezovani.nazev += " paket " + (this.paket_frezovani ?? 0).ToString();

                    cistefrezovani = false;
                }

                if (cistefrezovani)
                {
                    if (this.s_kamerou ?? false)
                    {
                        frezovani.nazev += " s kamerou";
                    }
                    frezovani.nazev += " paket " + (this.paket_frezovani ?? 0).ToString();
                }

            }



            // precislovani poradi:

            List<int> kartacovaniMeb = new List<int>() { 77, 79, 78 };

            int pridat = 0;
            for (int i = 1; i < kodSeznamFinal.Count; i++)
            {
                pridat += 1000;
                foreach (operace o in vysledek.Where(item => item.kod.Contains(kodSeznamFinal[i]) && !kartacovaniMeb.Contains(item.operace_id)))
                {
                    o.poradi += pridat;
                }

            }






            if (this.laminace_materialu == true)
            {
                string laminaceDefinice = this.laminace_definice.ToString();
                string[] laminaceDefiniceParse = laminaceDefinice.Split('\n');

                for (int i = 0; i < laminaceDefiniceParse.Count(); i++)
                {
                    operace specialOperation = new operace();
                    specialOperation.kod = "0." + i;
                    specialOperation.nazev = laminaceDefiniceParse[i].ToString();
                    specialOperation.operace_id = 0;
                    specialOperation.poradi = 0;
                    specialOperation.popis = "Extra operace";

                    vysledek.Add(specialOperation);
                }

            }

            this.seznamOperaci = vysledek.Distinct().OrderBy(i => i.poradi).ToList();

        }
    }
}
