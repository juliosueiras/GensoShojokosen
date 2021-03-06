﻿using UnityEngine;

namespace Genso.API {

    public interface ICharacterInput {


        Vector2 Movement { get; }

        bool Jump { get; }

        bool Crouch { get; }

        bool Attack { get; }

    }

}