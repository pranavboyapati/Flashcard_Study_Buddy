//import libraries
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

public class AutofillDefinition : MonoBehaviour
{
    //initialize variables
    public Text nameEntryField;
    public InputField definitionEntryField;
    public SpriteRenderer autofillFailed;

    //this function attempts to autofill the definition for the user-entered term and tells the user if the operation failed
    public async void Definition()
    {
        //get term that was entered
        string term = nameEntryField.text.ToString();

        //api call for definition   
        string url = "https://api.dictionaryapi.dev/api/v2/entries/en/" + term;
        HttpClient client = new HttpClient();
        
        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            responseBody = responseBody.ToString();
            responseBody = responseBody.Substring(responseBody.IndexOf("definition") + 29, responseBody.IndexOf("synonym") - responseBody.IndexOf("definition") - 32);
            responseBody = System.Text.RegularExpressions.Regex.Replace(responseBody, "[^a-z A-Z 0-9 . , ! & - _ : ; ' / ? \"]", "");

            //show definition in definition box
            definitionEntryField.GetComponent<UnityEngine.UI.InputField>().text = responseBody;
        }
        catch
        {
            if (autofillFailed != null)
            {
                autofillFailed.enabled = true;
            }
            await Task.Delay(1000);
            if (autofillFailed != null)
            {
                autofillFailed.enabled = false;
            }
        }
    }
}