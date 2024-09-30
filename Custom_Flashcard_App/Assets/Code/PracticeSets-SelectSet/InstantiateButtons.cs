//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateButtons : MonoBehaviour
{
    //initialize variables
    public GameObject buttonPrefab;
    public RectTransform ParentPanel;
    public GameObject createSetsPrompt;

    //this function is called once when the page first loads
    //this function creates the buttons for selecting a specific flashcard set
    public void Start()
    {
        if (MainManager.Instance.flashcardSetNames.Count != 0)
        {
            Destroy(createSetsPrompt);
        }
        for (int i = 0; i < MainManager.Instance.flashcardSetNames.Count; i++)
        {
            GameObject button = Instantiate(buttonPrefab);
            button.transform.SetParent(ParentPanel, false);
            button.transform.localScale = new Vector3(1, 1, 1);
            button.GetComponentInChildren<Text>().text = MainManager.Instance.flashcardSetNames[i].ToString();
        }
    }
}
