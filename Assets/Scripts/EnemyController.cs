using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;  // �ړ����x
    public GameObject bulletPrefab; // �e�ۂ̃v���n�u���擾
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

    private IEnumerator Fire()   // �e���˃R���[�`��
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Vector3 offset = new Vector3(-1f, 0f, 0f);  // �e�ۂ�G�̑O����1���j�b�g���炷
            Quaternion rotation = Quaternion.Euler(0f, 180f, 0f); //�e�ۂ̌����𔽓]
            Instantiate(bulletPrefab, transform.position + offset, rotation);
        }
    }

    // ��e����HP���Z����
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
