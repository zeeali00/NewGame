using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BulletInstan : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletsprefabs;
    [SerializeField]
    private GameObject Enemyprefab;
    //public GameObject Player;
    GameObject Background;
    public float speed;

   // public Vector3 InstantiatePos = new Vector3(210, 110, 0);
    // Start is called before the first frame update
    void Start()
    {
        Background = GameObject.Find("Background");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartBullet();
            SpawnEnem();
        }
        playerMovement();

    }

    void playerMovement()
    {

        transform.Translate(new Vector3(Input.GetAxis("Horizontal") *speed , Input.GetAxis("Vertical") * speed)) ;


    }

    
    void SpawnEnem()
    {
        GameObject Enemy = Instantiate(Enemyprefab, this.transform.position, Quaternion.identity, Background.transform);
        StartCoroutine(MoveObject(Enemy, new Vector3(Enemy.transform.position.x,700, Enemy.transform.position.z)));

    }

    void StartBullet()
    {

        GameObject bullet = Instantiate(bulletprefabs, this.transform.position, Quaternion.identity, Background.transform);
        StartCoroutine(MoveObject(bullet,new Vector3(bullet.transform.position.x,900, bullet.transform.position.z)));

    }

    IEnumerator MoveObject(GameObject obj, Vector3 pos)
    {
        while (obj.transform.position != pos)
        {
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, pos, 1);
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(obj);
    }

   
}
