using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
	// Use this for initialization
	void Start ()
  {
	
	}
	
	// Update is called once per frame
	void Update ()
  {
	
	}

  void OnCollisionEnter2D(Collision2D c)
  {
    var layerName = LayerMask.LayerToName(c.gameObject.layer);

    if(layerName == "Player")
    {
        c.gameObject.GetComponent<Health>().kill();
        GetComponent<Health>().kill();
    }
  }
}
