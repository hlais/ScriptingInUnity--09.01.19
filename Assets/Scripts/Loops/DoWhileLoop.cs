using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour {

    // whille loop test the condition before the body
    // doWhile Loops test the condition after the body 
    //meaning that doWhile statement gets excuted at least once

    
	void Start ()
    {
        bool shouldContinue = false;
        do
        {
            print ("Hello World");

        } while (shouldContinue == true);

        //if !shouldContinue it will run an infinite loop. Will need to EndTask=> Unity.

    }
	

}
