using System;
using System.Linq;
using UnityEngine;

public class AudioRecorder : MonoSingleton<AudioRecorder>
{
    private string m_MicDevice;

    private AudioSource m_AudioSource;
    private AudioClip m_AudioClip;
    public AudioSource AudioSource
    {
        set => m_AudioSource = value;
    }

    public bool SetDevice(string device)
    {
        if (Microphone.devices.Contains(device))
        {
            m_MicDevice = device;
        }

        return string.IsNullOrEmpty(m_MicDevice);
    }

    public bool StartRecord()
    {
        if (HasValidDevice())
        {
            m_AudioClip = Microphone.Start(m_MicDevice, true, 10, 44100);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool StopRecord()
    {
        if (HasValidDevice())
        {
            Microphone.End(m_MicDevice);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool PlayRecord()
    {
        if (m_AudioSource == null)
        {
            m_AudioSource = gameObject.GetOrAddComponent<AudioSource>();
        }

        if (m_AudioClip)
        {
            m_AudioSource.clip = m_AudioClip;
            m_AudioSource.Play();
            return true;
        }

        return false;
    }

    public bool SaveRecord()
    {
        throw new NotImplementedException();
    }

    protected override void Awake()
    {
        base.Awake();
        m_MicDevice = Microphone.devices.FirstOrDefault();
    }


    private bool HasValidDevice()
    {
        return !string.IsNullOrEmpty(m_MicDevice);
    }
}
