using UnityEngine;
using System.Collections;

public class HoleCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnTriggerEnter2D(Collider2D c)
  {
    var layerName = LayerMask.LayerToName(c.gameObject.layer);
    var playerBody = c.gameObject.GetComponent<Rigidbody2D>();

    if(layerName == "Player" && c.gameObject.tag == "Leon")
    {
      Debug.Log("Hit Hole");
      c.gameObject.GetComponent<Health>().kill();
    }
  }
}
