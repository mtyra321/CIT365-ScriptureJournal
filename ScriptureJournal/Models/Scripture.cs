using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class Scripture
    {


        public int ID { get; set; }
        

        public string Book { get; set; }


        public int Chapter { get; set; }


        public int Verse { get; set; }

        public string Notes { get; set; }

        public DateTime CreatedDate { get; set; }



    }
}
