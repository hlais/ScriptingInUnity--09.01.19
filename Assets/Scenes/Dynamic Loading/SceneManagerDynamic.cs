using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerDynamic : MonoBehaviour {

    /// <summary>
    /// -1) create an empty gameobject (gamema) in this is attached to Game
    /// </summary>
    public static SceneManagerDynamic Instance { set; get; }

    private void Awake()
    {
        Instance = this;
        
        Load("Scene1");
        Load("Scene2");
        Load("Player");
           
    }

    public void Load(string sceneName)
    {
        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            Debug.Log("loaded Sceene: ");
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }
    public void Unload(string sceneName)
    {
        if (SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            Debug.Log("Destroying?"+ sceneName);
            SceneManager.UnloadSceneAsync(sceneName);

        }
    }
}
