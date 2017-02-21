using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
        else
            Debug.Log("cannot find gamecontroller");
        this.gameObject.transform.Rotate(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {

        int score = gameController.Getscore();

        this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * (3f + Random.value*5f)*((score/1000+1)*1f));

        if (this.gameObject.transform.position.z <= -10f)
            Destroy(this.gameObject);

    }
}