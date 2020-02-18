using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Assign : MonoBehaviour
{
    public Text glad1;
    public Text glad2;
    public Text next;
    public bool ready;
    public string type;
    public Move character;
    public InputField nameField;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GetComponent<Select>().selected)
            {
                if (nameField.text == "") nameField.text = Names.Return();
                character.GetComponent<Stats>().name = nameField.text;
                AgentInfo.agents.Add(character);
                if (AgentInfo.agents.Count == 1)
                {
                    glad1.text = $"{nameField.text} the {type}";
                    nameField.text = "";
                    GetComponent<Select>().selected = false;
                }
                else if (AgentInfo.agents.Count == 2)
                {
                    glad2.text = $"{nameField.text} the {type}";
                    next.text = "Press Spacebar to start the match";
                    ready = true;
                }
            }            
        }
        if (ready)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Arena");
            }
        }
    }
}
