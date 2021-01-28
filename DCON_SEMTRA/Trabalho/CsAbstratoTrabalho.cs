
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public abstract class CsAbstratoTrabalho
    {
        public string SqlCommand { get; set; }

        public abstract void InsertObjTrans(object objTrans);
        public abstract void UpdateObjTrans(object objTrans);
        public abstract void DeleteObjTrans(object objTrans);

        public abstract void SeacherObjTrans(string where);

    }
}
