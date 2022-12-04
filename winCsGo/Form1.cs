using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCsGo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atesEt_Click(object sender, EventArgs e)
        {
            if (weaponCombobox.SelectedItem.GetType().GetInterface("IAtesEdilebileible")!=null && weaponCombobox.SelectedItem.GetType().GetInterface("IAtesEdilebileible").Name=="IAtesEdilebileible")
           {
                IAtesEdilebileible atesEt = (IAtesEdilebileible)weaponCombobox.SelectedItem;
                WeaponDesc.Text = atesEt.AtesEt();
            }
            else if (weaponCombobox.SelectedItem.GetType().GetInterface("ISavurabileible").Name == "ISavurabileible")
            {
                ISavurabileible savurAnam = (ISavurabileible)weaponCombobox.SelectedItem;
                WeaponDesc.Text = savurAnam.Savur();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AK47 newAk47 = new AK47();           
            newAk47.Name = "AK47";
            newAk47.AtisGucu = 42;
            newAk47.AtisMesafesi = 200;           
            weaponCombobox.Items.Add(newAk47);
            Haydar newHaydar = new Haydar();
            newHaydar.Name = "Haydarrr";
            newHaydar.AtisGucu = 25;
            newHaydar.AtisMesafesi = 2;
            weaponCombobox.Items.Add(newHaydar);
            Famas newFamas = new Famas();
            newFamas.Name = "Famas";
            newFamas.AtisGucu = 34;
            newFamas.AtisMesafesi = 184;           
            weaponCombobox.Items.Add(newFamas);
            Karambit newKarambit = new Karambit();
            newKarambit.Name = "Karambit Kızıl Ağ";
            newKarambit.AtisGucu = 32;
            newKarambit.AtisMesafesi = 2;
            weaponCombobox.Items.Add(newKarambit);


        }
    }
}
