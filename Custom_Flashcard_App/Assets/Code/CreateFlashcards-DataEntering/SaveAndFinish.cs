//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveAndFinish : MonoBehaviour
{
    //initialize variables
    public Text termEntryField;
    public Text definitionEntryField;
    public SpriteRenderer missingTermOrDefinitionPrompt;

    //this function saves the entire set of flashcards just created by the user and loads the home page
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

            string[] flashcardsArray = new string[MainManager.Instance.flashcardSetBeingCreated.Count];
            MainManager.Instance.flashcardSetBeingCreated.CopyTo(flashcardsArray);
            MainManager.Instance.flashcardSetBeingCreated.Clear();

            MainManager.Instance.allFlashcardSets[MainManager.Instance.mostRecentNameAdded] = new ArrayList(flashcardsArray);

            SceneManager.LoadScene("HomePage");
        }
    }
}
