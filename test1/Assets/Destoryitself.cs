using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoryitself : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Destroyself(1f));
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);
    }

    IEnumerator Destroyself(float waitTime)
    {

        

        yield return new WaitForSeconds(waitTime);

        Destroy(this.gameObject);

        StartCoroutine(Destroyself(1f));
    }
}
