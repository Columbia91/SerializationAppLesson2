using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAppLesson
{
    [Serializable]
    class User
    {
        [NonSerialized]
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
