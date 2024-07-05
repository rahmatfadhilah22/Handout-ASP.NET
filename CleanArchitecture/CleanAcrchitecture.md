# Clean Architecture

## 1. Apa itu Clean Architecture

Clean architecture merupakan sebuah arsitektur perangkat lunak yang mengedepankan pemisahan tanggung jawab, independen, dan mudah di dilakukan pengujian. Pemisahan tanggung jawab bertujuan agar code lebih mudah untuk dipelihara (_maitainable_), kemudian independen dari pihak eksternal(Framework, package/library, UI dll), selain itu kita juga dapat dengan mudah melakukan pengujian pada masing-masing bagian karena satu bagian tidak terikat pada bagian lainnya.

arsitektur ini juga menekankan bahwa detail implementasi h aruslah terpisah dari logika bisnis, dengan aturan tersebut kita dapat mewujudkannya dengan membuat beberapa layer. Adapun layer-layer tersebut adalah domain(aturan bisnis dan Entitas), Persistence(interaksi dengan data store), Application(logika bisnus), dan Infrastucture(interaksi antar sistem).

## 1.Domain

Pada layer ini kita akan membuat sebuah entitas, dan aturan bisnis aplikasi yang kita kembangkan. entitas biasanya merupakan object class yang mewakili tabel pada database, aturan bisnis dibuat sebagai interface yang memuat properti atau method-method apa saja yang kemudian method-method tersebut akan dijabarkan pada class yang implement terhadap interface ini. Sederhananya pada layer ini berfokus pada apa yang perlu dilakukan oleh sistem bukan bagaimana hal tersebut bisa dilakukan.

## 2. Persistence

Layer ini juga dikenal sebagai DAL atau _data access layer_ dimana pada layer ini digunakan untuk berinteraksi dengan data store atau database. pada layer ini kita mungkin perlu melakukan instalasi beberapa package atau library seperti ORM jika diperlukan. selain itu pada layer ini kita akan melakukan implement pada interface(repository) yang sudah dideklarasikan pada layer domain. Pada layer ini juga biasanya berisi operasi CRUD.

## 3. Application

Layer ini bertanggung jawab pada logika bisnis aplikasi. sebagai contoh pada layer interface kita memiliki method transaksi atau pembelian buku, maka bagaimana hal itu bisa terjadi akan di implementasi pada layer ini seperti mendapatkan data buku, memasukkan informasi buku pada log pembelian , dan update jumlah buku. mendapatkan, memasukkan, dan update merupakan method-method terpisah yang kemudian dikoordinir pada layer ini.

## 4. Infrastructure

Seperti yang sudah dijelaskan diatas, layer ini kita gunakan sebagai interaksi antar sistem, sebagai contoh dengan sistem atau aplikasi Frontend. Pada API dengan arsitektur Restful layer ini biasanya akan digunakan untuk UI mengirim requst pada sistem kita melalui protocol http/s. Misalnya user ingin data dengan jumlah baris tertentu maka FE dapat mengirim request sesuai method yang sudah kita deklarasi barulah dari method tersebut akan diteruskan pada Application sebagai layer bagaimana user dapat mendapatkan data dengan jumalh baris tertentu. Selain itu kita juga dapat membuat proses autentikasi dan autorisasi pada layer ini.
