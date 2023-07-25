using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSphere : MonoBehaviour
{
    public int gridSize;
    public float radius = 1;

    private Mesh mesh;
    private Vector3[] vertices;
    private Vector3[] normals;
    private Color32[] cubeUV;

    private void Start()
    {
        Generate();
    }

    private void Generate()
    {
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "Product Sphere";
        CreateColliders();
        SetVertex(1,(int)transform.localScale.x,(int)transform.localScale.y,(int)transform.localScale.z);
        
    }

    private void CreateColliders()
    {
        gameObject.AddComponent<SphereCollider>();
    }

    private void SetVertex(int i, int x, int y, int z)  
    {
        Vector3 v = new Vector3(x, y, z) * 2f/gridSize- Vector3.one;
        normals[i] = v.normalized;
        vertices[i] = normals[i] * radius;
        cubeUV[i] = new Color32((byte)x, (byte)y, (byte)z, 0);
    }
}
