using System;

namespace ObserverPattern.Case2.Base1 {
  /// <summary>
  ///   * [The 'Observer' contract]
  /// </summary>
  public interface ICountObserver {
    void OnCountChanged(int count);
  }

  [Serializable]
  public class ICountObserverContainer : IUnifiedContainer<ICountObserver> {
  }
}