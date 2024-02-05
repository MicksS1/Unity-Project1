using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public string SceneName;
    
    public void ChangeSceneNow() {

        SceneManager.LoadScene(SceneName);
    }
}
