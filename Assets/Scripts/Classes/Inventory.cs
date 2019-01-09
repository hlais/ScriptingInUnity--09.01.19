using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    //sub class created
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        //custom contructors that takes in parameters
        //NOTE name of contructor is name of the class
        //Contructors dont have return type, and dont use void
        //class can have multiple contructors
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
        //custom contructors that takes in parameters
        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        // Default Constructor, giving default values to the members of the class
        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }


    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    void Start()
    {
        
        Debug.Log(myStuff.bullets);
    }
}