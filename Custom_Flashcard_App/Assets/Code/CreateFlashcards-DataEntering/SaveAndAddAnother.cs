//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveAndAddAnother : MonoBehaviour
{
    //initialize variables
    public Text termEntryField;
    public Text definitionEntryField;
    public SpriteRenderer missingTermOrDefinitionPrompt;

    //this function saves the current flashcard just created and allows the user to create another
    public async void Click()
    {
        string term = termEntryField.text;
        string definition = definitionEntryField.text;

        if (term.Equals("") || definition.Equals(""))
        {
            missingTermOrDefinitionPrompt.enabled = true;
            await Task.Delay(1000);
            missingTermOrDefinitionPrompt.enabled = false;
        }
        else
        {
            MainManager.Instance.flashcardSetBeingCreated.Add(term);
            MainManager.Instance.flashcardSetBeingCreated.Add(definition);
            SceneManager.LoadScene("CreateFlashcards-DataEntering");
        }
    }
}
