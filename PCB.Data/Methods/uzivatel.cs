using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace pcb_develModel
{
    public partial class uzivatel
    {
        /// <summary>
        /// nacete jeho dodeleni
        /// </summary>
        /// <param name="DBContext"></param>
        public void LoadOddeleni(pcb_develEntities DBContext)
        {
            List<oddeleni> lsOddeleni = DBContext.oddelenis.ToList();
            foreach (oddeleni o in lsOddeleni)
            {
                if (this.uzivatel_oddelenis.FirstOrDefault(i => i.oddeleni_id == o.oddeleni_id) != null)
                {
                    o.Vybrano = true;
                }
                else
                {
                    o.Vybrano = false;
                }
            }
        }

        /// <summary>
        ///  zakodovani md5
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// prihlasi uzivatele
        /// </summary>
        /// <param name="osobniCislo"></param>
        /// <param name="password"></param>
        /// <param name="dbcontext"></param>
        /// <returns></returns>
        public static uzivatel Prihlasit(string osobniCislo, string password)
        {
            pcb_develEntities db = new pcb_develEntities();
            uzivatel uzivatel = db.uzivatels.Where(i => i.osobni_cislo == osobniCislo).FirstOrDefault();

            if (uzivatel == null)
            {
                return null;
            }

            if (MD5Hash(password) != uzivatel.heslo)
            {
                return null;
            }

            return uzivatel;
        }

        /// <summary>
        /// overeni prav
        /// </summary>
        /// <param name="pravo"></param>
        /// <returns></returns>
        public prava_hodnota.Value HasPravo(prava.Value pravo)
        {
            prava_hodnota.Value hodnota = prava_hodnota.Value.zadne;

            prava_role pravoRole = this.role.prava_roles.Where(i => i.prava_id == (int)pravo).FirstOrDefault();

            if (pravoRole != null)
            {
                hodnota = (prava_hodnota.Value)pravoRole.prava_hodnota_id;
            }

            prava_uzivatel pravoUzivatel = this.prava_uzivatels.Where(i => i.prava_id == (int)pravo).FirstOrDefault();

            if (pravoUzivatel != null)
            {
                if ((int)hodnota < pravoUzivatel.prava_hodnota_id)
                {
                    hodnota = (prava_hodnota.Value)pravoUzivatel.prava_hodnota_id;
                }
            }

            return hodnota;
        }

        /// <summary>
        /// ziska pridelana prava s ohledem na role
        /// </summary>
        /// <param name="dbcontext"></param>
        /// <returns></returns>
        public List<prava_uzivatel> GetPravaUzivatel(pcb_develEntities dbcontext)
        {
            if (this.role != null)
            {
                foreach (prava p in dbcontext.pravas)
                {
                    prava_uzivatel pravaUziv = this.prava_uzivatels.Where(i => i.prava_id == p.prava_id).FirstOrDefault();
                    if (pravaUziv == null)
                    {
                        prava_uzivatel pravaUzivNew = new prava_uzivatel();
                        pravaUzivNew.prava = p;
                        pravaUzivNew.uzivatel = this;

                        prava_role pravaRole = this.role.prava_roles.Where(i => i.prava_id == p.prava_id).FirstOrDefault();
                        if (pravaRole == null)
                        {
                            pravaUzivNew.role_prava_hodnota = dbcontext.prava_hodnotas.Where(i => i.prava_hodnota_id == (int)prava_hodnota.Value.zadne).First();
                        }
                        else
                        {
                            pravaUzivNew.role_prava_hodnota = this.role.prava_roles.Where(i => i.prava_id == p.prava_id).First().prava_hodnota;
                        }

                        pravaUzivNew.prava_hodnota = dbcontext.prava_hodnotas.Where(i => i.prava_hodnota_id == (int)prava_hodnota.Value.zadne).FirstOrDefault();
                        this.prava_uzivatels.Add(pravaUzivNew);
                    }
                    else
                    {
                        var prava = this.role.prava_roles.Where(i => i.prava_id == p.prava_id).FirstOrDefault();
                        if (prava != null)
                        {
                            pravaUziv.role_prava_hodnota = prava.prava_hodnota;
                        }
                        
                    }
                }
            }
            return this.prava_uzivatels.ToList();
        }
    }
}
