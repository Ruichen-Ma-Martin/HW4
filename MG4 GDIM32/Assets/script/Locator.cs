using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public player playerss { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

        GameObject playerOBject = GameObject.FindWithTag("BirdPlayer");
        if (playerOBject == null)
        {
                    Debug.LogError("Player object with tag 'BirdPlayer' not found!");
            return;
        }
        playerss = playerOBject.GetComponent<player>();
        if (playerss == null)
        {
            Debug.LogError("player component not found on the player object!");
        }
    }
}
