using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PCB.Gui
{
    public partial class CheckBoxButtonList : UserControl
    {
        private string selectedItem = "";
        public string SelectedItem
        {
            set
            {
                this.Items.Where(i => i.Code == value).First().Selected = true;
            }
            
            get
            {
                CheckButtonItem item = this.Items.Where(i => i.Selected).FirstOrDefault();
                if (item != null) return item.Code;
                return null;
            }
        }
        public bool RadioButtonMode { get; set; }
        public bool ShowColumnsCode
        {
            get
            {
                return gridColumn2.Visible;
            }

            set
            {
                gridColumn2.Visible = value;
            }
        }



        public CheckButtonItem[] SelectedItems
        {
            get
            {
                return this.Items.Where(i => i.Selected).ToArray();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<CheckButtonItem> Items { get; set; }


        public void RefeshData()
        {
            RefeshData(false);
        }

        public void RefeshData(bool autoFit )
        {
            Items = Items.Where(i=>i.Enabled).ToList();

            bindingSource1.DataSource = Items; 
            
            gridView1.RefreshData();

            if (autoFit)
            {
                gridView1.BestFitColumns();
            }
        }
        
        public CheckBoxButtonList()
        {
            InitializeComponent();
            this.Items = new List<CheckButtonItem>();

        }

        public void AddItem(string code, string name)
        {
            Items.Add(new CheckButtonItem(code, name));
        }

        public void AddItem(CheckButtonItem item)
        {
            Items.Add(item);
        }
                
        public void Remove(CheckButtonItem item)
        {
            this.Items.Remove(item);
        }

        
        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.RadioButtonMode)
            {
                foreach (CheckButtonItem item in this.Items)
                {
                    item.Selected = false;
                }

                gridControl1.RefreshDataSource();
            }
            
            
        }

    }

    public class CheckButtonItem
    {
        public CheckButtonItem (string Code, string Name )
        {
            this.Code = Code;
            this.Name = Name;
            this.Enabled = true;
        }

        public bool Selected { get; set; }
        public bool Enabled { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    

}
