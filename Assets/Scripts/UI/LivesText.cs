using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivesText : MonoBehaviour 
{
    string staticText;
    Text livesText; 

	// Use this for initialization
	void Start () 
    {
        staticText = "Lives: ";
        livesText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        livesText.text = staticText + GameObject.Find("Leon").GetComponent<Health>().lives;
	}
}
