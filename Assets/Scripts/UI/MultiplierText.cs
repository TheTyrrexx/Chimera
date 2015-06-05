using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiplierText : MonoBehaviour 
{
    string staticText;
    Text multiText;

    // Use this for initialization
    void Start()
    {
        staticText = "Multiplier: ";
        multiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        multiText.text = staticText + GameObject.Find("Leon").GetComponent<Scoring>().getMulti();
    }
}
