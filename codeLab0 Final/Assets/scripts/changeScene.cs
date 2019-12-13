using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    // Use this for initialization


    public string sceneName;
    public void Click()
    {
        Debug.Log("enter" + sceneName + "level");
        Application.LoadLevel(sceneName);
    }
}

