using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ileri_Programlama
{
    public partial class Form1 : Form
    {
        // Kaynak yöneticisi
        ResourceManager resManager;
        CultureInfo culture;

        public Form1()
        {
            InitializeComponent();
            // Resource dosya yolunu doğru yazdığından emin ol (Namespace.DosyaAdi)
            resManager = new ResourceManager("ileri_Programlama.Strings", Assembly.GetExecutingAssembly());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Varsayılan dil Türkçe (ComboBox'ta ilk sırada Türkçe var varsayıyoruz)
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0: Türkçe, 1: İngilizce
            if (comboBox1.SelectedIndex == 1)
            {
                culture = new CultureInfo("en");
            }
            else
            {
                culture = new CultureInfo("tr");
            }

            DiliGuncelle();
        }

        private void DiliGuncelle()
        {
            try
            {
                // ---------------- TAB 1: GENEL AYARLAR ----------------
                tabPage1.Text = resManager.GetString("Tab_Genel", culture);
                UygulamaDiliLbl.Text = resManager.GetString("Lbl_Dil", culture);
                TarihSaatLbl.Text = resManager.GetString("Lbl_Tarih", culture);
                uzunlukBirimiLbl.Text = resManager.GetString("Lbl_Uzunluk", culture);
                AğrlıkBirimiLbl.Text = resManager.GetString("Lbl_Agirlik", culture);
                TemaLbl.Text = resManager.GetString("Lbl_Tema", culture);
                Kaydet1Lbl.Text = resManager.GetString("Btn_Kaydet", culture);

                // ---------------- TAB 2: CİHAZ AYARLARI ----------------
                tabPage2.Text = resManager.GetString("Tab_Cihaz", culture);
                label6.Text = resManager.GetString("Lbl_MinHiz", culture);
                label8.Text = resManager.GetString("Lbl_MaxHiz", culture);
                label7.Text = resManager.GetString("Lbl_Timeout", culture);
                label9.Text = resManager.GetString("Lbl_OtoHome", culture);
                button2.Text = resManager.GetString("Btn_Kaydet", culture); // Ortak Kaydet butonu

                // ---------------- TAB 3: GÜVENLİK AYARLARI ----------------
                tabPage3.Text = resManager.GetString("Tab_Guvenlik", culture);
                label10.Text = resManager.GetString("Lbl_OturumSure", culture);
                label11.Text = resManager.GetString("Lbl_HataliGiris", culture);
                label12.Text = resManager.GetString("Lbl_SifrePolitika", culture);
                button3.Text = resManager.GetString("Btn_Kaydet", culture);

                // ---------------- TAB 4: VERİTABANI AYARLARI ----------------
                tabPage4.Text = resManager.GetString("Tab_Veritabani", culture);
                label15.Text = resManager.GetString("Lbl_YedekKlasor", culture);
                button5.Text = resManager.GetString("Btn_Sec", culture);
                label14.Text = resManager.GetString("Lbl_LogTemizleme", culture);
                label13.Text = resManager.GetString("Lbl_OtoYedek", culture);
                button4.Text = resManager.GetString("Btn_Kaydet", culture);

                // ---------------- TAB 5: MOBİL İZİNLER ----------------
                tabPage5.Text = resManager.GetString("Tab_Mobil", culture);
                label21.Text = resManager.GetString("Lbl_Roller", culture);
                label28.Text = resManager.GetString("Lbl_MobilUyg", culture);

                // Checkbox yanındaki labelları veya checkbox textlerini güncelleme:
                // Designer'a baktığımda textler Label içinde duruyor (örn: label22 Admin)
                label22.Text = resManager.GetString("Chk_Admin", culture);
                label23.Text = resManager.GetString("Chk_Operator", culture);
                label24.Text = resManager.GetString("Chk_Servis", culture);

                label27.Text = resManager.GetString("Chk_Terapi", culture);
                label26.Text = resManager.GetString("Chk_Durdur", culture);
                label25.Text = resManager.GetString("Chk_Vinc", culture);

                label30.Text = resManager.GetString("Lbl_AyakNo", culture);
                label29.Text = resManager.GetString("Lbl_AgirlikAzalt", culture);
                button8.Text = resManager.GetString("Btn_Kaydet", culture);

                // ---------------- TAB 6: E-POSTA AYARLARI ----------------
                tabPage6.Text = resManager.GetString("Tab_Eposta", culture);
                label16.Text = resManager.GetString("Lbl_Smtp", culture);
                label17.Text = resManager.GetString("Lbl_Gonderen", culture);
                label18.Text = resManager.GetString("Lbl_Sifre", culture);
                label19.Text = resManager.GetString("Lbl_Port", culture);
                label20.Text = resManager.GetString("Lbl_Ssl", culture);

                button6.Text = resManager.GetString("Btn_Test", culture);
                button7.Text = resManager.GetString("Btn_Kaydet", culture);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dil dosyası okunurken hata oluştu: " + ex.Message);
            }
        }
    }
}