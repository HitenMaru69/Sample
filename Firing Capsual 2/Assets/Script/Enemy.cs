using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health;
    public int Decressheath;
   
    Transform player;
    public float range = 10;
    public Transform enemy;
    float Distance;

    public Transform EnemyFirePos;
    public GameObject EnemyBullet;

    public float Starttime;
    public float Waittime;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        Starttime = Waittime;

    }

    // Update is called once per frame
    void Update()
    {
        

        Distance = Vector2.Distance(transform.position, player.position);
        if (Distance <= range)
        {
            Starttime -= Time.deltaTime;
            if (Starttime <= 0)
            {
                Instantiate(EnemyBullet, EnemyFirePos.position, Quaternion.identity);
                Starttime=Waittime;

            }
  
            
        }



        
        
        
    }

    public void Playerhealth()
    {
        Health -= Decressheath;

        if (Health == 0)
        {
            Destroy(this.gameObject);
        }


    }

   
}
