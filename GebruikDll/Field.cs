using CODE_TempleOfDoom_DownloadableContent;
using System.Reflection.Metadata.Ecma335;

namespace GebruikDll
{
    internal class Field : IField
    {
        int v1 = 0;
        public Field(int v1, int v2)
        {
        }

        public bool CanEnter => true;

        public IPlacable Item {
            get => null;
            set => v1 = 0;
             }

        public IField GetNeighbour(int direction)
        {
            return null;
        }
    }
}