using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenPostTestSurvey()
	{
		#if !UNITY_EDITOR
		openWindow("https://ucsantacruz.co1.qualtrics.com/jfe/form/SV_0eNWbabf4y3LxyZ");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}