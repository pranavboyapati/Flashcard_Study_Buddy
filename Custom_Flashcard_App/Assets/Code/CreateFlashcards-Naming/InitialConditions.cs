//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialConditions : MonoBehaviour
{
    //initialize variables
    public SpriteRenderer enterNewTextPrompt;

    //this function is called once when the page is first loaded and ensures the page loaded properly
    public void Start()
    {
        enterNewTextPrompt.enabled = false;
    }
}
