using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;

    private Vector2 _Movement;

    private Rigidbody2D _RbPlayer;
    private Vector2 _PlayerDirection;

    // Start is called before the first frame update
    void Start()
    {
        this._RbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.PlayerMovement();
    }

    // Move using keyboard
    private void PlayerMovement()
    {
        // Movement with mouse y
        float yDirection = Input.GetAxis("Mouse Y");

        this._PlayerDirection = new Vector2(0f, yDirection * playerSpeed * Time.deltaTime).normalized;
        
        // Movement with vertical
        this._Movement = new Vector2(0f, Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
        
        transform.Translate(this._Movement);
    }

    // Fixed update is called once per physics frame
    void FixedUpdate()
    {
        this._RbPlayer.velocity = new Vector2(0, this._PlayerDirection.y * this.playerSpeed);
    }
}
