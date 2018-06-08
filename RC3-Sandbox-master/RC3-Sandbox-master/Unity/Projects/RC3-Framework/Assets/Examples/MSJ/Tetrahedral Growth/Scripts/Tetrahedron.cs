using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetrahedron : MonoBehaviour {
    
   
    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = mf.mesh;
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(0,0,0),
            new Vector3(1,0,0),
            new Vector3(1,0,1),

            new Vector3(1,1,1),
            new Vector3(1,0,0),
            new Vector3(0,0,0),

            new Vector3(1,1,1),
            new Vector3(1,0,1),
            new Vector3(0,0,0),

            new Vector3(1,1,1),
            new Vector3(1,0,0),
            new Vector3(1,0,1),
        };
        int[] triangle = new int[]
        {
            0,1,2,
            

            3,1,0,
            

            0,2,3,

            2,1,3,
            //1,2,3,
            //3,2,0,
            //0,1,3

        };
        Color[] color = new Color[triangle.Length];
        for (int i = 0; i < triangle.Length; i++)
        {
            color[triangle[i]] = Color.green;
        }
        Vector2[] uvs = new Vector2[]
        {
            new Vector2 (0,0),
            new Vector2 (0,1),
            new Vector2 (1,0),


            new Vector2 (1,1),
            new Vector2 (0,1),
            new Vector2 (0,0),


            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),

            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1),



        };
        
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangle;
        mesh.uv = uvs;
        mesh.colors = color;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
    }

	
	// Update is called once per frame
	void Update () 
    {
        
        
	}
}

