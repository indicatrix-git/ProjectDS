using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using PCB.Data;
using PCB.Data.CustomObjects;
using PCB.Gui;
using pcb_develModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCB.Base
{
    public partial class frmBaseDetail : frmBase
    {

        #region data
        public bool isValid = false;
        public enum mode { editace, novy }
        public mode FormMode { get; set; }
        #endregion

        public frmBaseDetail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region metody

        /// <summary>
        /// validace
        /// </summary>
        public virtual void Valid() //valid pro ostatni typy ulozeni
        {
            List<ValidationResult> result = new List<ValidationResult>();
            if (!Validator.TryValidateObject(this.entityObject, new ValidationContext(this.entityObject, null, new Dictionary<object, object>
            {
                { "Db", this.DBContext },
            }), result, true))
            {
                List<string> ls = new List<string>();

                foreach (ValidationResult r in result)
                {
                    ls.Add(r.ErrorMessage);
                }


                if (result.Count > 0)
                {
                    frmHlaseniChyb frm = new frmHlaseniChyb();
                    frm.Data = ls;
                    frm.ShowDialog();
                }
            }

            this.isValid = (result.Count == 0);
        }


        /// <summary>
        /// validace bez duplicity
        /// </summary>
        /// <param name="typAkce"></param>
        public virtual void Valid(frmProduktDetail.ProduktAkce typAkce)
        {
            List<ValidationResult> result = new List<ValidationResult>();
            if (!Validator.TryValidateObject(this.entityObject, new ValidationContext(this.entityObject, null, new Dictionary<object, object>
            {
                { "Db", this.DBContext },
            }), result, true))
            {
                List<string> ls = new List<string>();

                
                if(result.Count >= 0)
                {
                    int i = 0;
                    foreach (ValidationResult r in result)
                    {
                        ls.Add(r.ErrorMessage);

                        try
                        {
                            if (ls[i].Equals("Duplicitní název"))
                            {
                                ls.Remove("Duplicitní název");
                            }
                        } catch(Exception p) { }
                        i++;
                    }
                }
                

                if (result.Count > 0)
                {
                    frmHlaseniChyb frm = new frmHlaseniChyb();
                    frm.Data = ls;

                    if (ls.Count == 0)
                    {
                        result.Clear();
                    }
                    else
                    {
                        frm.ShowDialog();
                    }
                }
            }

            this.isValid = (result.Count == 0);
        }


        /// <summary>
        /// automaticke readolny nad vsemi prvky
        /// </summary>
        /// <param name="cs"></param>
        public virtual void setReadonly(Control.ControlCollection cs)
        {
            if (this.PravaIgnore)
            {
                return;
            }

            foreach (object c in cs)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).ReadOnly = true;
                }

                if (c is IconHolder)
                {
                    ((IconHolder)c).VisiblePridat = false;
                    ((IconHolder)c).VisibleOdstranit = false;
                }

                if (c is ButtonEdit)
                {
                    ((ButtonEdit)c).ReadOnly = true;
                    ((ButtonEdit)c).Properties.Buttons.Clear();
                }

                if (c is CheckedListBoxControl)
                {
                    ((CheckedListBoxControl)c).Enabled = false;
                }

                if (c is CheckEdit)
                {
                    ((CheckEdit)c).ReadOnly = true;
                }

                if (c is LookUpEdit)
                {
                    ((LookUpEdit)c).ReadOnly = true;
                }

                if (c is System.Windows.Forms.ComboBox)
                {
                    ((System.Windows.Forms.ComboBox)c).Enabled = false;
                }

                if (c is System.Windows.Forms.CheckBox)
                {
                    ((System.Windows.Forms.CheckBox)c).Enabled = false;
                }

                if (c is XtraTabControl || c is XtraTabPage || c is Panel || c is GroupBox || c is GroupControl)
                {
                    setReadonly(((Control)c).Controls);
                }

                if (c is RadioGroup)
                {
                    ((RadioGroup)c).ReadOnly = true;
                }

                if (c is GridControl)
                {
                    for (int counter = 0; counter < ((GridControl)c).ViewCollection.Count; counter++)
                    {
                        if (((GridControl)c).ViewCollection[counter].GetType() == typeof(GridView))
                        {
                            GridView gv = ((GridControl)c).ViewCollection[counter] as GridView;
                            gv.OptionsBehavior.ReadOnly = true;
                            gv.OptionsBehavior.Editable = false;

                            foreach (GridColumn col in gv.Columns)
                            {
                                col.RealColumnEdit.ReadOnly = true;
                            }
                        }
                    }
                                        
                }

                if (c is SimpleButton)
                {
                  ((SimpleButton)c).Enabled = false;
                }

                if (c is PanelControl)
                {
                    setReadonly(((PanelControl)c).Controls);
                }


            }
        }
        

        /// <summary>
        /// ulozeni dat
        /// </summary>
        public virtual void SaveData()
        {
            DBContext.SaveChanges();
        }

        #endregion

        #region Ulozit, Storno

        /// <summary>
        /// Ulozit - extra special
        /// </summary>
        public void UlozitKontakt()
        {
            this.Valid();

            if (isValid)
            {
                Cursor.Current = Cursors.WaitCursor;
                this.SaveData();
                Cursor.Current = Cursors.Default;
            }
        }



        /// <summary>
        /// Ulozit - vseobecne (ponechane jen z duvodu ostatnich vazeb v celem systemu)
        /// </summary>
        public void Ulozit()
        {
            this.Valid();

            if (isValid)
            {
                Cursor.Current = Cursors.WaitCursor;
                this.SaveData();
                Cursor.Current = Cursors.Default;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }   
        }


        /// <summary>
        /// Ulozit - s konkretnym typem akce (jen pro DPS a Sablony)
        /// </summary>
        /// <param name="typAkce"></param>
        public void Ulozit(frmProduktDetail.ProduktAkce typAkce)
        {
            this.Valid(typAkce);

            if (isValid)
            {
                Cursor.Current = Cursors.WaitCursor;
                this.SaveData();
                Cursor.Current = Cursors.Default;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        public void Storno()
        {
            Close();
        }


        protected void base_number_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            if (string.IsNullOrEmpty((e.Value ?? "").ToString()))
            {
                string name = ((BaseEdit)sender).DataBindings[0].BindingMemberInfo.BindingField;

                System.Reflection.PropertyInfo p = this.entityObject.GetType().GetProperty(name);
                p.SetValue(this.entityObject, null, null);
            }
            else
            {
                string name = ((BaseEdit)sender).DataBindings[0].BindingMemberInfo.BindingField;

                System.Reflection.PropertyInfo p = this.entityObject.GetType().GetProperty(name);
                p.SetValue(this.entityObject, Convert.ToDecimal(e.Value.ToString().Replace(".", ",")), null);
            }
        }

        protected void base_int_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            if (string.IsNullOrEmpty((e.Value ?? "").ToString()))
            {
                string name = ((BaseEdit)sender).DataBindings[0].BindingMemberInfo.BindingField;

                System.Reflection.PropertyInfo p = this.entityObject.GetType().GetProperty(name);
                p.SetValue(this.entityObject, null, null);

            }
            else
            {
                string name = ((BaseEdit)sender).DataBindings[0].BindingMemberInfo.BindingField;

                System.Reflection.PropertyInfo p = this.entityObject.GetType().GetProperty(name);
                p.SetValue(this.entityObject, Convert.ToInt32(e.Value.ToString()), null);
            }
        }


        #endregion

        #region LoadData

        public override void LoadData(EntityObject entity)
        {
            Cursor.Current = Cursors.WaitCursor;
            base.LoadData(entity);
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Show Detail

        public DialogResult ShowDetail(frmBase parent, EntityObject entityObject)
        {
            return ShowDetail(parent, entityObject, null);
        }

        public DialogResult ShowDetail(frmBase parent, EntityObject entityObject, pcb_develEntities db)
        {
            this.ParentFormBase = parent;
            if (this.FormMode != mode.novy)
            {
                this.FormMode = mode.editace;
            }

            if (db == null)
            {
                this.dbContext = parent.DBContext;
            }
            else
            {
                this.dbContext = db;
            }

            this.entityObject = entityObject;
            this.Hide(); 

            this.LoadData(null);

            setReadonly(this.Controls);

            return this.ShowDialog(this.ParentFormBase);
        }
        public DialogResult ShowDetailNovy(frmBase parent)
        {
            this.ParentFormBase = parent;
            this.FormMode = mode.novy;
            this.dbContext = parent.DBContext;
           // bwLoad.RunWorkerAsync();

            //frmLoad = new frmWait();
            //frmLoad.StartPosition = FormStartPosition.CenterScreen;
            //frmLoad.ShowDialog(this);

            this.LoadData(null);

            return this.ShowDialog(this.ParentFormBase);

        }
        #endregion

    }
}
