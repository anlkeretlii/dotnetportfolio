# 🎨 ASP.NET Core Portfolio Projesi

Bu proje, **Murat Yücedağ**'ın Udemy'deki kapsamlı ASP.NET Core kursları sayesinde geliştirilmiş modern bir portfolyo web uygulamasıdır. Proje, hem kişisel portfolyo vitrinini hem de güçlü bir admin yönetim panelini içermektedir.

![.NET Core](https://img.shields.io/badge/.NET-8.0-purple?style=flat&logo=dotnet)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-blue?style=flat&logo=microsoft)

## 📖 Proje Hakkında

Bu portfolyo uygulaması, yazılım geliştirici ve tasarımcıların yeteneklerini sergileyebileceği modern ve responsive bir platform sunar. Clean Architecture prensiplerine uygun olarak geliştirilmiş, kullanıcı dostu arayüzü ve güçlü admin paneli ile dikkat çeker.

### 🎯 Proje Amacı
- Kişisel portfolyoyu dijital ortamda profesyonel şekilde sergilemek
- Modern web teknolojilerini kullanarak tam kapsamlı bir CMS sistemi oluşturmak
- Responsive tasarım ile tüm cihazlarda mükemmel görüntüleme sağlamak
- SEO dostu yapı ile arama motorlarında üst sıralarda yer almak

## 🚀 Özellikler

### 📱 Frontend (Portfolyo Sayfası)
- **Responsive Tasarım**: Mobil, tablet ve desktop cihazlarda mükemmel görüntü
- **Parallax Efektleri**: Göz alıcı görsel deneyim
- **Smooth Scrolling**: Akıcı sayfa geçişleri
- **Modern UI/UX**: Kullanıcı dostu arayüz tasarımı
- **Portfolio Galerisi**: Projelerinizi görsel olarak sergileyebilme
- **İletişim Formu**: Ziyaretçilerinizle doğrudan iletişim kurabilme
- **Sosyal Medya Entegrasyonu**: Sosyal medya hesaplarınızla bağlantı

### 🛠️ Admin Yönetim Paneli
- **Dashboard**: Genel istatistikler ve sistem durumu
- **İçerik Yönetimi**: 
  - Hakkımda bilgileri düzenleme
  - Özellikler (Features) yönetimi
  - Deneyimler ve iş geçmişi
  - Yetenek/Beceri yönetimi
  - Portfolyo projelerini ekleme/düzenleme
  - Referanslar (Testimonials) yönetimi
- **İletişim Yönetimi**: 
  - Gelen mesajları görüntüleme ve yönetme
  - İletişim bilgilerini güncelleme
- **Sistem Yönetimi**:
  - Site ayarları düzenleme
  - Bildirim sistemi
  - Sistem bilgileri ve analitik
  - ToDo List yönetimi

### 📊 Raporlama ve Analitik
- **Ziyaretçi İstatistikleri**: Site trafiği analizi
- **Mesaj Raporları**: İletişim formundan gelen mesaj analizi
- **Sistem Performansı**: Sunucu durumu ve performans metrikleri
- **SEO Optimizasyonu**: Arama motoru optimizasyon raporları

## 🛠️ Kullanılan Teknolojiler

### Backend
- **ASP.NET Core 8.0**: Modern web framework
- **Entity Framework Core**: ORM ve veritabanı yönetimi
- **SQL Server**: Veritabanı yönetim sistemi
- **ViewComponents**: Modüler yapı için
- **Repository Pattern**: Temiz kod mimarisi

### Frontend
- **HTML5 & CSS3**: Modern web standartları
- **Bootstrap 5**: Responsive framework
- **JavaScript/jQuery**: Dinamik etkileşimler
- **Hola Template**: Özel tasarım şablonu
- **Ready Dashboard**: Admin panel tasarımı
- **Font Awesome**: İkon kütüphanesi

### Veritabanı
- **Microsoft SQL Server**: Ana veritabanı
- **Entity Framework Migrations**: Veritabanı versiyonlama
- **Code First Approach**: Model-tabanlı geliştirme

## 📦 Kurulum

### Gereksinimler
- .NET 8.0 SDK
- SQL Server (LocalDB veya Express)
- Visual Studio 2022 veya VS Code
- Git

### Adım Adım Kurulum

1. **Repo'yu klonlayın**
   ```bash
   git clone [repo-url]
   cd netcoreportfolyo
   ```

2. **Bağımlılıkları yükleyin**
   ```bash
   dotnet restore
   ```

3. **Veritabanı bağlantı dizesini ayarlayın**
   `appsettings.json` dosyasında connection string'i güncelleyin:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PortfolioDb;Trusted_Connection=true"
     }
   }
   ```

4. **Veritabanını oluşturun**
   ```bash
   dotnet ef database update
   ```

5. **Uygulamayı çalıştırın**
   ```bash
   dotnet run
   ```

6. **Tarayıcıdan erişin**
   ```
   https://localhost:5001 (Portfolio Sayfası)
   https://localhost:5001/AdminDashboard (Admin Panel)
   ```

## 🗂️ Proje Yapısı

```
netcoreportfolyo/
├── 📁 Controllers/          # MVC Controllers
│   ├── AdminDashboardController.cs
│   ├── DefaultController.cs
│   ├── ExperienceController.cs
│   ├── MessageController.cs
│   ├── StatisticController.cs
│   └── ToDoListController.cs
├── 📁 DAL/                  # Data Access Layer
│   ├── 📁 Context/
│   │   └── MyPortfolioContext.cs
│   └── 📁 Entities/         # Veri Modelleri
│       ├── About.cs
│       ├── Contact.cs
│       ├── Experience.cs
│       ├── Feature.cs
│       ├── Message.cs
│       ├── Notification.cs
│       ├── Portfolio.cs
│       ├── Skill.cs
│       ├── SocialMedia.cs
│       └── Testimonial.cs
├── 📁 ViewComponents/       # View Components
│   └── 📁 LayoutViewComponents/
├── 📁 Views/               # Razor Views
│   ├── 📁 AdminDashboard/
│   ├── 📁 Default/
│   ├── 📁 Shared/
│   └── 📁 Layout/
├── 📁 wwwroot/             # Static Files
│   ├── 📁 hola-master/     # Portfolio Template
│   └── 📁 Ready-Bootstrap-Dashboard-master/ # Admin Template
├── 📁 Migrations/          # EF Migrations
└── 📄 Program.cs           # Uygulama Başlangıcı
```

## 🎨 Ekran Görüntüleri

### Portfolio Ana Sayfa
- Modern ve etkileyici hero section
- Parallax efektli arkaplan görselleri
- Responsive portfolyo galerisi
- Smooth scrolling navigasyon

### Admin Dashboard
- Comprehensive istatistik kartları
- Real-time veri görselleştirme
- Kullanıcı dostu içerik yönetimi
- Sistem durumu monitoring

## 🔧 Yapılandırma

### Veritabanı Yapılandırması
```csharp
// Program.cs
builder.Services.AddDbContext<MyPortfolioContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

