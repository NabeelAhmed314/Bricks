using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSetup : MonoBehaviour
{
    public static int obs = 9;

    // Update is called once per frame
    void Update()
    {
        if(obs == 0)
        {
            SceneManager.LoadScene("Won");
        }   
    }
}
