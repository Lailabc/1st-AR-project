using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Material selectedMaterial;
    private Material originalMaterial;
    //audio
    public AudioClip audioClip;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material;
        audioSource = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
        audioSource.clip = audioClip;
    }
    //when void is used as a function return type, it indicates that the function does not return a value

    public void PlayAudio()
    {
        audioSource.Play();
    }
    public void SetSelectedMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
    }
    public void SetOriginalMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
