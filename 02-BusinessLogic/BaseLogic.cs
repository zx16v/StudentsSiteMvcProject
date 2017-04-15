using System;

namespace ShimiTest
{
    public abstract class BaseLogic : IDisposable
    {
        public readonly pupilsEntities DB = new pupilsEntities();

        public void Dispose()
        {

            DB.Dispose();
        }


    }
}
