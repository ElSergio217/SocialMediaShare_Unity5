// ASCII Encoding Reference:
// http://www.w3schools.com/tags/ref_urlencode.asp
//
//Created by:
//https://twitter.com/elsergio217

using UnityEngine;
using System.Collections;

public class Facebook : MonoBehaviour {

	//Link that redirects if post is clicked on
	public string Link = "https://itunes.apple.com/us/app/circular-force/id1073741949?mt=8";

	//Description that will go along with the link
	public string Description = "Download #CircularForce now!";

	public void Share () {

		//Starting part of URL Link
		string URL = "https://www.facebook.com/sharer/sharer.php?u=";

		//Combine varibles with URL
		string vars = Link + "&description=" + Description;

		//Encodes status to be URL friendly by replacing characters to ASCII
		string Encode = vars.Replace(" ", "%20").Replace("#","%23").Replace("@","%40").Replace(":","%3A");

		//Combine URL and Encode. Opens on Browser
		Application.OpenURL (URL + Encode);
	}
}
