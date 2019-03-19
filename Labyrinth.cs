using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth : MonoBehaviour {
    public Transform Spawnpunkt, Spawnpunkt2, Spawnpunkt3, Spawnpunkt4, Spawnpunkt5;
    public GameObject stein;

    // Use this for initialization
    void OnTriggerEnter() {
        Instantiate(stein, Spawnpunkt.position, Spawnpunkt.rotation);
        Instantiate(stein, Spawnpunkt2.position, Spawnpunkt2.rotation);
        Instantiate(stein, Spawnpunkt3.position, Spawnpunkt3.rotation);
        Instantiate(stein, Spawnpunkt4.position, Spawnpunkt4.rotation);
        Instantiate(stein, Spawnpunkt5.position, Spawnpunkt5.rotation);
    }
}
