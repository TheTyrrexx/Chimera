using UnityEngine;
using System.Collections;

public class EnemyBulletCollision : MonoBehaviour
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
      for (int i = 0; i < c.contacts.Length; i++)
      {
        Debug.Log(c.contacts[i].collider.name);
        if(c.contacts[i].collider.name == "Leon")
        {
          c.gameObject.GetComponent<Health>().kill();
          GetComponent<BulletPhysics>().isAlive = false;
        }
      }
    }
  }
}
