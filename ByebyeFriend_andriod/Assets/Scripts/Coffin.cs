using UnityEngine;
using System.Collections;

public class Coffin : MonoBehaviour {

    public GameObject Image;
    public AudioClip schreuw;
    public AudioSource audio;
    public AudioSource audio2;

    private IEnumerator coroutine;

    public float timer;
    public float resetTimer;

    private bool timerReset = false;
	// Use this for initialization
	void Start () {
        //audio = GetComponent<AudioSource>();
        timer = 1.5f;
        resetTimer = 3;
    }
	
	// Update is called once per frame
	void Update () {
        if (timerReset == true)
        {
            resetTimer -= Time.deltaTime;
            if (resetTimer <= 0)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        Debug.Log(transform.eulerAngles.x);
        if (RayCheck.startEvent == true)
        {
            if (transform.eulerAngles.x <= 359)
            {
                timer -= Time.deltaTime;
                transform.Rotate(-Vector3.right * Time.deltaTime * 100);
                
                
            }
            if (timer <= 0)
            {
                RayCheck.startEvent = false;
                StartCoroutine(PlayAudio());
                Image.active = true;
                audio2.Stop();
                timerReset = true;
                


            }
        }
	
	}

    private IEnumerator PlayAudio()
    {
        audio.PlayOneShot(schreuw);
        yield return new WaitForSeconds(0);
    }
}
