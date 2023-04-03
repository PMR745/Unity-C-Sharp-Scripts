using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private GameObject player;
    Vector3 offset = new Vector3(0, 0, 2.0f);
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Instantiate(gameObject, new Vector3(0, 0, -5), gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Bullet");
            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        Vector3 bulletPos = player.transform.position + offset;
        Instantiate(gameObject, bulletPos, gameObject.transform.rotation);
    }
}
