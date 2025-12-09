using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ileri_Programlama
{
    public partial class Form1 : Form
    {
        // Kaynak yöneticisi tanımla (Dosya adı: Strings)
        ResourceManager resManager;
        CultureInfo culture;

        public Form1()
        {
            InitializeComponent();
            // Resource dosyasının tam yolunu belirtiyoruz (Namespace.DosyaAdi)
            resManager = new ResourceManager("ileri_Programlama.Strings", Assembly.GetExecutingAssembly());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Varsayılan olarak Türkçe seçili gelsin (Index 0: Türkçe, Index 1: İngilizce)
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen dile göre kültürü ayarla
            if (comboBox1.SelectedIndex == 1) // İngilizce
            {
                culture = new CultureInfo("en");
            }
            else // Türkçe (Varsayılan)
            {
                culture = new CultureInfo("tr");
            }

            // Arayüzü güncelle
            DiliGuncelle();
        }

        private void DiliGuncelle()
        {
            try
            {
                // Resx dosyasındaki "Name" kısmını buraya yazıyoruz.
                // Label ve Butonların Text özelliklerini değiştiriyoruz.

                TarihSaatLbl.Text = resManager.GetString("TarihSaatLbl", culture);
                UygulamaDiliLbl.Text = resManager.GetString("UygulamaDiliLbl", culture);
                TemaLbl.Text = resManager.GetString("TemaLbl", culture);

                // Designer dosyasında butonuna 'Kaydet1Lbl' ismini vermişsin:
                Kaydet1Lbl.Text = resManager.GetString("KaydetBtn", culture);

                // Tab (Sekme) İsimlerini de değiştirebilirsin
                tabPage1.Text = resManager.GetString("GenelAyarlarTab", culture);

                // Diğer kontrolleri buraya aynı mantıkla ekleyebilirsin...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dil dosyası okunurken hata oluştu: " + ex.Message);
            }
        }
    }
}