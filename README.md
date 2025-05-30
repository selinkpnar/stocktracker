StockTracker – Kurulum ve Kullanım Kılavuzu
1. Sistem Gereksinimleri
- Windows 10/11 işletim sistemi
- Visual Studio 2022 (veya uyumlu bir IDE)
- SQL Server (2019 veya üzeri)
- NET Framework 4.7.2 veya üzeri
- Google Cloud hesabı (Vision API için)
- El terminali (isteğe bağlı)
A. Programlama Dilleri
-C# (.NET Framework)
-Python 3.x
-SQL

B. C# Modülleri
-Windows Forms
-SQL Connection
-System.Data
-DataSet ve DataTable yapıları
-User Controls

C. Python Modülleri
-Flask
-SQLAlchemy
-Requests
-pyodbc kütüphanesi

D. Kütüphaneler
- Windows Forms
-Flask Framework
-SQLAlchemy
-System.Data.SqlClient

E. Diğer
-TCP/IP Soket Programlama
-JSON Veri Transferi

2. Proje Modülleri
A. Stok Takip Modülü
İşletmelerin envanter kontrolünü sağlıklı ve anlık olarak yürütebilmesini sağlayan temel modüldür.
•	Ürün Giriş-Çıkış İşlemleri: Manuel ya da görüntü işleme destekli stok hareketleri.
•	Minimum Stok Seviyesi Takibi: Kritik seviye altına inen ürünler için uyarı mekanizması.
•	Kategori Bazlı Ürün Yönetimi: Ürünleri sınıflandırarak erişim ve raporlamayı kolaylaştırır.
•	Barkod ile Hızlı İşlem Yapma: Barkod okutma ile ürün tanıma ve işlem hızlandırma.
B. Müşteri Yönetim Modülü
Müşteri ilişkilerini merkezi bir yapıda yöneten bu modül, satış sonrası takip ve analiz imkanı sunar.
•	Müşteri Kayıt ve Takibi: Yeni müşteri ekleme, düzenleme ve arşivleme.
•	Müşteri Bazlı Satış Geçmişi: Her müşterinin geçmiş satın alımlarının takibi.
•	İletişim Bilgileri Yönetimi: Telefon, e-mail, adres gibi bilgilerin sistematik saklanması.
C. El Terminali Modülü
Depo personelinin sahada daha hızlı ve doğru işlem yapabilmesi için geliştirilmiş mobil web arayüzüdür.
•	Barkod Okuma ile Hızlı İşlem: Ürünleri doğrudan barkod okuyucu ile tanıma.
•	Offline Çalışabilme Özelliği: Bağlantı kesilse dahi geçici verilerin saklanabilmesi.
•	Gerçek Zamanlı Stok Güncelleme: Anında veritabanına işlenen stok hareketleri.
•	Mobil Stok Sayım İmkanı: Depo envanteri yerinde sayılabilir.
D. Raporlama Modülü
İşletmenin geçmişe dönük veri analizi yapmasını sağlayan, karar alma süreçlerini destekleyen modüldür.
•	Stok Durumu Raporları: Anlık ve geçmiş stok bilgileri.
•	Satış Analizleri: Ürün ve dönem bazlı satış performansları.
•	Müşteri Bazlı Raporlar: En çok alışveriş yapan müşteriler, işlem hacmi vs.
•	Kategori Bazlı Stok Raporları: Hangi ürün gruplarının ne kadar stoklandığı bilgisi.
E. Kullanıcı Giriş ve Yetkilendirme Modülü
Sisteme erişimi güvenli hale getiren bu modül, kullanıcı rollerine göre yetkilendirme yapar.
•	Kullanıcı Giriş Paneli: Şifre ve kullanıcı adı ile oturum açma.
•	Rol Bazlı Erişim: Admin, personel, depo sorumlusu gibi farklı yetki seviyeleri.
•	Hesap Güvenliği: Şifre denemeleri, kilitleme ve şifre yenileme mekanizmaları.
F. Görüntü İşleme Modülü
Barkodsuz ürünlerin kamera ile tanınmasını sağlayan yapay zeka destekli akıllı sistemdir.
•	Google Cloud Vision API Entegrasyonu: Görsellerden metin ve etiket çıkartımı.
•	Veritabanı ile Etiket Karşılaştırması: En benzer ürün sistem tarafından önerilir.
•	Kullanıcı Onayı ile Ekleme: Benzerlik skoru sunularak stok güncellemesi yapılır.

