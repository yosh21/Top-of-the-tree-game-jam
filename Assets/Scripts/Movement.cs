using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int player;
    float x = 0.0f;
    float y = 0.0f;
    [SerializeField] private Rigidbody2D rb;
    private bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 TankPosition = new Vector2(x, y);
        if ((player==1)&&(Input.GetKey(KeyCode.D)))
        {
            TankPosition = new Vector2(8, y) * Time.deltaTime;
        }
        if ((player==1)&&(Input.GetKey(KeyCode.A)))
        {
            TankPosition = new Vector2(-8,y) * Time.deltaTime;
        }
        if ((player == 2) && (Input.GetKey(KeyCode.RightArrow)))
        {
            TankPosition = new Vector2(8, y) * Time.deltaTime;
        }
        if ((player == 2) && (Input.GetKey(KeyCode.LeftArrow)))
        {
            TankPosition = new Vector2(-8,y) * Time.deltaTime;
        }
        if ((player == 1) && (Input.GetKey(KeyCode.W))&&(canJump==true))
        {
            rb.AddForce(transform.up * 300.0f);
        }
        if ((player == 2) && (Input.GetKey(KeyCode.UpArrow)) && (canJump == true))
        {
            Debug.Log("huh");
            rb.AddForce(transform.up * 300.0f);
        }
        transform.Translate(TankPosition);
    }
    void OnCollisionEnter2D()
    {

        canJump = true;
    }
    void OnCollisionExit2D()
    {
        canJump = false;
    }
}
