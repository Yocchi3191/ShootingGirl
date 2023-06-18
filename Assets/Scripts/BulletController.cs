using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);

        //‰æ–ÊŠO‚És‚­‚©Õ“Ë‚µ‚½‚çíœ
        if (transform.position.x < -20
            || 20 < transform.position.x)
        {
            Debug.Log("out of area");
            Destroy(this.gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit!");
        Destroy(gameObject);
        Destroy(collision.gameObject);

    }
}
