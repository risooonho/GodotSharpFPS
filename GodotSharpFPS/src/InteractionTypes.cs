﻿
namespace GodotSharpFps.src
{
    public enum TouchType
    {
        None, Solid, Bullet, Thrown, Explosion
    }

    public enum TouchResponseType
    {
        None, Damaged, Killed
    }

    public struct TouchData
    {
        public TouchType touchType;
        public int teamId;
        public int damage;
    }

    public struct TouchResponseData
    {
        public TouchResponseType responseType;
        public int damageTaken;

        public static TouchResponseData empty
        {
            get
            {
                return new TouchResponseData
                {
                    responseType = TouchResponseType.None,
                    damageTaken = 0
                };
            }
        }
    }

    public interface IActor
    {
        TouchResponseData ActorTouch(TouchData touchData);
    }

    public interface IActorProvider
    {
        IActor GetActor();
    }
}
