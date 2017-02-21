using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject myEnemy;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnEnemy(1f));
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);
    }

    IEnumerator SpawnEnemy(float waitTime)
    {

        this.transform.position = new Vector3(Random.value*20-10, 0, 20);

        Instantiate(myEnemy, this.gameObject.transform.position, Quaternion.identity);

        yield return new WaitForSeconds(waitTime);
        StartCoroutine(SpawnEnemy(1f));
    }
}
