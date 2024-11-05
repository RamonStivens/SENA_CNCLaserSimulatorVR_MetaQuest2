using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source List")]
    public AudioSource _music;
    public AudioSource _ambientNoise;
    public AudioSource _ambientNature;
    public AudioSource _sfx;
    public AudioSource _ui;
    public AudioSource _laserEngineLoop;
    public AudioSource _laserEngineSFX;
    public AudioSource _vozEnOffIA;

    [Header("Audio Clips List")]
    public AudioClip laserOnLoop;
    public AudioClip laserOff;
    public AudioClip laserWorking;

    public AudioClip music1;

    public AudioClip noiseAmbient;
    public AudioClip natureAmbient;

    public AudioClip breaker;
    public AudioClip buttonExtractor;
    public AudioClip buttonRefrigerator;
    public AudioClip buttonLaserMachine;
    public AudioClip openCover;

    public AudioClip laptopOn;

    public AudioClip WelcomeIA;

    private void Start()
    {
        _music.clip = music1;
        _music.Play();
        _ambientNoise.clip = noiseAmbient;
        _ambientNoise.Play();
        _ambientNature.clip = natureAmbient;
        _ambientNature.Play();

        StartCoroutine(PlayWelcomeVoiceOverIA());
    }

    public void PlayBreakerSound()
    {
        _sfx.clip = breaker;
        _sfx.Play();
    }

    public void PlayButtonExtractorSound()
    {
        _sfx.clip = buttonExtractor;
        _sfx.Play();
    }
    public void PlayButtonRefrigeratorSound()
    {
        _sfx.clip = buttonRefrigerator;
        _sfx.Play();
    }
    public void PlayButtonLaserMachineSound()
    {
        _sfx.clip = buttonLaserMachine;
        _sfx.Play();
    }
    public void PlayTouchCoverSound()
    {
        _sfx.clip = openCover;
        _sfx.Play();
    }
    public void PlayLaptopOnSound()
    {
        _sfx.clip = laptopOn;
        _sfx.Play();
    }
    public void PlayLaserEngineLoop()
    {
        _laserEngineLoop.clip = laserOnLoop;
        _laserEngineLoop.Play();
    }

    public void StopLaserEngineLoop()
    {
        _laserEngineLoop.Stop();
    }
    public void PlayLaserEnginePowerOff()
    {
        _laserEngineSFX.clip = laserOff;
        _laserEngineSFX.Play();
    }
    public void PlayLaserEngineWorking()
    {
        _laserEngineSFX.clip = laserWorking;
        _laserEngineSFX.Play();
    }

    public void PlayWelcomeIA()
    {
        _vozEnOffIA.clip = WelcomeIA;
        _vozEnOffIA.Play();
    }

    private IEnumerator PlayWelcomeVoiceOverIA()
    {
        yield return new WaitForSeconds(7f); // Espera 7 segundos
        _vozEnOffIA.clip = WelcomeIA;
        _vozEnOffIA.Play(); // Inicia el audio
    }
}
