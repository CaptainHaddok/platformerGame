using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerControler : MonoBehaviour {
    //movement
    public int speed = 10;
    
    //jumps
    public int maxjumps = 1;
    public int currentJumps = 1;
    public int jumpHeight = 10  ;

    public Rigidbody rb;
    public Transform tf;
    private Vector3 position;

    void Start ()
    {
        rb.GetComponent<Rigidbody>();
        tf.GetComponent<Transform>();
	}

    void Update()
    {
        if (tf.position.y< -5)
        {
            die();
        }
        movement();
        jump();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (maxjumps != currentJumps)
        {
            currentJumps = maxjumps;
        }
        if (col.gameObject.tag == "Finish")
        {
            Debug.Log("Need to make the finnish");
        }
    }

    private void jump()
    {
        float Jump = Input.GetAxisRaw("Jump");
        Vector3 JumpVec = new Vector3(0.0f, Jump, 0.0f);
        if (currentJumps > 0 && Jump != 0)
        {
            rb.AddForce(JumpVec * jumpHeight);
            currentJumps--;
        }
    }

    private void movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }

    private void die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
