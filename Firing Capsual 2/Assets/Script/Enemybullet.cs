using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        ;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player ph = GameObject.FindObjectOfType<Player>();

            ph.Playerdescresshealth();
            Destroy(this.gameObject);
            
        }
        

        

    }
    




}
