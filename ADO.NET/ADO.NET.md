# ADO.NET

## Apa itu ADO.NET
ADO.NET merupakan library yang disediakan oleh .NET, umumnya library ini digunakan untuk agar aplikasi dan database dapat berinteraksi.

## Setup dan penggunan
Kita perlu menginstall library `System.Data.SqlClient` untuk SQL Server, setelah menginstall library tersebut selanjutnya kita dapat menggunakannya dengan menambahkan using System.Data.SqlClient; pada bagian atas code kita. 

## Koneksi
Untuk membuat aplikasi kita terkoneksi dengan database kita perlu menambahkan koneksinya dengan cara : 
````csharp
private static string connectionString = "koneksi_database";
(SqlConnection connection = new SqlConnection(connectionString)
````
## Open, Close, dan Dispose
Setelah membuat koneksi kita perlu membuka, menutup, dan dispose koneksi tersebut secara tepat, hal ini diperlukan untuk menejemen memory. Open digunakan untuk membuka _state_ dari koneksi terserbut, close adalah kebalikan dari open, dan Dispose adalah menghancurkan koneksi. Kalau di analogikan pada jembatan, maka connectionString itu adalah proses membuat jembatan, open adalah membuka palang penutup, kemudian close adalah menutup palangnya kembali sedangkan dispose adalah merubuhkan jembatan tersebut. Ketiga proses tersebut dapat dilakukan dengan code berikut :
```csharp
    connection.Open()
    connection.Close()
    connection.Dispose()
```

## Mengirim perintah pada database
Kita dapat mengirim perintah pada database untuk melakukan sesuatu sebagaimana kita melakukan query pada database tersebut. kita dapat menggunakan class SqlCommand seperti ini :

```csharp
SqlCommand command = new SqlCommand(query, connection)
```

## Parameterisasi
Bila kita ingin mengirim query yang dinamis kita perlu menggunakan parameterisasi untuk mencegah SQL Injection. kita dapat melakukannya dengan perintah berikut :

```csharp
command.Parameters.AddWithValue("@CategoryID", categories.CategoryID);
command.Parameters.AddWithValue("@CategoryName", categories.CategoryName);
command.Parameters.AddWithValue("@Description", categories.Description);
command.Parameters.AddWithValue("@Picture", categories.Picture);
```
