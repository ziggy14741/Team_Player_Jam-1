using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttontonextscene : MonoBehaviour
{
    public void SceneChange(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
