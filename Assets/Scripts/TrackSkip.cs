using UnityEngine;

public class TrackSkip : MonoBehaviour
{
    public float bpm;
    
    //units per second
    float ups;

    //in seconds
    public float startTime;

    public GameObject notes;

    public AudioSource audioSource;

    float noteStartingPos;

    private void Start()
    {
        audioSource.time = startTime;
        ups = bpm / 60f;
        noteStartingPos = ups * startTime;
        notes.transform.position = new Vector3(0f, -noteStartingPos, 0f);
    }
}
