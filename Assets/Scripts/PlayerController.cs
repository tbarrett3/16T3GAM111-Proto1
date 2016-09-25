using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin = -29, xMax = 29;
    public float yMin = -14, yMax = 14;
}

public class PlayerController : MonoBehaviour {

    public Boundary boundary;

    public Rigidbody2D rb;

    public float speed = 30f;

	// Use this for initialization
	void Start () {
        //Assign the rigidbody
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        // get the mouse position
        Vector2 mouse = Input.mousePosition;

        // Get the position of the mouse relative to the game world
        Vector2 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        // Get the delta between both positions
        Vector2 positionDelta = new Vector3(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        // Calculate the angular delta
        float angle = Mathf.Atan2(positionDelta.y, positionDelta.x) * Mathf.Rad2Deg - 90f;

        // Apply the rotation
        transform.eulerAngles = new Vector3(0, 0, angle);


    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Move the player
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;

        //Constrain the player (boudary)
        rb.position = new Vector2
            (
            Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp (rb.position.y, boundary.yMin, boundary.yMax)
            );

    }

}
