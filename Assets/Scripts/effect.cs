using UnityEngine;
using UnityEngine.Audio;

public class effect : MonoBehaviour
{
    public AudioClip myAudioClip;
    public AudioSource AudioSource;

    public void PlaySound()
    {
        AudioSource.PlayOneShot(myAudioClip, 0.9f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
