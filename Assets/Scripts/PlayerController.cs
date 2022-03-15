using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool gameOver = false;

    private float horizontalInput;
    private float speed = 10.0f;

    private float horizontalBounds = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the player according to horizontal input
        if(gameOver == false)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }

        //Restrict player boundaries along the plane
        if(transform.position.x >= horizontalBounds)
        {
            transform.position = new Vector3(horizontalBounds, transform.position.y, transform.position.z);
        }
        if(transform.position.x <= -horizontalBounds)
        {
            transform.position = new Vector3(-horizontalBounds, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        gameOver = true;
        Debug.Log("Game Over!");
    }
}
