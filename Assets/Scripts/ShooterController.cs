using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShooterController : MonoBehaviour
{   
    public GameObject ProjectilePrefab;
    float ReloadTime = 3f;
    public GameObject[] Shooters; 
    int count;
    public Text text;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Score = 0;
        StartCoroutine(StartFiring());
    }

    // Update is called once per frame
    void Update()
    {
       
        // Shooter.shoot();
    }

    IEnumerator StartFiring(){
        while(true){
            yield return new WaitForSeconds(ReloadTime);
            Shoot();
            Score++;
            text.text = ""+Score; 
            if(count == 10){
                if(ReloadTime>0.5f){
                    ReloadTime -= 0.2f;
                    count= 0;
                }
            }
            else {
                count++;
            }
            
        }
    }
    void Shoot(){
        // Debug.Log("SHOOTING");
         int index = Random.Range(0,4);
        GameObject Shooter = Shooters[index];
        // Debug.Log(Shooter);
        // Debug.Log(Shooter.transform.position);
        // Debug.Log(Shooter.Direction);
        GameObject p = Instantiate(ProjectilePrefab) as GameObject;
        p.transform.position = Shooter.transform.position;
       
    }
}
