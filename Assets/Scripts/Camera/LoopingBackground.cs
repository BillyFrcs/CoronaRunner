using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;

    public Renderer BackgroundRenderer;

    // Start is called before the first frame update
    void Start()
    {
        this.backgroundSpeed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.BackgroundRenderer.material.mainTextureOffset += new Vector2(this.backgroundSpeed * Time.deltaTime, 0f);
    }
}
