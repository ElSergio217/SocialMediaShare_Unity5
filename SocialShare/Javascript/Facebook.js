#pragma strict
// ASCII Encoding Reference:
// http://www.w3schools.com/tags/ref_urlencode.asp
//
//Created by:
//https://twitter.com/elsergio217


//Link that redirects if post is clicked on
var Link : String = "https://itunes.apple.com/us/app/circular-force/id1073741949?mt=8";

//Description that will go along with the link
var Description : String = "Download #CircularForce now!";

function Share () {

	//Starting part of URL Link
	var URL = "https://www.facebook.com/sharer/sharer.php?u=";

	//Combine varibles with URL
	var vars = Link + "&description=" + Description;

	//Encodes status to be URL friendly by replacing characters to ASCII
	var Encode = vars.Replace(" ", "%20").Replace("#","%23").Replace("@","%40").Replace(":","%3A");

	//Combine URL and Encode. Opens on Browser
	Application.OpenURL (URL + Encode);
}