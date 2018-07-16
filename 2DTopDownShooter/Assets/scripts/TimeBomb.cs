using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBomb : MonoBehaviour {


    public float TimeToDetonate;
    public GameObject explotion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(BombActivated());
    }

    IEnumerator BombActivated()
    {
        yield return new WaitForSeconds(TimeToDetonate);
        Instantiate(explotion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
