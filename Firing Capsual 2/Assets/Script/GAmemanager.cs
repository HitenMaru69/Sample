using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAmemanager : MonoBehaviour
{
    bool isGameend = false;
    // Start is called before the first frame update

    public void Restartlevel()
    {
        if (isGameend == false)
        {
            isGameend = true;
            Invoke("Restart", 1f);

        }
    }
    public void Quitmenu()
    {
        if (isGameend == false)
        {
            isGameend = true;
            Invoke("Quit", 1f);

        }
    }
    public void Bossmenu()
    {
        if (isGameend == false)
        {
            isGameend = true;
            Invoke("Boss", 1f);

        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Level");
    }

    void Quit()
    {
        Application.Quit();
    }

    void Boss()
    {
        SceneManager.LoadScene("Bossfight");
    }
   
}
