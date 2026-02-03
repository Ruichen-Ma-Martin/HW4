using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerrigidbody;
    //[SerializeField] private AudioSource _audioJump;

    //[SerializeField] public GameObject _pipUP;
    //[SerializeField] public GameObject _pipDOWN;
    //[SerializeField] public GameObject _pipPoint;
    [SerializeField] private float _jump = 5.0f;
    //private float _point;
    public delegate void Getpoint();
    public event Getpoint Point;

    public delegate void GameOver();
    public event GameOver onGameOver;

    public delegate void Jumps();
    public event Jumps jumping;

    // Start is called before the first frame update
    void Start()
    {
        //_point = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerrigidbody.velocity = new Vector2(_playerrigidbody.velocity.x, _jump);
            //_audioJump.Play();
            jumping?.Invoke();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("point"))
        {
            //_point = +1.0f;
            Point?.Invoke();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("pip"))
        {
            onGameOver?.Invoke();
            //Destroy(this.gameObject);
        }
    }




}
