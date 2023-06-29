using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;  // ˆÚ“®‘¬“x
    public GameObject bulletPrefab; // ’eŠÛ‚ÌƒvƒŒƒnƒu‚ðŽæ“¾
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

    private IEnumerator Fire()   // ’e”­ŽËƒRƒ‹[ƒ`ƒ“
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Vector3 offset = new Vector3(-1f, 0f, 0f);  // ’eŠÛ‚ð“G‚Ì‘O•û‚É1ƒ†ƒjƒbƒg‚¸‚ç‚·
            Quaternion rotation = Quaternion.Euler(0f, 180f, 0f); //’eŠÛ‚ÌŒü‚«‚ð”½“]
            Instantiate(bulletPrefab, transform.position + offset, rotation);
        }
    }

    // ”í’eŽž‚ÌHPŒ¸ŽZˆ—
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
