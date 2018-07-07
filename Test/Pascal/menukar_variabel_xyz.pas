{I.S : user memasukan nilai x, y, dan z}
{F.S : menampilkan nilai x, y, dan z dalam format (y,z,x)}

program menukar_variabel_xyz;

var
     input_x,input_y,input_z:integer;

begin
     writeln('Selamat datang di aplikasi Penukar Variabel xYz');
     write('Silahkan tekan enter untuk melanjutkan..');
     readln();
     writeln();
     write('Masukan nilai x : ');readln(input_x);
     write('Masukan nilai y : ');readln(input_y);
     write('Masukan nilai z : ');readln(input_z);
     writeln();
     writeln('Nilai setelah ditukar adalah : ','(',input_y,',',input_z,',',input_x,')');
     writeln();
     write('Silahkan tekan enter untuk keluar dari aplikasi..');
     readln();

end.
