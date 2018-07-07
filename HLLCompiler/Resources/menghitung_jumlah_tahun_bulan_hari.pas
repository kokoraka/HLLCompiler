{I.S : user memasukan berapa lama proyek dikerjakan dalam hari}
{F.S : menampilkan berapa tahun, bulan, dan hari proyek dikerjakan}

program menghitung_jumlah_tahun_bulan_hari;

var
     tahun, bulan, hari, sisa_hari:integer;

const
     jumlah_tahun_hari = 365;
     jumlah_bulan_hari = 30;

begin
     writeln('Selamat datang di aplikasi Penghitungan Lama Proyek');
     write('Silahkan tekan enter untuk melanjutkan..');
     readln();
     writeln();
     write('Berapa hari proyek dikerjakan : ');readln(hari);
     tahun     := hari div jumlah_tahun_hari;
     sisa_hari := hari mod jumlah_tahun_hari;
     bulan     := sisa_hari div jumlah_bulan_hari;
     hari      := sisa_hari mod jumlah_bulan_hari;
     writeln();
     writeln('Proyek dikerjakan selama ',tahun, ' tahun ',bulan,' bulan ',hari,' hari');
     writeln();
     write('Silahkan tekan enter untuk keluar dari aplikasi..');
     readln();

end.
