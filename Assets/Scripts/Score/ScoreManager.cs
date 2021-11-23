using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;

    private float _scoreGame;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            this._scoreGame += 1 * Time.deltaTime;

            this.ScoreText.text = ((int)this._scoreGame).ToString();
        }
    }
}
