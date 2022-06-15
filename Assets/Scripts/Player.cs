using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour {
    private Boolean _isWin;
    public int score;
    public Rigidbody rd;
    public TextMeshProUGUI scoreText;
    public GameObject winText;

    void Start() {
        rd = GetComponent<Rigidbody>();
        Debug.Log(rd);
    }

    void Update() {
        if (_isWin) return;
        // Move
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rd.AddForce(new Vector3(h, 0, v));
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Food")) {
            score++;
            scoreText.text = $"Score: {score}";
            Destroy(other.gameObject);
            if (score >= 6) {
                winText.SetActive(true);
                _isWin = true;
            }
        }
    }
}