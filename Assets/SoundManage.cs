using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SoundManage : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
  public void setMasterVolume(float value)
  {
    audioMixer.SetFloat("masterVolume",value);
  }
 
}