3. Kurulum Adımları
A. Veritabanı Kurulumu
1. SQL Server Management Studio (SSMS) üzerinden veritabanını oluştur.
2. Tablo yapısını projeye göre oluştur (örn. Urunler, StokHareketleri, Musteriler, vb.).
3. SQL script’leri ile başlangıç verilerini yükle (varsa).

B. Masaüstü Uygulama (C# Windows Forms)
1. Visual Studio ile StockTracker çözüm dosyasını aç.
2. App.config içinde SQL Server bağlantı bilgisini kendi sunucuna göre düzenle.
3. Projeyi derle ve çalıştır.
4. Giriş ekranı üzerinden kullanıcı hesabı ile giriş yap.

C. Python Backend (Flask)
1. Aşağıdaki Python kütüphanelerini yükle:
   pip install flask pyodbc requests google-cloud-vision
2. .env veya config dosyasıyla SQL bağlantı bilgileri ve Google Vision API key’ini gir.
3. Flask sunucusunu çalıştır:
   python app.py

D. Google Cloud Vision API
1. Google Cloud Console üzerinden Vision API'yi etkinleştir.
2. API anahtarını indir ve Python projesine entegre et.
3. Görsel tanıma işlemlerini bu anahtar üzerinden çalıştır.

4. Kullanım Kılavuzu
StockTracker, Windows Forms tabanlı bir masaüstü uygulama ile el terminali entegrasyonunu birleştiren, kapsamlı ve akıllı bir stok yönetim sistemidir. Ürün giriş-çıkışları, müşteri yönetimi, kategori bazlı ürün takibi ve detaylı raporlama işlemleri tek bir platform üzerinden etkin bir şekilde gerçekleştirilebilir. El terminali desteği sayesinde depo içi operasyonlar hızla ve hatasız bir şekilde tamamlanabilir.
A. Stok Giriş / Görüntü İşleme Süreci
1. Masaüstü uygulamadan “Görüntü ile Stok Girişi” modülünü seç.
2. Kamera açılır, ürün kameraya gösterilir.
3. Görüntü manuel olarak işleme gönderilir (Vision API).
4. API’den gelen veriler ürün veritabanıyla eşleştirilir.
5. En yakın ürün arayüzde gösterilir → kullanıcı onaylar.
6. Miktar girilir → stok güncellenir → başarı mesajı görüntülenir.

B. Müşteri Yönetimi
1. “Müşteri Ekle” menüsünden yeni müşteri bilgileri girilir.
2. Mevcut müşteriler listelenebilir, filtrelenebilir ve düzenlenebilir.

C. Raporlama
1. “Stok Hareketleri” bölümünden tarih aralığı seçilerek geçmiş işlemler izlenir.
2. Raporlar Excel veya PDF formatında dışa aktarılabilir.

D. El Terminali Kullanımı
1. El terminali cihazında özel olarak tasarlanmış web arayüzü açılır.
2. Barkod okutularak ürün tanınır veya elle girilir.
3. Flask API üzerinden stok güncellemesi yapılır.

5. Projenin Amacı
StockTracker, küçük ve orta ölçekli işletmelerin stok takibini dijital ortama taşıyarak süreci daha hızlı, güvenilir ve verimli hale getirmeyi hedefleyen kapsamlı bir stok yönetim sistemidir. Bu proje, geleneksel ve manuel yöntemlerin neden olduğu zaman kayıpları, veri hataları ve kontrol eksikliği gibi sorunlara çözüm sunar. Sistem, kullanıcı dostu masaüstü uygulaması ve el terminali entegrasyonu sayesinde depo içi işlemlerden müşteri takibine kadar tüm süreçleri tek bir platformda birleştirir.
Projenin Karşıladığı Temel İhtiyaçlar:
•	Ürün Giriş-Çıkışlarının Anlık Takibi: Depoya gelen veya çıkan her ürün, sistem üzerinden gerçek zamanlı olarak kaydedilir ve stok bilgileri otomatik güncellenir.
•	Stok Seviyelerinin Kontrolü: Minimum stok seviyesi tanımlanabilir, böylece kritik seviyeye inen ürünler için önceden uyarı alınabilir.
•	Mobil El Terminali ile Hızlı İşlem Yapabilme: El terminali üzerinden ürün tanıma veya barkod okutma işlemleri yapılabilir; bu da depo personelinin hızlı ve hatasız çalışmasını sağlar.
•	Stok Hareketlerinin Detaylı Raporlanması: Tüm giriş-çıkış işlemleri tarih, ürün, müşteri ve kullanıcı bazlı filtrelenerek raporlanabilir.
•	Müşteri Bazlı Satış Takibi: Müşteri geçmişi, sipariş detayları ve iletişim bilgileri sistemde saklanarak satış sonrası analiz yapılabilir.
•	Kategori Bazlı Ürün Yönetimi: Ürünler, kategori ve alt kategori yapısına göre gruplandırılarak daha düzenli ve erişilebilir bir envanter yönetimi sağlanır.

6. Projenin Faydaları
•	Stok takibinde manuel işlemlerin azaltılması
•	İş gücü ve zaman tasarrufu sağlanması
•	Stok kayıplarının önlenmesi
•	Gerçek zamanlı stok durumu takibi
•	Müşteri bazlı satış analizi imkanı
•	Raporlama süreçlerinin otomatizasyonu
•	Ürünlerin üzerinde barkod olmaması durumunda kayıt yapabilme özelliği

7. Proje Fizibilitesi
A. Teknik Fizibilite
StockTracker, mevcut yazılım ve donanım altyapıları ile tam uyumlu olacak şekilde geliştirilmiştir. Kullanılan teknolojiler (Windows Forms, Python Flask, SQL Server, Google Cloud Vision) yaygın, dokümantasyonu güçlü ve sürdürülebilir teknolojilerdir. Projede kullanılan mimari, modüler yapıdadır; bu da bakım ve genişletme açısından avantaj sağlar.
•	Geliştirme ortamı: Visual Studio 2022, Python IDE
•	Veritabanı yönetimi: Microsoft SQL Server
•	Görüntü işleme: Google Cloud Vision API
•	El terminali desteği: Python Flask üzerinden REST API ile
Sonuç: Teknik olarak uygulanabilir ve sürdürülebilir bir projedir.
B. Ekonomik Fizibilite
1. Maliyet Analizi:
Kalem	Açıklama	Tahmini Maliyet
Yazılım Geliştirme	Öğrenci emeği ile geliştirildi	0 ₺
SQL Server (Express versiyon)	Ücretsiz kullanılabilir	0 ₺
Google Cloud Vision API	Başlangıç kotası ücretsiz (aylık 1000 işlem)	0–100 ₺
El Terminali Donanımı	Android tabanlı cihaz	~3000 ₺
Eğitim ve Belgelendirme	İç kaynaklarla yapılabilir	0 ₺

2. Fayda Analizi:
•	Manuel stok takibine kıyasla ciddi iş gücü tasarrufu sağlar.
•	Hatalı girişlerin azalmasıyla veri güvenilirliği artar.
•	Barkodsuz ürün tanıma özelliği ile kayıt dışı ürün sorununu çözer.
•	Anlık stok durumu ve geçmiş raporlarıyla işletme içi karar verme süreci hızlanır.
•	Tek platformdan yönetim ile maliyet/çalışan başına verimlilik artışı sağlanır.
Sonuç: Ekonomik olarak düşük maliyetli ve yüksek getirili bir sistemdir.
C. Operasyonel Fizibilite
Kullanıcı dostu arayüzler sayesinde temel bilgisayar bilgisine sahip personel tarafından rahatlıkla kullanılabilir. El terminali entegrasyonu sayesinde depo çalışanları hızlı ve hatasız işlem yapabilir. Ayrıca sistemin offline çalışma kabiliyeti, internet kesintilerinde de işlerin aksamasını engeller.
•	Kullanıcı rolleriyle yetki sınırlaması yapılabilir.
•	Sistem loglaması sayesinde hatalar izlenebilir.
•	Yedekleme altyapısı kurulabilir.
Sonuç: Günlük operasyonlara kolaylıkla entegre edilebilir bir sistemdir.


8. Güvenlik Önlemleri
StockTracker, sistem güvenliğini sağlamak ve verilerin bütünlüğünü korumak amacıyla çeşitli katmanlarda güvenlik mekanizmaları içermektedir. Hem kullanıcı bazlı erişim kontrolü hem de veritabanı güvenliği dikkate alınarak geliştirilmiştir.
A.	Kullanıcı Yetkilendirme Sistemi
Her kullanıcıya rol bazlı yetkiler atanır (örneğin: admin, personel, depo sorumlusu). Sisteme sadece yetkili kişiler giriş yapabilir, böylece izinsiz erişim önlenir.

B.	 Veritabanı Şifreleme
Kritik kullanıcı bilgileri (şifreler, e-posta vb.) veritabanında şifrelenmiş olarak saklanır. Bu sayede yetkisiz veri erişimi durumlarında bile veri gizliliği korunur.

C.	 İşlem Logları
Kullanıcıların sistemde gerçekleştirdiği işlemler kayıt altına alınır. Böylece geriye dönük denetim yapılabilir ve izinsiz/şüpheli aktiviteler kolaylıkla tespit edilir.

D.	 Hata Yönetimi ve Kayıt Sistemi
Uygulama çalışması sırasında oluşan hatalar sistemsel log dosyalarına kaydedilir. Bu, geliştiricilerin sorunları hızlıca teşhis etmesine olanak tanır.

E.	Veri Yedekleme
Veritabanı yedekleme altyapısı sayesinde, sistemsel çökme veya veri kaybı gibi durumlarda son kayıtlar kolayca geri yüklenebilir. Otomatik yedekleme desteği de eklenebilir.
9. Test ve Gözlem
- Görsel tanıma işlemi ortalama 1-3 saniye sürmektedir.
- Benzerlik eşleştirme algoritması sayesinde barkodsuz ürünlerde başarı oranı yüksektir.
- El terminali ile yapılan işlemler gerçek zamanlı olarak sisteme yansır.

10. Öneriler ve Geliştirme Fikirleri
- Görüntü işleme modülünü otomatik tetiklemeli hale getirmek.
- Ürün tanımada makine öğrenmesi modeli ekleyerek daha akıllı eşleştirme.
- Kullanıcı bildirim sistemi (stok azaldığında uyarı).
- Mobil uygulama versiyonu.



11. Ekran Görüntüleri ve Diyagramlar
A. Giriş Ekranı
Bu ekran, kullanıcıların sisteme kimlik doğrulamasıyla erişmesini sağlar. Giriş yapan kişinin rolüne göre (personel, admin, depo sorumlusu) farklı yetkiler tanımlanır. Şifre hatırlatma, hesap kilitleme gibi güvenlik önlemleri içerir.
 


B. Ana Menü
Kullanıcının tüm modüllere erişim sağladığı merkez arayüzdür. Ana menü üzerinden:
•	Müşteri yönetimi
•	Ürün işlemleri
•	Stok güncellemeleri
•	Raporlama
•	Görüntü işleme modülü gibi alanlara kolayca geçiş yapılabilir.
Kullanıcı dostu ikonlar ve basitleştirilmiş menü tasarımı sayesinde kullanım kolaylığı sağlar.


C. Ürün Tanıma ve Stok Güncelleme Arayüzü
Bu ekran, kamera ile ürün tanıtma işleminin yapıldığı ve stok miktarlarının güncellendiği alandır.
İşleyiş:
1.	Kamera aktif hale getirilir, ürün kameraya gösterilir.
2.	Görsel Google Cloud Vision API’ye gönderilir.
3.	Gelen etiketler ve açıklamalar, ürün veritabanı ile eşleştirilir.
4.	Kullanıcı, sistemin önerdiği ürünü onaylayarak miktarı girer.
5.	Flask API üzerinden stok bilgisi veritabanına yazılır.
Güven skoru da kullanıcıya gösterilir (örneğin: “%92 benzerlik”).

D. Müşteri Ekleme Formu
Bu ekran üzerinden yeni müşteri kaydı yapılabilir veya mevcut müşteriler listelenip düzenlenebilir.
Kayıt Alanları:
•	TC Kimlik No
•	Ad Soyad
•	Telefon
•	E-mail
•	Adres
Listeleme Özellikleri:
•	TC ile filtreleme
•	Tüm müşteri geçmişine erişim
•	Satış bilgilerine bağlantı
E. Raporlama Ekranı
Bu ekran sayesinde stok hareketleri detaylı bir şekilde izlenebilir.
Özellikler:
•	Tarih aralığı seçme
•	Ürün/kategori bazlı filtreleme
•	Excel ve PDF çıktısı alma
•	Giriş/çıkış raporlarının ayrı listelenmesi
Kullanıcılar tarafından yapılan tüm stok hareketleri kayıt altına alınır ve denetlenebilir.

F. El Terminali Web Arayüzü
Depo personelinin kullandığı mobil web arayüzdür. Python Flask tarafından servis edilen bu arayüz sayesinde:
•	Barkod okutularak ürün tanımlanır
•	Manuel giriş imkanı vardır
•	Hızlı stok güncellemesi yapılır
•	Offline çalışma desteği sağlanabilir (opsiyonel)
Mobil cihazlar için sadeleştirilmiş ve optimize edilmiş bir tasarım kullanılmıştır.

G. Stok Güncelleme Süreci Diyagramı
1. Kamera ile ürün görüntüsü alınır
2. Görsel, Google Cloud Vision API’ye gönderilir
3. Vision API’den gelen etiketler alınır
4. Etiketler ürün veritabanı ile karşılaştırılır
5. En yüksek benzerliğe sahip ürün bulunur
6. Kullanıcı önerilen ürünü onaylar
7. Miktar girilir
8. Flask API ile SQL Server'a stok güncellemesi yapılır
9. Başarı mesajı ve yeni stok miktarı gösterilir
12. Veri Tabanı Yapısı
StockTracker sisteminde, tüm işlemler ilişkisel bir veritabanı (SQL Server) üzerinden yürütülmektedir. Aşağıda yer alan temel tablolar, sistemin işleyişini sağlayan çekirdek yapıyı oluşturur. Her tablo, ilgili modüllerin veri ihtiyaçlarına göre tasarlanmış ve optimize edilmiştir.
A. Terminaller Tablosu
•	El terminali cihazlarının sistemde kayıt altına alınmasını sağlar.
•	Cihaza özel IP adresi ve port bilgisi ile bağlantı kontrolü gerçekleştirilir.
•	Terminalin son bağlantı zamanı ve çevrimdışı/çevrimiçi durumu izlenebilir.
B. Kullanicilar Tablosu
•	Sistem kullanıcılarının kimlik bilgileri ve erişim yetkileri saklanır.
•	Güvenli giriş için şifreler şifrelenmiş olarak tutulur.
•	Her kullanıcıya rol (admin, personel, depo sorumlusu) atanarak erişim kısıtlaması yapılır.
C. Urunler Tablosu
•	Ürünlere ait temel bilgiler (isim, açıklama, barkod, birim fiyat vb.) burada saklanır.
•	Stok miktarı, minimum stok seviyesi ve güncel durum takip edilir.
•	Ürünler kategori ile ilişkilendirilerek gruplama yapılır.
D. StokHareketleri Tablosu
•	Tüm stok giriş ve çıkış işlemleri bu tabloda kayıt altına alınır.
•	Her hareket; işlem türü, kullanıcı, terminal, müşteri ve tarih bilgileriyle ilişkilendirilir.
•	Raporlama altyapısı bu tablo üzerinden tarih ve miktar bazlı çalışır.
E. Musteriler Tablosu
•	Müşteri firmalarının adı, yetkili kişi bilgisi ve iletişim bilgileri tutulur.
•	Her müşteriye özgü satış geçmişiyle ilişkilendirme yapılabilir.
•	Kategorilendirme ile müşteri grupları tanımlanabilir (örneğin: perakende, toptan).
F. Kategoriler Tablosu
•	Ürünlerin sistematik bir şekilde gruplanmasını sağlar.
•	Hiyerarşik yapı desteklenerek ana kategori–alt kategori ilişkisi kurulabilir.
•	Raporlama ve arama işlemlerinde sınıflandırma kolaylığı sunar.






13. Form Tasarımları Ve İşlevleri
StockTracker sisteminde kullanıcıların veriye erişimini ve işlemleri kolaylaştıran çeşitli form ekranları bulunmaktadır. Bu formlar; müşteri yönetimi, ürün işlemleri ve satış süreçlerini basitleştirmek amacıyla tasarlanmıştır. Aşağıda her formun işlevi ve içerdiği alanlar detaylı olarak sunulmuştur.
A. Ana Menü İşlevleri
Ana menü, uygulamadaki tüm alt modüllere erişimi sağlayan merkez arayüzdür. Kullanıcılar aşağıdaki işlemleri buradan gerçekleştirebilir:
•	Müşteri Ekleme: Yeni müşteri kaydı başlatılır.
•	Müşteri Listeleme: Kayıtlı müşteriler filtrelenip listelenebilir.
•	Ürün Ekleme: Yeni ürün tanımlaması yapılır.
•	Ürün Listeleme: Tüm ürünler detaylarıyla birlikte görüntülenir.
•	Satışları Listeleme: Geçmiş satış işlemleri tarih, müşteri veya ürün bazlı görüntülenir.
B. Müşteri İşlem Formları
1. Müşteri Ekleme / Düzenleme Formu
Yeni müşteri kaydı yapılmasını ve mevcut müşteri bilgilerinin güncellenmesini sağlayan formdur.
Veri Giriş Alanları:
•	TC Kimlik No
•	Ad Soyad
•	Telefon
•	Adres
•	E-mail
İşlem Butonları:
•	Ekle: Yeni müşteri ekler.
•	Güncelle: Seçili müşteriyi düzenler.
•	Sil: Müşteri kaydını sistemden kaldırır.
2. Müşteri Listeleme Formu
Sistemde kayıtlı tüm müşterilerin listelendiği ve filtrelenebildiği formdur.
Fonksiyonlar:
•	TC ile arama yapma
•	Tüm müşterileri listeleme
•	Müşteri bilgisi güncelleme ekranına yönlendirme
•	Seçilen müşterinin detaylarını ayrı bir panelde görüntüleme
C. Satış İşlemleri Formu
Satış işlemlerinin yürütüldüğü ve her satışın sisteme kaydedildiği formdur. Kullanıcı, müşteri ve ürün bilgilerini girerek işlemi tamamlar.
Müşteri Bilgileri:
•	TC
•	Ad Soyad
•	Telefon
Ürün İşlemleri:
•	Barkod No
•	Ürün Adı
•	Miktar
•	Satış Fiyatı
•	Toplam Fiyat (otomatik hesaplanır)
Fonksiyonel Butonlar:
•	Ekle: Seçilen ürünü satış listesine ekler.
•	Genel Toplam Hesaplama: Tüm ürünlerin toplam tutarını hesaplar.
•	Satış Yap: İşlemi tamamlar ve veritabanına kaydeder.
•	İşlem İptal: Mevcut işlemi iptal eder ve alanları sıfırlar.



![image](https://github.com/user-attachments/assets/9df3d403-44d9-4b44-870c-047b88c866e4)
