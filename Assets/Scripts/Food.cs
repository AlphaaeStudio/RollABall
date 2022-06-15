using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Food : MonoBehaviour {
    private Vector3 _startPos;

    private float _radian;

    // 摆动速率
    private float _perRadian = 0.02f;

    // 摆动半径
    private float _radius = 0.16f;

    void Start() {
        _startPos = transform.position;
        // 随机初始弧度
        _radian = Random.value * 100;
    }

    void Update() {
        _radian += _perRadian;
        float dy = Mathf.Cos(_radian) * _radius;
        transform.position = _startPos + new Vector3(0, dy, 0);
        transform.Rotate(new Vector3(1, 1, 1), 1);
    }
}