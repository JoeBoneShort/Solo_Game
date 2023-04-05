using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public void LoadGS1()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGS2()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGS3()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGS4()
    {
        SceneManager.LoadScene(3);
    }
}
