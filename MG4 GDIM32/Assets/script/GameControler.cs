using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float _timer = 3.0f;
    private float _spawnTimer = 0.0f;
    [SerializeField] private AudioSource _damageAudio;
    [SerializeField] private AudioSource _pointAudio;
    [SerializeField] private AudioSource _jumpAudio;
    [SerializeField] private TMP_Text _pointText;
    private float _point;

    // Start is called before the first frame update
    void Start()
    {
        _spawnTimer = _timer;
        player play = Locator.Instance.playerss;
        play.onGameOver += GameOverHandle;
        play.Point += AddPoint;
        play.jumping += JumpHandle;

    }
    public void JumpHandle()
    {
        //Debug.Log("Jumped");
        _jumpAudio.Play();

    }
    public void GameOverHandle()
    { 
        _damageAudio.Play();
        Time.timeScale = 0;
        _point = 0.0f;
        _pointText.text = _point.ToString();
    }
    public void AddPoint()
    {
        _point += 1.0f;
        //Debug.Log("Point: " + _point);
        _pointAudio.Play();
        _pointText.text = _point.ToString();
        
    }
    // Update is called once per frame
    void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            int _randomposition = Random.Range(-1, 5);
            Instantiate(_pipe, new Vector3(0, _randomposition, 0), Quaternion.identity);
            _spawnTimer = _timer;
        }
    }
}
