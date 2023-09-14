using Unity.VisualScripting;
using UnityEngine;

namespace ShadowCoder.Extensions
{
    public static class Extensions
    {
        public static string LogPrefix(this object o, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            var firstChar = o.GetType().Name.ToUpper()[0];
            var index = firstChar - 64;
            index--;

            Debug.Log($"{nameof(Extensions)} (LogPrefix) index = {index}");

            var rFactor = 1f;
            var gFactor = 1f;
            var bFactor = 1f;

            if (index == 0) 
            {
                rFactor = 0f;
            }
            else if (index < 9)
            {
                rFactor = 1f / (9 - index);
            }
            else if (index == 9)
            {
                gFactor = 0f;
            }
            else if (index < 18)
            {
                gFactor = 1f / (9 - (index - 9));
            }
            else if (index == 18)
            {
                bFactor = 0f;
            }
            else
            {
                bFactor = 1f / (8 - (index - 18));
            }


            var logColor = new Color(rFactor, gFactor, bFactor, 1);

            return $"[<color=#{logColor.ToHexString()}>{o.GetType().Name}] ({memberName})</color>";
        }
    }
}