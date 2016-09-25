using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {

    public Rigidbody2D rb;

    public GameObject player;

    public Boundary boundary;

    public float health;
    public float atkSpeed; //damage dealt on touch
    public float speed;

	// Use this for initialization
	void Start () {
        //Assign the rigidbody
        rb = GetComponent<Rigidbody2D>();

        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate()
    {
        //Constrain to the boudary)
        rb.position = new Vector2
            (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax)
            );
    }
}
