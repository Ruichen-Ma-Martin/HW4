using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pip : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private Transform _pipTransform;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _pipTransform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
}
}
