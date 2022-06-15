using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitFood : MonoBehaviour {
    public GameObject foodPre;

    void Start() {
        for (int i = 0; i < 10; i++) {
            GameObject food = Instantiate<GameObject>(foodPre);
            food.transform.position += new Vector3(Random.Range(-14, 14), 0, Random.Range(-14, 14));
        }
    }

    // Update is called once per frame
    void Update() { }
}