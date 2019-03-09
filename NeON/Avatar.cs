using UnityEngine;
using UnityEngine.SceneManagement;

public class Avatar : MonoBehaviour {

	public ParticleSystem shape, trail, burst;
    public GameObject Ship;
 //   public MainMenu mainMenu;
    private Player player;

	public float deathCountdown = -1f;

    private void Start()
    {
        shape.enableEmission = false;
    }

    private void Awake () {
		player = transform.root.GetComponent<Player>();
	}

	private void OnTriggerEnter (Collider collider) {
        shape.enableEmission = true;
        Destroy(Ship);
        if (deathCountdown < 0f) {
			
			trail.enableEmission = false;
			//burst.Emit(burst.maxParticles);
            shape.Emit(shape.maxParticles);
            deathCountdown = shape.startLifetime;
         //   mainMenu.EndGame(distanceTraveled);
            SEManager.Instance.Play(SEManager.SE.BOOM);
          


        }
	}
	
	private void Update () {
		if (deathCountdown >= 0f) {
			deathCountdown -= Time.deltaTime;
			if (deathCountdown <= 0f) {
				deathCountdown = -1f;
			//	shape.enableEmission = true;
				trail.enableEmission = true;
                //  Destroy(Ship);
                player.Die();
               // SceneManager.LoadScene("Ranking", LoadSceneMode.Additive);
                SceneManager.LoadScene("NeonGameGameOver", LoadSceneMode.Additive);
                

            }
        }
	}
}