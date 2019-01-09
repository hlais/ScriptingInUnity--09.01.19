using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePicker : MonoBehaviour {

    private void Awake()
    {
        //to keep object persisting
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update () {

        //Whatever Input you want 
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LoadNextLevel();
           
        }
		
	}
    void LoadNextLevel()
    {
        int m_level = SceneManager.GetActiveScene().buildIndex;
        int nextLevel = m_level + 1;
        if (nextLevel == SceneManager.sceneCountInBuildSettings)
        {
            nextLevel = 0;
        }
        SceneManager.LoadScene(nextLevel);
    }
}
