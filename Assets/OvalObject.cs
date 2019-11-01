using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvalObject : MonoBehaviour
{
	public float speed = 10.0f;
	private Rigidbody2D rb;
	private Vector2 screenBounds;


	// Use this for initialization
	void Start()
	{
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0, -speed);
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y < -10 )
		{
		
			if (this.gameObject != null)
			{
				Destroy(this.gameObject);
			}
			
		}
	}
}
