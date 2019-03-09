using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{

    public static SEManager Instance;
    private float vol = 3.0f;
    public enum SE
    {
        HACHIMITSU,
        STAND,
        CHOOSE,
        DAMAGE,
        DESTROY,
        TDAMAGE,
        TDESTROY,
        GAMEOVER,
        WIN,

    }

    [SerializeField]
    private AudioClip[] seList;

    private AudioSource audioSource;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;


            Instance = this;
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void Play(SE se)
    {
        audioSource.PlayOneShot(seList[(int)se], vol);
    }






    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
