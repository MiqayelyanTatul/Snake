using System;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    [SerializeField] private List<Transform> _tail;
    [SerializeField] private List<GameObject> _tailObject;
    [Range(0,3)]
    [SerializeField] private float _bonesDistance;
    [SerializeField] private GameObject _tailPrefab;
    [SerializeField] private Transform _mainCube;
    private Sprite _firstTail;

    private void Update()
    {
        MoveTails();
        if (Score.singletone.Count == 1)
        {
            _tailObject[0].gameObject.tag = "Untagged";
        }
    }

    private void MoveTails()
    {
        float sqrDistance = _bonesDistance * _bonesDistance;
        Vector3 previousPosition = transform.position;
        foreach (var bone in _tail)
        {
            if ((bone.position - previousPosition).sqrMagnitude > sqrDistance)
            {
                var temp = bone.position;
                bone.position = previousPosition;
                previousPosition = temp;
            }
            else
            {
                break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Circle"))
        {
            var bone = Instantiate(_tailPrefab);
            _tail.Add(bone.transform);
            _tailObject.Add(bone);
        }
    }
}
