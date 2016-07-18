// ASCII Encoding Reference:
// http://www.w3schools.com/tags/ref_urlencode.asp
//
//Created by:
//https://twitter.com/elsergio217

using UnityEngine;
using System.Collections;

public class Twitter : MonoBehaviour {

	//Tweet you want user to post
	public string status = "Download #CircularForce now! @elsergio217 https://itunes.apple.com/us/app/circular-force/id1073741949";

	public void Share () {
		//Starting part of URL Link
		string URL = "https://twitter.com/home?status=";

		//Encodes status to be URL friendly by replacing characters to ASCII
		string Encode = status.Replace (" ", "%20").Replace("#","%23").Replace("@","%40").Replace(":","%3A");

		//Combine URL and Encode. Opens on Browser
		Application.OpenURL (URL + Encode);
	}
}
