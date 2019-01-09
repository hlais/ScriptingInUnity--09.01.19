using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour
{
    private void Start()
    {
        string[] collectionOfWords = new string[3];

        collectionOfWords[0] = "First Word";
        collectionOfWords[1] = "Second Word";
        collectionOfWords[2] = "thired Word";

        foreach (string item in collectionOfWords)
        {
            print(item);
        }
        //string is the data time 
        // in is key word
        //itterates through item one by one 
        //until it reaches the end
        // note this is only readOnly.
        //can not older the values
      
    }
}