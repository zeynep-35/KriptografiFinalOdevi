ANA SAYFA

![image](https://github.com/user-attachments/assets/183a2867-a8ef-458e-b0b1-7c6563fe8d81)
Projenin giriş sayfasında görüldüğü gibi, kullanıcılar modern ve etkileşimli bir arayüzle karşılanmaktadır.Giriş ekranında, RSA Anahtar Üret, RSA Şifrele, RSA Şifre Çöz ve SHA256 Özeti olmak üzere dört temel işlev kartlar halinde sunulmakta; her bir kart kullanıcıya yönlendirici ikon, açıklama ve butonlar ile desteklenmektedir. Böylece, proje hem işlevsel hem de kullanıcı dostu bir deneyim sunmayı hedeflemektedir.



RSA ANAHTAR ÜRETİCİSİ
 ![image](https://github.com/user-attachments/assets/d68b96a9-ace6-4344-b0fd-ad0a081a892e)
 
Bu görsel, projenin “RSA Anahtar Üretici” sayfasına ait arayüzü göstermektedir. Promin olarak yer alan başlık ve açıklama sayesinde kullanıcıya, bu sayfa üzerinden yeni bir Public / Private key çifti oluşturabileceği açıkça iletilmektedir. Sayfanın üst kısmında yer alan “Anahtar Oluştur” butonuna tıklanarak anında anahtar üretimi sağlanmakta, aşağıda oluşturulan Public Key ve Private Key ayrı ayrı gösterilmektedir. Her iki anahtar alanının yanında yer alan “Kopyala” butonları, kullanıcıya kolaylık sunmakta; en altta bulunan “Geri Dön” butonu ise kullanıcıyı ana sayfaya yönlendirmektedir.



RSA ŞİFRELEME
![image](https://github.com/user-attachments/assets/b6846f8e-d99a-4ade-bc7b-dea1ea654c81)

Bu görsel, projenin RSA Şifreleme sayfasında şifreleme işlemi tamamlandıktan sonra kullanıcıya sunulan sonucu göstermektedir. Sayfa, mor ve mavi tonlardaki dijital temasıyla güvenlik odaklı bir arayüz sunmaya devam ederken, üst kısımda yer alan başlık ve açıklama kullanıcıyı yönlendirmektedir. Kullanıcı, daha önce girdiği Public Key ve şifrelenecek olan "ZEYNEP" metni ile işlemi başlatmıştır.
Alt bölümde ise şifreleme işlemi başarıyla tamamlandıktan sonra "Şifrelenmiş Metin" başlığı altında Base64 formatındaki çıktı görünmektedir. Yanında yer alan “Kopyala” butonu, kullanıcıya bu sonucu kolayca panoya alma imkânı sunmaktadır. Sayfanın en altındaki “Geri Dön” butonu ile kullanıcı önceki sayfaya dönebilir. 



RSA ŞİFRE ÇÖZME
![image](https://github.com/user-attachments/assets/68275fd0-d4f0-4345-b404-739097159f7e)

Başlık kısmında yer alan "RSA Şifre Çöz" ifadesi sarı neon efektiyle vurgulanmış ve altında kullanıcıdan şifrelenmiş metni ve Private Key’i girmesi istendiği belirtilmiştir. Kullanıcı, Base64 formatındaki şifreli metni ve Private Key’i ilgili alanlara girdikten sonra “Çöz” butonuna tıklayarak çözümleme işlemini başlatmıştır.
Alt kısımda, “Çözülmüş Metin” alanı görünür hâle gelmiş ve girişte şifrelenen “ZEYNEP” ifadesi başarıyla çözülerek kullanıcıya sunulmuştur. Sonuç alanının hemen yanında yer alan “Kopyala” butonu, veriyi kolayca panoya alma imkânı sağlar. Bu yapı sayesinde uygulama, RSA algoritmasına dayalı şifre çözme işlemini hem görsel hem de işlevsel açıdan başarılı şekilde sunmaktadır.



SHA256 İLE HASHLEME ARACI
![image](https://github.com/user-attachments/assets/cd9d9d4c-0796-4000-b414-2e0b7b0aa2ec)

![image](https://github.com/user-attachments/assets/d2f8bd04-383c-4c0f-ab81-3270b064db39)

SHA-256 ile Hashleme Aracı’nda iki farklı veri türü seçeneği sunulmaktadır:

Metin

Kullanıcı bu seçeneği seçtiğinde, doğrudan metin girişi yapabilir. Örneğin, “ZEYNEP” yazıldığında sistem bu metni SHA-256 algoritmasıyla işleyerek hash sonucunu üretir ve ekranda gösterir. Bu yöntem kısa ve hızlı veri girişi için uygundur.

Dosya 

Dosya seçeneği seçildiğinde, kullanıcı yerel cihazından bir dosya yükleyerek o dosyanın içeriğini SHA-256 ile hashleyebilir. Bu özellik özellikle dosya bütünlüğü ve doğrulama amaçlı kullanılır.

İkinci görselde görüldüğü gibi metin girilip "SHA256 Hashle" butonuna basıldığında, alt kısımda hash sonucu kullanıcıya sunulmakta ve “Kopyala” butonuyla kolayca alınabilmektedir. 

DOSYA VERİ TİPİ SEÇİLMESİ DURUMU

![image](https://github.com/user-attachments/assets/049c5574-ed80-4192-907e-fa563a22c63f)
![image](https://github.com/user-attachments/assets/0d725cb0-ba76-43e5-b01d-288d769bb162)
![image](https://github.com/user-attachments/assets/d0e9b919-603f-481d-8604-d6b3c43030fe)

SHA256 Hashleme Aracı'nda veri türü olarak "Dosya" seçildiğinde, kullanıcı mutlaka bir dosya seçmelidir. Aksi takdirde sistem “Geçerli bir dosya seçilmedi.” uyarısını verir.
 Dosya başarıyla seçildiğinde (örneğin: Deneme.txt), kullanıcı “SHA256 Hashle” butonuna tıklayarak dosyanın SHA256 hash sonucunu anında görebilir. Sonuç alındığında, hash değeri ekranın altında gösterilir ve "Kopyala" butonuyla panoya alınabilir.





