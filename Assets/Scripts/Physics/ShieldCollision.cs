using UnityEngine;
using System.Collections;

public class ShieldCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnCollisionEnter2D(Collision2D c)
  {
    var layerName = LayerMask.LayerToName(c.gameObject.layer);
    var objBody = c.gameObject.GetComponent<Rigidbody2D>();

    if(layerName == "EnemyBullet")
    {
      Debug.Log("Hit E. Bullet");
      c.gameObject.GetComponent<BulletPhysics>().isAlive = false;
    }
  }
}
