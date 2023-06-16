using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;  // プレイヤーの移動速度
    public GameObject bulletPrefab; // 弾丸のプレハブを取得


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
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 offset = new(1f, 0f, 0f);  // プレイヤーの前方に1ユニットずらす
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
