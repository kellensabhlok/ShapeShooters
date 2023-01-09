using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{   
    public float MovingSpeed;
    Vector3 Direction = new Vector3(1f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xaxis = Input.GetAxis("Horizontal");
        // Debug.Log(xaxis);
        float yaxis = Input.GetAxis("Vertical");
        if(xaxis > 0.2) {
           Direction = new Vector3(1f, 0f, 0f)*MovingSpeed;
            // transform.position += move;   
            // LastDirection = 0;
        }
        else if(xaxis < -0.2){
             Direction = new Vector3(-1f, 0f, 0f)*MovingSpeed;
            // LastDirection = 2;
        } else if (yaxis > 0.2){
            Direction = new Vector3(0f, 1f, 0f)*MovingSpeed;
            // LastDirection = 1;
        } else if (yaxis <-0.2 ){
            Direction = new Vector3(0f, -1f, 0f)*MovingSpeed;
            // LastDirection = 3;
        }
        transform.position += Direction;

    }


    private void OnTriggerExit2D(Collider2D collider){
        if(collider.tag == "InnerCollider"){
            Direction = -Direction;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag == "Projectile"){
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
