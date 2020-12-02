using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour {

    public void LoadTitle()
    {
        SceneManager.LoadScene(0);

    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadBacklog()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadSave()
    {
        SceneManager.LoadScene(3);
    }
}
