using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cikar(topla(5,3));
        print(isim("Enes"));

        nameSurname("Enes", " Celik");
    }

    int topla(int x, int y)
    {
        return x+y;
    }

    void cikar(int sayi)
    {
        print(sayi - 5);
    }

    string isim(string isim)
    {
        return isim;
    }

    void EKranaYazdir(string isim)
    {
        print(isim);
    }

    void nameSurname(string name, string surname)
    {
        print(name + surname);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
