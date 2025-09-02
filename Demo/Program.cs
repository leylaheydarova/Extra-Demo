//static void Atm()
//{
//    int money = 1000;
//    Console.WriteLine("Welcome to the ATM!");
//    Console.WriteLine("Etmek istediyiniz emeliyyati secin: (1: Balans, 2: Pul cekmek, 3: Pul yatirmaq, a: Cixis)");
//    string option = Console.ReadLine();

//    switch (option)
//    {
//        case "1":
//            Console.WriteLine("Balansiniz: " + money);
//            Console.ReadLine();
//            break;
//        case "2":
//            Console.WriteLine("Ne qeder pul cekmek isteyirsiniz?");
//            int price = Convert.ToInt32(Console.ReadLine());
//            if (price >= money)
//            {
//                Console.WriteLine("Balansinizda kifayet qeder pul yoxdur");
//            }
//            else if (price <= money)
//            {
//                money -= price;
//                Console.WriteLine($"Emeliyyat ugurlu oldu. Yeni balansiniz: {money}");
//            }
//            else
//            {
//                Console.WriteLine("Emeliyyat ugurlu oldu. Yeni balansiniz: " + money);
//            }
//            break;
//        case "3":
//            Console.WriteLine("Ne qeder pul yatirmaq isteyirsiniz?");
//            int addmoney = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Emeliyyat ugurlu oldu. Yeni balansiniz: " + (money + addmoney));
//            break;
//        case "a":
//            Console.WriteLine("ATM-den cixis edilir...");
//            Console.WriteLine("Xeyirle xercleyin!");
//            Console.ReadLine();
//            break;
//        default:
//            Console.WriteLine("Duzgun emeliyyat secin");
//            Console.ReadLine();
//            break;
//    }
//}

var variable1 = 3;
int sum = variable1 + 1;
object variable2 = 5; //boxing
sum = (int)variable2 + 2; //unboxing
dynamic variable3 = 1;
string sum1 = variable3 + 2;
Console.WriteLine(sum1);

//var - cari anda menimsedilmis deyerin tipini derhal taniyir.
//object - qutulasdirir, ve isletmek ucun qutudan acib ezerinde emeliyyat apara bilirik.
//dynamic - compile zamani hec cur mudaxile qebul etmir. Ne erroru bilinir, ne de tipi. Yalniz run olandan
//sonra tipini taniyir.

//ortaq cehetleri:  istenilen tipi goture bilirler.
