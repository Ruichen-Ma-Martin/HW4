using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float jumpForce =5.0f;
    [SerializeField] private Rigidbody2D _playerrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerrigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
