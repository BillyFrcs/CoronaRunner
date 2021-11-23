using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic _BackgroundMusic;

    private void Awake()
    {
        if (_BackgroundMusic == null)
        {
            _BackgroundMusic = this;

            DontDestroyOnLoad(_BackgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
