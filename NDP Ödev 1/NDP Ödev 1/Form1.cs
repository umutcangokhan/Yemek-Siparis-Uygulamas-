namespace NDP_Ödev_1

{
    public partial class Form1 : Form
    {

        private Yiyecek s;          // Ödevde belirtilen s ve m
        private Menu m = new Menu();


        // Yiyecek Sınıfı
        public class Yiyecek
        {

            public string Adi;
            public string Cins;
            public double Fiyat;
            public double KdvOrani;


            public Yiyecek()//sıfırlama
            {
                Adi = "";
                Cins = "";
                Fiyat = 0;
                KdvOrani = 0;
            }

            public Yiyecek(string adi, string cins, double fiyat, double kdv) // parametreli kurucu
            {
                Adi = adi;
                Cins = cins;
                Fiyat = fiyat;
                KdvOrani = kdv;
            }

            public string adi => Adi;
            public string cins => Cins;
            public double fiyat => Fiyat;
            public double kdv => KdvOrani;

            public virtual string Yazdir()
            {
                String bilgi = String.Format("{0,-10} {1,-10} {2,10} {3,3} ", Adi, Cins, Fiyat, KdvOrani);

                return bilgi;
            }
        }

        private Yiyecek BilgiAtama()
        {
            string adi = adText.Text;
            string cins = cinsText.Text;
            double fiyat; double.TryParse(fiyatText.Text, out fiyat);
            double kdv; double.TryParse(kdvText.Text, out kdv);
            double kalori; double.TryParse(kaloriText.Text, out kalori);

            int secim = yiyecekComboBox.SelectedIndex;

            switch (secim)
            {
                case 0:
                    return new Meyve(adi, cins, fiyat, kdv, kalori);
                case 1:
                    return new Tatli(adi, cins, fiyat, kdv, kalori);
                case 2:
                    return new Salata(adi, cins, fiyat, kdv, kalori);
                case 3:
                    return new Icecek(adi, cins, fiyat, kdv, kalori);
                default:
                    return null;
            }
        }

        private double paraHesapla()
        {
            double hesap = 0;

            foreach (var yiyecek in m.MenuYaz())
            {
                hesap += yiyecek.Fiyat * (yiyecek.KdvOrani / 100 + 1);
            }

            return hesap;
        }

        private double kaloriHesapla()
        {
            double toplamKalori = 0;

            foreach (var yiyecek in m.MenuYaz())
            {
                if (yiyecek is Icecek icecek) toplamKalori += icecek.Kalori;
                else if (yiyecek is Meyve meyve) toplamKalori += meyve.Kalori;
                else if (yiyecek is Tatli tatli) toplamKalori += tatli.Kalori;
                else if (yiyecek is Salata salata) toplamKalori += salata.Kalori;
            }
            return toplamKalori;
        }
        class Meyve : Yiyecek
        {
            public double Kalori;


            public Meyve()
            {
                Adi = "";
                Cins = "";
                Fiyat = 0;
                Kalori = 0;
                KdvOrani = 0;
            }

            public Meyve(string adi, string cins, double fiyat, double kdv, double kalori) : base(adi, cins, fiyat, kdv)
            {
                Adi = adi;
                Cins = cins;
                Fiyat = fiyat;
                KdvOrani = kdv;
                Kalori = kalori;
            }

            public override string Yazdir()
            {
                String bilgi = String.Format("Meyve    {0,-10}   {1,-10}   {2,8}₺    %{3, 3}    {4,4}cal ", Adi, Cins, Fiyat, KdvOrani, Kalori);
                return bilgi;
            }

        }

         class Salata : Yiyecek
        {
            public double Kalori;

            public double kalori => Kalori;

            public Salata()
            {
                Adi = "";
                Cins = "";
                Fiyat = 0;
                Kalori = 0;
                KdvOrani = 0;
            }

            public Salata(string adi, string cins, double fiyat, double kdv, double kalori) : base(adi, cins, fiyat, kdv)
            {
                Adi = adi;
                Cins = cins;
                Fiyat = fiyat;
                KdvOrani = kdv;
                Kalori = kalori;
            }

            public override string Yazdir()
            {
                String bilgi = String.Format("Salata    {0,-10}   {1,-10}   {2,8}₺    %{3, 3}    {4,4}cal", Adi, Cins, Fiyat, KdvOrani, Kalori);
                return bilgi;
            }

        }

        class Tatli : Yiyecek
        {
            public double Kalori;

            public double kalori => Kalori;

            public Tatli()
            {
                Adi = "";
                Cins = "";
                Fiyat = 0;
                Kalori = 0;
                KdvOrani = 0;
            }

            public Tatli(string adi, string cins, double fiyat, double kdv, double kalori) : base(adi, cins, fiyat, kdv)
            {
                Adi = adi;
                Cins = cins;
                Fiyat = fiyat;
                KdvOrani = kdv;
                Kalori = kalori;
            }

            public override string Yazdir()
            {
                String bilgi = String.Format("Tatlı    {0,-10}   {1,-10}   {2,8}₺    %{3, 3}    {4,4}cal ", Adi, Cins, Fiyat, KdvOrani, Kalori);
                return bilgi; 
            }

        }

        class Icecek : Yiyecek
        {
            public double Kalori;

            public double kalori => Kalori;

            public Icecek()
            {
                Adi = "";
                Cins = "";
                Fiyat = 0;
                Kalori = 0;
                KdvOrani = 0;
            }

            public Icecek(string adi, string cins, double fiyat, double kdv, double kalori) : base(adi, cins, fiyat, kdv)
            {
                Adi = adi;
                Cins = cins;
                Fiyat = fiyat;
                KdvOrani = kdv;
                Kalori = kalori;
            }

            public override string Yazdir()
            {
                String bilgi = String.Format("İçecek    {0,-10}   {1,-10}   {2,8}₺    %{3, 3}    {4,4}cal ", Adi, Cins, Fiyat, KdvOrani, Kalori);
                return bilgi;
            }

        }

        public class Menu
        {

            private List<Yiyecek> list = new List<Yiyecek>();

            public void Ekle(Yiyecek ekle)
            {
                list.Add(ekle);
            }

            public void Sil(int sil)
            {
                list.RemoveAt(sil);
            }

            public List<Yiyecek> MenuYaz() { return list; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
     
            if (!DegerlerGecerliMi())
            {
                return; // Hatalıysa işlemi durdur
            }

            s = BilgiAtama();

            m.Ekle(s);

            MessageBox.Show($"{s.Adi} Başarıyla Eklendi. Yazdıra basarak eklediklerinizi görüntüleyebilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public bool DegerlerGecerliMi()
        {
            bool hata = false;


            if (yiyecekComboBox.SelectedItem == null)
            { 
                MessageBox.Show("Lütfen yiyecek seçiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                hata = true;
            }

            else if (string.IsNullOrWhiteSpace(adText.Text)) 
            {
                MessageBox.Show("Lütfen bir yiyecek adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hata = true; 
            }

            else if (string.IsNullOrWhiteSpace(cinsText.Text)) 
            {
                MessageBox.Show("Lütfen yiyeceğin cinsini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                hata = true; 
            }

            else if (string.IsNullOrWhiteSpace(fiyatText.Text)) 
            { MessageBox.Show("Lütfen fiyat bilgisi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                hata = true; 
            }

            else if (!double.TryParse(fiyatText.Text, out double fiyat) || fiyat < 0) 
            {
                MessageBox.Show("Lütfen geçerli bir fiyat bilgisi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                hata = true; 
            }

            else if (string.IsNullOrWhiteSpace(kdvText.Text)) 
            {
                MessageBox.Show("Lütfen KDV oranını giriniz. % (0-100 arası)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                hata = true; 
            }

            else if (!double.TryParse(kdvText.Text, out double kdv) || kdv < 0 || kdv > 100)
            {
                MessageBox.Show("Lütfen geçerli bir KDV oranı giriniz. % (0-100 arası)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                hata = true;
            }

            else if (string.IsNullOrWhiteSpace(kaloriText.Text)) { MessageBox.Show("Lütfen bir kalori miktarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); hata = true; }

            else if (!double.TryParse(kaloriText.Text, out double kalori) || kalori < 0) { MessageBox.Show("Lütfen geçerli bir kalori miktarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); hata = true; }


            return !hata;
        }

        private void yazdirButton_Click(object sender, EventArgs e)
        {
            if (m.MenuYaz().Count == 0) MessageBox.Show("Sipariş listesini görebilmek için lütfen ürün ekleyin.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.Items.Clear();
            foreach (var yiyecek in m.MenuYaz())
            {
                listBox1.Items.Add(yiyecek.Yazdir());
            }
            paraText.Text = $"{Math.Round(paraHesapla(), 2)} ₺    {Math.Round(kaloriHesapla(), 2)} cal";


        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var silinecekValue = listBox1.SelectedIndex;
            m.Sil(silinecekValue);
            listBox1.Items.RemoveAt(silinecekValue);

            paraText.Text = $"{Math.Round(paraHesapla(), 2)}₺   {Math.Round(kaloriHesapla(), 2)}cal";
        }
    }

}

