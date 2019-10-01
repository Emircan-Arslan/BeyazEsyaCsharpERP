using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;




namespace BEYAZ_EŞYA
{
    class islem
    {
        
       
      
        
        MySqlConnection baglan;
        MySqlDataAdapter data;
        MySqlDataReader dr;
        public DataTable tablo;


        //giriş ekranı
        public Boolean giris(string kad, string sifre)//giriş için gereken metot.
        {
           
            bool onay = false; //onay değişkeni atadım false değerini verdin eğer kişi oğru girerse asağıdaki gibi true değerini döndürdüm.
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand komut = new MySqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "SELECT * FROM admin where k='" + kad + "' AND sifre='" + sifre + "'";
            //buruada giriş yapabilmesi için gerekli sql şartını yazdım.
            komut.ExecuteNonQuery();
            dr = komut.ExecuteReader();
            if((dr.Read()))//burada yzdığımız şartı "read" ile okuduk eğer bilgiler uyuşuyorda true değerini atadım.
            {
                onay = true;
               
            }
            baglan.Close();
            baglan.Dispose();
            return onay;           
        }




        //şifremi unuttum 
        public String sifreunuttum (string kad, string email,string tel)
        {
             baglan= new MySqlConnection(baglanti.bag);
              MySqlCommand komut = new MySqlCommand();
              baglan.Open();
              komut.CommandText = "select sifre from admin where k='" + kad + "' and eposta='" + email + "'and tel='" + tel + "'";
             //veri tabanından seçme sartımızı oluşturdum girilen bilgiler doğruysa kişini şifresini bize vericek.
                komut.Connection = baglan;

              string bilgi = komut.ExecuteScalar().ToString(); 
              // burada veri tabanından çektiğimiz bilgiyi geriye dönüre bilmek için değişkene atadım.
                baglan.Close(); 
              return bilgi;  
        }



