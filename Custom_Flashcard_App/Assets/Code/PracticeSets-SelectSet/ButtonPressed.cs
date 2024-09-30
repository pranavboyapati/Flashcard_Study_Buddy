//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPressed : MonoBehaviour
{
    //this function loads the page for practicing the flashcard set the user selected
    public void Clicked()
    {
        MainManager.Instance.selectedSet = this.GetComponentInChildren<Text>().text;
        SceneManager.LoadScene("PracticeSets-Practice");
    }
}