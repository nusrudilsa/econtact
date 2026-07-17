# E-Contact (Rehber Uygulaması) 📱

C# Windows Forms teknolojisi kullanılarak geliştirilmiş, temel kişi kayıt ve yönetim işlemlerini gerçekleştiren bir masaüstü rehber uygulamasıdır. 

Bu proje, C# programlama dilini, Windows Forms kontrollerini ve nesne yönelimli programlama mantığını pekiştirmek amacıyla YouTube üzerindeki bir eğitim serisi rehberliğinde geliştirilmiştir. Geliştirme sürecinde karşılaşılan arayüz-kod senkronizasyon hataları ve kontrol olayları (events) manuel olarak çözülerek stabil hale getirilmiştir.

---

## 🚀 Özellikler

* **Kişi Ekleme (Add):** Form üzerindeki metin kutularından (İsim, Soyisim, Telefon, Adres, Cinsiyet) verileri alarak dinamik olarak listeye ekler.
* **Hızlı Temizleme (Clear):** Giriş alanlarını tek bir tıkla sıfırlayarak yeni kayıt girişini kolaylaştırır.
* **Kayıt Silme (Delete):** Eklenen verileri liste üzerinden kaldırmayı sağlar.
* **Anlık Arama & Filtreleme (Search):** Arama kutusuna yazılan harflere göre `DataView.RowFilter` yapısı kullanarak listedeki kişileri anlık olarak filtreler.
* **Özgün Arayüz Tasarımı:** Kullanıcı dostu, modern ve temiz bir form tasarımı oluşturulmuştur.

---

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C# (.NET)
* **Arayüz:** Windows Forms (WinForms)
* **Veri Yönetimi:** `DataTable` ve `DataView` (Hafıza üzerinde geçici veri yönetimi)

---

## 🎯 Bu Projeden Ne Öğrendim?

* Windows Forms kontrollerinin (`TextBox`, `ComboBox`, `DataGridView`, `PictureBox`) `Name` ve `Event` yönetimini,
* Tasarım mimarisi (`Designer.cs`) ile asıl kod bloğu (`.cs`) arasındaki bağlantıyı ve hata ayıklamayı (debugging),
* Bellek üzerinde sanal tablolar (`DataTable`) oluşturarak verileri manipüle etmeyi,
* `TextChanged` event'i ile dinamik filtreleme yapmayı öğrendim.

---
