using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {

    public GameObject playership;
    public GameObject laserbolt;
    public GameObject enemyexploion;
    public GameObject playerexploion;
    public GUIText healthtext;
    public int health;

	// Use this for initialization
	void Start () {
        health = 10;
        Updatehealth();

    }
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 10.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;
        if (playership.transform.position.x > 10)
            if (x > 0)
                x = 0;
        if (playership.transform.position.x < -10)
            if (x < 0)
                x = 0;
        if (playership.transform.position.z > 15)
            if (z > 0)
                z = 0;
        if (playership.transform.position.z < -1)
            if (z < 0)
                z = 0;

        playership.transform.Translate(x, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(laserbolt, this.gameObject.transform.position, Quaternion.identity);

        //Debug.Log(x+""+z);
    }

    void OnTriggerEnter(Collider other)
    {

        Instantiate(enemyexploion, other.gameObject.transform.position, Quaternion.identity);
        Destroy(other.gameObject);
        health--;
        Updatehealth();
        if (health <= 0)
        {
            Instantiate(playerexploion, this.gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    void Updatehealth()
    {
        healthtext.text = "Health: " + health;
    }

}
