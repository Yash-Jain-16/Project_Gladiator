using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Women_Empowerment.Models
{
    public class MwcdContext:DbContext
    {
        public MwcdContext(DbContextOptions <MwcdContext> options):base(options)
        {

        }   


    }
}
