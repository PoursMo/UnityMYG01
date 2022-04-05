using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("coucou");
    }
    public void ChangerScene(string sceneName)
    {
        Debug.Log("restart cliqué " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

}
