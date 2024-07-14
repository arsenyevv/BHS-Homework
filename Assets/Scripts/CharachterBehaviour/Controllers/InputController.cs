
using UnityEngine;

namespace BHS
{
    public abstract class InputController : ScriptableObject    //че означает двоеточие 
    {
        public abstract float RetrieveMoveInput(); //почему флоат 
        public abstract bool RetrieveJumpInput();
    }
}