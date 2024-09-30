//import libraries
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    //Variables that need to be stored in MainManager should be declared here
    public ArrayList flashcardSetNames = new ArrayList();   //contains the names of all the flashcard sets the user created
    public string selectedSet;   //contains the name of the set the user chose to practice
    public string mostRecentNameAdded;   //contains the name of the set that the user is in the process of creating
    public Dictionary<string, ArrayList> allFlashcardSets = new Dictionary<string, ArrayList>();   //contains all flashcards sets; key is the name of the set and value is the arraylist containing all the terms and definitions
    public ArrayList flashcardSetBeingCreated = new ArrayList();   //terms and definitions of the flashcard set being created are added to this arraylist

    //Used to create MainManager -- do NOT edit
    public static MainManager Instance; 

    //this function ensures data persistence between pages and sessions
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
