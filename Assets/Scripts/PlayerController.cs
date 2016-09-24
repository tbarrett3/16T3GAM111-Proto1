using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb;


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

        // Apple the rotation
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
