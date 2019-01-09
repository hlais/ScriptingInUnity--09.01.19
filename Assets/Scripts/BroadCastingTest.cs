using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadCastingTest : MonoBehaviour {

    private delegate void Numbers();
    Numbers numbers;
	// Use this for initialization
	void Start () {
        BroadcastMessage("TestBroadCast");
        numbers += Sing;
        numbers += SingPartTwo;

		
	}
	
	// Update is called once per frame
	void Update () {


        int methods = numbers.GetHashCode();
        
        Debug.Log(methods);
		
	}
    void Sing()
    {
        print("sing sing");
    }
    void SingPartTwo()
    {
        print("Juice Juice");
    }
}
