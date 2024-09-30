//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticeSetsButton : MonoBehaviour
{
    //this function loads the pages for practicing flashcards sets that already exist
    public void Click()
    {
        SceneManager.LoadScene("PracticeSets-SelectSet");
    }
}
