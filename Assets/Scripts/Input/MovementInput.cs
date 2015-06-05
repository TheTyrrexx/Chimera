using System.Collections;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
  public float movementVelocity = 25.0f;

	// Use this for initialization
	void Start ()
  {
	
	}
	
	// Update is called once per frame
	void Update ()
  {
    movePlayer();
	}

  public void movePlayer()
  {
    var playerBody = GetComponent<Rigidbody2D>();
    var playerTransform = GetComponent<Transform>();

    Vector2 move = new Vector2(Input.GetAxis("Horizontal") * movementVelocity, Input.GetAxis("Vertical") * movementVelocity);

    playerBody.velocity = move;
//    this.transform.GetComponentInParent<Rigidbody2D>().velocity = move;
//    //this.transform.FindChild("Goat").GetComponent<Rigidbody2D>().velocity = move;
//    //this.transform.FindChild("Snake").GetComponent<Rigidbody2D>().velocity = move;

//    Vector2 moveDirection = playerBody.velocity;
//    if (moveDirection != Vector2.zero) {
//      float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
//      playerTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
//    }
    //playerTransform.LookAt((Vector2)playerTransform.position + move.normalized, Vector3.up);


    //Clamping code so player cannot move offscreen
    if(Camera.main.WorldToViewportPoint(transform.position).x < 0.0f)
    {
      var view = Camera.main.ViewportToWorldPoint(new Vector2(0.0f, 0.0f));
      transform.position = new Vector2(view.x, transform.position.y);
    }
    else if(Camera.main.WorldToViewportPoint(transform.position).x > 1.0f)
    {
      var view = Camera.main.ViewportToWorldPoint(new Vector2(1.0f, 1.0f));
      transform.position = new Vector2(view.x, transform.position.y);
    }
  }
}
