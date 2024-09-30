//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

public class NextButton : MonoBehaviour
{
    //initialize variables
    public Text nameEntryField;
    public SpriteRenderer EnterDiffNamePrompt;
    public bool valid = true;

    //this function checks if the name of the flashcard set will be unique and loads the page for creating flashcards if that is the case
    public async void Click()
    {
        string userEnteredText = nameEntryField.text.ToString();
        userEnteredText = userEnteredText.ToUpper();

        if(MainManager.Instance.flashcardSetNames.Count == 0)
        {
            if (userEnteredText.Equals(""))
            {
                if (EnterDiffNamePrompt != null)
                {
                    EnterDiffNamePrompt.enabled = true;
                }
                await Task.Delay(1000);
                if (EnterDiffNamePrompt != null)
                {
                    EnterDiffNamePrompt.enabled = false;
                }
            }
            else
            {
                MainManager.Instance.flashcardSetNames.Add(userEnteredText);
                MainManager.Instance.mostRecentNameAdded = userEnteredText;
                SceneManager.LoadScene("CreateFlashcards-DataEntering");
            }
        }
        else
        {
            for (int i = 0; i < MainManager.Instance.flashcardSetNames.Count; i++)
            {
                string name = (MainManager.Instance.flashcardSetNames[i]).ToString();

                if (userEnteredText.Equals(""))
                {
                    valid = false;
                    if (EnterDiffNamePrompt != null)
                    {
                        EnterDiffNamePrompt.enabled = true;
                    }
                    await Task.Delay(1000);
                    if (EnterDiffNamePrompt != null)
                    {
                        EnterDiffNamePrompt.enabled = false;
                    }
                    break;
                }
                else
                {
                    if (userEnteredText.Equals(name))
                    {
                        valid = false;
                        if (EnterDiffNamePrompt != null)
                        {
                            EnterDiffNamePrompt.enabled = true;
                        }
                        await Task.Delay(1000);
                        if (EnterDiffNamePrompt != null)
                        {
                            EnterDiffNamePrompt.enabled = false;
                        }
                        break;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }

            if (valid == true)
            {
                MainManager.Instance.flashcardSetNames.Add(userEnteredText);
                MainManager.Instance.mostRecentNameAdded = userEnteredText;
                SceneManager.LoadScene("CreateFlashcards-DataEntering");
            }
        }
    }
}
