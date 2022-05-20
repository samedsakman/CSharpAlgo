1. FootballPlayer base sınıfı oluşturularak;

- FullName, ShirtNumber, ShortPass, Tackling, Shooting, Decisions, Teamwork, Pace, Stamina, NaturalFitness özellikleri eklenecektir. 
- Bu sınıfın Constructor Metodu bir string (fullName) ve bir int (shirtNumber) değeri dışarıdan alacak, kalan özellikler ise 50 ila 90 arasında rastgele değerlerle üretilecektir.

- Bu sınıf içerisinde double değer döndüren GeneralScore() isimli bir metot üretilecektir. Yukarıda oluşturulan özellikler %10 ila %40 arasında değişen rastgele katsayılarla bu fonksiyonda yer alacaktır.(Örneğin: Passing * 0.2)

2. GoalKeeper sınıfı oluşturulacak ve FootballPlayer sınıfından kalıtım alacaktır. 

- Handling, Reflexes, AerialAbility ve OneAndOnes özellikleri eklenecektir.
- Bu sınıfın Constructor Metodu, sınıfa ait özelliklere 60 ila 100 arasında rastgele değerler üretilerek oluşturulacaktır.
- Bu sınıfta double değer döndüren SavingPlay() isimli bir metot yer alacaktır. Bu metot, sınıfa ait özelliklerin %30 ila %60 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını döndürecektir. (Örneğin: Handling * 0.5 + ........ + GeneralScore();)
- Bu sınıfta double değer döndüren PassingPlay() isimli bir metot yer alacaktır. Bu metot, base sınıfa ait ShortPass, Decisions ve Teamwork özelliklerinin %20 ila %30 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: ShortPass * 0.4 + ........ + GeneralScore();)

3. Defender Sınıfı oluşturulacak ve FootballPlayer sınıfından kalıtım alacaktır.
- Strenght, Marking, Heading, Jumping özellikleri eklenecektir.
- Bu sınıfın Constructor Metodu, sınıfa ait özelliklere 50 ila 80 arasında rastgele değerler üretilerek oluşturulacaktır.
- Bu sınıfta double değer döndüren TacklingPlay() isimli bir metot yer alacaktır. Bu metot, sınıfa ait özelliklerin %30 ila %60 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: Marking * 0.4 + ........ + GeneralScore();)
- Bu sınıfta double değer döndüren PassingPlay() isimli bir metot yer alacaktır. Bu metot, base sınıfa ait ShortPass, Decisions ve Teamwork özelliklerinin %20 ila %30 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: ShortPass * 0.4 + ........ + GeneralScore();)
- Bu sınıfta double değer döndüren FinishingPlay() isimli bir metot yer alacaktır. Bu metot, base sınıfa ait Shooting, Pace ve Teamwork özelliklerinin %10 ila %20 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: Tackling * 0.4 + ........ + GeneralScore();)

4. Midfielder Sınıfı oluşturulacak ve FootballPlayer sınıfından kalıtım alacaktır.
- Technique, LongPass, FirstTouch, Positioning özellikleri eklenecektir.
- Bu sınıfın Constructor Metodu, sınıfa ait özelliklere 50 ila 80 arasında rastgele değerler üretilerek oluşturulacaktır.
- Bu sınıfta double değer döndüren PassingPlay() isimli bir metot yer alacaktır. Bu metot, sınıfa ait özelliklerin %30 ila %60 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: Technique * 0.3 + ........ + GeneralScore();)
- Bu sınıfta double değer döndüren TacklingPlay() isimli bir metot yer alacaktır. Bu metot, base sınıfa ait Tackling, Stamina ve Natural Fitness özelliklerinin %20 ila %30 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: Tackling * 0.4 + ........ + GeneralScore();)
- Bu sınıfta double değer döndüren FinishingPlay() isimli bir metot yer alacaktır. Bu metot, base sınıfa ait Shooting, Pace ve Teamwork özelliklerinin %10 ila %20 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: Tackling * 0.4 + ........ + GeneralScore();)

5. Attacker Sınıfı oluşturulacak ve FootballPlayer sınıfından kalıtım alacaktır.
- Finishing, Dribbling, OffTheBall, Acceleration özellikleri eklenecektir.
- Bu sınıfın Constructor Metodu, sınıfa ait özelliklere 50 ila 80 arasında rastgele değerler üretilerek oluşturulacaktır.
- Bu sınıfta double değer döndüren FinishingPlay() isimli bir metot yer alacaktır. Bu metot, sınıfa ait özelliklerin %30 ila %60 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: Finishing * 0.5 + ........ + GeneralScore();)
- Bu sınıfta double değer döndüren PassingPlay() isimli bir metot yer alacaktır. Bu metot, base sınıfa ait ShortPass, Decisions ve Teamwork özelliklerinin %20 ila %30 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: ShortPass * 0.4 + ........ + GeneralScore();)
- Bu sınıfta double değer döndüren TacklingPlay() isimli bir metot yer alacaktır. Bu metot, base sınıfa ait Tackling, Stamina ve Natural Fitness özelliklerinin %10 ila %20 arasında değişen rastgele katsayılarla çarpımı ile base sınıfa ait GeneralScore() metodunun toplamını dönderecektir. (Örneğin: Tackling * 0.4 + ........ + GeneralScore();)

NOT: FullName ve ShirtNumber dışında Hiçbir property'e dışarıdan değer atanamayacaktır.

OYUN KURALLARI
- Her iki Kullanıcıdan da yerleşim taktiği ve takım ismi girilmesi istenecektir. (4-4-2, 4-3-3, 3-4-3, 3-5-2 veya 3-6-1 taktiklerine izin verilecektir.)
- Kullanıcıların girmiş olduğu taktik yerleşim ile her oyuncu kendi sınıfından türetilerek iki takım oluşturulacaktır. (Örneğin: 4-3-3 girilmişse 1 kaleci, 4 defans vb. gibi)
- Oyun rastgele seçilen bir oyuncu ile PassingPlay() metodu çağrılarak başlayacaktır. Seçilen oyuncunun karşısına diğer takımdan rastgele bir oyuncu seçilecektir. Seçilen oyuncunun TacklingPlay() değeri ilk seçilen oyuncunun PassingPlay() değerinden yüksekse top ikinci seçilen oyuncuya geçecektir. Değilse top ilk takımdan seçilen oyuncudan ikinci rastgele seçilen oyuncuya geçecektir (Not: Oyuncu tekrar kendine pas veremez). Bu şekilde üst üste 3 pas yapabilen takım şut hakkı kazanacaktır ve şut için rastgele seçilen oyuncunun FinishingPlay() değeri kalecinin SavingPlay() değerinden büyükse gol olacaktır ve ekrana GOLLLLLL!!! FirstName ve ShirtNumber bilgileri yazdırılacaktır.
- Gerçekleşen her başarılı veya başarısız işlem ekrana yazdırılacaktır.

BONUS
- Oyun iki dakika sürecektir ve süre sonunda skor bilgisi ekrana yazdırılacaktır.

