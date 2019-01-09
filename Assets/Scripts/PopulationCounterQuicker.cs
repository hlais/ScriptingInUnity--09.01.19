using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class PopulationCounterQuicker : MonoBehaviour
{

    [SerializeField] GameObject timer;
    public InputField userInput;
    TimeSpan miliSecs = new TimeSpan();

    long timeUpdater;
    long initialvalue;

    long totalTime;
    string displayCounter;

    private void Update()
    {
        if (initialvalue > Mathf.Epsilon)
        {
            long ms = (long)(Time.deltaTime * 10f);
          
            timeUpdater += ms;
            print(timeUpdater);

            //timeUpdater += (int)miliSecs.TotalMilliseconds;
            //int roundedsecs = timeUpdater;
            //totalTime = initialvalue + roundedsecs;
            displayCounter = timeUpdater.ToString("n");

            timer.GetComponent<Text>().text = displayCounter.Remove(displayCounter.Length -3 );
        }


    }


    public void TextInputInitialValue()
    {

        initialvalue = long.Parse(userInput.text);


    }
}
