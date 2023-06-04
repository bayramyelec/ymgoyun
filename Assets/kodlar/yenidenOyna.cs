using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenidenOyna : MonoBehaviour
{

    public void YenidenOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        hak.kalanHak = 3;
        Time.timeScale = 1;
    }

}

    
