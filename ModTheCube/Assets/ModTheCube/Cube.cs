using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float rotateTo;

    void Start()
    {
        InvokeRepeating("UpdateCubeState", 0, 1);
    }

    void Update()
    {
        transform.Rotate(rotateTo * Time.deltaTime, 0.0f, 0.0f);
    }

    private void UpdateCubeState() {
        transform.position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        transform.localScale = Vector3.one * Random.Range(1f, 3f);

        Material material = Renderer.material;

        material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        rotateTo = Random.Range(-30f, 30f);
    }
}
