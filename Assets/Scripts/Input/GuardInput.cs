using UnityEngine;
using System.Collections;

public class GuardInput : MonoBehaviour
{
	// Use this for initialization
	void Start ()
  {

	}
	
	// Update is called once per frame
	void Update ()
  {
    if(Input.GetMouseButton(1))
    {
      moveGuard();
    }
	}

  void moveGuard()
  {
    var gTransform = gameObject.transform;

    Vector3 mousePos = Input.mousePosition;
    mousePos = Camera.main.ScreenToWorldPoint(mousePos);
    Vector3 dir = mousePos - gTransform.position;
    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    gTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
  }
}
