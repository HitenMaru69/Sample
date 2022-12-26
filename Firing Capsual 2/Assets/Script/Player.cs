using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpforce;
    public bool isgrounded = true;

    public Text Score;
    public GameObject Rstartmenu;
    public int Health;
    public int Descresshealth;

    float x;

    



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Score.text = ":"+Health.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");

        if (x > 0)
        {
            gameObject.transform.localScale = new Vector3(0.33489f, 0.277447f, 1);
        }

        if(x < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.33489f, 0.277447f, 1);
        }

    }

    private void FixedUpdate()
    {
  

        rb.velocity = new Vector2(x * speed, rb.velocity.y);
     
        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {

            rb.AddForce(Vector2.up * jumpforce,ForceMode2D.Impulse);

            isgrounded = false;

        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isgrounded = true;
        }
    }


    public void Playerdescresshealth()
    {
        Health -= Descresshealth;
        Score.text = ":"+ Health.ToString();

        if (Health <= 0)
        {
            Destroy(gameObject);
            Rstartmenu.SetActive(true);
        }
    }

}
