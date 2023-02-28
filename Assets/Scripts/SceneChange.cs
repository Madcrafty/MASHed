using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //public int sceneIndex = 0;
    // Start is called before the first frame update
    void ChangeScene()
    {
    }
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
