//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonPracticePage : MonoBehaviour
{
    //this function loads the home page
    public void click()
    {
        SceneManager.LoadScene("HomePage");
    }
}
