using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagementForScenes : MonoBehaviour
{
    public void PlayGame(int level)
    {
        SceneManager.LoadScene("Level" + level);
    }
}
