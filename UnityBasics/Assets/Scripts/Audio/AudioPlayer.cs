using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    public AudioSource source;
    private Coroutine m_Coroutine = null;

    public void Awake()
    {
        source = gameObject.GetOrAddComponent<AudioSource>();
    }


    public void PlayAudioClip(AudioClip clip, UnityAction<AudioClip> callback)
    {
        StopAudioClip();
        source.clip = clip;
        source.Play();
        m_Coroutine = StartCoroutine(AduioClipCallback(clip, callback));
    }

    void StopAudioClip()
    {
        if (m_Coroutine != null)
        {
            StopCoroutine(m_Coroutine);
            m_Coroutine = null;
        }
        source.Stop();
    }

    private IEnumerator AduioClipCallback(AudioClip clip, UnityAction<AudioClip> callback)
    {
        yield return new WaitForSeconds(clip.length);
        callback(clip);
    }

}
