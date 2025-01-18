using System.Collections;
using UnityEngine;
using UnityEngine.Internal;

namespace Assets.Scripts.CounterComponent.Interfaces
{
    public interface ICoroutineRunner
    {
        public Coroutine StartCoroutine(string methodName);

        public Coroutine StartCoroutine(IEnumerator coroutine);

        public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value);
    }
}
