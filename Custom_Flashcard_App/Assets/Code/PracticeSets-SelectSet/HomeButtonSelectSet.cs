//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonSelectSet : MonoBehaviour
{
    //this function loads the home page
    public void Clicked()
    {   
        SceneManager.LoadScene("HomePage");
    }
}
