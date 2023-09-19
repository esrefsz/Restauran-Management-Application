Bu proje izleveogren youtube kanalından yararlanılarak yapılmıştır.

Projenin publish edilebilmesi için projeyi C:\ içerisine aktarıp publish edilmesi önerilir( Path uzun olursa bazı dll dosyalarına ulaşamayabiliyor.)

Oluşan klasörün içerisinde bir setup.exe oluşacak. Onu çalıştırınca program kurulmuş olacak.

Restorant adında bir database ile proje çalışabilmektedir. SQL management Server'a ".bak" uzantılı dosya import edilmelidir.

Projenin kurulduğu yerde "sqlPath.txt" adında bir dosya eklenmelis ve içerisinde "Server=MYSERVERNAME ;Database=Restorant; Trusted_Connection=true"
	"MYSERVERNAME" kısmına programın çalıştığı yerdeki sql servername yazılmalıdır.


FOR CODERS

Proje publish edilmeden önce app.config içerisinde girilerek servername kuracağınız bilgisayardaki servername yazılarak değiştirilir.

Eşrefhan Kadıoğlu
kadioglue17@itu.edu.tr
