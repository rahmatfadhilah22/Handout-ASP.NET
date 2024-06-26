## 1. Apa itu GIT

Git merupakan aplikasi VCS atau `Version Control System` yang dapat digunakan untuk memantau perubahan _code_ pada _file_ proyek.

## 2. Cara kerja GIT
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

## 3. Konfigurasi

Untuk menggunakan git kita diharuskan melakukan konfigurasi agar dapat melakukan perintah-perintah git, kita dapat menggunakan perintah berikut :  
```
git config --global user.name "Isi_dengan_nama"
git config --global user.email "masukkan_email"
```

## 4. Menambahkan Git pada direktori

Pada awalnya direktori kita hanya seperti folder biasa pada umumnya yang tidak dapat kita _track_ perubahan-perubahan yang ada didalamnya. Untuk menambahkan git pada direktori direktori kita dapat menggunakan perintah berikut.  
```
git init
```

## 5. Branch
Terkadang kita ingin mengisolasi _soruce code_ kita untuk kepentingan pengembangan fitur baru. Misalnya kita membuat aplikasi kalkulator yang saat ini hanya bisa melakukan operasi matematika dasar, kemudian ingin kita kembangan untuk melakukan opreasi matematika lanjutan seperti _differecial, integral_ dll. jika kita langsung mengubah-ubah _soruce code_ berpotensi menghasilkan _error_ dan jika ingin segera menggunakan aplikasi tersebut kita harus memperbaiki semua _error_ itu atau mengembalikan ke _source code _ sebelumnya, dan itu tidaklah efektif. Untuk mengatasi permasalahan tersebut kita dapat menggunakan _branch_ atau percabangan, jadi kita bisa membuat cabang baru khusus pengembangan fitur tersebut. untuk membuat percabangan dapat menggunakan perintah berikut :
```
git branch nama_branch
```
untuk berpindah ke branch tertentu dapat meggunakan :
```
git checkout nama_branch
```
untuk melihat daftar branch dapat menggunakan :
```
git branch
```

## 6. Merge
Sebelumnya kita sudah bisa melakukan percabangan agar memudahkan pengembangan fitur baru, kemudian jika fitur tersebut sudah berhasil dibuat kita bisa melakukan _merge_ atau menggabungkan _source code_ tambahan tersebut ke branch lainnya, atau branch utama. untuk melakukan itu kita perlu berpindah ke branch yang ingin digabungkan, contoh jika fitur baru tersebut berada di branch B maka kita perlu ke branch A atau lainnya kemudian melakukan merge, dengan perintah berikut:
```
git merge nama_branch
```

## 7. Remote Repository

Penjelasan 1 - 6 merupakan penggunaan git pada level _local_ sekarang kita ingin menggunakan git untuk keperluan bekerja sama antar developer yang pasti mereka memiliki _repository local_ masing-masing, untuk itu kita perlu menggunakan _remote repository_ untuk berinteraksi. Kita dapat menggunakan Github, Gitlab, Bit Bucket atau yang lain sebagai _remote repository_. topik yang penting kita ketahui adalah remote, push, dan pull yang akan kita bahas selanjutnya.

## 8. Remote

Setelah membuat Repository pada github kita dapat mengambil URL/SSH nya agar git _repository local_ kita dapat terhubung dengan yang ada di _remote repository_. Untuk melakukan hal tersebut kita dapat menggunakan perintah :
```
git remote add nama_remote url_remote
git remote add origin https://github.com/rahmatfadhilah22/Handout-ASP.NET.git
```
sekarang jika kita ingin berinteraksi pada remote repository kita cukup menggunakan nama remote tersebut(orgin).

## 9. Push
Push merupakan proses dimana kita ingin mengirim source code terbaru yang berada pada _local repository_ ke _remote repository_. Untuk melakukan proses tersebut kita dapat menggunakan perintah berikut :
```
git push origin nama_branch_remote_server
git push origin master
```
dimana origin tersebut adalah alamat _remote repository_.

## 10. Fetch dan Pull
Selain mengirim _source code_ terbaru, kita juga dapat mengetahui perubahan _source code_ terbaru pada _remote repository_. Untuk mengetahui perubahan kita dapat menggunakan fetch, sedangkan jika kita ingin mengetahui sekaligus merge code yang ada di repository local dan remote repository kita dapat menggunakan pull. kita dapat melakukan kedua proses tersebut dengan perintah berikut:

```
git fetch origin nama_branch_remote_server
git pull origin nama_branch_remote_server
```
