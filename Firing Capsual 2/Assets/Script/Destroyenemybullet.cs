using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyenemybullet : MonoBehaviour
{
    public GameObject Restartmenu;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet" )
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Restartmenu.SetActive(true);
        }
    }
}
