//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipCard : MonoBehaviour
{
    //initialize variables
    public ArrayList flashcards;
    public Text flashcardText;

    //this function flips the flashcard so that the user can see the term/definition
    public void ClickCard()
    {
        flashcards = MainManager.Instance.allFlashcardSets[MainManager.Instance.selectedSet];
        string currentFlashcardText = flashcardText.GetComponent<Text>().text;
        int index = flashcards.IndexOf(currentFlashcardText);

        if (index % 2 == 0)
        {
            //term is showing currently; need to update text to 1 index position further
            flashcardText.GetComponent<Text>().text = (flashcards[index + 1]).ToString();
        }
        else
        {
            //definition is showing currently; need to update text to 1 index position before
            flashcardText.GetComponent<Text>().text = (flashcards[index - 1]).ToString();
        }
    }
}
