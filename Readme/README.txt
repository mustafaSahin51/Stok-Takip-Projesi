Stok Takip Uygulaması
Proje Özellikleri
•	Kullanıcı girişi ve kayıt sistemi
•	Şifre gücü kontrolü ve uyarı sistemi
•	Güvenlik soruları ile şifre sıfırlama
•	Rol tabanlı kullanıcı yönetimi (Admin/Kullanıcı)
•	Koyu ve açık tema desteği
•	Menü ve tarif yönetimi
•	Toplu malzeme ihtiyacı ve maliyet analizi
•	Kritik stok uyarı sistemi
•	Excel (CSV) aktarım desteği
•	Gelişmiş loglama ve işlem geçmişi
•	Hatalı girişte geçici blokaj (brute-force koruması)
Güvenlik Önlemleri
•	Şifreler hash’lenerek ve salt ile veritabanında saklanır
•	SQL Injection’a karşı parametreli sorgular kullanılır
•	Kod, ConfuserEx ile obfuscate edilmiştir
•	Giriş denemeleri sınırlandırılmıştır (3 hatalı girişte süreli blokaj)
•	Güvenlik soruları zorunludur
•	Rol tabanlı erişim kontrolü uygulanır
•	Kritik işlemler loglanır
Kurulum
1.	.NET Framework 4.7.2 bilgisayarınızda kurulu olmalıdır.
2.	SQLite Kurulumu:
Proje ile birlikte gelen sqlite-setup.exe dosyasını çalıştırarak SQLite’ı kurunuz.
3.	Proje klasöründe yer alan veritabanı dosyasının (veritabani.db veya benzeri - database/sqlite klasöründe veritabanı bulunur) uygulama ile aynı dizinde olduğundan emin olun.
Varsayılan Giriş Bilgileri
•	Kullanıcı Adı: admin_Mustafa
•	Şifre: 123456
İlk girişten sonra şifrenizi değiştirmeniz önerilir.
---
Herhangi bir sorunla karşılaşırsanız veya destek almak isterseniz iletişime geçebilirsiniz.
---
Not:
•	sqlite-setup.exe dosyasını projenizin ana dizinine eklemeyi unutmayın.
•	Gerekli tüm DLL ve bağımlılıkların da dağıtım klasöründe olduğundan emin olun.



Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Detaylar için LICENSE dosyasına bakabilirsiniz.