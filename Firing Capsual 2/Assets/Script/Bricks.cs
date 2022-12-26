using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    SpriteRenderer Bricksrender;
    BoxCollider2D Brickscollider;

    public bool isDestroy = false;
    // Start is called before the first frame update
    void Start()
    {
        Bricksrender = GetComponent<SpriteRenderer>();
        Brickscollider = GetComponent<BoxCollider2D>();


        Brickscollider.size = Bricksrender.size;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && isDestroy ==true)
        {
            Destroy(this.gameObject);

        }
        
    }


}
