using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;

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
        float yDirection = Input.GetAxis("Mouse Y");

        this._PlayerDirection = new Vector2(0, yDirection).normalized;
    }

    // Fixed update is called once per physics frame
    void FixedUpdate()
    {
        this._RbPlayer.velocity = new Vector2(0, this._PlayerDirection.y * this.playerSpeed);
    }
}
