using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;  // ÚŽŹx
    public GameObject bulletPrefab; // eŰĚvnuđćž
    public int hp;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fire());
    }

    void Update()
    {
        if (hp < 0)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Fire()   // e­ËR[`
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Vector3 offset = new Vector3(-1f, 0f, 0f);  // eŰđGĚOűÉ1jbg¸çˇ
            Quaternion rotation = Quaternion.Euler(0f, 180f, 0f); //eŰĚüŤđ˝]
            Instantiate(bulletPrefab, transform.position + offset, rotation);
        }
    }

    // íeĚHP¸Z
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string getObjectTag = collision.gameObject.tag;
        if (getObjectTag == "Bullet")
        {
            Debug.Log("Hit!");
            hp--;
        }


    }
}
