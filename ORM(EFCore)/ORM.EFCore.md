## Object Relational Mapping(ORM)

## 1. Apa Itu ORM
ORM merupakan teknik pemrograman yang digunakan untuk berinteraksi dengan database dengan abstraksi yang lebih tinggi dari _raw query_, Pemetaan atau _mapping_ antara _object_ hasil _query_ dan instance _object_ dari _class_, dan masih banyak lagi. Maksud dari abstraksi lebih tinggi adalah kita tidak perlu mengirim _query_ mentah lagi sebagaimana yang seblumnya kita lakukan dengan ADO.NET namun cukup menggunakan perintah sederhana seperti LINQ kemudian library yang digunakan akan secara otomatis menerjemahkannya menjadi _query_ yang digunakan untuk berinteraksi dengan database. Setelah _object_ didapatkan dari database maka valuenya akan secara otomatis di mapping pada setiap properti pada _object_ instance _class_.

## 2. Entitiy Framework Core
EF Core merupakan salah satu library yang paling populer dapat pengembangan aplikasi .NET yang memiliki beragam fitur. Dengan menggunakan EF Core kita dapat menggunakan LINQ yang kemudian akan diterjemahkan menjadi query oleh library tersebut, selain itu kita juga dapat melakukan tracking pada object yang dibuat. Selain mengirim query kita juga dapat membuat database, tabel bahkan sampai relasi dan constraintnya menggunakan fitur migration atau yang lebih dikenal sebagai Code First, namun kali ini kita tidak akan mempelajari hal tersebut

## 3. Setup
1. Tambahkan package berikut pada project yang kita gunakan
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
```
2. Buat sebuah class yang digunakan sebagai titik akses utama database yang akan dibuat inherit terhadap class DbContext yang ada pada library EF Core
```csharp

    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		public DbSet<Categories> Categories { get; set; }
	}

```
Categirues merupakan Object Class yang kita buat secara manual.

3. Lakukan dependency Injection pada Program.cs dengan cara menambahkan code berikut :

```csharp
builder.Services.AddDbContext<DataContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
```

4. Tambahkan Connection String pada Appsettings.json

```json
    "ConnectionStrings": {
    "DefaultConnection": "Koneksi database"
  }
```

## 4. Cara penggunaan

Buat sebuah Constructor sebagai dependency injection pada class yang menjadi titik akses database sebelumnya

```csharp

        private readonly DataContext _context;
		public CategoriesController(DataContext context)
		{
			_context = context;
		}
```

Setelah melakukan hal tersebut sekarang `_context` sudah memiliki Daftar tabel yang sudah kita daftarkan sebelumnya, kemudian method2 yang dapat digunakan untuk berinteraksi dengan database yang telah disediakan oleh EF Core, agar lebih jelas dapat dilihat pada folder Controller.
