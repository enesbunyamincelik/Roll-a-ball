using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Car vehicle_1 = new Car();

        vehicle_1.brand = "BMW";
        vehicle_1.model = "X5";
        vehicle_1.price = 500000;

        print(vehicle_1.brand);
        print(vehicle_1.model);
        print(vehicle_1.price);

        Car vehicle_2 = new Car();

        vehicle_2.brand = "Lamborgihini";
        vehicle_2.model = "Avantador";
        vehicle_2.price = 67000000;
        

        print(vehicle_2.brand);
        print(vehicle_2.model);
        print(vehicle_2.price);




        


        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
