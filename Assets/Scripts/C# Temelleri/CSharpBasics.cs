using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpBasics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // string;
        // string sonuc = "Ball fell down.";
        // print(sonuc);

        // integer; 2,5,35,7647,83835
        // int x = 56;
        // print(x);

        // float; 3,14, 55.77, 3802.3842
        // float y = 3.14f;
        // print(y);

        // var;

        // var a = 3.14f;
        // var b = 5;
        // var c = "Ball fell down.";

        // print(a);
        // print(b);
        // print(c);

        // print(1+1);

        // bool x = true;
        // bool y = false;

        // print(x);
        // print(y);

        // var x = 1;
        // var y = 2;

        // var x = "1";
        // var y = "2";

        // var x = "Enes ";
        // var y = "Celik";

        // var x = "123 ";
        // var y = "245";

        // var a = "Senatech";
        // var b = 12;
        // var c = 3.14f;

        // print(a + " " + b + " " + c);

        // a = "Enes Celik";
        // b = 17;
        // c = 5.16f;

        // print(a + " " + b + " " + c);

        // Expression that indicate size ////////////////////////////////////////////

        // buyuktur >
        // print(6>5);

        // kucuktur <
        // print(5<6);

        // esittir ==
        // print(5==6);

        // buyuk esittir >=
        // print(6>=5);

        // kucuk esittir <=
        // print(5<=6);

        // Conditional Statements if-else-else if ////////////////////////////////////////

        // var a = 5;
        // var b = 6;
        // var c = 5;

        // if (a==b)
        // {
        //     print("a, b'ye esittir.");
        // }else if(a==c)
        // {
        //     print("a, c'ye esittir");
        // }else
        // {
        //     print("a, b'ye ve c'ye esit degildir.");
        // }

        // while loop ////////////////////////////////////////////

        // var x = 0;

        // while(x<5)
        // {
        //     x = x+1;
        //     print(x);
        // }

        // do-while loop ////////////////////////////////////////////

        // var x = 0;

        // do
        // {
        //     x = x+1;
        //     // x += 1;
        //     print(x);

        // }while(x<5);

        // SORU ///////////////////////////////////////////////////////// ONEMLI

        // var x = 0;

        // do
        // {
        //     x += 4;
        //     print(x);

        // }while(x<5);

        // Ciktisi neden 4 ve 8? 8, 5'den buyuk bir sayi olmasina ragmen??

        // switch-case structre ///////////////////////////////////////////////

        // var x = 1;

        // switch(x) // => x'in degerine bakilir.
        // {
        //     case 1: print("x'in degeri 1'dir.");
        //         break;
        //     case 2: print("x'in degeri 2'dir.");      // case => ise
        //         break;
        // }

        // for loop /////////////////////////////////////////////////

        // int x;
        // // Tanimlama-Sart-Yapilacak
        // for(x = 0; x < 5; x += 1)
        // {
        //     print(x);
        // }

        // Lists ///////////////////////////////////////////////////////

        // List<string> gunler = new List<string>();

        // gunler.Add("Pazartesi");
        // gunler.Add("Sali");
        // gunler.Add("Carsamba");

        // print(gunler);

        // Iterable Object => icinde birden fazla nese bulunduran objelere denir.
        // int x = 5;
        // string isim = "Enes";

        // print(isim);

        // foreach (var item in gunler)
        // {
        //     print(item);
        // } 

        // Array

        // string[] daysArray = {"Monday", "Tuesday", "Wednesday"};

        // foreach (var day in days)
        // {
        //     print(day);
        // }

        // print(daysArray[0]);

        // ArrayList

        // ArrayList random = new ArrayList();

        // random.Add(2);
        // random.Add("Enes");
        // random.Add(3.14f);

        // foreach (var item in random)
        // {
        //     print(item);
        // }

        // print(random[0]);
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}