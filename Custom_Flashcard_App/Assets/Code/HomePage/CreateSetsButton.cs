//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateSetsButton : MonoBehaviour
{
    //this function loads the pages for creating new flashcard sets
    public void Click()
    {
        SceneManager.LoadScene("CreateFlashcards-Naming");
    }
}
