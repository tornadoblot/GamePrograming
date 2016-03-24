using UnityEngine;
using System.Collections;

public class BG : MonoBehaviour {

    public float ScrollSp = 1.5f;
    Material asdf;

	// Use this for initialization
	void Start () {
        asdf = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        float x = asdf.mainTextureOffset.x + ScrollSp * Time.deltaTime;
        Vector2 offset = new Vector2(x, 0);
        asdf.mainTextureOffset = offset;
	
	}
}
