using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayStatsIterator : MonoBehaviour
{
    [SerializeField] GameObject[] counter;
    float time = 10f;
    bool isSwitching = true;

    [SerializeField]GameObject[] textObjects;

    [SerializeField] GameObject button;

    float timeUpdater;
    public float speedOfTime = 2.5f;
    long initialvalue;

    long totalTime;

    float nextTime = 10f;

    bool isSwitchingAllowed = false;

    // Update is called once per frame
    private void FixedUpdate()
    {


        if (isSwitchingAllowed)
        {
            timeUpdater += Time.fixedDeltaTime * speedOfTime;

            long roundedsecs = (long)timeUpdater;
            totalTime = initialvalue + roundedsecs;

            if (totalTime > time)
            {
                if (isSwitching)
                {
                    SwitchObjects();
                }
                if (!isSwitching)
                {
                    SwitchObjectsAgain();
                }
                time += nextTime;
            }

            isSwitching = !isSwitching;
            //setting second object to the centre of screen
            counter[1].transform.position = new Vector3(0, 0, 100);
            Debug.Log("Object ONe " + counter[1].transform.position);
            counter[0].transform.position = new Vector3(0, 0, 100);
        }




    }
    public void SetEnable()
    {
        isSwitchingAllowed = true;
        button.SetActive(false);

    }
    

    
    void SwitchObjects()
    {
       
        if (counter[1] == isActiveAndEnabled)
        {
            counter[1].SetActive(false);
        }
        if (counter[0] == isActiveAndEnabled)
        {
            counter[0].SetActive(true);
        }
    }
    void SwitchObjectsAgain()
    {
        if (counter[1] == isActiveAndEnabled)
        {
            counter[1].SetActive(true);
        }
        if (counter[0] == isActiveAndEnabled)
        {
            counter[0].SetActive(false);
        }

    }
}


