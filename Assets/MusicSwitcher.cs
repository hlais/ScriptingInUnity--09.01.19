using System;
using UnityEngine;
using UnityEngine.UI;

public class MusicSwitcher : MonoBehaviour
{
    public GameObject[] musicObjects;
    private int m_CurrentMusicObject;



    public void MusicSwitch()
    {
        int nextactiveobject = m_CurrentMusicObject + 1 >= musicObjects.Length ? 0 : m_CurrentMusicObject + 1;

        for (int i = 0; i < musicObjects.Length; i++)
        {
            musicObjects[i].SetActive(i == nextactiveobject);
        }

        m_CurrentMusicObject = nextactiveobject;
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MusicSwitch();
        }
    }
}