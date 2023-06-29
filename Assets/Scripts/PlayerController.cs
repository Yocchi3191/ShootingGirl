using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;  // プレイヤーの移動速度
    public GameObject bulletPrefab; // 弾丸のプレハブを取得
    public int hp;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 矢印キーで移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        // 弾丸の発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 offset = new Vector3(1f, 0f, 0f);  // 弾丸をプレイヤーの前方に1ユニットずらす
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
        }

        if (hp < 0)
        {
            Destroy(gameObject);
        }
    }

    // 被弾時のHP減算処理
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
