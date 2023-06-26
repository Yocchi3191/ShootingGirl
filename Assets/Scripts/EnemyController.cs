using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;  // 移動速度
    public GameObject bulletPrefab; // 弾丸のプレハブを取得

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fire());
    }

    private IEnumerator Fire()   // 弾発射コルーチン
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Vector3 offset = new Vector3(-1f, 0f, 0f);  // 弾丸を敵の前方に1ユニットずらす
            Quaternion rotation = Quaternion.Euler(0f, 180f, 0f); //弾丸の向きを反転
            Instantiate(bulletPrefab, transform.position + offset, rotation);
        }
    }
}
