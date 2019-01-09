using UnityEngine;
using System;


public class ClockAnimator : MonoBehaviour
{
    [SerializeField] Transform hours, mins, seconds;
    public GameObject characterOne;

    private const float hoursToDegree = 360 / 12f;
    private const float minsToDegree = 360 / 60f;
    private const float secondsToDegree = 360 / 60f;

    public bool analog;

    private void Update()
    {


        if (Input.GetKey(KeyCode.DownArrow))
        {
            characterOne.SetActive(false);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            characterOne.SetActive(true);
        }
        if (analog)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            hours.localRotation = Quaternion.Euler(0, 0, hoursToDegree * -(float)time.TotalHours);
            mins.localRotation = Quaternion.Euler(0, 0, minsToDegree * -(float)time.TotalMinutes);
            seconds.localRotation = Quaternion.Euler(0, 0, secondsToDegree * -(float)time.TotalSeconds);
            
        }
        else
        {
            DateTime time = DateTime.Now;
            // minus values becuase Unity uses left hand co-ordinate system
            hours.localRotation = Quaternion.Euler(0, 0, hoursToDegree * -time.Hour);
            mins.localRotation = Quaternion.Euler(0, 0, minsToDegree * -time.Minute);
            seconds.localRotation = Quaternion.Euler(0, 0, secondsToDegree * -time.Second);
        }

    }


}