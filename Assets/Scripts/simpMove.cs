using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpMove : MonoBehaviour
{
    [SerializeField] float move;
    [SerializeField] float speed;
    [SerializeField] bool IsFacingRight;
    private Vector2 moveInput;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        moveInput.x = move;
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (rb.velocity.x != 0)
		{
        	CheckDirectionToFace(moveInput.x > 0);
        }

        
    }
    private void Turn()
	{
		//stores scale and flips the player along the x axis, 
		Vector3 scale = transform.localScale; 
		scale.x *= -1;
		transform.localScale = scale;

		IsFacingRight = !IsFacingRight;
	}
      public void CheckDirectionToFace(bool isMovingRight)
	{
		if (isMovingRight != IsFacingRight)
			Turn();
	}
}
