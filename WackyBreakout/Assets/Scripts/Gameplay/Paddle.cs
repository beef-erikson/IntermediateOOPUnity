using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles Paddle behavior
/// </summary>
public class Paddle : MonoBehaviour
{
    #region Fields

    new Rigidbody2D rigidbody2D;

    #endregion
    
    #region Methods
    
    /// <summary>
    /// Initializations
    /// </summary>
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Handles Paddle movement
    /// </summary>
    private void FixedUpdate()
    {
        // Horizontal movement based on configuration utils setting
        float moveHorizontal = Input.GetAxis("Horizontal");
        if (moveHorizontal != 0)
        {
            Vector2 velocity = new Vector2(moveHorizontal * ConfigurationUtils.PaddleMoveUnitsPerSecond, 0);
            rigidbody2D.MovePosition(rigidbody2D.position + velocity * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    
    {
        
    }
    
    #endregion
}
