using PatikaWeek5Kapanis;
//Döngü çıkış değişkeni
bool exit = false;
//Üretilen arabaların tutulacağı liste tanımlaması
List<Car> Cars = new List<Car>();
Console.WriteLine("Hoşgeldiniz");

while (!exit)
{
    // Bir defa olmak üzere araba üretimi yapılmak istenmesi sorulur
    Console.WriteLine("Araba üretimi yapmak istermisiniz? e/h");
    string choice = Console.ReadLine().ToLower();

    // Kullanıcının girişine göre araba üretimi yada programı kapatıcak if döngüsü
    if (choice == "e")
    {
        do
        {
            // Yeni bir araba üretimi
            Car car1 = new Car();

            Console.WriteLine("Lütfen Seri Numarası Giriniz:");
            car1.SerialNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Marka Bilgisi Giriniz:");
            car1.Brand = Console.ReadLine();

            Console.WriteLine("Lütfen Model Bilgisi Giriniz:");
            car1.Model = Console.ReadLine();

            Console.WriteLine("Lütfen Araç Rengini Giriniz:");
            car1.Color = Console.ReadLine();

        cAgain://Kapı sayısına sayı dışında bir değer girildiğinde mesaj ekranından sonra atlanacak satır
            Console.WriteLine("Lütfen Kapı Sayısını Giriniz:");
            string input = Console.ReadLine();
            try
            {
                car1.Door = int.Parse(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen sayısal bir değer giriniz.");
                goto cAgain; 
            }

            // Üretilen araba nesnesinin listeye eklenmesi
            Cars.Add(car1);

            // Kullanıcıya tekrar üretim yapmak istenmesinin sorulması
            Console.WriteLine("Başka bir üretim yapmak istermisiniz? e/h");
            string input1 = Console.ReadLine().ToLower();

            if (input1 == "h")
            {
                exit = true;  
            }

        } while (!exit);  
    }
    else if (choice == "h")
    {
        exit = true;  
    else
    {
        Console.WriteLine("Geçersiz giriş. Lütfen 'e' veya 'h' giriniz.");
    }
}

Console.WriteLine("Üretilen arabalar:");

foreach (var item in Cars)
{
    Console.WriteLine($"Seri Numarası: {item.SerialNo}, Markası: {item.Brand}");
}

Console.WriteLine("Program sonlandı.");