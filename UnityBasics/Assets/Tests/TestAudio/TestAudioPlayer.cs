using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class TestAudioPlayer : MonoBehaviour 
{
	public AudioClip clip1;
	public AudioClip clip2;

    public AudioPlayer audioPlayer;

	void OnGUI()
	{

		if (GUILayout.Button ("<size=50>播放音频1</size>")) {
			audioPlayer.PlayAudioClip (clip1,delegate(AudioClip clip) {
				Debug.LogFormat("音频：{0}播放结束",clip.name);
			});
			
		}
		if (GUILayout.Button ("<size=50>播放音频2</size>")) {
			audioPlayer.PlayAudioClip (clip2,delegate(AudioClip clip) {
				Debug.LogFormat("音频：{0}播放结束",clip.name);
			});
		}
	}

}
