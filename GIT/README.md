##1. Apa itu GIT

Git merupakan aplikasi VCS atau `Version Control System` yang dapat digunakan untuk memantau perubahan _code_ pada _file_ proyek.

##2. Cara kerja GIT
![Github](/Image/Github.jpeg)

Pada git terdapat tiga tahapan utama yaitu _modified_, _staged_, dan _commited_. 
1. _Modified_ merupakan tahapan yang terjadi saat kita melakukan perubahan pada _code_ kita entah itu menambahkan, mengurangi atupun menghapus. Pada VS Code biasanya ditandai dengan warna kuning pada bagian kanan file yang mengalami perubahan.
2. _Staged_ adalah tahapan dimana kita menambahkan perubahan code pada `Staging Area`, perubahan dapat ditambahkan dengan cara per-file atau kumulatif dengan perintah dibawah ini.  

Perfile
``` 
git add nama_file 
```
Kumulatif
```
git add .
```
3. _Commited_ Tahapan terakhir dimana kita menyimpan perubahan code secara permanen kedalam repositori lokal kita. Setiap _commit_ memiliki pesan yang masing-masing memiliki arti spesifik yang menjelaskan perubahan yang dilakukan. untuk melakukan _commit_ dapat menggunakan perintah berikut.  
```
git commit -m "Pesan_yang_ingin_disampaikan"
```

##3. Konfigurasi

Untuk menggunakan git kita diharuskan melakukan konfigurasi agar dapat melakukan perintah-perintah git, kita dapat menggunakan perintah berikut :  
```
git config --global user.name "Isi_dengan_nama"
git config --global user.email "masukkan_email"
```

##4. Menambahkan Git pada direktori

Pada awalnya direktori kita hanya seperti folder biasa pada umumnya yang tidak dapat kita _track_ perubahan-perubahan yang ada didalamnya. Untuk menambahkan git pada direktori direktori kita dapat menggunakan perintah berikut.  
```
git init
```
