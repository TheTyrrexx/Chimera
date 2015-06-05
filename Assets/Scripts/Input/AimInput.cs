using UnityEngine;
using System.Collections;

public class AimInput : MonoBehaviour
{
	// Use this for initialization
	void Start ()
  {
	
	}
	
	// Update is called once per frame
	void Update ()
  {
    if(Input.GetMouseButton(0))
    {
      aim();
    }
	}

  void aim()
  {
    var parentTransform = gameObject.transform.parent.gameObject.GetComponent<Transform>();

    Vector3 mousePos = Input.mousePosition;
    mousePos = Camera.main.ScreenToWorldPoint(mousePos);
    Vector3 dir = mousePos - parentTransform.position;
    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    parentTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

//    if (timeLastBullet >= bulletDelay)
//    {
//      timeLastBullet = 0.0f;
//      shoot(transform, dir);
//    }
//    timeLastBullet += Time.deltaTime;

    //Need to do for all children
    //this.GetComponentInChildren<Shooting>().shoot(transform, dir);
    ShootingInput[] shootScripts;
    shootScripts = GetComponentsInChildren<ShootingInput>();
    foreach(ShootingInput s in shootScripts)
    {
      s.shoot(transform, dir);
    }

  }

//  void shoot(Transform origin, Vector3 dir)
//  {
//    if (timeLastBullet >= bulletDelay)
//    {
//      timeLastBullet = 0.0f;
//      Vector3 spot = new Vector3(origin.position.x + 1.0f, origin.position.y + 0.37f, 0.0f);
//      GameObject b = Instantiate(bullet, spot, Quaternion.identity) as GameObject;
//      b.GetComponent<BulletPhysics>().init(dir);
//    }
//    timeLastBullet += Time.deltaTime;
//  }
}
