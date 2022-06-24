using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderScript : MonoBehaviour
{
    public GameObject thunderSource;
    public float minT,maxT,thunderTime = 0.1f;
    public AudioClip[] sounds;
    void Start()
    {
        thunderSource.SetActive(false);
        StartCoroutine("Thunder");
    }

    // Update is called once per frame
    IEnumerator Thunder()
    {
        yield return new WaitForSeconds(Random.Range(minT,maxT));

        GetComponent<AudioSource>().clip = sounds[Random.Range(0, sounds.Length)];
        GetComponent<AudioSource>().Play();
        for (int i = 0;i<= Random.Range(0,4); i++){
            yield return new WaitForSeconds(thunderTime);
            thunderSource.SetActive(true);
            yield return new WaitForSeconds(thunderTime);
            thunderSource.SetActive(false);
        }




        StartCoroutine("Thunder");
    }
}
