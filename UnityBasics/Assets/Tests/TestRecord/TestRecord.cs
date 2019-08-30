using UnityEngine;
using System.Linq;

public class TestRecord : MonoBehaviour 
{


	void Start() {


    }

	void OnGUI()
	{
		if (GUILayout.Button ("<size=50>开始录音</size>"))
        {
            AudioRecorder.Instance.StartRecord();

        }
		if (GUILayout.Button ("<size=50>结束录音</size>"))
        {
            AudioRecorder.Instance.StopRecord();
        }

		if (GUILayout.Button ("<size=50>播放保存录音</size>"))
        {
            AudioRecorder.Instance.PlayRecord();
        }
	}

}
