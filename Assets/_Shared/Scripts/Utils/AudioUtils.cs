using UnityEngine;

public static class AudioUtils {
  /// <summary>
  ///   Play by AudioSource from GameManager
  /// </summary>
  public static void PlayOneShot(this AudioClip audioClip) {
    if (!audioClip) return;
    // ! GameManager coupled
    GameManager.Instance.audioSource.PlayOneShot(audioClip);
  }

  /// <summary>
  ///   Play the audio source if the given condition is true. 
  /// </summary>
  public static void Play(this AudioSource audioSource, bool @if) {
    if (@if) audioSource.Play();
  }

  /// <summary>
  ///   Play one shot the given clip if the given condition is true.
  /// </summary>
  public static void PlayOneShot(this AudioSource audioSource, AudioClip audioClip, bool @if) {
    if (@if) audioSource.PlayOneShot(audioClip);
  }

  /// <summary>
  ///   Trigger playing music if the source is not playing && the given condition is true.
  /// </summary>
  public static void PlayIfStopped(this AudioSource audioSource, AudioClip clip, bool @if = true) {
    if (!@if) return;

    audioSource.clip = clip;
    if (!audioSource.isPlaying) audioSource.Play();
  }

  /// <summary>
  ///   Trigger playing audio if the source is not playing && the given condition is true. <br />
  ///   If the condition is false, stop the audio source.
  /// </summary>
  public static void PlayOrStop(this AudioSource audioSource, AudioClip clip, bool @if = true) {
    if (@if)
      audioSource.PlayIfStopped(clip);
    else
      audioSource.Stop();
  }
}