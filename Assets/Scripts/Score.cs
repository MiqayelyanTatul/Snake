using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    public int Count;
    private const string Circle = "Circle";
    public static Score singletone { get; private set; }

    private void Awake()
    {
        if (!singletone)
        {
            singletone = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        _scoreText.text = Count.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag(Circle) )
        {
            Count++;
            Points.singletone.RandomPoints();
            Destroy(col.gameObject);
        }
    }
}
