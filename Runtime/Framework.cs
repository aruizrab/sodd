using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("com.github.aruizrab.sodd.Editor")]

namespace SODD
{
    internal static class Framework
    {
        public const string Root = "SODD/";

        public static class DataTypes
        {
            public const string Void = "Void";

            // Primitive types
            public const string Bool = "Bool";
            public const string Float = "Float";
            public const string Int = "Int";
            public const string String = "String";

            public const string Enum = "Enum";

            // Data structures
            public const string List = "List";

            public const string Dictionary = "Dictionary";

            // Unity data types
            public const string Vector2 = "Vector2";
            public const string Vector3 = "Vector3";
            public const string Color = "Color";
            public const string LayerMask = "LayerMask";

            public const string AudioClip = "Audio Clip";

            // Unity reference types
            public const string GameObject = "GameObject";
            public const string Component = "Component";
            public const string Reference = "Reference";
        }

        public static class MenuOrders
        {
            public const int Void = 0;
            public const int Bool = 11;
            public const int Int = 12;
            public const int Float = 13;
            public const int String = 14;
            public const int Enum = 31;
            public const int Vector2 = 32;
            public const int Vector3 = 33;
            public const int List = 34;
            public const int Dictionary = 35;
            public const int Color = 51;
            public const int LayerMask = 52;
            public const int AudioClip = 53;
            public const int GameObject = 71;
            public const int Component = 72;
            public const int Reference = 73;
        }

        public static class Events
        {
            public const string Path = Root + "Events/";

            public const string Void = Path + "Void";
            public const string Bool = Path + "Bool";
            public const string Float = Path + "Float";
            public const string Int = Path + "Int";
            public const string String = Path + "String";
            public const string Enum = Path + "Enum";
            public const string List = Path + "List";
            public const string Dictionary = Path + "Dictionary";
            public const string Vector2 = Path + "Vector2";
            public const string Vector3 = Path + "Vector3";
            public const string Color = Path + "Color";
            public const string LayerMask = Path + "LayerMask";
            public const string AudioClip = Path + "Audio Clip";
            public const string GameObject = Path + "GameObject";
            public const string Component = Path + "Component";
            public const string Reference = Path + "Reference";
        }
    }
}