using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasercontrol : MonoBehaviour
{
    public GameObject enemyexploion;
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
        else
            Debug.Log("cannot find gamecontroller");

        this.gameObject.transform.Rotate(90, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0, Time.deltaTime * 15.0f, 0);
        if (this.gameObject.transform.position.z >= 20f)
            Destroy(this.gameObject);

    }

    void OnTriggerEnter(Collider other)
    {

        gameController.Addscore(100);

        Instantiate(enemyexploion, other.gameObject.transform.position, Quaternion.identity);
        other.gameObject.GetComponent<AudioSource>().Play();
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        
    }
}