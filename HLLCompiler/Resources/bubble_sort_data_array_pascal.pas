program bubble_sort_data_array;

uses crt;

const
     max = 10;

type
    larik = array[1..max] of integer;

var
    data:larik;
    tahap, langkah:integer;
    ulang:char;

    procedure insert_data(var data:larik);

    begin
         data[1] := 24;
         data[2] := 41;
         data[3] := 73;
         data[4] := 88;
         data[5] := 89;
         data[6] := 64;
         data[7] := 41;
         data[8] := 18;
         data[9] := 64;
         data[10] := 73;
    end;

    procedure show_data(data:larik);

    var
         i:integer;

    begin
         for i := 1 to max do
         begin
              write(data[i], ' ');
         end;
    end;

    procedure ascending_bubble_sort(var data:larik; var tahap, langkah:integer);

    var
         i, j, temp:integer;

    begin
         tahap := 0;
         langkah := 0;
         for i := 1 to max - 1 do
         begin
              textcolor(14);gotoxy(37,12+tahap+langkah);write('TAHAP ',i);
              for j := max downto i + 1 do
              begin
                   if (data[j] < data[j - 1]) then
                   begin
                        temp := data[j];
                        data[j] := data[j - 1];
                        data[j - 1] := temp;
                   end;
                   inc(langkah);
                   delay(300);
                   gotoxy(25,12+tahap+langkah);
                   textcolor(15);show_data(data);
              end;
              inc(tahap);
         end;
    end;

begin
     repeat
           textcolor(15);gotoxy(24,2);write('ASCENDING BUBBLE SORT GURISA.COM');
           textcolor(14);gotoxy(24,3);write('~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~');
           textcolor(10);gotoxy(29,5);write('DATA SEBELUM DIURUTKAN');
           insert_data(data);
           textcolor(15);gotoxy(25,7);
           show_data(data);
           textcolor(10);gotoxy(29,10);write('PROSES PENGURUTAN DATA');
           textcolor(15);ascending_bubble_sort(data, tahap, langkah);
           textcolor(10);gotoxy(29,14+tahap+langkah);write('DATA SESUDAH DIURUTKAN');
           textcolor(15);gotoxy(25,16+tahap+langkah);show_data(data);
           textcolor(14);gotoxy(16,18+tahap+langkah);write('Pengurutan Terdiri Dari : ',tahap, ' Tahap & ',langkah,' Langkah');
           textcolor(14);gotoxy(22,20+tahap+langkah);write('Ulangi Proses Pengurutan [Y/T] : ');readln(ulang);
           clrscr();
     until (ulang = 'T') or (ulang = 't');
end.
