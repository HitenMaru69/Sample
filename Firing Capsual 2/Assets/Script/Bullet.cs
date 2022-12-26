using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float Firespeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.right * Firespeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroybullet();
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {

           
            Enemy en = GameObject.FindObjectOfType<Enemy>();
            en.Playerhealth();
            Destroy(gameObject);
           
        }
        
    }

    void Destroybullet()
    {
        GameObject.FindGameObjectsWithTag("Bullet");
        Destroy(gameObject,5f);
    }



}
