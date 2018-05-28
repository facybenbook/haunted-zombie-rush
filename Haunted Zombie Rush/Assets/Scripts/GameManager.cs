using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	[SerializeField] private GameObject mainMenu;
	[SerializeField] public RawImage gameOverImage;

	private bool playerActive = false;
	private bool gameOver = false;
	private bool gameStarted = false;

	public bool PlayerActive {
		get { return playerActive; }
	}

	public bool GameOver {
		get { return gameOver; }
	}

	public bool GameStarted {
		get { return gameStarted; }
	}

	void Awake() {
		if (instance == null) {
			instance = this;
		} 
		else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

		Assert.IsNotNull (mainMenu);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerCollided() {
		gameOverImage.enabled = true;
		gameOver = true;
	}

	public void PlayerStartedGame() {
		playerActive = true;
	}

	public void EnterGame(){
		gameStarted = true;
		mainMenu.SetActive (false);
	}
}
