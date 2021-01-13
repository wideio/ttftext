//  Unity TTF Text
//  Copyrights 2011-2012 ComputerDreams.org O. Blanc & B. Nouvel
//  All infos related to this software at http://ttftext.computerdreams.org/
//   

using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
[AddComponentMenu("Text/Extra/Set Material Color")]
public class TTFTextExtra_SetMaterialColor : MonoBehaviour {
	public Color color;
	Material savedMat;
	Material newMat;
	
	// Use this for initialization
	void Start () {
		if ((GetComponent<Renderer>()!=null)&&(GetComponent<Renderer>().sharedMaterial!=null)) {
		  savedMat=GetComponent<Renderer>().sharedMaterial;	
	   	  color=GetComponent<Renderer>().sharedMaterial.color;
		  GetComponent<Renderer>().material=newMat=new Material(savedMat);
		  newMat.color=color;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (newMat==null) {Start();}
		if (newMat!=null) {
			if (newMat.color!=color) {
				newMat.color=color;
				//renderer.material=new Material()
			}
		}
	}
}