using System;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    //insert gameobject with camera components
    public GameObject[] objects;
   
    private int m_CurrentActiveObject;

    public void NextCamera()
    {
        int nextactiveobject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(i == nextactiveobject);
        }

        m_CurrentActiveObject = nextactiveobject;
       
    }
    private void Update()
    {
        //input to swtich camera
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            NextCamera();
            
        }
    }
}
