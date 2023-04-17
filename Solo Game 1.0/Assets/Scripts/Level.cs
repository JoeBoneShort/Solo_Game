using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void GS1()
    {
        SceneManager.LoadScene(5);
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Instructions()
    {
        SceneManager.LoadScene(1);
    }
    public void Lore1()
    {
        SceneManager.LoadScene(2);
    }

    public void Lore2()
    {
        SceneManager.LoadScene(3);
    }

    public void Lore3()
    {
        SceneManager.LoadScene(4);
    }

    


}
