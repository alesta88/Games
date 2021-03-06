﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public PipeSystem pipeSystem;

	public float velocity;
	public float rotationVelocity;

	private Pipe currentPipe;

	private float distanceTraveled;
	private float deltaToRotation;
	private float systemRotation;
	private float worldRotation, avatarRotation;

	private Transform world, rotater;

    AudioSource m_MyAudioSource;




    public HUD hud;



    public void Die () {
        mainMenu.EndGame(distanceTraveled);
        gameObject.SetActive(false);
        Destroy(gameObject);
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(((int)(distanceTraveled * 10f)));

    }

    public MainMenu mainMenu;


    public void StartGame()
    {

        distanceTraveled = 0f;
        avatarRotation = 0f;
        systemRotation = 0f;
        worldRotation = 0f;
        currentPipe = pipeSystem.SetupFirstPipe();
        SetupCurrentPipe();
        gameObject.SetActive(true);
        hud.SetValues(distanceTraveled);
    }

    private void Awake()

    {
        distanceTraveled = 0f;
        avatarRotation = 0f;
        systemRotation = 0f;
        worldRotation = 0f;
        //Initiate the Slider value to half way
        // m_MySliderValue = 0.5f;
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        world = pipeSystem.transform.parent;
        rotater = transform.GetChild(0);
       // gameObject.SetActive(true);
        currentPipe = pipeSystem.SetupFirstPipe();
        SetupCurrentPipe();
        gameObject.SetActive(true);
      //  hud.SetValues(distanceTraveled);
    }


    private void Update () {
		float delta = velocity * Time.deltaTime;
		distanceTraveled += delta;
		systemRotation += delta * deltaToRotation;

		if (systemRotation >= currentPipe.CurveAngle) {
			delta = (systemRotation - currentPipe.CurveAngle) / deltaToRotation;
			currentPipe = pipeSystem.SetupNextPipe();
			SetupCurrentPipe();
			systemRotation = delta * deltaToRotation;
		}

		pipeSystem.transform.localRotation =
			Quaternion.Euler(0f, 0f, systemRotation);

		UpdateAvatarRotation();
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
   //         m_MyAudioSource.volume = 1.0f;
            SEManager.Instance.Play(SEManager.SE.LEFT);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow ))
        {
            SEManager.Instance.Play(SEManager.SE.RIGHT);
        }

        hud.SetValues(distanceTraveled);

    }

	private void UpdateAvatarRotation () {
		avatarRotation +=
			rotationVelocity * Time.deltaTime * Input.GetAxis("Horizontal");
		if (avatarRotation < 0f) {
			avatarRotation += 360f;
           
        }
		else if (avatarRotation >= 360f) {
			avatarRotation -= 360f;
            
        }
		rotater.localRotation = Quaternion.Euler(avatarRotation, 0f, 0f);
	}

	private void SetupCurrentPipe () {
		deltaToRotation = 360f / (2f * Mathf.PI * currentPipe.CurveRadius);
		worldRotation += currentPipe.RelativeRotation;
		if (worldRotation < 0f) {
			worldRotation += 360f;
            
        }
		else if (worldRotation >= 360f) {
			worldRotation -= 360f;
           
        }
		world.localRotation = Quaternion.Euler(worldRotation, 0f, 0f);
	}
}