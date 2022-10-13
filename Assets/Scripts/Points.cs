using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Points : MonoBehaviour
{
   [SerializeField] private GameObject[] _points;
   [SerializeField] private GameObject _circle;
   private int _random;
   public static Points singletone { get; private set; }

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

   private void Start()
   {
      RandomPoints();
   }

   public void RandomPoints()
   {
      _random = Random.Range(0, 99);
      Instantiate(_circle, _points[_random].transform.position,transform.rotation);
   }
}
