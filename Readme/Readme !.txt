
bu proje için sqlite kurulumu gerekmektedir


## SQLite Kurulumu ve Kullanımı

Bu proje, veritabanı olarak **SQLite** kullanmaktadır. SQLite, sunucusuz ve dosya tabanlı hafif bir veritabanıdır, bu nedenle kullanımı ve kurulumu oldukça basittir.

### Geliştirme Ortamında

- Projeyi çalıştırmak için gerekli olan SQLite kütüphaneleri (`System.Data.SQLite` veya `Microsoft.Data.Sqlite`) NuGet paket yöneticisi ile projeye eklenmiştir.  
- Ekstra bir veritabanı kurulumu yapmanız gerekmez.

### Veritabanı Dosyası

- Veriler, proje dizininde bulunan `database.db` dosyasında tutulmaktadır.  
- Bu dosya uygulama tarafından otomatik olarak kullanılır ve güncellenir.

### Projeyi Başka Bilgisayara Taşımak

- Proje dosyaları ile birlikte `database.db` dosyasını da kopyalayarak kullanabilirsiniz.  
- Kullanıcı tarafında SQLite kurulumu yapılmasına gerek yoktur.

### Veritabanı Yönetimi

- İsterseniz [DB Browser for SQLite](https://sqlitebrowser.org/) gibi görsel araçlarla veritabanınızı inceleyip düzenleyebilirsiniz.

---

