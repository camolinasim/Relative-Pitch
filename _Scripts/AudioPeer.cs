using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class AudioPeer : MonoBehaviour {
    AudioSource _audioSource;
    public float[] _samples = new float[512];
    public int counter = 0;
    // Start is called before the first frame update
    void Start() {
        _audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource ();
        _audioSource.Play();
    }

    void GetSpectrumAudioSource(){
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }
}
