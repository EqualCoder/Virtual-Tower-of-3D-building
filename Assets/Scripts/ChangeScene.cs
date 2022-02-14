using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{

    public string sceneName; 
    public Button loadSceneBtn;

    void Start() {

        loadSceneBtn.onClick.AddListener(Change);
    }

    void Change()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}