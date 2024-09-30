//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialConditionsDataEnteringPage : MonoBehaviour
{
    //initialize variables
    public SpriteRenderer enterTermFirstPrompt;
    public SpriteRenderer missingTermDefinitionPrompt;
    public SpriteRenderer autofillFailed;

    //this function is called once when the page first loads and performs initial operations to ensure the page loaded properly
    public void Start()
    {
        enterTermFirstPrompt.enabled = false;
        missingTermDefinitionPrompt.enabled = false;
        autofillFailed.enabled = false;
    }
}
