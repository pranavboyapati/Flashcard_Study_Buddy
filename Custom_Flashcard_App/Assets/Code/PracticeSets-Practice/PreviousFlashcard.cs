//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviousFlashcard : MonoBehaviour
{
    //initialize variables
    public ArrayList flashcards;
    public Text flashcardText;

    //this function switches the flashcard to the previous one in the set, or the last if the button is pressed when on the first in the set
    public void Click()
    {
        flashcards = MainManager.Instance.allFlashcardSets[MainManager.Instance.selectedSet];
        string currentFlashcardText = flashcardText.GetComponent<Text>().text;
        int index = flashcards.IndexOf(currentFlashcardText);

        if (index % 2 == 0)
        {
            index -= 2;

            if (index < 0)
            {
                index = (flashcards.Count) - 2;
            }
        }
        else
        {
            index -= 3;

            if (index < 0)
            {
                index = (flashcards.Count) - 2;
            }
        }

        flashcardText.GetComponent<Text>().text = (flashcards[index]).ToString();
    }
}
