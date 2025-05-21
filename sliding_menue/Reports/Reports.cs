using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sliding_menue.Reports
{
    
    class Reports
    {
        clincEntities db = new clincEntities();
        void report()
        {
            var reps = from v in db.vists
                       join pt in db.patients
                       on v.FKpt_id equals pt.pt_id
                       //where pt.pt_id == Convert.ToInt32(zz.getinstance.gridVisits.CurrentRow.Cells[2].Value)
                       select new
                       {
                           vId = v.visit_id,
                           vDate = v.visitDate,
                           id = pt.pt_id,
                           name = pt.pt_name
                       };
        }
    }
}
