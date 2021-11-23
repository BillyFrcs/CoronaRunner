using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObstacle : MonoBehaviour
{
    private GameObject _Player;

    // Start is called before the first frame update
    void Start()
    {
        this._Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this._Player.gameObject);
        }
    }
}
