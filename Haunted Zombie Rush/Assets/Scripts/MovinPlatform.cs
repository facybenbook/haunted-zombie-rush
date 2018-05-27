using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovinPlatform : MonoBehaviour {

	[SerializeField] float platformSpeed = 2;
	[SerializeField] float resetPosition = 10.09f;
	[SerializeField] float startPosition = -30.89f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	protected virtual void Update () {
		if (!GameManager.instance.GameOver) {
			transform.Translate(Vector3.right * (platformSpeed * Time.deltaTime));

			if (transform.localPosition.x >= resetPosition) {
				Vector3 newPos = new Vector3 (startPosition, transform.position.y, transform.position.z);
				transform.position = newPos;
			}
		}
	}
}
