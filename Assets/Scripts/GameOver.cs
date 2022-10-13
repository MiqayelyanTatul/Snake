using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private const string _wal = "Wal";
    private const string _tail = "Tail";
    private bool _paused;

    private void Awake()
    {
        _paused = true;
    }

    private void Update()
    {
        if (_paused == false)
        {
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag(_wal) || col.gameObject.CompareTag(_tail))
        {
            GamePause();
        }
    }

    private void GamePause()
    {
        _paused = false;
    }
}
