//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class EnterDefinitionTimingControl : MonoBehaviour
{
    //initialize variables
    public InputField definitionInputField;    
    public Text nameEntryField;
    public SpriteRenderer EnterTermFirstPrompt;

    //This function ensures that the definition can only be entered after the term in entered
    public async void TextTyped()
    {
        string userEnteredText = nameEntryField.text.ToString();

        if (userEnteredText.Equals(""))
        {
            definitionInputField.GetComponent<InputField>().text = "";
            
            if (EnterTermFirstPrompt != null)
            {
                EnterTermFirstPrompt.enabled = true;
            }
            await Task.Delay(1000);
            if (EnterTermFirstPrompt != null)
            {
                EnterTermFirstPrompt.enabled = false;
            }
        }
    }
}
