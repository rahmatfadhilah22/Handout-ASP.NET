# API

## 1. Apa itu API

API adalah singkatan dari _Aplication Programming Interface_ yang berisikan sekumpulan protokol yang ditetapkan untuk membuat sebuah aplikasi berkomunikasi dengan aplikasi lainnya. protokol-protokol tersebut dapat berupa perintah mengambil, menambahkan, mengubah, dan menghapus data, atau bahkan dapat lebih kompleks. Misal dari UI ingin menambahkan data maka UI akan mengirim pesan ke API yang kemudian oleh API akan memberikan perintah untuk menambahkan data ke aplikas-aplikasi terkait. dari penjelasan tersebut API dapat diartikan sebagai perantara dua atau lebih aplikasi untuk berkomunikasi seperti pelayan pada restoran yang menghubungkan antara pelanggan dan koki.

## 2. RESTful
Berdasarkan arsitektur dan protocolnya API terdapat beberapa jenis seperti REST, gRPC, GraphQL, WebSockets, SOAP, dll. pada kelas ini kita akan membahas REST(Representational State Transfer), dimana pada arsitektur ini menggunakan HTTP untuk berkomunikasi dan GET, POST, PUT, Delete, dll sebagai Methodnya. Kemudian untuk mengirim parameter kita dapat menggunakan header yang diberi query parameters, ataupun body yang pada akhirnya akan menghasilkan data dalam format JSON(Javascript Object Notation).

## 3. Status Code
Dalam RESTful terdapat banyak status code yang memiliki artinya masing-masing, status code ini berada di rentang 100 - 500.
1.  100 - Biasanya seputar informasi bahwa server sudah menerima header (jarang dipakai).
2.  200 - Permintaan ke server berhasil.
3.  300 - Direct ke page/halaman tertentu (jarang dipakai).
4.  400 - Server tidak ditemukan, biasanya ini dikarenakan Client salah melakukan request, baik itu URL, Header, body, atau parameter lainnya.
5.  500 - Biasanya terdapat error yang terjadi pada sisi server.