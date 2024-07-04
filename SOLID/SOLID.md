# SOLID

## 1. Apa itu SOLID

SOLID merupakan akronim dari prinsip-prinsip dalam pemrograman beroreientasi objek. Prinsip ini mengatur kita agar code yang dibuat memiliki kualitas yang baik, mudah di _maintenence_, _testing_, fleksibel dll.

## (S)ingle Responsibility (SRP)

Prinsip ini menegaskan bahwa suatu class berikut _member of class_ nya hanya memiliki tanggung jawab tunggal. sebagai contoh kita punya proses transaksi yang melibatkan proses _select_, insert, dan update maka kita tidak boleh membuat satu _method_ yang secara langsung menangani tiga hal tersebut, tapi kita perlu membuat tiga buah method yang memiliki tugas secara spesifik kemudian satu method lagi yang mengkoordinir method2 tersebut.

Hal ini diperlukan, karena jika terjadi kesalahan pada proses update, maka kita dapat fokus pada _method_ update saja yg di _maintenence_, sekaligus tidak merubah code-code pada _method_ lainnya.

## (O)pen/Closed Principle (OCP)

Prinsip ini menyatakan suatu class harus terbuka untuk ekstensi tetapi tertutup pada modifikasi. Maksud dari pernyataan tersebut adalah jika dimasa depan kita melakukan penambahan fitur maka seharusnya itu dapat dilakukan tanpa memodifikasi source code sebelumnya.

sebagai contoh kita memiliki aplikasi kalkulator yang bisa menghitung luasan. setelah beberapa waktu kita ingin menambahkan fitur perhitungan volume maka penambahan fitur volume ini harus dapat dilakukan tanpa memodifikasi perhitungan luasan sebelumnya.

## (L)iskov Subtitution Principle (LSP)

Prinsip ini menyatakan bahwa objek dalam program harus dapat digantikan dengan instansi dari subkelas mereka tanpa mengubah korektivitas program. Makusd dari penyataan tersebut ada kaitannya dengan polimorfisme pada OOP yang berarti instance dari suatu class turunan harusnya dapat digantikan dengan instance class induknya. sebagai contoh kita memiliki kelas dasar Burung dan kelas turunan BurungTerbang dan Penguin. Dalam hal ini, Penguin adalah burung tetapi tidak bisa terbang. Jika kita memiliki metode terbang() dalam kelas Burung, maka Penguin tidak akan dapat mengimplementasikannya dengan benar, yang melanggar LSP.

```csharp
public class Burung
{
    public virtual void terbang()
    {
        // kode untuk terbang
    }
}

public class BurungTerbang : Burung
{
    public override void terbang()
    {
        // kode untuk terbang
    }
}

public class Penguin : Burung
{
    public override void terbang()
    {
        // Penguin tidak bisa terbang, jadi bagaimana mengimplementasikan metode ini?
    }
}
```

Untuk mematuhi LSP, kita bisa memisahkan kemampuan terbang ke dalam antarmuka terpisah IBisaTerbang dan hanya kelas-kelas yang bisa terbang yang mengimplementasikannya:

```csharp
public interface IBisaTerbang
{
    void terbang();
}

public class Burung
{
    // Kelas Burung dasar
}

public class BurungTerbang : Burung, IBisaTerbang
{
    public void terbang()
    {
        // kode untuk terbang
    }
}

public class Penguin : Burung
{
    // Penguin tidak perlu mengimplementasikan metode terbang
}

```

## (I)nterface Segregation Principle (ISP)

Prinsip ini menyatakan bahwa klien tidak boleh dipaksa untuk bergantung pada antarmuka yang mereka tidak gunakan. Maksud dari pernyataan tersebut adalah suatu class tidak boleh dipaksa membuat properti atau method yang mana hal tersebut tidak diperlukan pada class tersebut. sebagai contoh kita memiliki interface yang didalamnya ada method GetRecords, GetRecord, Insert, Update, dan Delete. Ketika kita membuat suatu class kemudian implement pada interface tersebut maka class kita akan dipaksa membuat method-method tersebut karena sifat dari interface adalah kontrak yang berarti class yg implement harus membuat apa yang ada didalam interface yang diimplementnya.

```csharp

public interface Base
{
  List<T> GetRecords()
  T GetRecord(int id)
  int Insert(T entity)
  int Update(T entity)
  int Delete(T entity)
}

public class Book : Base
{
  public List<Book> GetRecords()
  {
    // detail code
  }

  public Book GetRecord()
  {
    // detail code
  }

  public int Insert(Book entity)
  {
    // detail code
  }

  public int Delete(int id)
  {
    // detail code
  }

  public int Update(int id)
  {
    // detail code
  }
}
```

Untuk mengatasi persoalan tersebut kita dapat membagi interface tersebut menjadi beberapa bagian misalnya kita buat interface khusus GetRecords, GetRecord dst, kemudian class hanya perlu implement interface-interface yang methodnya diperlukan saja.

```csharp

public interface GetRecords
{
  List<T> GetRecords()
}

public interface GetRecord
{
  T GetRecord(int id)
}

public interface Insert
{
  int Insert(T entity)
}

public interface Update
{
  int Update(T entity)
}

public interface Delete
{
  int Delete(T entity)
}


public class Book : GetRecords, Insert
{
    public List<Book> GetRecords()
  {
    // detail code
  }

  public int Insert(Book entity)
  {
    // detail code
  }
}
```

## 5. (D)ependency Inversion Principle

Prinsip ini menyatakan bahwa modul tingkat tinggi tidak boleh bergantung pada modul tingkat rendah. Keduanya harus bergantung pada abstraksi. Untuk lebih mudahnya kita bisa memperkecil scope penjelasan mengenai Clean Architecture sebagai salah satu implementasi dari prinsip ini. Pada Clean Architecture terdapat setidaknya empat buah layer yaitu domain, persistence, Application, dan Infrastructure, bayangkan sebuah bawng yang berlapis-lapis. lapisan terdalam yaitu domain sebagai inti, kemudian disusul oleh persistence, application, dan infrastructure, yang dimaksud modul pada pernyataan diatas adalah layer jadi layer application tidak boleh bergantung langsung pada layer persistence meskipun dia membutuhkannya tetapi harus melalui abstraksi yang biasanya dibuat pada layer domain.
