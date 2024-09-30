//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextFlashcard : MonoBehaviour
{
    //initialize variables
    public ArrayList flashcards;
    public Text flashcardText;

    //this function loads the next flashcard in the set, or the first one if the button is pressed on the last one in the set
    public void Click()
    {
        flashcards = MainManager.Instance.allFlashcardSets[MainManager.Instance.selectedSet];
        string currentFlashcardText = flashcardText.GetComponent<Text>().text;
        int index = flashcards.IndexOf(currentFlashcardText);

        if (index % 2 == 0)
        {
            index += 2;

            if (index >= flashcards.Count)
            {
                index = 0;
            }
        }
        else
        {
            index += 1;

            if (index >= flashcards.Count)
            {
                index = 0;
            }
        }

        flashcardText.GetComponent<Text>().text = (flashcards[index]).ToString();
    }
}
