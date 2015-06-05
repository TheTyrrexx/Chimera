using UnityEngine;
using System.Collections;

public class PlayerBulletCollision : MonoBehaviour
{
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnCollisionEnter2D(Collision2D c)
  {
    var layerName = LayerMask.LayerToName(c.gameObject.layer);

    if(layerName == "Enemy")
    {
      c.gameObject.GetComponent<Health>().kill();
      GetComponent<BulletPhysics>().isAlive = false;
    }
  }
}
