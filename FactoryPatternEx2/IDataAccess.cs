using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2
{
    public interface IDataAccess
    {
        public void LoadData();
        public void SaveData();
    }
}
