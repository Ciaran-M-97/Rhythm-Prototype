using UnityEngine;

public class NoteScroller : MonoBehaviour
{
    public float noteSpeed;
    public bool hasStarted;
    public AudioSource audioSource;

    void Start() {
        noteSpeed = noteSpeed / 60f; 
    }

    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
                audioSource.Play();
            }
        }
        else
        {
            transform.position -= new Vector3(0f, noteSpeed * Time.deltaTime, 0f);
        }
    }
}