        // ürün ekleme 
        public void kayit(string urunturu, string marka, string enerjısinifi, string urunrengı, string model, double fıyat, string yukseklık, string derınlık, string genıslık, string hacım, int adet,string tarıh,string resım,string f)
        {
            File.Copy(f, @"C:\wamp64\www\beyazesya\" + resım);
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand komut = new MySqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into urun (utur,marka,esinif,ureng,model,fiyat,yukseklik,derinlik,genislik,hacim,adet,date,resım) values ('" + urunturu + "','" + marka + "','" + enerjısinifi + "','" + urunrengı + "','" + model + "','" + fıyat + "','" + yukseklık + "','" + derınlık + "','" + genıslık + "','" + hacım + "','" + adet + "','" + tarıh + "','" + resım + "')";
            komut.ExecuteNonQuery();
            baglan.Close();
            // File.Copy(f,Application.StartupPath + @"\resım\" + resım);//eklediğim resmin kopyasını aynı zamanda debug klasörüne kayıt ediyorum. 
            
        }


        //müşteri ekleme 
        public void musterı(string ad, string soyad, string tel, string ıl, string ılce, string semt)
        {
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand komut = new MySqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into musterı (mad,msoyad,mtel,mil,milce,msemt) values ('" + ad + "','" + soyad + "','" + tel + "','" + ıl + "','" + ılce + "','" + semt + "')";
            komut.ExecuteNonQuery();
            baglan.Close();
             

        }



        //ürün silme  komutu 
        public void sill(string n)
        {
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand sil = new MySqlCommand();
            sil.Connection = baglan;
            sil.CommandText = "delete from urun where model=@no";
            string no = n;
            sil.Parameters.AddWithValue("@no", no);
            baglan.Open();
            sil.ExecuteNonQuery();
            baglan.Close();
        }


        //müşteri silme 
        public void musterısill(string tell)
        {
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand sil = new MySqlCommand();
            sil.Connection = baglan;
            sil.CommandText = "delete from musterı where mtel=@tel";
            string no = tell;
            sil.Parameters.AddWithValue("@tel", no);
            baglan.Open();
            sil.ExecuteNonQuery();
            baglan.Close();
        }



        //ürün güncelleme 
        public void guncelle(string urunturu, string marka, string enerjısinifi, string urunrengı, double fıyat, string yukseklık, string derınlık, string genıslık, string hacım, int adet, DateTime tarıh,string model)
        {
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand guncelle = new MySqlCommand();
            guncelle.Connection = baglan;
            guncelle.CommandText= "update urun set utur=@urunturu,marka=@marka,esinif=@enerjisinifi,ureng=@urunrengi,fiyat=@fiyatt,yukseklik=@yükseklikk,derinlik=@derinlikk,genislik=@genislikk,hacim=@hacimm,adet=@adett,date=@tarih where  model=@modell";
            string ur = urunturu;
            string mar = marka;
            string er = enerjısinifi;
            string urn = urunrengı;
            double f = fıyat;
            string y = yukseklık;
            string d = derınlık;
            string g = genıslık;
            string h = hacım;
            int a = adet;
            DateTime tar = tarıh;
            string m = model;
            guncelle.Parameters.AddWithValue("@urunturu", ur);
            guncelle.Parameters.AddWithValue("@marka", mar);
            guncelle.Parameters.AddWithValue("@enerjisinifi", er);
            guncelle.Parameters.AddWithValue("@urunrengi", urn);
            guncelle.Parameters.AddWithValue("@fiyatt", f);
            guncelle.Parameters.AddWithValue("@yükseklikk", y);
            guncelle.Parameters.AddWithValue("@derinlikk", d);
            guncelle.Parameters.AddWithValue("@genislikk", g);
            guncelle.Parameters.AddWithValue("@hacimm", h);
            guncelle.Parameters.AddWithValue("@adett", a);
            guncelle.Parameters.AddWithValue("@tarih", tar);
            guncelle.Parameters.AddWithValue("@modell", m);
            baglan.Open();
            guncelle.ExecuteNonQuery();
            baglan.Close();

        }

        //satış ürün adet güncelle 
        public void satısguncelle(int adet , string model)
        {
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand satısguncelle = new MySqlCommand();
            satısguncelle.Connection = baglan;
            satısguncelle.CommandText = "update urun set adet=adet-@ad where  model=@mo ";
            int a = adet;
            string m = model;
            satısguncelle.Parameters.AddWithValue("@ad", a);
            satısguncelle.Parameters.AddWithValue("@mo", m);
            baglan.Open();
            satısguncelle.ExecuteNonQuery();
            baglan.Close();

        }

        //SATIŞ TABLOSUNA  EKLEME 
        public void satısekle(string urunmodel, int adet, double fıyat, string musterıtel,string tur)
        {
            baglan = new MySqlConnection(baglanti.bag);
            MySqlCommand komut = new MySqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into satis (umodel,adet,ufiyat,mtel,tur) values ('" + urunmodel + "','" + adet + "','" + fıyat + "','" + musterıtel + "','" + tur + "')";
            komut.ExecuteNonQuery();
            baglan.Close();


        }



        //texte girilene göre arama  metodu 
        public void arama (string model )
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select utur,marka,esinif,ureng,model,fiyat,yukseklik,derinlik,genislik,hacim,adet,date from urun where model Like '" + model + "%'", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();


        }
        //ürüntürene  gore arama 
        public void turarama( string tur)
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select utur,marka,esinif,ureng,model,fiyat,yukseklik,derinlik,genislik,hacim,adet,date from urun where utur Like '" + tur + "%'", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }

        //Müsteri arama 
        public void muara(string tel)
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select mad,msoyad,mtel,mil,milce,msemt from musteri where mtel Like '" + tel + "%'", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }



        //haber listeleme
        public void haberlist()
        {
            baglan= new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select utur,marka,model,adet from urun", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }
        

        //yazdırma işlemindeki listeleme 
        public void yazdırlist()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select utur,marka,esinif,ureng,model,fiyat,yukseklik ,derinlik,genislik,hacim,adet,date from urun", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }


        //güncelle sil listeleme 
        public void güncelle_sıl()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select utur,marka,esinif,ureng,model,fiyat,yukseklik,derinlik,genislik,hacim,adet,date from urun", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }

        //müşteri listeleme 
        public void musterılist()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select mad,msoyad,mtel,mil,milce,msemt,tur from musteri", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }

        //azalan stoğu gösterme 
        public void azalanstok()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select utur,marka,esinif,ureng,model,adet  from urun where adet < 5 ", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }
        //haber satış listemele
        public void sonsatıs()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select umodel,adet,ufiyat,mtel,tur  from satis ORDER BY id DESC ", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }
        //SATIŞ FORMUNDAKİ DATA GRİD İÇİN 
        public void satıslıst()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select utur,marka,esinif,ureng,model,fiyat,yukseklik,derinlik,genislik,hacim,adet,date from urun", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }

        //TOPLAM SATIŞ FORMU İÇİN 
        public void topsatıs()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select  count(adet) from satis", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            baglan.Close();
        }
        public void topfıyat()
        {
            baglan = new MySqlConnection(baglanti.bag);
            baglan.Open();
            data = new MySqlDataAdapter("select  sum(ufiyat) from satis", baglan);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
           
           
        }
    }
}      