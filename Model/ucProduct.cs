using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeeling_Ka.Model
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;
        
        public int id { get; set; }
        
        public string PPrice 
        {  
            get { return lblPrice.Text; } 
            set { lblPrice.Text = value; }
        }
        
        public string PCategory {  get; set; }
        
        public string PName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private void productclick(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
