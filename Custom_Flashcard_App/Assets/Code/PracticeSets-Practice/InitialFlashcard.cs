//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialFlashcard : MonoBehaviour
{
    //initialize variables
    public ArrayList flashcardSet;
    public Text flashcard;

    //this function is called once when the page first loads
    //this function creates the first flashcard that can then be changed as necessary for the user's practicing needs
    public void Start()
    {   
        flashcardSet = MainManager.Instance.allFlashcardSets[MainManager.Instance.selectedSet];
        flashcard.GetComponent<Text>().text = flashcardSet[0].ToString();
    }
}
