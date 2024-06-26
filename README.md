# Sifreli_Veriler_Ile_Calisma

## Genel Bakış

Bu proje, şifreli verilerle nasıl çalışılacağını gösteren bir Windows Forms uygulamasıdır. Kullanıcı verilerini (isim, soyisim, e-posta, şifre ve hesap numarası) SQL Server veritabanına kaydetmeden önce şifreleme ve bu verileri görüntülemek için şifre çözme işlevselliğini içerir. Uygulama, şifreleme ve şifre çözme süreçleri için Base64 kodlamasını kullanır.

## Kurulum

1. **Gereksinimler:**
    - Visual Studio (C# geliştirme ortamı)
    - .NET Framework
    - SQL Server

2. **Adımlar:**
    - Bu projeyi bilgisayarınıza klonlayın veya indirin.
    - Visual Studio'da projeyi açın.
    - SQL Server'ınızda `DbProje13` adlı bir veritabanı oluşturun ve `TBLVERILER` adlı bir tablo ekleyin. Tablo sütunları `AD`, `SOYAD`, `MAIL`, `SIFRE`, `HESAPNO` olarak ayarlanmalıdır.
    - Projedeki bağlantı dizesini (`conn` değişkeni) kendi SQL Server ayarlarınıza göre güncelleyin.

## Kullanım

### Başlatma ve Listeleme

- Uygulamayı çalıştırdığınızda, `Form1_Load` olayı tetiklenir ve `listele` yöntemi çağrılarak veritabanındaki mevcut veriler DataGridView kontrolünde listelenir.

### Veri Ekleme ve Şifreleme

- `button1` (Verileri Kaydet) butonuna tıkladığınızda:
    - Kullanıcıdan alınan isim, soyisim, e-posta, şifre ve hesap numarası bilgileri ASCII karakterlerine dönüştürülüp Base64 formatında şifrelenir.
    - Şifrelenmiş veriler SQL Server veritabanındaki `TBLVERILER` tablosuna eklenir.
    - Kullanıcıya verilerin şifrelenerek kaydedildiğine dair bir mesaj gösterilir.

### Şifre Çözme ve Görüntüleme

- `button2` (Veriyi Çöz) butonuna tıkladığınızda:
    - Kullanıcının girdiği Base64 şifreli veri çözülerek orijinal ASCII formatına geri dönüştürülür ve ekranda görüntülenir.

## Kod Özeti

### Form1 Sınıfı

- `Form1` sınıfı, formun başlatılması ve kullanıcı etkileşimlerinin işlenmesi için gerekli bileşenleri ve yöntemleri içerir.

### Metodlar ve Olaylar

- `listele()`: Veritabanındaki mevcut verileri DataGridView'e yükler.
- `button1_Click()`: Kullanıcı verilerini alır, şifreler ve veritabanına kaydeder.
- `Form1_Load()`: Form yüklendiğinde `listele` metodunu çağırır.
- `button2_Click()`: Kullanıcı tarafından girilen Base64 şifreli veriyi çözer ve görüntüler.

## Önemli Notlar

- Bu uygulama basit bir şifreleme yöntemi (Base64) kullanır ve bu yöntem güvenlik açısından yeterli değildir. Gerçek dünyadaki uygulamalarda daha güçlü şifreleme algoritmaları kullanılmalıdır.
- Veritabanı bağlantı dizesi (`conn` değişkeni) uygulama ayarlarınıza göre güncellenmelidir.

Bu rehber, projeyi kurmanıza ve kullanmanıza yardımcı olacaktır. Herhangi bir sorunla karşılaşırsanız, gerekli ayarları ve adımları tekrar kontrol edin.

## Projeye Ait Örnek Ekran Görüntüsü
![Sifreli_Veri](https://github.com/huseynaktas/Sifreli_Veriler_Ile_Calisma/assets/114494075/929f7bd8-efd3-4813-b500-109c382224a7)


