using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float ProjectileSpeed;
    public int Direction;
    // Start is called before the first frame update
    void Start()
    {
      if(transform.position[0] <40 ){
        Direction = 0;
      } 
      else if(transform.position[0] > 800){
        Direction = 2;
      }
      else if(transform.position[1] < 100){
        Direction = 1;
      } else{
        Direction = 3;
      }
    //   Debug.Log(Direction);
    }

    // Update is called once per frame
    void Update()
    {
         if(Direction == 0){
                transform.position += new Vector3(1f,0f,0f)*ProjectileSpeed;
         }
         else if(Direction == 1){
                transform.position += new Vector3(0f,1f,0f)*ProjectileSpeed;

         } else if(Direction == 2) {
                transform.position += new Vector3(-1f,0f,0f)*ProjectileSpeed;

         } else {
                transform.position += new Vector3(0f,-1f,0f)*ProjectileSpeed;

         }
        
        if(transform.position[0]>1000 || transform.position[0]<0|| transform.position[1]<0|| transform.position[1]>1000){
            Destroy(gameObject);
        }
       
    }
}