### Email Yapılandırması (Opsiyonel)
```json
{
  "EmailSettings": {
    "SmtpServer": "smtp.gmail.com",
    "Port": 587,
    "Username": "your-email@gmail.com",
    "Password": "your-app-password"
  }
}
```

## 📈 Performans Özellikleri

- **Lazy Loading**: Görsellerin gecikmeli yüklenmesi
- **Caching**: Veritabanı sorgularının önbelleklenmesi
- **Minification**: CSS/JS dosyalarının optimize edilmesi
- **CDN Ready**: İçerik dağıtım ağı desteği
- **SEO Optimized**: Arama motoru optimizasyonu

## 🔒 Güvenlik Özellikleri

- **CSRF Protection**: Cross-site request forgery koruması
- **XSS Prevention**: Cross-site scripting koruması
- **SQL Injection Protection**: Entity Framework güvenliği
- **Input Validation**: Giriş verisi doğrulama
- **HTTPS Enforcement**: Güvenli bağlantı zorunluluğu

## 🧪 Test Etme

```bash
# Unit testleri çalıştırma
dotnet test

# Integration testleri
dotnet test --filter "Category=Integration"

# Coverage raporu
dotnet test --collect:"XPlat Code Coverage"
```

## 🚀 Deploy (Yayınlama)

### IIS'e Deploy
1. `dotnet publish -c Release -o ./publish` komutunu çalıştırın
2. Publish klasörünü IIS sunucusuna kopyalayın
3. IIS'te site oluşturun ve .NET Core hosting bundle'ı yükleyin

### Azure'a Deploy
```bash
# Azure CLI ile
az webapp deploy --resource-group myResourceGroup --name myApp --src-path ./publish
```

### Docker ile Deploy
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY ./publish .
ENTRYPOINT ["dotnet", "netcoreportfolyo.dll"]
```

## 📚 Öğrenim Kaynağı

Bu proje **Murat Yücedağ**'ın Udemy'deki kapsamlı ASP.NET Core kursları sayesinde geliştirilmiştir. Kurs boyunca öğrenilen konular:

### Temel Konular
- ASP.NET Core MVC mimarisi
- Entity Framework Core kullanımı
- Repository Pattern implementasyonu
- ViewComponent yapısı
- Razor View Engine

### İleri Seviye Konular
- Code First yaklaşımı
- Migration yapısı
- CRUD operasyonları
- Authentication & Authorization
- Modern web tasarım teknikleri

### Kullanılan Tasarım Desenleri
- Model-View-Controller (MVC)
- Repository Pattern
- Dependency Injection
- ViewComponent Pattern

## 🤝 Katkıda Bulunma

1. Bu repo'yu fork edin
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi commit edin (`git commit -m 'feat: Add amazing feature'`)
4. Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. Pull Request oluşturun

## 📝 Changelog

### v1.0.0 (2024)
- İlk stabil sürüm
- Temel portfolyo özellikleri
- Admin panel entegrasyonu
- Responsive tasarım

### v1.1.0 (Gelecek)
- Blog sistemi entegrasyonu
- Çoklu dil desteği
- Email notification sistemi
- Advanced analytics

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 📞 İletişim

- **Geliştirici**: [Adınız]
- **Email**: [email@example.com]
- **LinkedIn**: [LinkedIn profiliniz]
- **GitHub**: [GitHub profiliniz]

## 🙏 Teşekkürler

- **Murat Yücedağ** - Kapsamlı ASP.NET Core eğitimi için
- **Udemy** - Kaliteli eğitim platformu sağladığı için
- **Microsoft** - .NET teknolojileri için
- **Bootstrap Ekibi** - Harika responsive framework için
- **Hola Template** - Güzel portfolyo tasarımı için

---

⭐ Bu projeyi beğendiyseniz star vermeyi unutmayın!

🚀 **"Kod yazmak sadece başlangıç, hayallerinizi gerçekleştirmek asıl hedeftir!"** 
