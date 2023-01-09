using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;
public class ShooterScript : MonoBehaviour
{
    public float MovementFactor;
    public int Direction;
    bool MovingPositive;
    int count;
    // Random Rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        float initial = Random.Range(0,2);
        if(initial == 0){
            MovingPositive= false;
            
        } else {
            MovingPositive = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Random.Range(-1,500);
        // Debug.Log(movement);
        if(movement < 0){
             MovingPositive = !MovingPositive;
        } 
        if(Direction == 0 || Direction == 2){
           
            if(MovingPositive){
                 transform.position += new Vector3(0f,1f, 0f)*MovementFactor;
            } else {
                 transform.position += new Vector3(0f,-1f, 0f)*MovementFactor;
            }
        } else {
        
            if(MovingPositive){
                 transform.position += new Vector3(1f, 0f, 0f)*MovementFactor;
            } else {
                 transform.position += new Vector3(-1f, 0f, 0f)*MovementFactor;
            }
        }
        if(count > 5000){
            MovementFactor+=0.1f;
            count = 0;
        } else {
            count++;
        }
    }
    private void OnTriggerExit2D(Collider2D collider){
        MovingPositive = !MovingPositive;
    }

    // void shoot(){
    //     Debug.Log("SHOOTING");
    // }
}
