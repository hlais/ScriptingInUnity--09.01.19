using UnityEngine;
using System;


public class VariableAndFunctions : MonoBehaviour
{
    //variable
    //intialising a value
    int myInt = 5;

    //Start gets run when we enter a scene
    //void does not return 
    private void Start()
    {
        myInt = 55;
        Debug.Log(MultiplyByTwo(myInt));

        //we can assign the value
        //myInt = MultiplyByTwo(myInt);
    }
    //this has return type
    int MultiplyByTwo(int number)
    {
        int ret;
        ret = myInt * 2;
        return ret;
    }
}