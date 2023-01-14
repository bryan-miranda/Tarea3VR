using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubes : MonoBehaviour
{
    public int stage;
    public Collider cubeCollider;
    public AudioSource portal;
    public AudioSource cubes;
    private Renderer _myRenderer;
    private float randomX;
    private float randomZ;

    // Start is called before the first frame update
    void Start()
    {
        _myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick()
    {
        if (stage == 1)
        {
            transform.position = new Vector3(-6.84f, 5.88f, 7.65f);
            cubeCollider.enabled = false;
            portal.Play();
            cubes.Play();
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            randomX = Random.Range(-5.53f, 7.1f);
            randomZ = Random.Range(-0.2f, 3.5f);
            transform.position = new Vector3(randomX, 0.2f, randomZ);
            transform.eulerAngles = new Vector3(-20, 0, 0);
            cubes.Play();
        }
    }
}
